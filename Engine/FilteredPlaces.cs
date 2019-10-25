using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.Interfaces;

namespace Engine
{
    public class FilteredPlaces
    {
        public IFiltrer Filtrer { get; set; }

        public FilteredPlaces(IFiltrer i_Filtrer)
        {
            Filtrer = i_Filtrer;
        }

        public void Filter(List<Place> i_PlacesToFilter)
        {
            Places places = new Places();

            foreach (KeyValuePair<Place, int> placeInt in places.PlacesIveBeenMap)
            {
                if (Filtrer.ShouldBeAdded(placeInt))
                {
                    i_PlacesToFilter.Add(placeInt.Key);
                }
            }
        }
    }
}