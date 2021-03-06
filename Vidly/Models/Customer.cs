﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
	public class Customer
	{
		public int Id { get; set; }
		[Required]
		[StringLength(250)]
		public string Name { get; set; }
		public bool IsSubscribedToNewsLetter { get; set; }
		public DateTime? BirthDate { get; set; }
		public MembershipType MembershipType { get; set; }
		public byte MembershipTypeId { get; set; }
	}
}