namespace Library_Management
{
    partial class change_password_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_password_admin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNew_Pass = new System.Windows.Forms.TextBox();
            this.lblNew_Password = new System.Windows.Forms.Label();
            this.lblConfirm_Pass = new System.Windows.Forms.Label();
            this.txtConfirm_Pass = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblChangePass = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblID_Text = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.92208F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.07792F));
            this.tableLayoutPanel1.Controls.Add(this.txtNew_Pass, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNew_Password, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblConfirm_Pass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtConfirm_Pass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnChange, 0, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(91, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.77477F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.02703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 222);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtNew_Pass
            // 
            this.txtNew_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNew_Pass.Location = new System.Drawing.Point(181, 12);
            this.txtNew_Pass.Name = "txtNew_Pass";
            this.txtNew_Pass.PasswordChar = '*';
            this.txtNew_Pass.Size = new System.Drawing.Size(220, 29);
            this.txtNew_Pass.TabIndex = 11;
            // 
            // lblNew_Password
            // 
            this.lblNew_Password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNew_Password.AutoSize = true;
            this.lblNew_Password.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew_Password.Location = new System.Drawing.Point(32, 16);
            this.lblNew_Password.Name = "lblNew_Password";
            this.lblNew_Password.Size = new System.Drawing.Size(125, 21);
            this.lblNew_Password.TabIndex = 2;
            this.lblNew_Password.Text = "New Password";
            // 
            // lblConfirm_Pass
            // 
            this.lblConfirm_Pass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConfirm_Pass.AutoSize = true;
            this.lblConfirm_Pass.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm_Pass.Location = new System.Drawing.Point(3, 73);
            this.lblConfirm_Pass.Name = "lblConfirm_Pass";
            this.lblConfirm_Pass.Size = new System.Drawing.Size(154, 21);
            this.lblConfirm_Pass.TabIndex = 8;
            this.lblConfirm_Pass.Text = "Confirm Password";
            // 
            // txtConfirm_Pass
            // 
            this.txtConfirm_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirm_Pass.Location = new System.Drawing.Point(181, 69);
            this.txtConfirm_Pass.Name = "txtConfirm_Pass";
            this.txtConfirm_Pass.PasswordChar = '*';
            this.txtConfirm_Pass.Size = new System.Drawing.Size(220, 29);
            this.txtConfirm_Pass.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(243, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(68, 149);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(89, 36);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblChangePass
            // 
            this.lblChangePass.AutoSize = true;
            this.lblChangePass.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePass.Location = new System.Drawing.Point(246, 41);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(149, 21);
            this.lblChangePass.TabIndex = 2;
            this.lblChangePass.Text = "Change Password";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(46, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(12, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "-";
            // 
            // lblID_Text
            // 
            this.lblID_Text.AutoSize = true;
            this.lblID_Text.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_Text.Location = new System.Drawing.Point(17, 49);
            this.lblID_Text.Name = "lblID_Text";
            this.lblID_Text.Size = new System.Drawing.Size(23, 13);
            this.lblID_Text.TabIndex = 4;
            this.lblID_Text.Text = "Id:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(44, 335);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(17, 21);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "-";
            // 
            // change_password_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 375);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblID_Text);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblChangePass);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "change_password_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password Admin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNew_Password;
        private System.Windows.Forms.Label lblChangePass;
        private System.Windows.Forms.Label lblConfirm_Pass;
        private System.Windows.Forms.TextBox txtNew_Pass;
        private System.Windows.Forms.TextBox txtConfirm_Pass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblID_Text;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChange;
    }
}