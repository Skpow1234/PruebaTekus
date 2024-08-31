using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTekus.Domain.Entities
{
    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idprovider { get; set; }

        [Required]
        public string nit { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string mail { get; set; }
        public List<ProvidersServices> ProvidersServices { get; set; } = new List<ProvidersServices>();

    }
}
