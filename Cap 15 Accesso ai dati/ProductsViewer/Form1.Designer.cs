namespace ProductsViewer
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adventureWorksLT2012DataSet = new ProductsViewer.AdventureWorksLT2012DataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new ProductsViewer.AdventureWorksLT2012DataSetTableAdapters.ProductTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productModelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinuedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thumbNailPhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2012DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.productNumberDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.standardCostDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.productCategoryIDDataGridViewTextBoxColumn,
            this.productModelIDDataGridViewTextBoxColumn,
            this.sellStartDateDataGridViewTextBoxColumn,
            this.sellEndDateDataGridViewTextBoxColumn,
            this.discontinuedDateDataGridViewTextBoxColumn,
            this.thumbNailPhotoDataGridViewImageColumn,
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // adventureWorksLT2012DataSet
            // 
            this.adventureWorksLT2012DataSet.DataSetName = "AdventureWorksLT2012DataSet";
            this.adventureWorksLT2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.adventureWorksLT2012DataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // standardCostDataGridViewTextBoxColumn
            // 
            this.standardCostDataGridViewTextBoxColumn.DataPropertyName = "StandardCost";
            this.standardCostDataGridViewTextBoxColumn.HeaderText = "StandardCost";
            this.standardCostDataGridViewTextBoxColumn.Name = "standardCostDataGridViewTextBoxColumn";
            // 
            // listPriceDataGridViewTextBoxColumn
            // 
            this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // productCategoryIDDataGridViewTextBoxColumn
            // 
            this.productCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "ProductCategoryID";
            this.productCategoryIDDataGridViewTextBoxColumn.HeaderText = "ProductCategoryID";
            this.productCategoryIDDataGridViewTextBoxColumn.Name = "productCategoryIDDataGridViewTextBoxColumn";
            // 
            // productModelIDDataGridViewTextBoxColumn
            // 
            this.productModelIDDataGridViewTextBoxColumn.DataPropertyName = "ProductModelID";
            this.productModelIDDataGridViewTextBoxColumn.HeaderText = "ProductModelID";
            this.productModelIDDataGridViewTextBoxColumn.Name = "productModelIDDataGridViewTextBoxColumn";
            // 
            // sellStartDateDataGridViewTextBoxColumn
            // 
            this.sellStartDateDataGridViewTextBoxColumn.DataPropertyName = "SellStartDate";
            this.sellStartDateDataGridViewTextBoxColumn.HeaderText = "SellStartDate";
            this.sellStartDateDataGridViewTextBoxColumn.Name = "sellStartDateDataGridViewTextBoxColumn";
            // 
            // sellEndDateDataGridViewTextBoxColumn
            // 
            this.sellEndDateDataGridViewTextBoxColumn.DataPropertyName = "SellEndDate";
            this.sellEndDateDataGridViewTextBoxColumn.HeaderText = "SellEndDate";
            this.sellEndDateDataGridViewTextBoxColumn.Name = "sellEndDateDataGridViewTextBoxColumn";
            // 
            // discontinuedDateDataGridViewTextBoxColumn
            // 
            this.discontinuedDateDataGridViewTextBoxColumn.DataPropertyName = "DiscontinuedDate";
            this.discontinuedDateDataGridViewTextBoxColumn.HeaderText = "DiscontinuedDate";
            this.discontinuedDateDataGridViewTextBoxColumn.Name = "discontinuedDateDataGridViewTextBoxColumn";
            // 
            // thumbNailPhotoDataGridViewImageColumn
            // 
            this.thumbNailPhotoDataGridViewImageColumn.DataPropertyName = "ThumbNailPhoto";
            this.thumbNailPhotoDataGridViewImageColumn.HeaderText = "ThumbNailPhoto";
            this.thumbNailPhotoDataGridViewImageColumn.Name = "thumbNailPhotoDataGridViewImageColumn";
            // 
            // thumbnailPhotoFileNameDataGridViewTextBoxColumn
            // 
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn.DataPropertyName = "ThumbnailPhotoFileName";
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn.HeaderText = "ThumbnailPhotoFileName";
            this.thumbnailPhotoFileNameDataGridViewTextBoxColumn.Name = "thumbnailPhotoFileNameDataGridViewTextBoxColumn";
            // 
            // rowguidDataGridViewTextBoxColumn
            // 
            this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 405);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2012DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AdventureWorksLT2012DataSet adventureWorksLT2012DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private AdventureWorksLT2012DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productModelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discontinuedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn thumbNailPhotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thumbnailPhotoFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
    }
}

