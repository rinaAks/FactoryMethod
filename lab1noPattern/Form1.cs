using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string pizzaStyle, pizzaType;
        private void btStart_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
            pizzaStyle = (string)cbStyle.SelectedItem.ToString();
            pizzaType = (string)cbType.SelectedItem.ToString();

            Pizza pizza = new Pizza();

            pizza.orderPizza(pizzaStyle, pizzaType);

            tbResult.Text += "Pizza Style: " + pizza.PizzaStyle();
            tbResult.Text += "\nPizza Type: " + pizza.PizzaType();

            pizza.orderPizza(pizzaStyle, pizzaType); 
        }
        
    }
}
