/*Add a model Class

A model is an object that represents the data in your application. In this case, the only model is a to-do item.

Add a folder named Models. You can put model classes anywhere in your project, but the Model is used by convention.

Add a TodoItem Class with the following Code:*/

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id {get; set;}
        public string Name { get; set;}
        public bool IsComplete { get; set;}
    }

}