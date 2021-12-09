using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreDB;

namespace DBPresent.SpecializationVC
{
    public partial class AddSpecialization : Form
    {

        private bool addButtonClicked = false;
        public AddSpecialization()
        {
            InitializeComponent();
            SetScreen();
            FormClosing -= AddButton_Click;
        }

        private void SetScreen()
        {
            AddButton.Text = "Add";
            NameTB.PlaceholderText = "Enter";
            NameLabel.Text = "Name";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(Double.TryParse((NameTB.Text), out var a))
            {
                MessageBox.Show("Numbers? Real? Update name!!!", "Numbers");

            } 
            else if (NameTB.Text == "")
            {
                MessageBox.Show("Please, write name", "Name", MessageBoxButtons.OK);
            }
            else
            {
                Core.AddToDB(NameTB.Text);
                addButtonClicked = true;
                Close();
            }
        }

        private void AddSpecialization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!addButtonClicked)
            {
                var check = MessageBox.Show("Are you sure? Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                e.Cancel = check == DialogResult.No;
            }
           
        }
    }
}
