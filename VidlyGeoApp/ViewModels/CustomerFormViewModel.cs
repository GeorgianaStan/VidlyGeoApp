using System.Collections.Generic;
using VidlyGeoApp.Models;

namespace VidlyGeoApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}