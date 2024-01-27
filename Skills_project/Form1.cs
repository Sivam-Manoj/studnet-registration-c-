using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Skills_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=manoj\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Trust Server Certificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string user_name, user_password;

            user_name = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                string query = "SELECT * FROM login WHERE username = @username AND password = @password";
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    sda.SelectCommand.Parameters.AddWithValue("@username", txt_username.Text);
                    sda.SelectCommand.Parameters.AddWithValue("@password", txt_password.Text);

                    DataTable datable = new DataTable();
                    sda.Fill(datable);

                    if (datable.Rows.Count > 0)
                    {
                        user_name = txt_username.Text;
                        user_password = txt_password.Text;

                        Studentform form2 = new Studentform();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Clear();
                        txt_password.Clear();
                        txt_username.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you Want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }
    }
}
