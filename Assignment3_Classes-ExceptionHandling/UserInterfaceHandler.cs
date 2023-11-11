namespace Assignment3_Classes_ExceptionHandling
{
    /*
    * Author: Ramiyan Gangatharan
    * File Editing Duration: October 27 2023 - October 27 2023
    * Description: This class is used to handle the user's inputs from the controls.
    */
    internal class UserInterfaceHandler
    {

        /*
         * This method clears all of the modifiable user interfaces using a for loop and various
         * if and else if statements where it verifies the type of control and clears it appropriately.
         */
        int defaultIndex = -1;
        public void ClearControls(Control[] controls)
        {
            for (int controller = 0; controller < controls.Length; controller++)
            {
                var control = controls[controller];
                if (control.GetType() == typeof(CheckBox)) { ((CheckBox)control).Checked = false; }
                else if (control.GetType() == typeof(ComboBox)) { ((ComboBox)control).SelectedIndex = defaultIndex; }
                else if (control.GetType() == typeof(RichTextBox)) { ((RichTextBox)control).Clear(); }
            }
        }


        // This method is used to overwrite a row when called and is used once the user input has been validated and the row has been clicked.
        public void UpdateListViewItem(ListViewItem item, Service service)
        {
            item.SubItems[1].Text = service.calender;
            item.SubItems[2].Text = service.firstName;
            item.SubItems[3].Text = service.lastName;
            item.SubItems[4].Text = service.phoneNumber;
            item.SubItems[5].Text = service.Make;
            item.SubItems[6].Text = service.Model;
            item.SubItems[7].Text = service.Year.ToString();
            item.SubItems[8].Text = service.Colour;
            item.SubItems[9].Text = "$" + service.Price.ToString("0.00");
        }

        /*
         * This method validates all user input fields so that the right information is appended to the table.
         * The method is validating if the input is empty, null, or just whitespace.
         */
        public bool ValidateFields(Control[] controls)
        {
            for (int controller = 0; controller < controls.Length; controller++)
            {
                var control = controls[controller];
                if (control.GetType() == typeof(RichTextBox))
                {
                    RichTextBox rtb = (RichTextBox)control;
                    if (string.IsNullOrWhiteSpace(rtb.Text))
                    {
                        return false;
                    }
                }
                else if (control.GetType() == typeof(ComboBox))
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.SelectedIndex == defaultIndex)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}