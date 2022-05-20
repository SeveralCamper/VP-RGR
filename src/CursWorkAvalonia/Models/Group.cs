using System;
using System.Collections.Generic;

namespace CursWorkAvalonia
{
    public partial class Group
    {
        public string GroupId { get; set; } = null!;
        public string MatchId { get; set; } = null!;
        public string GroupNum { get; set; } = null!;

        public virtual Match Match { get; set; } = null!;
    }
}
