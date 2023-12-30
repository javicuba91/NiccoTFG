using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGPlastic.Core.Entity
{
    public class TaskEntityPlastic
    {

        public String[] Changes { get; set; }
        public String Path { get; set; }
        public String ServerPath { get; set; }
        public bool IsLink { get; set; }
        public LocalInfoEntityPlastic LocalInfo { get; set; }
        public RevisionInfoEntityPlastic RevisionInfo { get; set; }

    }
}
