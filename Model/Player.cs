using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class Player
    {
        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Position { get; set; }

        [DataMember]
        public int NumberOfGamesPlayed { get; set; }

        [DataMember]
        public int NumberOfGoalsScored { get; set; }

        [DataMember]
        public int NumberOfAssists { get; set; }
    }
}
