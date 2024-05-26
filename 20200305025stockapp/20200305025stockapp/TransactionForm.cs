using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace _20200305025stockapp
{
    public partial class TransactionForm : Form
    {

        private string connectionString = "Server=localhost;User ID=root;Password=;Database=20200305025";

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            ListProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
            textBox_Id.Text = "";
            textBox_Name.Text = "";
            textBox_Brand.Text = "";
            textBox_Package.Text = "";
            textBox_Warehouse.Text = "";
            textBox_Location.Text = "";
            textBox_Stock.Text = "";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListProducts();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = "";
            textBox_Brand.Text = "";
            textBox_Package.Text = "";
            textBox_Warehouse.Text = "";
            textBox_Location.Text = "";
            textBox_Stock.Text = "";

            string id = textBox_Id.Text;
            string name = textBox_Name.Text;
            string brand = textBox_Brand.Text;
            string packageType = textBox_Package.Text;
            string warehouseName = textBox_Warehouse.Text;
            string locationInWarehouse = textBox_Location.Text;
            string stock = textBox_Stock.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE products SET name = @name, brand = @brand, package_type = @packageType, warehouse_name = @warehouseName, location_in_warehouse = @locationInWarehouse, stock = @stock WHERE id = @id";
                MySqlCommand updateCommand = new MySqlCommand(query, connection);
                updateCommand.Parameters.AddWithValue("@name", name);
                updateCommand.Parameters.AddWithValue("@brand", brand);
                updateCommand.Parameters.AddWithValue("@packageType", packageType);
                updateCommand.Parameters.AddWithValue("@warehouseName", warehouseName);
                updateCommand.Parameters.AddWithValue("@locationInWarehouse", locationInWarehouse);
                updateCommand.Parameters.AddWithValue("@stock", stock);
                updateCommand.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    int result = updateCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Product successfully updated.");
                        ListProducts();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while updating the product.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textBox_Id.Text = "";


            if (int.TryParse(textBox_Id.Text, out int productId))
            {

                DeleteProduct(productId);


                ListProducts();
            }
            else
            {
                MessageBox.Show("Please enter a valid product ID.");
            }
        }

        private void AddProduct()
        {
            try
            {

                MySqlConnection connection = new MySqlConnection(connectionString);


                string query = "INSERT INTO products (name, brand, package_type, warehouse_name, location_in_warehouse, stock) VALUES (@Name, @Brand, @PackageType, @WarehouseName, @LocationInWarehouse, @Stock)";


                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", textBox_Name.Text);
                command.Parameters.AddWithValue("@Brand", textBox_Brand.Text);
                command.Parameters.AddWithValue("@PackageType", textBox_Package.Text);
                command.Parameters.AddWithValue("@WarehouseName", textBox_Warehouse.Text);
                command.Parameters.AddWithValue("@LocationInWarehouse", textBox_Location.Text);
                command.Parameters.AddWithValue("@Stock", textBox_Stock.Text);


                connection.Open();


                command.ExecuteNonQuery();


                connection.Close();


                ListProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ListProducts()
        {
            try
            {

                MySqlConnection connection = new MySqlConnection(connectionString);


                string query = "SELECT * FROM products";


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);


                DataTable dataTable = new DataTable();


                dataAdapter.Fill(dataTable);


                listView_Transaction.Items.Clear();


                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["name"].ToString());
                    item.SubItems.Add(row["brand"].ToString());
                    item.SubItems.Add(row["package_type"].ToString());
                    item.SubItems.Add(row["warehouse_name"].ToString());
                    item.SubItems.Add(row["location_in_warehouse"].ToString());
                    item.SubItems.Add(row["stock"].ToString());
                    listView_Transaction.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EditProduct()
        {
            try
            {
                if (listView_Transaction.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a product to edit.");
                    return;
                }


                ListViewItem selectedItem = listView_Transaction.SelectedItems[0];
                int productId = int.Parse(selectedItem.SubItems[0].Text);


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    string query = "UPDATE products SET name = @Name, brand = @Brand, package_type = @PackageType, warehouse_name = @WarehouseName, location_in_warehouse = @LocationInWarehouse, stock = @Stock WHERE id = @Id";


                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", textBox_Name.Text);
                    command.Parameters.AddWithValue("@Brand", textBox_Brand.Text);
                    command.Parameters.AddWithValue("@PackageType", textBox_Package.Text);
                    command.Parameters.AddWithValue("@WarehouseName", textBox_Warehouse.Text);
                    command.Parameters.AddWithValue("@LocationInWarehouse", textBox_Location.Text);
                    command.Parameters.AddWithValue("@Stock", textBox_Stock.Text);
                    command.Parameters.AddWithValue("@Id", productId);


                    connection.Open();


                    int rowsAffected = command.ExecuteNonQuery();


                    connection.Close();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product successfully updated.");
                        ListProducts();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while updating the product.");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteProduct(int productId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM products WHERE id = @productId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@productId", productId);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Product with the specified ID does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnback2_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}
