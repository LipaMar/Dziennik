namespace Dziennik
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.passTextB = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginTextB = new System.Windows.Forms.TextBox();
            this.loginBackgroundPicture = new System.Windows.Forms.PictureBox();
            this.loginLogoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginBackgroundPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // passTextB
            // 
            this.passTextB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passTextB.ForeColor = System.Drawing.Color.Black;
            this.passTextB.Location = new System.Drawing.Point(780, 65);
            this.passTextB.Name = "passTextB";
            this.passTextB.Size = new System.Drawing.Size(275, 27);
            this.passTextB.TabIndex = 7;
            this.passTextB.Text = "Hasło";
            this.passTextB.UseSystemPasswordChar = true;
            this.passTextB.Enter += new System.EventHandler(this.passTextB_Enter);
            this.passTextB.Leave += new System.EventHandler(this.passTextB_Leave);
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.Location = new System.Drawing.Point(780, 97);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(275, 40);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginTextB
            // 
            this.loginTextB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTextB.ForeColor = System.Drawing.Color.Black;
            this.loginTextB.Location = new System.Drawing.Point(780, 33);
            this.loginTextB.Name = "loginTextB";
            this.loginTextB.Size = new System.Drawing.Size(275, 27);
            this.loginTextB.TabIndex = 5;
            this.loginTextB.Text = "Nazwa użytkownika";
            this.loginTextB.Enter += new System.EventHandler(this.loginTextB_Enter);
            this.loginTextB.Leave += new System.EventHandler(this.loginTextB_Leave);
            // 
            // loginBackgroundPicture
            // 
            this.loginBackgroundPicture.Image = ((System.Drawing.Image)(resources.GetObject("loginBackgroundPicture.Image")));
            this.loginBackgroundPicture.Location = new System.Drawing.Point(0, 0);
            this.loginBackgroundPicture.Name = "loginBackgroundPicture";
            this.loginBackgroundPicture.Size = new System.Drawing.Size(1142, 569);
            this.loginBackgroundPicture.TabIndex = 8;
            this.loginBackgroundPicture.TabStop = false;
            // 
            // loginLogoPicture
            // 
            this.loginLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("loginLogoPicture.Image")));
            this.loginLogoPicture.Location = new System.Drawing.Point(110, -35);
            this.loginLogoPicture.Name = "loginLogoPicture";
            this.loginLogoPicture.Size = new System.Drawing.Size(450, 170);
            this.loginLogoPicture.TabIndex = 9;
            this.loginLogoPicture.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 562);
            this.Controls.Add(this.loginLogoPicture);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginTextB);
            this.Controls.Add(this.passTextB);
            this.Controls.Add(this.loginBackgroundPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBackgroundPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passTextB;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginTextB;
        private System.Windows.Forms.PictureBox loginBackgroundPicture;
        private System.Windows.Forms.PictureBox loginLogoPicture;
    }
}