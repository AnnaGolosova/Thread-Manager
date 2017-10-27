namespace Threading1
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox3 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox4 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox5 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox6 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.Logs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(29, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "First Thread";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(155, 84);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Second Thread";
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(28, 120);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(63, 30);
            this.materialCheckBox1.TabIndex = 2;
            this.materialCheckBox1.Text = "Hight";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox2.Location = new System.Drawing.Point(28, 150);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(72, 30);
            this.materialCheckBox2.TabIndex = 3;
            this.materialCheckBox2.Text = "Middle";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox3
            // 
            this.materialCheckBox3.AutoSize = true;
            this.materialCheckBox3.Depth = 0;
            this.materialCheckBox3.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox3.Location = new System.Drawing.Point(28, 180);
            this.materialCheckBox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox3.Name = "materialCheckBox3";
            this.materialCheckBox3.Ripple = true;
            this.materialCheckBox3.Size = new System.Drawing.Size(55, 30);
            this.materialCheckBox3.TabIndex = 4;
            this.materialCheckBox3.Text = "Low";
            this.materialCheckBox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox4
            // 
            this.materialCheckBox4.AutoSize = true;
            this.materialCheckBox4.Depth = 0;
            this.materialCheckBox4.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox4.Location = new System.Drawing.Point(159, 180);
            this.materialCheckBox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox4.Name = "materialCheckBox4";
            this.materialCheckBox4.Ripple = true;
            this.materialCheckBox4.Size = new System.Drawing.Size(55, 30);
            this.materialCheckBox4.TabIndex = 7;
            this.materialCheckBox4.Text = "Low";
            this.materialCheckBox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox5
            // 
            this.materialCheckBox5.AutoSize = true;
            this.materialCheckBox5.Depth = 0;
            this.materialCheckBox5.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox5.Location = new System.Drawing.Point(159, 150);
            this.materialCheckBox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox5.Name = "materialCheckBox5";
            this.materialCheckBox5.Ripple = true;
            this.materialCheckBox5.Size = new System.Drawing.Size(72, 30);
            this.materialCheckBox5.TabIndex = 6;
            this.materialCheckBox5.Text = "Middle";
            this.materialCheckBox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox6
            // 
            this.materialCheckBox6.AutoSize = true;
            this.materialCheckBox6.Depth = 0;
            this.materialCheckBox6.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox6.Location = new System.Drawing.Point(159, 120);
            this.materialCheckBox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox6.Name = "materialCheckBox6";
            this.materialCheckBox6.Ripple = true;
            this.materialCheckBox6.Size = new System.Drawing.Size(63, 30);
            this.materialCheckBox6.TabIndex = 5;
            this.materialCheckBox6.Text = "Hight";
            this.materialCheckBox6.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(114, 259);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(31, 36);
            this.materialFlatButton1.TabIndex = 9;
            this.materialFlatButton1.Text = "GO";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column});
            this.Grid.Location = new System.Drawing.Point(293, 84);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(152, 315);
            this.Grid.TabIndex = 10;
            // 
            // Column
            // 
            this.Column.HeaderText = "Processes";
            this.Column.Name = "Column";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Depth = 0;
            this.ResultLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResultLabel.Location = new System.Drawing.Point(136, 333);
            this.ResultLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 19);
            this.ResultLabel.TabIndex = 11;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(30, 333);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Current";
            // 
            // Logs
            // 
            this.Logs.FormattingEnabled = true;
            this.Logs.Location = new System.Drawing.Point(451, 84);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(254, 316);
            this.Logs.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 420);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialCheckBox4);
            this.Controls.Add(this.materialCheckBox5);
            this.Controls.Add(this.materialCheckBox6);
            this.Controls.Add(this.materialCheckBox3);
            this.Controls.Add(this.materialCheckBox2);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox3;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox4;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox5;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        public System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        public MaterialSkin.Controls.MaterialLabel ResultLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ListBox Logs;
    }
}

