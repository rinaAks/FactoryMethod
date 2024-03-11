using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1withPattern;

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

        PizzaStore pizzaStore;
        if (pizzaStyle == "Tomsk") pizzaStore = new TomskPizzaStore();
        else if (pizzaStyle == "Novosibirsk") pizzaStore = new NovosibirskPizzaStore();
        else pizzaStore = null;

        Pizza pizza = pizzaStore.orderPizza(pizzaType);

        tbResult.Text += pizza.textForTextbox;
    }
    
}
