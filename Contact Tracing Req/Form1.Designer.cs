
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.dttmpckr = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(79, 81);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(125, 27);
            this.txtbxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name\r\n";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 137);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxAge
            // 
            this.txtbxAge.Location = new System.Drawing.Point(79, 134);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(49, 27);
            this.txtbxAge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-mail \r\nAddress";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(79, 194);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(125, 27);
            this.txtbxEmail.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 254);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 40);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone\r\nNumber";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Location = new System.Drawing.Point(79, 260);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(125, 27);
            this.txtbxPhone.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(81, 321);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(125, 27);
            this.txtbxAddress.TabIndex = 9;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(12, 383);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(41, 20);
            this.Date.TabIndex = 10;
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dttmpckr
            // 
            this.dttmpckr.Location = new System.Drawing.Point(81, 376);
            this.dttmpckr.Name = "dttmpckr";
            this.dttmpckr.Size = new System.Drawing.Size(250, 27);
            this.dttmpckr.TabIndex = 12;
            this.dttmpckr.Value = new System.DateTime(2021, 6, 2, 18, 27, 51, 0);
            this.dttmpckr.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmContactTracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dttmpckr);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContactTracing";
            this.Text = "Contact Tracing Form";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker dttmpckr;
    }
}

