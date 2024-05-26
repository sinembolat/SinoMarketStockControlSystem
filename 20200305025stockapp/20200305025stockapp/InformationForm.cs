using System.Data;
using MySqlConnector;

namespace _20200305025stockapp
{
    public partial class InformationForm : Form
    {
        
        private string connectionString = "Server=localhost;User ID=root;Password=;Database=20200305025";

        public InformationForm()
        {
            InitializeComponent();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            
            listViewProducts.Columns.Add("Id");
            listViewProducts.Columns.Add("Name");
            listViewProducts.Columns.Add("Brand");
            listViewProducts.Columns.Add("Package Type");
            listViewProducts.Columns.Add("Warehouse Name");
            listViewProducts.Columns.Add("Location in Warehouse");
            listViewProducts.Columns.Add("Stock");

            
            ShowStockInformation();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            
            ShowStockInformation(true);
        }

        private void ShowStockInformation(bool sortByName = false)
        {
            try
            {
                
                MySqlConnection connection = new MySqlConnection(connectionString);

                
                string query = "SELECT * FROM products";

                if (sortByName)
                {
                    
                    query += " ORDER BY name";
                }

                
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);

                
                DataTable dataTable = new DataTable();

                
                dataAdapter.Fill(dataTable);

                
                listViewProducts.Items.Clear();

                
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["name"].ToString()); 
                    item.SubItems.Add(row["brand"].ToString());
                    item.SubItems.Add(row["package_type"].ToString());
                    item.SubItems.Add(row["warehouse_name"].ToString());
                    item.SubItems.Add(row["location_in_warehouse"].ToString());
                    item.SubItems.Add(row["stock"].ToString());
                    listViewProducts.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide(); 
        }
    }
}



