using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CostPurchase
{
    public partial class FormStore : Form
    {
        public FormStore()
        {
            InitializeComponent();

            using (StreamReader f = new StreamReader("Pricelist.txt", System.Text.Encoding.GetEncoding(1251)))
            {
                _priceList = new List<double> { };
                string line;
                while ((line = f.ReadLine()) != null && line != "")
                {
                    _priceList.Add(double.Parse(line));
                    listBoxPrice.Items.Add(line + " Руб");
                }
            }
            using (StreamReader f1 = new StreamReader("GoodsList.txt", System.Text.Encoding.UTF8)) 
            {
                _checkBoxContent = new List<string> { };
                string line;
                while ((line = f1.ReadLine()) !=null && line != "") 
                {
                    _checkBoxContent.Add(line);
                    GoodsList.Items.Add(line);
                }
            }
        }

        private string[] priceResult;
        private List<string> _checkBoxContent;
        private List<double> _priceList;
        private double _summ = 0;
        private bool ValidCharFound(string str) 
        {
            bool valid = true;
            foreach (char c in str) 
            {
                string bfr = c.ToString();
                if (Regex.IsMatch(bfr, @"[0-9]"))
                {
                    valid = true;
                }
                else 
                {
                    valid = false;
                    break;
                }
            }
        return valid;
        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int i = 0;

            do
            {
                if (GoodsList.GetItemChecked(i))
                {
                    _summ += _priceList.ElementAt(i);
                }
                i++;
            } while (i < GoodsList.Items.Count);

            MessageBox.Show(Convert.ToString(_summ) + " Руб.", "Стоимость заказа " + MessageBoxButtons.OK);

            _summ = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void buttonAddGoods_Click(object sender, EventArgs e)
        {
            FormStore formStore = new FormStore();

            if (!string.IsNullOrEmpty(textBoxGoodsName.Text) && !string.IsNullOrEmpty(textBoxGoodsPrice.Text))
            {
                if (ValidCharFound(textBoxGoodsPrice.Text) && !ValidCharFound(textBoxGoodsName.Text))
                {
                    GoodsList.Items.Add(textBoxGoodsName.Text);
                    _priceList.Add(int.Parse(textBoxGoodsPrice.Text));
                    _checkBoxContent.Add(textBoxGoodsName.Text);
                    listBoxPrice.Items.Add(textBoxGoodsPrice.Text);

                    formStore.Refresh();
                }
                else
                {
                    MessageBox.Show("Укажите корректные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Не вcе данные внесены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            priceResult = _priceList.Select(x => x.ToString()).ToArray();

            File.WriteAllLines("GoodsList.txt", _checkBoxContent);
            File.WriteAllLines("Pricelist.txt", priceResult);
        }
    }
}
