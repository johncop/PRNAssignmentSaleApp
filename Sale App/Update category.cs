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
    public partial class FormUpdateCategory : Form
    {
        public FormUpdateCategory()
        {
            InitializeComponent();
        }
        private Category category;
        public void LoadCategory(Category cat)
        {
            category = cat;
            txtCatId.Text = cat.Id.ToString();
            txtCatName.Name = cat.CategoryName.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
