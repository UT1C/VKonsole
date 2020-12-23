using Terminal.Gui;
using System.Threading.Tasks;

namespace VKonsole
{
    class App
    {
        Toplevel top;

        public App()
        {
            Application.Init();
            this.top = Application.Top;
        }

        public void run()
        {
            Application.Run();
        }
    }
}
