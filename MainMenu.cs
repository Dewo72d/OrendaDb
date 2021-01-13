using System;
using System.Windows.Forms;

namespace CookParse
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void buttonInputID_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.ShowDialog();
        }

        private void buttonViewDb_Click(object sender, EventArgs e)
        {
            ViewDb viewDb = new ViewDb();
            viewDb.ShowDialog();
        }
        private void apartButton_Click(object sender, EventArgs e)
        {
            ApartamentInput apartamentInput = new ApartamentInput();
            apartamentInput.ShowDialog();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ApartVbutton_Click(object sender, EventArgs e)
        {
            ApartamentDb apartamentDb = new ApartamentDb();
            apartamentDb.ShowDialog();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear clearCh = new Clear();
            clearCh.ShowDialog();
        }
    }
}
