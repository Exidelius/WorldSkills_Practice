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
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelGreetings = new System.Windows.Forms.Label();
            this.comboBoxCompetitions = new System.Windows.Forms.ComboBox();
            this.buttonCompetition = new System.Windows.Forms.Button();
            this.buttonEditCompetition = new System.Windows.Forms.Button();
            this.buttonExpersManagement = new System.Windows.Forms.Button();
            this.buttonProtocols = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelParameters = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDeployment = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanelParameters.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(3, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(103, 44);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxIcon.BackgroundImage = global::WorldSkills_WinApp.Properties.Resources.wsrlogo_01;
            this.pictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxIcon.Image = global::WorldSkills_WinApp.Properties.Resources.wsrlogo_01;
            this.pictureBoxIcon.Location = new System.Drawing.Point(479, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(216, 152);
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelGreetings
            // 
            this.labelGreetings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGreetings.Location = new System.Drawing.Point(117, 0);
            this.labelGreetings.Name = "labelGreetings";
            this.labelGreetings.Size = new System.Drawing.Size(153, 114);
            this.labelGreetings.TabIndex = 3;
            this.labelGreetings.Text = "Привет";
            // 
            // comboBoxCompetitions
            // 
            this.comboBoxCompetitions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCompetitions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCompetitions.FormattingEnabled = true;
            this.comboBoxCompetitions.Location = new System.Drawing.Point(3, 128);
            this.comboBoxCompetitions.Name = "comboBoxCompetitions";
            this.comboBoxCompetitions.Size = new System.Drawing.Size(273, 24);
            this.comboBoxCompetitions.TabIndex = 4;
            this.comboBoxCompetitions.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompetitions_SelectedIndexChanged);
            // 
            // buttonCompetition
            // 
            this.buttonCompetition.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCompetition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCompetition.Location = new System.Drawing.Point(3, 51);
            this.buttonCompetition.Name = "buttonCompetition";
            this.buttonCompetition.Size = new System.Drawing.Size(115, 45);
            this.buttonCompetition.TabIndex = 5;
            this.buttonCompetition.Text = "Чемпионат";
            this.buttonCompetition.UseVisualStyleBackColor = false;
            this.buttonCompetition.Click += new System.EventHandler(this.buttonCompetition_Click);
            // 
            // buttonEditCompetition
            // 
            this.buttonEditCompetition.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEditCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditCompetition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditCompetition.Location = new System.Drawing.Point(3, 107);
            this.buttonEditCompetition.Name = "buttonEditCompetition";
            this.buttonEditCompetition.Size = new System.Drawing.Size(115, 45);
            this.buttonEditCompetition.TabIndex = 6;
            this.buttonEditCompetition.Text = "Настройка чемпионата";
            this.buttonEditCompetition.UseVisualStyleBackColor = false;
            this.buttonEditCompetition.Click += new System.EventHandler(this.buttonEditCompetition_Click);
            // 
            // buttonExpersManagement
            // 
            this.buttonExpersManagement.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonExpersManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExpersManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExpersManagement.Location = new System.Drawing.Point(3, 163);
            this.buttonExpersManagement.Name = "buttonExpersManagement";
            this.buttonExpersManagement.Size = new System.Drawing.Size(115, 45);
            this.buttonExpersManagement.TabIndex = 7;
            this.buttonExpersManagement.Text = "Управление экспертами";
            this.buttonExpersManagement.UseVisualStyleBackColor = false;
            // 
            // buttonProtocols
            // 
            this.buttonProtocols.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonProtocols.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProtocols.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonProtocols.Location = new System.Drawing.Point(3, 219);
            this.buttonProtocols.Name = "buttonProtocols";
            this.buttonProtocols.Size = new System.Drawing.Size(115, 45);
            this.buttonProtocols.TabIndex = 8;
            this.buttonProtocols.Text = "Протоколы";
            this.buttonProtocols.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelParameters, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 517);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.64198F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.35802F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxIcon, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(886, 161);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.comboBoxCompetitions, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(273, 155);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.buttonExit, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelGreetings, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(273, 114);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // tableLayoutPanelParameters
            // 
            this.tableLayoutPanelParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelParameters.ColumnCount = 2;
            this.tableLayoutPanelParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelParameters.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanelParameters.Controls.Add(this.tableLayoutPanelDeployment, 1, 0);
            this.tableLayoutPanelParameters.Location = new System.Drawing.Point(3, 190);
            this.tableLayoutPanelParameters.Name = "tableLayoutPanelParameters";
            this.tableLayoutPanelParameters.RowCount = 1;
            this.tableLayoutPanelParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelParameters.Size = new System.Drawing.Size(886, 324);
            this.tableLayoutPanelParameters.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.buttonCompetition, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.buttonProtocols, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.buttonEditCompetition, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.buttonExpersManagement, 0, 5);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 9;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(122, 318);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanelDeployment
            // 
            this.tableLayoutPanelDeployment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelDeployment.AutoScroll = true;
            this.tableLayoutPanelDeployment.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanelDeployment.ColumnCount = 1;
            this.tableLayoutPanelDeployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDeployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDeployment.Location = new System.Drawing.Point(131, 3);
            this.tableLayoutPanelDeployment.Name = "tableLayoutPanelDeployment";
            this.tableLayoutPanelDeployment.RowCount = 1;
            this.tableLayoutPanelDeployment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDeployment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 336F));
            this.tableLayoutPanelDeployment.Size = new System.Drawing.Size(752, 318);
            this.tableLayoutPanelDeployment.TabIndex = 1;
            // 
            // FormOrganizationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(640, 300);
            this.Name = "FormOrganizationMenu";
            this.Text = "Меню организатора";
            this.Load += new System.EventHandler(this.FormOrganizationMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanelParameters.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelGreetings;
        private System.Windows.Forms.ComboBox comboBoxCompetitions;
        private System.Windows.Forms.Button buttonCompetition;
        private System.Windows.Forms.Button buttonEditCompetition;
        private System.Windows.Forms.Button buttonExpersManagement;
        private System.Windows.Forms.Button buttonProtocols;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParameters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeployment;
    }
}