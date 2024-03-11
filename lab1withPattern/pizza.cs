using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1withPattern;

public abstract class PizzaStore
{
    public Pizza orderPizza(string type) 
    {
        Pizza pizza;
        pizza = createPizza(type);

        pizza.prepare();
        pizza.bake();
        pizza.cut();
        pizza.box();
        return pizza;
    }
    protected abstract Pizza createPizza(string type); //фабрика
}

public class TomskPizzaStore : PizzaStore
{
    protected override Pizza createPizza(string type)
    {
        if (type == "Cheese") return new TomskCheesePizza();
        else if (type == "Pepperoni") return new TomskPepperoniPizza();
        else if (type == "Mandarin") return new TomskMandarinPizza();
        else return null;
    }

}

public class NovosibirskPizzaStore : PizzaStore
{
    protected override Pizza createPizza(string type)
    {
        if (type == "Cheese") return new NovosibirskCheesePizza();
        else if (type == "Pepperoni") return new NovosibirskPepperoniPizza();
        else if (type == "Mandarin") return new NovosibirskMandarinPizza();
        else return null;
    }
}

public abstract class Pizza
{
    const int topingsNumber = 2; //idk
    public string name, dough, sauce;
    public string[] topings = new string[topingsNumber];

    public string textForTextbox;

    public void prepare()
    {
        textForTextbox += name;
        textForTextbox += "\nВот такое тесто раскаталось: " + dough;
        textForTextbox += "\nCоус: " + sauce;
        textForTextbox += "\nДобавляем добавки!";
        for(int i = 0; i < topingsNumber; i++)
        {
            textForTextbox += "\n    " + topings[i];
        }
    }

    public void bake()
    {
        textForTextbox += "\nПицца в дровяной Помпейской печи";
    }

    public void cut()
    {
        textForTextbox += "\nДелим пиццу";
    }

    public void box()
    {
        textForTextbox += "\nСкладываем";
    }

}

public class TomskCheesePizza : Pizza
{
    public TomskCheesePizza()
    {
        name = "Томская сырная пицца";
        dough = "Розовое тесто";
        sauce = "Просто соус";
        topings[0] = "Сыр1";
        topings[1] = "Сыр2";
    }
}
public class TomskPepperoniPizza : Pizza
{
    public TomskPepperoniPizza()
    {
        name = "Томская пицца пепперони";
        dough = "Просто тесто";
        sauce = "Просто соус";
        topings[0] = "Сырокопченая колбаса";
    }
}
public class TomskMandarinPizza : Pizza
{
    public TomskMandarinPizza()
    {
        name = "Томская мандариновая пицца";
        dough = "Просто тесто";
        sauce = "Без соуса";
        topings[0] = "Банан";
    }
}

public class NovosibirskCheesePizza : Pizza
{
    public NovosibirskCheesePizza()
    {
        name = "Новосибирская сырная пицца";
        dough = "Просто тесто";
        sauce = "Просто соус";
        topings[0] = "Сыр1";
        topings[1] = "Сыр2";
    }
}
public class NovosibirskPepperoniPizza : Pizza
{
    public NovosibirskPepperoniPizza()
    {
        name = "Новосибирская пицца пепперони";
        dough = "Просто тесто";
        sauce = "Просто соус";
        topings[0] = "Сырокопченая колбаса";
    }
}
public class NovosibirskMandarinPizza : Pizza
{
    public NovosibirskMandarinPizza()
    {
        name = "Новосибирская мандариновая пицца";
        dough = "Просто тесто";
        sauce = "Без соуса";
        topings[0] = "Апельсин";
    }
}
