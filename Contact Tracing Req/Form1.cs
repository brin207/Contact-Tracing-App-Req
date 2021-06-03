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

            if (txtbxName.Text == "" && txtbxAge.Text == "" && txtbxSex.Text == "" && txtbxTemp.Text == "" && txtbxEmail.Text == "" && txtbxPhone.Text == "" && txtbxAddress.Text == "")
            {

                txtbxName.Text == txtbxAge.Text == txtbxSex.Text == txtbxTemp.Text == txtbxEmail.Text == txtbxPhone.Text == txtbxAddress.Bo == Color.Red;
            }
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
        }
    }
}
