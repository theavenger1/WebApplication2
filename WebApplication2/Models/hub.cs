namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.hubs")]
    public partial class hub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hub()
        {
            govs = new HashSet<gov>();
            hubs_admins = new HashSet<hubs_admins>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hub_id { get; set; }

        [Required]
        [StringLength(255)]
        public string hub_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gov> govs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hubs_admins> hubs_admins { get; set; }
    }
}
