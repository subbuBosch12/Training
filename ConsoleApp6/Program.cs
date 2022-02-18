using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public delegate void adddelegate();

    class Program
    {
        public void appBank1()
        {
            int select;
            Console.WriteLine("   Select your option");
            Console.WriteLine("1.Saving account");
            Console.WriteLine("2.Childcare account");
            Console.WriteLine("3.Current account");
            Console.WriteLine("-----------------------------------------------");


            select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("selected saving a/c");
                    Console.WriteLine("This is a saving a/c deposit limit is 1,00,000");
                    int amt1 = Convert.ToInt32(Console.ReadLine());
                    customerinfo ci1 = new customerinfo();
                    ci1.customerdata();
                    savingaccount sg = new savingaccount();
                    sg.transferred(amt1);
                    Console.ReadKey();
                    sg.transferred(amt1);
                    int amt = Convert.ToInt32(Console.ReadLine());
                    Console.ReadKey();
                    sg.transferred(amt);
                   
                    ci1.atm();
                    break;
                case 2:
                    Console.WriteLine("selected child care a/c");
                    Console.WriteLine("This is a childcare a/c deposit limit is 50,000");
                    int amt2 = Convert.ToInt32(Console.ReadLine());
                    customerinfo ci2 = new customerinfo();
                    ci2.customerdata();
                    childcareaccount cc = new childcareaccount();
                    cc.transferred(amt2);
                    Console.ReadKey();
                    ci2.atm();
                    break;

                case 3:
                    Console.WriteLine("selected current a/c");
                    Console.WriteLine("This is a current a/c deposit limit is 2,00,000");
                    int amt3 = Convert.ToInt32(Console.ReadLine());
                    customerinfo ci3 = new customerinfo();
                    ci3.customerdata();
                    currentaccount ca = new currentaccount();
                    ca.transferred(amt3);
                    Console.ReadKey();
                    ci3.atm();
                    break;

            }
        }
    }
    public class customerinfo
    {
        string name;
        int age;
        int accountid;
        string address;
        public void customerdata()
        {
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your accno");
            accountid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your address");
            address = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------");
        }
        public void atm()
        {
            int avlbalance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Any other choice ?");
            for (int i = 1; i <= 3; i++)
            {

                Console.WriteLine("1.Withdrawl");
                Console.WriteLine(" 2.CheckBal ");
                Console.WriteLine(" 3.Exit");
                int Choice = Convert.ToInt32(Console.ReadLine());
                if (Choice == 1)
                {
                    Console.WriteLine("Enter the amount to withdraw");
                    int withdrawlamt = Convert.ToInt32(Console.ReadLine());
                    if (avlbalance > withdrawlamt)
                    {
                        Console.WriteLine("Amount has been withdrawn successfully");
                        avlbalance = avlbalance - withdrawlamt;
                        Console.WriteLine("Remaianing balance in your account is" + avlbalance);
                    }

                    else
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    if (i >= 3)
                    {
                        Console.WriteLine("Day Limit Exceeds  amount is detecting  500 from account");
                        avlbalance = avlbalance - withdrawlamt;
                        Console.WriteLine(" balance before detecting is :" + avlbalance);
                        avlbalance = avlbalance - 500;
                        Console.WriteLine(" balance after detecting is :" + avlbalance);
                    }
                }
                if (Choice == 2)
                {

                    Console.WriteLine("Your available balance is " + avlbalance);
                }
                if (Choice == 3)
                {
                    Environment.Exit(0);
                    Console.ReadKey();
                }
            }
        }
    }


    class Program1
    {
        static void Main(string[] args)
        {
            Program b = new Program();
            b.appBank1();
            P1 pp = new P1();
            pp.customerinfo();
            Console.ReadKey();
        }
    }

    public class CashLimitExceed : Exception
    {
        public CashLimitExceed message;
    }

    class currentaccount
    {
        int availablebal = 0;
        public void transferred(int cash)
        {
            try
            {
                if (cash > 200000)
                {
                    throw new CashLimitExceed();
                }
                else
                {
                    Console.WriteLine("Successfully Deposited to your account  ");
                }
                availablebal = availablebal + cash;
                Console.WriteLine("your current  balance is " + cash);
            }

            catch (CashLimitExceed e)
            {
                Console.WriteLine("limit is 200000 " + e);
            }
        }

    }

    class savingaccount
    {
        int availablebal = 0;
        public void transferred(int cash)
        {
            try
            {
                if (cash > 100000)
                {
                    throw new CashLimitExceed();
                }
                else
                {
                    Console.WriteLine("Successfully Deposited to your account");
                }
                availablebal = availablebal + cash;
                Console.WriteLine("your saving balance is " + cash);
            }
            catch (CashLimitExceed e)
            {
                Console.WriteLine("limit is  100000" + e);
            }
        }
    }
    class childcareaccount
    {
        int availablebal = 0;
        public void transferred(int cash)
        {
            try
            {
                if (cash > 50000)
                {
                    throw new CashLimitExceed();
                }
                else
                {
                    Console.WriteLine("Successfully Deposited to your account");
                }
                availablebal = availablebal + cash;
                Console.WriteLine("your childcare balance is " + cash);
            }
            catch (CashLimitExceed e)
            {
                Console.WriteLine("limit is 50000" + e);
            }

        }
    }

    public class customer
    {
        public int id
        {
            get; set;
        }
        public string name
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public string accounttype
        {
            get;
            set;
        }
        public string transactionstatus
        {
            get;
            set;
        }

    }

    class P1
    {
        public void customerinfo()
        {
            customer c = new customer()
            {
                id = 20091,
                name = "john",
                Gender = "male",
                accounttype = "savings",
                transactionstatus = "successful"

            };
            customer c1 = new customer()
            {
                id = 70091,
                name = "priya",
                Gender = "Female",
                accounttype = "current;",
                transactionstatus = "successful"

            };

            customer c2 = new customer()
            {
                id = 80091,
                name = "ram",
                Gender = "male",
                accounttype = "current",
                transactionstatus = "pending"

            };
            customer c3 = new customer()
            {
                id = 60091,
                name = "sai",
                Gender = "male",
                accounttype = "current",
                transactionstatus = "rejected"

            };
            List<customer> em = new List<customer>();
            em.Add(c);
            em.Add(c1);
            em.Add(c2);
            em.Add(c3);
            foreach (customer k in em)
            {
                Console.Write("  {0}  ", k.name);
            }
            // Console.WriteLine("Getting the first employyee data ");
//Console.WriteLine(k.id+ " || " + k.name + " || " + k.age + " || " + k.accounttype + " || " + k.transactionstatus);
            Console.ReadKey();

        }
    }
}





