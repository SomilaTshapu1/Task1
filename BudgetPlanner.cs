using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasl1;


//Reference: https://www.youtube.com/watch?v=MZ19bsOAYWA&t=637s 
//Reference: https://www.youtube.com/watch?v=0c5P7K65f6s 
namespace Task1
{
    public partial class BudgetPlanner : Form
    {
        //Declaring variables
        double moneyLeft;
        int numberOfYears;
        String iMoneyleft;
        double InterestRate, monthlyInteresetRate, loanAmount, MonthlyPayment, TotalPayment, Deposi, Gross;
        String iMonthlyPayment, iTotalPayment;
        public BudgetPlanner()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            cCustomer iCustomer = new cCustomer();
            RentClass iRent = new RentClass();
            cUtilities iUtilities = new cUtilities();
         
            ExpensesClass expenses = new ExpensesClass();

            //Linking methods created in expenses class with textboxes
            expenses.theClothing = Double.Parse(txtClothing.Text);
            expenses.theElectricity = Double.Parse(txtElectricity.Text);
            expenses.theEntertainment = Double.Parse(txtEntertainment.Text);
            expenses.theGroceries = Double.Parse(txtGroceries.Text);
            expenses.theInvestment = Double.Parse(txtInvestments.Text);
            expenses.thePhone = Double.Parse(txtPhone.Text);
            expenses.theTransport = Double.Parse(txtTTransport.Text);
            expenses.theWater = Double.Parse(txtWater.Text);
            expenses.theTax = Double.Parse(txtTax.Text);
            expenses.theGrossIncome = Double.Parse(txtGross.Text);
           

           
            //Calculations
            String t = String.Format("{0:C}", expenses.theClothing + expenses.theElectricity +
                expenses.theEntertainment + expenses.theGroceries + expenses.theInvestment + expenses.thePhone +
                expenses.theTax + expenses.theTransport + expenses.theWater);
            txtTotal.Text = t;

           



            //the software will printout this as a reciept
            rptExpenses.AppendText("\t\tMY EXPENSES" + "\n" + "---------------------------------------------" + "\n");
            rptExpenses.AppendText("Clothing" + "\t\t\t" + txtClothing.Text + "\n");
            rptExpenses.AppendText("Electricity" + "\t\t\t" + txtElectricity.Text + "\n");
            rptExpenses.AppendText("Entertainement" + "\t\t" + txtEntertainment.Text + "\n");
            rptExpenses.AppendText("Groceries" + "\t\t\t" + txtGroceries.Text + "\n");
            rptExpenses.AppendText("Transport " + "\t\t" + txtTTransport.Text + "\n");
            rptExpenses.AppendText("Investments" + "\t\t" + txtInvestments.Text + "\n");
            rptExpenses.AppendText("Phone" + "\t\t\t" + txtPhone.Text + "\n");
            rptExpenses.AppendText("Water" + "\t\t\t" + txtWater.Text + "\n");
            rptExpenses.AppendText("Tax" + "\t\t\t" + txtTax.Text + "\n");
            rptExpenses.AppendText("-------------------------------------------------------------------\n");
            rptExpenses.AppendText("Total" + "\t\t\t" + txtTotal.Text + "\n");
            rptExpenses.AppendText("------------------------------------------------------------------\n");

        }

        private void btnRental_Click(object sender, EventArgs e)
        { //creating new classes
            cCustomer iCustomer = new cCustomer();
            RentClass iRent = new RentClass();
            cUtilities iUtilities = new cUtilities();

            // linking methods created in rent class 
            iCustomer.theDeposit = Double.Parse(txtDeposit.Text);
            iRent.theCost = Double.Parse(txtCost.Text);
            iRent.theNumberofroom = Double.Parse(nudRoom.Text);
            iUtilities.theElectricity = Double.Parse(txtEletricity.Text);
            iUtilities.theLocalTax = Double.Parse(txtWaterBill.Text);
            iUtilities.theWaterBill = Double.Parse(txtWaterBill.Text);

            //Calculations
            String q = String.Format("{0:C}", iCustomer.theDeposit  + (iRent.theCost * iRent.theNumberofroom)
                + iUtilities.theElectricity + iUtilities.theLocalTax + iUtilities.theWaterBill);
            txtTotalPayment.Text = q;

            


            // Creating  printout for the recipts
            rptRent.AppendText("\t\tRENT" + "\n" + "-------------------------------------------------------------------------------" + "\n");
            rptRent.AppendText("Customer ID" + "\t\t" + txtCustomerID.Text + "\n");
            rptRent.AppendText("Firstname" + "\t\t\t" + txtFirstname.Text + "\n");
            rptRent.AppendText("Surname" + "\t\t\t" + txtSurname.Text + "\n");
            rptRent.AppendText("Address" + "\t\t\t" + txtAddress.Text + "\n");
            rptRent.AppendText("Postal Code" + "\t\t" + txtPostalCode.Text + "\n");
            rptRent.AppendText("Proof of ID" + "\t\t" + cmbMonth.Text + "\n");
            rptRent.AppendText("Town" + "\t\t\t" + txtTown.Text + "\n");
            rptRent.AppendText("--------------------------------------------------------------------------\n");

            rptRent.AppendText("Electricity" + "\t\t\t" + txtElectricity.Text + "\n");
            rptRent.AppendText("Local Tax" + "\t\t\t" + txtlocaltax.Text + "\n");
            rptRent.AppendText("Water Bill" + "\t\t\t" + txtWaterBill.Text + "\n");
            rptRent.AppendText("-------------------------------------------------------------------------\n");
            rptRent.AppendText("Total Payment" + "\t\t" + txtTotalPayment.Text + "\n");
            rptRent.AppendText("--------------------------------------------------------------------------");
        }
        private void ClearTextBoxes()
        {
            //Clearing data in the textboxes and recipts
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        //Clearing data in the textboxes and recipts
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            cmbLocation.Text = "";
            cmbMonth.Text = "";
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exit for loan calculator
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            
        }

