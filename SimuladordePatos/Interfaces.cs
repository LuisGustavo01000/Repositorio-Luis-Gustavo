using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladordePatos
{
    public interface IFlyable
    {
        void fly();
    }

    public interface IQuackable
    {
        void quack();
    }

    public interface ISwinable
    {
        void swin();
    }
}
