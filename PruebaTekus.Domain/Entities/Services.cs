using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PruebaTekus.Domain.Entities
{
    public class Services
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idservice { get; set; }

        [Required]
        public string service { get; set; }

        public List<ProvidersServices> ProvidersServices { get; set; } = new List<ProvidersServices>();
    }
}
