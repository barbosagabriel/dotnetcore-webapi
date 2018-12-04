using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("todoitems")]
    public class ToDoItem
    {
        //[Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("createdOn")]
        [Required(ErrorMessage = "Created Date is required")]
        public DateTime CreatedOn { get; set; }

        [Column("completedOn")]
        public DateTime CompletedOn { get; set; }

        [Column("dueDate")]
        public DateTime DueDate { get; set; }

        [Column("description")]
        [Required(ErrorMessage = "Task is required")]
        [StringLength(100, ErrorMessage = "Task can't be longer than 100 characters")]
        public string Description { get; set; }

        [ForeignKey("user")]
        [Required(ErrorMessage = "User is required")]
        public User User { get; set; }
    }
}
