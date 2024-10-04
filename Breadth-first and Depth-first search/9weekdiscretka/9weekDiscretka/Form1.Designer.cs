namespace _9weekDiscretka
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.C21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.С31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.С32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.С33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(188, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 54);
            this.button1.TabIndex = 60;
            this.button1.Text = "В ширину";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2});
            this.dataGridView1.Location = new System.Drawing.Point(4, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(177, 469);
            this.dataGridView1.TabIndex = 61;
            // 
            // C1
            // 
            this.C1.HeaderText = "От";
            this.C1.MaxInputLength = 2;
            this.C1.MinimumWidth = 6;
            this.C1.Name = "C1";
            this.C1.Width = 40;
            // 
            // C2
            // 
            this.C2.HeaderText = "До";
            this.C2.MaxInputLength = 2;
            this.C2.MinimumWidth = 6;
            this.C2.Name = "C2";
            this.C2.Width = 40;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C21,
            this.C22});
            this.dataGridView2.Location = new System.Drawing.Point(188, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(177, 414);
            this.dataGridView2.TabIndex = 62;
            // 
            // C21
            // 
            this.C21.HeaderText = "N";
            this.C21.MaxInputLength = 2;
            this.C21.MinimumWidth = 6;
            this.C21.Name = "C21";
            this.C21.Width = 40;
            // 
            // C22
            // 
            this.C22.HeaderText = "День";
            this.C22.MaxInputLength = 2;
            this.C22.MinimumWidth = 6;
            this.C22.Name = "C22";
            this.C22.Width = 40;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(371, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 54);
            this.button2.TabIndex = 65;
            this.button2.Text = "В глубину";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.С31,
            this.С32,
            this.С33});
            this.dataGridView3.Location = new System.Drawing.Point(371, 67);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(239, 414);
            this.dataGridView3.TabIndex = 66;
            // 
            // С31
            // 
            this.С31.HeaderText = "N";
            this.С31.MaxInputLength = 2;
            this.С31.MinimumWidth = 6;
            this.С31.Name = "С31";
            this.С31.Width = 40;
            // 
            // С32
            // 
            this.С32.HeaderText = "День";
            this.С32.MaxInputLength = 2;
            this.С32.MinimumWidth = 6;
            this.С32.Name = "С32";
            this.С32.Width = 40;
            // 
            // С33
            // 
            this.С33.HeaderText = "Откуда";
            this.С33.MaxInputLength = 2;
            this.С33.MinimumWidth = 6;
            this.С33.Name = "С33";
            this.С33.Width = 45;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(633, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 33);
            this.textBox1.TabIndex = 67;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(633, 208);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 37);
            this.textBox2.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(629, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 26);
            this.label1.TabIndex = 69;
            this.label1.Text = "Первый день для ширины:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(629, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 26);
            this.label2.TabIndex = 70;
            this.label2.Text = "Первый день для глубины:";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(616, 7);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(233, 54);
            this.clear.TabIndex = 71;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 494);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C21;
        private System.Windows.Forms.DataGridViewTextBoxColumn C22;
        private System.Windows.Forms.DataGridViewTextBoxColumn С31;
        private System.Windows.Forms.DataGridViewTextBoxColumn С32;
        private System.Windows.Forms.DataGridViewTextBoxColumn С33;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear;
    }
}

