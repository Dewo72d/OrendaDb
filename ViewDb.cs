using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace CookParse
{
    public partial class ViewDb : Form
    {
        public ViewDb()
        {
            InitializeComponent();
            loadData();
        }

        // private SQLiteConnection DataBase;
        private void loadData()
        {
            dataGridView1.AllowUserToAddRows = false;

            //Загрузка данных
            SQLiteConnection DataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3;DateTimeFormat=Ticks;");
            DataBase.Open();

            string allDb = "SELECT * FROM inputForm";
            string apartDb = "SELECT apartamentId, rooms, sleepPlaces, street, apartNum FROM apartament, inputForm WHERE inputForm.idApart = apartament.apartamentId";
            SQLiteCommand command = new SQLiteCommand(allDb, DataBase);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[10]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString().Substring(0, 10);
                data[data.Count - 1][8] = reader[8].ToString().Substring(0, 10);
                data[data.Count - 1][9] = reader[9].ToString();
            }

            SQLiteCommand command1 = new SQLiteCommand(apartDb, DataBase);
            SQLiteDataReader reader1 = command1.ExecuteReader();

            List<string[]> data1 = new List<string[]>();
            while (reader1.Read())
            {
                data1.Add(new string[5]);

                data1[data1.Count - 1][0] = reader1[0].ToString();
                data1[data1.Count - 1][1] = reader1[1].ToString();
                data1[data1.Count - 1][2] = reader1[2].ToString();
                data1[data1.Count - 1][3] = reader1[3].ToString();
                data1[data1.Count - 1][4] = reader1[4].ToString();

                Console.WriteLine(reader1[3]);
            }

            
                //string outDate = string.Concat($"id: {comboBox2.Items.Add(reader1[0].ToString())} |", $" Количество комнат: {comboBox2.Items.Add(reader1[1].ToString())} |", $" Количество спальных мест: {comboBox2.Items.Add(reader1[2].ToString())} |", $" Улица: {comboBox2.Items.Add(reader1[3].ToString())} | ", $"Номер квартиры: {comboBox2.Items.Add(reader1[4].ToString())}");
                // comboBox2.Items.Add(outDate);
           

            reader.Close();
            reader1.Close();
            DataBase.Close();

            foreach (string[] d in data)
                dataGridView1.Rows.Add(d);



                for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string idApart = dataGridView1.Rows[i].Cells[1].Value.ToString();

                DateTime dateStartConvert = DateTime.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                DateTime dateOutConvert = DateTime.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                //  Получаем сутки
                TimeSpan diff = dateOutConvert.Subtract(dateStartConvert);
                // Обрезка лишнего
                string diffString = diff.ToString();
                int l = diffString.LastIndexOf('.');
                l = (l == -1) ? l = 0 : l = l;
                diffString = diffString.Substring(0, l);
                diffString = (diffString == "") ? diffString = "0" : diffString = diffString;
                // Общая сумма
                int diffInt = Convert.ToInt32(diffString);
                int moneyInt = Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value);
                int totalSum = moneyInt * diffInt;
                //totalSum = (totalSum == 0) ? totalSum = moneyInt : totalSum = 000;

                string outDate = string.Concat($" id: {id} |", $" Количество суток: {diffString} |", $" Цена за сутки: {moneyInt} |", $" Общая сумма: {totalSum} | ", $"КвартираId: {idApart}");
                comboBox1.Items.Add(outDate);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Проверка на int
            int i = 0;
            try
            {
                Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value);
            }
            catch
            {   
                i++;
            }

            switch (i) 
            {
                case 1:
                    MessageBox.Show("Введите id квартиры", "error", MessageBoxButtons.OK);
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

                    SqlComand.CommandText = $"UPDATE inputForm SET {selcRow} = @selcCell WHERE id = @selсId";
                    SqlComand.ExecuteNonQuery();
                    dataBase.Close();
                    break;
            }
        }



        private void Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comboBox1.Items.Clear();

            SQLiteConnection DataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3;DateTimeFormat=Ticks;");
            DataBase.Open();
            string allDb = "SELECT * FROM inputForm";
            SQLiteCommand command = new SQLiteCommand(allDb, DataBase);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[10]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString().Substring(0, 10);
                data[data.Count - 1][8] = reader[8].ToString().Substring(0, 10);
                data[data.Count - 1][9] = reader[9].ToString();
            }

            reader.Close();
            DataBase.Close();

            foreach (string[] d in data)
                dataGridView1.Rows.Add(d);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string idApart = dataGridView1.Rows[i].Cells[1].Value.ToString();

                DateTime dateStartConvert = DateTime.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                DateTime dateOutConvert = DateTime.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                //  Получаем сутки
                TimeSpan diff = dateOutConvert.Subtract(dateStartConvert);
                // Обрезка лишнего
                string diffString = diff.ToString();
                int l = diffString.LastIndexOf('.');
                l = (l == -1) ? l = 0 : l = l;
                diffString = diffString.Substring(0, l);
                diffString = (diffString == "") ? diffString = "0" : diffString = diffString;
                // Общая сумма
                int diffInt = Convert.ToInt32(diffString);
                int moneyInt = Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value);
                int totalSum = moneyInt * diffInt;
               // totalSum = (totalSum == 0) ? totalSum = moneyInt : totalSum = 000;

                string outDate = string.Concat($" id: {id} |", $" Количество суток: {diffString} |", $" Цена за сутки: {moneyInt} |", $" Общая сумма: {totalSum} | ", $"КвартираId: {idApart}");
                comboBox1.Items.Add(outDate);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            Help goHelp = new Help();

            goHelp.ShowDialog();
        }

        private void showPic_Click(object sender, EventArgs e)
        {
            try
            {
                var pic = dataGridView1.CurrentCell.Value.ToString();
                pictureBox1.Image = Image.FromFile(@"pic\" + pic);
            }
            catch
            {
                MessageBox.Show("Изображение не найдено или не существует", "error", MessageBoxButtons.OK);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SQLiteConnection dataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3;DateTimeFormat=Ticks;");
            dataBase.Open();

            var selcId = dataGridView1.CurrentRow.Cells[0].Value;
            SQLiteCommand SqlComand = dataBase.CreateCommand();

            SqlComand.CommandText = $"DELETE FROM inputForm WHERE id = {selcId};";
            SqlComand.ExecuteNonQuery();
            dataBase.Close();
        }
    }
}
