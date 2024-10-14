namespace CarRentingSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using static DataConstants.User;

    public class User : IdentityUser
    {
        [MaxLength(FullNameMaxLength)]
        public string FullName { get; set; }
        [MaxLength(10)]
        public string PhoneNumer { get; set; }

        [Remote("IsUniqueEgn", ErrorMessage ="This EGN already exists")]
        [MaxLength(10)]
        public string EGN { get; set; }
    }
}
