﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_Final.Models;

namespace Vidly_Final.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MemberShipTypeId { get; set; }

        //[Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }


    }
}