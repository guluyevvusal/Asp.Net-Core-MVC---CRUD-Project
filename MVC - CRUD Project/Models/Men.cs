using System.ComponentModel.DataAnnotations;

namespace MVC___CRUD_Project.Models
{
    public class Men
    {
        [Key]
        public int Men_Id { get; set; }
        public string Men_FullName { get; set; }
    }
}
