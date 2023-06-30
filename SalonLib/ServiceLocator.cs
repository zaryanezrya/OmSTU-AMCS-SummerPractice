namespace SalonLib;
public class ServiceLocator
{
    private static IDictionary<string, Func<string>> store;

    static ServiceLocator()
    {
        store = new Dictionary<string, Func<string>>();
        store.Add("Читать стихи", () => "В читальном зале");
<<<<<<< HEAD
<<<<<<< HEAD
        store.Add("Петь романсы", () => "У рояля");
=======
        store.Add("Писать статьи", () => "В кабинете");
>>>>>>> broken/OsipBrik
=======
        store.Add("Петь романсы", () => "У рояля");
        store.Add("Играть в карты", () => "За карточным столом");
>>>>>>> broken/VladimirMayakovsky
    }

    public static string GetService(string key)
    {
        return store[key].Invoke();
    }

}
