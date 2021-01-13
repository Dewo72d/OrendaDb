using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CookParse
{
    public partial class ApartamentDb : Form
    {
        public ApartamentDb()
        {
            InitializeComponent();
            loadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void loadData()
        {
            dataGridView1.AllowUserToAddRows = false;

            //Загрузка данных
            SQLiteConnection DataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3;DateTimeFormat=Ticks;");
            DataBase.Open();

            string allDb = "SELECT * FROM apartament";
            SQLiteCommand command = new SQLiteCommand(allDb, DataBase);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();
            DataBase.Close();

            foreach (string[] d in data)
                dataGridView1.Rows.Add(d);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Проверка на int
            int i = 0;
            try
            {
                Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value);
                Convert.ToInt16(dataGridView1.CurrentRow.Cells[2].Value);
                Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value);
                Convert.ToInt16(dataGridView1.CurrentRow.Cells[5].Value);
            }
            catch
            {
                i++;
            }

            switch (i)
            {
                case 1:
                    MessageBox.Show("Введите цифровое значение ", "error", MessageBoxButtons.OK);
                    break;
                case 0:
                    //id указанной строки
                    SQLiteConnection dataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3;DateTimeFormat=Ticks;");
                    dataBase.Open();

                    //id указанной строки
                    var selcId = dataGridView1.CurrentRow.Cells[0].Value;
                    // указанная строка
                    var selcCell = dataGridView1.CurrentCell.Value.ToString();
                    //Имя столбца
                    var selcRow = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name.ToString();


                    SQLiteCommand SqlComand = dataBase.CreateCommand();
                    SqlComand.Parameters.Add("@selcCell", DbType.String).Value = selcCell;
                    SqlComand.Parameters.Add("@selсId", DbType.String).Value = selcId;
                    SqlComand.Parameters.Add("@selcRow", DbType.String).Value = selcRow;


                    SqlComand.CommandText = $"UPDATE apartament SET {selcRow} = @selcCell WHERE apartamentId = @selсId";
                    SqlComand.ExecuteNonQuery();
                    dataBase.Close();
                    break;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            SQLiteConnection DataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3;DateTimeFormat=Ticks;");
            DataBase.Open();
            string allDb = "SELECT * FROM apartament";
            SQLiteCommand command = new SQLiteCommand(allDb, DataBase);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();

            }


            reader.Close();
            DataBase.Close();

            foreach (string[] d in data)
                dataGridView1.Rows.Add(d);
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SQLiteConnection dataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3;DateTimeFormat=Ticks;");
            dataBase.Open();

            var selcId = dataGridView1.CurrentRow.Cells[0].Value;
            SQLiteCommand SqlComand = dataBase.CreateCommand();

            SqlComand.CommandText = $"DELETE FROM apartament WHERE apartamentid = {selcId};";
            SqlComand.ExecuteNonQuery();
            dataBase.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            Help1 goHelp = new Help1();

            goHelp.ShowDialog();
        }
    }
}
