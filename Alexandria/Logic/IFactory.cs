using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandria.Logic
{
    public interface IFactory<O>
    {
        O Create(String response);
    }
}
