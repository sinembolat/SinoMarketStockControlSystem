namespace _20200305025stockapp
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            btnAdd = new Button();
            button_Edit = new Button();
            btnDelete = new Button();
            btnList = new Button();
            label1_Id = new Label();
            label2_Name = new Label();
            label3_Brand = new Label();
            label4_PackageType = new Label();
            label5_WarehouseName = new Label();
            label6_Location = new Label();
            label7_Stock = new Label();
            listView_Transaction = new ListView();
            id = new ColumnHeader();
            name = new ColumnHeader();
            brand = new ColumnHeader();
            package_type = new ColumnHeader();
            wareohuse_name = new ColumnHeader();
            location_in_warehouse = new ColumnHeader();
            stock = new ColumnHeader();
            textBox_Id = new TextBox();
            textBox_Name = new TextBox();
            textBox_Brand = new TextBox();
            textBox_Package = new TextBox();
            textBox_Warehouse = new TextBox();
            textBox_Location = new TextBox();
            textBox_Stock = new TextBox();
            btnback2 = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ScrollBar;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.Location = new Point(27, 433);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 33);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD PRODUCT";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // button_Edit
            // 
            button_Edit.BackColor = SystemColors.ScrollBar;
            button_Edit.Font = new Font("Segoe UI", 9F);
            button_Edit.Location = new Point(165, 472);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(128, 33);
            button_Edit.TabIndex = 9;
            button_Edit.Text = "EDIT PRODUCT";
            button_Edit.UseVisualStyleBackColor = false;
            button_Edit.Click += button_Edit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ScrollBar;
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.Location = new Point(27, 472);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 33);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "DELETE PRODUCT";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnList
            // 
            btnList.BackColor = SystemColors.ScrollBar;
            btnList.Font = new Font("Segoe UI", 9F);
            btnList.Location = new Point(165, 433);
            btnList.Name = "btnList";
            btnList.Size = new Size(128, 33);
            btnList.TabIndex = 11;
            btnList.Text = "LİST PRODUCT";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // label1_Id
            // 
            label1_Id.AutoSize = true;
            label1_Id.BackColor = Color.FromArgb(255, 224, 192);
            label1_Id.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1_Id.Location = new Point(12, 147);
            label1_Id.Name = "label1_Id";
            label1_Id.Size = new Size(34, 26);
            label1_Id.TabIndex = 19;
            label1_Id.Text = "ID";
            // 
            // label2_Name
            // 
            label2_Name.AutoSize = true;
            label2_Name.BackColor = Color.FromArgb(255, 224, 192);
            label2_Name.Font = new Font("Showcard Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2_Name.Location = new Point(12, 189);
            label2_Name.Name = "label2_Name";
            label2_Name.Size = new Size(58, 23);
            label2_Name.TabIndex = 20;
            label2_Name.Text = "Name";
            // 
            // label3_Brand
            // 
            label3_Brand.AutoSize = true;
            label3_Brand.BackColor = Color.FromArgb(255, 224, 192);
            label3_Brand.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3_Brand.Location = new Point(12, 228);
            label3_Brand.Name = "label3_Brand";
            label3_Brand.Size = new Size(64, 20);
            label3_Brand.TabIndex = 21;
            label3_Brand.Text = "Brand";
            // 
            // label4_PackageType
            // 
            label4_PackageType.AutoSize = true;
            label4_PackageType.BackColor = Color.FromArgb(255, 224, 192);
            label4_PackageType.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4_PackageType.Location = new Point(12, 261);
            label4_PackageType.Name = "label4_PackageType";
            label4_PackageType.Size = new Size(60, 30);
            label4_PackageType.TabIndex = 22;
            label4_PackageType.Text = "Package\r\n Type";
            label4_PackageType.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5_WarehouseName
            // 
            label5_WarehouseName.AutoSize = true;
            label5_WarehouseName.BackColor = Color.FromArgb(255, 224, 192);
            label5_WarehouseName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5_WarehouseName.Location = new Point(12, 300);
            label5_WarehouseName.Name = "label5_WarehouseName";
            label5_WarehouseName.Size = new Size(84, 30);
            label5_WarehouseName.TabIndex = 23;
            label5_WarehouseName.Text = "Warehouse \r\nName";
            label5_WarehouseName.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6_Location
            // 
            label6_Location.AutoSize = true;
            label6_Location.BackColor = Color.FromArgb(255, 224, 192);
            label6_Location.Font = new Font("Showcard Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6_Location.Location = new Point(12, 349);
            label6_Location.Name = "label6_Location";
            label6_Location.Size = new Size(97, 23);
            label6_Location.TabIndex = 24;
            label6_Location.Text = "Location";
            // 
            // label7_Stock
            // 
            label7_Stock.AutoSize = true;
            label7_Stock.BackColor = Color.FromArgb(255, 224, 192);
            label7_Stock.Font = new Font("Showcard Gothic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7_Stock.Location = new Point(12, 386);
            label7_Stock.Name = "label7_Stock";
            label7_Stock.Size = new Size(67, 23);
            label7_Stock.TabIndex = 25;
            label7_Stock.Text = "Stock";
            // 
            // listView_Transaction
            // 
            listView_Transaction.Columns.AddRange(new ColumnHeader[] { id, name, brand, package_type, wareohuse_name, location_in_warehouse, stock });
            listView_Transaction.Location = new Point(277, 109);
            listView_Transaction.Name = "listView_Transaction";
            listView_Transaction.Size = new Size(567, 263);
            listView_Transaction.TabIndex = 26;
            listView_Transaction.UseCompatibleStateImageBehavior = false;
            listView_Transaction.View = View.Details;
            // 
            // id
            // 
            id.Text = "id";
            // 
            // name
            // 
            name.Text = "name";
            name.Width = 70;
            // 
            // brand
            // 
            brand.Text = "brand";
            brand.Width = 80;
            // 
            // package_type
            // 
            package_type.Text = "package_type";
            package_type.Width = 80;
            // 
            // wareohuse_name
            // 
            wareohuse_name.Text = "wareohuse_name";
            wareohuse_name.Width = 90;
            // 
            // location_in_warehouse
            // 
            location_in_warehouse.Text = "location_in_warehouse";
            location_in_warehouse.Width = 90;
            // 
            // stock
            // 
            stock.Text = "stock";
            // 
            // textBox_Id
            // 
            textBox_Id.Location = new Point(82, 147);
            textBox_Id.Multiline = true;
            textBox_Id.Name = "textBox_Id";
            textBox_Id.Size = new Size(112, 26);
            textBox_Id.TabIndex = 27;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(82, 189);
            textBox_Name.Multiline = true;
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(112, 26);
            textBox_Name.TabIndex = 28;
            // 
            // textBox_Brand
            // 
            textBox_Brand.Location = new Point(82, 228);
            textBox_Brand.Multiline = true;
            textBox_Brand.Name = "textBox_Brand";
            textBox_Brand.Size = new Size(112, 26);
            textBox_Brand.TabIndex = 29;
            // 
            // textBox_Package
            // 
            textBox_Package.Location = new Point(82, 265);
            textBox_Package.Multiline = true;
            textBox_Package.Name = "textBox_Package";
            textBox_Package.Size = new Size(112, 26);
            textBox_Package.TabIndex = 30;
            // 
            // textBox_Warehouse
            // 
            textBox_Warehouse.Location = new Point(102, 304);
            textBox_Warehouse.Multiline = true;
            textBox_Warehouse.Name = "textBox_Warehouse";
            textBox_Warehouse.Size = new Size(112, 26);
            textBox_Warehouse.TabIndex = 31;
            // 
            // textBox_Location
            // 
            textBox_Location.Location = new Point(115, 349);
            textBox_Location.Multiline = true;
            textBox_Location.Name = "textBox_Location";
            textBox_Location.Size = new Size(112, 26);
            textBox_Location.TabIndex = 32;
            // 
            // textBox_Stock
            // 
            textBox_Stock.Location = new Point(115, 386);
            textBox_Stock.Multiline = true;
            textBox_Stock.Name = "textBox_Stock";
            textBox_Stock.Size = new Size(112, 26);
            textBox_Stock.TabIndex = 33;
            // 
            // btnback2
            // 
            btnback2.BackColor = SystemColors.ScrollBar;
            btnback2.Font = new Font("Segoe UI", 9F);
            btnback2.Location = new Point(504, 452);
            btnback2.Name = "btnback2";
            btnback2.Size = new Size(128, 33);
            btnback2.TabIndex = 34;
            btnback2.Text = "BACK TO MENU";
            btnback2.UseVisualStyleBackColor = false;
            btnback2.Click += btnback2_Click;
            // 
            // Transaction Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(874, 516);
            Controls.Add(btnback2);
            Controls.Add(textBox_Stock);
            Controls.Add(textBox_Location);
            Controls.Add(textBox_Warehouse);
            Controls.Add(textBox_Package);
            Controls.Add(textBox_Brand);
            Controls.Add(textBox_Name);
            Controls.Add(textBox_Id);
            Controls.Add(listView_Transaction);
            Controls.Add(label7_Stock);
            Controls.Add(label6_Location);
            Controls.Add(label5_WarehouseName);
            Controls.Add(label4_PackageType);
            Controls.Add(label3_Brand);
            Controls.Add(label2_Name);
            Controls.Add(label1_Id);
            Controls.Add(btnList);
            Controls.Add(btnDelete);
            Controls.Add(button_Edit);
            Controls.Add(btnAdd);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TRANSACTION FORM";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColumnHeader ID;
        private new ColumnHeader Name;
        private ColumnHeader Brand;
        private ColumnHeader PackageType;
        private ColumnHeader WarehouseName;
        private ColumnHeader LocationInWarehouse;
        private ColumnHeader Stock;
        private Button btnAdd;
        private Button button_Edit;
        private Button btnDelete;
        private Button btnList;
        private TextBox textBox_Id;
        private Label label1_Id;
        private Label label2_Name;
        private Label label3_Brand;
        private Label label4_PackageType;
        private Label label5_WarehouseName;
        private Label label6_Location;
        private Label label7_Stock;
        private ListView listView_Transaction;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader brand;
        private ColumnHeader package_type;
        private ColumnHeader wareohuse_name;
        private ColumnHeader location_in_warehouse;
        private ColumnHeader stock;
        private TextBox textBox_Name;
        private TextBox textBox_Brand;
        private TextBox textBox_Package;
        private TextBox textBox_Warehouse;
        private TextBox textBox_Location;
        private TextBox textBox_Stock;
        private Button btnback2;
    }
}