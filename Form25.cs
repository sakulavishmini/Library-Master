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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM StaffDetails01 WHERE StaffId=@StaffId", con);
            cmd.Parameters.AddWithValue("@StaffId", textBox1.Text);
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
            textBox11.Clear();
            textBox12.Clear();
            MessageBox.Show("Deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE StaffDetails01 SET StaffId=@StaffId, MemberName=@MemberName, NIC=@NIC, Address=@Address, TelephoneNo=@TelephoneNo, Email=@Email, DateofBirth=@DateofBirth, Gender=@Gender, Position=@Position, Salary=@Salary, DateofAppoinment=@DateofAppoinment where StaffId=@StaffId", con);
            cmd.Parameters.AddWithValue("@StaffId", textBox1.Text);
            cmd.Parameters.AddWithValue("@MemberName", textBox2.Text);
            cmd.Parameters.AddWithValue("@NIC", textBox4.Text);
            cmd.Parameters.AddWithValue("@Address", textBox5.Text);
            cmd.Parameters.AddWithValue("@TelephoneNo", textBox6.Text);
            cmd.Parameters.AddWithValue("@Email", textBox7.Text);
            cmd.Parameters.AddWithValue("@DateofBirth", textBox8.Text);
            cmd.Parameters.AddWithValue("@Gender", textBox9.Text);
            cmd.Parameters.AddWithValue("@Position", textBox10.Text);
            cmd.Parameters.AddWithValue("@Salary", textBox11.Text);
            cmd.Parameters.AddWithValue("@DateofAppoinment", textBox12.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void Form25_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 f24 = new Form24();
            f24.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM StaffDetails01 WHERE StaffId=@StaffId", con);
                    cmd.Parameters.AddWithValue("@StaffId", textBox1.Text);
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
                        textBox11.Text = da.GetValue(9).ToString();
                        textBox12.Text = da.GetValue(10).ToString();
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
                        textBox11.Clear();
                        textBox12.Clear();
                        MessageBox.Show("NO Record Found");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Staff ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
            textBox11.Clear();
            textBox12.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
