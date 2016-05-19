using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// Project: Cramer's Calculator
// Date: 03/23/2016 09:54:19 pm
//
// I declare that the following code was written by me. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace CramerCalculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare some doubles
            double
                a11 = 0.0,
                a12 = 0.0,
                a13 = 0.0,
                a21 = 0.0,
                a22 = 0.0,
                a23 = 0.0,
                a31 = 0.0,
                a32 = 0.0,
                a33 = 0.0,
                b1 = 0.0,
                b2 = 0.0,
                b3 = 0.0,
                determinate = 0.0,
                determinateX = 0.0,
                determinateY = 0.0,
                determinateZ = 0.0,
                xAnswer = 0.0,
                yAnswer = 0.0,
                zAnswer = 0.0;


            //Declare some strings
            string
                x1 = "",
                x2 = "",
                x3 = "";

            //Display that the results are in
            txtResult.Text = "According to my Calculations:";

            //store user inputs from Matrix A in appropriate variables
            a11 = double.Parse(txtA11.Text);
            a12 = double.Parse(txtA12.Text);
            a13 = double.Parse(txtA13.Text);
            a21 = double.Parse(txtA21.Text);
            a22 = double.Parse(txtA22.Text);
            a23 = double.Parse(txtA23.Text);
            a31 = double.Parse(txtA31.Text);
            a32 = double.Parse(txtA32.Text);
            a33 = double.Parse(txtA33.Text);

            //Store user inputs from Matrix X in appropriate variables
            x1 = txtX1.Text;
            x2 = txtX2.Text;
            x3 = txtX3.Text;

            //Store user inputs from Matrix B in appropraite variables
            b1 = double.Parse(txtB1.Text);
            b2 = double.Parse(txtB2.Text);
            b3 = double.Parse(txtB3.Text);

            //Call our determinate calculator and store the value
            determinate = CalcDeterminate(a11, a12, a13, a21, a22, a23, a31, a32, a33);

            //Call determinateX meethod and store the value
            determinateX = CalcDeterminateX(b1, a12, a13, b2, a22, a23, b3, a32, a33);

            //Call determinateY method and store the value
            determinateY = CalcDeterminateY(a11, b1, a13, a21, b2, a23, a31, b3, a33);

            //Call determinateZ method and store the value
            determinateZ = CalcDeterminateZ(a11, a12, b1, a21, a22, b2, a31, a32, b3);

            //Solve for X
            xAnswer = determinateX / determinate;

            //Solve for Y
            yAnswer = determinateY / determinate;

            //Solve for Z
            zAnswer = determinateZ / determinate;

            //Display answers in appropraite text boxes
            txtResultX.Text = ($"{x1} = {xAnswer:N2}");
            txtResultY.Text = ($"{x2} = {yAnswer:N2}");
            txtResultZ.Text = ($"{x3} = {zAnswer:N2}");
        }

        /// <summary>
        /// Determinate Calculator
        /// </summary>
        /// <param name="a11"></param>
        /// <param name="a12"></param>
        /// <param name="a13"></param>
        /// <param name="a21"></param>
        /// <param name="a22"></param>
        /// <param name="a23"></param>
        /// <param name="a31"></param>
        /// <param name="a32"></param>
        /// <param name="a33"></param>
        /// <returns>newDeterminate</returns>
        static double CalcDeterminate(double a11, double a12, double a13, double a21, double a22, double a23, double a31, double a32, double a33)

        {
            //Declare some local variables
            double
                    row1Column1 = 0.0,
                    row2Column1 = 0.0,
                    row3Column1 = 0.0,
                    newDeterminate = 0.0;

            //Take the first row/first column position and calc the value
            row1Column1 = a11 * ((a22 * a33) - (a32 * a23));

            //Take the second row/first column and calc the value
            row2Column1 = a21 * ((a12 * a33) - (a32 * a13));

            //Take the third row/first column and calc the value
            row3Column1 = a31 * ((a12 * a23) - (a13 * a22));

            //Add row 1 column 1 values to row 3 column 1 value then subtract second row first column value
            newDeterminate = row1Column1 + row3Column1 - row2Column1;

            //Return the value
            return newDeterminate;
        }

        /// <summary>
        /// Determinate X Calculator
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="a12"></param>
        /// <param name="a13"></param>
        /// <param name="b2"></param>
        /// <param name="a22"></param>
        /// <param name="a23"></param>
        /// <param name="b3"></param>
        /// <param name="a32"></param>
        /// <param name="a33"></param>
        /// <returns>newDeterminateX</returns>
        static double CalcDeterminateX(double b1, double a12, double a13, double b2, double a22, double a23, double b3, double a32, double a33)
        {
            //Declare some local variables
            double
                row1Column1 = 0.0,
                row2Column1 = 0.0,
                row3Column1 = 0.0,
                newDeterminateX = 0.0;

            //Take the first row/first column position and calc the value
            row1Column1 = b1 * ((a22 * a33) - (a32 * a23));

            //Take the second row/first column and calc the value
            row2Column1 = b2 * ((a12 * a33) - (a32 * a13));

            //Take the third row/first column and calc the value
            row3Column1 = b3 * ((a12 * a23) - (a13 * a22));

            //Add row 1 column 1 values to row 3 column 1 value then subtract second row first column value
            newDeterminateX = row1Column1 + row3Column1 - row2Column1;

            //Return the value
            return newDeterminateX;
        }

        /// <summary>
        /// Determinate Y Calculator
        /// </summary>
        /// <param name="a11"></param>
        /// <param name="b1"></param>
        /// <param name="a13"></param>
        /// <param name="a21"></param>
        /// <param name="b2"></param>
        /// <param name="a23"></param>
        /// <param name="a31"></param>
        /// <param name="b3"></param>
        /// <param name="a33"></param>
        /// <returns>newDeterminateY</returns>
        static double CalcDeterminateY(double a11, double b1, double a13, double a21, double b2, double a23, double a31, double b3, double a33)
        {
            //Declare some local variables
            double
                row1Column1 = 0.0,
                row2Column1 = 0.0,
                row3Column1 = 0.0,
                newDeterminateY = 0.0;

            //Take the first row/first column position and calc the value
            row1Column1 = a11 * ((b2 * a33) - (b3 * a23));

            //Take the second row/first column and calc the value
            row2Column1 = a21 * ((b1 * a33) - (b3 * a13));

            //Take the third row/first column and calc the value
            row3Column1 = a31 * ((b1 * a23) - (a13 * b2));

            //Add row 1 column 1 values to row 3 column 1 value then subtract second row first column value
            newDeterminateY = row1Column1 + row3Column1 - row2Column1;

            //Return the value
            return newDeterminateY;
        }

        /// <summary>
        /// Determinate Z Calculator
        /// </summary>
        /// <param name="a11"></param>
        /// <param name="a12"></param>
        /// <param name="b1"></param>
        /// <param name="a21"></param>
        /// <param name="a22"></param>
        /// <param name="b2"></param>
        /// <param name="a31"></param>
        /// <param name="a32"></param>
        /// <param name="b3"></param>
        /// <returns>newDeterminateZ</returns>
        static double CalcDeterminateZ(double a11, double a12, double b1, double a21, double a22, double b2, double a31, double a32, double b3)
        {
            //Declare some local variables
            double
                row1Column1 = 0.0,
                row2Column1 = 0.0,
                row3Column1 = 0.0,
                newDeterminateZ = 0.0;

            //Take the first row/first column position and calc the value
            row1Column1 = a11 * ((a22 * b3) - (a32 * b2));

            //Take the second row/first column and calc the value
            row2Column1 = a21 * ((a12 * b3) - (a32 * b1));

            //Take the third row/first column and calc the value
            row3Column1 = a31 * ((a12 * b2) - (b1 * a22));

            //Add row 1 column 1 values to row 3 column 1 value then subtract second row first column value
            newDeterminateZ = row1Column1 + row3Column1 - row2Column1;

            //Return the value
            return newDeterminateZ;
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display message box explaining the programs purpose
            MessageBox.Show("This Application will take your most complex\n3x3 system of equations and make it easy.\n\n\nPlease enter your values in the AX = B numerical format.");

        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shut down the application
            this.Close();
        }
    }
}
