namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.hub_travel_cost")]
    public partial class hub_travel_cost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hub_travel_cost()
        {
            order_items = new HashSet<order_item>();
        }

        [Key]
        public int hub_travel_cost_id { get; set; }

        public int? from_hub_id { get; set; }

        public int? to_hub_id { get; set; }

        [StringLength(45)]
        public string cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_item> order_items { get; set; }
    }
}
