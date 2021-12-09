using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseModels.Doctors;
using CoreDB;

namespace DBPresent.DoctorVC
{
    public partial class UpdateDoctor : Form
    {
        private Doctor doctor;

        private static bool updateButtonClicked = false;
        public UpdateDoctor(Doctor _doctor)
        {
            InitializeComponent();
            doctor = _doctor;
            SetComboBox();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "")
            {
                MessageBox.Show("Please, write name", "Name", MessageBoxButtons.OK);
            }
            else
            {
                doctor.Name = NameTB.Text;
                doctor.SpecializationId = Core.GetContext().Specializations.Where(p => p.Name == IdSpecComboBox.SelectedItem).FirstOrDefault().Id;
                updateButtonClicked = true;
                Close();
            }
        }

        private void SetComboBox()
        {
            IdSpecComboBox.Items.Clear();
            IdSpecComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var item in Core.GetNameByIdSpecialization())
            {
                IdSpecComboBox.Items.Add(item);
            }
            IdSpecComboBox.SelectedItem = Core.GetContext().Specializations.Where(p => p.Id == doctor.SpecializationId).FirstOrDefault().Name;
        }

        private void SetLabels()
        {
            UpdateVCLabel.Text = "Change Doctor";
            NameLabel.Text = "Name";
            IdLabel.Text = "Id";
            IdSpecLabel.Text = "Specialization Id";
            IdTB.Text = doctor.Id.ToString();
            IdTB.ReadOnly = true;
            NameTB.Text = doctor.Name.ToString();
            UpdateButton.Text = "Update";
        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {
            SetLabels();
        }

        private void UpdateDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!updateButtonClicked)
            {
                var check = MessageBox.Show("Are you sure? Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                e.Cancel = check == DialogResult.No;
            }
        }
    }
}
