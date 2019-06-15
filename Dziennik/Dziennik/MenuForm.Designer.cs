namespace Dziennik
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuBackgroundPicture = new System.Windows.Forms.PictureBox();
            this.menuLogoPicture = new System.Windows.Forms.PictureBox();
            this.timetablePictureButton = new System.Windows.Forms.PictureBox();
            this.gradesPictureButton = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.gradesListView = new System.Windows.Forms.ListView();
            this.przedmiotHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ocenaHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.averageLabel = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.timetablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.timetableListView = new System.Windows.Forms.ListView();
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timetableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuBackgroundPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetablePictureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesPictureButton)).BeginInit();
            this.gradesPanel.SuspendLayout();
            this.timetablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBackgroundPicture
            // 
            this.menuBackgroundPicture.Image = ((System.Drawing.Image)(resources.GetObject("menuBackgroundPicture.Image")));
            this.menuBackgroundPicture.Location = new System.Drawing.Point(0, 0);
            this.menuBackgroundPicture.Name = "menuBackgroundPicture";
            this.menuBackgroundPicture.Size = new System.Drawing.Size(1140, 568);
            this.menuBackgroundPicture.TabIndex = 0;
            this.menuBackgroundPicture.TabStop = false;
            // 
            // menuLogoPicture
            // 
            this.menuLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("menuLogoPicture.Image")));
            this.menuLogoPicture.Location = new System.Drawing.Point(110, -35);
            this.menuLogoPicture.Name = "menuLogoPicture";
            this.menuLogoPicture.Size = new System.Drawing.Size(450, 170);
            this.menuLogoPicture.TabIndex = 1;
            this.menuLogoPicture.TabStop = false;
            // 
            // timetablePictureButton
            // 
            this.timetablePictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timetablePictureButton.Image = ((System.Drawing.Image)(resources.GetObject("timetablePictureButton.Image")));
            this.timetablePictureButton.Location = new System.Drawing.Point(724, 228);
            this.timetablePictureButton.Name = "timetablePictureButton";
            this.timetablePictureButton.Size = new System.Drawing.Size(190, 200);
            this.timetablePictureButton.TabIndex = 2;
            this.timetablePictureButton.TabStop = false;
            this.timetablePictureButton.Click += new System.EventHandler(this.timetablePictureButton_Click);
            // 
            // gradesPictureButton
            // 
            this.gradesPictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradesPictureButton.Image = ((System.Drawing.Image)(resources.GetObject("gradesPictureButton.Image")));
            this.gradesPictureButton.Location = new System.Drawing.Point(945, 228);
            this.gradesPictureButton.Name = "gradesPictureButton";
            this.gradesPictureButton.Size = new System.Drawing.Size(190, 200);
            this.gradesPictureButton.TabIndex = 3;
            this.gradesPictureButton.TabStop = false;
            this.gradesPictureButton.Click += new System.EventHandler(this.gradesPictureButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.infoLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(719, 23);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(309, 28);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Informacje o użytkowniku";
            // 
            // gradesListView
            // 
            this.gradesListView.AutoArrange = false;
            this.gradesListView.BackColor = System.Drawing.Color.White;
            this.gradesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.przedmiotHeader,
            this.ocenaHeader});
            this.gradesListView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gradesListView.FullRowSelect = true;
            this.gradesListView.GridLines = true;
            this.gradesListView.Location = new System.Drawing.Point(144, 3);
            this.gradesListView.Name = "gradesListView";
            this.gradesListView.Size = new System.Drawing.Size(417, 343);
            this.gradesListView.TabIndex = 0;
            this.gradesListView.UseCompatibleStateImageBehavior = false;
            this.gradesListView.View = System.Windows.Forms.View.Details;
            // 
            // przedmiotHeader
            // 
            this.przedmiotHeader.Text = "Nazwa przedmiotu";
            this.przedmiotHeader.Width = 337;
            // 
            // ocenaHeader
            // 
            this.ocenaHeader.Text = "Ocena";
            this.ocenaHeader.Width = 75;
            // 
            // gradesPanel
            // 
            this.gradesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gradesPanel.ColumnCount = 3;
            this.gradesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gradesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.gradesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gradesPanel.Controls.Add(this.averageLabel, 1, 1);
            this.gradesPanel.Controls.Add(this.gradesListView, 1, 0);
            this.gradesPanel.Location = new System.Drawing.Point(0, 180);
            this.gradesPanel.Name = "gradesPanel";
            this.gradesPanel.RowCount = 2;
            this.gradesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.gradesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gradesPanel.Size = new System.Drawing.Size(706, 388);
            this.gradesPanel.TabIndex = 5;
            // 
            // averageLabel
            // 
            this.averageLabel.BackColor = System.Drawing.Color.White;
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.averageLabel.Location = new System.Drawing.Point(144, 349);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(417, 24);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.Text = "Średnia arytmetyczna";
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logout.ForeColor = System.Drawing.Color.Gray;
            this.logout.Location = new System.Drawing.Point(1074, 9);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(48, 13);
            this.logout.TabIndex = 6;
            this.logout.Text = "(wyloguj)";
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // timetablePanel
            // 
            this.timetablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timetablePanel.ColumnCount = 3;
            this.timetablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5F));
            this.timetablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97F));
            this.timetablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5F));
            this.timetablePanel.Controls.Add(this.timetableLabel, 1, 0);
            this.timetablePanel.Controls.Add(this.timetableListView, 1, 1);
            this.timetablePanel.Location = new System.Drawing.Point(0, 180);
            this.timetablePanel.Name = "timetablePanel";
            this.timetablePanel.RowCount = 2;
            this.timetablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.timetablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.timetablePanel.Size = new System.Drawing.Size(706, 388);
            this.timetablePanel.TabIndex = 7;
            this.timetableLabel.Text = "Miesięczny plan zajęć";
            // 
            // timetableListView
            // 
            this.timetableListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateHeader,
            this.FormHeader,
            this.subjectHeader,
            this.teacherHeader,
            this.startHeader,
            this.endHeader});
            this.timetableListView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timetableListView.FullRowSelect = true;
            this.timetableListView.GridLines = true;
            this.timetableListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.timetableListView.Location = new System.Drawing.Point(13, 26);
            this.timetableListView.Name = "timetableListView";
            this.timetableListView.Size = new System.Drawing.Size(678, 359);
            this.timetableListView.TabIndex = 0;
            this.timetableListView.UseCompatibleStateImageBehavior = false;
            this.timetableListView.View = System.Windows.Forms.View.Details;
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Data";
            this.dateHeader.Width = 90;
            // 
            // FormHeader
            // 
            this.FormHeader.Text = "Typ";
            this.FormHeader.Width = 48;
            // 
            // subjectHeader
            // 
            this.subjectHeader.Text = "Nazwa przedmiotu";
            this.subjectHeader.Width = 209;
            // 
            // teacherHeader
            // 
            this.teacherHeader.Text = "Prowadzący";
            this.teacherHeader.Width = 149;
            // 
            // startHeader
            // 
            this.startHeader.Text = "Początek";
            this.startHeader.Width = 84;
            // 
            // endHeader
            // 
            this.endHeader.Text = "Koniec";
            this.endHeader.Width = 75;
            // 
            // timetableLabel
            // 
            this.timetableLabel.BackColor = System.Drawing.Color.White;
            this.timetableLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timetableLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetableLabel.Location = new System.Drawing.Point(13, 0);
            this.timetableLabel.Name = "timetableLabel";
            this.timetableLabel.Size = new System.Drawing.Size(678, 23);
            this.timetableLabel.TabIndex = 1;
            this.timetableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 562);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.gradesPictureButton);
            this.Controls.Add(this.timetablePictureButton);
            this.Controls.Add(this.menuLogoPicture);
            this.Controls.Add(this.timetablePanel);
            this.Controls.Add(this.menuBackgroundPicture);
            this.Controls.Add(this.gradesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.menuBackgroundPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetablePictureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesPictureButton)).EndInit();
            this.gradesPanel.ResumeLayout(false);
            this.timetablePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox menuBackgroundPicture;
        private System.Windows.Forms.PictureBox menuLogoPicture;
        private System.Windows.Forms.PictureBox timetablePictureButton;
        private System.Windows.Forms.PictureBox gradesPictureButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ListView gradesListView;
        private System.Windows.Forms.ColumnHeader przedmiotHeader;
        private System.Windows.Forms.ColumnHeader ocenaHeader;
        private System.Windows.Forms.TableLayoutPanel gradesPanel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.TableLayoutPanel timetablePanel;
        private System.Windows.Forms.ListView timetableListView;
        private System.Windows.Forms.ColumnHeader FormHeader;
        private System.Windows.Forms.ColumnHeader subjectHeader;
        private System.Windows.Forms.ColumnHeader teacherHeader;
        private System.Windows.Forms.ColumnHeader startHeader;
        private System.Windows.Forms.ColumnHeader endHeader;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.Label timetableLabel;
    }
}