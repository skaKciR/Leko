using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Drawing;

namespace LR0Moroz
{
    public partial class MainTable : Form
    {
        public string urm = "Kok";
        public MainTable()
        {
            InitializeComponent();
        }
        public MainTable(string[] s)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(s);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddOrderForm child = new AddOrderForm(this);
            child.Show();
        }    
        private void ClearButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            label6.Text = "0";
            label3.Text = "";
            label4.Text = "";
        }
        private void ClearSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].Value != null)
            {
                int ind = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(ind);
            } else MessageBox.Show("Заказ отсутсвует!");
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells[0].Value != null)
            {
                EditForm child = new EditForm(this);
                child.EditOrder.Text = dataGridView1.SelectedCells[0].Value.ToString();
                child.Show();
            }
            else MessageBox.Show("Выбранная ячейка пуста!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            Stream mystr = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    try
                    {
                        string[] str1 = myread.ReadToEnd().Split('\n');
                        int num = str1.Count();
                        dataGridView1.RowCount = num;
                        for (int i = 0; i < num-1; i++)
                        {
                            str = str1[i].Split('^');
                                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {                                   
                                    string data = str[j].Replace("[etot_simvol]", "^");
                                    dataGridView1.Rows[i].Cells[j].Value = str[j]; 
                                }
                                catch { }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                    }
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog()== DialogResult.OK) 
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null) 
                {
                    StreamWriter myWrite = new StreamWriter(myStream);
                    try 
                    {
                    for (int i =0; i<dataGridView1.RowCount -1; i++) 
                        {
                        for (int j = 0; j<dataGridView1.ColumnCount; j++) 
                            {
                                string data = dataGridView1.Rows[i].Cells[j].Value.ToString().Replace("^", "[etot_simvol]");
                                myWrite.Write(data + "^" );                          
                            }
                            myWrite.WriteLine(); 
                        }               
                    } catch(Exception ex) 
                    {
                        MessageBox.Show(ex.Message);
                    
                    }
                    finally 
                    {
                        myWrite.Close();
                    }
                    myStream.Close();               
                }            
            }
        }
        private void MainTable_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Добавить заказ");
            t.SetToolTip(ClearSelected,"Удалить заказ");
            t.SetToolTip(ClearButton,"Очистить таблицу");
            t.SetToolTip(button3, "Редактировать заказ");
            t.SetToolTip(button4, "Найти товар");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
            Random rnd = new Random();
            int value = rnd.Next(1, 1000);
            if (textBox1.Text == "") { MessageBox.Show("Пустой шифр!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }
            else
            {
                int a = Convert.ToInt32(textBox1.Text);
                if ((a > 1005) || (a < 1001))
                {
                    MessageBox.Show(
                 "Товар с заданным шифром отсутствует на складе",
                 "Информация по товару",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
                 MessageBoxDefaultButton.Button1);
                }
                if (a == 1001)
                {
                    MessageBox.Show(
             "Товар с шифром 1001:Ноутбук Acer Nitro 5. Количество на складе:" + value,
             "Информация по товару",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button1);
                }
                if (a == 1002)
                {
                    MessageBox.Show(
             "Товар с шифром 1002:Наушники Apple AirPods Pro. Количество на складе:" + value,
             "Информация по товару",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button1);
                }
                if (a == 1003)
                {
                    MessageBox.Show(
             "Товар с шифром 1003:Умная станция Алиса. Количество на складе:" + value,
             "Информация по товару",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button1);
                }
                if (a == 1004)
                {
                    MessageBox.Show(
             "Товар с шифром 1004:Чехол для телефона. Количество на складе:" + value,
             "Информация по товару",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button1);
                }
                if (a == 1005)
                {
                    MessageBox.Show(
             "Товар с шифром 1005:Кабель USB Type-C. Количество на складе:" + value,
             "Информация по товару",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button1);
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
           int j = Convert.ToInt32(dataGridView1.RowCount.ToString())-1;
            string s;

            label3.Text= (from DataGridViewRow row in dataGridView1.Rows
                               where row.Cells[3].FormattedValue.ToString() != string.Empty
                               select Convert.ToInt32(row.Cells[3].FormattedValue)).Max().ToString();
            int u = Convert.ToInt32(label3.Text);
            label4.Text = (from DataGridViewRow row in dataGridView1.Rows
                           where row.Cells[3].FormattedValue.ToString() != string.Empty
                           select Convert.ToInt32(row.Cells[3].FormattedValue)).Min().ToString();
            for (int i = 0; i < j; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[3].Value) == label3.Text)
                    label3.Text = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);

                }
            for (int i = 0; i < j; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[3].Value) == label4.Text)
                    label4.Text = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);

            }


            double sum1 = 0d;
            for (int i = 0; i < j; i++)
            {
                sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value)*(Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) - Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value));
            }
            label6.Text = Convert.ToString(sum1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string season = Data.Text;
            int j = Convert.ToInt32(dataGridView1.RowCount.ToString()) - 1;
            int x = 0;
            for (int i = 0; i < j; i++)
            {
                DateTime today = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                x = today.Month;
                if (dataGridView1.Rows[i].Cells[4].Value != null)
                {

                    if ((season == "Зима") && ((x == 12) || (x == 1) || (x == 2)))
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        j--;
                        i--;

                    }
                    if ((season == "Весна") && ((x == 3) || (x == 4) || (x == 5)))
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        j--;
                        i--;

                    }
                    if ((season == "Лето") && ((x == 6) || (x == 7) || (x == 8)))
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        j--;
                        i--;

                    }
                    if ((season == "Осень") && ((x == 8) || (x == 10) || (x == 11)))
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        j--;
                        i--;

                    }
                }
                
                label6.Text =Convert.ToString(x);
            }
          
        }
        public string test()
        {
            string[] s = { "Айфон", "1006", "13000", "95000", "5 декабря 2021г.", "50" };
            string one = string.Join(Convert.ToString(' '), s);
            textBox2.Text += one;
            return one;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            DateTime first = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime second = Convert.ToDateTime(dateTimePicker2.Value);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DateTime today = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                if((today>=first)&&(today<=second))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
  
