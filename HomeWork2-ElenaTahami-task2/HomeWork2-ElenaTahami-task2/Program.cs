
class Program

{
    static void Main()
    {

        Console.WriteLine("enter Your Request");
        Console.WriteLine("For WithDraw Enter 1 ");
        Console.WriteLine(" For Deposit Enter 2 ");
        int p = Convert.ToInt32(Console.ReadLine());


        BankAccount Client1 = new BankAccount();
        double amount;
        if (p == 1)
        {
            Console.WriteLine("Enter Your Amount");
            amount = Convert.ToDouble(Console.ReadLine());
            Client1.Withdraw(amount);
        }

        else if (p == 2)
        {
            Console.WriteLine("Enter Your Amount");
            amount = Convert.ToDouble(Console.ReadLine());
            Client1.Deposit(amount);

        }
        else if (p != 1 || p != 2)
        {
            Console.WriteLine("Invalid Input");
        }

    }



    class BankAccount
    {
        private int balance = 1000;//موجودی حساب را نگه میدارد

        public void ShowBalance()
        {
            // this.balance = balance;
            Console.WriteLine($" balance is {balance}");
        }
        public void Deposit(double amount)//مقدار مشخص شده را به موجودی اضافه کند //واریز
        {
            balance = balance + Convert.ToInt32(amount);
            ShowBalance();
        }
        public void Withdraw(double amount)//برداشت//مقدار مشخص شده را از موجودی کم کند 

        {
            if (balance >= amount)
            {
                balance = Convert.ToInt32(balance - amount);

            }
            else
            {
                Console.WriteLine(" mojodi kafi nist");
            }
            ShowBalance(); 
        }
    }
}



