using System;
using System.Text;


namespace ITC366_899_Matt_Taylor_HW_7_SalesTransaction
{
    public class HW7
    {
        public enum LWH
        {
            length = 1,
            width,
            height
        } // enumerator for length, width, and height

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Headers and Instructions strings
            String headerBar = new string('*', 40);
            String header = "\n  -  ITC366-899 Homework  -\nMatthew Taylor\nmatt271@live.missouristate.edu\n";
            String instructions = "Enter the number from one the following to run the corresponding exercise code: \n";
            String exerciseList = ": Exercise ";

            //Main method control variable declaration and initialization
            Boolean continueStatus = true; //initialize and set loop control boolean
            int length = 5; //sets number of exercises
            char exerciseSelection, continueChoice; //character variables to hold exercise selection


            Console.WriteLine(headerBar + header + headerBar);


            //Console.Write("Enter your name: ");
            //String enteredName = Console.ReadLine(); 

            /*
            * While loop runs as long as users choose to continue program
            * 
            * Improvement notes: implement break and continue statements
            */

            while (continueStatus == true)
            {

                ///// Write Program Instructions /////
                Console.WriteLine(instructions);


                //loop through exercises and display menu
                for (int loopIndex = 1; loopIndex <= length; loopIndex++)
                {
                    Console.WriteLine(loopIndex + exerciseList + loopIndex);

                }//end menu text for loop

                //prompt for and retrieve exercise selection
                Console.WriteLine("Enter exercise selection: ");
                exerciseSelection = (char)Console.Read();
                ClearKeys();


                switch (exerciseSelection)
                {
                    case '1':
                        Exercise1();
                        break; // end case 1

                    case '2':
                        Exercise2();
                        break;
                    case '3':
                        Exercise3();
                        break;
                    case '4':
                        Exercise4();
                        break; //end case 4

                    case '5':
                        Exercise5();
                        break; //end case 5
                    default:
                        Console.WriteLine("Invalid input.");
                        break;

                }  // switch on exerciseSelection to launch exercise methods

                ///// Continue program section /////
                Console.WriteLine("Continue (y/n)?");
                continueChoice = (char)Console.Read();
                ClearKeys();

                // conditionals to determine whether to exit while loop
                // improve with continue statement?
                if (continueChoice == 'y')
                {
                    continueStatus = true;
                    Console.WriteLine("Choose another exercise.\n");

                }//end if

                else
                {
                    continueStatus = false;
                    Console.WriteLine("Thank you for using this application.\n");
                }//end else

            }// program continuation while loop

        } // end main method

        private static void Exercise5()
        {

            int licenseQty = 3;
            const int STARTINGNUM = 201601; // as written, this value is assigned but never used
            BoatLicense[] licenses = new BoatLicense[licenseQty]; // no BoatClass license exists, pluralized array name per convention. added licenseQty variable to allow for future improvement
            int x;
            for (x = 0; x < licenses.Length; ++x)
            {
                licenses[x] = new BoatLicense(); // as written calls default constructor. 
                licenses[x].LicenseNum = x + STARTINGNUM; // will need to be changed to reference class constant, value converted to int. the pound sign output can be established in the display method.
            }

            licenses[0].State = "WI";
            licenses[1].State = "MI";
            licenses[2].State = "MN";
            licenses[0].MotorSizeInHP = 30;
            licenses[1].MotorSizeInHP = 50;
            licenses[2].MotorSizeInHP = 100;
            for (x = 0; x < licenses.Length; x++) // case error on licenses.Length, the increment on the x variable should be post eval not pre eval
            {
                BoatLicense.setLicensePrice(licenses[x]);
                DisplayBoatLicense(licenses[x]); // already a method named Display used in a previous exercise, will need to specify a different method signature

            }

            // in order to determine the price, we'll need to write a private method in the BoatLicense class that will set the price based on the motor size

            //throw new NotImplementedException();
        } // exercise 5

        private static void Exercise4()
        {
            Car myCar = new Car(32000, "red");
            Car yourCar = new Car(14000); // not sure if I should change this to match the output on the example or what
            Car theirCar = new Car(); // you don't appear to be able to just create the object, you must also instantiate it with the new keyword 
            Console.WriteLine("My {0} car cost {1}", myCar.Color, myCar.Price.ToString("c2")); //spelling error, 
            Console.WriteLine("Your {0} car cost {1}", yourCar.Color, yourCar.Price.ToString("c2")); // case error in yourcar.price
            Console.WriteLine("Their {0} car cost {1}", theirCar.Color, theirCar.Price.ToString("c2")); // case issue on price, color not set when object is instantiated. need to adjust default constructor
        

        //throw new NotImplementedException();
        } // exercise 4

        private static void Exercise3()
        {
            Sale[] sales = createSaleList();

            String ithSaleTotal, ithSalesTax;

            for (int i = 0; i < sales.Length; i++)
            {
                Sale aSale = sales[i];
                ithSaleTotal = aSale.saleTotal.ToString("C");
                ithSalesTax = aSale.saleTaxTotal.ToString("C");
                Console.Write($"Sale # {i+1}: Amount {i+1}: {ithSaleTotal}\n    Tax is {ithSalesTax}\n");

            } // loop through sales array to display values

            //throw new NotImplementedException();
        } // exercise 3


