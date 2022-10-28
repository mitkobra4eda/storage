using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {

        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String prodName = textBox1.Text;
            int quantity = Convert.ToInt32(textBox2.Text);
            double price = Convert.ToDouble(textBox3.Text);

            string[] row = new string[] {prodName, price.ToString(), quantity.ToString()};
            form1.grid.Rows.Add(row);
        }
    }
}
