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
    public partial class Form15 : Form
    {
        public Form15()
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

        private void Form15_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT BookID,BookName,Author,MemberID,MemberName,IssuedID FROM IssueBooks", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox2.DataSource = dt;
            comboBox3.DataSource = dt;
            comboBox4.DataSource = dt;
            comboBox5.DataSource = dt;
            comboBox6.DataSource = dt;
            comboBox1.DisplayMember = "BookID";
            comboBox2.DisplayMember = "BookName";
            comboBox3.DisplayMember = "Author";
            comboBox4.DisplayMember = "MemberID";
            comboBox5.DisplayMember = "MemberName";
            comboBox6.DisplayMember = "IssuedID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "")
                {
                    comboBox1.Text = "";
                    MessageBox.Show("Empty fields are not allowed. Enter All Data"); 
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[ReturnBooks01]([BookID],[BookName],[Author],[MemberID],[MemberName],[IssuedID],[ReturnDate],[availability])VALUES('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "','" + dateTimePicker1.Value + "','" + comboBox7.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Returned");
                    con.Close();

                    SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-UTRJ5HQ;Initial Catalog=LIBRARYMASTER01NEW;Integrated Security=True");
                    con1.Open();
                    // con.Open();
                    SqlCommand cmd1 = new SqlCommand("UPDATE BookDeatails SET Availability=@av WHERE BookID=@BookID", con1);
                    cmd1.Parameters.AddWithValue("BookID", comboBox1.Text);
                    cmd1.Parameters.AddWithValue("av", comboBox7.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Checked");


                    con1.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox4.Text = "";
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
