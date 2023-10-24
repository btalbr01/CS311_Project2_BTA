namespace CS311_Project2_BTA
{
    public partial class frmCraps : Form
    {
        //Creates variables to track roll count, the point and balance.
        //Starts balance at $100.00. Uses parseTest and parseBool to check for valid input.
        int rollCount = 0;
        int point = 0;
        float balance = 100;
        float parseTest = 0;
        bool parseBool;

        public frmCraps()
        {
            InitializeComponent();
        }//end frmCraps

        private void calculate_score()
        {
            //Creates 2 random numbers between 1-6 to simulate die rolls.
            Random rnd = new Random();
            int roll1 = rnd.Next(6) + 1;
            int roll2 = rnd.Next(6) + 1;

            //Takes the bet from the user.
            float bet = float.Parse(txtBet.Text);

            //Displays the roll of both dice and increments the roll count.
            lblRoll1.Text = roll1.ToString();
            lblRoll2.Text = roll2.ToString();
            rollCount++;

            //Checks if a roll of 7 or 11 is made on the first roll.
            if (rollCount == 1 && roll1 + roll2 == 7 ||
                roll1 + roll2 == 11 && rollCount == 1)
            {
                //Outputs win text, resets roll count and point,
                //updates balance and outputs to lblBalance as a dollar amount.
                lblWinLosePoint.Text = "You win!";
                rollCount = 0;
                point = 0;
                balance = balance + bet;
                lblBalance.Text = balance.ToString("C");
            }//end if

            //Checks if roll matches the point and the roll is not 7.
            //Outputs win text, resets roll count and point,
            //updates balance and outputs to lblBalance as a dollar amount.
            if (roll1 + roll2 == point && point != 7)
            {
                lblWinLosePoint.Text = "You win!";
                rollCount = 0;
                point = 0;
                balance = balance + bet;
                lblBalance.Text = balance.ToString("C");
            }//end if

            //Checks if a roll of 2, 3 or 12 is made on the first roll
            //Outputs loss text, resets roll count and point,
            //updates balance and outputs to lblBalance as a dollar amount.
            if (rollCount == 1 && roll1 + roll2 == 2 || rollCount == 1 && roll1 + roll2 == 3
                || rollCount == 1 && roll1 + roll2 == 12)
            {
                lblWinLosePoint.Text = "You lose!";
                rollCount = 0;
                point = 0;
                balance = balance - bet;
                lblBalance.Text = balance.ToString("C");
            }//end if

            //Checks if roll is not a win or lose and sets as point.
            //Outputs to lblWinLosePoint.
            if (roll1 + roll2 != 2 && roll1 + roll2 != 3 &&
                roll1 + roll2 != 12 && roll1 + roll2 != 7 &&
                roll1 + roll2 != 11 && rollCount == 1)
            {
                point = roll1 + roll2;

                if (rollCount == 1)
                {
                    lblWinLosePoint.Text = "Point is " + point;
                }//end if
            }//end if

            //Checks for a roll of 7 after first roll. 
            //If true outputs loss text, resets roll count and point,
            //updates balance and outputs to lblBalance as a dollar amount.
            if (roll1 + roll2 == 7 && rollCount > 1)
            {
                lblWinLosePoint.Text = "You lose!";
                rollCount = 0;
                point = 0;
                balance = balance - bet;
                lblBalance.Text = balance.ToString("C");
            }//end if
        }//end calculate_score

        private void btnRoll_Click(object sender, EventArgs e)
        {
            parseBool = float.TryParse(txtBet.Text, out parseTest);
            //Checks if txtBet is a valid input. If true, prompts user to input a bet.
            if (!parseBool)
            {
                MessageBox.Show("Please enter a valid bet");
            }//end if

            //Calls calculate_score if txtBet is not blank and 
            //there is enough money in the bank for the bet.
            else if (txtBet.Text != "" && float.Parse(txtBet.Text) <= balance)

                calculate_score(); //end if
            //If there is not enough money in the bank, notifies user.
            else if (float.Parse(txtBet.Text) > balance)
                MessageBox.Show("Not enough money in the bank!"); // end else if
        }//end btnRoll_Click
    }//end frmCraps
}