using Customer.Domain.Enums;

namespace Customer.Domain.Entities
{
    public class PlayList : Entity<Guid>
    {
        public string ProfileId { get; set; }

        public string MusicId { get; set; }

        public int Index { get; set; }

        public PlayListStatus Status { get; set; } = PlayListStatus.Normal;

        public PlayList(string profileId, string musicId, int index, PlayListStatus status)
        {
            ProfileId = profileId;
            MusicId = musicId;
            Index = index;
            Status = status;
        }

        public PlayList()
        {
            Status = PlayListStatus.Normal;
        }
    }
}
