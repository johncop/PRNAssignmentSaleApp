using ProductManagement1.Data;
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
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            ProductRepository repo = new ProductRepository();
            var pro = repo.Get();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pro;
        }
    }
}
