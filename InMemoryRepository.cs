using System.Collections.Generic;

public class InMemoryRepository
{
    public List<Country> Countries = new List<Country> {
        new Country { Id = 1, Name = "Турция", Continent = "Азия" },
        new Country { Id = 2, Name = "Италия", Continent = "Европа" }
    };
    public List<Manager> Managers = new List<Manager> {
        new Manager { Id = 1, FullName = "Иванова А.А.", Experience = 5 },
        new Manager { Id = 2, FullName = "Петров П.П.", Experience = 2 }
    };
    public List<Tour> Tours = new List<Tour> {
        new Tour { Id = 1, Name = "Пляжный отдых", CountryId = 1, ManagerId = 1, Price = 50000, Days = 7 },
        new Tour { Id = 2, Name = "Экскурсионный", CountryId = 2, ManagerId = 2, Price = 40000, Days = 5 },
        new Tour { Id = 3, Name = "Всё включено супер", CountryId = 1, ManagerId = 1, Price = 85000, Days = 10 },
        new Tour { Id = 4, Name = "Римские каникулы", CountryId = 2, ManagerId = 2, Price = 120000, Days = 12 },
        new Tour { Id = 5, Name = "Круиз по Нилу", CountryId = 1, ManagerId = 1, Price = 65000, Days = 8 }
    };
}
