using System;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductsList();
            ListCategories();
        }

        private void ProductListByProductName(string search)
       {
            using (NortWindContext nortWindContext = new NortWindContext())
            {
                dgwProducts.DataSource = nortWindContext.Products.Where(x => x.PRoductName.ToLower().Contains(search)).ToList();
            }
        }

        private void ProductsListByCategory(int id)
        {
            using (NortWindContext nortWindContext = new NortWindContext())
            {
                dgwProducts.DataSource = nortWindContext.Products.Where(x => x.CategoryID == id).ToList();
            }
        }

        private void ListCategories()
        {
            using (NortWindContext nortWindContext = new NortWindContext())
            {
                cbxCategory.DataSource = nortWindContext.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryID";
            }
        }

        private void ProductsList()
        {
            using (NortWindContext nortWindContext = new NortWindContext())
            {
                dgwProducts.DataSource = nortWindContext.Products.ToList();
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProductsListByCategory(Convert.ToInt32((cbxCategory.SelectedValue)));
            }
            catch (Exception)
            {

            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            ProductListByProductName(tbxSearch.Text.ToLower());
        }
    }
}
