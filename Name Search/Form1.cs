//John Fade IV 2307363
//I worked alone on this assignment
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Name_Search
{
    public partial class Form1 : Form
    {
       
        List<string> boysList = new List<string>();
        List<string> girlsList = new List<string>();
        public Form1()
        {
            //initilizes methods on form launch
            InitializeComponent();
            //triggers the read file methods at form launch
            ReadGirls(girlsList);
            ReadBoys(boysList);


        }

        //reads boys file
        private void ReadBoys(List<string> boysList)
        {
            try
            {
                StreamReader inputFile = File.OpenText("BoyNames.txt"); //opens the text

                while (!inputFile.EndOfStream)
                {
                    boysList.Add(inputFile.ReadLine()); //reads entire text and adds to boysList
                }

                inputFile.Close(); //closes the file
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //reads girls file
        private void ReadGirls(List<string> girlsList)
        {
            try
            {
                StreamReader inputFile = File.OpenText("GirlNames.txt"); //opens the text
                while (!inputFile.EndOfStream)
                {
                    girlsList.Add(inputFile.ReadLine()); //reads entire text and adds to girlsList
                }

                inputFile.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        //search button click event
            //determines if the name entered by the user matches one found in their respective listboxes
            //outputs message boxes accordingly
        private void nameSearchButton_Click(object sender, EventArgs e)
        {
            

            string boysSearchText = boyTextBox.Text.Trim(); //holds the boy entry by the user
            string girlsSearchText = girlTextBox.Text.Trim(); //holds the girl entry by the user
            int girlCount; //holds the compared rank          
            int boyCount; //holds the compared rank
            bool boyNameFound = false; //boy default boolean set to false
            bool girlNameFound = false; //girl default boolean set to false

            //boys test to see if the entered text matches a name found in the list
            
            if (boysList.Contains(boysSearchText))
            {
                for  (boyCount = -1; boyCount <= boysList.IndexOf(boysSearchText); boyCount++)
                {

                }
                MessageBox.Show(boysSearchText + " was found in the top 200! " + " Located at rank: #" + boyCount + " of 200!");
                boyNameFound = true;
            }
            else
            {
                boyNameFound = false;
            }

            //girls test to see if the entered text matches a name found in the list
            if (girlsList.Contains(girlsSearchText))
            {
                
                for ( girlCount = -1; girlCount <= girlsList.IndexOf(girlsSearchText); girlCount++)
                {
                    
                }               
                MessageBox.Show(girlsSearchText + " was found in the top 200! " + "Located at rank: #" + girlCount + " of 200!");
                girlNameFound = true;

            }
            else
            {
                girlNameFound = false;
            }

            //the boy and girl catches for failed entries
            if (girlNameFound == false )
            {
                MessageBox.Show("A girls name you entered was not found.");
            }
            if (boyNameFound == false)
            {
                MessageBox.Show("A boys name you entered was not found.");
            }
        }
        //exits the form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
