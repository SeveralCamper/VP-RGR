using System;
using System.Collections.Generic;

namespace FL
{
    public partial class GroupsResault
    {
        public string GroupsTeamResId { get; set; } = null!;
        public string? Team { get; set; }
        public long? Place { get; set; }
        public long? GamesPlayed { get; set; }
        public long? Wins { get; set; }
        public long? Draws { get; set; }
        public long? Loses { get; set; }
        public long? GfBallsScored { get; set; }
        public long? GaBallsConceded { get; set; }
        public long? GdAccountDifference { get; set; }
        public long? PtsPoints { get; set; }
        public string? GroupId { get; set; }
    }
}
