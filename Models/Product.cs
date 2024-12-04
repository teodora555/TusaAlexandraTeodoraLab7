using SQLite;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Attributes;

namespace TusaAlexandraTeodoraLab7.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Description { get; set; }

        [OneToMany]
        public List<ListProduct> ListProducts { get; set; }
    }
}
