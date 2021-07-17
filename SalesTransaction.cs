using System;
using System.Text;


public class SalesTransaction
    {
        /**SalesTransaction Fields
         */

        public readonly double commissionRate;
        public String salesperson;
        public double saleTotal;
        public double commissionTotal;

        /**SalesTransaction Class Constructors
         */
        
        public SalesTransaction(String aSalesperson, double saleTotal, double commissionRate)
        {
            this.salesperson = aSalesperson;
            this.saleTotal = saleTotal;
            this.commissionRate = commissionRate;

            double commissionTotal = this.saleTotal * this.commissionRate;
            
            //Console.WriteLine($"{salesperson} had sales totaling {saleTotal.ToString("C")}. Commission rate is {commissionRate.ToString("P")}; commission value is {commissionTotal.ToString("C")} ");
        } // sets all fields and calculates commission
        

        public SalesTransaction(String aSalesperson, double saleTotal)
        {
            this.salesperson = aSalesperson;
            this.saleTotal = saleTotal;
            this.commissionRate = 0;
        } // 

        public SalesTransaction(String aSalesperson)
        {
            this.salesperson = aSalesperson;
            this.saleTotal = 0;
            this.commissionRate = 0;
        } //

        /*
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

        }
        */

    public static SalesTransaction operator+(SalesTransaction sale1, SalesTransaction sale2)
    {
        double saleTotal = sale1.saleTotal + sale2.saleTotal;
        double commissionTotal = sale1.commissionTotal + sale2.commissionTotal;

        return (new SalesTransaction(null,saleTotal,0));
    }


        


    } // end class
