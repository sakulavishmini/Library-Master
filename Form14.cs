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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT BookID,BookName,Author FROM BookDeatails",con);
            SqlCommand cmd1 = new SqlCommand("SELECT MemberId,MemberName FROM MemberDetails01", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox2.DataSource = dt;
            comboBox3.DataSource = dt;
            comboBox1.DisplayMember = "BookID";
            comboBox2.DisplayMember = "BookName";
            comboBox3.DisplayMember = "Author";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox4.DataSource = dt1;
            comboBox5.DataSource = dt1;
            comboBox4.DisplayMember = "MemberId";
            comboBox5.DisplayMember = "MemberName";    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || textBox1.Text == "")
                {
                    comboBox1.Text = "";
                    comboBox4.Text = "";
                    MessageBox.Show("Empty Fields are not allowed. Enter All Data");
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[IssueBooks]([BookID],[BookName],[Author],[MemberID],[MemberName],[IssuedID],[Period],[IssueDate],[ReturnDate],[availability])VALUES('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + comboBox6.Text + "')", con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Issued");


                    con.Close();
                    SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
                    con1.Open();
                    // con.Open();
                    SqlCommand cmd1 = new SqlCommand("UPDATE BookDeatails SET Availability=@av WHERE BookID=@BookID", con1);
                    cmd1.Parameters.AddWithValue("BookID", comboBox1.Text);
                    cmd1.Parameters.AddWithValue("av", comboBox6.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Checked");


                    con1.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
        }
    }
}
