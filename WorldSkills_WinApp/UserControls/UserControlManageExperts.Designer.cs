namespace WorldSkills_WinApp
{
    partial class UserControlManageExperts
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
            this.tableLayoutPanelExperts = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanelExperts
            // 
            this.tableLayoutPanelExperts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelExperts.AutoScroll = true;
            this.tableLayoutPanelExperts.ColumnCount = 1;
            this.tableLayoutPanelExperts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelExperts.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelExperts.Name = "tableLayoutPanelExperts";
            this.tableLayoutPanelExperts.RowCount = 1;
            this.tableLayoutPanelExperts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelExperts.Size = new System.Drawing.Size(807, 571);
            this.tableLayoutPanelExperts.TabIndex = 0;
            this.tableLayoutPanelExperts.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelExperts_Paint);
            // 
            // UserControlManageExperts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanelExperts);
            this.Name = "UserControlManageExperts";
            this.Size = new System.Drawing.Size(813, 577);
            this.Load += new System.EventHandler(this.UserControlManageExperts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelExperts;
    }
}
