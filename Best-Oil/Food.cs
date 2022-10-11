using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Best_Oil
{
    public partial class UC_Food : UserControl
    {
        private int price = 0;


        public UC_Food()
        {
            InitializeComponent();
            Count_msgbx.Enabled = false;
            total_msgbx.Enabled = false;
        }

        private void Food_checkbx_CheckedChanged(object sender, EventArgs e)
        {

            if (Food_checkbx.Checked)
                Count_msgbx.Enabled = true;
            else
                Count_msgbx.Enabled = false;

        }

        private void Count_msgbx_TextChanged(object sender, EventArgs e)
        {
            total_msgbx.Text = (Int32.Parse(Count_msgbx.Text) * price).ToString();
            
        }

        private void UC_Food_Load(object sender, EventArgs e)
        {
            price = Int32.Parse(total_msgbx.Text);
            

        }
    }
}
