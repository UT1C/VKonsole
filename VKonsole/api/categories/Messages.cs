namespace VKonsole.Categories
{
    public class Messages : Category
    {
        public Messages(API api) : base(api) {}

        async public void Send()
        {
            await this.api.Request();
        }
    }
}
