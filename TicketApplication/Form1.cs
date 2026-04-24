using System.Globalization;

namespace TicketApplication
{
    public partial class Form1 : Form
    {
        public class TicketCalculator
        {
            //Thandolwenkosi Gama - 20240351
            // Constant pricing rates
            private const decimal PriceCatOne = 20m;
            private const decimal PriceCatTwo = 35m;
            private const decimal PriceCatThree = 50m;

            public static decimal CalculatePrice(int age, int distance, string category, bool isFemale)
            {
                //Thandolwenkosi Gama - 20240351
                // Rule 1: If Age is smaller than 12 , ticket is free
                if (age < 12) return 0m;

                // Calculate base price based on category
                decimal price = 0m;
                
                switch (category)
                {
                    case "One - R20 per km": price = distance * PriceCatOne; break;
                    case "Two - R35 per km": price = distance * PriceCatTwo; break;
                    case "Three - R50 per km": price = distance * PriceCatThree; break;
                }

                // Rule 2: If user is a female , they get a 50% discount
                if (isFemale)
                {
                    price *= 0.50m;
                }

                return price;
            }
        }
        private bool IsInputValid(string ageText, string distanceText, out int age, out int distance)
        {
            //Thandolwenkosi Gama - 20240351
            // 1. Try to parse inputs to integers
            bool isAgeValid = int.TryParse(ageText, out age);
            bool isDistanceValid = int.TryParse(distanceText, out distance);

            // 2. Check parsing success and logical ranges (Age/Distance cannot be negative)
            if (!isAgeValid || age < 0 || age > 100)
            {
                MessageBox.Show("Please enter a valid age (0-100).", "Input Error");
                return false;
            }

            if (!isDistanceValid || distance <= 0)
            {
                MessageBox.Show("Please enter a valid positive distance.", "Input Error");
                return false;
            }

            return true;
        }
        private void ResetForm()
        {
            //Thandolwenkosi Gama - 20240351
            // 1. Clear textboxes
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtDistance.Text = string.Empty;

            // 2. uncheck radio buttons
            rbMale.Checked = false;
            rbFemale.Checked = false;

            // 3. Clear combo box selection
            cmbCategory.SelectedIndex = -1;

            //4. Clear listbox output
            lbOutput.Items.Clear();

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Thandolwenkosi Gama - 20240351
            // Ask for confirmation before exiting
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Thandolwenkosi Gama - 20240351
            ResetForm();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Thandolwenkosi Gama - 20240351
            // Validate inputs using the helper method
            if (!IsInputValid(txtAge.Text, txtDistance.Text, out int age, out int distance))
            {
                return;
            }

            // Clear previous output so the new calculation is clean
            lbOutput.Items.Clear();

            bool isFemale = rbFemale.Checked;
            string category = cmbCategory.Text;
           

            decimal finalPrice = TicketCalculator.CalculatePrice(age, distance, category, isFemale);

            // Display Result
            lbOutput.Items.Add($"Passenger: {txtName.Text}");
            lbOutput.Items.Add($"Age: {age}"); 
            lbOutput.Items.Add($"Gender: {(isFemale ? "Female" : "Male")}");
            lbOutput.Items.Add($"Category: {category}");
            lbOutput.Items.Add($"Distance: {distance} km");
            lbOutput.Items.Add($"Final Price: {finalPrice.ToString("C", new CultureInfo("en-ZA"))}"); // forces automatically format to local currency (R)

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
