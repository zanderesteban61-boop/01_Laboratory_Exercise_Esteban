namespace zander
{
    partial class FrmRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistration));
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelProgram = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtboxStud = new System.Windows.Forms.MaskedTextBox();
            this.txtboxLast = new System.Windows.Forms.TextBox();
            this.txtboxContact = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxFirst = new System.Windows.Forms.TextBox();
            this.txtboxMiddle = new System.Windows.Forms.TextBox();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxProg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStudent.Location = new System.Drawing.Point(49, 71);
            this.labelStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(166, 27);
            this.labelStudent.TabIndex = 0;
            this.labelStudent.Text = " Student No. : ";
            this.labelStudent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelStudent.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelProgram.Location = new System.Drawing.Point(496, 71);
            this.labelProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(143, 27);
            this.labelProgram.TabIndex = 1;
            this.labelProgram.Text = "PROGRAM :";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelContact.Location = new System.Drawing.Point(487, 328);
            this.labelContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(150, 25);
            this.labelContact.TabIndex = 2;
            this.labelContact.Text = "Contact No. :";
            this.labelContact.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAge.Location = new System.Drawing.Point(49, 318);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(74, 25);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = " Age :";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMiddleName.Location = new System.Drawing.Point(610, 212);
            this.labelMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(151, 27);
            this.labelMiddleName.TabIndex = 4;
            this.labelMiddleName.Text = "Middle Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFirstName.Location = new System.Drawing.Point(304, 212);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(142, 27);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = " First Name ";
            this.labelFirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LastName.Location = new System.Drawing.Point(43, 212);
            this.LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(126, 27);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "Last Name";
            this.LastName.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAddress.Location = new System.Drawing.Point(49, 449);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(100, 27);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtboxStud
            // 
            this.txtboxStud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxStud.Location = new System.Drawing.Point(43, 113);
            this.txtboxStud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxStud.Name = "txtboxStud";
            this.txtboxStud.Size = new System.Drawing.Size(350, 20);
            this.txtboxStud.TabIndex = 8;
            this.txtboxStud.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtboxStud_MaskInputRejected);
            // 
            // txtboxLast
            // 
            this.txtboxLast.Location = new System.Drawing.Point(43, 251);
            this.txtboxLast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxLast.Name = "txtboxLast";
            this.txtboxLast.Size = new System.Drawing.Size(209, 20);
            this.txtboxLast.TabIndex = 10;
            this.txtboxLast.TextChanged += new System.EventHandler(this.txtboxLast_TextChanged);
            // 
            // txtboxContact
            // 
            this.txtboxContact.Location = new System.Drawing.Point(489, 362);
            this.txtboxContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxContact.Name = "txtboxContact";
            this.txtboxContact.Size = new System.Drawing.Size(251, 20);
            this.txtboxContact.TabIndex = 11;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAddress.Location = new System.Drawing.Point(43, 488);
            this.txtboxAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxAddress.MaximumSize = new System.Drawing.Size(1000, 230);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(848, 100);
            this.txtboxAddress.TabIndex = 444;
            this.txtboxAddress.TabStop = false;
            this.txtboxAddress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtboxFirst
            // 
            this.txtboxFirst.Location = new System.Drawing.Point(309, 251);
            this.txtboxFirst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxFirst.Name = "txtboxFirst";
            this.txtboxFirst.Size = new System.Drawing.Size(230, 20);
            this.txtboxFirst.TabIndex = 13;
            // 
            // txtboxMiddle
            // 
            this.txtboxMiddle.Location = new System.Drawing.Point(605, 251);
            this.txtboxMiddle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxMiddle.Name = "txtboxMiddle";
            this.txtboxMiddle.Size = new System.Drawing.Size(223, 20);
            this.txtboxMiddle.TabIndex = 14;
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(51, 362);
            this.txtboxAge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(116, 20);
            this.txtboxAge.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(359, 619);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Next ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxProg
            // 
            this.comboBoxProg.FormattingEnabled = true;
            this.comboBoxProg.Items.AddRange(new object[] {
            "BSIT"});
            this.comboBoxProg.Location = new System.Drawing.Point(492, 113);
            this.comboBoxProg.Name = "comboBoxProg";
            this.comboBoxProg.Size = new System.Drawing.Size(363, 21);
            this.comboBoxProg.TabIndex = 446;
            this.comboBoxProg.SelectedIndexChanged += new System.EventHandler(this.comboBoxProg_SelectedIndexChanged);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(975, 698);
            this.Controls.Add(this.comboBoxProg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.txtboxMiddle);
            this.Controls.Add(this.txtboxFirst);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxContact);
            this.Controls.Add(this.txtboxLast);
            this.Controls.Add(this.txtboxStud);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelProgram);
            this.Controls.Add(this.labelStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfirm";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.MaskedTextBox txtboxStud;
        private System.Windows.Forms.TextBox txtboxLast;
        private System.Windows.Forms.TextBox txtboxContact;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.TextBox txtboxFirst;
        private System.Windows.Forms.TextBox txtboxMiddle;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxProg;
    }
}

