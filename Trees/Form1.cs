using MySql.Data.MySqlClient;

namespace Trees
{
    public partial class Form1 : Form
    {
        string connecting = "server=10.6.0.33;" +
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

            //Class
            MySqlCommand query = new MySqlCommand("SELECT * FROM class", connect);

            MySqlDataReader readerCombo = query.ExecuteReader();

            List<ComboBox_Items> itemsClass = new List<ComboBox_Items>();

            while (readerCombo.Read())
            {
                ComboBox_Items itemClass = new ComboBox_Items();
                itemClass.Text = readerCombo[1].ToString();
                itemClass.Value = (int)readerCombo[0];
                itemsClass.Add(itemClass);
            }

            readerCombo.Close();
            comboBoxClass.DataSource = itemsClass;
            comboBoxClass.DisplayMember = "Text";
            comboBoxClass.ValueMember = "Value";

            //Otdel
            query = new MySqlCommand("SELECT * FROM otdel", connect);

            readerCombo = query.ExecuteReader();

            List<ComboBox_Items> itemsOtdel = new List<ComboBox_Items>();

            while (readerCombo.Read())
            {
                ComboBox_Items itemOtdel = new ComboBox_Items();
                itemOtdel.Text = readerCombo[1].ToString();
                itemOtdel.Value = (int)readerCombo[0];
                itemsOtdel.Add(itemOtdel);
            }

            readerCombo.Close();
            comboBoxOtdel.DataSource = itemsOtdel;
            comboBoxOtdel.DisplayMember = "Text";
            comboBoxOtdel.ValueMember = "Value";

            //Razred
            query = new MySqlCommand("SELECT * FROM razred", connect);

            readerCombo = query.ExecuteReader();

            List<ComboBox_Items> itemsRazred = new List<ComboBox_Items>();
            while (readerCombo.Read())
            {
                ComboBox_Items itemRazred = new ComboBox_Items();
                itemRazred.Text = readerCombo[1].ToString();
                itemRazred.Value = (int)readerCombo[0];
                itemsRazred.Add(itemRazred);
            }

            readerCombo.Close();
            comboBoxRazred.DataSource = itemsRazred;
            comboBoxRazred.DisplayMember = "Text";
            comboBoxRazred.ValueMember = "Value";

            //Family
            query = new MySqlCommand("SELECT * FROM family", connect);

            readerCombo = query.ExecuteReader();

            List<ComboBox_Items> itemsFamily = new List<ComboBox_Items>();

            while (readerCombo.Read())
            {
                ComboBox_Items itemFamily = new ComboBox_Items();
                itemFamily.Text = readerCombo[1].ToString();
                itemFamily.Value = (int)readerCombo[0];
                itemsFamily.Add(itemFamily);
            }

            readerCombo.Close();
            comboBoxFamily.DataSource = itemsFamily;
            comboBoxFamily.DisplayMember = "Text";
            comboBoxFamily.ValueMember = "Value";


            //Rod
            query = new MySqlCommand("SELECT * FROM rod", connect);

            readerCombo = query.ExecuteReader();

            List<ComboBox_Items> itemsRod = new List<ComboBox_Items>();

            while (readerCombo.Read())
            {
                ComboBox_Items itemRod = new ComboBox_Items();
                itemRod.Text = readerCombo[1].ToString();
                itemRod.Value = (int)readerCombo[0];
                itemsRod.Add(itemRod);
            }

            readerCombo.Close();
            comboBoxRod.DataSource = itemsRod;
            comboBoxRod.DisplayMember = "Text";
            comboBoxRod.ValueMember = "Value";


            //Type
            query = new MySqlCommand("SELECT * FROM type", connect);

            readerCombo = query.ExecuteReader();

            List<ComboBox_Items> itemsType = new List<ComboBox_Items>();

            while (readerCombo.Read())
            {
                ComboBox_Items itemType = new ComboBox_Items();
                itemType.Text = readerCombo[1].ToString();
                itemType.Value = (int)readerCombo[0];
                itemsType.Add(itemType);
            }

            readerCombo.Close();
            comboBoxType.DataSource = itemsType;
            comboBoxType.DisplayMember = "Text";
            comboBoxType.ValueMember = "Value";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string InsertSql = "INSERT INTO `trees_zaimov`.`tree`" +
                "(`name`, `imageUrl`, `otdel_id`,`class_id`, " +
                "`razred_id`, `family_id`, `rod_id`,`vid_id`," +
                "`description`, DateLastUpdate)" +
                "VALUES (@name, @img, @otdel, @class,@razred, " +
                "@family, @rod, @vid, @info, @dateReg)";

            MySqlConnection connect = new MySqlConnection(connecting);
            if (connect.State == 0)
            {
                connect.Open();
            }

            MySqlCommand query = new MySqlCommand(InsertSql, connect);

            query.Parameters.AddWithValue("@name", txtNaimenovanie.Text);
            query.Parameters.AddWithValue("@img",txtAddImage.Text);
            query.Parameters.AddWithValue("@otdel",comboBoxOtdel.Text);
            query.Parameters.AddWithValue("@class",comboBoxClass.Text);
            query.Parameters.AddWithValue("@razred",comboBoxRazred.Text);
            query.Parameters.AddWithValue("@family",comboBoxFamily.Text);
            query.Parameters.AddWithValue("@rod", comboBoxRod.Text);
            query.Parameters.AddWithValue("@vid", comboBoxType.Text);
            query.Parameters.AddWithValue("@info",txtOpisanie.Text);
            query.Parameters.AddWithValue("@dateReg", DateTime.Now);

            query.ExecuteNonQuery();
            connect.Close();
        }
    }
}