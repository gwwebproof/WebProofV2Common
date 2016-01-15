using System;

namespace WebProofIdentitySync
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length < 1 || args.Length > 3)
            {
                ShowHelp();
            }
            else
            {
                switch (args.Length)
                {
                    case 1:
                        {
                            StartWithOneParam(args[0]);
                            break;
                        }
                    case 2:
                        {
                            StartWithTwoParams(args[0], args[1]);
                            break;
                        }
                    case 3:
                        {
                            StartWithThreeParams(args[0], args[1], args[2]);
                            break;
                        }
                    default:
                        {
                            ShowHelp();
                            break;
                        }
                }
            }



        }

        private static void StartWithThreeParams(string param1, string param2, string param3)
        {
            switch (param1)
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

        private static void StartWithTwoParams(string param1, string param2)
        {
            switch (param1)
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

        private static void StartWithOneParam(string param)
        {
            switch (param)
            {
                case "-s":
                    {
                        //Start app as service
                        RunAsService();
                        break;
                    }
                case "-c":
                    {
                        //Start app in console mode
                        RunAsConsole();
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

        private static void RunAsConsole()
        {
            throw new NotImplementedException();
        }

        private static void RunAsService()
        {
            throw new NotImplementedException();
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
            Environment.Exit(0);
        }
    }
}
