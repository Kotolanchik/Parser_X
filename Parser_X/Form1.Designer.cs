namespace Parser_X
{
    partial class Parser
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
            this.StartPointer = new System.Windows.Forms.Label();
            this.numericIsStart = new System.Windows.Forms.NumericUpDown();
            this.EndPointer = new System.Windows.Forms.Label();
            this.numericIsEnd = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericIsStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIsEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // StartPointer
            // 
            this.StartPointer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartPointer.AutoSize = true;
            this.StartPointer.Location = new System.Drawing.Point(840, 15);
            this.StartPointer.Name = "StartPointer";
            this.StartPointer.Size = new System.Drawing.Size(65, 13);
            this.StartPointer.TabIndex = 1;
            this.StartPointer.Text = "Start Pointer";
            // 
            // numericIsStart
            // 
            this.numericIsStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericIsStart.Location = new System.Drawing.Point(843, 34);
            this.numericIsStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericIsStart.Name = "numericIsStart";
            this.numericIsStart.Size = new System.Drawing.Size(120, 20);
            this.numericIsStart.TabIndex = 2;
            this.numericIsStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndPointer
            // 
            this.EndPointer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndPointer.AutoSize = true;
            this.EndPointer.Location = new System.Drawing.Point(843, 57);
            this.EndPointer.Name = "EndPointer";
            this.EndPointer.Size = new System.Drawing.Size(62, 13);
            this.EndPointer.TabIndex = 3;
            this.EndPointer.Text = "End Pointer";
            this.EndPointer.Click += new System.EventHandler(this.EndPointer_Click);
            // 
            // numericIsEnd
            // 
            this.numericIsEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericIsEnd.Location = new System.Drawing.Point(846, 73);
            this.numericIsEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericIsEnd.Name = "numericIsEnd";
            this.numericIsEnd.Size = new System.Drawing.Size(120, 20);
            this.numericIsEnd.TabIndex = 4;
            this.numericIsEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(846, 111);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(117, 23);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abort
            // 
            this.Abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Abort.Location = new System.Drawing.Point(846, 140);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(117, 23);
            this.Abort.TabIndex = 6;
            this.Abort.Text = "Abort";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.Location = new System.Drawing.Point(29, 22);
            this.textBox1.MaximumSize = new System.Drawing.Size(500, 500);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 0);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(822, 578);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Parser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 614);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Abort);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.numericIsEnd);
            this.Controls.Add(this.EndPointer);
            this.Controls.Add(this.numericIsStart);
            this.Controls.Add(this.StartPointer);
            this.Name = "Parser";
            this.Text = "Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericIsStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIsEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StartPointer;
        private System.Windows.Forms.NumericUpDown numericIsStart;
        private System.Windows.Forms.Label EndPointer;
        private System.Windows.Forms.NumericUpDown numericIsEnd;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Abort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