        private void btnpdf_Click_1(object sender, EventArgs e)
        {
            //saving the reciepts into pdf format for loan
            using (SaveFileDialog sf = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sf.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(rptRent.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void btnexpensespdf_Click(object sender, EventArgs e)
        {
            //saving the reciepts into pdf format for loan
            using (SaveFileDialog sf = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sf.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(rptExpenses.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void btnexpensespdf_Click_1(object sender, EventArgs e)
        {
            //saving the reciepts into pdf format for rent
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(rptExpenses.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void txtTTransport_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btnShowRemaining_Click(object sender, EventArgs e)
        {
            //Calculating remaining money
            double totalexpense = double.Parse(txtTotal.Text);
            double totalrent = double.Parse(txtTotalPayment.Text);
            double totalloan = double.Parse(lblTotalPayment.Text);
            double result = 0;

            //if the user clicks renting it will subtract expenses and rent and come with total
            if(rbRenting.Checked == true)
            {
                result = totalexpense - totalrent;
            }
            //if the user clicks buying it will subtract expenses and homeloan and come with total
            else if (rbBuying.Checked)
            {
                result = totalexpense - totalloan;
            }
            //final answer is calculated
            txtmoneyremaining.Text = result.ToString();

        }

        private void txtmoneyused_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMoneyused_Click(object sender, EventArgs e)
        {
            //Calculating remaining money
            double expense = double.Parse(txtTotal.Text);
            double rents = double.Parse(txtTotalPayment.Text);
            double homeloan = double.Parse(lblTotalPayment.Text);
            double moneyused = 0;

            //if the user clicks renting it will add expenses and rent and come with total
            if (rbrentused.Checked == true)
            {
                moneyused = expense + rents;
            }
            //if the user clicks buying it will add expenses and homeloan and come with total
            else if (rbloanused.Checked)
            {
                moneyused = expense + homeloan;
            }
            //final answer is calculated
            txtmoneyremaining.Text = moneyused.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //saving the reciepts into pdf format for rent
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(rptRent.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saving the reciepts into pdf format for expenses
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(rtLoanreciept1.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
        // when the user clicks this button it will automatically calculate the ttal loan payment and monthly payment
        private void btnLoan_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInteresetRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            loanAmount = Convert.ToDouble(txtAmountofLoan.Text);
           
            //Calculations formula
            MonthlyPayment = loanAmount * monthlyInteresetRate / (1 - 1 / Math.Pow(1 + monthlyInteresetRate, numberOfYears * 12));


            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);

            TotalPayment = MonthlyPayment * numberOfYears * 12;
            iTotalPayment = String.Format("{0:C}", TotalPayment);
            lblTotalPayment.Text = (iTotalPayment);

            txtAmountofLoan.Text = String.Format("{0:}", loanAmount);

            rtLoanreciept1.AppendText("\t\" LOAN" + "\n" + "-------------------------------------------------------------------------------" + "\n");
            rtLoanreciept1.AppendText("Loan Amount" + "\t\t" + "R" + txtAmountofLoan.Text + "\n");
            rtLoanreciept1.AppendText("Number of Years" + "\t\t" + "R" + txtNumberOfYears.Text + "\n");
            rtLoanreciept1.AppendText("Interest Rate" + "\t\t" + "R" + txtInterestRate.Text + "\n");
            rtLoanreciept1.AppendText("Monthly Payment" + "\t\t" + lblMonthlyPayment.Text + "\n");
            rtLoanreciept1.AppendText("--------------------------------------------------------------------------------------\n");
            rtLoanreciept1.AppendText("Total" + "\t\t" + lblTotalPayment.Text + "\n");
            rtLoanreciept1.AppendText("--------------------------------------------------------------------------------------\n");


        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTown.Text = cmbLocation.Text;
        }
    }
}
