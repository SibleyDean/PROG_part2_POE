using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poeAssigmentTwo.Structures
{
    public class responseB
    {
        public string Title { get; set; } = string.Empty;
        public string[] Triggers { get; set; } = Array.Empty<string>();
        public string[] RandomResponses { get; set; } = Array.Empty<string>();
        public string[] FollowUps { get; set; } = Array.Empty<string>();
        public Dictionary<string, string[]> FollowUpResponses { get; set; } = new Dictionary<string, string[]>();
    }
}
