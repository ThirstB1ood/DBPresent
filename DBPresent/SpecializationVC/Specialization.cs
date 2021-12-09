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
    public partial class SpecializationVc : Form
    {

        private readonly DataTable dataTable;
        public SpecializationVc()
        {
            InitializeComponent();
            dataTable = new DataTable();
            SetButtons();
        }

        private void SetData()
        {
            
            var data = Core.GetContext().Specializations.ToList();
            
            dataTable.Columns.Add("Id", typeof(int)).ReadOnly = true;
            dataTable.Columns.Add("Name", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Delete", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Update", typeof(string)).ReadOnly = true;

            for (int i = 0; i < data.Count; i++)
            {
                var tableData = new TableData(data[i].Name, data[i].Id);
                dataTable.Rows.Add(tableData.Id, tableData.Name, TableData.Delete, TableData.Update);
                
            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);


            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new();
                dataGridView1[2, i] = linkCell;
                DataGridViewLinkCell linkCell1 = new();
                dataGridView1[3, i] = linkCell1;
            }
        }

        private void SetButtons()
        {
            AddButton.Text = "Add";
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void ReloadData()
        {
            dataTable.Clear();

            var data = Core.GetContext().Specializations.ToList();

            for (int i = 0; i < data.Count; i++)
            {
                var tableData = new TableData(data[i].Name, data[i].Id);
                dataTable.Rows.Add(tableData.Id, tableData.Name, TableData.Delete, TableData.Update);
            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new();
                dataGridView1[2, i] = linkCell;
                DataGridViewLinkCell linkCell1 = new();
                dataGridView1[3, i] = linkCell1;
            }
        }

        private void SpecializationVc_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    if (MessageBox.Show("Are you sure? Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;
                        Core.RemoveFromDb("Specialization", Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value));
                    }
                }
                else if (e.ColumnIndex == 3)
                {  
                    int rowIndex = e.RowIndex;

                    UpdateSpecialization updateSpecialization = new(Core.GetSpecById(Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value)));
                    updateSpecialization.Show();
                }
                ReloadData();

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            AddSpecialization addSpecialization = new();
            addSpecialization.Show();
        }

        private void SpecializationVc_Activated(object sender, EventArgs e)
        {
            ReloadData();
        }
    }

    struct TableData
    {
        public string Name;
        public int Id;
        public static string Delete = "Delete";
        public static string Update = "Update";

        public TableData(string _name, int _id)
        {
            Name = _name;
            Id = _id;
        }
    }
}
