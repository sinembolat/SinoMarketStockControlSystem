namespace _20200305025stockapp
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            btnSort = new Button();
            label2 = new Label();
            btnBack = new Button();
            listViewProducts = new ListView();
            id = new ColumnHeader();
            name = new ColumnHeader();
            brand = new ColumnHeader();
            package_type = new ColumnHeader();
            warehouse_name = new ColumnHeader();
            location_in_warehouse = new ColumnHeader();
            stock = new ColumnHeader();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.BackColor = SystemColors.ActiveCaptionText;
            btnSort.Location = new Point(337, 321);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(111, 39);
            btnSort.TabIndex = 4;
            btnSort.Text = "SORT PRODUCT";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("STHupo", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(125, 22);
            label2.Name = "label2";
            label2.Size = new Size(549, 21);
            label2.TabIndex = 5;
            label2.Text = "INFORMATION ABOUT THE ALL PRODUCTS AND THEIR STOCKS";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(337, 378);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 39);
            btnBack.TabIndex = 7;
            btnBack.Text = "BACK TO MENU";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { id, name, brand, package_type, warehouse_name, location_in_warehouse, stock });
            listViewProducts.Location = new Point(97, 98);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(625, 217);
            listViewProducts.TabIndex = 8;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            // 
            // id
            // 
            id.Text = "id";
            // 
            // name
            // 
            name.Text = "name";
            name.Width = 80;
            // 
            // brand
            // 
            brand.Text = "brand";
            brand.Width = 100;
            // 
            // package_type
            // 
            package_type.Text = "package_type";
            package_type.Width = 90;
            // 
            // warehouse_name
            // 
            warehouse_name.Text = "warehouse_name";
            warehouse_name.Width = 110;
            // 
            // location_in_warehouse
            // 
            location_in_warehouse.Text = "location_in_warehouse";
            location_in_warehouse.Width = 120;
            // 
            // stock
            // 
            stock.Text = "stock";
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(791, 444);
            Controls.Add(listViewProducts);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(btnSort);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "InformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INFORMATION FORM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSort;
        private Label label2;
        private Button btnBack;
        private ListView listViewProducts;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader brand;
        private ColumnHeader package_type;
        private ColumnHeader warehouse_name;
        private ColumnHeader location_in_warehouse;
        private ColumnHeader stock;
    }
}