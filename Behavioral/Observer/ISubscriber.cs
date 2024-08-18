using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubscriber
    {
        // Może to być dowolny typ przekazanej wartości
        void Update(string context);
    }
}
