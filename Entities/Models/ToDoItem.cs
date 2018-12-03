using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("todoitem")]
    public class ToDoItem
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Created Date is required")]
        public DateTime CreatedOn { get; set; }

        public DateTime CompletedOn { get; set; }

        [Required(ErrorMessage = "User is required")]
        public User User { get; set; }
    }
}
