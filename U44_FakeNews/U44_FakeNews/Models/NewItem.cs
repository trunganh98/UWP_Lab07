using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U44_FakeNews.Model
{
    public class NewItem
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
        private static List<NewItem> GetNewItems()
        {
            var items = new List<NewItem>();
            items.Add(new NewItem() { Id = 1, Category = "Financial", HeadLine = "Street Wall", DeadLine = "16/10/2020", Image = "Assets/finacial.png", Subhead = "Bill Gate" });
            items.Add(new NewItem() { Id = 2, Category = "Financial", HeadLine = "Person don't sleep", DeadLine = "15/10/2020", Image = "Assets/finacial.png", Subhead = "Bill Clinton" });
            items.Add(new NewItem() { Id = 3, Category = "Financial", HeadLine = "Black Friday", DeadLine = "14/10/2020", Image = "Assets/finacial.png", Subhead = "Edward Gate" });
            items.Add(new NewItem() { Id = 4, Category = "Food", HeadLine = "Vegetable ", DeadLine = "11/10/2020", Image = "Assets/food.png", Subhead = "Duck Gate" });
            items.Add(new NewItem() { Id = 5, Category = "Food", HeadLine = "Pig Fresh ", DeadLine = "12/10/2020", Image = "Assets/food.png", Subhead = "Pig Gate" });
            items.Add(new NewItem() { Id = 6, Category = "Food", HeadLine = "Carrot Purple ", DeadLine = "13/10/2020", Image = "Assets/food.png", Subhead = "Vegetarian Gate" });
            return items;
        }
        public static void GetNews(
            string category,
            ObservableCollection<NewItem> newItems)
        {
            var allItems = GetNewItems();
            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();
            newItems.Clear();
            filteredNewsItems.ForEach(p => newItems.Add(p));
        }

    }

}
