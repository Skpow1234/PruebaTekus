using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTekus.Domain.Entities
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idcountry { get; set; }
        public string country { get; set; }
        public List<ProvidersServices> ProvidersServices { get; set; } = new List<ProvidersServices>();
    }
}
