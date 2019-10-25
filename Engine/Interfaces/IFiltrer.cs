using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Interfaces
{
    public interface IFiltrer
    {
        bool ShouldBeAdded(KeyValuePair<Place, int> i_Place);
    }
}