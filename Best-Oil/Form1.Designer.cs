namespace Best_Oil
{
    partial class Form1
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
            this.Oil = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totaloil_lbl = new System.Windows.Forms.Label();
            this.ForOiltxt = new System.Windows.Forms.TextBox();
            this.ForMoneyTxt = new System.Windows.Forms.TextBox();
            this.ForOil = new System.Windows.Forms.RadioButton();
            this.ForMoney = new System.Windows.Forms.RadioButton();
            this.OilTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.OilListBx = new System.Windows.Forms.ListBox();
            this.McDonalds = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.foodtotal_lbl = new System.Windows.Forms.Label();
            this.Cash = new System.Windows.Forms.GroupBox();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.Oil.SuspendLayout();
            this.McDonalds.SuspendLayout();
            this.Cash.SuspendLayout();
            this.SuspendLayout();
            // 
            // Oil
            // 
            this.Oil.Controls.Add(this.button1);
            this.Oil.Controls.Add(this.label2);
            this.Oil.Controls.Add(this.totaloil_lbl);
            this.Oil.Controls.Add(this.ForOiltxt);
            this.Oil.Controls.Add(this.ForMoneyTxt);
            this.Oil.Controls.Add(this.ForOil);
            this.Oil.Controls.Add(this.ForMoney);
            this.Oil.Controls.Add(this.OilTotal);
            this.Oil.Controls.Add(this.label1);
            this.Oil.Controls.Add(this.label);
            this.Oil.Controls.Add(this.OilListBx);
            this.Oil.Location = new System.Drawing.Point(33, 24);
            this.Oil.Name = "Oil";
            this.Oil.Size = new System.Drawing.Size(280, 414);
            this.Oil.TabIndex = 0;
            this.Oil.TabStop = false;
            this.Oil.Text = "Best-Oil";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(30, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "ACCEPT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Oil: ";
            // 
            // totaloil_lbl
            // 
            this.totaloil_lbl.BackColor = System.Drawing.Color.DarkGray;
            this.totaloil_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totaloil_lbl.Location = new System.Drawing.Point(30, 274);
            this.totaloil_lbl.Name = "totaloil_lbl";
            this.totaloil_lbl.Size = new System.Drawing.Size(231, 46);
            this.totaloil_lbl.TabIndex = 8;
            this.totaloil_lbl.Text = "0";
            // 
            // ForOiltxt
            // 
            this.ForOiltxt.Location = new System.Drawing.Point(136, 181);
            this.ForOiltxt.Name = "ForOiltxt";
            this.ForOiltxt.Size = new System.Drawing.Size(125, 27);
            this.ForOiltxt.TabIndex = 7;
            // 
            // ForMoneyTxt
            // 
            this.ForMoneyTxt.Location = new System.Drawing.Point(136, 149);
            this.ForMoneyTxt.Name = "ForMoneyTxt";
            this.ForMoneyTxt.Size = new System.Drawing.Size(125, 27);
            this.ForMoneyTxt.TabIndex = 6;
            // 
            // ForOil
            // 
            this.ForOil.AutoSize = true;
            this.ForOil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForOil.Location = new System.Drawing.Point(30, 182);
            this.ForOil.Name = "ForOil";
            this.ForOil.Size = new System.Drawing.Size(72, 24);
            this.ForOil.TabIndex = 5;
            this.ForOil.TabStop = true;
            this.ForOil.Text = "ForOil";
            this.ForOil.UseVisualStyleBackColor = true;
            // 
            // ForMoney
            // 
            this.ForMoney.AutoSize = true;
            this.ForMoney.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForMoney.Location = new System.Drawing.Point(30, 152);
            this.ForMoney.Name = "ForMoney";
            this.ForMoney.Size = new System.Drawing.Size(105, 24);
            this.ForMoney.TabIndex = 4;
            this.ForMoney.TabStop = true;
            this.ForMoney.Text = "For money";
            this.ForMoney.UseVisualStyleBackColor = true;
            this.ForMoney.CheckedChanged += new System.EventHandler(this.ForMoney_CheckedChanged);
            // 
            // OilTotal
            // 
            this.OilTotal.Location = new System.Drawing.Point(102, 84);
            this.OilTotal.Name = "OilTotal";
            this.OilTotal.Size = new System.Drawing.Size(148, 27);
            this.OilTotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Money: ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(30, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 20);
            this.label.TabIndex = 1;
            this.label.Text = "Oil: ";
            // 
            // OilListBx
            // 
            this.OilListBx.ColumnWidth = 5;
            this.OilListBx.FormattingEnabled = true;
            this.OilListBx.ItemHeight = 20;
            this.OilListBx.Location = new System.Drawing.Point(102, 42);
            this.OilListBx.Name = "OilListBx";
            this.OilListBx.Size = new System.Drawing.Size(148, 24);
            this.OilListBx.TabIndex = 0;
            this.OilListBx.SelectedIndexChanged += new System.EventHandler(this.OilListBx_SelectedIndexChanged);
            // 
            // McDonalds
            // 
            this.McDonalds.Controls.Add(this.button2);
            this.McDonalds.Controls.Add(this.label3);
            this.McDonalds.Controls.Add(this.foodtotal_lbl);
            this.McDonalds.Location = new System.Drawing.Point(319, 24);
            this.McDonalds.Name = "McDonalds";
            this.McDonalds.Size = new System.Drawing.Size(322, 414);
            this.McDonalds.TabIndex = 1;
            this.McDonalds.TabStop = false;
            this.McDonalds.Text = "McDonalds";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(20, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "ACCEPT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Food: ";
            // 
            // foodtotal_lbl
            // 
            this.foodtotal_lbl.BackColor = System.Drawing.Color.DarkGray;
            this.foodtotal_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.foodtotal_lbl.Location = new System.Drawing.Point(20, 274);
            this.foodtotal_lbl.Name = "foodtotal_lbl";
            this.foodtotal_lbl.Size = new System.Drawing.Size(231, 46);
            this.foodtotal_lbl.TabIndex = 11;
            this.foodtotal_lbl.Text = "0";
            // 
            // Cash
            // 
            this.Cash.Controls.Add(this.Total_lbl);
            this.Cash.Location = new System.Drawing.Point(33, 444);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(608, 144);
            this.Cash.TabIndex = 2;
            this.Cash.TabStop = false;
            this.Cash.Text = "Cash";
            // 
            // Total_lbl
            // 
            this.Total_lbl.AutoSize = true;
            this.Total_lbl.Location = new System.Drawing.Point(30, 39);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(0, 20);
            this.Total_lbl.TabIndex = 0;
            this.Total_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 602);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.McDonalds);
            this.Controls.Add(this.Oil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Oil.ResumeLayout(false);
            this.Oil.PerformLayout();
            this.McDonalds.ResumeLayout(false);
            this.McDonalds.PerformLayout();
            this.Cash.ResumeLayout(false);
            this.Cash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Oil;
        private TextBox OilTotal;
        private Label label1;
        private Label label;
        private ListBox OilListBx;
        private GroupBox McDonalds;
        private RadioButton ForOil;
        private RadioButton ForMoney;
        private TextBox ForOiltxt;
        private TextBox ForMoneyTxt;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        public Label totaloil_lbl;
        public Label Total_lbl;
        public Label foodtotal_lbl;
        public GroupBox Cash;
    }
}