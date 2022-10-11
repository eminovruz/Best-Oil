namespace Best_Oil
{
    partial class UC_Food
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Food_checkbx = new System.Windows.Forms.CheckBox();
            this.total_msgbx = new System.Windows.Forms.TextBox();
            this.Count_msgbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Food_checkbx
            // 
            this.Food_checkbx.Location = new System.Drawing.Point(10, 8);
            this.Food_checkbx.Margin = new System.Windows.Forms.Padding(1);
            this.Food_checkbx.Name = "Food_checkbx";
            this.Food_checkbx.Size = new System.Drawing.Size(81, 20);
            this.Food_checkbx.TabIndex = 1;
            this.Food_checkbx.Text = "checkBox1";
            
            this.Food_checkbx.UseVisualStyleBackColor = true;
            this.Food_checkbx.CheckedChanged += new System.EventHandler(this.Food_checkbx_CheckedChanged);
            // 
            // total_msgbx
            // 
            this.total_msgbx.Location = new System.Drawing.Point(112, 5);
            this.total_msgbx.Margin = new System.Windows.Forms.Padding(1);
            this.total_msgbx.Name = "total_msgbx";
            this.total_msgbx.ReadOnly = true;
            this.total_msgbx.Size = new System.Drawing.Size(85, 23);
            this.total_msgbx.TabIndex = 2;
            // 
            // Count_msgbx
            // 
            this.Count_msgbx.Location = new System.Drawing.Point(206, 5);
            this.Count_msgbx.Margin = new System.Windows.Forms.Padding(1);
            this.Count_msgbx.Name = "Count_msgbx";
            this.Count_msgbx.Size = new System.Drawing.Size(85, 23);
            this.Count_msgbx.TabIndex = 3;
            this.Count_msgbx.TextChanged += new System.EventHandler(this.Count_msgbx_TextChanged);
            // 
            // UC_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Count_msgbx);
            this.Controls.Add(this.total_msgbx);
            this.Controls.Add(this.Food_checkbx);
            this.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "UC_Food";
            this.Size = new System.Drawing.Size(322, 33);
            this.Load += new System.EventHandler(this.UC_Food_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CheckBox Food_checkbx;
        public TextBox total_msgbx;
        public TextBox Count_msgbx;
    }
}
