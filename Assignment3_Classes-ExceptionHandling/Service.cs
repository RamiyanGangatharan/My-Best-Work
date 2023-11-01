namespace Assignment3_Classes_ExceptionHandling
{
    internal class Service
    {
        /*
         * Author: Ramiyan Gangatharan
         * File Editing Duration: October 20 2023 - October 27 2023
         * Description: This is the Service class where it gets, sets, and modifies the user input.
         */

        // Declarations
        // declaration of the Count and IdentificationNumber variables as static to be used between classes.
        public static int Count = 0;
        public static int IdentificationNumber = 0;

        // Getters and setters for each input.
        public string calendar { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int Year { get; set; }
        public bool EngOilChange { get; set; }
        public bool TransOilChange { get; set; }
        public bool AirFilterChange { get; set; }
        public decimal Price { get; set; }

        // This helper method is used to increment the row counter in the table.
        public static void IncrementCount()
        {
            Count++;
            IdentificationNumber = Count;
        }

        // Default Constructor
        public Service()
        {
            IdentificationNumber = 0;
            calendar = "1/1/2000";
            firstName = "JOHN";
            lastName = "DOE";
            phoneNumber = "555 555 5555";
            Make = "DEFAULT";
            Model = "DEFAULT";
            Colour = "BLANK";
            Year = 2000;
            EngOilChange = false;
            TransOilChange = false;
            AirFilterChange = false;
            Price = 0;
        }

        // Parameterized Constructor (not used, but kept because of instructions for the assignment)
        public Service
        (
            string calendar, string firstName, string lastName, string phoneNumber, string Make, string Model, 
            int Year, string Colour, bool EngOilChange, bool TransOilChange, bool AirFilterChange, decimal Price
        )
        {
            this.calendar = calendar;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Colour = Colour;
            this.EngOilChange = EngOilChange;
            this.TransOilChange = TransOilChange;
            this.AirFilterChange = AirFilterChange;
            this.Price = Price;
        }

        // not used, but kept because of instructions for the assignment
        public string GetServiceData()
        {
            return
                $"Service Information:\n" +
                $"Identification Number: {IdentificationNumber}\n" +
                $"Date: {calendar}\n" +
                $"Name: {firstName} {lastName}\n" +
                $"Phone Number: {phoneNumber}\n" +
                $"Make: {Make}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}\n" +
                $"Colour: {Colour}\n" +
                $"Engine Oil Change: {EngOilChange}\n" +
                $"Transmission Oil Change: {TransOilChange}\n" +
                $"Air Filter Change: {AirFilterChange}\n" +
                $"Price: {Price:C}";
        }
    }
}