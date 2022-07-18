using ProductManagement1.Data;
using ProductManagement1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_App
{
    public partial class ucCategory : UserControl
    {
        public ucCategory()
        {
            InitializeComponent();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadData()
        {
            CategoryRepository repo = new CategoryRepository();
            var category = repo.Get();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = category;
        }









        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this category?",
               "Delete confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                CategoryRepository repo = new CategoryRepository();
                repo.Delete(id);
                loadData();
            }
            else
            {
                MessageBox.Show("Please select category to delete");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddCategory formAddCate = new FormAddCategory();
            formAddCate.ShowDialog();
            //formAddCate.FormClosed += FormAddCategory_FormClosed;
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateCategory formUpdate = new FormUpdateCategory();
            if(dataGridView1.SelectedRows.Count > 0)
            {
                var cate = new Category()
                {
                    Id = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                    CategoryName = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                    Status = 1
                };
                formUpdate.LoadCategory(cate);
                //formUpdate.Update(cate);
            }
            formUpdate.ShowDialog();
            
            loadData();
        }




    }
}
