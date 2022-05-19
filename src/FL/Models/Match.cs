﻿using System;
using System.Collections.Generic;

namespace FL
{
    public partial class Match
    {
        public Match()
        {
            Groups = new HashSet<Group>();
            Quarters = new HashSet<Quarter>();
        }

        public string MatchId { get; set; } = null!;
        public byte[]? Date { get; set; }
        public string FirstTeam { get; set; } = null!;
        public string SecondTeam { get; set; } = null!;
        public long FirstTeamResault { get; set; }
        public long SecondTeamResault { get; set; }
        public long WhoWon { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Quarter> Quarters { get; set; }
    }
}
