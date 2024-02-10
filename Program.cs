using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace restorentproc1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Welcome to my restorent");
                Console.WriteLine("1. Dosa");
                Console.WriteLine("2. Idli");
                Console.WriteLine("3. PavBhaji");
                Console.WriteLine("4. Puri");
                Console.WriteLine("5. bada");
                Console.WriteLine(" \n");

                string[] s = { "dosa", "idli", "pavbhaji", "puri", "bada" };
                ArrayList a1 = new ArrayList();
                char ch;
                do
                {
                    Console.Write("Enter your choice : ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    a1.Add(s[a - 1]);

                    Console.Write("Do you want to continue (y/n) : ");
                    ch = Convert.ToChar(Console.ReadLine());
                } while (ch == 'y');
                Console.WriteLine(" \n");
                Console.Write("Your Order is : ");
                foreach (string s1 in a1)
                {
                    Console.Write(s1 + " ");
                }
                Console.WriteLine(" \n");
                Console.WriteLine("\n Edit order");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Modify Item");
                Console.WriteLine("3. Confirm order");
                Console.WriteLine(" \n");
                int ch1;
                do
                {
                    Console.Write("choose edit option : ");
                    ch1 = Convert.ToInt32(Console.ReadLine());

                    if (ch1 == 1)
                    {
                        Console.Write("Enter item number to add : ");
                        int item = Convert.ToInt32(Console.ReadLine());
                        a1.Add(s[item - 1]);
                        Console.WriteLine("item added successfully");
                        Console.WriteLine(" \n");
                    }
                    else if (ch1 == 2)
                    {
                        Console.Write("Enter item name to modify : ");
                        string item1 = Console.ReadLine();
                        int index = a1.IndexOf(item1);
                        Console.Write("Enter new item name : ");
                        string nitem = Console.ReadLine();
                        a1[index] = nitem;
                        Console.WriteLine("Item modify successfully");
                        Console.WriteLine(" \n");

                    }
                } while (ch1 == 1 || ch1 == 2);
                Console.WriteLine(" \n");
                Console.Write("Your new item : ");
                foreach (string s1 in a1)
                {
                    Console.Write(s1 + " ");
                }
                Console.WriteLine(" \n");
                Dictionary<string, double> dic = new Dictionary<string, double>();
                dic["dosa"] = 60.00;
                dic["idli"] = 70.00;
                dic["pavbhaji"] = 80;
                dic["puri"] = 65;
                dic["bada"] = 50;
                double bill = 0;


                Dictionary<int, bill> dic2 = new Dictionary<int, bill>();

                int sno = 0;
                foreach (string s2 in a1)
                {
                    bill b1 = new bill();
                    Console.WriteLine("\ncost of " + s2 + " is " + dic[s2]);

                    Console.Write("Enter Quantity of  " + s2 + " : ");
                    int Quantity = Convert.ToInt32(Console.ReadLine());
                    bill = bill + (dic[s2] * Quantity);

                    sno++;
                    b1.cost = dic[s2];
                    b1.item = s2;
                    b1.Quantity = Quantity;
                    b1.Bill = bill;
                    dic2.Add(sno, b1);


                }
           
            Console.WriteLine(" \n");
            double sum = 0;
            Console.WriteLine("sno" + "\t" + "Cost" + "\t" + "Item" + "\t" + "Quantity" + "   " + "Bill");
            foreach(int b2 in dic2.Keys)
            {

                Console.WriteLine(b2 + "\t" + dic2[b2].cost + "    " + dic2[b2].item + "\t  " + dic2[b2].Quantity + "\t   " + dic2[b2].Bill);
                sum = sum + dic2[b2].Bill;

            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("   Total Bill is : " + "\t\t  " + sum);
            Console.WriteLine("----------------------------------------------------------");
            }
            catch (Exception e1)
            {
                Console.Write("please follow instraction carefully");
                
            }







            Console.ReadLine();
        }
    }
}
