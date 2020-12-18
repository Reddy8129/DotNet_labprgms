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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Prashanth\Documents\PBPro1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Project Manager")
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select IdEmployee,EmployeeName,ContactNumber,IdDesignation,IdReporting from tbl_EmployeeDetails where IdDesignation like'" + textBox1.Text + "%'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        con.Close();
                    }
                 else if (comboBox1.Text == "Project Leader")
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select IdEmployee,EmployeeName,ContactNumber,IdDesignation,IdReporting from tbl_EmployeeDetails where IdDesignation like'" + textBox1.Text + "%'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        con.Close();
                     }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

         
       
    }
}
