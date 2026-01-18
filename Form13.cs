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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM MemberDetails01 WHERE MemberId=@MemberId", con);
            cmd.Parameters.AddWithValue("@MemberId",textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            MessageBox.Show("Deleted");
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM MemberDetails01 WHERE MemberId=@MemberId", con);
                    cmd.Parameters.AddWithValue("MemberId", textBox1.Text);
                    SqlDataReader da = cmd.ExecuteReader();
                    if (da.Read())
                    {
                        textBox2.Text = da.GetValue(1).ToString();
                        textBox4.Text = da.GetValue(2).ToString();
                        textBox5.Text = da.GetValue(3).ToString();
                        textBox6.Text = da.GetValue(4).ToString();
                        textBox7.Text = da.GetValue(5).ToString();
                        textBox8.Text = da.GetValue(6).ToString();
                        textBox9.Text = da.GetValue(7).ToString();
                        textBox10.Text = da.GetValue(8).ToString();
                    }
                    else
                    {
                        textBox2.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox9.Clear();
                        textBox10.Clear();
                        MessageBox.Show("No Record Found");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Member ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE MemberDetails01 SET MemberName=@MemberName,NIC=@NIC,Address=@Address,TelephoneNo=@TelephoneNo,Email=@Email,Gender=@Gender,DateofBirth=@DateofBirth,DateofAddmition=@DateofAddmition Where MemberId=@MemberId", con);
            cmd.Parameters.AddWithValue("@MemberId",textBox1.Text);
            cmd.Parameters.AddWithValue("@MemberName", textBox2.Text);
            cmd.Parameters.AddWithValue("@NIC", textBox4.Text);
            cmd.Parameters.AddWithValue("@Address", textBox5.Text);
            cmd.Parameters.AddWithValue("@TelephoneNo", textBox6.Text);
            cmd.Parameters.AddWithValue("@Email", textBox7.Text);
            cmd.Parameters.AddWithValue("@Gender", textBox8.Text);
            cmd.Parameters.AddWithValue("@DateofBirth", textBox9.Text);
            cmd.Parameters.AddWithValue("@DateofAddmition", textBox10.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form20 f20 = new Form20();
            f20.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.Show();
            this.Hide();
        }
    }
}
