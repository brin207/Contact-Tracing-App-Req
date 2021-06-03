
namespace Contact_Tracing_Req
{
    partial class frmContactTracing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactTracing));
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.lblResidence = new System.Windows.Forms.Label();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.dttmpckrDate = new System.Windows.Forms.DateTimePicker();
            this.txtbxSex = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtbxTemp = new System.Windows.Forms.TextBox();
            this.lblTimeI = new System.Windows.Forms.Label();
            this.lblTimeO = new System.Windows.Forms.Label();
            this.dttmpckrTimeI = new System.Windows.Forms.DateTimePicker();
            this.dttmpckrTimeO = new System.Windows.Forms.DateTimePicker();
            this.grpbxDate = new System.Windows.Forms.GroupBox();
            this.grpbxContact = new System.Windows.Forms.GroupBox();
            this.grpbxPersonal = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblNamed = new System.Windows.Forms.Label();
            this.lblTempd = new System.Windows.Forms.Label();
            this.lblResidd = new System.Windows.Forms.Label();
            this.grpbxDate.SuspendLayout();
            this.grpbxContact.SuspendLayout();
            this.grpbxPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(73, 43);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(246, 27);
            this.txtbxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name\r\n";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(6, 106);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxAge
            // 
            this.txtbxAge.Location = new System.Drawing.Point(73, 102);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(66, 27);
            this.txtbxAge.TabIndex = 3;
            this.txtbxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-mail \r\nAddress";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(136, 46);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(188, 27);
            this.txtbxEmail.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(25, 97);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 40);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone\r\nNumber";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Location = new System.Drawing.Point(136, 103);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(188, 27);
            this.txtbxPhone.TabIndex = 7;
            // 
            // lblResidence
            // 
            this.lblResidence.AutoSize = true;
            this.lblResidence.Location = new System.Drawing.Point(25, 155);
            this.lblResidence.Name = "lblResidence";
            this.lblResidence.Size = new System.Drawing.Size(76, 20);
            this.lblResidence.TabIndex = 8;
            this.lblResidence.Text = "Residence";
            this.lblResidence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(138, 155);
            this.txtbxAddress.Multiline = true;
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(186, 156);
            this.txtbxAddress.TabIndex = 9;
            // 
            // dttmpckrDate
            // 
            this.dttmpckrDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckrDate.Location = new System.Drawing.Point(47, 26);
            this.dttmpckrDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dttmpckrDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dttmpckrDate.Name = "dttmpckrDate";
            this.dttmpckrDate.Size = new System.Drawing.Size(125, 27);
            this.dttmpckrDate.TabIndex = 12;
            this.dttmpckrDate.Value = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            this.dttmpckrDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtbxSex
            // 
            this.txtbxSex.Location = new System.Drawing.Point(73, 152);
            this.txtbxSex.Name = "txtbxSex";
            this.txtbxSex.Size = new System.Drawing.Size(144, 27);
            this.txtbxSex.TabIndex = 13;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(6, 158);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(32, 20);
            this.lblSex.TabIndex = 14;
            this.lblSex.Text = "Sex";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(153, 106);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(93, 20);
            this.lblTemp.TabIndex = 15;
            this.lblTemp.Text = "Temperature";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxTemp
            // 
            this.txtbxTemp.Location = new System.Drawing.Point(252, 102);
            this.txtbxTemp.Name = "txtbxTemp";
            this.txtbxTemp.Size = new System.Drawing.Size(67, 27);
            this.txtbxTemp.TabIndex = 16;
            this.txtbxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTimeI
            // 
            this.lblTimeI.AutoSize = true;
            this.lblTimeI.Location = new System.Drawing.Point(34, 80);
            this.lblTimeI.Name = "lblTimeI";
            this.lblTimeI.Size = new System.Drawing.Size(58, 20);
            this.lblTimeI.TabIndex = 17;
            this.lblTimeI.Text = "Time In";
            this.lblTimeI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTimeI.Click += new System.EventHandler(this.lblTimeI_Click);
            // 
            // lblTimeO
            // 
            this.lblTimeO.AutoSize = true;
            this.lblTimeO.Location = new System.Drawing.Point(32, 113);
            this.lblTimeO.Name = "lblTimeO";
            this.lblTimeO.Size = new System.Drawing.Size(70, 20);
            this.lblTimeO.TabIndex = 18;
            this.lblTimeO.Text = "Time Out";
            this.lblTimeO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTimeO.Click += new System.EventHandler(this.lblTimeO_Click);
            // 
            // dttmpckrTimeI
            // 
            this.dttmpckrTimeI.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttmpckrTimeI.Location = new System.Drawing.Point(108, 75);
            this.dttmpckrTimeI.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dttmpckrTimeI.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dttmpckrTimeI.Name = "dttmpckrTimeI";
            this.dttmpckrTimeI.ShowUpDown = true;
            this.dttmpckrTimeI.Size = new System.Drawing.Size(125, 27);
            this.dttmpckrTimeI.TabIndex = 19;
            this.dttmpckrTimeI.Value = new System.DateTime(2021, 6, 3, 14, 15, 20, 0);
            // 
            // dttmpckrTimeO
            // 
            this.dttmpckrTimeO.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttmpckrTimeO.Location = new System.Drawing.Point(108, 108);
            this.dttmpckrTimeO.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dttmpckrTimeO.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dttmpckrTimeO.Name = "dttmpckrTimeO";
            this.dttmpckrTimeO.ShowUpDown = true;
            this.dttmpckrTimeO.Size = new System.Drawing.Size(125, 27);
            this.dttmpckrTimeO.TabIndex = 20;
            this.dttmpckrTimeO.Value = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            // 
            // grpbxDate
            // 
            this.grpbxDate.Controls.Add(this.dttmpckrDate);
            this.grpbxDate.Controls.Add(this.lblTimeO);
            this.grpbxDate.Controls.Add(this.dttmpckrTimeO);
            this.grpbxDate.Controls.Add(this.lblTimeI);
            this.grpbxDate.Controls.Add(this.dttmpckrTimeI);
            this.grpbxDate.Location = new System.Drawing.Point(68, 412);
            this.grpbxDate.Name = "grpbxDate";
            this.grpbxDate.Size = new System.Drawing.Size(271, 160);
            this.grpbxDate.TabIndex = 21;
            this.grpbxDate.TabStop = false;
            this.grpbxDate.Text = "Date";
            // 
            // grpbxContact
            // 
            this.grpbxContact.Controls.Add(this.lblResidd);
            this.grpbxContact.Controls.Add(this.txtbxEmail);
            this.grpbxContact.Controls.Add(this.label1);
            this.grpbxContact.Controls.Add(this.txtbxPhone);
            this.grpbxContact.Controls.Add(this.txtbxAddress);
            this.grpbxContact.Controls.Add(this.lblPhone);
            this.grpbxContact.Controls.Add(this.lblResidence);
            this.grpbxContact.Location = new System.Drawing.Point(400, 196);
            this.grpbxContact.Name = "grpbxContact";
            this.grpbxContact.Size = new System.Drawing.Size(365, 333);
            this.grpbxContact.TabIndex = 22;
            this.grpbxContact.TabStop = false;
            this.grpbxContact.Text = "Contact Info.";
            // 
            // grpbxPersonal
            // 
            this.grpbxPersonal.Controls.Add(this.lblTempd);
            this.grpbxPersonal.Controls.Add(this.lblNamed);
            this.grpbxPersonal.Controls.Add(this.txtbxName);
            this.grpbxPersonal.Controls.Add(this.lblName);
            this.grpbxPersonal.Controls.Add(this.txtbxAge);
            this.grpbxPersonal.Controls.Add(this.txtbxTemp);
            this.grpbxPersonal.Controls.Add(this.lblAge);
            this.grpbxPersonal.Controls.Add(this.lblTemp);
            this.grpbxPersonal.Controls.Add(this.txtbxSex);
            this.grpbxPersonal.Controls.Add(this.lblSex);
            this.grpbxPersonal.Location = new System.Drawing.Point(32, 196);
            this.grpbxPersonal.Name = "grpbxPersonal";
            this.grpbxPersonal.Size = new System.Drawing.Size(343, 210);
            this.grpbxPersonal.TabIndex = 23;
            this.grpbxPersonal.TabStop = false;
            this.grpbxPersonal.Text = "Personal Info.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(99, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(609, 62);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "CONTACT TRACING FORM";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.Location = new System.Drawing.Point(187, 71);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(417, 31);
            this.lblTitle2.TabIndex = 25;
            this.lblTitle2.Text = "For Prevention and Control of COVID-19";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(120, 111);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(574, 60);
            this.lblDesc.TabIndex = 26;
            this.lblDesc.Text = "The data collected through this form is protected by RA 10173, Data Privacy Act o" +
    "f 2012,\r\nand that you are required by RA 11469, Bayanihan to Heal as One Act, \r\n" +
    "to provide truthful information.";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(517, 549);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 41);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblNamed
            // 
            this.lblNamed.AutoSize = true;
            this.lblNamed.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNamed.Location = new System.Drawing.Point(73, 71);
            this.lblNamed.Name = "lblNamed";
            this.lblNamed.Size = new System.Drawing.Size(168, 17);
            this.lblNamed.TabIndex = 17;
            this.lblNamed.Text = "(Last Name, First Name M.I.)";
            // 
            // lblTempd
            // 
            this.lblTempd.AutoSize = true;
            this.lblTempd.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTempd.Location = new System.Drawing.Point(264, 132);
            this.lblTempd.Name = "lblTempd";
            this.lblTempd.Size = new System.Drawing.Size(43, 17);
            this.lblTempd.TabIndex = 18;
            this.lblTempd.Text = "(in °C)";
            // 
            // lblResidd
            // 
            this.lblResidd.AutoSize = true;
            this.lblResidd.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblResidd.Location = new System.Drawing.Point(33, 175);
            this.lblResidd.Name = "lblResidd";
            this.lblResidd.Size = new System.Drawing.Size(86, 85);
            this.lblResidd.TabIndex = 18;
            this.lblResidd.Text = "(Bldg, Street,\r\nBarangay, \r\nCity, Province,\r\nRegion, \r\nPostal Code)";
            // 
            // frmContactTracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpbxPersonal);
            this.Controls.Add(this.grpbxContact);
            this.Controls.Add(this.grpbxDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContactTracing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Form";
            this.grpbxDate.ResumeLayout(false);
            this.grpbxDate.PerformLayout();
            this.grpbxContact.ResumeLayout(false);
            this.grpbxContact.PerformLayout();
            this.grpbxPersonal.ResumeLayout(false);
            this.grpbxPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.Label lblResidence;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.DateTimePicker dttmpckrDate;
        private System.Windows.Forms.TextBox txtbxSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtbxTemp;
        private System.Windows.Forms.Label lblTimeI;
        private System.Windows.Forms.Label lblTimeO;
        private System.Windows.Forms.DateTimePicker dttmpckrTimeI;
        private System.Windows.Forms.DateTimePicker dttmpckrTimeO;
        private System.Windows.Forms.GroupBox grpbxDate;
        private System.Windows.Forms.GroupBox grpbxContact;
        private System.Windows.Forms.GroupBox grpbxPersonal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResidd;
        private System.Windows.Forms.Label lblTempd;
        private System.Windows.Forms.Label lblNamed;
    }
}

