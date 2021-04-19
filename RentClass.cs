using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasl1

{
    class RentClass
    {
        //Data member
        private int flat;
        private int house;
        private Double cost;
        private Double numberofroom;
        private Double location;

        //Accessor function

        public int theFlat
        {
            get
            {
                return this.flat;
            }
            set
            {
                this.flat = value;

            }
        }
        public int theHouse
        {
            get
            {
                return this.house;
            }
            set
            {
                this.house = value;

            }
        }
        public Double theNumberofroom
        {
            get
            {
                return this.numberofroom;
            }
            set
            {
                this.numberofroom = value;

            }
        }
        public Double theLocation
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;

            }
        }
        public Double theCost
        {
            get
            {
                return this.cost;
            }
            set
            {
                this.cost = value;

            }
        }

    }
}

class cCustomer
{
    //Member variables
    private String CustomerID;
    private String Firstname;
    private String Surname;
    private String Postcode;
    private String Address;
    private String Town;
    private String ProofofID;
    private Double Deposit;
    private Double DownPayment;

    //Accessor functions

    public String theCustomerID
    {
        get
        {
            return this.CustomerID;
        }
        set
        {
            this.CustomerID = value;
        }
    }
    public String theSurname
    {
        get
        {
            return this.Surname;
        }
        set
        {
            this.Surname = value;
        }

    }
    public String theFirstname
    {
        get
        {
            return this.Firstname;
        }
        set
        {
            this.Firstname = value;
        }
    }
    public String theAddress
    {
        get
        {
            return this.Address;
        }
        set
        {
            this.Address = value;
        }
    }
    public String thePostcode
    {
        get
        {
            return this.Postcode;
        }
        set
        {
            this.Postcode = value;
        }
    }
    public String theTown
    {
        get
        {
            return this.Town;
        }
        set
        {
            this.Town = value;
        }
    }
    public String theProveID
    {
        get
        {
            return this.ProofofID;
        }
        set
        {
            this.ProofofID = value;
        }
    }
    public Double theDeposit
    {
        get
        {
            return this.Deposit;
        }
        set
        {
            this.Deposit = value;
        }
    }
    public Double theDownPayment
    {
        get
        {
            return this.DownPayment;
        }
        set
        {
            this.DownPayment = value;
        }
    }
}

class cUtilities
{
    //Member variables
    private Double localTax;
    private Double waterBill;
    private Double electricity;

    //Access functions

    public Double theLocalTax
    {
        get
        {
            return this.localTax;
        }
        set
        {
            this.localTax = value;
        }
    }
    public Double theWaterBill
    {
        get
        {
            return this.waterBill;
        }
        set
        {
            this.waterBill = value;
        }
    }
    public Double theElectricity
    {
        get
        {
            return this.electricity;
        }
        set
        {
            this.electricity = value;
        }
    }
}

