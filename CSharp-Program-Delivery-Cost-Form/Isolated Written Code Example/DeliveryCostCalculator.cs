// Lab 
// CIS 199-01
// Due: 10/15/2020
// By: R1466

// This program creates a form to accept shipping details such as mile, weight, and delivery days.
// Form uses nested if statements to calculate and display shipping costs for three companies, then outputs which shipping cost is lowest.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class DeliveryCostCalculator : Form
    {
        // Variables
        private bool validInput;    // Boolean variable to hold if TryParse was successful.
        private int days;           // Holds input for delivery days in form. Must be an integer. Used in individual companies cost calculation.
        private double weight,      // Holds input for package weight in form. Could be fractional. Used in individual companies cost calculation.
        miles,                      // Holds input for miles traveled in form. Could be fractional. Used in individual companies cost calculation.
        aCost,                      // Holds calculation for Company A's delivery cost. Used for output and in if statement to determine lowest cost.
        bCost,                      // Holds calculation for Company B's delivery cost. Used for output and in if statement to determine lowest cost.
        cCost;                      // Holds calculation for Company C's delivery cost. Used for output and in if statement to determine lowest cost.

        public DeliveryCostCalculator()
        {
            InitializeComponent();
        }

        // Event that triggers upon activation of calcButton.
        // This event uses a series of nested if statements to calculate and display shipping costs for three companies.
        // Input is validated with TryParse, costs are calculated, displayed, and lowest cost company is displayed.
        private void calcButton_Click(object sender, EventArgs e)
        {
            // Constant Variables
            const int VALID_INPUT_FLOOR = 0;            // Constant to test if inputs are above 0.

            const double A_MILE_RATE = 0.02;            // Company A's mile rate of $0.02 per.
            const int A_WEIGHT_RATE = 1;                // Company A's weight rate of $1 per lb.
            const int A_DAY_RATE_1 = 20;                // Company A's flat rate for 1 day delivery.
            const int A_DAY_RATE_2 = 17;                // Company A's flat rate for 2 day delivery.
            const int A_DAY_RATE_3 = 15;                // Company A's flat rate for 3 day delivery.
            const int A_DAY_RATE_4_6 = 10;              // Company A's flat rate for 4-6 day delivery.
            const int A_DAY_RATE_7 = 7;                 // Company A's flat rate for 7+ day delivery.
            const int A_DAY_7 = 7;                      // Constant to test if Company A's 7+ day delivery applies.
            const int A_DAY_4_6 = 1;                    // Constant to test if Company A's 4-6 day delivery applies.
            const int A_DAY_3 = 3;                      // Constant to test if Company A's 3 day delivery applies.
            const int A_DAY_2 = 2;                      // Constant to test if Company A's 2 day delivery applies. If all tests fail, 1 day delivery applies.


            const double B_MILE_RATE = 0.1;             // Company B's mile rate of $0.02 per.
            const int B_DAY_RATE_1_3 = 10;              // Company B's flat rate for 1-3 day delivery.
            const int B_DAY_RATE_4 = 7;                 // Company B's flat rate for 4+ day delivery.
            const int B_DAY_4 = 4;                      // Constant to test if Company B's 4+ day delivery applies. If test fails, 1-3 day delivery applies.
            const int B_WEIGHT_RATE_UP_TO_10 = 3;       // Company B's flat rate for weight under 10 lbs.
            const int B_WEIGHT_RATE_UP_TO_50 = 5;       // Company B's flat rate for weight 10 to up to 50 lbs.
            const int B_WEIGHT_RATE_UP_TO_100 = 10;     // Company B's flat rate for weight 50 to up to 100 lbs.
            const int B_WEIGHT_RATE_UP_TO_200 = 20;     // Company B's flat rate for weight 100 to up to 200 lbs.
            const double B_WEIGHT_RATE_200 = 0.15;      // Company B's rate for weight 200 lbs and up.
            const int B_WEIGHT_200 = 200;               // Constant to test if Company B's 200+ weight rate applies.
            const int B_WEIGHT_UP_TO_200 = 100;         // Constant to test if Company B's 100 to up to 200 lbs weight rate applies.
            const int B_WEIGHT_UP_TO_100 = 50;          // Constant to test if Company B's 50 to up to 100 lbs weight rate applies.
            const int B_WEIGHT_UP_TO_50 = 10;           // Constant to test if Company B's 10 to up to 50 lbs weight rate applies. If all tests fail, under 10 lbs weight rate applies.

            const double C_WEIGHT_RATE = 0.25;          // Company C's weight rate of $0.25 per lb.
            const int C_DAY_RATE = 20;                  // Company C's flat rate for delivery of any day amount.
            const int C_MILE_RATE_UP_TO_200 = 10;       // Company C's flat rate for miles under 200.
            const int C_MILE_RATE_UP_TO_500 = 15;       // Company C's flat rate for miles 200 up to 500.
            const int C_MILE_RATE_UP_TO_750 = 25;       // Company C's flat rate for miles 500 up to 750.
            const int C_MILE_RATE_UP_TO_1000 = 35;      // Company C's flat rate for miles 750 up to 1000.
            const int C_MILE_RATE_1000 = 40;            // Company C's flat rate for miles 1000 and above.
            const int C_MILE_1000 = 1000;               // Constant to test if Company C's 1000+ mile rate applies.
            const int C_MILE_UP_TO_1000 = 750;          // Constant to test if Company C's 750 up to 1000 mile rate applies.
            const int C_MILE_UP_TO_750 = 500;           // Constant to test if Company C's 500 up to 750 mile rate applies.
            const int C_MILE_UP_TO_500 = 200;           // Constant to test if Company C's 200 up to 500 mile rate applies. If all tests fail, under 200 mile rate applies.


            // TryParse for valid inputs.
            if (int.TryParse(daysTxtBox.Text, out days) && days > VALID_INPUT_FLOOR)                    // Checks if days input is an integer and is above 0.
                if (double.TryParse(distTxtBox.Text, out miles) && miles > VALID_INPUT_FLOOR)           // Checks if miles input is a double and is above 0.
                    if (double.TryParse(weightTxtBox.Text, out weight) && weight > VALID_INPUT_FLOOR)   // Checks if weight input is a double and is above 0.
                        validInput = true;                      // True if all TryParse tests are passed. Used to trigger rest of if statements
                    else
                        MessageBox.Show("Invalid Weight.");     // Shows error message if weight input is not valid.
                else
                    MessageBox.Show("Invalid Distance.");       // Shows error message if miles input is not valid.
            else
                MessageBox.Show("Invalid Delivery Days.");      // Shows error message if days input is not valid.


            // Nested if statements to calculate and display cost for Company A.
            if (validInput == true)
            {
                if (days >= A_DAY_7)
                    aCost = (miles * A_MILE_RATE) + (weight * A_WEIGHT_RATE) + (A_DAY_RATE_7);
                else if (days >= A_DAY_4_6)
                    aCost = (miles * A_MILE_RATE) + (weight * A_WEIGHT_RATE) + (A_DAY_RATE_4_6);
                else if (days == A_DAY_3)
                    aCost = (miles * A_MILE_RATE) + (weight * A_WEIGHT_RATE) + (A_DAY_RATE_3);
                else if (days == A_DAY_2)
                    aCost = (miles * A_MILE_RATE) + (weight * A_WEIGHT_RATE) + (A_DAY_RATE_2);
                else
                    aCost = (miles * A_MILE_RATE) + (weight * A_WEIGHT_RATE) + (A_DAY_RATE_1);

                aCostOutputLbl.Text = $"{aCost.ToString("C")}";     // Outputs cost of Company A to label on form.
            }

            // Nested if statements to calculate and display cost for Company B.
            if (validInput == true)
            {
                if (days >= B_DAY_4)
                    if (weight >= B_WEIGHT_200)
                        bCost = (miles * B_MILE_RATE) + (weight * B_WEIGHT_RATE_200) + (B_DAY_RATE_4);
                    else if (weight >= B_WEIGHT_UP_TO_200)
                        bCost = (miles * B_MILE_RATE) + (B_WEIGHT_RATE_UP_TO_200) + (B_DAY_RATE_4);
                    else if (weight >= B_WEIGHT_UP_TO_100)
                        bCost = (miles * B_MILE_RATE) + (B_WEIGHT_RATE_UP_TO_100) + (B_DAY_RATE_4);
                    else if (weight >= B_WEIGHT_UP_TO_50)
                        bCost = (miles * B_MILE_RATE) + (B_WEIGHT_RATE_UP_TO_50) + (B_DAY_RATE_4);
                    else
                        bCost = (miles * B_MILE_RATE) + (B_WEIGHT_RATE_UP_TO_10) + (B_DAY_RATE_4);

                else
                    if (weight >= B_WEIGHT_200)
                        bCost = (miles * B_MILE_RATE) + (weight * B_WEIGHT_RATE_200) + (B_DAY_RATE_1_3);
                    else if (weight >= B_WEIGHT_UP_TO_200)
                        bCost = (miles * B_MILE_RATE) + (B_WEIGHT_RATE_UP_TO_200) + (B_DAY_RATE_1_3);
                    else if (weight >= B_WEIGHT_UP_TO_100)
                        bCost = (miles * B_MILE_RATE) + (B_WEIGHT_RATE_UP_TO_100) + (B_DAY_RATE_1_3);
                    else if (weight >= B_WEIGHT_UP_TO_50)
                        bCost = (miles * B_MILE_RATE) + (B_WEIGHT_RATE_UP_TO_50) + (B_DAY_RATE_1_3);
                    else
                        bCost = (miles * B_MILE_RATE) + (B_WEIGHT_RATE_UP_TO_10) + (B_DAY_RATE_1_3);

                bCostOutputLbl.Text = $"{bCost.ToString("C")}";     // Outputs cost of Company B to label on form.
            }

            // If statement to calculate and display cost for Company C.
            if (validInput == true)
            {
                if (miles >= C_MILE_1000)
                    cCost = (weight * C_WEIGHT_RATE) + (C_DAY_RATE) + (C_MILE_RATE_1000);
                else if (miles >= C_MILE_UP_TO_1000)
                    cCost = (weight * C_WEIGHT_RATE) + (C_DAY_RATE) + (C_MILE_RATE_UP_TO_1000);
                else if (miles >= C_MILE_UP_TO_750)
                    cCost = (weight * C_WEIGHT_RATE) + (C_DAY_RATE) + (C_MILE_RATE_UP_TO_750);
                else if (miles >= C_MILE_UP_TO_500)
                    cCost = (weight * C_WEIGHT_RATE) + (C_DAY_RATE) + (C_MILE_RATE_UP_TO_500);
                else
                    cCost = (weight * C_WEIGHT_RATE) + (C_DAY_RATE) + (C_MILE_RATE_UP_TO_200);

                cCostOutputLbl.Text = $"{cCost.ToString("C")}";     // Outputs cost of Company C to label on form.
            }

            // Nested if statment to caculate and display lowest cost company.
            if (validInput == true)
            {
                if ((aCost < bCost) && (aCost < cCost))
                    lowestCostOutputLbl.Text = "Company A";     // Outputs to label on form if Company A is lowest.
                else if ((bCost < aCost) && (bCost < cCost))
                    lowestCostOutputLbl.Text = "Company B";     // Outputs to label on form if Company B is lowest.
                else
                    lowestCostOutputLbl.Text = "Company C";     // Outputs to label on form if Company C is lowest.
            }
        }
    }
}
