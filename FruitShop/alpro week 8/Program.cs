using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Program
{
    public static void MyMethod(int[]price)
    {
        Console.WriteLine("GRAND TOTAL: $" + (price[0] + price[1] + price[2] + price[3] + price[4] + price[5]));
    }
    public static void Main()
    {
        int abc = 0; 
        int menu = 0; 
        string items = "fruit"; 
        string buymore = "y";
        int i = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int[] qua = new int[6];
        string[] item = new string[6] { "Apple ", "Orange", "Lychee", "Banana", "Durian", "Lemon "};
        int[] price = new int[6];
        string[] itemedit = new string[6];
        

        while (abc >= 0)
        {
            Console.WriteLine("WELCOME TO THE FRUIT MART\n");
            Console.WriteLine("What can I help you?");
            Console.WriteLine(" [1] Buy\n [2] View Cart\n [3] Edit Cart\n [4] Checkout");
            Console.Write("Choose: ");
            menu = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (menu)
            {
                case 1:
                    {
                        buymore = "y";
                        Console.WriteLine("|------------------------------|");
                        Console.WriteLine("|          ITEM LIST           |");
                        Console.WriteLine("|------------------------------|");
                        Console.WriteLine("| ID  |   Item     |   Price   |");
                        Console.WriteLine("|------------------------------|");
                        Console.WriteLine("|  1  |  Apple     |    $1     |");
                        Console.WriteLine("|  2  |  Orange    |    $2     |");
                        Console.WriteLine("|  3  |  Lychee    |    $6     |");
                        Console.WriteLine("|  4  |  Banana    |    $5     |");
                        Console.WriteLine("|  5  |  Durian    |    $12    |");
                        Console.WriteLine("|  6  |  Lemon     |    $3     |");
                        Console.WriteLine("|------------------------------|");

                        while (buymore == "y")
                        {
                            Console.Write("Enter Item ID: ");
                            int ID = Convert.ToInt32(Console.ReadLine());
                            while (ID <= 0 || ID > 6)
                            {
                                Console.WriteLine("Invalid Item.");
                                Console.Write("Enter Item ID: ");
                                ID = Convert.ToInt32(Console.ReadLine());
                                
                            }

                            Console.Write("Enter Quantity: ");
                            int Qtt = Convert.ToInt32(Console.ReadLine());
                            

                            if (ID == 1)
                            {
                                qua[0] = qua[0] + Qtt;
                                items = "Apple ";
                                item[0] = "Apple ";
                                c=qua[0];
                                itemedit[b]= "Apple ";
                                price[0] = 1 * qua[0];
                                Console.WriteLine();
                                Console.WriteLine("Bought " + qua[0] + " pcs of " + items);
                                b++;

                            }
                            if (ID == 2)
                            {
                                qua[1] = qua[1] + Qtt;
                                items = "Orange";
                                item[1] = "Orange";
                                itemedit[b] = "Orange";
                                c = qua[1];
                                price[1] = 2 * qua[1];
                                Console.WriteLine();
                                Console.WriteLine("Bought " + qua[1] + " pcs of " + items);
                                b++;
                            }
                            if (ID == 3)
                            {
                                qua[2] = qua[2] + Qtt;
                                items = "Lychee";
                                item[2] = "Lychee";
                                itemedit[b] = "Lychee";
                                c = qua[2];
                                price[2] = 6*qua[2];
                                Console.WriteLine();
                                Console.WriteLine("Bought " + qua[2] + " pcs of " + items);
                                b++;
                                
                            }
                            if (ID == 4)
                            {
                                items = "Banana";
                                item[3] = "Banana";
                                qua[3] = qua[3] + Qtt;
                                c = qua[3];
                                itemedit[b] = "Banana";
                                price[3] = 5*qua[3];
                                Console.WriteLine();
                                Console.WriteLine("Bought " + qua[3] + " pcs of " + items);
                                b++;
                            }
                            if (ID == 5)
                            {
                                items = "Durian";
                                item[4] = "Durian";
                                qua[4] = qua[4] + Qtt;
                                c = qua[4];
                                itemedit[b] = "Durian";
                                price[4] = 12 * qua[4];
                                Console.WriteLine();
                                Console.WriteLine("Bought " + qua[4] + " pcs of " + items);
                                b++;
                            }
                            if (ID == 6)
                            {
                                items = "Lemon ";
                                item[5] = "Lemon ";
                                itemedit[b] = "Lemon ";
                                qua[5] = qua[5] + Qtt;
                                c = qua[5];
                                price[5] = 3*qua[5];
                                Console.WriteLine();
                                Console.WriteLine("Bought " + qua[5] + " pcs of " + items);
                                b++;
                            }

                            i++;
                            Console.WriteLine("Buy more item? (y/n)");
                            buymore = Console.ReadLine();
                            
                        }
                        abc = 1;
                        a--;

                    Console.Clear();
                    break;

                       
                    }
                    case 2:
                    Console.WriteLine("CART");
                    if (abc <= 0)
                    {
                        Console.WriteLine("Cart is empty.\n");
                    }
                    i = 0;
                    for (int j=0; j < 6; j++)
                    {

                        if (qua[j] != 0)
                        {
                            i++;
                            Console.WriteLine("[" + (i) + "] " + qua[j] + " " + item[j]);

                        }
                        
                    }
                    Console.ReadKey();
                    Console.Clear();

                    break;

                    case 3:
                        Console.WriteLine("EDIT CART \n");
                    if (abc <= 0)
                    {
                        Console.WriteLine("Cart is empty.\n");
                        Console.ReadKey();
                    }
                    else
                    {
                        i = 0;
                        for (int j = 0; j < 6; j++)
                        {
                            
                            if (qua[j] != 0)
                            {
                                i++;
                                Console.WriteLine("[" + (i) + "] " + qua[j] + " " + item[j]);
                            }
                        }
                        Console.WriteLine("Which item you want to edit?");
                        int edit = Convert.ToInt32(Console.ReadLine());
                        

                        for (int k = 0; k < 6; k++)
                        {

                            while (edit > i)
                            {
                                Console.WriteLine("Invalid Item.");
                                Console.WriteLine("Which item you want to edit?");
                                edit = Convert.ToInt32(Console.ReadLine());
                                
                            }

                            if (edit == k+1)
                            {
                                Console.WriteLine("Enter New Quantity of " + itemedit[edit-1]);
                                c = Convert.ToInt16(Console.ReadLine());
                                if (c != 0)
                                {
                                    Console.WriteLine("Update: bought " + c + " pcs of " + itemedit[edit-1]);
                                    if (itemedit[edit-1]== "Apple ")
                                    {
                                        qua[0] = c;
                                        price[0] = 1*qua[0];
                                    }
                                    if (itemedit[edit-1] == "Orange")
                                    {
                                        qua[1] = c;
                                        price[1] = 2 * qua[1];
                                    }
                                    if (itemedit[edit - 1] == "Lychee")
                                    {
                                        qua[2] = c;
                                        price[2] = 6 * qua[2];
                                    }
                                    if (itemedit[edit - 1] == "Banana")
                                    {
                                        qua[3] = c;
                                        price[3] = 5 * qua[3];
                                    }
                                    if (itemedit[edit - 1] == "Durian")
                                    {
                                        qua[4] = c;
                                        price[4] = 12 * qua[4];
                                    }
                                    if (itemedit[edit - 1] == "Lemon ")
                                    {
                                        qua[5] = c;
                                        price[5] = 3 * qua[5];
                                    }
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Update: deleted " + itemedit[edit-1] + " from cart.");
                                    c = 0;
                                    if (itemedit[edit - 1] == "Apple ")
                                    {
                                        qua[0] = c;
                                        price[0] = 1 * qua[0];
                                    }
                                    if (itemedit[edit - 1] == "Orange")
                                    {
                                        qua[1] = c;
                                        price[1] = 2 * qua[1];
                                    }
                                    if (itemedit[edit - 1] == "Lychee")
                                    {
                                        qua[2] = c;
                                        price[2] = 6 * qua[2];
                                    }
                                    if (itemedit[edit - 1] == "Banana")
                                    {
                                        qua[3] = c;
                                        price[3] = 5 * qua[3];
                                    }
                                    if (itemedit[edit - 1] == "Durian")
                                    {
                                        qua[4] = c;
                                        price[4] = 12 * qua[4];
                                    }
                                    if (itemedit[edit - 1] == "Lemon ")
                                    {
                                        qua[5] = c;
                                        price[5] = 3 * qua[5];
                                    }
                                    Console.ReadKey();
                                }

                            }
                        }    

                    }
                        Console.Clear();
                    break;

                    case 4:
                    Console.WriteLine("RECEIPT");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("No.   Qty    Item     Total");
                    i = 0;
                    for (int j = 0; j < 6; j++)
                    {
                        if (qua[j] != 0)
                        {
                            i++;
                            Console.WriteLine((i) + ".     " + qua[j] + "     " + item[j] + "    $" + price[j]);
                        }

                    }
                    Console.WriteLine();
                    MyMethod(price);

                    abc = -1;
                    break;

                    default:
                    Console.WriteLine("Invalid Menu");
                    Console.ReadKey();
                    Console.Clear();
                    break;  
            }

        }
    }
}
