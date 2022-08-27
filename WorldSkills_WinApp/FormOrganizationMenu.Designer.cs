namespace WorldSkills_WinApp
{
    partial class FormOrganizationMenu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonProtocols = new System.Windows.Forms.Button();
            this.buttonExperts = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.dataGridViewCompetitions = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelGreetings = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonProtocols);
            this.tabPage1.Controls.Add(this.buttonExperts);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.buttonChange);
            this.tabPage1.Controls.Add(this.dataGridViewCompetitions);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonProtocols
            // 
            this.buttonProtocols.Location = new System.Drawing.Point(659, 140);
            this.buttonProtocols.Name = "buttonProtocols";
            this.buttonProtocols.Size = new System.Drawing.Size(103, 23);
            this.buttonProtocols.TabIndex = 4;
            this.buttonProtocols.Text = "Протоколы";
            this.buttonProtocols.UseVisualStyleBackColor = true;
            // 
            // buttonExperts
            // 
            this.buttonExperts.Location = new System.Drawing.Point(659, 96);
            this.buttonExperts.Name = "buttonExperts";
            this.buttonExperts.Size = new System.Drawing.Size(103, 23);
            this.buttonExperts.TabIndex = 3;
            this.buttonExperts.Text = "Эксперты";
            this.buttonExperts.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(659, 7);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(659, 53);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(103, 23);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCompetitions
            // 
            this.dataGridViewCompetitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.date_start,
            this.date_end,
            this.description,
            this.city});
            this.dataGridViewCompetitions.Location = new System.Drawing.Point(3, 7);
            this.dataGridViewCompetitions.Name = "dataGridViewCompetitions";
            this.dataGridViewCompetitions.ReadOnly = true;
            this.dataGridViewCompetitions.RowHeadersWidth = 51;
            this.dataGridViewCompetitions.RowTemplate.Height = 24;
            this.dataGridViewCompetitions.Size = new System.Drawing.Size(636, 309);
            this.dataGridViewCompetitions.TabIndex = 0;
            this.dataGridViewCompetitions.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCompetitions_CellMouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(16, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(484, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(300, 88);
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelGreetings
            // 
            this.labelGreetings.AutoSize = true;
            this.labelGreetings.Location = new System.Drawing.Point(106, 15);
            this.labelGreetings.Name = "labelGreetings";
            this.labelGreetings.Size = new System.Drawing.Size(56, 16);
            this.labelGreetings.TabIndex = 3;
            this.labelGreetings.Text = "Привет";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 47;
            // 
            // title
            // 
            this.title.HeaderText = "title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 125;
            // 
            // date_start
            // 
            this.date_start.HeaderText = "date_start";
            this.date_start.MinimumWidth = 6;
            this.date_start.Name = "date_start";
            this.date_start.ReadOnly = true;
            this.date_start.Width = 125;
            // 
            // date_end
            // 
            this.date_end.HeaderText = "date_end";
            this.date_end.MinimumWidth = 6;
            this.date_end.Name = "date_end";
            this.date_end.ReadOnly = true;
            this.date_end.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 125;
            // 
            // city
            // 
            this.city.HeaderText = "city";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 125;
            // 
            // FormOrganizationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGreetings);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormOrganizationMenu";
            this.Text = "FormOrganizationMenu";
            this.Load += new System.EventHandler(this.FormOrganizationMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewCompetitions;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonExperts;
        private System.Windows.Forms.Button buttonProtocols;
        private System.Windows.Forms.Label labelGreetings;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
    }
}