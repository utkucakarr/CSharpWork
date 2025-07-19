namespace NothWind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCatefory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProducName = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.cbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUpdateStockAmount = new System.Windows.Forms.Label();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateCategoryId = new System.Windows.Forms.Label();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateProduct = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCatefory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(13, 214);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(836, 224);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCatefory
            // 
            this.gbxCatefory.Controls.Add(this.cbxCategory);
            this.gbxCatefory.Controls.Add(this.lblCategory);
            this.gbxCatefory.Location = new System.Drawing.Point(0, 13);
            this.gbxCatefory.Name = "gbxCatefory";
            this.gbxCatefory.Size = new System.Drawing.Size(849, 71);
            this.gbxCatefory.TabIndex = 1;
            this.gbxCatefory.TabStop = false;
            this.gbxCatefory.Text = "Categoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(64, 31);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(164, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 34);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProducName);
            this.gbxProductName.Controls.Add(this.lblProduct);
            this.gbxProductName.Location = new System.Drawing.Point(0, 114);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(849, 71);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Product adına göre ara";
            // 
            // tbxProducName
            // 
            this.tbxProducName.Location = new System.Drawing.Point(64, 31);
            this.tbxProducName.Name = "tbxProducName";
            this.tbxProducName.Size = new System.Drawing.Size(164, 20);
            this.tbxProducName.TabIndex = 3;
            this.tbxProducName.TextChanged += new System.EventHandler(this.tbxProducName_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(12, 34);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(48, 13);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Ürün Adı";
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.cbxCategoryId);
            this.gbxAddProduct.Controls.Add(this.btnAddProduct);
            this.gbxAddProduct.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.lblQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.tbxStockAmount);
            this.gbxAddProduct.Controls.Add(this.tbxUnitPrice);
            this.gbxAddProduct.Controls.Add(this.lblStockAmount);
            this.gbxAddProduct.Controls.Add(this.lblUnitPrice);
            this.gbxAddProduct.Controls.Add(this.lblCategoryId);
            this.gbxAddProduct.Controls.Add(this.tbxProductName);
            this.gbxAddProduct.Controls.Add(this.lblProductName);
            this.gbxAddProduct.Location = new System.Drawing.Point(15, 456);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(414, 280);
            this.gbxAddProduct.TabIndex = 3;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Yeni Ürün Ekle";
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(75, 65);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoryId.TabIndex = 11;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(237, 95);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(162, 23);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Ürün Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(285, 66);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(114, 20);
            this.tbxQuantityPerUnit.TabIndex = 9;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(220, 69);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnit.TabIndex = 8;
            this.lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(285, 40);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(114, 20);
            this.tbxStockAmount.TabIndex = 7;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(75, 92);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxUnitPrice.TabIndex = 6;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(220, 43);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(59, 13);
            this.lblStockAmount.TabIndex = 4;
            this.lblStockAmount.Text = "Stok Adedi";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(14, 95);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(12, 69);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryId.TabIndex = 2;
            this.lblCategoryId.Text = "Kategori";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(75, 40);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(121, 20);
            this.tbxProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(10, 43);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.cbxUpdateCategoryId);
            this.gbxUpdateProduct.Controls.Add(this.btnUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateStockAmount);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateStockAmount);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateUnitPrice);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateCategoryId);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProduct);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(435, 456);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(414, 280);
            this.gbxUpdateProduct.TabIndex = 4;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Ürün Güncelleme";
            // 
            // cbxUpdateCategoryId
            // 
            this.cbxUpdateCategoryId.FormattingEnabled = true;
            this.cbxUpdateCategoryId.Location = new System.Drawing.Point(75, 65);
            this.cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            this.cbxUpdateCategoryId.Size = new System.Drawing.Size(121, 21);
            this.cbxUpdateCategoryId.TabIndex = 11;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(237, 95);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(162, 23);
            this.btnUpdateProduct.TabIndex = 10;
            this.btnUpdateProduct.Text = "Ürün Güncelle";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(285, 66);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(114, 20);
            this.tbxUpdateQuantityPerUnit.TabIndex = 9;
            // 
            // lblUpdateQuantityPerUnit
            // 
            this.lblUpdateQuantityPerUnit.AutoSize = true;
            this.lblUpdateQuantityPerUnit.Location = new System.Drawing.Point(220, 69);
            this.lblUpdateQuantityPerUnit.Name = "lblUpdateQuantityPerUnit";
            this.lblUpdateQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblUpdateQuantityPerUnit.TabIndex = 8;
            this.lblUpdateQuantityPerUnit.Text = "Birim Adedi";
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(285, 40);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(114, 20);
            this.tbxUpdateStockAmount.TabIndex = 7;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(75, 92);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdateUnitPrice.TabIndex = 6;
            // 
            // lblUpdateStockAmount
            // 
            this.lblUpdateStockAmount.AutoSize = true;
            this.lblUpdateStockAmount.Location = new System.Drawing.Point(220, 43);
            this.lblUpdateStockAmount.Name = "lblUpdateStockAmount";
            this.lblUpdateStockAmount.Size = new System.Drawing.Size(59, 13);
            this.lblUpdateStockAmount.TabIndex = 4;
            this.lblUpdateStockAmount.Text = "Stok Adedi";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(14, 95);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUpdateUnitPrice.TabIndex = 3;
            this.lblUpdateUnitPrice.Text = "Fiyat";
            // 
            // lblUpdateCategoryId
            // 
            this.lblUpdateCategoryId.AutoSize = true;
            this.lblUpdateCategoryId.Location = new System.Drawing.Point(12, 69);
            this.lblUpdateCategoryId.Name = "lblUpdateCategoryId";
            this.lblUpdateCategoryId.Size = new System.Drawing.Size(46, 13);
            this.lblUpdateCategoryId.TabIndex = 2;
            this.lblUpdateCategoryId.Text = "Kategori";
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(75, 40);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdateProductName.TabIndex = 1;
            // 
            // lblUpdateProduct
            // 
            this.lblUpdateProduct.AutoSize = true;
            this.lblUpdateProduct.Location = new System.Drawing.Point(10, 43);
            this.lblUpdateProduct.Name = "lblUpdateProduct";
            this.lblUpdateProduct.Size = new System.Drawing.Size(48, 13);
            this.lblUpdateProduct.TabIndex = 0;
            this.lblUpdateProduct.Text = "Ürün Adı";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(720, 185);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(129, 23);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Sil";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 803);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCatefory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCatefory.ResumeLayout(false);
            this.gbxCatefory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCatefory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProducName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryId;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.Label lblUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateStockAmount;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateStockAmount;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateCategoryId;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}

