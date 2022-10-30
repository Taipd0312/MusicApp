using Customer.Domain.Enums;

namespace Customer.Domain.Entities
{
    public class Profile : Entity<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Avatar { get; set; }

        public string DisplayName { get; set; }

        public ProfileStatus Status { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public Profile(string firstName, string lastName, string avatar, string displayName, ProfileStatus status, string createdBy, DateTime createdOn, string modifiedBy, DateTime modifiedOn)
        {
            FirstName = firstName;
            LastName = lastName;
            Avatar = avatar;
            DisplayName = displayName;
            Status = status;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            ModifiedBy = modifiedBy;
            ModifiedOn = modifiedOn;
        }

        public Profile()
        {
            ModifiedOn = DateTime.Now;
        }
    }
}
