using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CookParse
{
    public partial class ApartamentInput : Form
    {
        private SQLiteConnection DataBase = new SQLiteConnection(@"Data Source=db/UsersDB.db;Version=3");

        public ApartamentInput()
        {   
            InitializeComponent();
        }

        public void sambitButton_Click(object sender, EventArgs e)
        {

            string street = streetBox.Text.Trim();
            string apartNum = numOfApart.Text.Trim();
            string rooms = numOfRooms.Text.Trim();
            string sleepPlace = numOfsp.Text.Trim();
            string level = levelBox.Text.Trim();

            if (String.IsNullOrWhiteSpace(street) == false || String.IsNullOrWhiteSpace(apartNum) == false || String.IsNullOrWhiteSpace(rooms) == false || String.IsNullOrWhiteSpace(sleepPlace) == false)
            {
                
                DataBase.Open();
                SQLiteCommand SqlComand =  DataBase.CreateCommand();
                SqlComand.Parameters.Add("@street", DbType.String).Value = street;
                SqlComand.Parameters.Add("@apartNum", DbType.Int32).Value = apartNum;
                SqlComand.Parameters.Add("@rooms", DbType.Int32).Value = rooms;
                SqlComand.Parameters.Add("@sleepPlace", DbType.Int32).Value = sleepPlace;
                SqlComand.Parameters.Add("@level", DbType.Int32).Value = level;

                SqlComand.CommandText = "insert into apartament(street, apartNum, rooms, sleepPlaces, level) values(@street, @apartNum, @rooms, @sleepPlace, @level)";

                SqlComand.ExecuteNonQuery();
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("Заполните поля", "error", MessageBoxButtons.OK);
            };
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}
