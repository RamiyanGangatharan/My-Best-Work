namespace Assignment3_Classes_ExceptionHandling
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            PersonalInformation = new GroupBox();
            label12 = new Label();
            Calender = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            PhoneRTB = new RichTextBox();
            LastNameRTB = new RichTextBox();
            FirstNameRTB = new RichTextBox();
            label1 = new Label();
            VehicularInformation = new GroupBox();
            YearComboBox = new ComboBox();
            ColourRTB = new RichTextBox();
            label7 = new Label();
            label6 = new Label();
            MakeComboBox = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            ModelRTB = new RichTextBox();
            AddButton = new Button();
            ResetButton = new Button();
            UpdateButton = new Button();
            RemoveButton = new Button();
            RemoveAllButton = new Button();
            ExitButton = new Button();
            Services = new GroupBox();
            AirCheck = new CheckBox();
            EngineCheck = new CheckBox();
            TransmissionCheck = new CheckBox();
            CostRTB = new RichTextBox();
            DataListView = new ListView();
            NumberHeader = new ColumnHeader();
            Date = new ColumnHeader();
            FirstNameHeader = new ColumnHeader();
            LastNameHeader = new ColumnHeader();
            PhoneHeader = new ColumnHeader();
            MakeHeader = new ColumnHeader();
            ModelHeader = new ColumnHeader();
            YearHeader = new ColumnHeader();
            ColourHeader = new ColumnHeader();
            PriceHeader = new ColumnHeader();
            CopyrightLabel = new Label();
            groupBox2 = new GroupBox();
            CreditButton = new Button();
            HelpButton = new Button();
            groupBox3 = new GroupBox();
            groupBox1 = new GroupBox();
            label10 = new Label();
            TaxRTB = new RichTextBox();
            label9 = new Label();
            label8 = new Label();
            toolTip1 = new ToolTip(components);
            PersonalInformation.SuspendLayout();
            VehicularInformation.SuspendLayout();
            Services.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PersonalInformation
            // 
            PersonalInformation.BackColor = Color.Transparent;
            PersonalInformation.Controls.Add(label12);
            PersonalInformation.Controls.Add(Calender);
            PersonalInformation.Controls.Add(label3);
            PersonalInformation.Controls.Add(label2);
            PersonalInformation.Controls.Add(PhoneRTB);
            PersonalInformation.Controls.Add(LastNameRTB);
            PersonalInformation.Controls.Add(FirstNameRTB);
            PersonalInformation.Controls.Add(label1);
            PersonalInformation.ForeColor = SystemColors.ControlText;
            PersonalInformation.Location = new Point(17, 14);
            PersonalInformation.Margin = new Padding(4);
            PersonalInformation.Name = "PersonalInformation";
            PersonalInformation.Padding = new Padding(4);
            PersonalInformation.Size = new Size(269, 224);
            PersonalInformation.TabIndex = 0;
            PersonalInformation.TabStop = false;
            PersonalInformation.Text = "Personal Information";
            toolTip1.SetToolTip(PersonalInformation, "This is the section where you insert your personal information");
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(149, 149);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 8;
            label12.Text = "Date";
            // 
            // Calender
            // 
            Calender.Format = DateTimePickerFormat.Short;
            Calender.Location = new Point(149, 172);
            Calender.Name = "Calender";
            Calender.Size = new Size(113, 27);
            Calender.TabIndex = 4;
            toolTip1.SetToolTip(Calender, "Enter the date of appointment here.");
            Calender.Value = new DateTime(2023, 10, 30, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 149);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 6;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // PhoneRTB
            // 
            PhoneRTB.Location = new Point(8, 173);
            PhoneRTB.Margin = new Padding(4);
            PhoneRTB.Name = "PhoneRTB";
            PhoneRTB.Size = new Size(134, 27);
            PhoneRTB.TabIndex = 3;
            PhoneRTB.Text = "";
            toolTip1.SetToolTip(PhoneRTB, "Enter your telephone number here.");
            // 
            // LastNameRTB
            // 
            LastNameRTB.Location = new Point(7, 112);
            LastNameRTB.Margin = new Padding(4);
            LastNameRTB.Name = "LastNameRTB";
            LastNameRTB.Size = new Size(255, 30);
            LastNameRTB.TabIndex = 2;
            LastNameRTB.Text = "";
            toolTip1.SetToolTip(LastNameRTB, "Enter your lastname here.");
            // 
            // FirstNameRTB
            // 
            FirstNameRTB.Location = new Point(7, 54);
            FirstNameRTB.Margin = new Padding(4);
            FirstNameRTB.Name = "FirstNameRTB";
            FirstNameRTB.Size = new Size(255, 30);
            FirstNameRTB.TabIndex = 1;
            FirstNameRTB.Text = "";
            toolTip1.SetToolTip(FirstNameRTB, "Enter your first name here.");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 30);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // VehicularInformation
            // 
            VehicularInformation.BackColor = Color.Transparent;
            VehicularInformation.Controls.Add(YearComboBox);
            VehicularInformation.Controls.Add(ColourRTB);
            VehicularInformation.Controls.Add(label7);
            VehicularInformation.Controls.Add(label6);
            VehicularInformation.Controls.Add(MakeComboBox);
            VehicularInformation.Controls.Add(label5);
            VehicularInformation.Controls.Add(label4);
            VehicularInformation.Controls.Add(ModelRTB);
            VehicularInformation.Location = new Point(294, 15);
            VehicularInformation.Margin = new Padding(4);
            VehicularInformation.Name = "VehicularInformation";
            VehicularInformation.Padding = new Padding(4);
            VehicularInformation.Size = new Size(222, 224);
            VehicularInformation.TabIndex = 1;
            VehicularInformation.TabStop = false;
            VehicularInformation.Text = "Vehicular Information";
            toolTip1.SetToolTip(VehicularInformation, "This is the section where you insert your vehicular information");
            // 
            // YearComboBox
            // 
            YearComboBox.DropDownHeight = 455;
            YearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            YearComboBox.FormattingEnabled = true;
            YearComboBox.IntegralHeight = false;
            YearComboBox.Items.AddRange(new object[] { "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920" });
            YearComboBox.Location = new Point(8, 170);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(100, 28);
            YearComboBox.TabIndex = 7;
            toolTip1.SetToolTip(YearComboBox, "Enter the year of the customer's vehicle here.");
            // 
            // ColourRTB
            // 
            ColourRTB.Location = new Point(115, 170);
            ColourRTB.Margin = new Padding(4);
            ColourRTB.Name = "ColourRTB";
            ColourRTB.Size = new Size(100, 28);
            ColourRTB.TabIndex = 8;
            ColourRTB.Text = "";
            toolTip1.SetToolTip(ColourRTB, "Enter the colour of the customer's vehicle here.");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(115, 146);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 8;
            label7.Text = "Colour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(8, 146);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 7;
            label6.Text = "Year";
            // 
            // MakeComboBox
            // 
            MakeComboBox.DropDownHeight = 575;
            MakeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MakeComboBox.FormattingEnabled = true;
            MakeComboBox.IntegralHeight = false;
            MakeComboBox.Items.AddRange(new object[] { "Acura", "Alfa-Romeo", "AMC", "Ariel", "Aston Martin", "Audi", "Bentley", "BMW", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroën", "Dacia", "Datsun", "Delorean", "Dodge", "Ferrari", "Fiat", "Ford", "GMC", "Hennessey", "Hino", "Holden", "Honda", "Hudson", "Hummer", "Hyundai", "Infiniti", "Isuzu", "Jaguar", "Jeep", "Kia", "Koenigsegg", "Lamborghini", "Lancia", "Land Rover", "Lexus", "Lincoln", "Lotus", "Maserati", "Mazda", "McLaren", "Mercedes-Benz", "Mitsubishi", "Nissan", "Oldsmobile", "Opel", "Pagani", "Peugeot", "Plymouth", "Pontiac", "Porsche", "Reliant", "Renault", "Rivian", "Rolls Royce", "Saab", "Saleen", "Saturn", "Scion", "Smart", "Subaru", "Suzuki", "TATA", "Tesla", "Toyota", "Vauxhall", "Volkswagen", "Volvo", "Willys", "Yamaha" });
            MakeComboBox.Location = new Point(8, 55);
            MakeComboBox.Name = "MakeComboBox";
            MakeComboBox.Size = new Size(208, 28);
            MakeComboBox.TabIndex = 5;
            toolTip1.SetToolTip(MakeComboBox, "Enter the make of the customer's vehicle here.");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 32);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Make";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 86);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Model";
            // 
            // ModelRTB
            // 
            ModelRTB.Location = new Point(8, 110);
            ModelRTB.Margin = new Padding(4);
            ModelRTB.Name = "ModelRTB";
            ModelRTB.Size = new Size(207, 30);
            ModelRTB.TabIndex = 6;
            ModelRTB.Text = "";
            toolTip1.SetToolTip(ModelRTB, "Enter the model of the customer's vehicle here.");
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(15, 23);
            AddButton.Margin = new Padding(4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 45);
            AddButton.TabIndex = 12;
            AddButton.Text = "&Add";
            toolTip1.SetToolTip(AddButton, "Add the service details to the summary below.");
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ResetButton.Location = new Point(123, 23);
            ResetButton.Margin = new Padding(4);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(100, 45);
            ResetButton.TabIndex = 13;
            ResetButton.Text = "&Reset";
            toolTip1.SetToolTip(ResetButton, "Clear all input fields and selections.");
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.Location = new Point(231, 23);
            UpdateButton.Margin = new Padding(4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(100, 45);
            UpdateButton.TabIndex = 14;
            UpdateButton.Text = "&Update";
            toolTip1.SetToolTip(UpdateButton, "Update the selected service details in the summary.");
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.Location = new Point(15, 75);
            RemoveButton.Margin = new Padding(4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(100, 45);
            RemoveButton.TabIndex = 16;
            RemoveButton.Text = "R&emove";
            toolTip1.SetToolTip(RemoveButton, "Remove the selected service details from the summary.");
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // RemoveAllButton
            // 
            RemoveAllButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveAllButton.Location = new Point(123, 75);
            RemoveAllButton.Margin = new Padding(4);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(100, 45);
            RemoveAllButton.TabIndex = 17;
            RemoveAllButton.Text = "Re&move All";
            toolTip1.SetToolTip(RemoveAllButton, "Clear the entire service summary below.");
            RemoveAllButton.UseVisualStyleBackColor = true;
            RemoveAllButton.Click += RemoveAllButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(338, 75);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 45);
            ExitButton.TabIndex = 19;
            ExitButton.Text = "E&xit";
            toolTip1.SetToolTip(ExitButton, "Close the application.");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Services
            // 
            Services.Controls.Add(AirCheck);
            Services.Controls.Add(EngineCheck);
            Services.Controls.Add(TransmissionCheck);
            Services.Location = new Point(524, 15);
            Services.Margin = new Padding(4);
            Services.Name = "Services";
            Services.Padding = new Padding(4);
            Services.Size = new Size(191, 138);
            Services.TabIndex = 8;
            Services.TabStop = false;
            Services.Text = "Services";
            toolTip1.SetToolTip(Services, "This is the section where you insert the services required");
            // 
            // AirCheck
            // 
            AirCheck.AutoSize = true;
            AirCheck.FlatStyle = FlatStyle.Popup;
            AirCheck.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AirCheck.Location = new Point(8, 92);
            AirCheck.Margin = new Padding(4);
            AirCheck.Name = "AirCheck";
            AirCheck.Size = new Size(96, 24);
            AirCheck.TabIndex = 11;
            AirCheck.Text = "Air Filter";
            toolTip1.SetToolTip(AirCheck, "Check if the vehicle's air filter needs replacement.");
            AirCheck.UseVisualStyleBackColor = true;
            AirCheck.CheckedChanged += AirCheck_CheckedChanged;
            // 
            // EngineCheck
            // 
            EngineCheck.AutoSize = true;
            EngineCheck.FlatStyle = FlatStyle.Popup;
            EngineCheck.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EngineCheck.Location = new Point(8, 60);
            EngineCheck.Margin = new Padding(4);
            EngineCheck.Name = "EngineCheck";
            EngineCheck.Size = new Size(110, 24);
            EngineCheck.TabIndex = 10;
            EngineCheck.Text = "Engine Oil";
            toolTip1.SetToolTip(EngineCheck, "Check if the vehicle needs an engine oil change.");
            EngineCheck.UseVisualStyleBackColor = true;
            EngineCheck.CheckedChanged += EngineCheck_CheckedChanged;
            // 
            // TransmissionCheck
            // 
            TransmissionCheck.AutoSize = true;
            TransmissionCheck.FlatStyle = FlatStyle.Popup;
            TransmissionCheck.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TransmissionCheck.Location = new Point(8, 28);
            TransmissionCheck.Margin = new Padding(4);
            TransmissionCheck.Name = "TransmissionCheck";
            TransmissionCheck.Size = new Size(179, 24);
            TransmissionCheck.TabIndex = 9;
            TransmissionCheck.Text = "Transmission Fluid";
            toolTip1.SetToolTip(TransmissionCheck, "Check if the vehicle requires a transmission fluid change.");
            TransmissionCheck.UseVisualStyleBackColor = true;
            TransmissionCheck.CheckedChanged += TransmissionCheck_CheckedChanged;
            // 
            // CostRTB
            // 
            CostRTB.Enabled = false;
            CostRTB.Location = new Point(99, 45);
            CostRTB.Margin = new Padding(4);
            CostRTB.Name = "CostRTB";
            CostRTB.Size = new Size(84, 25);
            CostRTB.TabIndex = 0;
            CostRTB.Text = "";
            toolTip1.SetToolTip(CostRTB, "Displays the final amount to be paid.");
            // 
            // DataListView
            // 
            DataListView.Columns.AddRange(new ColumnHeader[] { NumberHeader, Date, FirstNameHeader, LastNameHeader, PhoneHeader, MakeHeader, ModelHeader, YearHeader, ColourHeader, PriceHeader });
            DataListView.FullRowSelect = true;
            DataListView.GridLines = true;
            DataListView.Location = new Point(7, 27);
            DataListView.Margin = new Padding(4);
            DataListView.Name = "DataListView";
            DataListView.Size = new Size(1145, 403);
            DataListView.TabIndex = 20;
            DataListView.UseCompatibleStateImageBehavior = false;
            DataListView.View = View.Details;
            // 
            // NumberHeader
            // 
            NumberHeader.Text = "NO";
            NumberHeader.Width = 40;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.TextAlign = HorizontalAlignment.Center;
            Date.Width = 110;
            // 
            // FirstNameHeader
            // 
            FirstNameHeader.Text = "First Name";
            FirstNameHeader.TextAlign = HorizontalAlignment.Center;
            FirstNameHeader.Width = 155;
            // 
            // LastNameHeader
            // 
            LastNameHeader.Text = "Last Name";
            LastNameHeader.TextAlign = HorizontalAlignment.Center;
            LastNameHeader.Width = 155;
            // 
            // PhoneHeader
            // 
            PhoneHeader.Text = "Phone";
            PhoneHeader.TextAlign = HorizontalAlignment.Center;
            PhoneHeader.Width = 180;
            // 
            // MakeHeader
            // 
            MakeHeader.Text = "Make";
            MakeHeader.TextAlign = HorizontalAlignment.Center;
            MakeHeader.Width = 135;
            // 
            // ModelHeader
            // 
            ModelHeader.Text = "Model";
            ModelHeader.TextAlign = HorizontalAlignment.Center;
            ModelHeader.Width = 135;
            // 
            // YearHeader
            // 
            YearHeader.Text = "Year";
            YearHeader.TextAlign = HorizontalAlignment.Center;
            YearHeader.Width = 53;
            // 
            // ColourHeader
            // 
            ColourHeader.Text = "Colour";
            ColourHeader.TextAlign = HorizontalAlignment.Center;
            ColourHeader.Width = 95;
            // 
            // PriceHeader
            // 
            PriceHeader.Text = "Price ($)";
            PriceHeader.Width = 81;
            // 
            // CopyrightLabel
            // 
            CopyrightLabel.AutoSize = true;
            CopyrightLabel.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            CopyrightLabel.Location = new Point(24, 685);
            CopyrightLabel.Margin = new Padding(1, 0, 1, 0);
            CopyrightLabel.Name = "CopyrightLabel";
            CopyrightLabel.Size = new Size(277, 15);
            CopyrightLabel.TabIndex = 11;
            CopyrightLabel.Text = "Copyright © Ramiyan Gangatharan - DC 2023 ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CreditButton);
            groupBox2.Controls.Add(HelpButton);
            groupBox2.Controls.Add(AddButton);
            groupBox2.Controls.Add(ExitButton);
            groupBox2.Controls.Add(RemoveAllButton);
            groupBox2.Controls.Add(RemoveButton);
            groupBox2.Controls.Add(ResetButton);
            groupBox2.Controls.Add(UpdateButton);
            groupBox2.Location = new Point(722, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(452, 132);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control Surfaces";
            toolTip1.SetToolTip(groupBox2, "This is the section where you control your data");
            // 
            // CreditButton
            // 
            CreditButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreditButton.Location = new Point(231, 75);
            CreditButton.Name = "CreditButton";
            CreditButton.Size = new Size(100, 45);
            CreditButton.TabIndex = 18;
            CreditButton.Text = "&Overwrite";
            toolTip1.SetToolTip(CreditButton, "View application credits and acknowledgments.");
            CreditButton.UseVisualStyleBackColor = true;
            CreditButton.Click += OverwriteButton_Click;
            // 
            // HelpButton
            // 
            HelpButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            HelpButton.Location = new Point(338, 23);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(100, 45);
            HelpButton.TabIndex = 15;
            HelpButton.Text = "&Help";
            toolTip1.SetToolTip(HelpButton, "Open the help documentation or FAQ.");
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DataListView);
            groupBox3.Location = new Point(17, 245);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1157, 437);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Vehicle Service Summary";
            toolTip1.SetToolTip(groupBox3, "This table will list all the services availed by the vehicle. ");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(TaxRTB);
            groupBox1.Controls.Add(CostRTB);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(524, 161);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(191, 78);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total Cost";
            toolTip1.SetToolTip(groupBox1, "This is the section where the cost is displayed");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 23);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 3;
            label10.Text = "Subtotal:";
            // 
            // TaxRTB
            // 
            TaxRTB.Enabled = false;
            TaxRTB.Location = new Point(99, 18);
            TaxRTB.Margin = new Padding(4);
            TaxRTB.Name = "TaxRTB";
            TaxRTB.Size = new Size(84, 25);
            TaxRTB.TabIndex = 1;
            TaxRTB.Text = "";
            toolTip1.SetToolTip(TaxRTB, "Displays the total cost of services selected, before any discounts or taxes.");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 50);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 2;
            label9.Text = "Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(800, 43);
            label8.Name = "label8";
            label8.Size = new Size(313, 40);
            label8.TabIndex = 14;
            label8.Text = "Auto Repair Shop";
            // 
            // Window
            // 
            AcceptButton = AddButton;
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            CancelButton = ExitButton;
            ClientSize = new Size(1199, 701);
            Controls.Add(groupBox3);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(CopyrightLabel);
            Controls.Add(Services);
            Controls.Add(VehicularInformation);
            Controls.Add(PersonalInformation);
            Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Repair Shop";
            Load += Window_Load;
            PersonalInformation.ResumeLayout(false);
            PersonalInformation.PerformLayout();
            VehicularInformation.ResumeLayout(false);
            VehicularInformation.PerformLayout();
            Services.ResumeLayout(false);
            Services.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox PersonalInformation;
        private GroupBox VehicularInformation;
        private Button AddButton;
        private Button ResetButton;
        private Button UpdateButton;
        private Button RemoveButton;
        private Button RemoveAllButton;
        private Button ExitButton;
        private GroupBox Services;
        private CheckBox AirCheck;
        private CheckBox TransmissionCheck;
        private CheckBox EngineCheck;
        private RichTextBox CostRTB;
        private ListView DataListView;
        private Label CopyrightLabel;
        private ColumnHeader NumberHeader;
        private ColumnHeader FirstNameHeader;
        private ColumnHeader LastNameHeader;
        private ColumnHeader PhoneHeader;
        private ColumnHeader MakeHeader;
        private ColumnHeader ModelHeader;
        private ColumnHeader YearHeader;
        private ColumnHeader ColourHeader;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label3;
        private Label label2;
        private RichTextBox PhoneRTB;
        private RichTextBox LastNameRTB;
        private RichTextBox FirstNameRTB;
        private Label label6;
        private ComboBox MakeComboBox;
        private Label label5;
        private Label label4;
        private RichTextBox ModelRTB;
        private RichTextBox ColourRTB;
        private Label label7;
        private ComboBox YearComboBox;
        private GroupBox groupBox1;
        private Label label8;
        private new Button HelpButton;
        private ColumnHeader PriceHeader;
        private RichTextBox TaxRTB;
        private Label label10;
        private Label label9;
        private DateTimePicker Calender;
        private Label label12;
        private Button CreditButton;
        private ColumnHeader Date;
        private ToolTip toolTip1;
    }
}