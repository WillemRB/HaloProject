using Topshelf;

namespace SpartanUpdateService
{
    public class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<SpartanUpdater>(s =>
                    {
                        s.ConstructUsing(() => new SpartanUpdater());
                        s.WhenStarted(updater => updater.Start());
                        s.WhenStopped(updater => updater.Stop());
                    }
                );

                x.RunAsLocalSystem();

                x.SetInstanceName("SpartanUpdater");
                x.SetDisplayName("Spartan Update Service");

                x.StartAutomatically();
            });
        }
    }
}
