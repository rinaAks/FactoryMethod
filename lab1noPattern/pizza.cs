using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public class Pizza
    {
        private string pizzaStyle, pizzaType;
        public Pizza orderPizza(String style, String type)
        {
            Pizza pizza = new Pizza();
            if(style == "Tomsk")
            {
                if (type == "Cheese") pizza = new TomskCheesePizza();
                else if (type == "Pepperoni") pizza = new TomskPepperoniPizza();
                else if (type == "Mandarin") pizza = new TomskMandarinPizza();
            }
            else if(style == "Novosibirsk")
            {
                if (type == "Cheese") pizza = new NovosibirskCheesePizza();
                else if (type == "Pepperoni") pizza = new NovosibirskPepperoniPizza();
                else if (type == "Mandarin") pizza = new NovosibirskMandarinPizza();
            }
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            pizzaStyle = style;
            pizzaType = type;

            return pizza;
        }

        public string PizzaStyle()
        {
            return pizzaStyle;
        }
        public string PizzaType()
        {
            return pizzaType;
        }

        public void prepare()
        {

        }

        public void bake()
        {

        }

        public void cut()
        {

        }

        public void box()
        {

        }
    }

    public class TomskCheesePizza : Pizza
    {
        
    }
    public class TomskPepperoniPizza : Pizza
    {

    }
    public class TomskMandarinPizza : Pizza
    {

    }

    public class NovosibirskCheesePizza : Pizza
    {

    }
    public class NovosibirskPepperoniPizza : Pizza
    {

    }
    public class NovosibirskMandarinPizza : Pizza
    {

    }


}
