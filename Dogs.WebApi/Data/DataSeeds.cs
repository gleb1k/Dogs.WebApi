using Dogs.WebApi.Models;

namespace Dogs.WebApi.Data
{
    public static class DataSeeds
    {
        public static readonly List<Dog> DogsList = new List<Dog>
        {
            new Dog
            {
                Id = Guid.NewGuid(),
                Name = "Красивый песик",
                Description = "Это песик",
                ImgUrl = "https://www.belnovosti.by/sites/default/files/blogs/10-04-2017/8.jpg",
                ShortDescription = "мини инфо",
                Family = null,
                Height = 50,
                Weight = 30,
                MinAge = 10,
                MaxAge = 15,
            },
            new Dog
            {
                Id = Guid.NewGuid(),
                Name = "Красивый песик2",
                Description = "Это песик2",
                ImgUrl = "https://www.belnovosti.by/sites/default/files/blogs/10-04-2017/8.jpg",
                ShortDescription = "мини инфо2",
                Family = null,
                Height = 50,
                Weight = 30,
                MinAge = 10,
                MaxAge = 15,
            },
            new Dog
            {
                Id = Guid.NewGuid(),
                Name = "Красивый песик3",
                Description = "Это песик3",
                ImgUrl = "https://www.belnovosti.by/sites/default/files/blogs/10-04-2017/8.jpg",
                ShortDescription = "мини инфо3",
                Family = null,
                Height = 50,
                Weight = 30,
                MinAge = 10,
                MaxAge = 15,
            }
        };

        public static readonly List<Family> FamilyList = new List<Family>
        {
            new Family
            {
                Id = Guid.NewGuid(),
                Description = "С шерсткой",
                Name = "Пушистые"
            },
            new Family
            {
                Id = Guid.NewGuid(),
                Description = "Без шерсткой",
                Name = "Лысые"
            }
        };
    }
}