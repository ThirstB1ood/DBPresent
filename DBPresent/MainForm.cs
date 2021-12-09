using DBPresent.CertificateVC;
using DBPresent.DoctorVC;
using DBPresent.SpecializationVC;
using CoreDB;

namespace DBPresent
{
    public partial class Hospital : Form
    {
        
        public Hospital()
        {
            InitializeComponent();
            SetComboBox();
            SetLabel();
        }

        private void SetComboBox()
        {
            SelectTypeObject.Items.Add("Doctor");
            SelectTypeObject.Items.Add("Specialization");
            SelectTypeObject.Items.Add("Certificate");
            SelectTypeObject.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectTypeObject.SelectedIndex = 0;
        }

        private void SetLabel()
        {
            SelectLabel.Text = "Select Essence";
            SelectButton.Text = "Select";
            Text = "Hospital"; 
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            switch (SelectTypeObject.SelectedIndex)
            {
                case 0:
                    Thread threadDoctor = new(ShowDoctor);
                    threadDoctor.Start();
                    break;
                case 1:
                    Thread threadSpec = new(ShowSpec);
                    threadSpec.Start();
                    break;
                case 2:
                    Thread threadCert = new(ShowCertificate);
                    threadCert.Start();
                    break;

            }
        }

        private void ShowDoctor()
        {
            DoctorVc doctor = new();
            Application.Run(doctor);
        }

        private void ShowSpec()
        {
            SpecializationVc specialization = new();
            Application.Run(specialization);
        }

        private void ShowCertificate()
        {
            CertificateVc certificate = new();
            Application.Run(certificate);
        }

    }
}