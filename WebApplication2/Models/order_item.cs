namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.order items")]
    public partial class order_item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order_item()
        {
            books = new HashSet<book>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_item_id { get; set; }

        public int no_of_items { get; set; }

        [StringLength(45)]
        public string order_id { get; set; }

        public int orders_order_id { get; set; }

        public int? from_hub_id { get; set; }

        public int? to_hub_id { get; set; }

        [StringLength(45)]
        public string cost { get; set; }

        public int hub_travel_cost_hub_travel_cost_id { get; set; }

        public int hubs_admins_admin_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<book> books { get; set; }

        public virtual hub_travel_cost hub_travel_cost { get; set; }

        public virtual hubs_admins hubs_admins { get; set; }

        public virtual order order { get; set; }
    }
}
