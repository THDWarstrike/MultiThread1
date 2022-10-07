using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread.CarzyPC
{
    internal class audio
    {
        public static void fireSound()
        {
            Thread thread = new Thread(playSimpleSound);
            thread.Start();
        }

        private static void playSimpleSound()
        {
            while (true)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                simpleSound.Play();
            }
        }
    }
}
