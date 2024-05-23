using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Backoffice.Components.Models
{
    public class WebsiteUser
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Biography { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ProfileImage { get; set; } = "/images/icons/no-profile-picture.svg";
        public int? AddressId { get; set; }
        public WebsiteUserAddressModel? Address { get; set; }
    }

    public class WebsiteUserAddressModel
    {
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}