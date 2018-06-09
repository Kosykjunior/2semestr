namespace _1._2
{
    partial class BinForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Inp = new System.Windows.Forms.TextBox();
            this.PositiveBtn = new System.Windows.Forms.RadioButton();
            this.NegativeBtn = new System.Windows.Forms.RadioButton();
            this.OddBtn = new System.Windows.Forms.RadioButton();
            this.EvenBtn = new System.Windows.Forms.RadioButton();
            this.Filtr = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenBtn,
            this.saveBtn});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(180, 22);
            this.OpenBtn.Text = "открыть";
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(180, 22);
            this.saveBtn.Text = "сохранить";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Числа|*.dat|все файлы|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Числа|*.dat|все файлы|*.*";
            // 
            // Inp
            // 
            this.Inp.Location = new System.Drawing.Point(12, 59);
            this.Inp.Name = "Inp";
            this.Inp.Size = new System.Drawing.Size(442, 20);
            this.Inp.TabIndex = 3;
            // 
            // PositiveBtn
            // 
            this.PositiveBtn.AutoSize = true;
            this.PositiveBtn.Checked = true;
            this.PositiveBtn.Location = new System.Drawing.Point(12, 36);
            this.PositiveBtn.Name = "PositiveBtn";
            this.PositiveBtn.Size = new System.Drawing.Size(106, 17);
            this.PositiveBtn.TabIndex = 4;
            this.PositiveBtn.TabStop = true;
            this.PositiveBtn.Text = "положительные";
            this.PositiveBtn.UseVisualStyleBackColor = true;
            // 
            // NegativeBtn
            // 
            this.NegativeBtn.AutoSize = true;
            this.NegativeBtn.Location = new System.Drawing.Point(124, 36);
            this.NegativeBtn.Name = "NegativeBtn";
            this.NegativeBtn.Size = new System.Drawing.Size(103, 17);
            this.NegativeBtn.TabIndex = 5;
            this.NegativeBtn.Text = "отрицательные";
            this.NegativeBtn.UseVisualStyleBackColor = true;
            // 
            // OddBtn
            // 
            this.OddBtn.AutoSize = true;
            this.OddBtn.Location = new System.Drawing.Point(300, 36);
            this.OddBtn.Name = "OddBtn";
            this.OddBtn.Size = new System.Drawing.Size(73, 17);
            this.OddBtn.TabIndex = 7;
            this.OddBtn.Text = "нечётные";
            this.OddBtn.UseVisualStyleBackColor = true;
            // 
            // EvenBtn
            // 
            this.EvenBtn.AutoSize = true;
            this.EvenBtn.Location = new System.Drawing.Point(233, 36);
            this.EvenBtn.Name = "EvenBtn";
            this.EvenBtn.Size = new System.Drawing.Size(61, 17);
            this.EvenBtn.TabIndex = 6;
            this.EvenBtn.Text = "чётные";
            this.EvenBtn.UseVisualStyleBackColor = true;
            // 
            // Filtr
            // 
            this.Filtr.Location = new System.Drawing.Point(379, 33);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(75, 23);
            this.Filtr.TabIndex = 8;
            this.Filtr.Text = "отфильтровать";
            this.Filtr.UseVisualStyleBackColor = true;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // BinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 101);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.OddBtn);
            this.Controls.Add(this.EvenBtn);
            this.Controls.Add(this.NegativeBtn);
            this.Controls.Add(this.PositiveBtn);
            this.Controls.Add(this.Inp);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BinForm";
            this.Text = "BinForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenBtn;
        private System.Windows.Forms.ToolStripMenuItem saveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox Inp;
        private System.Windows.Forms.RadioButton PositiveBtn;
        private System.Windows.Forms.RadioButton NegativeBtn;
        private System.Windows.Forms.RadioButton OddBtn;
        private System.Windows.Forms.RadioButton EvenBtn;
        private System.Windows.Forms.Button Filtr;
    }
}

