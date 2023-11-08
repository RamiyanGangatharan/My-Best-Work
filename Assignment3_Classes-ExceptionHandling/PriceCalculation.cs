namespace Assignment3_Classes_ExceptionHandling
{
    /*
    * Author: Ramiyan Gangatharan
    * File Editing Duration: October 27 2023 - October 27 2023
    * Description: This thing is for calculating price, split it into a class for the sake of doing so.
    */
    internal class PriceCalculation
    {
        // This method updates the cost of service "in real time" with the calculation of sales tax.
        public decimal UpdateTotalCost(decimal runningTotal, decimal salesTax)
        {
            decimal totalCost = runningTotal * salesTax;
            return totalCost;
        }


    }
}