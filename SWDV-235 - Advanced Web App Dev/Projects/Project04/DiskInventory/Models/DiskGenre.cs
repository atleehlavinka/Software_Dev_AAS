﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DiskInventory.Models
{
    public partial class DiskGenre
    {
        public DiskGenre()
        {
            Disks = new HashSet<Disk>();
        }

        public int GenreId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Disk> Disks { get; set; }
    }
}
