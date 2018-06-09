namespace _3._1
{
    partial class QueueForm
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
            this.Output = new System.Windows.Forms.TextBox();
            this.ValueInput = new System.Windows.Forms.NumericUpDown();
            this.IndexInput = new System.Windows.Forms.NumericUpDown();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ValueInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexInput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 53);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(485, 20);
            this.Output.TabIndex = 0;
            // 
            // ValueInput
            // 
            this.ValueInput.Location = new System.Drawing.Point(12, 27);
            this.ValueInput.Name = "ValueInput";
            this.ValueInput.Size = new System.Drawing.Size(64, 20);
            this.ValueInput.TabIndex = 1;
            // 
            // IndexInput
            // 
            this.IndexInput.Location = new System.Drawing.Point(431, 27);
            this.IndexInput.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IndexInput.Name = "IndexInput";
            this.IndexInput.Size = new System.Drawing.Size(66, 20);
            this.IndexInput.TabIndex = 2;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(82, 24);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "добавить в конец";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(197, 24);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(111, 23);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "удалить из начала";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(314, 24);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(111, 23);
            this.insertBtn.TabIndex = 5;
            this.insertBtn.Text = "добавить после";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 6;
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
            // QueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 88);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.IndexInput);
            this.Controls.Add(this.ValueInput);
            this.Controls.Add(this.Output);
            this.Name = "QueueForm";
            this.Text = "Queue";
            this.Load += new System.EventHandler(this.QueueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValueInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexInput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.NumericUpDown ValueInput;
        private System.Windows.Forms.NumericUpDown IndexInput;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenBtn;
        private System.Windows.Forms.ToolStripMenuItem saveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

