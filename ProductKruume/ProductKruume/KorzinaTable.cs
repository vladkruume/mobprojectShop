using System;
using SQLite;

namespace ProductKruume
{
    [Table("Korzina")]
    public class KorzinaTable
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }       
        public string Amaut { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public int Pricee { get; set; }

    }
}


