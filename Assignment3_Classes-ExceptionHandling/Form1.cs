namespace Assignment3_Classes_ExceptionHandling
{
    public partial class Window : Form
    {
        #region "SUMMARY"
        /*
         * Author: Ramiyan Gangatharan
         * File Editing Duration: October 20 2023 - November 10 2023
         * Description: This application is intended to be a car service reservation application where you store customer information, 
         * vehicle information, and service data within the application where it can be viewed in the car service summary. This is the 
         * largest functional program I have written so far with six classes and three windows as it has taken me two weeks to plan and implement.
         */
        #endregion

        #region "INITIALIZATION"
        Service service = new Service();
        PriceCalculation calculation = new PriceCalculation();
        UserInterfaceHandler UIHandler = new UserInterfaceHandler();
        Control[] controls;

        // Note: found out the "M" suffix is used as something called a literal where it is a value that does not change.
        //https://stackoverflow.com/questions/977484/what-does-the-m-stand-for-in-c-sharp-decimal-literal-notation
        //https://www.geeksforgeeks.org/c-sharp-literals/
        decimal transmissionCost = 120.00M;
        decimal engineCost = 60.00M;
        decimal airCost = 40.50M;
        const decimal salesTax = 1.13M;
        decimal runningTotal = 0.0M;
        int defaultIndex = -1;

        /*
         * This constructor is used to initialize all the components of this application and create an array of controls excluding buttons.
         * Turns out the InitializeComponent method is used to create the GUI itself and to declare all components of the form including the
         * window so that there is a general understanding that the item exists in the environment. When you click on it, it brings you to the
         * back end of the code where everything is being done by the .NET framework.
         */
        public Window()
        {
            InitializeComponent();
            controls = new Control[]
            {
                TransmissionCheck, EngineCheck, AirCheck, YearComboBox, MakeComboBox,
                FirstNameRTB, LastNameRTB, ColourRTB, PhoneRTB, ModelRTB, CostRTB
            };
        }
        // I assume this is for loading the form but I have put nothing in here so far.
        private void Window_Load(object sender, EventArgs e) { }
        #endregion

        #region "CHECKBOXES"
        /*
         * This method is used to update the cost where it accesses an instance of the Service class and uses the property "Price"
         * in which is from the Service object. This is my first time properly using classes and has blown my mind on how useful it is.
         */
        private decimal CostUpdater(decimal runningTotal, decimal salesTax)
        {
            service.Price = calculation.UpdateTotalCost(runningTotal, salesTax);
            CostRTB.Clear();
            TaxRTB.Clear();
            CostRTB.AppendText("$" + service.Price.ToString("0.00"));
            TaxRTB.AppendText("$" + runningTotal.ToString("0.00"));
            return service.Price;
        }

        /*
         * This method checks if any of the checkboxes are clicked. If the checkbox is clicked, then add to the cost of the service.
         * If it is not clicked, then remove to the total cost of the service thus creating a "real time" feeling interface. Once this 
         * is determined, then call the CostUpdater method to change the actual cost of the service for that vehicle.
         */
        private void Checkbox_CheckedChanged(object sender, decimal cost)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                runningTotal += cost;
            }
            else
            {
                runningTotal -= cost;
            }
            CostUpdater(runningTotal, salesTax);
        }

        /* These three methods create functionality to the checkboxes in the program. The checkboxes are used to calculate the price (with tax). 
         * For example, the transmission fluid it costs $120.00 plus tax ($135.60). I found that I was repeating code three times so I created 
         * an event handler for the checkboxes with different parameters in order to determine if each individual checkbox is clicked or not. 
        */
        private void TransmissionCheck_CheckedChanged(object sender, EventArgs e)
        {
            Checkbox_CheckedChanged(sender, transmissionCost);
        }
        private void EngineCheck_CheckedChanged(object sender, EventArgs e)
        {
            Checkbox_CheckedChanged(sender, engineCost);
        }
        private void AirCheck_CheckedChanged(object sender, EventArgs e)
        {
            Checkbox_CheckedChanged(sender, airCost);
        }

        #endregion

        #region "BUTTONS"

        /*
         * This function clears all input fields using a for loop and resets them to the values that they were on initialization.
         * Using a class I have created called UIHandler with the method ClearControls where it clears all textboxes and checkboxes.
         */
        private void ResetButton_Click(object sender, EventArgs e)
        {
            UIHandler.ClearControls(controls);
            // Reset the indices of comboBox to default values
            MakeComboBox.SelectedIndex = defaultIndex;
            YearComboBox.SelectedIndex = defaultIndex;
        }

        /*
         * This event handler updates the current selected row where it first checks if a row is selected then overwrites the row selected 
         * with the validated data that the user inputs before clicking the button. This is where I learned about using MessageBox buttons 
         * for the first time where if the user does not select a row, then it displays an error message with one button and does nothing.
         */
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (DataListView.SelectedItems.Count == 0)
            {
                // Check if a row is selected in the DataListView
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Exit the method if no row is selected
                return;
            }
            if (!ValidateFields())
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PopulateServiceObject();

            // Get the selected row, then use the UIHandler class to update the listView item
            ListViewItem selectedRow = DataListView.SelectedItems[0];
            UIHandler.UpdateListViewItem(selectedRow, service);

            // Clear input fields
            ResetButton_Click(sender, e);
        }

        // This is a helper method for the add button to validate the user input.
        private bool ValidateFields()
        {
            return UIHandler.ValidateFields(controls);
        }

        // This is a helper method for the add button where it displays a custom error message
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /* 
         * This is a helper method for the add button where it helps declare and organize the user inputs to the table 
         * using the service class before the true appending of the information with the add button.
        */
        private void PopulateServiceObject()
        {
            service.calendar = Calender.Text;
            service.firstName = FirstNameRTB.Text;
            service.lastName = LastNameRTB.Text;
            service.phoneNumber = PhoneRTB.Text;
            service.Make = MakeComboBox.SelectedItem?.ToString() ?? string.Empty;
            service.Model = ModelRTB.Text;
            service.Year = int.Parse(YearComboBox.SelectedItem?.ToString() ?? "0");
            service.Colour = ColourRTB.Text;
            service.EngOilChange = EngineCheck.Checked;
            service.TransOilChange = TransmissionCheck.Checked;
            service.AirFilterChange = AirCheck.Checked;
            service.Price = CostUpdater(runningTotal, salesTax);
        }


        // This is a helper method for the add button where it updates the counter for the row counter.
        // This is just an indicator on how many rows the user has inputted.
        public void UpdateCounter()
        {
            int counter = 0;
            foreach (ListViewItem item in DataListView.Items)
            {
                counter++;
                // Set the updated counter value
                item.SubItems[0].Text = counter.ToString();
            }
            // Update the variable to match the total item count.
            Service.Count = counter;
        }

        /*
         * This is a helper method for the add button where it actually appends the data into the table.
         * It first creates a new listViewItem control then adds each column to the table. Once that is
         * done, it then creates the table with all the columns and rows required for operation.
        */
        private void AddNewRow()
        {
            Service.IncrementCount();
            ListViewItem newItem = new ListViewItem(Service.IdentificationNumber.ToString());
            newItem.SubItems.Add(Calender.Text);
            newItem.SubItems.Add(FirstNameRTB.Text);
            newItem.SubItems.Add(LastNameRTB.Text);
            newItem.SubItems.Add(PhoneRTB.Text);
            newItem.SubItems.Add(MakeComboBox.SelectedItem?.ToString() ?? string.Empty);
            newItem.SubItems.Add(ModelRTB.Text);
            newItem.SubItems.Add(YearComboBox.SelectedItem?.ToString() ?? string.Empty);
            newItem.SubItems.Add(ColourRTB.Text);
            newItem.SubItems.Add(CostRTB.Text);
            DataListView.Items.Add(newItem);
        }

        /*
         * This event handler is for the "Add" button where it checks if the inputs are empty, null, or has whitespace. 
         * By utilizing many helper functions for cleaner code, it first checks if there is valid information in the 
         * user inputs, then it inserts the data into the data list view (table) to be displayed to the user.
         */
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                ShowErrorMessage("Please fill in all required fields.");
                return;
            }
            PopulateServiceObject();
            AddNewRow();
            ResetButton_Click(sender, e);
        }


        // This method is used to remove an individual item on the table once the row is clicked.
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (DataListView.Items.Count > 0 && DataListView.SelectedItems.Count > 0)
            {
                DataListView.Items.Remove(DataListView.SelectedItems[0]);
                UpdateCounter();
            }
        }

        // This method is used to remove all contents from the table.
        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            if (DataListView.Items.Count > 0)
            {
                for (int index = DataListView.Items.Count - 1; index >= 0; index--)
                {
                    DataListView.Items.RemoveAt(index);
                }
                Service.Count = 0;
            }
        }

        // This button closes the application, but before it does close the app, it makes sure you want to actually close it.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
            (
                "Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // This button opens a window for the help window (will explain in that file).
        private void HelpButton_Click(object sender, EventArgs e)
        {
            UserManual userManual = new UserManual();
            userManual.Show();
        }

        // This button opens a window for a little credit window, the reasons I have this are:
        // 1) All the people who helped me with this project
        // 2) The control surface section needed an eighth button to be aesthetically pleasing
        private void CreditButton_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
        }

        private void Calendar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    #endregion
}