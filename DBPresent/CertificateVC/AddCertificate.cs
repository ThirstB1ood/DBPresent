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

namespace DBPresent.CertificateVC
{
    public partial class AddCertificate : Form
    {
        private bool addButtonClicked = false;

        public AddCertificate()
        {
            InitializeComponent();
            SetScreen();
            SetComboBox();
            FormClosing -= AddButton_Click;
        }

        private void SetScreen()
        {
            AddButton.Text = "Add";
            DescriptionTB.PlaceholderText = "Enter";
            DescriptionLabel.Text = "Description";
            DoctorIdLabel.Text = "Id";
            DateLabel.Text = "Date";
            DatePicker.Value = DateTime.Now;
        }

        private void SetComboBox()
        {
            DoctorIdComboBox.Items.Clear();
            DoctorIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var item in Core.GetNameByIdDoctors())
            {
                DoctorIdComboBox.Items.Add(item);
            }
            DoctorIdComboBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (DescriptionTB.Text.Length == 0)
            {
                MessageBox.Show("Where is description?", "Description");
            }
            else if(Double.TryParse(DescriptionTB.Text, out var _))
            {
                MessageBox.Show("Numbers? Real? Update name!!!", "Numbers");
            }
            else
            {
                var id = Core.GetContext().Doctors.Where(p => p.Name == DoctorIdComboBox.SelectedItem).FirstOrDefault().Id;
                Core.AddToDB(id, DescriptionTB.Text, DatePicker.Value);
                addButtonClicked = true;
                Close();
            }
        }

        private void AddCertificate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!addButtonClicked)
            {
                var check = MessageBox.Show("Are you sure? Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                e.Cancel = check == DialogResult.No;
            }
        }
    }
}
