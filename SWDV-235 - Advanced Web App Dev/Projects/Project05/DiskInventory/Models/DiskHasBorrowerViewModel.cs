using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiskInventory.Models
{
    public partial class DiskHasBorrowerViewModel
    {
        //public int DiskHasBorrowerId { get; set; }
        //[Required]
        //public int BorrowerId { get; set; }
        //[Required]
        //public int DiskId { get; set; }
        //public DateTime BorrowedDate { get; set; }
        //public DateTime? ReturnedDate { get; set; }

        public DiskHasBorrowerViewModel()
        {
            CurrentVM = new DiskHasBorrower();
        }
        public virtual DiskBorrower Borrower { get; set; }
        public virtual Disk Disk { get; set; }
        public List<DiskBorrower> Borrowers { get; set; }
        public List<Disk> Disks { get; set; }
        public DiskHasBorrower CurrentVM { get; set; }
    }
}
