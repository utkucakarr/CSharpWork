using NorthWind.Business.Abstract;
using NorthWind.Business.DependencyResolvers.Ninject;
using NorthWind.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace NothWind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Buradan Product Manager çağırırız

            LoadProducts();
            LoadCategories();
            LoadCategoriesId();
            LoadUpdateCategoriesId();
        }

        private void LoadUpdateCategoriesId()
        {
            cbxUpdateCategoryId.DataSource = _categoryService.GetAll();
            cbxUpdateCategoryId.DisplayMember = "CategoryName";
            cbxUpdateCategoryId.ValueMember = "CategoryId";
        }

        private void LoadCategoriesId()
        {
            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource =
                    _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {
            }
        }

        private void tbxProducName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProducName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductByProductName(tbxProducName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    ProductName = tbxProductName.Text,
                    CategoryID = Convert.ToInt32(cbxCategory.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(tbxQuantityPerUnit.Text)
                });
                MessageBox.Show("Ürün Eklendi!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxUpdateProductName.Text,
                    CategoryID = Convert.ToInt32(cbxUpdateCategoryId.SelectedValue),
                    QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxUpdateStockAmount.Text)
                });
                MessageBox.Show("Ürün Güncellendi!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateProductName.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            cbxUpdateCategoryId.SelectedValue = dgwProduct.CurrentRow.Cells[1].Value;
            tbxUpdateUnitPrice.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateStockAmount.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Normalde arayüz tarafında hata yakalaması yapılmaz
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi!");
                    LoadProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
