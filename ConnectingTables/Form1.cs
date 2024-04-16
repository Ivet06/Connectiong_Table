using MySql.Data.MySqlClient;

namespace ConnectingTables
{
    public partial class Form1 : Form
    {
        string connecting = "server=10.6.0.127;" +
                            "port=3306;" +
                            "user=PC1;" +
                            "password=1111;" +
                            "database=trees_zaimov";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlConnection connect = new MySqlConnection(connecting);
            if (connect.State == 0)
            {
                connect.Open();
            }
            MessageBox.Show("Connection now open");
        }

        
    }
}
