using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Genre : IComparable<Genre>
    {

        public int Id { get; set; }
        public String Name { get; set; }

        public int CompareTo([AllowNull] Genre other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
