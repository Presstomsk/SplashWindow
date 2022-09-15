using System;
using System.Threading;


namespace Splash
{
    public partial class SplashWindow : IDisposable
    {
        private volatile View.SplashWindow splashWindow;

        public SplashWindow(string title = "SplashWindow")
        {
            Show(title);
        }     

        protected virtual void Show(string title = "SplashWindow")
        {
            var thread = new Thread(() =>
            {
                splashWindow = new View.SplashWindow();
                splashWindow.Title = title;
                splashWindow.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start();

            while (splashWindow == null) { }
        }

        protected virtual void Close()
        {
            splashWindow.Dispatcher.Invoke(() => splashWindow.Close());
        }
        public void Dispose()
        {
            Close();
        }
    }
}
