/*
S2217
Program 2
Due Date: 03/11/2022
Course Section: CIS 199-03
Displays the cost of a hotel stay based on
the number of guests, duration of the stay,
and star rating of the hotel.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            const int LOWEST_GUEST = 100; //Constant for 1 guest fee
            const int LOW_GUEST = 150; //Constant for 2 guest fee
            const int HIGH_GUEST = 250; //Constant for 3 guest fee
            const int HIGHEST_GUEST = 400; //Constant for 4-7 guest fee
            const int DAILY_RATE = 100; //Constantt for 1-6 nights
            const int WEEKLY_RATE = 75; //Constant for 7-30 nights
            const int MONTHLY_RATE = 25; //Constant for 31+ nights
            const double ONE_STAR = 1; //One star multiplier
            const double TWO_STAR = 1.5; //Two star multiplier
            const double THREE_STAR = 2.5; //Three star multipler
            const double FOUR_STAR = 3; //Four star multiplier
            const double FIVE_STAR = 4; //Five star multiplier
            int numGuests; //Number of guests
            int numNights = 0; //Number of nights
            int numStars; //Number of stars
            double starCostFactor = 0; //Assigns star multiplier
            int guestFactor = 0; //Assigns guest fee
            int nightsFactor = 0; //Assigns night rate
            int nightCost = 0; //Cost per night
            double totalCost; //Total cost


            if (int.TryParse(numGuestsTextbox.Text, out numGuests) && numGuests >= 1 && numGuests <= 7) //TryParse for number of guests
            {
                if (int.TryParse(numNightsTextbox.Text, out numNights) && numNights >= 1) //TryParse for number of nights
                {
                    if (int.TryParse(numStarsTextbox.Text, out numStars) && numStars >= 1 && numStars <= 5) //TryParse for number of stars
                    {
                        if (numStars == 5) //Assigns a star multiplier based on how many stars were input
                            starCostFactor = FIVE_STAR;
                        else if (numStars == 4)
                            starCostFactor = FOUR_STAR;
                        else if (numStars == 3)
                            starCostFactor = THREE_STAR;
                        else if (numStars == 2)
                            starCostFactor = TWO_STAR;
                        else
                            starCostFactor = ONE_STAR;
                    }

                    else
                    {
                        MessageBox.Show("Number of stars not valid."); //Displays error message if TryParse fails, clears the textbox, and focuses it
                        numStarsTextbox.Clear();
                        numStarsTextbox.Focus();
                    }

                    if (numNights >= 31) //Assigns nightly rate based on how many nights were input
                        nightsFactor = MONTHLY_RATE;
                    else if (numNights <= 30 && numNights >= 7)
                        nightsFactor = WEEKLY_RATE;
                    else
                        nightsFactor = DAILY_RATE;
                }

                else
                {
                    MessageBox.Show("Number of nights not valid."); //Displays error message if TryParse fails, clears the textbox, and focuses it
                    numNightsTextbox.Clear();
                    numNightsTextbox.Focus();
                }

                if (numGuests <= 7 && numGuests >= 4) //Assigns a guest fee based on how many guests were input
                    guestFactor = HIGHEST_GUEST;
                else if (numGuests == 3)
                    guestFactor = HIGH_GUEST;
                else if (numGuests == 2)
                    guestFactor = LOW_GUEST;
                else
                    guestFactor = LOWEST_GUEST;
            }

            else
            {
                MessageBox.Show("Number of guests not valid."); //Displays error message if TryParse fails, clears the textbox, and focuses
                numGuestsTextbox.Clear();
                numGuestsTextbox.Focus();
            }

            nightCost = numNights * nightsFactor; //Finds and assigns the night cost amount
            totalCost = (nightCost + guestFactor) * starCostFactor; //Finds and assigns the total cost amount

            hotelCostOutput.Text = totalCost.ToString("C"); //Displays total cost
        }
    }
}
