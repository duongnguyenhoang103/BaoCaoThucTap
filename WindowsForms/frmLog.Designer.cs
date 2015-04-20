namespace DeMoQLSV1
{
    partial class frmLog
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLogIn = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btDN2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tai khoan";
            // 
            // txtDN
            // 
            this.txtDN.Location = new System.Drawing.Point(129, 35);
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(152, 20);
            this.txtDN.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(129, 79);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(152, 20);
            this.txtMK.TabIndex = 3;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "mat khau";
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(46, 139);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(75, 23);
            this.btLogIn.TabIndex = 4;
            this.btLogIn.Text = "Dang Nhap";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(148, 139);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 5;
            this.btReset.Text = "Nhap moi";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(248, 139);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoat";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDN2
            // 
            this.btDN2.Location = new System.Drawing.Point(46, 174);
            this.btDN2.Name = "btDN2";
            this.btDN2.Size = new System.Drawing.Size(75, 23);
            this.btDN2.TabIndex = 7;
            this.btDN2.Text = "Code 2";
            this.btDN2.UseVisualStyleBackColor = true;
            this.btDN2.Click += new System.EventHandler(this.btDN2_Click);
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 209);
            this.Controls.Add(this.btDN2);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDN);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLog";
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDN2;
    }
}