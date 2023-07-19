namespace HavaDurumu
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            İL = new DataGridViewTextBoxColumn();
            DURUM = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(4, 12);
            button1.Name = "button1";
            button1.Size = new Size(616, 45);
            button1.TabIndex = 0;
            button1.Text = "Hava Durumu Bilgilerini Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { İL, DURUM, Column2 });
            dataGridView1.Location = new Point(4, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(612, 270);
            dataGridView1.TabIndex = 1;
            // 
            // İL
            // 
            İL.HeaderText = "İL";
            İL.Name = "İL";
            // 
            // DURUM
            // 
            DURUM.HeaderText = "DURUM";
            DURUM.Name = "DURUM";
            // 
            // Column2
            // 
            Column2.HeaderText = "MAKSİMUM SICAKLIK";
            Column2.Name = "Column2";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 344);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "form1";
            Text = "Hava Durumu";
            Load += form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn İL;
        private DataGridViewTextBoxColumn DURUM;
        private DataGridViewTextBoxColumn Column2;
    }
}