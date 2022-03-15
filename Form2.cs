using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N86MPUU\SQLEXPRESS;User ID=sa;Password=*********");
        int a,b, total;
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            int rolno = Convert.ToInt32(textBox4.Text);
            cmd.CommandText = "insert into Tourism values ('" + comboBox1.Text + "','" + label11.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + label12.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Karachi to Khunjrab (with sightseen)")
            {
                label11.Text = "50000";
            }
            if (comboBox1.Text == "Karachi to Islamabad (with sightseen)")
            {
                label11.Text = "18000";
            }
            if (comboBox1.Text == "Islamabad to Naran (with sightseen)")
            {
                label11.Text = "19000";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(label11.Text);
            b = Convert.ToInt32(textBox1.Text);
            total = a * b;
            label12.Text = total.ToString();
        }
    }
}
