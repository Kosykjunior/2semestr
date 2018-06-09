namespace _5
{
    partial class TreeForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.PictureBox();
            this.GetN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetN)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 38);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(1133, 565);
            this.output.TabIndex = 0;
            this.output.TabStop = false;
            // 
            // GetN
            // 
            this.GetN.Location = new System.Drawing.Point(42, 12);
            this.GetN.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.GetN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GetN.Name = "GetN";
            this.GetN.Size = new System.Drawing.Size(78, 20);
            this.GetN.TabIndex = 1;
            this.GetN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N = ";
            // 
            // DrawBtn
            // 
            this.DrawBtn.Location = new System.Drawing.Point(144, 9);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawBtn.TabIndex = 3;
            this.DrawBtn.Text = "построить";
            this.DrawBtn.UseVisualStyleBackColor = true;
            this.DrawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 615);
            this.Controls.Add(this.DrawBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetN);
            this.Controls.Add(this.output);
            this.Name = "TreeForm";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox output;
        private System.Windows.Forms.NumericUpDown GetN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DrawBtn;
    }
}

