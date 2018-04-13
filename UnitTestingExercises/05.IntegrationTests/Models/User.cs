using System.Collections.Generic;

namespace _05.Integration.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<Category> Categories { get; set; }

        public User(string name, List<Category> categories)
        {
            this.Name = name;
            this.Categories = new List<Category>(categories);
        }

        public void Add(Category category)
        {
            this.Categories.Add(category);
        }

        public void Remove(params Category[] categories)
        {
            if (categories.Length == 1)
            {
                this.Categories.Remove(categories[0]);
            }
            else
            {
                foreach (var category in categories)
                {
                    this.Categories.Remove(category);
                }
            }
        }
    }
}