Guy joe = new Guy() { Name = "joe", Cash = 50 };
Guy bob = new Guy() { Name = "bob", Cash = 100 };

while (true)
{
    Console.Write("Enter an amount: ");
    string howMuch=Console.ReadLine();
    if (howMuch == "")
    {
        return;
    }
    if(int.TryParse(howMuch,out int amount))
    {
        Console.Write("Who should give the cash: ");
        string whichGuy=Console.ReadLine();
        if(whichGuy == "joe")
        {
            int cashGiven=joe.GiveCash(amount);
            bob.ReceiveCash(cashGiven);
            totalCash();
        }else if(whichGuy == "bob")
        {
            int cashGiven=bob.GiveCash(amount);
            joe.ReceiveCash(cashGiven);
            totalCash();
        }
        else
        {
            Console.WriteLine("which 'joe' or 'bob' ");
        }
    }
    else
    {
        Console.WriteLine("Please enter an amount");
    }

}
void totalCash()
{
    Console.WriteLine("bob剩餘金額: " + bob.Cash);
    Console.WriteLine("joe剩餘金額: " + joe.Cash);
}
class Guy
{
    public string Name=string.Empty;
    public int Cash=0;

    public void WriteMyInfo()
    {
        Console.WriteLine(Name + " has " + Cash + " bucks.");
    }

    public int GiveCash(int amount)
    {
        if(amount <= 0)
        {
            Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
            return 0;
        }
        if (amount > Cash)
        {
            Console.WriteLine(Name + " says: " + "I don't have enough cash to give you " + amount);
            return 0;
        }
        Cash -= amount;
        return amount;
    }
    public void ReceiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take");
        }
        else
        {
            Cash+=amount;
        }
    }
}
