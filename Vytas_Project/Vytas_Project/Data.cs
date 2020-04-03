
using SQLite;

namespace Vytas_Project
{
    [Table("Friends")]
    public class Data
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string index { get; set; }
        public int count { get; set; }
    }
}
