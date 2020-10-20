using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U45.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string HeadLine { get; set; }
        public string Subhead { get; set; }
        public string DeadLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newItems)
        {
            var allItems = GetNewsItems();
            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();
            newItems.Clear();
            filteredNewsItems.ForEach(p => newItems.Add(p));
        }

        private static List<NewsItem> GetNewsItems()
        {
            var Item = new List<NewsItem>();
            Item.Add(new NewsItem() { Id = 1, Category = "Financial", HeadLine = "Street Wall", DeadLine = "16/10/2020", Image = "Assets/financial.jfif", Subhead = "Bill Gate" });
            Item.Add(new NewsItem() { Id = 2, Category = "Financial", HeadLine = "Person don't sleep", DeadLine = "15/10/2020", Image = "Assets/financial2.jfif", Subhead = "Bill Clinton" });
            Item.Add(new NewsItem() { Id = 3, Category = "Financial", HeadLine = "Black Friday", DeadLine = "14/10/2020", Image = "Assets/financial3.jfif", Subhead = "Edward Gate" });
            Item.Add(new NewsItem() { Id = 4, Category = "Financial", HeadLine = "Vegetable ", DeadLine = "11/10/2020", Image = "Assets/financial4.jfif", Subhead = "Duck Gate" });
            Item.Add(new NewsItem() { Id = 5, Category = "Financial", HeadLine = "Pig Fresh ", DeadLine = "12/10/2020", Image = "Assets/financial5.jfif", Subhead = "Pig Gate" });

            Item.Add(new NewsItem() { Id = 6, Category = "Food", HeadLine = "Eirmod vero", DeadLine = "12/11/2020", Image = "Assets/food.jfif", Subhead = "Pig Gate" });
            Item.Add(new NewsItem() { Id = 7, Category = "Food", HeadLine = "Sins shun", DeadLine = "21/12/2020", Image = "Assets/food2.jfif", Subhead = "Vegetarian Gate" });
            Item.Add(new NewsItem() { Id = 8, Category = "Food", HeadLine = "Das ihr", DeadLine = "13/10/2020", Image = "Assets/food3.jfif", Subhead = "123" });
            Item.Add(new NewsItem() { Id = 9, Category = "Food", HeadLine = "Hélas la", DeadLine = "16/10/2020", Image = "Assets/food4.jfif", Subhead = "456" });
            Item.Add(new NewsItem() { Id = 10, Category = "Food", HeadLine = "Golfes aux", DeadLine = "18/10/2020", Image = "Assets/food5.jfif", Subhead = "789" });
            return Item;
        }


    }
}