        /// <summary>  - Room Class
        /// 
        /// </summary>
        private static void Exercise2()
        {
            int roomQty = 4;
            Room[] someRooms = new Room[roomQty];
            //Room aRoom = BuildRoom();
            String aOrAn;

            for (int i = 0; i < roomQty; i++)
            {
                Console.WriteLine($"Enter dimenstions for room {i+1}");
                Room aRoom = BuildRoom();
                someRooms[i] = aRoom;

                if (aRoom.Length == 8 || aRoom.Length == 18)
                {
                    aOrAn = "an";
                } // sets correct value for a or an in the output. you could just use a(n), but I'm a pedant.
                else
                {
                    aOrAn = "a";
                }

                
                // output section
                Console.WriteLine($"For {aOrAn} {aRoom.Length} x {aRoom.Width} x {aRoom.Height} room,\n     2 walls are {aRoom.Length}' long x {aRoom.Height}' high and 2 rooms are {aRoom.Width}' long x {aRoom.Height}' high.\n Total paintable surface area =  {aRoom.WallArea} square feet, {aRoom.PaintQty} gallons of paint will be necessary for full coverage.\n");
            
            } // loop through room array, populate dimensions, 

            Console.WriteLine($"\n\n A total of { computeTotalPaint(someRooms)} gallons will be necessary to complete project.");

            //throw new NotImplementedException();
        } // exercise 2


        /// <summary>  ClearKeys method code located through research to ensure that characters are read correctly
        /// 
        /// </summary>
        public static void ClearKeys()
        {
            while (Console.In.Peek() != -1)
                Console.In.Read();
        }


        /// <summary> - Sales Transaction Class -
        /// 
        /// </summary>
        /// 
        public static void Exercise1()
        {
            SalesTransaction sale1 = new SalesTransaction("Abbott", 2000, 0.2);
            SalesTransaction sale2 = new SalesTransaction("Bender", 4000);
            SalesTransaction sale3 = new SalesTransaction("Carter");
            SalesTransaction total = sale1 + sale2 + sale3;
            Display(sale1);
            Display(sale2);
            Display(sale3);
            DisplayTotal(total);
            
        } // exercise 1 - SalesTransaction Class
        

        public static void Display(SalesTransaction aTransaction)
        {
            Console.WriteLine($"{aTransaction.salesperson} had sales totaling {aTransaction.saleTotal.ToString("C")}. Commission rate is {aTransaction.commissionRate.ToString("P")}; commission value is {aTransaction.commissionTotal.ToString("C")} ");
        } //not sure why these woudln't be declared in the SalesTransaction class

        public static void DisplayTotal(SalesTransaction aTransaction)
        {
            Console.WriteLine($"Total sales: {aTransaction.saleTotal.ToString("C")}");
        }

        private static Room BuildRoom()
        {
            LWH lwh1 = new LWH();
            int l = 0, w = 0, h = 0;

            for (int i = 1; i <= 3; i++)
            {
                lwh1 = (LWH)i;
                String entry;
                int[] dims = new int[3];

                switch (i)
                {
                    case 1:
                        Console.Write($"Enter {lwh1.ToString()} ");
                        entry = Console.ReadLine();
                        l = int.Parse(entry);
                        break;
                    case 2:
                        Console.Write($"Enter {lwh1.ToString()} ");
                        entry = Console.ReadLine();
                        w = int.Parse(entry);
                        break;
                    case 3:
                        Console.Write($"Enter {lwh1.ToString()} ");
                        entry = Console.ReadLine();
                        h = int.Parse(entry);
                        break;
                    default:
                        break;
                } // record length, width, and height based on loop index 

            } // loop through 3 dimensions
            Room aRoom = new Room(l, w, h);
            //Room aRoom = new Room(dims[0], dims[1], dims[2]);

            return aRoom;
        }  // build a room with dimensions

        private static int computeTotalPaint(Room[] someRooms)
        {
            int paintTotal = 0;

            foreach (var room in someRooms)
            {
                paintTotal += room.PaintQty;
            } //sum 

            return paintTotal;
        } // calculate total paint needed for all rooms in array

        public static Sale[] createSaleList()
        {
            int saleQty = 5;
            Sale[] sales = new Sale[saleQty];
            String inventoryIDStr, saleTotalStr;
            //Sale aSale;

            for (int i = 0; i < saleQty; i++)
            {
                
                Console.Write($"Enter inventory #{i+1} >>");
                inventoryIDStr = Console.ReadLine();

                Console.Write("Enter amount of sale >> ");
                saleTotalStr = Console.ReadLine();

                int inventoryID = int.Parse(inventoryIDStr);
                double saleTotal = double.Parse(saleTotalStr);

                Sale aSale = new Sale(inventoryID, saleTotal);

                sales[i] = aSale;

            } // populate sales array
            return sales;

        } // createSalesList

        public static void DisplayBoatLicense(BoatLicense aLicense)
        {
            Console.WriteLine($"Boat #{aLicense.LicenseNum} from {aLicense.State} has a {aLicense.MotorSizeInHP} HP motor.\n    The price for the license is {aLicense.LicensePrice.ToString("C")}");
        }

////////////////////////////////////
    } // end class HW7
////////////////////////////////////
} // end namespace


