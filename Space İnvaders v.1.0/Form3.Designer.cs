namespace Space_İnvaders_v._1._0
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oyuncuAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yüksekSkorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uzaylı_AvıDataSet1 = new Space_İnvaders_v._1._0.Uzaylı_AvıDataSet1();
            this.skorTableAdapter = new Space_İnvaders_v._1._0.Uzaylı_AvıDataSet1TableAdapters.skorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzaylı_AvıDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oyuncuAdıDataGridViewTextBoxColumn,
            this.yüksekSkorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.skorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 304);
            this.dataGridView1.TabIndex = 5;
            // 
            // oyuncuAdıDataGridViewTextBoxColumn
            // 
            this.oyuncuAdıDataGridViewTextBoxColumn.DataPropertyName = "Oyuncu_Adı";
            this.oyuncuAdıDataGridViewTextBoxColumn.HeaderText = "Oyuncu_Adı";
            this.oyuncuAdıDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.oyuncuAdıDataGridViewTextBoxColumn.Name = "oyuncuAdıDataGridViewTextBoxColumn";
            this.oyuncuAdıDataGridViewTextBoxColumn.Width = 150;
            // 
            // yüksekSkorDataGridViewTextBoxColumn
            // 
            this.yüksekSkorDataGridViewTextBoxColumn.DataPropertyName = "Yüksek_Skor";
            this.yüksekSkorDataGridViewTextBoxColumn.HeaderText = "Yüksek_Skor";
            this.yüksekSkorDataGridViewTextBoxColumn.Name = "yüksekSkorDataGridViewTextBoxColumn";
            // 
            // skorBindingSource
            // 
            this.skorBindingSource.DataMember = "skor";
            this.skorBindingSource.DataSource = this.uzaylı_AvıDataSet1;
            // 
            // uzaylı_AvıDataSet1
            // 
            this.uzaylı_AvıDataSet1.DataSetName = "Uzaylı_AvıDataSet1";
            this.uzaylı_AvıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skorTableAdapter
            // 
            this.skorTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yüksek Skor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Menüye Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(399, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Sıralama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzaylı_AvıDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Uzaylı_AvıDataSet1 uzaylı_AvıDataSet1;
        private System.Windows.Forms.BindingSource skorBindingSource;
        private Uzaylı_AvıDataSet1TableAdapters.skorTableAdapter skorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyuncuAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yüksekSkorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}