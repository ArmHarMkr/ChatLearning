using System.ComponentModel.DataAnnotations;

namespace ChatLearning.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }

        public DateTime When { get; set; } = DateTime.Now;
        public int UserID { get;set; }
        public virtual AppUser AppUser { get; set; }
    }
}
