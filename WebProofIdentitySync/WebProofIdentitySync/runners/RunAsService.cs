using System;
using System.Timers;
using Topshelf;

namespace WebProofIdentitySync.runners
{
    internal class ServiceRunner
    {
        readonly Timer _timer;
        public ServiceRunner(string delay)
        {
            var interval = Int32.Parse(delay);
            _timer = new Timer(interval: interval * 1000)
            {
                AutoReset = true
            };

            _timer.Elapsed += (sender, eventArgs) => Console.WriteLine("It is {0} and all is well", DateTime.Now);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            //Perform clean up.
            _timer.Stop();
        }
    }
    /// <summary>
    /// Running Syncronisation as a service.
    /// </summary>
    internal sealed class RunAsService
    {

        public void Start(string param1, string param2)
        {
            HostFactory.Run(x =>
            {
                x.StartAutomaticallyDelayed();
                x.EnablePauseAndContinue();
                x.EnableShutdown();
                x.EnableServiceRecovery(sr =>
                {
                    sr.RestartService(1);
                    sr.SetResetPeriod(1);
                });
                x.Service<ServiceRunner>(s =>
                {
                    s.ConstructUsing(name => new ServiceRunner(param1));
                    s.WhenStarted(sr => sr.Start());
                    s.WhenStopped(sr => sr.Stop());
                    s.WhenPaused(sr => sr.Stop());
                    s.WhenContinued(sr => sr.Start());
                    s.WhenShutdown(sr => sr.Stop());

                });
                x.RunAsLocalSystem();

                x.SetDescription("WebProof wp.identity Syncronisation Service");
                x.SetDisplayName("WPIdentitySyncronisation");
                x.SetServiceName("WPIdentitySyncronisation");
            });
        }
    }
}
