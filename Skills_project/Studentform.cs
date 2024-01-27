using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Skills_project
{
    public partial class Studentform : Form
    {
        public Studentform()
        {
            InitializeComponent();
            UpdateRegistrationComboBox();

        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=manoj\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Trust Server Certificate=True");
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Studentform_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_address.Clear();
            txt_contact.Clear();
            txt_gmail.Clear();
            txt_homenum.Clear();
            txt_nic.Clear();
            txt_parentname.Clear();
            txt_phonenum.Clear();
            dob.Value = DateTime.Now; // Set it to the current date, you can choose another default if needed
            male.Checked = false;
            female.Checked = false;

            UpdateRegistrationComboBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a registration number is selected
                if (txt_reg.SelectedItem != null)
                {
                    // Get the selected registration number
                    int selectedRegNo = (int)txt_reg.SelectedItem;

                    // Open a connection to the database
                    using (SqlConnection conn = new SqlConnection(@"Data Source=manoj\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Trust Server Certificate=True"))
                    {
                        conn.Open();

                        // Create a SQL command to delete the record with the selected registration number
                        SqlCommand cmd = new SqlCommand("DELETE FROM registration WHERE regNo = @regNo", conn);
                        cmd.Parameters.AddWithValue("@regNo", selectedRegNo);

                        // Execute the delete command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any rows were affected (record deleted)
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully");
                            // Update the combo box with the latest registration numbers


                        }
                        else
                        {
                            MessageBox.Show("Record not found");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a registration number to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            UpdateRegistrationComboBox();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=manoj\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Trust Server Certificate=True"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO registration VALUES (@regNo, @firstName, @lastName, @dateOfBirth, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo,@gender)", conn);

                    // Assuming 'comboBoxRegNo' is a ComboBox for reg no (assuming it contains integers)
                    int regNo;
                    if (int.TryParse(txt_reg.Text, out regNo))
                    {
                        cmd.Parameters.AddWithValue("@regNo", regNo);
                    }
                    else
                    {
                        MessageBox.Show("Invalid reg no");
                        return; // Stop execution if there's an issue
                    }

                    cmd.Parameters.AddWithValue("@firstName", txt_firstname.Text);
                    cmd.Parameters.AddWithValue("@lastName", txt_lastname.Text);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@address", txt_address.Text);
                    cmd.Parameters.AddWithValue("@email", txt_gmail.Text);
                    cmd.Parameters.AddWithValue("@mobilePhone", txt_phonenum.Text);

                    // Assuming 'txt_homenum' is a TextBox for int
                    int homenum;
                    if (int.TryParse(txt_homenum.Text, out homenum))
                    {
                        cmd.Parameters.AddWithValue("@homePhone", homenum);
                    }
                    else
                    {
                        MessageBox.Show("Invalid home phone number");
                        return; // Stop execution if there's an issue
                    }

                    cmd.Parameters.AddWithValue("@parentName", txt_parentname.Text);
                    cmd.Parameters.AddWithValue("@nic", txt_nic.Text);

                    // Assuming 'txt_contact' is a TextBox for int
                    int contact;
                    if (int.TryParse(txt_contact.Text, out contact))
                    {
                        cmd.Parameters.AddWithValue("@contactNo", contact);
                    }
                    else
                    {
                        MessageBox.Show("Invalid contact number");
                        return; // Stop execution if there's an issue
                    }
                    if (male.Checked)
                    {
                        cmd.Parameters.AddWithValue("@gender", "Male");
                    }
                    else if (female.Checked)
                    {
                        cmd.Parameters.AddWithValue("@gender", "Female");
                    }
                    else
                    {
                        MessageBox.Show("Please select a gender");
                        return; // Stop execution if no gender is selected
                    }



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            UpdateRegistrationComboBox();
        }

        private void txt_reg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=manoj\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Trust Server Certificate=True"))
                {
                    conn.Open();

                    // Assuming 'txt_reg' is a ComboBox for reg no
                    int selectedRegNo;
                    if (int.TryParse(txt_reg.Text, out selectedRegNo))
                    {
                        // Fetch command
                        SqlCommand fetchCmd = new SqlCommand("SELECT * FROM registration WHERE regNo = @regNo", conn);
                        fetchCmd.Parameters.AddWithValue("@regNo", selectedRegNo);

                        SqlDataReader reader = fetchCmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Assuming 'txt_firstname' is a TextBox
                            txt_firstname.Text = reader["firstName"].ToString();
                            txt_lastname.Text = reader["lastName"].ToString();
                            txt_phonenum.Text = reader["mobilePhone"].ToString();

                            // Example for address (txt_address)
                            txt_address.Text = reader["address"].ToString();

                            // Example for email (txt_gmail)
                            txt_gmail.Text = reader["email"].ToString();

                            // Example for parent name (txt_parentname)
                            txt_parentname.Text = reader["parentName"].ToString();

                            // Example for NIC (txt_nic)
                            txt_nic.Text = reader["nic"].ToString();
                            txt_contact.Text = reader["contactNo"].ToString();

                            // Example for contact number (txt_contact)
                            txt_contact.Text = reader["contactNo"].ToString();
                            // Similarly, populate other textboxes, date picker, etc.

                            txt_homenum.Text = reader["homePhone"].ToString();
                            // Example for date of birth (dob)
                            dob.Value = Convert.ToDateTime(reader["dateOfBirth"]);

                            // Example for home phone (txt_homenum)
                            string gender = reader["gender"].ToString();
                            if (gender == "Male")
                            {
                                male.Checked = true;
                            }
                            else if (gender == "Female")
                            {
                                female.Checked = true;
                            }

                            // Similarly, populate other fields
                        }

                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid reg no");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateRegistrationComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=manoj\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Trust Server Certificate=True"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT regNo FROM registration", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    txt_reg.Items.Clear(); // Clear existing items before populating

                    while (reader.Read())
                    {
                        int regNo = reader.GetInt32(0); // Assuming regNo is of type int
                        txt_reg.Items.Add(regNo);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating combo box: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=manoj\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Trust Server Certificate=True"))
                {
                    conn.Open();

                    // Assuming 'comboBoxRegNo' is the ComboBox for reg no
                    int selectedRegNo;
                    if (int.TryParse(txt_reg.Text, out selectedRegNo))
                    {
                        // Update command
                        SqlCommand updateCmd = new SqlCommand("UPDATE registration SET " +
                                                                "firstName = @firstName, " +
                                                                "lastName = @lastName, " +
                                                                "dateOfBirth = @dateOfBirth, " +
                                                                "address = @address, " +
                                                                "email = @email, " +
                                                                "mobilePhone = @mobilePhone, " +
                                                                "homePhone = @homePhone, " +
                                                                "parentName = @parentName, " +
                                                                "nic = @nic, " +
                                                                "contactNo = @contactNo, " +
                                                                "gender = @gender " +
                                                                "WHERE regNo = @regNo", conn);

                        updateCmd.Parameters.AddWithValue("@regNo", selectedRegNo);
                        updateCmd.Parameters.AddWithValue("@firstName", txt_firstname.Text);
                        updateCmd.Parameters.AddWithValue("@lastName", txt_lastname.Text);
                        updateCmd.Parameters.AddWithValue("@dateOfBirth", dob.Value.Date);
                        updateCmd.Parameters.AddWithValue("@address", txt_address.Text);
                        updateCmd.Parameters.AddWithValue("@email", txt_gmail.Text);
                        updateCmd.Parameters.AddWithValue("@mobilePhone", txt_phonenum.Text);

                        // Assuming 'txt_homenum' is a TextBox for int
                        int homenum;
                        if (int.TryParse(txt_homenum.Text, out homenum))
                        {
                            updateCmd.Parameters.AddWithValue("@homePhone", homenum);
                        }
                        else
                        {
                            updateCmd.Parameters.AddWithValue("@homePhone", DBNull.Value);
                        }

                        updateCmd.Parameters.AddWithValue("@parentName", txt_parentname.Text);
                        updateCmd.Parameters.AddWithValue("@nic", txt_nic.Text);

                        // Assuming 'txt_contact' is a TextBox for int
                        int contact;
                        if (int.TryParse(txt_contact.Text, out contact))
                        {
                            updateCmd.Parameters.AddWithValue("@contactNo", contact);
                        }
                        else
                        {
                            updateCmd.Parameters.AddWithValue("@contactNo", DBNull.Value);
                        }
                        if (male.Checked)
                        {
                            updateCmd.Parameters.AddWithValue("@gender", "Male");
                        }
                        else if (female.Checked)
                        {
                            updateCmd.Parameters.AddWithValue("@gender", "Female");
                        }
                        else
                        {
                            updateCmd.Parameters.AddWithValue("@gender", DBNull.Value);
                        }


                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Record updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Invalid reg no");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            UpdateRegistrationComboBox();
        }

    }
}
