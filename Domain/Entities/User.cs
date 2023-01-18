using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using AspNetCoreHero.Abstractions;
using AspNetCoreHero.Abstractions.Domain;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string State { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string PostalCode { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Email { get; set; }
        public int NeighborhoodId { get; set; }
        public Neighborhood Neighborhood { get; set; }

    }
}
