using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Xml.Linq;

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


        private void btn_Click(object sender, EventArgs e)
        {
            string insertSQL = "INSERT INTO trees_zaimov.rod " +
               "(`name`,`name_bg` ) " +
               "VALUES (@name,@name_bg)";


            MySqlConnection connect = new MySqlConnection(connecting);
            if (connect.State == 0)
            {
                connect.Open();
            }

            MySqlCommand query = new MySqlCommand(insertSQL, connect);

            query.Parameters.AddWithValue("@name", txtName.Text);
            query.Parameters.AddWithValue("@name_bg", txtNameBg.Text);

            query.ExecuteNonQuery();
            MessageBox.Show("Add in a table Rod");
            connect.Close();
        }
    }
}
