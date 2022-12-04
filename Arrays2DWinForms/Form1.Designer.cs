namespace Arrays2DWinForms
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.solve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sumValue = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.generate = new System.Windows.Forms.Button();
            this.rowsCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.columnsCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // solve
            // 
            this.solve.BackColor = System.Drawing.Color.LightCoral;
            this.solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solve.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solve.Location = new System.Drawing.Point(611, 53);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(161, 40);
            this.solve.TabIndex = 16;
            this.solve.Text = "Розв\'язати";
            this.solve.UseVisualStyleBackColor = false;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(521, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дольна О.І., гр. СН-21";
            // 
            // sumValue
            // 
            this.sumValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sumValue.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumValue.Location = new System.Drawing.Point(470, 457);
            this.sumValue.Name = "sumValue";
            this.sumValue.Size = new System.Drawing.Size(151, 34);
            this.sumValue.TabIndex = 14;
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMatrix.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(12, 148);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.ReadOnly = true;
            this.dataGridViewMatrix.RowHeadersWidth = 51;
            this.dataGridViewMatrix.RowTemplate.Height = 24;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(760, 291);
            this.dataGridViewMatrix.TabIndex = 13;
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.LightCoral;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generate.Location = new System.Drawing.Point(433, 53);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(161, 40);
            this.generate.TabIndex = 12;
            this.generate.Text = "Генерувати";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // rowsCount
            // 
            this.rowsCount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsCount.Location = new System.Drawing.Point(259, 88);
            this.rowsCount.Name = "rowsCount";
            this.rowsCount.Size = new System.Drawing.Size(120, 34);
            this.rowsCount.TabIndex = 11;
            this.rowsCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(16, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Найбільша сума елементів по рядках:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Кількість рядків:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Кількість стовпців:";
            // 
            // columnsCount
            // 
            this.columnsCount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnsCount.Location = new System.Drawing.Point(259, 26);
            this.columnsCount.Name = "columnsCount";
            this.columnsCount.Size = new System.Drawing.Size(120, 34);
            this.columnsCount.TabIndex = 18;
            this.columnsCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arrays2DWinForms.Properties.Resources.завантаження;
            this.ClientSize = new System.Drawing.Size(795, 562);
            this.Controls.Add(this.columnsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sumValue);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.rowsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1073, 774);
            this.MinimumSize = new System.Drawing.Size(813, 609);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3. Завдання 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sumValue;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.NumericUpDown rowsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown columnsCount;
    }
}

