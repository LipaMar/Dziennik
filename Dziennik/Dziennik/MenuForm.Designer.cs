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
            this.timetableLabel = new System.Windows.Forms.Label();
            this.timetableListView = new System.Windows.Forms.ListView();
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.monthRadio = new System.Windows.Forms.RadioButton();
            this.weekRadio = new System.Windows.Forms.RadioButton();
            this.dayRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.menuBackgroundPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetablePictureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesPictureButton)).BeginInit();
            this.gradesPanel.SuspendLayout();
            this.timetablePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.infoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.ForeColor = System.Drawing.Color.DimGray;
            this.infoLabel.Location = new System.Drawing.Point(720, 31);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(240, 22);
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
            this.gradesListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.gradesListView_ColumnWidthChanging);
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
            this.timetablePanel.Controls.Add(this.groupBox1, 1, 1);
            this.timetablePanel.Controls.Add(this.timetableListView, 1, 2);
            this.timetablePanel.Location = new System.Drawing.Point(0, 180);
            this.timetablePanel.Name = "timetablePanel";
            this.timetablePanel.RowCount = 3;
            this.timetablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timetablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timetablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.timetablePanel.Size = new System.Drawing.Size(706, 388);
            this.timetablePanel.TabIndex = 7;
            // 
            // timetableLabel
            // 
            this.timetableLabel.BackColor = System.Drawing.Color.White;
            this.timetableLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timetableLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timetableLabel.Location = new System.Drawing.Point(13, 0);
            this.timetableLabel.Name = "timetableLabel";
            this.timetableLabel.Size = new System.Drawing.Size(678, 39);
            this.timetableLabel.TabIndex = 1;
            this.timetableLabel.Text = "Plan zajęć";
            this.timetableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NextButton);
            this.groupBox1.Controls.Add(this.PrevButton);
            this.groupBox1.Controls.Add(this.monthRadio);
            this.groupBox1.Controls.Add(this.weekRadio);
            this.groupBox1.Controls.Add(this.dayRadio);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 33);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.NextButton.Location = new System.Drawing.Point(572, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 26);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Następny";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.PrevButton.Location = new System.Drawing.Point(6, 4);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(100, 26);
            this.PrevButton.TabIndex = 3;
            this.PrevButton.Text = "Poprzedni";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // monthRadio
            // 
            this.monthRadio.AutoSize = true;
            this.monthRadio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthRadio.Location = new System.Drawing.Point(415, 10);
            this.monthRadio.Name = "monthRadio";
            this.monthRadio.Size = new System.Drawing.Size(87, 20);
            this.monthRadio.TabIndex = 2;
            this.monthRadio.Text = "Miesięcznie";
            this.monthRadio.UseVisualStyleBackColor = true;
            this.monthRadio.CheckedChanged += new System.EventHandler(this.monthRadio_CheckedChanged);
            // 
            // weekRadio
            // 
            this.weekRadio.AutoSize = true;
            this.weekRadio.Checked = true;
            this.weekRadio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weekRadio.Location = new System.Drawing.Point(295, 10);
            this.weekRadio.Name = "weekRadio";
            this.weekRadio.Size = new System.Drawing.Size(92, 20);
            this.weekRadio.TabIndex = 1;
            this.weekRadio.TabStop = true;
            this.weekRadio.Text = "Tygodniowo";
            this.weekRadio.UseVisualStyleBackColor = true;
            this.weekRadio.CheckedChanged += new System.EventHandler(this.weekRadio_CheckedChanged);
            // 
            // dayRadio
            // 
            this.dayRadio.AutoSize = true;
            this.dayRadio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dayRadio.Location = new System.Drawing.Point(186, 10);
            this.dayRadio.Name = "dayRadio";
            this.dayRadio.Size = new System.Drawing.Size(71, 20);
            this.dayRadio.TabIndex = 0;
            this.dayRadio.Text = "Dziennie";
            this.dayRadio.UseVisualStyleBackColor = true;
            this.dayRadio.CheckedChanged += new System.EventHandler(this.dayRadio_CheckedChanged);
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
            this.timetableListView.Location = new System.Drawing.Point(13, 81);
            this.timetableListView.Name = "timetableListView";
            this.timetableListView.Size = new System.Drawing.Size(678, 292);
            this.timetableListView.TabIndex = 0;
            this.timetableListView.UseCompatibleStateImageBehavior = false;
            this.timetableListView.View = System.Windows.Forms.View.Details;
            this.timetableListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.timetableListView_ColumnWidthChanging);
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Data";
            this.dateHeader.Width = 90;
            // 
            // FormHeader
            // 
            this.FormHeader.Text = "Typ";
            this.FormHeader.Width = 45;
            // 
            // subjectHeader
            // 
            this.subjectHeader.Text = "Nazwa przedmiotu";
            this.subjectHeader.Width = 205;
            // 
            // teacherHeader
            // 
            this.teacherHeader.Text = "Prowadzący";
            this.teacherHeader.Width = 162;
            // 
            // startHeader
            // 
            this.startHeader.Text = "Początek";
            this.startHeader.Width = 84;
            // 
            // endHeader
            // 
            this.endHeader.Text = "Koniec";
            this.endHeader.Width = 70;
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
            this.Load += new System.EventHandler(this.weekRadio_CheckedChanged);
            ((System.ComponentModel.ISupportInitialize)(this.menuBackgroundPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetablePictureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesPictureButton)).EndInit();
            this.gradesPanel.ResumeLayout(false);
            this.timetablePanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dayRadio;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.RadioButton monthRadio;
        private System.Windows.Forms.RadioButton weekRadio;
    }
}