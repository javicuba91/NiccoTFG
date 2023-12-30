using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGPlastic.Core.Entity
{
    public class RevisionInfoEntityPlastic
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ItemId { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public string Hash { get; set; }
        public int BranchId { get; set; }
        public int ChangesetId { get; set; }
        public bool IsCheckedOut { get; set; }
        public DateTime CreationDate { get; set; }
        public RepositoryIdEntityPlastic RepositoryId { get; set; }
        public OwnerEntityPlastic Owner { get; set; }

    }
}
