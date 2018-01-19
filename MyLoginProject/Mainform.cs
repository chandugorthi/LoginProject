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
    public partial class Mainform : Form
    {
        //Variables for ProfileLayout
        private Label lblName = new Label();
        private Label lblAccNo = new Label();
        private Label lblEmailId = new Label();
        private Label lblContNo = new Label();
        private Label lblAddress = new Label();

        private TextBox txtName = new TextBox();
        private TextBox txtAccNo = new TextBox();
        private TextBox txtEmailId = new TextBox();
        private TextBox txtContNo = new TextBox();
        private RichTextBox txtAddress = new RichTextBox();
        private DataGridView UserInfoGridView = new DataGridView();
        private DataGridView TransDetailsGridView = new DataGridView();

        public string name;
        public bool IsAdmin;
        public int count;
        public int IsValidCount;
        //this.lblName.AutoSize = true;

        //    public string UserName
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}




        public Mainform()
        {
            InitializeComponent();
            //LoadMenu();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void LoadMenu()

        {
            this.UserDetails.Visible = true;
            if (IsAdmin == false)
            {
                this.UserDetails.Visible = false;
            }

            this.btnEdit.Visible = false;
            this.btnNew.Visible = false;
            this.btnSave.Visible = false;
            this.btnClose.Visible = true;
            ProfileLayout();
        }

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfileLayout();
        }

        private void ProfileLayout()
        {
            //this.splitContainer1.Visible = false;
            ControlsOnMenuChange();
            //lblName
            this.btnEdit.Visible = true;
            this.btnSave.Visible = true;
            this.btnClose.Visible = true;
            this.btnSave.Enabled = false;
            this.btnEdit.Enabled = true;
            this.btnNew.Enabled = true;
           
            if (IsAdmin == false)
            {
                this.btnNew.Visible = false;

            }
            else
            {
                this.btnNew.Visible = true;

            }
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(32, 41);
            this.lblName.Size = new System.Drawing.Size(123, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "UserName :";
            this.lblName.TextAlign = ContentAlignment.MiddleRight;
            this.lblName.Visible = true;
            //lblAccNo
            this.lblAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNo.Location = new System.Drawing.Point(32, 71);
            this.lblAccNo.Size = new System.Drawing.Size(123, 17);
            this.lblAccNo.TabIndex = 0;
            this.lblAccNo.Text = "Account Number :";
            this.lblAccNo.TextAlign = ContentAlignment.MiddleRight;
            this.lblAccNo.Visible = true;
            //lblEmailId
            this.lblEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailId.Location = new System.Drawing.Point(32, 101);
            this.lblEmailId.Size = new System.Drawing.Size(123, 17);
            this.lblEmailId.TabIndex = 0;
            this.lblEmailId.Text = "Email Id :";
            this.lblEmailId.TextAlign = ContentAlignment.MiddleRight;
            this.lblEmailId.Visible = true;
            //lblContNo
            this.lblContNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContNo.Location = new System.Drawing.Point(32, 131);
            this.lblContNo.Size = new System.Drawing.Size(123, 17);
            this.lblContNo.TabIndex = 0;
            this.lblContNo.Text = "Contact Number :";
            this.lblContNo.TextAlign = ContentAlignment.MiddleRight;
            this.lblContNo.Visible = true;
            //lblAddress
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(32, 161);
            this.lblAddress.Size = new System.Drawing.Size(123, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address :";
            this.lblAddress.TextAlign = ContentAlignment.MiddleRight;
            this.lblAddress.Visible = true;
            //txtName
            this.txtName.Location = new System.Drawing.Point(162, 41);
            this.txtName.Size = new System.Drawing.Size(232, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Visible = true;
            this.txtName.Enabled = false;
            this.txtName.BorderStyle = BorderStyle.Fixed3D;
            //txtAccNo
            this.txtAccNo.Location = new System.Drawing.Point(162, 71);
            this.txtAccNo.Size = new System.Drawing.Size(232, 22);
            this.txtAccNo.TabIndex = 1;
            this.txtAccNo.Visible = true;
            this.txtAccNo.Enabled = false;
            this.txtAccNo.BorderStyle = BorderStyle.Fixed3D;
            //txtEmailId
            this.txtEmailId.Location = new System.Drawing.Point(162, 101);
            this.txtEmailId.Size = new System.Drawing.Size(232, 22);
            this.txtEmailId.TabIndex = 1;
            this.txtEmailId.Visible = true;
            this.txtEmailId.Enabled = false;
            this.txtEmailId.BorderStyle = BorderStyle.Fixed3D;
            //txtContNo
            this.txtContNo.Location = new System.Drawing.Point(162, 131);
            this.txtContNo.Size = new System.Drawing.Size(232, 22);
            this.txtContNo.TabIndex = 1;
            this.txtContNo.Visible = true;
            this.txtContNo.Enabled = false;
            this.txtContNo.BorderStyle = BorderStyle.Fixed3D;
            //txtAddress
            this.txtAddress.Location = new System.Drawing.Point(162, 161);
            this.txtAddress.Size = new System.Drawing.Size(232, 143);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Visible = true;
            this.txtAddress.Enabled = false;
            this.txtAddress.BorderStyle = BorderStyle.Fixed3D;

            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.Controls.Add(this.lblAccNo);
            this.splitContainer1.Panel1.Controls.Add(this.lblEmailId);
            this.splitContainer1.Panel1.Controls.Add(this.lblContNo);
            this.splitContainer1.Panel1.Controls.Add(this.lblAddress);

            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.txtAccNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmailId);
            this.splitContainer1.Panel1.Controls.Add(this.txtContNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddress);
            //
            //SQl connection and write an sp to get the data from UserProfile table and display it on the screen.
            //

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=CITI;Integrated Security=True;Pooling=False"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_getUserProfile", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = this.name;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();

                        this.txtName.Text = dt.Rows[0]["Name"].ToString();
                        this.txtAccNo.Text = dt.Rows[0]["AccountNo"].ToString();
                        this.txtEmailId.Text = dt.Rows[0]["EmailId"].ToString();
                        this.txtContNo.Text = dt.Rows[0]["ContactNo"].ToString();
                        this.txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {

                MessageBox.Show(this, "As per our records your profile is not yet updated. Please Visit your nearest CITI bank and update your profile.", "User's Data Unvailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Something is not right.Please try to login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ControlsOnMenuChange()
        {


            this.splitContainer1.Panel1.Controls.Remove(this.lblName);
            this.splitContainer1.Panel1.Controls.Remove(this.lblAccNo);
            this.splitContainer1.Panel1.Controls.Remove(this.lblEmailId);
            this.splitContainer1.Panel1.Controls.Remove(this.lblContNo);
            this.splitContainer1.Panel1.Controls.Remove(this.lblAddress);

            this.splitContainer1.Panel1.Controls.Remove(this.txtName);
            this.splitContainer1.Panel1.Controls.Remove(this.txtAccNo);
            this.splitContainer1.Panel1.Controls.Remove(this.txtEmailId);
            this.splitContainer1.Panel1.Controls.Remove(this.txtContNo);
            this.splitContainer1.Panel1.Controls.Remove(this.txtAddress);

            this.splitContainer1.Panel1.Controls.Remove(this.UserInfoGridView);
            this.splitContainer1.Panel1.Controls.Remove(this.TransDetailsGridView);

            this.btnEdit.Visible = false;
            this.btnNew.Visible = false;
            this.btnSave.Visible = false;
            this.btnClose.Visible = false;


        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserDetails_Click(object sender, EventArgs e)
        {
            ControlsOnMenuChange();
            this.splitContainer1.Panel1.Controls.Add(this.UserInfoGridView);
            this.UserInfoGridView.Size = new System.Drawing.Size(800, 320);
            try
            {



                using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=CITI;Integrated Security=True;Pooling=False"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_getAllUsersDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = this.UserName;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "UserProfile");
                        con.Close();
                        UserInfoGridView.DataSource = ds;
                        UserInfoGridView.DataMember = "UserProfile";
                    }
                }
                this.UserInfoGridView.ReadOnly = true;
                if (this.UserInfoGridView.Rows.Count != 0)
                {
                    for (int i = 0; i < UserInfoGridView.Columns.Count; i++)
                    {
                        if (i == UserInfoGridView.Columns.Count - 1)
                        {
                            this.UserInfoGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        else
                            this.UserInfoGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    }


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, "Something is not right.Please try to login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void transactionDeatilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlsOnMenuChange();
            this.splitContainer1.Panel1.Controls.Add(this.TransDetailsGridView);
            this.TransDetailsGridView.Size = new System.Drawing.Size(800, 320);



            try
            {


                using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=CITI;Integrated Security=True;Pooling=False"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_getTransactionDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = this.name;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        DataTable dt = new DataTable();

                        da.Fill(ds);
                        dt = ds.Tables[0];
                        con.Close();
                        TransDetailsGridView.DataSource = dt.DefaultView;
                        // TransDetailsGridView.DataMember = dt;

                    }
                }
                this.TransDetailsGridView.ReadOnly = true;
                if (this.TransDetailsGridView.Rows.Count != 0)
                {
                    this.TransDetailsGridView.Columns[0].HeaderText = "Transaction Id";
                    this.TransDetailsGridView.Columns[1].HeaderText = "User Name";
                    this.TransDetailsGridView.Columns[2].HeaderText = "Debit Or Credit";
                    this.TransDetailsGridView.Columns[3].HeaderText = "Amount";
                    this.TransDetailsGridView.Columns[4].HeaderText = "Transaction Date";

                    this.TransDetailsGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.TransDetailsGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.TransDetailsGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.TransDetailsGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.TransDetailsGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(this, "Something is not right.Please try to login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult close = new DialogResult();
                close = MessageBox.Show("Do you want exit?", "Exit",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2);
                if (close == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }

            base.OnFormClosing(e);
            //Form1 frm = new Form1();
            //frm.Close();
            // CloseOpenForms();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            this.txtName.Enabled = false;
            this.txtAccNo.Enabled = false;
            this.txtContNo.Enabled = true;
            this.txtEmailId.Enabled = true;
            this.txtAddress.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnNew.Enabled = true;
            this.btnSave.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           int x= UserProfileValidations();
            if (x == 0)
            {
                int i = SaveUserProfile();
                if (i > 0)
                {
                    MessageBox.Show(this, "Profile has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ProfileLayout();
                }
            }

        }

        private int SaveUserProfile()
        {
            count = 0;
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=CITI;Integrated Security=True;Pooling=False"))
                {
                    using (SqlCommand cmd1 = new SqlCommand("sp_getUserId", con))
                    {
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.Add("@Username", SqlDbType.NVarChar).Value = this.txtName.Text;
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            
                            count = 0;

                        }
                        else
                            count = -1;

                        con.Close();    
                    }
                    if(count==-1)
                    {
                        using (SqlCommand cmd2 = new SqlCommand("sp_CreateUser", con))
                        {
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@Username", SqlDbType.NVarChar).Value = this.txtName.Text;
                            con.Open();

                            cmd2.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter(cmd2);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show(this,"New User Id and Password have been geneated for the user with ID as '" + this.txtName.Text + "' and Password as 'CITI'.","UserId generated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            else
                                return count;

                            con.Close();
                        }
                    }
                        using (SqlCommand cmd = new SqlCommand("sp_InsertRUpdateUserProfile", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = this.name;
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = this.txtName.Text;
                        cmd.Parameters.Add("@AccNo", SqlDbType.NVarChar).Value = this.txtAccNo.Text;
                        cmd.Parameters.Add("@EmailId", SqlDbType.NVarChar).Value = this.txtEmailId.Text;
                        cmd.Parameters.Add("@ContactNo", SqlDbType.NVarChar).Value = this.txtContNo.Text;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = this.txtAddress.Text;
                        con.Open();

                        cmd.ExecuteNonQuery();
                        count = 1;
                        con.Close();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Something is not right.Please try after sometime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return count;
        }
        private int UserProfileValidations()
        {
            IsValidCount = 0;
            StringBuilder sb = new StringBuilder("Hi " + this.name.ToString());
            sb.AppendLine();
            if (this.txtName.Text.Length > 50)
            {
                sb.AppendLine("Name Should be not exceed 50 characters.");
                
            }
            if (this.txtName.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please specify a User Name.");
            }
            if (this.txtAccNo.Text.Length != 12)
            {
                sb.AppendLine("Please enter a valid 12 digit Account Number.");
                
            }
            if(this.txtEmailId.Text.Length>50)
            {
                sb.AppendLine("EmailId Should be not exceed 50 characters.");

            }
            if(this.txtContNo.Text.Length!=10)
            {
                sb.AppendLine("Please enter a valid 10 digit Contact Number.");
            }
            if(this.txtAddress.Text.Length>100)
            {
                sb.AppendLine("Address Should be not exceed 100 characters.");
            }
            if (this.txtAddress.Text.Length > 100 || this.txtContNo.Text.Length != 10 || this.txtEmailId.Text.Length > 50 || this.txtAccNo.Text.Length != 12 || this.txtName.Text.Length > 50)

            {
                IsValidCount++;
                MessageBox.Show(this, sb.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return IsValidCount;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtAccNo.Text = "";
            this.txtContNo.Text = "";
            this.txtEmailId.Text = "";
            this.txtAddress.Text = "";
            this.txtName.Enabled = true;
            this.txtAccNo.Enabled = true;
            this.txtContNo.Enabled = true;
            this.txtEmailId.Enabled = true;
            this.txtAddress.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnEdit.Enabled = false;
        }
    }
}
