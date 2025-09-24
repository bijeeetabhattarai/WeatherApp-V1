
/*Project 2.
Bijita Bhattarai

Weather Analysis version 2.0

The name of the application is Weather Analysis Version 1.0, the purpose of this application to record,
display the Weather Records and to show average temperature of the states and the region, with few other functions.
This application takes date, city name, state name and temperature from user and records it on the .txt file and 
displays it on the list box.

Users provide the inputs, User can also check for the lowest temperature and the highest temperature, update and
the save the records, delete just one records or delete all records. User can search by state.

*/




using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using static System.Windows.Forms.AxHost;

namespace P2_Bhattarai_Bijita
{
    public partial class Form1 : Form
    {

        //declare a variable to store verified temp value which can be used throughout the class
        private double verifiedTemperatureValue;
        // declare a variable to check if the temp is set
        private bool isTemperatureSet = false;
        public Form1()
        {
            InitializeComponent();


            // Set up autocomplete suggestion and append mode for stateComboBox
            stateComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //sets the source to list of items in combo box
            stateComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

           

        }


        // event handler for when a key is press in the city text box
        private void cityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // check if key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                //set the event to handle and successfully processed
                e.Handled = true;
                //set the focus to combo box
                stateComboBox.Focus();
            }
        }

        //event handler for when a key is press in the combo Box 
        private void stateComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            // check if key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                //set the event to handle and successfully processed
                e.Handled = true;
                // set the focus to temp text Box
                tempTextBox.Focus();
            }
        }
        //event handler for when a key is press in the temp text box
        private void tempTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // check if key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                //set the event to handle and successfully processed
                e.Handled = true;
                // set the focus to date time pickers
                dateTimePicker.Focus();
            }
        }
        //event handler for when a key is press in the date time pickers 
        private void dateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            // check if key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                //set the event to handle and successfully processed
                e.Handled = true;
                // set the focus to add button
                addButton.Focus();
            }
        }


        // Method to get verified temp value
        private void SetVerifiedTemperatureValue()
        {
            //declare temp
            double temp;
            //Parse the temperature string into double
            if (!double.TryParse(tempTextBox.Text, out temp))
            {
                //if the conersion fails show this message
                MessageBox.Show("Please enter a valid Temperature number");
                //clear textbox
                tempTextBox.Clear();

                // set the focus to temp textbox
                tempTextBox.Focus();
                // Temperature is not set, set the flag to false
                isTemperatureSet = false;
            }
            //check the temp range
            else if (temp < -90 || temp > 130)
            {
                //show error if temp is out of range
                MessageBox.Show("Temperature  must be between -90 and  130");
                //clear the text box
                tempTextBox.Clear();
                //set the focus to temp text box
                tempTextBox.Focus();
                // Temperature is not set, set the flag to false
                isTemperatureSet = false;

            }
            else
            {

                // set the temp value to the verifiedTemperatureValue
                verifiedTemperatureValue = temp;
                // Temperature is set, set the flag to True
                isTemperatureSet = true;
            }


        }// Event handler for validating input in the temperature textbox
        private void tempTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only digit, (-), backspace
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 45) && (!char.IsControl(e.KeyChar)))
            {
                //set the event to handle and successfully processed
                e.Handled = true;
            }
            //if enter key is pressed
            if (e.KeyChar == '\r')
            {
                //call this method and set the verified temperature value
                SetVerifiedTemperatureValue();
            }
        }
        // Event handler for the add button click
        private void addButton_Click(object sender, EventArgs e)

        {
            

            // store citytextbox value in city
            string city = cityTextBox.Text;
            //check for empty or whitespace
            if (string.IsNullOrWhiteSpace(city))
            {
                //show error message
                MessageBox.Show("city must be entered");
                //set the focus
                cityTextBox.Focus();
                //exit, do noy execute
                return;
            }
            // store combobox value in state
            string state = stateComboBox.Text;
            // Check if state is empty, contains digits, or is not in the list of items
            if (string.IsNullOrWhiteSpace(state) || state.Any(char.IsDigit) || !stateComboBox.Items.Contains(state))
            {
                // Display a message box indicating that a state must be selected and cannot contain digits
                MessageBox.Show("State must be selected and cannot contain digits.");
                // Reset the selected index of the stateComboBox to -1 (no selection)
                stateComboBox.SelectedIndex = -1;
                // Set focus to the stateComboBox
                stateComboBox.Focus();
                //exit
                return;
            }

            // to validate and use the value
            SetVerifiedTemperatureValue();

            // check is temperate is not set
            if (!isTemperatureSet)
            {
                //show error message
                MessageBox.Show("Temperature must be entered before proceeding");
                //set the focus
                tempTextBox.Focus();
                // exit
                return;
            }

            // store dateTimeoicker value in date
            string date = dateTimePicker.Value.ToString("MM-dd-yyyy");
            //check for null or whitespace
            if (string.IsNullOrWhiteSpace(date))
            {
                //show error message
                MessageBox.Show(" Date must be selected");

                //set focus
                dateTimePicker.Focus();

                //exit
                return;
            }

           


            // add F to the temperature value (F as in fahrenheit unit)
            String temp = verifiedTemperatureValue.ToString() +"F";

            //format how you want it be displayed or added
            string completeWeatherInformation = $"{date,-20}\t{city,-20}\t{state,-10}\t{temp,-10}";
            //add to the list box
            outputListBox.Items.Add(completeWeatherInformation);
            // set the focus to the city text box
            cityTextBox.Focus();
            // Re-Calculate average temperatures
            CalculateAverageTemperatures();


            // try to write weather info to the weather.txt file
            try
            {
                // Declare a StreamWriter variable
                StreamWriter outputFile;

                // Create a file and get a StreamWriter object
                outputFile = File.AppendText("Weather.txt");
                //write weather info to file
                outputFile.WriteLine(completeWeatherInformation);
                // close the file
                outputFile.Close();
                // show success message
                MessageBox.Show("The weather Information is entered");

            }
            catch (Exception ex)
            {
                // Display and error message
                MessageBox.Show(ex.Message);
            }

            // clear all 4 input fields
            cityTextBox.Clear();
            stateComboBox.SelectedIndex = -1;
            tempTextBox.Clear();
            dateTimePicker.Value = DateTime.Now;
            

            


        }

        // Event handler for the clear button click
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the text in the city text box
            cityTextBox.Clear();
            // Set the selected index of the state combo box to -1 (no selection)
            stateComboBox.SelectedIndex = -1;
            // Clear the text in the temperature text box
            tempTextBox.Clear();
            // Set the value of the date time picker to the current date and time
            dateTimePicker.Value = DateTime.Now;

        }
        // Event handler for when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
             
                // Declare a StreamReader variable
                StreamReader inputFile;

                //open the file and get the streamReader object
                inputFile = File.OpenText("Weather.txt");

                //Read the file's contents
                while (!inputFile.EndOfStream)
                {
                    // Read a line from the file
                    String line = inputFile.ReadLine();
                    // Split the line into parts separated by spaces, removing empty entries
                    string[] parts = line.Split(new char[] {'\t'}, StringSplitOptions.RemoveEmptyEntries);
                    // Extract the date, city, state, and temperature from the parts
                    string date = parts[0].Trim();
                    string city = parts[1].Trim();
                    string state = parts[2].Trim();
                    string temp = parts[3].Replace("F", "").Trim();

                    string tempF = temp + "F";

                    // Create a formatted string with weather information
                    string completeWeatherInformation = $"{date,-20}\t{city,-20}\t{state,-10}\t{tempF,-10}";


                    // Add the formatted weather information to the list box
                    outputListBox.Items.Add(completeWeatherInformation);


                }
                // Close the file after reading
                inputFile.Close();
                CalculateAverageTemperatures();

            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show(ex.Message);
            }


            // Re-Calculate average temperatures
            //CalculateAverageTemperatures();
        }
        // Event handler for the remove all button click
        private void removeAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the list Box
                outputListBox.Items.Clear();
               

                // check if the file exists
                if (File.Exists("Weather.txt"))
                {
                    //delete the file
                    File.Delete("Weather.txt");
                    MessageBox.Show("All records removed");
                }

            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show(ex.Message);
            }

            // Re-Calculate average temperatures
            CalculateAverageTemperatures();

        }
        // Event handler for the remove record button click
        private void removeRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any item is selected
                if (outputListBox.SelectedItem != null)
                {
                    // Get the selected item
                    string selectedWeatherInformation = outputListBox.SelectedItem.ToString();

                    // Remove the selected item from the ListBox
                    outputListBox.Items.Remove(selectedWeatherInformation);

                    // Read all lines from the file "Weather.txt" into an array
                    string[] lines = File.ReadAllLines("Weather.txt");
                    // Create a list to store updated lines
                    List<string> updatedLines = new List<string>();

                    // Iterate through each line in the file
                    foreach (string line in lines)
                    {
                        // Check if the line does not matches the selected item
                        if (line.Trim() != selectedWeatherInformation.Trim())
                        {
                            // Add the line to the list of updated lines
                            updatedLines.Add(line);
                        }
                    }

                    // Write updated lines back to the file
                    File.WriteAllLines("Weather.txt", updatedLines);
 
                   
                }
                else
                {// no selection made message
                    MessageBox.Show("Please select an item to remove.");
                }
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show(ex.Message);
            }
            // Re-Calculate average temperatures
            CalculateAverageTemperatures();

        }

        // Event handler for the close button click
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
        // Event handler for the lowest temperature button click
        private void lowestTempButton_Click(object sender, EventArgs e)
        {
            // Clear any previously selected item in the outputListBox
            outputListBox.ClearSelected();

            // Initialize a variable to store the lowest temperature found
            double lowestTemperature = double.MaxValue;
            // Initialize a list to store the indices of items with the lowest temperature
            List<int> lowestIndices = new List<int>();

            // Loop through each item in the outputListBox
            for (int i = 0; i < outputListBox.Items.Count; i++)
            {
                // Get the current item as a string
                string item = outputListBox.Items[i].ToString();
                // Split the item into parts based on tab delimiter
                string[] parts = item.Split('\t');
                // Extract the temperature part and remove any extra characters
                string tempP = parts[3].Trim();
                string tempPart = tempP.Trim('F');


                double temp;
                // parse the tempPart into double
                if (double.TryParse(tempPart, out temp))
                {
                    // If the parsed temperature is less than the lowestTemperature
                    if (temp < lowestTemperature)
                    {
                        // store temp in a lowestTemperature
                        lowestTemperature = temp;
                        // Clear the list of lowest indices
                        lowestIndices.Clear();
                        // add the current index
                        lowestIndices.Add(i);
                    }
                    // If the parsed temperature is equal to the lowestTemperature
                    else if (temp == lowestTemperature)
                    {
                        // Add the current index to the list of lowest indices
                        lowestIndices.Add(i);
                    }
                }
            }
            // Loop through each index in the list of lowest indices
            foreach (int index in lowestIndices)
            {
                // Set the corresponding item in the outputListBox as selected
                outputListBox.SetSelected(index, true);
            }


        }



        // Event handler for the highest temperature button click
        private void highestTempButton_Click_1(object sender, EventArgs e)
        {

            //clear any previsiouly selected item
            outputListBox.ClearSelected();


            //initialize a variable to store the highest temperature found
            double highestTemperature = double.MinValue;
            // Initialize a list to store the indices of items with the highest temperature
            List<int> maxIndices = new List<int>();

            //loop through each item in the listbox
            for (int i = 0; i < outputListBox.Items.Count; i++)
            {
                // get the current item as a string
                string item = outputListBox.Items[i].ToString();
                // Split the item into parts based on tab delimiter
                string[] parts = item.Split('\t');
                //  Extract the temperature part and remove any extra characters
                string tempP = parts[3].Trim();
                string temPart = tempP.Trim('F');

                double temp;
                //parse into double
                if (double.TryParse(temPart, out temp))
                {
                    // If the parsed temperature is greater than the highestTemperature
                    if (temp > highestTemperature)
                    {
                        // store it in a highest temperature
                        highestTemperature = temp;
                        // Clear the list of max indices 
                        maxIndices.Clear();
                        //add the current index
                        maxIndices.Add(i);
                    }
                    // If the parsed temperature is equal to the highestTemperature
                    else if (temp == highestTemperature)
                    {
                        // Add the current index to the list of max indices
                        maxIndices.Add(i);
                    }
                }
            }
            // Loop through each index in the list of max indices
            foreach (int index in maxIndices)
            {
                // Set the corresponding item in the outputListBox as selected
                outputListBox.SetSelected(index, true);
            }

        }
        // Event handler for the edit button click
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any item is selected
                if (outputListBox.SelectedItem != null)
                {
                    // Get the selected item as string
                    string selectedWeatherInformation = outputListBox.SelectedItem.ToString();

                    // Split the selected item into parts
                    string[] parts = selectedWeatherInformation.Split(new char[]{'\t'}, StringSplitOptions.RemoveEmptyEntries);

                    // Extract the date, city, state, and temperature
                    string date = parts[0].Trim();
                    string city = parts[1].Trim();
                    string state = parts[2].Trim();
                    string temp = parts[3].Trim();

                    // Display the information of the selected item in the corresponding text boxes
                   // dateTimePicker.Text = date;
                    cityTextBox.Text = city;
                    stateComboBox.Text = state;
                    tempTextBox.Text = temp.Trim('F');

                    // Show the save edit button and hide the add button
                    saveEditbutton.Visible = true;
                    addButton.Visible = false;
                }
                else
                {
                    // Show a message if no item is selected
                    MessageBox.Show("Please select an item to edit.");
                }
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show(ex.Message);
            }

        }
        // Event handler for the save edit button click
        private void saveEditbutton_Click(object sender, EventArgs e)
        {
            try
            {

                string tempP = tempTextBox.Text + " F";
                // Combine the edited information into a string
                string editedWeatherInformation = $"{dateTimePicker.Text,-20}\t{cityTextBox.Text,-20}\t{stateComboBox.Text,-10}\t{tempP,-10}";

                // Get the index of the selected item
                int selectedIndex = outputListBox.SelectedIndex;

                // Update the item in the list box
                outputListBox.Items[selectedIndex] = editedWeatherInformation;

                // Read all lines from the text file
                string[] lines = File.ReadAllLines("Weather.txt");

                // Update the corresponding line in the text file
                lines[selectedIndex] = editedWeatherInformation;

                // Write updated lines back to the file
                File.WriteAllLines("Weather.txt", lines);

                // Hide the save edit button and show the add button
                saveEditbutton.Visible = false;
                addButton.Visible = true;

                // Show a message indicating successful saving of changes
                MessageBox.Show("Changes saved successfully.");

                // Clear the text in the city text box
                cityTextBox.Clear();
                // Set the selected index of the state combo box to -1 (no selection)
                stateComboBox.SelectedIndex = -1;
                // Clear the text in the temperature text box
                tempTextBox.Clear();
                // Set the value of the date time picker to the current date and time
                dateTimePicker.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show(ex.Message);
            }

            // Re-Calculate average temperatures
            CalculateAverageTemperatures();
        }
        // Event handler for the search record button click
        private void SearchRecordButton_Click(object sender, EventArgs e)
        {

            // Get the state to search for from the textbox 
            string stateToSearch = searchTextbox.Text;

            // If the state to search for is not empty
            if (!string.IsNullOrWhiteSpace(stateToSearch))
            {
               // Convert the search query to uppercase for case-insensitive comparison
                stateToSearch = stateToSearch.ToUpper();
                // Clear any previous selections
                outputListBox.ClearSelected();

                // Iterate through each item in the list box
                for (int i = 0; i < outputListBox.Items.Count; i++)
                {
                    // Get the current item as a string, convert to uppercase
                    string item = outputListBox.Items[i].ToString().ToUpper();

                    // Check if the item contains the state to search for
                    if (item.Contains(stateToSearch))
                    {
                        // Highlight the item by selecting it
                        outputListBox.SetSelected(i, true);
                    }
                }
                // CLear the textbox
                searchTextbox.Clear();

                // If no items were found, display a message
                if (outputListBox.SelectedItems.Count == 0)
                {
                    MessageBox.Show($"No records found for state '{stateToSearch}'.");
                }
            }
            else
            {
                // Show a message if no state is entered to search for
                MessageBox.Show("Please enter a state to search for.");
            }
        }

        private void CalculateAverageTemperatures()
        {
            // Dictionary to store total temperature and count of occurrences for each state
            Dictionary<string, Tuple<double, int>> stateData = new Dictionary<string, Tuple<double, int>>();

            // Iterate through the items in the outputListBox
            foreach (var item in outputListBox.Items)
            {
                // split the item string by tab character
                string[] parts = item.ToString().Split('\t');
                //get the state from the item and trim
                string state = parts[2].Trim();
                double temperature;

                // parse the temperature value from the split parts of the current item string     
                if (double.TryParse(parts[3].Replace("F", "").Trim(), out temperature))
                {

                    //check if the state is already present in the stateData Dictionary
                    if (stateData.ContainsKey(state))
                    {
                        //retrieve the tuple associated with the current state  
                        var stateTuple = stateData[state];

                        // Updates the stateData dictionary with the new total temperature and count of occurrences for the current state
                        stateData[state] = Tuple.Create(stateTuple.Item1 + temperature, stateTuple.Item2 + 1);
                    }
                    else
                    {
                        // Initializes the stateData dictionary with the temperature and count of occurrences for the current state.
                        stateData[state] = Tuple.Create(temperature, 1);
                    }
                }
            }

            // Variable to store the total temperature of the entire Midwest region
            double totalRegionTemperature = 0;
            //Variable to count the number of labels representing each state's average temperature
            int regionLabelCount = 0;

            // iterate through each entry in the stateData dictionary
            foreach (var stateEntry in stateData)
            {
                // Retrieves the state from the dictionary entry
                string state = stateEntry.Key;
                // Retrievves the total temperature for the state
                double totalTemperature = stateEntry.Value.Item1;
                //Retrieve the count of occurance for the state
                int count = stateEntry.Value.Item2;

                // calculate the average temperature for the state
                double averageTemperature = totalTemperature / count;

                // Find the label associated with the current state in the averageTemperatureGroupBox controls
                Label stateLabel = AverageTempGroupBox.Controls.Find($"{state.ToLower()}AverageLabel", true).FirstOrDefault() as Label;

                // check if the labels for the state is found
                if (stateLabel != null)
                {
                    // Updates the text of the state label to display the average temperature if there are data.
                    stateLabel.Text = count > 0 ? $" {averageTemperature:F2} °F" : "";
                    // Increments the regionLabelCount indicating that a label representing state's average temperature is found
                    regionLabelCount++;
                    // Accumulates the total temperature of the entire Midwest region.
                    totalRegionTemperature += averageTemperature;
                }
            }

            // Iterates through each label in the averageTemperatureGroupBox.
            foreach (Label label in AverageTempGroupBox.Controls.OfType<Label>())
            {
                // Checks if the label represents the average temperature of a state and if there's no corresponding data in the outputListBox.
                if (label.Name.EndsWith("AverageLabel") && !stateData.ContainsKey(label.Name.Replace("AverageLabel", "").ToUpper()))
                {
                    // Resets the text of the label to empty
                    label.Text = "";
                }
            }

            // Checks if there are labels representing state's average temperature found.
            if (regionLabelCount > 0)
            {
                // Calculates the average temperature for the entire Midwest region.
                double regionAverageTemperature = totalRegionTemperature / stateData.Count;

                // Finds the label for the region average in the averageTemperatureGroupBox controls
                Label regionLabel = AverageTempGroupBox.Controls.Find("regionAverageLabel", true).FirstOrDefault() as Label;

                // Checks if the label for the region average is found.
                if (regionLabel != null)
                {
                    // Updates the text of the region average label to display the calculated average temperature.
                    regionLabel.Text = $" {regionAverageTemperature:F2} °F";
                    // Sets the visibility of the region average label to true.
                    regionLabel.Visible = true;
                }
            }
            // Selects only labels representing state's average temperature.
            // Checks if all labels representing state's average temperature are empty.
            bool allAverageLabelsEmpty = AverageTempGroupBox.Controls.OfType<Label>()
                .Where(label => label.Name.EndsWith("AverageLabel")) // Select only average labels
                .All(label => string.IsNullOrEmpty(label.Text));
            // Shows/hides the averageTemperatureGroupBox based on whether all state average labels are empty or not.
            AverageTempGroupBox.Visible = !allAverageLabelsEmpty;
        }





    }
}


