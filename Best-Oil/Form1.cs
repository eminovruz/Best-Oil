namespace Best_Oil
{
    public partial class Form1 : Form
    {
        private double oilPrice;
        private List<FastFood> foods = new();

        public Form1()
        {
            InitializeComponent();
            foods.Add(new FastFood("Hot dog", 4));
            foods.Add(new FastFood("Pizza", 2));
            foods.Add(new FastFood("Qogal", 3));
            foods.Add(new FastFood("Simit", 1));
            OilListBx.Items.Add("92");
            OilListBx.Items.Add("95");
            OilListBx.Items.Add("Premium");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in foods)
            {
                UC_Food food = new();
                food.Food_checkbx.Text = item.Name;
                food.total_msgbx.Text = item.Price.ToString();
                food.Dock = DockStyle.Top;
                McDonalds.Controls.Add(food);
            }


        }

        private void OilListBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(OilListBx.SelectedItem == "92")
            {
                oilPrice = 1;
                OilTotal.Text = oilPrice.ToString();
            }
            else if(OilListBx.SelectedItem == "95")
            {
                oilPrice = 2;
                OilTotal.Text = oilPrice.ToString();
            }
            else
            {
                oilPrice = 3;
                OilTotal.Text = oilPrice.ToString();
            }
        }

        private void ForMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (ForOil.Checked)
            {
                ForMoneyTxt.Enabled = false;
                ForOiltxt.Enabled = true;
            }
            else
            {
                ForOiltxt.Enabled = false;
                ForMoneyTxt.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ForOil.Checked == true)
            {
                Total_lbl.Text = (Int32.Parse(ForOiltxt.Text) * oilPrice).ToString();
                totaloil_lbl.Text = ForOiltxt.Text;
            }
            else if(ForMoney.Checked == true)
            {
                Total_lbl.Text = ForMoneyTxt.Text;
                MessageBox.Show($"Returned Cash: {(Int32.Parse(ForMoneyTxt.Text) % oilPrice).ToString()}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}