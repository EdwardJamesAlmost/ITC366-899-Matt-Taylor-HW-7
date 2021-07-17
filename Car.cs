using System;
using System.Collections.Generic;
using System.Text;

class Car
{
    private string color;
    private int price;
    
    public Car() : this(10000, "black")
    {
    }
    public Car(int price) : this(price,"black")  // I don't believe the initializer is set correctly to produce the displayed outcome. 

    {
    }
    public Car(int price, string color)
    {
        // use of the this keyword doesn't reference a class field, there are case issues between the class field variable names and the constructor parameters
        this.price = price;
        this.color = color;
    }
    public string Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }
    public int Price
    {
        get
        {
            return price; // using a capital P here caused a stack overflow as it was stuck in a loop of calling and returning a variable
        }
        set
        {
            price = value;
        }
    }





}

