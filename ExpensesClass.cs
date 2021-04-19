using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ExpensesClass
    {
        //Member variables
        private Double groceries;
        private Double water;
        private Double electricity;
        private Double transport;
        private Double phone;
        private Double entertainment;
        private Double clothing;
        private Double investments;
        private Double tax;
        private Double grossincome;
        private int moneyleft;
        private Double total;

        //Access function

        public Double theTax
        {
            get
            {
                return this.tax;
            }
            set
            {
                this.tax = value;
            }
        }
        public Double theWater
        {
            get
            {
                return this.water;
            }
            set
            {
                this.water = value;
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
        public Double thePhone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }
        public Double theClothing
        {
            get
            {
                return this.clothing;
            }
            set
            {
                this.clothing = value;
            }
        }
        public Double theInvestment
        {
            get
            {
                return this.investments;
            }
            set
            {
                this.investments = value;
            }
        }
        public Double theEntertainment
        {
            get
            {
                return this.entertainment;
            }
            set
            {
                this.entertainment = value;
            }
        }
        public Double theTransport
        {
            get
            {
                return this.transport;
            }
            set
            {
                this.transport = value;
            }
        }
        public Double theGroceries
        {
            get
            {
                return this.groceries;
            }
            set
            {
                this.groceries = value;
            }
        }
        public Double theGrossIncome
        {
            get
            {
                return this.grossincome;
            }
            set
            {
                this.grossincome = value;
            }
        }
        public int theMoneyLeft
        {
            get
            {
                return this.moneyleft;
            }
            set
            {
                this.moneyleft = value;
            }
        }
        public Double theTotal
        {
            get
            {
                return this.total;
            }

        }
    }
}

