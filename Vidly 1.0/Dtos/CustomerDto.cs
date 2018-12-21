using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_1._0.Models;

namespace Vidly_1._0.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

     /*   public MembershipType MembershipType { get; set; }
          
          we should not add this bcz it is also
          a domain model. so it can impact to this dto. so mainly use primitive types or custom dtos.
          if want to return hierarchical data structures, should create 
          another type called MembershipType dto.
     */


        
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
       
     //   [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}