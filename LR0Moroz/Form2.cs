using System;
using System.Windows.Forms;

namespace LR0Moroz
{
    public partial class AddOrderForm : Form
    {   public string Lexa = "BEST";
        public MainTable otherForm;
        public double a = 0;
        public AddOrderForm(MainTable form1)
        {
            InitializeComponent();
            otherForm = form1;
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainTable f1 = new MainTable();
            f1.ShowDialog();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((Custsurname.Text.Equals("")) || (Opt.Text.Equals("")) || (Value.Text.Equals(""))||(Rozn.Text.Equals("")))
            {
                MessageBox.Show("Вы не ввели все необходимые данные!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (Convert.ToDouble(Opt.Text) > Convert.ToDouble(Rozn.Text))
                {
                    MessageBox.Show("Не выгодная перепродажа товаров", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                   
                    otherForm.dataGridView1.Rows.Add(Custsurname.Text, ONumber.Text, Opt.Text, Rozn.Text, Date2.Text, Value.Text);
                    Hide();
                }
            }
           
        }
        private void Custsurname_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            }
            
        private void ProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b' && l != '.')
            {
                e.Handled = true;
                MessageBox.Show("Введите только цифры!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }


        }      
        private void MSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
                MessageBox.Show("Введите только буквы!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
         
        }
        private void Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b' && l != '.')
            {
                e.Handled = true;
                MessageBox.Show("Введите только цифры!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }    
        }
        private void Value_KeyPress(object sender, KeyPressEventArgs e)
        {

            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b' && l != '.')
            {
                e.Handled = true;
                MessageBox.Show("Введите только цифры!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void ONumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Custurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Custsurname.Text;
            int y = 1;
            int x = 1;
            if (Custsurname.Text == "Ноутбук Acer Nitro 5")
            {
                y = 25000;
                x = 50000;
                Opt.Text = Convert.ToString(y);
                Rozn.Text = Convert.ToString(x);
                ONumber.Text = Convert.ToString(1001);
            }
            if (Custsurname.Text == "Наушники Apple AirPods Pro")
            {
                y *= 5000;
                x *= 15000;
                Opt.Text = Convert.ToString(y);
                Rozn.Text = Convert.ToString(x);
                ONumber.Text = Convert.ToString(1002);
            }
            if (Custsurname.Text == "Умная станция Алиса")
            {
                y = 13000;
                x = 26000;
                Opt.Text = Convert.ToString(y);
                Rozn.Text = Convert.ToString(x);
                ONumber.Text = Convert.ToString(1003);
            }
            if (Custsurname.Text == "Чехол для телефона")
            {
                y = 150;
                x = 350;
                Opt.Text = Convert.ToString(y);
                Rozn.Text = Convert.ToString(x);
                ONumber.Text = Convert.ToString(1004);
            }
            if (Custsurname.Text == "Кабель USB Type-C")
            {
                y = 50;
                x = 200;
                Opt.Text = Convert.ToString(y);
                Rozn.Text = Convert.ToString(x);
                ONumber.Text = Convert.ToString(1005);
            }
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void Value_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rozn.Text = Convert.ToString(Convert.ToInt32(Rozn.Text) * (1+Convert.ToDouble(textBox2.Text)/100));
        }
    }
}
