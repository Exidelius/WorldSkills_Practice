namespace WorldSkills_WinApp
{
    partial class UserControlFullCompetitionInformation
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxSkills = new System.Windows.Forms.ComboBox();
            this.comboBoxExperts = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownExpertsCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParticipantsCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddSkill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpertsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParticipantsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(28, 29);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 40);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.Location = new System.Drawing.Point(142, 29);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 40);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AccessibleDescription = "";
            this.textBoxTitle.AccessibleName = "";
            this.textBoxTitle.Location = new System.Drawing.Point(28, 150);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(593, 22);
            this.textBoxTitle.TabIndex = 5;
            // 
            // comboBoxSkills
            // 
            this.comboBoxSkills.FormattingEnabled = true;
            this.comboBoxSkills.Location = new System.Drawing.Point(28, 203);
            this.comboBoxSkills.Name = "comboBoxSkills";
            this.comboBoxSkills.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSkills.TabIndex = 6;
            // 
            // comboBoxExperts
            // 
            this.comboBoxExperts.FormattingEnabled = true;
            this.comboBoxExperts.Location = new System.Drawing.Point(200, 203);
            this.comboBoxExperts.Name = "comboBoxExperts";
            this.comboBoxExperts.Size = new System.Drawing.Size(158, 24);
            this.comboBoxExperts.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WorldSkills_WinApp.Properties.Resources.wsrlogo_01;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(627, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 198);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(28, 91);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStart.TabIndex = 13;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(239, 91);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEnd.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название чемпионата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата начала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Дата окончания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Компетенция";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Главный эксперт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Кол-во экспертов";
            // 
            // numericUpDownExpertsCount
            // 
            this.numericUpDownExpertsCount.Location = new System.Drawing.Point(364, 204);
            this.numericUpDownExpertsCount.Name = "numericUpDownExpertsCount";
            this.numericUpDownExpertsCount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownExpertsCount.TabIndex = 21;
            // 
            // numericUpDownParticipantsCount
            // 
            this.numericUpDownParticipantsCount.Location = new System.Drawing.Point(490, 203);
            this.numericUpDownParticipantsCount.Name = "numericUpDownParticipantsCount";
            this.numericUpDownParticipantsCount.Size = new System.Drawing.Size(131, 22);
            this.numericUpDownParticipantsCount.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Кол-во участников";
            // 
            // buttonAddSkill
            // 
            this.buttonAddSkill.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSkill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddSkill.Location = new System.Drawing.Point(28, 234);
            this.buttonAddSkill.Name = "buttonAddSkill";
            this.buttonAddSkill.Size = new System.Drawing.Size(31, 30);
            this.buttonAddSkill.TabIndex = 24;
            this.buttonAddSkill.Text = "+";
            this.buttonAddSkill.UseVisualStyleBackColor = false;
            this.buttonAddSkill.Click += new System.EventHandler(this.buttonAddSkill_Click);
            // 
            // UserControlFullCompetitionInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddSkill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownParticipantsCount);
            this.Controls.Add(this.numericUpDownExpertsCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxExperts);
            this.Controls.Add(this.comboBoxSkills);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "UserControlFullCompetitionInformation";
            this.Size = new System.Drawing.Size(889, 401);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpertsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParticipantsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxSkills;
        private System.Windows.Forms.ComboBox comboBoxExperts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownExpertsCount;
        private System.Windows.Forms.NumericUpDown numericUpDownParticipantsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddSkill;
    }
}
