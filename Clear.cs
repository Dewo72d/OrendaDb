using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CookParse
{
    public partial class Clear : Form
    {
        public Clear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string absolutPath = Application.StartupPath.ToString() + @"\pic";
            bool checkDir = Directory.Exists(absolutPath);

            try
            {
                if (checkDir)
                {
                    Directory.Delete(absolutPath, true);
                    Directory.CreateDirectory(absolutPath);
                    MessageBox.Show("Успешно!", "Complite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Directory.CreateDirectory(absolutPath);
                }
            }

            catch
            {
                MessageBox.Show("Ошибка!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection DataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3;DateTimeFormat=Ticks;");
                DataBase.Open();

                string allDb = "DELETE FROM inputForm";
                SQLiteCommand command = new SQLiteCommand(allDb, DataBase);
                command.ExecuteNonQuery();

                MessageBox.Show("Успешно!", "Complite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Console.WriteLine("Ошибка!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection DataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3;DateTimeFormat=Ticks;");
                DataBase.Open();

                string allDb = "DELETE FROM apartament";
                SQLiteCommand command = new SQLiteCommand(allDb, DataBase);
                command.ExecuteNonQuery();

                MessageBox.Show("Успешно!", "Complite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Console.WriteLine("Ошибка!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help2 help2 = new Help2();
            help2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
