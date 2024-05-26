
namespace _20200305025stockapp 
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            
            InformationForm informationForm = new InformationForm();
            informationForm.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
        }
    }
}
