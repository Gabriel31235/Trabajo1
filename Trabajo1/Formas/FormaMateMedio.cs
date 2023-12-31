﻿using System;
using System.Windows.Forms;

namespace Trabajo1.Formas
{
    public partial class FormaMateMedio : Form
    {


        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;



        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;

        public FormaMateMedio()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(200);
            addend2 = randomizer.Next(200);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            Sum.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(12, 24);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            Restar.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(12, 24);
            multiplier = randomizer.Next(12, 24);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            Multiplicar.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(12, 24);
            int temporaryQuotient = randomizer.Next(12, 24);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            Dividir.Value = 0;

            // Start the timer.
            timeLeft = 60;
            TimeLabel.Text = "60 seconds";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == Sum.Value)
                && (minuend - subtrahend == Restar.Value)
                && (multiplicand * multiplier == Multiplicar.Value)
                && (dividend / divisor == Dividir.Value))
                return true;
            else
                return false;
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                if (CheckTheAnswer())
                {
                    // If CheckTheAnswer() returns true, then the user 
                    // got the answer right. Stop the timer  
                    // and show a MessageBox.
                    timer1.Stop();
                    MessageBox.Show("Tienes todas las respuestas correctas!",
                                    "Felicidades!");
                    startButton.Enabled = true;
                }
                else if (timeLeft > 0)
                {
                    // If CheckTheAnswer() returns false, keep counting
                    // down. Decrease the time left by one second and 
                    // display the new time left by updating the 
                    // Time Left label.
                    timeLeft = timeLeft - 1;
                    TimeLabel.Text = timeLeft + " Segundos";
                }
                else
                {
                    // If the user ran out of time, stop the timer, show
                    // a MessageBox, and fill in the answers.
                    timer1.Stop();
                    TimeLabel.Text = "Tiempo!";
                    MessageBox.Show("No completaste el Quiz.", "Intentalo de nuevo!");
                    Sum.Value = addend1 + addend2;
                    Restar.Value = minuend - subtrahend;
                    Multiplicar.Value = multiplicand * multiplier;
                    Dividir.Value = dividend / divisor;
                    startButton.Enabled = true;
                }
            }

        }

        private void answer_Enter(object sender, EventArgs e)
        {

            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetQuiz();
        }
        private void ResetQuiz()
        {
            // Reinicia todas las variables del quiz
            addend1 = 0;
            addend2 = 0;
            minuend = 0;
            subtrahend = 0;
            multiplicand = 0;
            multiplier = 0;
            dividend = 0;
            divisor = 0;
            timeLeft = 0;

            // Reinicia los controles de la interfaz de usuario
            plusLeftLabel.Text = "?";
            plusRightLabel.Text = "?";
            Sum.Value = 0;
            minusLeftLabel.Text = "?";
            minusRightLabel.Text = "?";
            Restar.Value = 0;
            timesLeftLabel.Text = "?";
            timesRightLabel.Text = "?";
            Multiplicar.Value = 0;
            dividedLeftLabel.Text = "?";
            dividedRightLabel.Text = "?";
            Dividir.Value = 0;
            TimeLabel.Text = "30 seconds";

            // Detiene el temporizador si está en funcionamiento
            timer1.Stop();

            // Habilita el botón de inicio
            startButton.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Dividir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dividedRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void dividedLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void Multiplicar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timesRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void timesLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void Restar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void minusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void minusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void Sum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
