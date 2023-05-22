public class Mackbook : Laptop
{
    public bool TouchScreen => false;

    public void TurnOff()
    {
        Console.WriteLine("Turning off Mackbook");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on Mackbook");
    }

    public void TurnOn(bool accessBIOS)
    {
        if(accessBIOS)
        {
            Console.WriteLine("Turnin on BIOS on Mackbook");

        } else {

            Console.WriteLine("Not accessing BIOS on Mackbook, just turning on.");
        }
    }
}