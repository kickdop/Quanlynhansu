namespace baitapnhom1.Model.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("phongban")]
    public partial class phongban
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }
    }
}
