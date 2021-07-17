using System;
using System.Collections.Generic;
using System.Text;

public class BoatLicense
{
    private String state;
    private int motorSizeInHP;
    private int licenceNumber;
    private double licensePrice;

    public double LicensePrice { get; set; }
    public int LicenseNumber { get; set; }
    public String State { get; set; }
    public int MotorSizeInHP { get; set; }
    public int LicenseNum { get; set; }

    public BoatLicense()
    {
        
    }

    public static void setLicensePrice(BoatLicense aLicense)
    {
       if (aLicense.MotorSizeInHP < 100)
        {
            aLicense.LicensePrice = 25;
        } 
       else
        {
            aLicense.LicensePrice = 38;
        }

    } // setLicensePrice

} // end class

