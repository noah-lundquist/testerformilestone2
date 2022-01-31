
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace CST117_IC08_console

{

    class Program

    {

        static void Main(string[] args)



        {
          //tests for structs, all of these will be imported into original program and then set equal to textboxes
            
            car sportsCar = new car();
            sportsCar.make = "Ford Mustang";
            sportsCar.year = 1965;
            sportsCar.price = 67500.0;
            sportsCar.productnum = 4589;


            parts muffler = new parts();
            muffler.name = "titanium muffler";
            muffler.productnum = 1100;
            muffler.closeout = true;

            apparel tshirt = new apparel();
            tshirt.size = "xl";
            tshirt.productnum = 7890;
            tshirt.carPurchase = true;
            tshirt.price =  0;

            service oilchange = new service();
            oilchange.laborHours = 2;
            oilchange.productnum = 4890;
            oilchange.discount = false;
            oilchange.name = "Oil change";



            //Will showup in a message box as a success message

            Console.WriteLine("Your new car added is a " +sportsCar.make+ " is year " +sportsCar.year+ " has a price of "+sportsCar.price+ " and the product number is "+sportsCar.productnum);
            Console.WriteLine("Your new part added is a " +muffler.name+  " and the product number is "+sportsCar.productnum+ " is a closeout? "+muffler.closeout);
            Console.WriteLine("Your T shirt size is " +tshirt.size+" product nummber " +tshirt.productnum+ " is it free with your car ourchase? " +tshirt.carPurchase);
            Console.WriteLine("Service being done " +oilchange.name+" labor hours " + oilchange.laborHours+ " discount? "  +oilchange.discount);




        }

    }

}

namespace CST117_IC08_console
{
    struct car
    {
        public string make;
        public int year;
        public double productnum;
        public double price;


    }
    struct parts
    {
        public string name;
        public double productnum;
        public bool closeout;
    }

    struct apparel
    {
        public double productnum;
        public string size;
        public bool carPurchase;
        public double price;

    }

    struct service
    {
        public double productnum;
        public bool discount;
        public double laborHours;
        public string name; 
    }

 


}