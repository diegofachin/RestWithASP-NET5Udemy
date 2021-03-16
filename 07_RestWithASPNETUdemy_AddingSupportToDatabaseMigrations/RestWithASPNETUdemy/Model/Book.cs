using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    [Table("book")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string Author { get; set; }

        [Column("last_name")]
        public DateTime LaunchDate { get; set; }

        [Column("address")]
        public Decimal Price { get; set; }

        [Column("gender")]
        public string Title { get; set; }

    }
}
