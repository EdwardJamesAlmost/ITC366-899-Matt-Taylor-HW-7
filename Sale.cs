using System;
using System.Collections.Generic;
using System.Text;

    public class Sale
    {
    /// <summary> Sale class properties
    /// 
    /// </summary>
    public int inventoryID { get; private set; }
    public  double saleTotal { get; private set; }
    public double saleTaxTotal { get; private set; }

    private const double taxRate = 0.08;  

    public Sale(int inventoryID, double saleTotal)
        {
            this.inventoryID = inventoryID;
            this.saleTotal = saleTotal;
            this.saleTaxTotal = saleTotal * taxRate;

        } // Sale constructor that sets properties

    } // end class
