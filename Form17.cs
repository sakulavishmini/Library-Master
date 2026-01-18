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

namespace WindowsFormsApplication3
{
    public partial class Form17 : Form
    {
        string PaymentType;
        public Form17()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || PaymentType == "" || textBox1.Text == "" || textBox2.Text == "")
                {
                    comboBox1.Text = "";
                    MessageBox.Show("Empty fields are not allowed. Enter All Data"); 
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[PaymentDetails01]([MemeberID],[MemberName],[PaymentType],[Amount],[BillNumber],[PaymentDate])VALUES('" + comboBox1.Text + "','" + comboBox2.Text + "','" + PaymentType + "','" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paid");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PaymentType = "New Membership";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PaymentType = "Renew Membership";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PaymentType = "Fines";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT MemberId, MemberName FROM MemberDetails01", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox2.DataSource = dt;
            comboBox1.DisplayMember = "MemberId";
            comboBox2.DisplayMember = "MemberName";
        }
    }
}
