using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace ZeqOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("ZeqOS EXT Codename 'Makle' Build 7909 Booted! Type a command.");
        }

        protected override void Run()
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if(input == "ver")
            {
                Console.WriteLine("ZeqOS Version: 1.1 Codename Makle Build 7909");
            }
            if(input == "shutdown")
            {
                Sys.Power.Shutdown();
            }
            if (input == "reboot")
            {
                Sys.Power.Reboot();
            }
            else
            {
                Console.WriteLine("Invalid Command",input);
            }
        }
    }
}
