using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Timers;

namespace GalacticaOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetBufferSize(384, 256);
                Console.SetWindowSize(192, 48);
                Console.SetBufferSize(192, 48);
            }

            Methods methods = new Methods();

            
        }


    }
}
