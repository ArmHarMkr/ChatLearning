using Microsoft.AspNetCore.Identity;

namespace ChatLearning.Models
{
    public class AppUser : IdentityUser
    {
        // 1 - * AppUser || Message  One to Many relationship
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }
        public virtual ICollection<Message> Messages { get; set; }

    }
}
