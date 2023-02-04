using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//important for using smooth up and down
//doesn't matter that you know what this is
using System.Runtime.InteropServices;



namespace racing_game_smooth_movement
{

    //Copyright (C) 2023 Iljo De Poorter

    //This program is free software: you can redistribute it and/or modify
    //it under the terms of the GNU General Public License as published by
    //the Free Software Foundation, either version 3 of the License, or
    //(at your option) any later version.

    //This program is distributed in the hope that it will be useful,
    //but WITHOUT ANY WARRANTY; without even the implied warranty of
    //MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    //GNU General Public License for more details.

    //You should have received a copy of the GNU General Public License
    //along with this program.If not, see<https://www.gnu.org/licenses/>.

    //You can contact met at my electronic mail at Iljodp@gmail.com





    //FOR THIS CODE TO WORK IT IS VERY VERY IMPORTANT TO CHECK THE 'EVENT SECTION IN THE PROPERTIES WINDOW IN THE FORM DESIGN ITSELF
    //THE 2 FUNCTIONS THAT WE JUST MADE ARE BEING EXECUTED IN THE EVENT SECTION (YELLOW BOLT) IN THE PROPERTIES FROM THE FORM ITSELF, NOT THE CAR
    public partial class Form1 : Form
    {
        //this part is used to implement the GetAsyncKeyState in the code, which is used for the smooth up and down in this code
        //The code is a C# declaration for the GetAsyncKeyState function in the "user32.dll" library.
        //It is decorated with DllImport attribute to indicate that the function is being imported from an external library, in this case, the "user32.dll" library.

        //here it imports a dll
        [DllImport("user32.dll")]

        //When called, the GetAsyncKeyState function retrieves the state of the specified virtual key.
        //The return value is a 16-bit signed integer indicating the state of the key. 
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        bool goleft, goright;
        int snelheid = 5;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //this is the part of the code that just makes sure that the white stripes in the middle of the road move along with the players car
        private void beweegmiddelijn(int snelheid)
        {
            //making an array
            PictureBox[] pictures = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7 };
            //and then using a clever loop to make sure that it works, but the code is significantly cut down in size with this loop
            foreach (PictureBox pic in pictures)
            {
                if (pic.Top >= 700)
                {
                    pic.Top = 0;
                }
                else
                {
                    pic.Top += snelheid;
                }
            }
        }

        //this is the part of the code that works when the key (left or right arrow) is being held DOWN
        //There is a significant difference between holding it up and down, and this can't be placed in the same function, even if you change the code a bit
        private void keyisdown(object sender, KeyEventArgs e)
        {
            //this is the part of the code that is responsible for making the car move to the left or the right
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            //this part of the code isn't repeated anywhere else, but this is the part that makes the car move up or down
            //this could 100% be changed into also being smooth, but i'il just be releasing a quick build for now

            //if (e.KeyCode == Keys.Up && auto.Top > 35)
            //{
            //    auto.Top -= snelheid + 1;
            //}
            //else if (e.KeyCode == Keys.Down && auto.Bottom < 700)
            //{
            //    auto.Top += snelheid + 1;
            //}
        }

        //this is the timer of the whole game itself
        private void gameTimerEvent_Tick(object sender, EventArgs e)
        {
 
            //here it calls onto the function we made before, and due to it being in a timer it keeps repeating
            //which is what we want, because it needs to constantly move
            beweegmiddelijn(snelheid);

            //this part of the code makes sure that the car acctualy moves when the key is being pressed down
            if (goleft == true && auto.Left > 10)
            {
                auto.Left -= snelheid;
            }
            if (goright == true && auto.Left < 415)
            {
                auto.Left += snelheid;
            }

            // Calculate smooth movement for the up and down direction.
            int upandown = snelheid + 1;

            // Store the current position of the car
            int currentposition = auto.Top;

            // Check if the Up key is pressed and the car is not at the top edge
            if (GetAsyncKeyState(Keys.Up) != 0 && auto.Top > 35)
            {
                // Decrease the targetTop by the speed of movement
                currentposition -= upandown;
            }
            // Check if the Down key is pressed and the car is not at the bottom edge
            else if (GetAsyncKeyState(Keys.Down) != 0 && auto.Bottom < 700)
            {
                // Increase the targetTop by the speed of movement
                currentposition += upandown;
            }

            // Update the position of the car using a smooth transition
            auto.Top = (auto.Top + currentposition) / 2;
        }


        //this is the part of the code that makes sure that the car acctualy stops moving when a key isn't being pressed, and that it goes in a straight line
        // I think the code is self explanatory.
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

    }
}
