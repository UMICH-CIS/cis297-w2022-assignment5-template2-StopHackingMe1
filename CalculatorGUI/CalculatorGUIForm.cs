using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/// <summary>
/// This program implements some arithmetic functions as a calculator except in a windows form with buttons for each function
/// </summary>
/// <Student> Aaron Willis </Student>
/// <Class>CIS297</Class>
/// <Semester>Winter 2022</Semester>

namespace CalculatorGUI
{
   public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
         InitializeComponent();
      }
          /// <summary>
          /// This function removes the space when a string is passed within the textbox
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void removeSpaceButton_Click(object sender, EventArgs e)
          {
               resultTextBox.Text = removeSpaceTextBox.Text.Replace(" ", "");
          }

          /// <summary>
          /// This function reverses a string when it is passed through within a textbox
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void reverseWordButton_Click(object sender, EventArgs e)
          {
               char[] charArray = reverseWordTextBox.Text.ToCharArray();
               Array.Reverse(charArray);
               resultTextBox.Text = String.Concat(charArray);
          }

          /// <summary>
          /// This function gives the remainder after division. Input is passed through the text boxes and the button must be pressed
          /// after input
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void button13_Click(object sender, EventArgs e)
          {
               int divisor = int.Parse(divisorTextBox.Text);
               int dividend = int.Parse(dividendTextBox.Text);
               int remainder;

               int quotient = Math.DivRem(dividend, divisor, out remainder);

               string resultMessage = divisor.ToString() + " divided by " + dividend.ToString() + " is " + quotient.ToString() + " remainder " + remainder.ToString();

               resultTextBox.Text = resultMessage;
          }

          /// <summary>
          /// This function finds the log of a number to base 10. The input is passed through a text box
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void LogBase10Button_Click(object sender, EventArgs e)
          {
               int logNumber = int.Parse(logBase10TextBox.Text);
               double result =  Math.Log10(logNumber);

               string resultMessage = logNumber.ToString() + " to the base 10 is " + result.ToString();
               resultTextBox.Text = resultMessage;
          }

          /// <summary>
          /// This function does the same as above except the base is chosen by the user and taken from input
          /// through the text box
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void logToChosenBaseButton_Click(object sender, EventArgs e)
          {
               int logNumber = int.Parse(chosenNumberTextBox.Text);
               int logBase = int.Parse(chosenBaseTextBox.Text);
               double result = Math.Log(logNumber, logBase);

               string resultMessage = logNumber.ToString() + " to the base " + logBase.ToString() + " is " + result.ToString();
               resultTextBox.Text = resultMessage;
          }

          /// <summary>
          /// This function finds the min and max of two numbers through user input from text boxes
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>

          private void minAndMaxButton_Click(object sender, EventArgs e)
          {
               int firstNumber = int.Parse(minAndMaxTextBox1.Text);
               int secondNumber = int.Parse(minAndMaxTextBox2.Text);

               int min = Math.Min(firstNumber, secondNumber);
               int max = Math.Max(firstNumber, secondNumber);

               string resultMessage = "The min number is " + min.ToString() + " and the max is " + max.ToString();
               resultTextBox.Text = resultMessage;
          }

          /// <summary>
          /// This function takes a number and a power from user input through text boxes and takes that number to the
          /// specified power
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>

          private void numberToPowerButton_Click(object sender, EventArgs e)
          {
               int baseNumber = int.Parse(numToPowerBaseTextBox.Text);
               int power = int.Parse(numToPowerPowerTextBox.Text);

               double result = Math.Pow(baseNumber, power);

               string resultMessage = baseNumber.ToString() + " to the power " + power.ToString() + " is " + result.ToString();
               resultTextBox.Text = resultMessage;
          }

          /// <summary>
          /// This class is used in order to find the roots of a quadratic equation
          /// </summary>
          class QuadraticEquation1
          {
               int A;
               int B;
               int C;
               double Discriminant;
               double X1;
               double X2;
               Boolean status = true;
               /// <summary>
               /// 
               /// </summary>
               /// <param name="a"></param>
               /// <param name="b"></param>
               /// <param name="c"></param>
               public QuadraticEquation1(int a, int b, int c)
               {
                    this.A = a;
                    this.B = b;
                    this.C = c;
               }
               public double ComputeDisc()
               {
                    Discriminant = Math.Pow(B, 2) - 4 * A * C;
                    return Discriminant;
               }

               public void ComputeSolution()
               {
                    if (Discriminant == 0)
                    {
                         X1 = -B / (2 * A);
                         X2 = X1;
                    }
                    else if (Discriminant > 0)
                    {
                         X1 = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                         X2 = (-B - Math.Sqrt(Discriminant)) / (2 * A);
                    }
                    else
                    {
                         status = false;
                    }
               }
               public string DisplaySolution()
               {
                    //Console.WriteLine($"Quadratic Equation with  A: {0}   B: {1}  C: {2}", A, B, C);
                    if (status)
                    {
                         if (X1 == X2)
                         {

                              string result;
                              string root1 = X1.ToString();
                              result = "The equation has one root: " + root1;
                              return result;
                         }
                         else
                         {
                              string result;
                              string root1 = X1.ToString();
                              string root2 = X2.ToString();

                              result = "Root X1 = " + root1 + ", Root X2 = " + root2;
                              return result;
                         }
                    }
                    else
                    {
                         return "There are no roots that exist";
                    }

               }

          }

          /// <summary>
          /// This function finds the roots of a quadratic equation after given the coefficients and constants from user input
          /// through text boxes
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void findRootsButton_Click(object sender, EventArgs e)
          {
               int coefficientA = int.Parse(coefficientATextBox.Text);
               int coefficientB = int.Parse(CoefficientBTextBox.Text);
               int constant = int.Parse(constantTextBox.Text);

               QuadraticEquation1 object1 = new QuadraticEquation1(coefficientA, coefficientB, constant);
               object1.ComputeDisc();
               object1.ComputeSolution();
               resultTextBox.Text =  object1.DisplaySolution();

               
          }
          /// <summary>
          /// This function finds the square root of a number given through user input within the text box
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void squareRootButton_Click(object sender, EventArgs e)
          {
               double userNumber = double.Parse(squareRootTextBox.Text);
               double result = Math.Sqrt(userNumber);

               resultTextBox.Text = "The square root of " + userNumber.ToString() + " is " + result.ToString();

          }

          /// <summary>
          /// This function closes the program
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>

          private void exitButton_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/