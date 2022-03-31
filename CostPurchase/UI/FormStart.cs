using System;
using System.Windows.Forms;

namespace CostPurchase
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();

            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp form = new FormHelp();
            form.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            FormStore form = new FormStore();
            form.ShowDialog();
        }
    }
}
