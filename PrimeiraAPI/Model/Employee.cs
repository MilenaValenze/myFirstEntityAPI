using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraAPI.Model
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("name")]
        public string name { get; private set; }

        [Column("age")]
        public int age { get; private set; }

        [Column("photo")]
        public string photo { get; private set; }
        public Employee() { }

        public Employee(string name, int birthYear, string photo)
        {
            DateTime moment = DateTime.Now;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = moment.Year - birthYear;
            this.photo = photo;
            
        }
    }
}
