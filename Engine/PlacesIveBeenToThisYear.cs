using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.Interfaces;

namespace Engine
{
    public class PlacesIveBeenToThisYear : IFiltrer
    {
        public bool ShouldBeAdded(KeyValuePair<Place, int> i_Place)
        {
            bool isShouldBeAdded = false;
            DateTime currentTime = DateTime.Today;

            foreach (PlaceRelatedInfo placeRelatedInfo in i_Place.Key.PlaceRelatedInformationList)
            {
                if (placeRelatedInfo.RelatedDateTime.Year > currentTime.Year)
                {
                    isShouldBeAdded = !isShouldBeAdded;
                    break;
                }
            }

            return isShouldBeAdded;
        }
    }
}