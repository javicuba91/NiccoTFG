using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGPlastic.Core.Entity
{
    public interface ITareaRepository
    {
        Task Add(object a);
        Task Delete(object a);
        Task Update(object a);
    }
}
