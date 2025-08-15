namespace zander
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelProg = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelMiddle = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.BackColor = System.Drawing.Color.LightCyan;
            this.labelStudent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelStudent.Location = new System.Drawing.Point(66, 39);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(91, 19);
            this.labelStudent.TabIndex = 0;
            this.labelStudent.Text = "Student No. :";
            this.labelStudent.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelProg
            // 
            this.labelProg.AutoSize = true;
            this.labelProg.BackColor = System.Drawing.Color.LightCyan;
            this.labelProg.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelProg.Location = new System.Drawing.Point(66, 75);
            this.labelProg.Name = "labelProg";
            this.labelProg.Size = new System.Drawing.Size(69, 19);
            this.labelProg.TabIndex = 8;
            this.labelProg.Text = "Program :";
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.BackColor = System.Drawing.Color.LightCyan;
            this.labelLast.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLast.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelLast.Location = new System.Drawing.Point(66, 111);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(82, 19);
            this.labelLast.TabIndex = 9;
            this.labelLast.Text = "Last Name :";
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.BackColor = System.Drawing.Color.LightCyan;
            this.labelFirst.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirst.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelFirst.Location = new System.Drawing.Point(66, 150);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(83, 19);
            this.labelFirst.TabIndex = 10;
            this.labelFirst.Text = "First Name :";
            // 
            // labelMiddle
            // 
            this.labelMiddle.AutoSize = true;
            this.labelMiddle.BackColor = System.Drawing.Color.LightCyan;
            this.labelMiddle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiddle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMiddle.Location = new System.Drawing.Point(66, 188);
            this.labelMiddle.Name = "labelMiddle";
            this.labelMiddle.Size = new System.Drawing.Size(99, 19);
            this.labelMiddle.TabIndex = 11;
            this.labelMiddle.Text = "Middle Name :";
            this.labelMiddle.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.Color.LightCyan;
            this.labelAge.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelAge.Location = new System.Drawing.Point(66, 222);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(40, 19);
            this.labelAge.TabIndex = 12;
            this.labelAge.Text = "Age :";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.LightCyan;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelAddress.Location = new System.Drawing.Point(66, 295);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(65, 19);
            this.labelAddress.TabIndex = 13;
            this.labelAddress.Text = "Address :";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.BackColor = System.Drawing.Color.LightCyan;
            this.labelContact.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelContact.Location = new System.Drawing.Point(66, 257);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(91, 19);
            this.labelContact.TabIndex = 14;
            this.labelContact.Text = "Contact No. :";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkOrange;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Submit.Location = new System.Drawing.Point(106, 367);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(118, 25);
            this.Submit.TabIndex = 15;
            this.Submit.Text = "Submit";
            this.Submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(371, 423);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelMiddle);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelProg);
            this.Controls.Add(this.labelStudent);
            this.Name = "Form2";
            this.Text = "FrmConfirm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelProg;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelMiddle;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Button Submit;
    }
}