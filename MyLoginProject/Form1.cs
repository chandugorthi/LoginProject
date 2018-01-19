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


namespace MyLoginProject
{
    public partial class Form1 : Form
    {
        public bool IsAdmin;
        
      
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refresh()
        {
            Form1 f = new Form1();
            f.Refresh();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            IsAdmin = false ;

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=CITI;Integrated Security=True;Pooling=False"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_IsValidUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUserName.Text;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPassword.Text;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {

                            if (dt.Rows[0][0].ToString() == "True")
                            {
                                IsAdmin = true;
                            }


                            Mainform mainfrm = new Mainform();


                            mainfrm.name = txtUserName.Text;

                            mainfrm.IsAdmin = IsAdmin;
                            mainfrm.LoadMenu();
                            this.Hide();
                            mainfrm.Show();
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show(this, "Username or Password is incorrect.Click 'Ok' to login again or 'Cancel' to Exit.", "Invalid User", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (result == DialogResult.OK)
                            {
                                refresh();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        con.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //label1.Text = IsAdmin.ToString();
           
        }
    }
}
