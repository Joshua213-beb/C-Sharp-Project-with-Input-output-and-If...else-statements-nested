using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // My own Program #### BUYINZA JOSHUA
            Console.WriteLine("WELCOME TO JOSH IT SOLUTIONS ( JITS) ");

            Console.WriteLine("We need you to enter some simple questions please !!!");

            // Asking names of the user
            Console.WriteLine("1. What is your name ?");
            Console.WriteLine("Enter Name here:");
            string yourname = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + yourname + " here at JITS" );

            //asking age of the user
            Console.WriteLine("1. How old are you dia ?");
            Console.WriteLine("Enter Your Age here:");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If your Age is " + Age + " then you are eligible to access our services dia");

            //Our Services
            Console.WriteLine("HOW CAN WE HELP YOU ? ");
            Console.WriteLine("Here is the list of Our services ;");
            Console.WriteLine("1. Website Developing ");
            Console.WriteLine("2. Graphics Designing ");
            Console.WriteLine("3. Software Development");
            Console.WriteLine("4. Database Management System (DBMS)");
            Console.WriteLine("5. Just want to view all of them at once.");

            //Asking the user the services he wants to access from us :
            Console.WriteLine("Please Which service would you like to access form Us ?");
            Console.WriteLine("Enter the service here:");
            int service = Convert.ToInt32(Console.ReadLine());
            

            // if...else statement
            if (service == 1)
            {
                Console.WriteLine("WEBSITE DEVELOPMENT : ");
                Console.WriteLine("We Offer Good Services Of Websites Developing :-");
                Console.WriteLine("1. Dynamic Websites = 1,500,000 Ugx");
                Console.WriteLine("2. Static Websites = 1,000,000");
                Console.WriteLine("3. Other (If not listed Here)");


                Console.WriteLine("Enter your choice here: ");
                int web = Convert.ToInt32(Console.ReadLine());

                if (web == 1) {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");

                }
                else if (web == 2) {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
                else if (web == 3)
                {
                    Console.WriteLine("Enter it here below :");
                    string site = Console.ReadLine();
                    Console.WriteLine(site + "? Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
            }
            else if (service == 2)
            {
                Console.WriteLine("GRAPHICS DESIGNING :");
                Console.WriteLine("We offer different services of Graphics Designing :-");
                Console.WriteLine("1. Business Cards");
                Console.WriteLine("2. Certificates");
                Console.WriteLine("3. Posters");
                Console.WriteLine("4. Flyers");
                Console.WriteLine("5. Banners");
                Console.WriteLine("6. Other (If not listed Here)");

                Console.WriteLine("Enter your choice here: ");
                int graphics = Convert.ToInt32(Console.ReadLine());
                if (graphics == 1)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");

                }
                else if (graphics == 2)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                } 
                else if (graphics == 3)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
                else if (graphics == 4)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
                else if (graphics == 5)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
                else if (graphics == 6)
                {
                    Console.WriteLine("Enter it here below :");
                    string graph = Console.ReadLine();
                    Console.WriteLine(graph + "? Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
            }
            else if (service == 3)
            {
                Console.WriteLine("SOFTWARE DEVELOPMENT :");
                Console.WriteLine("We develope Different types of softwares :-");
                Console.WriteLine("1. Inventory Management systems");
                Console.WriteLine("2. Banking Management systems ");
                Console.WriteLine("3. School Management systems ");
                Console.WriteLine("4. Any Program Of your Choice ");
                Console.WriteLine("5. Other (If not listed Here)");

                Console.WriteLine("Enter your choice here: ");
                int software = Convert.ToInt32(Console.ReadLine());

                if (software == 1)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");

                }
                else if (software == 2)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
                else if (software == 3)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
                else if (software == 4)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
              
                else if (software == 5)
                {
                    Console.WriteLine("Enter it here below :");
                    string soft = Console.ReadLine();
                    Console.WriteLine(soft +"? Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
            }
            else if (service == 4)
            {
                Console.WriteLine("DATABASE MANAGEMENT SYSTEMS :");
                Console.WriteLine("We use different types of database ;-");
                Console.WriteLine("1. Mongo DB");
                Console.WriteLine("2. MySQL DB");
                Console.WriteLine("3. SQL");
                Console.WriteLine("4. Other (If not listed Here)");

                Console.WriteLine("Enter your choice here: ");
                int dbms = Convert.ToInt32(Console.ReadLine());

                if (dbms == 1)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");

                }
              
                else if (dbms == 2)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }
                else if (dbms == 3)
                {
                    Console.WriteLine("Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }


                else if (dbms == 4)
                {
                    Console.WriteLine("Enter it here below :");
                    string data = Console.ReadLine();
                    Console.WriteLine(data + "? Thank you for your choice we shall contact you");
                    Console.WriteLine("press any key to exit!!");
                }

            }
            else if (service == 5)
            {
                Console.WriteLine("VIEW ALL AT ONCE :");

                Console.WriteLine("WEBSITE DEVELOPMENT : ");
                Console.WriteLine("We Offer Good Services Of Websites Developing :-");
                Console.WriteLine("1. Dynamic Websites = 1,500,000 Ugx");
                Console.WriteLine("2. Static Websites = 1,000,000");

                Console.WriteLine("GRAPHICS DESIGNING :");
                Console.WriteLine("We offer different services of Graphics Designing :-");
                Console.WriteLine("1. Business Cards");
                Console.WriteLine("2. Certificates");
                Console.WriteLine("3. Posters");
                Console.WriteLine("4. Flyers");
                Console.WriteLine("5. Banners");
                Console.WriteLine("6. Other (If not listed Here)");

                Console.WriteLine("SOFTWARE DEVELOPMENT :");
                Console.WriteLine("We develope Different types of softwares :-");
                Console.WriteLine("1. Inventory Management systems");
                Console.WriteLine("2. Banking Management systems ");
                Console.WriteLine("3. School Management systems ");
                Console.WriteLine("4. Any Program Of your Choice ");
                Console.WriteLine("5. Other (If not listed Here)");

                Console.WriteLine("DATABASE MANAGEMENT SYSTEMS :");
                Console.WriteLine("We use different types of database ;-");
                Console.WriteLine("1. Mongo DB");
                Console.WriteLine("2. MySQL DB");
                Console.WriteLine("3. SQL");

                Console.WriteLine("Thank you for viewing .");
                Console.WriteLine("Press any key to exit");
            }


            Console.ReadLine();

        }
    }
}
