using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PBPro1
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Prashanth\Documents\PBPro1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("insert into tbl_EmployeeDetails values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + "," + textBox5.Text + ")", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deatais were added to the Database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_EmployeeDetails", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        
    }
}
