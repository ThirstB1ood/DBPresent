using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseModels.Certificates;
using CoreDB;

namespace DBPresent.CertificateVC
{
    public partial class UpdateCertificate : Form
    {
        private Certificate certificate;

        private bool updateButtonClicked = false;
        public UpdateCertificate(Certificate _certificate)
        {
            InitializeComponent();
            certificate = _certificate;
            SetScreen();
            SetComboBox();
            FormClosing -= UpdateButton_Click;
        }

        private void SetScreen()
        {
            IdLabel.Text = "Id";
            DescriptionLabel.Text = "Description";
            DoctorIdLabel.Text = "DoctorId";
            DateLabel.Text = "Date";
            IdTB.Text = certificate.Id.ToString();
            IdTB.ReadOnly = true;
            DescriptionTB.Text = certificate.Description;
            DatePicker.Value = certificate.Date;
            UpdateButton.Text = "Update";
        }

        private void SetComboBox()
        {
            DoctorIdComboBox.Items.Clear();
            DoctorIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var item in Core.GetNameByIdDoctors())
            {
                DoctorIdComboBox.Items.Add(item);
            }
            DoctorIdComboBox.SelectedItem = Core.GetContext().Doctors.Where(p => p.Id == certificate.DoctorId).First().Name;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (DescriptionTB.Text.Length == 0)
            {
                MessageBox.Show("Please, write Description", "Description", MessageBoxButtons.OK);
            }
            else
            {
                certificate.Description = DescriptionTB.Text;
                certificate.DoctorId = Core.GetContext().Specializations.Where(predicate: p => p.Name == DoctorIdComboBox.SelectedItem).First().Id;
                certificate.Date = DatePicker.Value;
                updateButtonClicked = true;
                Close();
            }
        }

        private void UpdateCertificate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!updateButtonClicked)
            {
                var check = MessageBox.Show("Are you sure? Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                e.Cancel = check == DialogResult.No;
            }
        }
    }
}
