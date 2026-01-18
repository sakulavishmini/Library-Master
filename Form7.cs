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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM BookDeatails  WHERE BookID=@BookID", con);
                    cmd.Parameters.AddWithValue("@BookID", textBox1.Text);
                    SqlDataReader da = cmd.ExecuteReader();
                    if (da.Read())
                    {
                        textBox2.Text = da.GetValue(1).ToString();
                        textBox3.Text = da.GetValue(2).ToString();
                        textBox4.Text = da.GetValue(3).ToString();
                        textBox5.Text = da.GetValue(4).ToString();
                        textBox6.Text = da.GetValue(5).ToString();
                        textBox7.Text = da.GetValue(6).ToString();
                        textBox8.Text = da.GetValue(7).ToString();
                        textBox9.Text = da.GetValue(8).ToString();
                    }
                    else
                    {
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox9.Clear();
                        MessageBox.Show("No Record Found.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter BookID.");
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
            SqlCommand cmd = new SqlCommand("UPDATE BookDeatails  SET BookName=@BookName,Author=@Author,Genre=@Genre,Price=@Price,Quntity=@Quntity,RackNo=@RackNo,DateofAdded=@DateofAdded, Availability=@Availability WHERE BookID=@BookID", con);
            cmd.Parameters.AddWithValue("@BookID", textBox1.Text);
            cmd.Parameters.AddWithValue("@BookName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Author", textBox3.Text);
            cmd.Parameters.AddWithValue("@Genre", textBox4.Text);
            cmd.Parameters.AddWithValue("@Price", textBox5.Text);
            cmd.Parameters.AddWithValue("@Quntity", textBox6.Text);
            cmd.Parameters.AddWithValue("@RackNo", textBox7.Text);
            cmd.Parameters.AddWithValue("@DateofAdded", textBox8.Text);
            cmd.Parameters.AddWithValue("@Availability", textBox8.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM BookDeatails WHERE BookID=@BookID", con);
            cmd.Parameters.AddWithValue("@BookId",textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            MessageBox.Show("Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
