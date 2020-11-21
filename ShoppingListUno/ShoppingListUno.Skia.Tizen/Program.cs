using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ShoppingListUno.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ShoppingListUno.App(), args);
            host.Run();
        }
    }
}
