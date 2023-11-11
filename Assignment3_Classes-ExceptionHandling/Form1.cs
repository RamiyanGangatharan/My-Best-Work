namespace Assignment3_Classes_ExceptionHandling
{
    public partial class Window : Form
    {
        /*
         * Author: Ramiyan Gangatharan
         * File Editing Duration: October 20 2023 - November 10 2023
         * Description: This app is intended to be a car service reservation application where you store customer, vehicle, and service information.
         */

        Service service = new Service();
        PriceCalculation calculation = new PriceCalculation();
        UserInterfaceHandler UIHandler = new UserInterfaceHandler();
        Control[] controls;

        // Note: found out the "M" suffix is used as something called a literal where it is a value that does not change.
        //https://stackoverflow.com/questions/977484/what-does-the-m-stand-for-in-c-sharp-decimal-literal-notation
        decimal transmissionCost = 120.00M;
        decimal engineCost = 60.00M;
        decimal airCost = 40.50M;
        const decimal salesTax = 1.13M;
        decimal runningTotal = 0.0M;
        int defaultIndex = -1;

        public Window()
        {
            InitializeComponent();
            // This is an array of controls to make the data manipulation processes easier.
            controls = new Control[]
            {
                TransmissionCheck, EngineCheck, AirCheck, YearComboBox, MakeComboBox,
                FirstNameRTB, LastNameRTB, ColourRTB, PhoneRTB, ModelRTB, CostRTB
            };
        }

        private void Window_Load(object sender, EventArgs e) { }

        // This method is used to update the cost using the Service class where it clears the textboxes and refreshes it to the current values inputted.
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
         * This method checks if any of the checkboxes are clicked. If the checkbox is clicked, then add to the cost of the service. If it is not clicked, 
         * then remove to the total cost of the service creating a "real time" feeling interface. Once done, call CostUpdater to change the cost of service.
         */
        private void Checkbox_CheckedChanged(object sender, decimal cost)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked) { runningTotal += cost; }
            else { runningTotal -= cost; }
            CostUpdater(runningTotal, salesTax);
        }

        /* 
         * These three methods create functionality to the checkboxes in the program. The checkboxes are used to calculate the price (with tax). The
         * transmission fluid it costs $120.00 plus tax ($135.60). I found that I was repeating code three times so I created an event handler for the 
         * checkboxes with different parameters in order to determine if each individual checkbox is clicked or not. 
        */
        private void TransmissionCheck_CheckedChanged(object sender, EventArgs e) { Checkbox_CheckedChanged(sender, transmissionCost); }
        private void EngineCheck_CheckedChanged(object sender, EventArgs e) { Checkbox_CheckedChanged(sender, engineCost); }
        private void AirCheck_CheckedChanged(object sender, EventArgs e) { Checkbox_CheckedChanged(sender, airCost); }

        /*
         * This function clears all input fields using a for loop using the method ClearControls where it clears all text and checks.
         */
        private void ResetButton_Click(object sender, EventArgs e)
        {
            UIHandler.ClearControls(controls);
            // Reset the indices of comboBox to default values
            MakeComboBox.SelectedIndex = defaultIndex;
            YearComboBox.SelectedIndex = defaultIndex;
            FirstNameRTB.Focus();
        }

        /*
         * This event handler updates the current selected row where it first checks if a row is selected then overwrites the row selected with the 
         * validated data that the user inputs before clicking the button. This is where I learned about using MessageBox buttons for the first time 
         * where if the user does not select a row, then it displays an error message with one button and does nothing.
         */
        private void UpdateButton_Click(object sender, EventArgs e)
        {

            // Validation
            int selectedCount = DataListView.SelectedItems.Count;
            if (selectedCount == 0) 
            { 
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedCount > 1) 
            { 
                MessageBox.Show("Please select only one row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (DataListView.SelectedItems.Count > 0)
                {
                    // Service --> DataListView
                    // Updates service object with list item selection. SelectedItems[0] == the row you clicked. SubItems[] is the column number in the row.
                    service.calender = DataListView.SelectedItems[0].SubItems[1].Text;
                    service.firstName = DataListView.SelectedItems[0].SubItems[2].Text;
                    service.lastName = DataListView.SelectedItems[0].SubItems[3].Text;
                    service.phoneNumber = DataListView.SelectedItems[0].SubItems[4].Text;
                    service.Make = DataListView.SelectedItems[0].SubItems[5].Text;
                    service.Model = DataListView.SelectedItems[0].SubItems[6].Text;
                    if (int.TryParse(DataListView.SelectedItems[0].SubItems[7].Text, out int yearValue)) { service.Year = yearValue; }
                    service.Colour = DataListView.SelectedItems[0].SubItems[8].Text;
                    if (decimal.TryParse(DataListView.SelectedItems[0].SubItems[9].Text, out decimal value)) { service.Price = value; }
                }

                // Transferring the data from textboxes to the service object
                FirstNameRTB.Text = service.firstName;
                LastNameRTB.Text = service.lastName;
                PhoneRTB.Text = service.phoneNumber;
                Calender.Text = service.calender;
                MakeComboBox.SelectedItem = service.Make;
                ModelRTB.Text = service.Model;
                YearComboBox.SelectedItem = service.Year.ToString();
                ColourRTB.Text = service.Colour;
                CostRTB.Text = service.Price.ToString();
            }
        }

        /* 
         * This is a helper method for the add and overwrite buttons where it helps declare and organize the user inputs to the table using the service 
         * class before the true appending of the information with the add button.
        */
        private void PopulateServiceObject()
        {
            service.calender = Calender.Text;
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

        private void OverwriteButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataListView and exit the method if no row is selected
            if (DataListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if all rows are filled
            if (!ValidateFields())
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Overwrite the row
                PopulateServiceObject();

                // Get the selected row, then use the UIHandler class to update the listView item
                ListViewItem selectedRow = DataListView.SelectedItems[0];
                UIHandler.UpdateListViewItem(selectedRow, service);

                // Clear input fields
                ResetButton_Click(sender, e);
                FirstNameRTB.Focus();
            }
        }

        // This is a helper method for the add button to validate the user input.
        private bool ValidateFields() { return UIHandler.ValidateFields(controls); }

        /*
         * This event handler is for the "Add" button where it checks if the inputs are empty, null, or has whitespace. By utilizing many helper functions for
         * cleaner code, it first checks if there is valid information in the user inputs, then it inserts the data into the data list view (table) to be 
         * displayed to the user.
         */
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PopulateServiceObject();

            Service.Count++;
            Service.IdentificationNumber = Service.Count;

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

            ResetButton_Click(sender, e);
            FirstNameRTB.Focus();
        }

        // This method is used to remove an individual item on the table once the row is clicked.
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (DataListView.Items.Count > 0 && DataListView.SelectedItems.Count > 0)
            {
                DataListView.Items.Remove(DataListView.SelectedItems[0]);

                // Update the counter for the row
                int counter = 0;
                foreach (ListViewItem item in DataListView.Items)
                {
                    counter++;
                    // Set the updated counter value
                    item.SubItems[0].Text = counter.ToString();
                }
                // Update the variable to match the total item count.
                Service.Count = counter;
                FirstNameRTB.Focus();
            }
        }

        // This method is used to remove all contents from the table using a for loop.
        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            if (DataListView.Items.Count > 0)
            {
                for (int i = DataListView.Items.Count - 1; i >= 0; i--) { DataListView.Items.RemoveAt(i); }
                Service.Count = 0;
            }
            FirstNameRTB.Focus();
        }

        // This button closes the application, but before it does close the app, it makes sure you want to actually close it.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) { Application.Exit(); }
        }

        // This button opens a window for the help window (will explain in that file).
        private void HelpButton_Click(object sender, EventArgs e)
        {
            UserManual userManual = new UserManual();
            userManual.Show();
        }
    }
}