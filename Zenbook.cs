using System;

public class Zenbook : Laptop

{
    public bool TouchScreen => true;

     public void TurnOff()
    {
        Console.WriteLine("Turning off Zenbook");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on Zenbook");
    }

     public void TurnOn(bool accessBIOS)
    {
        if(accessBIOS)
        {
            Console.WriteLine("Turnin on BIOS on Zenbook");

        } else {

            Console.WriteLine("Not accessing BIOS on Zenbook, just turning on.");
        }
    }
}