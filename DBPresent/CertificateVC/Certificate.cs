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
using DatabaseModels.Certificates;

namespace DBPresent.CertificateVC
{
    public partial class CertificateVc : Form
    {
        private readonly DataTable dataTable;

        public CertificateVc()
        {
            InitializeComponent();
            dataTable = new DataTable();
            SetData();
            SetButton();
        }

        private void SetButton()
        {
            AddButton.Text = "Add";
        }

        private void SetData()
        {

            var data = Core.GetContext().Certificates.ToList();

            dataTable.Columns.Add("Id", typeof(int)).ReadOnly = true;
            dataTable.Columns.Add("DoctorId", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Description", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Date", typeof(DateTime)).ReadOnly = true;
            dataTable.Columns.Add("Delete", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Update", typeof(string)).ReadOnly = true;

            for (int i = 0; i < data.Count; i++)
            {
                var tableData = new TableData(data[i].Id, data[i].DoctorId, data[i].Description, data[i].Date);
                dataTable.Rows.Add(tableData.Id, tableData.DoctorId, tableData.Description, tableData.DateTimePicker, TableData.Delete, TableData.Update);

            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new();
                dataGridView1[3, i] = linkCell;
            }
        }

        private void ReloadData()
        {
            dataTable.Clear();

            var data = Core.GetContext().Certificates.ToList();

            for (int i = 0; i < data.Count; i++)
            {
                var tableData = new TableData(data[i].Id, data[i].DoctorId, data[i].Description, data[i].Date);
                dataTable.Rows.Add(tableData.Id, tableData.DoctorId, tableData.Description, tableData.DateTimePicker, TableData.Delete, TableData.Update);

            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new();
                dataGridView1[4, i] = linkCell;
                DataGridViewLinkCell linkCell1 = new();
                dataGridView1[5, i] = linkCell1;
            }


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCertificate addCertificate = new();
            addCertificate.Show();
        }

        private void SpecializationVc_Activated(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void CertificateVc_Activated(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Are you sure? Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;
                        Core.RemoveFromDb("Certificate", Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value));
                    }
                }
                else if (e.ColumnIndex == 5)
                {
                    int rowIndex = e.RowIndex;

                    UpdateCertificate updateCertificate = new(Core.GetCertificateById(Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value)));
                    updateCertificate.Show();

                    //core.ChangeInDB(dataGridView1.Rows[rowIndex].Cells["Name"].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value));
                }
                ReloadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void CertificateVc_Load(object sender, EventArgs e)
        {

        }
    }

    struct TableData
    {
        public int Id;
        public int DoctorId;
        public string Description;
        public DateTime DateTimePicker;
        public static string Delete = "Delete";
        public static string Update = "Update";

        public TableData(int _id, int _doctorId, string _description, DateTime _dateTimePicker)
        {
            Id = _id;
            DoctorId = _doctorId;
            Description = _description;
            DateTimePicker = _dateTimePicker;
        }

    }
}

