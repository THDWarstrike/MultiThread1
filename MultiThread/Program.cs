using MultiThread.CarzyPC;
using MultiThread.ThreadingSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace MultiThread
{
    internal class Program
    {
        public static System.Windows.Forms.Keys ModifierKeys { get; }
        public char KeyChar { get; set; }
        public System.Windows.Forms.Keys KeyCode { get; }
        static void Main(string[] args)
        {
            //NoThread.NoThreadExample();
            //ThreadingOne.DemoThread();
            //CrazyPC.CrazyFunctionCall();
            audio.fireSound();
            keystrokes.threadKeyStroke();


            Console.ReadLine();
            Console.ReadKey();




        }


        






    }
}
