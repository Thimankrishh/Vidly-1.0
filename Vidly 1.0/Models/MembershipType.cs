using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly_1._0.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public short SignUpFree { get; set; }
        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }
    }
}