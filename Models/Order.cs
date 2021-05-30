using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }


        [Required(ErrorMessage = "Your userId is missing")]
        [Display(Name = "UserId")]
        [StringLength(50)]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Your first name is missing")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your last name is missing")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is missing")]
        [Display(Name = "Street Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is missing")]
        public string City { get; set; }

        [Required(ErrorMessage = "Province is missing")]
        [StringLength(2, MinimumLength = 2)]
        public string Province { get; set; }

        [Required(ErrorMessage = "Postal Code is missing")]
        [StringLength(6, MinimumLength = 6)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Phone number is missing")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public double OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}