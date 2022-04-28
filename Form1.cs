using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertDB();
        }

        private void insertDB()
        {
            String connectString = "Server=127.0.0.1;Database = webdev;Uid=webmaster;Pwd=1234";
            MySqlConnection conn = new MySqlConnection(connectString);

            try
            {
                conn.Open();
                String query = "insert into tb2_dbconnect (machineName,userName,date) " +
                                 "values(\'" + textBox1.Text + "\',\'" + textBox2.Text + "\',\'" + textBox3.Text + "\')";


                MySqlCommand mySqlCommand = new MySqlCommand(query, conn);
                MessageBox.Show("DB연결이 성공하였습니다.");
                mySqlCommand.ExecuteNonQuery();

                conn.Close();

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString() + " " + "DB연결이 실패했습니다.");
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
