using System;

namespace IntercommIoSync
{
    class Program
    {
        static void Main(string[] args)
        {
            // WebProofGlobalTest.TestAllClients();

            if (args.Length < 1 || args.Length > 2)
            {
                ShowHelp();
            }

            var param = args[0];
            var sleep = args[1];
            switch (param)
            {
                case "-s":
                    {
                        //Start app as service
                        break;
                    }
                case "-c":
                    {
                        //Start app in console mode
                        break;
                    }
                case "-h":
                    {
                        //Show help
                        ShowHelp();
                        break;
                    }
                default:
                    {
                        //Param is missing so show help
                        ShowHelp();
                        break;
                    }
            }
        }

        static void ShowHelp()
        {
            Console.WriteLine("Application parameters:");
            Console.WriteLine("-s Start Application as Service.");
            Console.WriteLine("-c Start Application in Console mode.");
            Console.WriteLine("-p Minutes application sleeps before next poll.");
            Console.WriteLine("");
            Console.WriteLine("Ex: -s -p30 Applicacation starts as a service and sleeps 30 minutes inbetween each poll.");
            Console.ReadLine();
        }
    }
}
