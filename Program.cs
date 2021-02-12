using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project1._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductType x = new ProductType("Cameras");
            ResolutionInfo y = new ResolutionInfo(1, "Resolution of camera");

            ProductType z = new ProductType("Photoprinter");
            ResolutionInfo m = new ResolutionInfo(1, "Resolution of photoprinter");
            ProductType p = new ProductType("Wifi-Devices");

            List<ProductBase> ProductList = new List<ProductBase>()
            {

                new Camera("Canon PowerShot SX430 IS Camera",16499,x ,323,1,"Brand:Canon,Model Number:SX430 IS,Series: PowerShot,Brand Color:Black,Effective Pixels:20 MP",500,"45x", y),
                new Camera("Sony CyberShot DSC-W800/BC IN5 Camera",7790,x ,125,2,"Brand:Sony,Model Number:DSC-W800/BC IN5,Series: CyberShot,Brand Color:Black,Effective Pixels:20.1 MP",200,"13x", y),
                new Camera("Nikon Coolpix P950 Camera",59999,x ,1500,0,"Brand:Nikon,Model Number:P950,Series: Coolpix,Brand Color:Black,Effective Pixels:16 MP",800,"83x", y),


                new  PhotoPrinter("Canon PIXMA E470 Multi-function WiFi Color Printer",5525,z,600,1,"Printing Method:Inkjet,Type:Multi-function,Model Name:PIXMA E470,Printing Output:Color,Functions:Print, Copy, Scan,Brand:Canon,Refill Type:Ink Cartridge","Color",14,"Colour Cartridge:CL57,CL57S,Black cartridge:PG 47",m ),
                new  PhotoPrinter("Epson L3100 Multi-function Color Printer",11699,z,3900,5,"Printing Method:Inkjet,Type:Multi-function,Model Name:L3100,Printing Output:Color,Functions:Print, Copy, Scan,Brand:Epson,Refill Type:Ink Bottle","Color",16,"4,500 Pages Black Ink Bottle, 7,500 (Composite Yield) Cyan Ink Bottle, 7,500 (Composite Yield) Magenta Ink Bottle, 7,500 (Composite Yield) Yellow Ink Bottle",m ),
                new  PhotoPrinter("HP DeskJet 2331 Multi-function Color Printer",3299,z,3240,6,"Printing Method:Inkjet,Type:Multi-function,Model Name:DeskJet 2331,Printing Output:Color,Functions:Print, Copy, Scan,Brand:HP,Refill Type:Ink Cartridge","Color",10,"HP 805 Tri-color Original Ink Cartridge,HP 805 Small Black Cartridge",m ),

                new Router("TP-Link TL-WR845N Wireless N 300 mbps Router",1199,p,400,7,"Type:Wireless Without Modem,Model:TL-WR845N Wireless N,Part Number:1750502328,Controls:Buttons: Reset, Wi-Fi / WPS, Power On / Off,Color: White,Brand:TP-Link","2.4Ghz","IEEE 802.11n, IEEE 802.11g, IEEE 802.11b",4,"Parental Control, Local Management Control, Host List, Access Schedule, Rule Management","Black"),
                new Router("TENDA F3 Wireless Router 300 Mbps Router",1099,p,450,3,"Type:Wireless Without Modem,Model:F3 Wireless Router,Color: White,Brand:TENDA","2.4Ghz","IEEE802.11/b/g/n",3,"Parental Control, Local Management Control, Host List, Access Schedule, Rule Management","Black"),
                new Router("D-Link DIR-819 750 Mbps Router",1589,p,500,1,"Type:Wireless Without Modem,Model:DIR-819,Controls:WPS Button, Power Switch,Color: Black,Brand:D-Link","2.4Ghz","IEEE 802.11ac, IEEE 802.11n, IEEE 802.11g, IEEE 802.11b, IEEE 802.11a, IEEE 802.3u",4,"Parental Control, Local Management Control, Host List, Access Schedule, Rule Management","Black"),


            };


            List<ProductBase> MyCart = new List<ProductBase>();



            MainMenu(ProductList, MyCart);




        }

        
        
        private static void OperationKeys()
        {
            Console.WriteLine("Press “A” button - To view Catalog ");
            Console.WriteLine("Press “Q” button – order by price ascending");
            Console.WriteLine("Press “W” button – order by price descending");
            Console.WriteLine("Press “E” button – order by type ascending");
            Console.WriteLine("Press “R” button – order by type descending");
            Console.WriteLine("Press “Y” button – order by product name ascending");
            Console.WriteLine("Press “U” button – order by product name descending");
            Console.WriteLine("Press “K” button - add product to cart");
            Console.WriteLine("Press “C” button – view cart with total sum and weight");

        }

        private static void ViewCart(List<ProductBase> ProductList,List<ProductBase> MyCart)
        {
            Console.WriteLine("\n************************************************************************************************************************\n");
            Console.WriteLine("You have these Products in your Cart!\n");

            if (MyCart.Count == 0)
                Console.WriteLine("------------------ EMPTY CART------------------ ");

            for (int i = 0; i < MyCart.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + MyCart[i].GetName() +" "+ "Price:"+" "+ MyCart[i].GetPrice());
            }

            float TotalPrice = 0;
            foreach (var i in MyCart)
            {
                TotalPrice += i.GetPrice();

            }

            float TotalWeight = 0;

            foreach (var i in MyCart)
            {
                TotalWeight += i.GetWeight();

            }

            Console.WriteLine("Total Amount of Money to Pay:\n" + TotalPrice + " "+ "Rubles");
            Console.WriteLine("Total Weight of Products:\n" + TotalWeight +" "+"grams");

            
            Console.WriteLine("Do you want to add more products to Cart?");

            Console.WriteLine("Press any alphabet to add product to your cart or Press any number to return to Main Menu");

            MainMenuPart3(ProductList, MyCart);
        }

        private static void DisplayProducts(List<ProductBase>ProductList)
        {
            Console.WriteLine("\n************************************************************************************************************************\n");
            Console.WriteLine("Welcome To Catalog! We have the following products for you!\n");


            int Index = 1;

            foreach (var i in ProductList)
            {
                Console.WriteLine(Index.ToString() + ".");
                i.DisplayToConsole();
                Index++;
            }

            Console.WriteLine("Press the Index Number of Product to see the Technical details of the Product");

            int ProductChosen = int.Parse(Console.ReadLine())-1;

            

            if (ProductList[ProductChosen] is Camera)
            {
                var product = new Camera();
                product = (Camera)ProductList[ProductChosen];
                Console.WriteLine("Name:" + product.GetName() + "\n");
                Console.WriteLine("Technical Details:\n");
                product.DisplayToConsole();
                Console.WriteLine("\n");
            }
            else if (ProductList[ProductChosen] is Router)
            {
                var product = new Router();
                product = (Router)ProductList[ProductChosen];
                Console.WriteLine("Name:" + product.GetName() + "\n");
                Console.WriteLine("Technical Details:\n");
                product.DisplayToConsole();
                Console.WriteLine("\n");
            }
            else if (ProductList[ProductChosen] is PhotoPrinter)
            {
                var product = new PhotoPrinter();
                product = (PhotoPrinter)ProductList[ProductChosen];
                Console.WriteLine("Name:"+product.GetName() + "\n");
                Console.WriteLine("Technical Details:\n");
                product.DisplayToConsole();
                Console.WriteLine("\n");

            }



        }

        //Order catalog by Price in Ascending order (OPAsc);
        private static void ProductbyLowPrice(List<ProductBase> ProductList)
        {

            var orderByResult2 = from s in ProductList
                                 orderby s.GetPrice() //Sorts the ProductList collection in ascending order
                                 select s;

           
            Console.WriteLine("\n************************************************************************************************************************\n");
            Console.WriteLine("Products according to Price in ascending order\n");
            Console.WriteLine("Ascending Order:\n");

            foreach (var std in orderByResult2)
            {
                Console.WriteLine("Name: {0}, Price: {1}", std.GetName(), std.GetPrice());

                Console.WriteLine("*************************************************************************");
            }
        }

        //Order catalog by Price in Descending order(OPDesc);
        private static void ProductbyHighPrice(List<ProductBase>ProductList)
        {
            var orderByDescendingResult2 = from s in ProductList //Sorts the studentList collection in descending order
                                           orderby s.GetPrice() descending
                                           select s;
            Console.WriteLine("\n************************************************************************************************************************\n");
            Console.WriteLine("Products according to Price in descending order\n");
            Console.WriteLine("Descending Order:\n");

            foreach (var std in orderByDescendingResult2)
            {
                Console.WriteLine("Name: {0}, Price: {1}", std.GetName(), std.GetPrice());

                Console.WriteLine("*************************************************************************");
            }


        }

        //Order catalog by Product Type Name in Ascending order(OTAsc);
        private static void ProductbyLowType(List<ProductBase>ProductList)
        {

            var orderByResult3 = from s in ProductList
                                 orderby s.GetType() //Sorts the ProductList collection in ascending order
                                 select s;
            Console.WriteLine("\n************************************************************************************************************************\n");
            Console.WriteLine("Products according to Type in ascending order\n");
            Console.WriteLine("Ascending Order:\n");

            Console.WriteLine("Ascending Order:\n");

            foreach (var std in orderByResult3)
                Console.WriteLine("Name: {0}, Product Type: {1}", std.GetName(), std.GetType());

            Console.WriteLine("*************************************************************************");


        }

        //Order catalog by Product Type Name in Descending order(OTDesc);
        private static void ProductbyHighType(List<ProductBase>ProductList)
        {
            var orderByDescendingResult3 = from s in ProductList //Sorts the ProductList collection in descending order
                                           orderby s.GetType() descending
                                           select s;
            Console.WriteLine("\n************************************************************************************************************************\n");
            Console.WriteLine("Products according to Type in descending order\n");


            Console.WriteLine("Descending Order:\n");

            foreach (var std in orderByDescendingResult3)
                Console.WriteLine("Name: {0}, Product Type: {1}", std.GetName(), std.GetType());

            Console.WriteLine("*************************************************************************");


        }

        //Order catalog by Name in Ascending Order (ONAsc)
        private static void ProductbyLowName(List<ProductBase>ProductList)
        {
            

            var orderByResult = from s in ProductList
                                orderby s.GetName() //Sorts the ProductList collection in ascending order
                                select s;

            Console.WriteLine("\n************************************************************************************************************************\n");
            Console.WriteLine("Products according to Name in Ascending order\n");


            Console.WriteLine("Ascending Order:\n");

            foreach (var std in orderByResult)
                Console.WriteLine(std.GetName());

            Console.WriteLine("*************************************************************************");

        }

        //Order catalog by Name in Descending Order(ONDesc)
        private static void ProductbyHighName(List<ProductBase>ProductList)
        {

            var orderByDescendingResult = from s in ProductList //Sorts the ProductList collection in descending order
                                          orderby s.GetName() descending
                                          select s;

            Console.WriteLine("\n************************************************************************************************************************\n");
            Console.WriteLine("Products according to Name in Dscending order\n");


            Console.WriteLine("Descending Order:\n");
            foreach (var std in orderByDescendingResult)
                Console.WriteLine(std.GetName());

            Console.WriteLine("*************************************************************************");

        }

        private static void AddingtoCart(List<ProductBase> ProductList,List<ProductBase>MyCart)
        {
            AddtoCartPart2(ProductList, MyCart);

            Console.WriteLine("Do you want to add more products to Cart?");

            Console.WriteLine("Press any alphabet to add product to your cart or Press any number to return to Main Menu");

            MainMenuPart3(ProductList, MyCart);
        }

        private static void MainMenu(List<ProductBase>ProductList,List<ProductBase>MyCart)
        {
            string ss = "Welcome to Sinsay Shopping \n";
            Console.SetCursorPosition((Console.WindowWidth - ss.Length) / 2, Console.CursorTop);
            Console.WriteLine(ss);

            OperationKeys();

            var c = Console.ReadKey();

            switch (c.KeyChar)
            {
                case 'A':
                    DisplayProducts(ProductList);
                    Console.WriteLine("Press any number to go back to Main Menu");
                    MainMenuPart3(ProductList,MyCart);
                    break;
                case 'Q':

                    ProductbyLowPrice(ProductList);
                    Console.WriteLine("Press any number to go back to Main Menu");
                    MainMenuPart3(ProductList, MyCart);
                    break;

                case 'W':
                    ProductbyHighPrice(ProductList);
                    Console.WriteLine("Press any number to go back to Main Menu");
                    MainMenuPart3(ProductList, MyCart);

                    break;

                case 'E':

                    ProductbyLowType(ProductList);
                    Console.WriteLine("Press any number to go back to Main Menu");
                    MainMenuPart3(ProductList, MyCart);

                    break;


                case 'R':

                    ProductbyHighType(ProductList);
                    Console.WriteLine("Press any number to go back to Main Menu");
                    MainMenuPart3(ProductList, MyCart);

                    break;

                case 'Y':

                    ProductbyLowName(ProductList);
                    Console.WriteLine("Press any number to go back to Main Menu");
                    MainMenuPart3(ProductList, MyCart);

                    break;

                case 'U':

                    ProductbyHighName(ProductList);
                    Console.WriteLine("Press any number to go back to Main Menu");
                    MainMenuPart3(ProductList, MyCart);

                    break;


                case 'K':

                    AddingtoCart(ProductList, MyCart);



                    break;

                case 'C':

                    ViewCart(ProductList,MyCart);

                    break;
                default:

                    Console.WriteLine("Wrong Input! Please any key to back to Main Menu");
                    

                    break;

            }

            Console.ReadLine();

        }

        private static void AddtoCartPart2 (List<ProductBase>ProductList,List<ProductBase>MyCart)
        {

            Console.WriteLine("\n************************************************************************************************************************\n");
            Console.WriteLine("Add Products to your shopping cart by index number from 1 to 12!\n");


            for (int i = 0; i < ProductList.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + ProductList[i].GetName());
            }

            int ProductChosen = int.Parse(Console.ReadLine())-1;

            if (ProductList[ProductChosen].GetQuantity() == 0)
            {

                Console.WriteLine("Product Out of Stock! Please choose another Product");
                AddtoCartPart2(ProductList, MyCart);
            }

            else
            {
                MyCart.Add(ProductList[ProductChosen]);
                ProductList[ProductChosen].QuantityInStock--;



                Console.WriteLine("UpdatedStock:" + ProductList[ProductChosen].QuantityInStock);

                Console.WriteLine("Product Added to Cart!");

                Console.WriteLine("Press any number to back to Main Menu");

                var command = Convert.ToInt32(Console.ReadLine());

                MainMenu(ProductList, MyCart);
            }


        }

        private static void MainMenuPart3(List<ProductBase>ProductList,List<ProductBase>MyCart)
        {

            int Bowl; // Variable to hold number

            var UserInput = Console.ReadKey(); // get user input

            if (char.IsDigit(UserInput.KeyChar))
            {
                Bowl = int.Parse(UserInput.KeyChar.ToString());

                MainMenu(ProductList, MyCart);
            }
            else
            {
                AddingtoCart(ProductList, MyCart);


            }



        }



    }
}
