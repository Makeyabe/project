namespace โปรเจคWinFormsApp2.s
{
    public partial class Form1 : Form
    {
        int order = 1;
        double total = 0;
        private object obj;
        private object receiptBindingSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                addRow(txtProductNane.Text, txtQuantity.Text, txtPrice.Text, txtTotal.Text, txtCash.Text);
                txtProductNane.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
                txtTotal.Text = "";
                txtCash.Text = "";
            }
            void addRow(string ID, string ProductName, string Price, string Total, string Cash)
            {
                String[] row = {ID, ProductName,Price,Total};
                dataGridView1.Rows.Add(row);
            }
        }

        private void addRow(string text1, string text2, string text3, string text4, string text5)
        {
            throw new NotImplementedException();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}