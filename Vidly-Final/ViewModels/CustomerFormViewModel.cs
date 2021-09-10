using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Final.Models;

namespace Vidly_Final.ViewModels
{
    public class CustomerFormViewModel
    {
        public List<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}