using VkNet;

namespace VKonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            VkApi api = new VkApi();
            App app = new App();
            app.Run();
        }
    }
}
