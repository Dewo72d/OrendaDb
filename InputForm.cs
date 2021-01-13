using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CookParse
{
    public partial class InputForm : Form
    {
        private SQLiteConnection DataBase;
        public InputForm()
        {
            InitializeComponent();
        }

        public void InputForm_Load(object sender, EventArgs e)
        {
            DataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3");
            DataBase.Open();

            string allDb = "SELECT * FROM apartament";
            SQLiteCommand command = new SQLiteCommand(allDb, DataBase);
            SQLiteDataReader reader = command.ExecuteReader();

            

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        int checkEntry = 0;
        public void downloadPhotoButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP; *.JPG; *.PNG)|*.BMP; *.JPG; *.PNG";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxUser.Image = new Bitmap(ofd.FileName);
                    checkEntry++;
                }
                catch
                {

                    MessageBox.Show("Невозможно открыть этот файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }         
        }

        public void addNum_Click(object sender, EventArgs e)
        {
            if (oterNumTextBox.Visible == false)
            {
                oterNumTextBox.Visible = true;               
            };
        }
        private void delNum_Click(object sender, EventArgs e)
        {
            if (oterNumTextBox.Visible == true)
            {
                oterNumTextBox.Visible = false;                
                oterNumTextBox.Text = "";                
            };
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // Oтправка в Базу

        private void sendForm_Click(object sender, EventArgs e)
        {
            string doneNameImg;

            switch (checkEntry)
            {
                case 0:

                    string doneNameImg1 = "Изображение отсутствует";
                    string doneNameImgSql1 = doneNameImg1;
                    string idSql1 = comboBox1.Text;
                    string textFIOSql1 = textFIO.Text;
                    string textNumSql1 = textNum.Text;
                    string otherNumSql1 = oterNumTextBox.Text;
                    string noteTextBoxSql1 = textBoxNote.Text;
                    string dateStartSql1 = dateTimePicker.Value.Ticks.ToString();
                    string dateOutSql1 = dateTimePicker1.Value.Ticks.ToString();
                    string moneySql1 = inputMoney.Text;

                    if (oterNumTextBox.Text.Contains("(38 )") && textNum.Text.Contains("(38 )"))
                    {
                        MessageBox.Show("Заполните корректно поля номеров", "error", MessageBoxButtons.OK);
                    }

                    else
                      if (String.IsNullOrWhiteSpace(textFIOSql1) == false || String.IsNullOrWhiteSpace(textNumSql1) == false || String.IsNullOrWhiteSpace(noteTextBoxSql1) == false)
                      {
                        SQLiteCommand SqlComand = DataBase.CreateCommand();
                        SqlComand.Parameters.Add("@idSql1", DbType.String).Value = idSql1;
                        SqlComand.Parameters.Add("@doneNameImgSql1", DbType.String).Value = doneNameImgSql1;
                        SqlComand.Parameters.Add("@textFIOSql1", DbType.String).Value = textFIOSql1;
                        SqlComand.Parameters.Add("@textNumSql1", DbType.String).Value = textNumSql1;
                        SqlComand.Parameters.Add("@otherNumSql1", DbType.String).Value = otherNumSql1;
                        SqlComand.Parameters.Add("@textBoxNoteSql1", DbType.String).Value = noteTextBoxSql1;
                        SqlComand.Parameters.Add("@dateStartSql1", DbType.String).Value = dateStartSql1;
                        SqlComand.Parameters.Add("@dateOutSql1", DbType.String).Value = dateOutSql1;
                        SqlComand.Parameters.Add("@moneySql1", DbType.String).Value = moneySql1;

                        SqlComand.CommandText = "insert into inputForm(fio, number, info, oterNum0, pathImg, dateStart, dateOut, money, idApart) values(@textFIOSql1, @textNumSql1, @textBoxNoteSql1, @otherNumSql1, @doneNameImgSql1, @dateStartSql1, @dateOutSql1, @moneySql1, @idSql1)";

                        SqlComand.ExecuteNonQuery();
                        MessageBox.Show("Успешно");
                      }
                    else
                    {
                        MessageBox.Show("Заполните поля", "error", MessageBoxButtons.OK);
                    };
                    break;



                case 1:

                    //Сохранение картинки

                    //Имя картинки
                    Random rnd = new Random();
                    var rndNum = rnd.Next(999, 9999);
                    var rndInt = Convert.ToInt32(rndNum);
                    doneNameImg = rndInt.ToString() + ".png";
                    //Полет в директорию
                    string path = @"\pic";
                    string currentPath = Directory.GetCurrentDirectory() + path;
                    string fullPath = Path.Combine(currentPath, doneNameImg);
                    pictureBoxUser.Image.Save(fullPath, ImageFormat.Jpeg);


                    string doneNameImgSql = doneNameImg;
                    string idSql = comboBox1.Text;
                    string textFIOSql = textFIO.Text;
                    string textNumSql = textNum.Text;
                    string otherNumSql = oterNumTextBox.Text;
                    string noteTextBoxSql = textBoxNote.Text;
                    string dateStartSql = dateTimePicker.Value.Ticks.ToString();
                    string dateOutSql = dateTimePicker1.Value.Ticks.ToString();
                    string moneySql = inputMoney.Text;

                    if (oterNumTextBox.Text.Contains("(38 )") && textNum.Text.Contains("(38 )"))
                    {
                        MessageBox.Show("Заполните корректно поля номеров", "error", MessageBoxButtons.OK);
                    }

                    else
                  if (String.IsNullOrWhiteSpace(textFIOSql) == false || String.IsNullOrWhiteSpace(textNumSql) == false || String.IsNullOrWhiteSpace(noteTextBoxSql) == false)
                    {
                        SQLiteCommand SqlComand = DataBase.CreateCommand();
                        SqlComand.Parameters.Add("@idSql", DbType.String).Value = idSql;
                        SqlComand.Parameters.Add("@doneNameImgSql", DbType.String).Value = doneNameImgSql;
                        SqlComand.Parameters.Add("@textFIOSql", DbType.String).Value = textFIOSql;
                        SqlComand.Parameters.Add("@textNumSql", DbType.String).Value = textNumSql;
                        SqlComand.Parameters.Add("@otherNumSql", DbType.String).Value = otherNumSql;
                        SqlComand.Parameters.Add("@textBoxNoteSql", DbType.String).Value = noteTextBoxSql;
                        SqlComand.Parameters.Add("@dateStartSql", DbType.String).Value = dateStartSql;
                        SqlComand.Parameters.Add("@dateOutSql", DbType.String).Value = dateOutSql;
                        SqlComand.Parameters.Add("@moneySql", DbType.String).Value = moneySql;

                        SqlComand.CommandText = "insert into inputForm(fio, number, info, oterNum0, pathImg, dateStart, dateOut, money,idApart) values(@textFIOSql, @textNumSql, @textBoxNoteSql, @otherNumSql, @doneNameImgSql, @dateStartSql, @dateOutSql, @moneySql, @idSql)";

                        SqlComand.ExecuteNonQuery();
                        MessageBox.Show("Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Заполните поля", "error", MessageBoxButtons.OK);
                    };

                    break;
            }
        }
    }
}
