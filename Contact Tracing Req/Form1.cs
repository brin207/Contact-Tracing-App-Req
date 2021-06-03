using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Contact_Tracing_Req
{
    public partial class frmContactTracing : Form
    {
       
        public frmContactTracing()
        {
            InitializeComponent();
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTimeO_Click(object sender, EventArgs e)
        {

        }

        private void lblTimeI_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool na = false;
            //txtbxName.BackColor = txtbxAge.BackColor = txtbxSex.BackColor = txtbxTemp.BackColor = txtbxEmail.BackColor = txtbxPhone.BackColor = txtbxAddress.BackColor = Color.FromArgb(225, 192, 192);
            //txtbxName.Text == "" && txtbxAge.Text == "" && txtbxSex.Text == "" && txtbxTemp.Text == "" && txtbxEmail.Text == "" && txtbxPhone.Text == "" && txtbxAddress.Text == ""
            foreach(Control ctrl in grpbxPersonal.Controls)
            {
                if (ctrl is TextBox)
                {

                    if (ctrl.Text == "")
                    {

                        ctrl.BackColor = Color.FromArgb(225, 192, 192);
                        na = true;
                        lblWarn.Visible = true;
                    }
                    else if(ctrl.Text != "")
                    {

                        ctrl.BackColor = Color.White;
                    }
                }
            }

            foreach (Control ctrl in grpbxContact.Controls)
            {
                if (ctrl is TextBox)
                {

                    if (ctrl.Text == "")
                    {

                        ctrl.BackColor = Color.FromArgb(225, 192, 192);
                        na = true;
                        lblWarn.Visible = true;
                    }
                    else if (ctrl.Text != "")
                    {

                        ctrl.BackColor = Color.White;
                    }
                }
            }

            if (na == false)
            {
                lblWarn.Visible = false;
                DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Submit", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    StreamWriter outptFile;
                    outptFile = File.AppendText("Data.txt");
                    outptFile.WriteLine("=====");
                    outptFile.WriteLine(txtbxName.Text);
                    outptFile.WriteLine(txtbxAge.Text);
                    outptFile.WriteLine(txtbxSex.Text);
                    outptFile.WriteLine(txtbxTemp.Text);
                    outptFile.WriteLine(txtbxEmail.Text);
                    outptFile.WriteLine(txtbxPhone.Text);
                    outptFile.WriteLine(txtbxAddress.Text);
                    outptFile.WriteLine(dttmpckrDate.Value);
                    outptFile.WriteLine(dttmpckrTimeI.Value);
                    outptFile.WriteLine(dttmpckrTimeO.Value);
                    outptFile.Close();
                    DialogResult result1 = MessageBox.Show("Your response is submitted. Thank You!\nDo you want to submit another form?", "Thank You!", MessageBoxButtons.YesNo);

                    if (result1 == DialogResult.Yes)
                    {

                        txtbxName.Text = txtbxAge.Text = txtbxSex.Text = txtbxTemp.Text = txtbxEmail.Text = txtbxPhone.Text = txtbxAddress.Text = "";
                    }
                    else if (result1 == DialogResult.No)
                    {

                        System.Windows.Forms.Application.Exit();
                    }
                }
                else if (result == DialogResult.No)
                {

                    //None
                }
            }













         
        }

        private void frmContactTracing_Load(object sender, EventArgs e)
        {

        }

        private void lblWarn_Click(object sender, EventArgs e)
        {

        }
    }
}
