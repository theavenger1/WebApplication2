namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.books")]
    public partial class book
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int book_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int users_id { get; set; }

        [Required]
        [StringLength(255)]
        public string book_title { get; set; }

        public long no_of_books { get; set; }


        [Column("order items_orders_id")]
        public int order_items_orders_id { get; set; }

        public int book_cost { get; set; }

        [StringLength(45)]
        public string description { get; set; }

        public virtual category category { get; set; }

        public virtual order_item order_items { get; set; }

        public virtual user user { get; set; }
    }
}
