using System.Collections.Generic;

namespace _05.Integration.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<Category> ChildCategories { get; set; }
        public Category(string name, List<User> users)
        {
            this.Name = name;
            this.Users = new List<User>(users);
        }

        public void AssignToParentCategory(Category childCategory)
        {
            this.ChildCategories.Add(childCategory);
        }
    }
}