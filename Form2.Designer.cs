namespace FirstWindowForm
{
    partial class frmNext
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
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbYellow = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAnd = new System.Windows.Forms.CheckBox();
            this.chkJv = new System.Windows.Forms.CheckBox();
            this.chkIsad = new System.Windows.Forms.CheckBox();
            this.chkCs = new System.Windows.Forms.CheckBox();
            this.chkCpp = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.ForeColor = System.Drawing.Color.Red;
            this.rdbRed.Location = new System.Drawing.Point(333, 46);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(45, 17);
            this.rdbRed.TabIndex = 0;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.ForeColor = System.Drawing.Color.Green;
            this.rdbGreen.Location = new System.Drawing.Point(333, 88);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(54, 17);
            this.rdbGreen.TabIndex = 1;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbYellow
            // 
            this.rdbYellow.AutoSize = true;
            this.rdbYellow.ForeColor = System.Drawing.Color.Yellow;
            this.rdbYellow.Location = new System.Drawing.Point(333, 130);
            this.rdbYellow.Name = "rdbYellow";
            this.rdbYellow.Size = new System.Drawing.Size(56, 17);
            this.rdbYellow.TabIndex = 2;
            this.rdbYellow.TabStop = true;
            this.rdbYellow.Text = "Yellow";
            this.rdbYellow.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(344, 201);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.chkAnd);
            this.groupBox1.Controls.Add(this.chkJv);
            this.groupBox1.Controls.Add(this.chkIsad);
            this.groupBox1.Controls.Add(this.chkCs);
            this.groupBox1.Controls.Add(this.chkCpp);
            this.groupBox1.Location = new System.Drawing.Point(515, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 248);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HDIT Modules";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkAnd
            // 
            this.chkAnd.AutoSize = true;
            this.chkAnd.Location = new System.Drawing.Point(15, 200);
            this.chkAnd.Name = "chkAnd";
            this.chkAnd.Size = new System.Drawing.Size(62, 17);
            this.chkAnd.TabIndex = 4;
            this.chkAnd.Text = "Android";
            this.chkAnd.UseVisualStyleBackColor = true;
            this.chkAnd.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkJv
            // 
            this.chkJv.AutoSize = true;
            this.chkJv.Location = new System.Drawing.Point(15, 84);
            this.chkJv.Name = "chkJv";
            this.chkJv.Size = new System.Drawing.Size(49, 17);
            this.chkJv.TabIndex = 3;
            this.chkJv.Text = "Java";
            this.chkJv.UseVisualStyleBackColor = true;
            // 
            // chkIsad
            // 
            this.chkIsad.AutoSize = true;
            this.chkIsad.Location = new System.Drawing.Point(15, 161);
            this.chkIsad.Name = "chkIsad";
            this.chkIsad.Size = new System.Drawing.Size(51, 17);
            this.chkIsad.TabIndex = 2;
            this.chkIsad.Text = "ISAD";
            this.chkIsad.UseVisualStyleBackColor = true;
            // 
            // chkCs
            // 
            this.chkCs.AutoSize = true;
            this.chkCs.Location = new System.Drawing.Point(15, 120);
            this.chkCs.Name = "chkCs";
            this.chkCs.Size = new System.Drawing.Size(40, 17);
            this.chkCs.TabIndex = 1;
            this.chkCs.Text = "C#";
            this.chkCs.UseVisualStyleBackColor = true;
            // 
            // chkCpp
            // 
            this.chkCpp.AutoSize = true;
            this.chkCpp.Location = new System.Drawing.Point(15, 43);
            this.chkCpp.Name = "chkCpp";
            this.chkCpp.Size = new System.Drawing.Size(45, 17);
            this.chkCpp.TabIndex = 0;
            this.chkCpp.Text = "C++";
            this.chkCpp.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(88, 129);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmNext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rdbYellow);
            this.Controls.Add(this.rdbGreen);
            this.Controls.Add(this.rdbRed);
            this.Name = "frmNext";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbYellow;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAnd;
        private System.Windows.Forms.CheckBox chkJv;
        private System.Windows.Forms.CheckBox chkIsad;
        private System.Windows.Forms.CheckBox chkCs;
        private System.Windows.Forms.CheckBox chkCpp;
        private System.Windows.Forms.Button btnShow;
    }
}