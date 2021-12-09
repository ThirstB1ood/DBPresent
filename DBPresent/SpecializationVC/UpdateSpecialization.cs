using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseModels.Specializations;

namespace DBPresent.SpecializationVC
{
    public partial class UpdateSpecialization : Form
    {
        private readonly Specialization specialization;

        private bool updateButtonClicked = false;

        public UpdateSpecialization(Specialization _specialization)
        {
            InitializeComponent();
            specialization = _specialization;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(specialization.Name == "")
            {
                MessageBox.Show("Please, write name", "Name", MessageBoxButtons.OK);
            }
            else
            {
                specialization.Name = NameTB.Text;
                updateButtonClicked = true;
                Close();
            }
        }

        private void SetLabels()
        {
            NameVCLabel.Text = "Change Specialization";
            NameSpecLabel.Text = "Name";
            IdSpecNameLabel.Text = "Id";
            IdSpecLabel.Text = specialization.Id.ToString();
            NameTB.Text = specialization.Name.ToString();
        }

        private void UpdateSpecialization_Load(object sender, EventArgs e)
        {
            SetLabels();
        }

        private void UpdateSpecialization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!updateButtonClicked)
            {
                var check = MessageBox.Show("Are you sure? Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                e.Cancel = check == DialogResult.No;
            }
        }
    }
}
