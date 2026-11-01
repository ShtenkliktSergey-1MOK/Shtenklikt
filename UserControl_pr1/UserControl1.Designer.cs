namespace UserControl_pr1
{
    partial class UserControl1
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
            this.pictureBoxMotorbike = new System.Windows.Forms.PictureBox();
            this.labelBrandData = new System.Windows.Forms.Label();
            this.labelModelData = new System.Windows.Forms.Label();
            this.labelPriceData = new System.Windows.Forms.Label();
            this.labelMileageData = new System.Windows.Forms.Label();
            this.labelHorsepowerData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorbike)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMotorbike
            // 
            this.pictureBoxMotorbike.Location = new System.Drawing.Point(66, 22);
            this.pictureBoxMotorbike.Name = "pictureBoxMotorbike";
            this.pictureBoxMotorbike.Size = new System.Drawing.Size(186, 156);
            this.pictureBoxMotorbike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMotorbike.TabIndex = 0;
            this.pictureBoxMotorbike.TabStop = false;
            // 
            // labelBrandData
            // 
            this.labelBrandData.AutoSize = true;
            this.labelBrandData.Location = new System.Drawing.Point(139, 227);
            this.labelBrandData.Name = "labelBrandData";
            this.labelBrandData.Size = new System.Drawing.Size(35, 13);
            this.labelBrandData.TabIndex = 1;
            this.labelBrandData.Text = "label1";
            // 
            // labelModelData
            // 
            this.labelModelData.AutoSize = true;
            this.labelModelData.Location = new System.Drawing.Point(139, 268);
            this.labelModelData.Name = "labelModelData";
            this.labelModelData.Size = new System.Drawing.Size(35, 13);
            this.labelModelData.TabIndex = 2;
            this.labelModelData.Text = "label2";
            // 
            // labelPriceData
            // 
            this.labelPriceData.AutoSize = true;
            this.labelPriceData.Location = new System.Drawing.Point(139, 310);
            this.labelPriceData.Name = "labelPriceData";
            this.labelPriceData.Size = new System.Drawing.Size(35, 13);
            this.labelPriceData.TabIndex = 3;
            this.labelPriceData.Text = "label3";
            // 
            // labelMileageData
            // 
            this.labelMileageData.AutoSize = true;
            this.labelMileageData.Location = new System.Drawing.Point(139, 355);
            this.labelMileageData.Name = "labelMileageData";
            this.labelMileageData.Size = new System.Drawing.Size(35, 13);
            this.labelMileageData.TabIndex = 4;
            this.labelMileageData.Text = "label4";
            // 
            // labelHorsepowerData
            // 
            this.labelHorsepowerData.AutoSize = true;
            this.labelHorsepowerData.Location = new System.Drawing.Point(139, 401);
            this.labelHorsepowerData.Name = "labelHorsepowerData";
            this.labelHorsepowerData.Size = new System.Drawing.Size(35, 13);
            this.labelHorsepowerData.TabIndex = 5;
            this.labelHorsepowerData.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "л/с";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelHorsepowerData);
            this.Controls.Add(this.labelMileageData);
            this.Controls.Add(this.labelPriceData);
            this.Controls.Add(this.labelModelData);
            this.Controls.Add(this.labelBrandData);
            this.Controls.Add(this.pictureBoxMotorbike);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(320, 494);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorbike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMotorbike;
        private System.Windows.Forms.Label labelBrandData;
        private System.Windows.Forms.Label labelModelData;
        private System.Windows.Forms.Label labelPriceData;
        private System.Windows.Forms.Label labelMileageData;
        private System.Windows.Forms.Label labelHorsepowerData;
        private System.Windows.Forms.Label label6;
    }
}
