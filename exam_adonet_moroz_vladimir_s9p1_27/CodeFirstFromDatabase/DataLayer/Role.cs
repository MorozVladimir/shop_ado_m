namespace CodeFirstFromDatabase.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Role")]
    public partial class Role
    {
        public int RoleId { get; set; }

        [StringLength(32)]
        public string RoleName { get; set; }
    }
}
