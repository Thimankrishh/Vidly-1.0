using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_1._0.Models;

namespace Vidly_1._0.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }

        public Customer Customer { get; set; }
    }
}