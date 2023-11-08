namespace Assignment3_Classes_ExceptionHandling
{
    /*
     * Author:          Ramiyan Gangatharan
     * File Editing Duration: October 20 2023 - October 22 2023
     * 
     * Description: This is the user accessible documentation or user manual I have programmed in case
     *              there is completely new user trying to figure out how this program operates.
     *
     * This file is purely to open the window. I felt that this window was required because 
     * I have a feeling that *somebody* will be confused on how to operate this software.
     */

    public partial class UserManual : Form
    {
        public UserManual() { InitializeComponent(); }
        private void UserManual_Load(object sender, EventArgs e)
        {
            // Researched links because it was interesting 
            // Add a link to the LinkLabel
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://youtu.be/dQw4w9WgXcQ");

            // Add to the LinkClicked event
            linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);

            // Add the LinkLabel to the form's controls
            this.Controls.Add(linkLabel1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the link in the default browser
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo { FileName = e.Link.LinkData.ToString(), UseShellExecute = true };
                System.Diagnostics.Process.Start(psi);
            }
            catch (System.ComponentModel.Win32Exception ex)
            { MessageBox.Show("Unable to open link. The system cannot find the file specified." + "StackTrace: " + ex); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}