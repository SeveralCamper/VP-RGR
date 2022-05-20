using System;
using System.Collections.Generic;

namespace CursWorkAvalonia
{
    public partial class Quarter
    {
        public string QuartersId { get; set; } = null!;
        public string MatchId { get; set; } = null!;
        public double QuartersNum { get; set; }

        public virtual Match Match { get; set; } = null!;
    }
}
