using System;

class Program
{
    static void Main()
    {
        var repo = new InMemoryRepository();
        var tours = repo.Tours; var managers = repo.Managers; var countries = repo.Countries;

        string test = "Пляжный отдых";
        Manager foundM = null;
        foreach (var t in tours) if (t.Name == test) foreach (var m in managers) if (m.Id == t.ManagerId) foundM = m;
        Console.WriteLine($"1. FindManager(\"{test}\"): {(foundM != null ? foundM.FullName + " (" + foundM.Experience + " лет опыта)" : "null")}");

        Country foundC = null;
        foreach (var t in tours) if (t.Name == test) foreach (var c in countries) if (c.Id == t.CountryId) foundC = c;
        Console.WriteLine($"2. FindCountry(tour \"{test}\"): {(foundC != null ? foundC.Name + " (" + foundC.Continent + ")" : "null")}");

        int totalDays = 0;
        foreach (var t in tours) totalDays += t.Days;
        Console.WriteLine($"3. GetTotalDays: {totalDays}");

        Country popC = null; int max = -1;
        foreach (var c in countries)
        {
            int count = 0;
            foreach (var t in tours) if (t.CountryId == c.Id) count++;
            if (count > max) { max = count; popC = c; }
        }
        Console.WriteLine($"4. GetMostPopularCountry: {popC?.Name} ({max} тура)");

        Console.WriteLine("5. PrintAllTours:");
        foreach (var t in tours)
        {
            string mName = "—", cName = "—";
            foreach (var m in managers) if (m.Id == t.ManagerId) mName = m.FullName;
            foreach (var c in countries) if (c.Id == t.CountryId) cName = c.Name;
            Console.WriteLine($"  \"{t.Name}\" ({t.Days} дней, {t.Price:F0} руб.) — менеджер {mName}, страна \"{cName}\"");
        }

        string fake = "Неизвестный тур"; bool ok = false;
        foreach (var t in tours) if (t.Name == fake) ok = true;
        Console.WriteLine($"\nНе найдено: FindManager(\"{fake}\") => {(ok ? "" : "null")}");

        Console.ReadLine();
    }
}
