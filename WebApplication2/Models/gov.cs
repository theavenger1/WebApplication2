namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.gov")]
    public partial class gov
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gov()
        {
            cities = new HashSet<city>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int gov_id { get; set; }

        [Required]
        [StringLength(255)]
        public string gov_name { get; set; }

        public int hub_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<city> cities { get; set; }

        public virtual hub hub { get; set; }
    }
}
