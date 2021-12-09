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

namespace DBPresent.DoctorVC
{
    public partial class AddDoctor : Form
    {
        private bool addButtonClicked = false;
        public AddDoctor()
        {
            InitializeComponent();
            SetScreen();
            SetComboBox();
            FormClosing -= AddButton_Click;
        }

        private void SetScreen()
        {
            AddButton.Text = "Add";
            NameTB.PlaceholderText = "Enter";
            NameLabel.Text = "Name";
            IdSpecLabel.Text = "SpecId";
        }

        private void SetComboBox()
        {
            IdSpecComboBox.Items.Clear();
            IdSpecComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var item in Core.GetNameByIdSpecialization())
            {
                IdSpecComboBox.Items.Add(item);
            }
            IdSpecComboBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Double.TryParse((NameTB.Text), out var _))
            {
                MessageBox.Show("Numbers? Real? Update name!!!", "Numbers");
            }
            else if (NameTB.Text.Length == 0)
            {
                MessageBox.Show("Please, write name", "Name", MessageBoxButtons.OK);
            }
            else
            {
                var id = Core.GetContext().Specializations.Where(p => p.Name == IdSpecComboBox.SelectedItem).FirstOrDefault().Id;
                Core.AddToDB(NameTB.Text, id);
                addButtonClicked = true;
                Close();
            }
        }

        private void AddDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!addButtonClicked)
            {
                var check = MessageBox.Show("Are you sure? Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                e.Cancel = check == DialogResult.No;
            }
        }
    }
}
