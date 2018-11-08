using System;
using System.Collections.Generic;

namespace tshilobo.Enities
{
    public partial class Gender
    {
        public Gender()
        {
            User = new HashSet<User>();
        }

        public int GenderId { get; set; }
        public string Gname { get; set; }

        public ICollection<User> User { get; set; }
    }
}
