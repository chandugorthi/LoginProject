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
using System.Text.RegularExpressions;

namespace MyLoginProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtReEnterPass.PasswordChar = '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool Isvalid = false;

           Isvalid= NewUserValidate();

            if(Isvalid)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=CITI;Integrated Security=True;Pooling=False"))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_CreateNewUser", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUsername.Text;
                            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPassword.Text;
                            cmd.Parameters.Add("@AccNo", SqlDbType.NVarChar).Value = txtAccNo.Text;

                            con.Open();
                            cmd.ExecuteNonQuery();
                            
                            DialogResult result=MessageBox.Show(this, "Account has been created.To login, click 'OK' or click 'Cancel' to Exit", "Account created", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            this.Close();
                            if (result==DialogResult.OK)
                            {
                                
                                Form1 f = new Form1();
                                f.Show();
                            }
                            
                           
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"SignUp Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


            }
            else
            {
                txtPassword.Text = "";
                txtReEnterPass.Text = "";
            }


        }

        private bool NewUserValidate()
        {
            bool IsMatch = false;
            //Check if UserName already Exrists
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=CITI;Integrated Security=True;Pooling=False"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_getUserId", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUsername.Text;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();
                        if (dt.Rows.Count > 0)
                        {

                            MessageBox.Show(this, "Username already exists. Please try with different username.", "Change Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           
                        }
                        else
                        {
                            //if (this.txtAccNo.Text.Length != 12)
                            if(Regex.IsMatch(this.txtAccNo.Text,@"^[\d]{12}"))
                            {

                                if (string.Equals(txtPassword.Text, txtReEnterPass.Text))
                                {
                                    IsMatch = true;
                                }
                                else
                                {
                                    IsMatch = false;
                                    MessageBox.Show(this, "Passwords doesn't match.Please reenter and try again.", "Create Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                
                            }
                            else
                            {
                                IsMatch = false;
                                MessageBox.Show(this, "Please enter a valid 12 digit Account Number.", "Account Number Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          return IsMatch;          
        }
    }
}
