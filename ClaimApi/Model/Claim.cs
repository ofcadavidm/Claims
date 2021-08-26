using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClaimApi.Model
{
    [Table("Claims")]
	public class Claim : BaseCollection
	{
		[MaxLength(20)]
		public string Firstname { get; set; }
		[MaxLength(20)]
		public string Lastname { get; set; }
		public string Documenttype { get; set; }
		public Int64 Documentid { get; set; }
		[MaxLength(50)]
		public string Email { get; set; }
		public DateTime? Dateaccident { get; set; }
		public string Country { get; set; }
		[MaxLength(50)]
		public string Region { get; set; }
		[MaxLength(500)]
		public string Accidentdetails { get; set; }
		[MaxLength(100)]
		public string Category { get; set; }
		[MaxLength(100)]
		public string Marca { get; set; }
		[MaxLength(20)]
		public string Matricula { get; set; }
		[MaxLength(20)]
		public string Nropoliza { get; set; }
		[MaxLength(500)]
		public string Comments { get; set; }
		public DateTime Registrationdate { get; set; } = DateTime.Now;
	}
}
