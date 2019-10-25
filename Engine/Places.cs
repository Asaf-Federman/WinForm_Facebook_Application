using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using Engine.UserData;

namespace Engine
{
    public class Places
    {
        private readonly BasicUserData r_User;

        public Dictionary<Place, int> PlacesIveBeenMap
        {
            get;
            set;
        }

        public Places()
        {
            r_User = LoggedInUser.InstanceOfLoggedInUser.LoggedInUserInstance;
            fetchPlaces();
        }

        private void fetchPlaces()
        {
            PlacesIveBeenMap = new Dictionary<Place, int>();

            fetchFromAlbums(PlacesIveBeenMap);
            fetchFromPosts(PlacesIveBeenMap);
            fetchFromCheckins(PlacesIveBeenMap);
            fetchFromEvents(PlacesIveBeenMap);
        }

        private void fetchFromAlbums(Dictionary<Place, int> i_PlacesIveBeenMap)
        {
            string city, country, imageURL, message;
            DateTime time;

            foreach (BasicAlbumData album in r_User.Albums)
            {
                foreach (BasicPhotoData photo in album)
                {
                    try
                    {
                        city = photo.Place.Location.City;
                        country = photo.Place.Location.Country;
                        imageURL = photo.PictureNormalURL;
                        message = photo.Message;
                        time = photo.CreatedTime ?? DateTime.MinValue;
                        addPlaceToMap(city, country, imageURL, message, time, i_PlacesIveBeenMap);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void fetchFromPosts(Dictionary<Place, int> i_PlacesIveBeenMap)
        {
            List<BasicPostData> posts = new List<BasicPostData>();
            string city, country, imageURL, message;
            DateTime time;

            try
            {
                posts.AddRange(r_User.Posts);
                posts.AddRange(r_User.PostsTaggedIn);
                foreach (BasicPostData post in posts)
                {
                    city = post.Place.Location.City;
                    country = post.Place.Location.Country;
                    imageURL = post.PictureURL;
                    message = post.Message;
                    time = post.CreatedTime;
                    addPlaceToMap(city, country, imageURL, message, time, i_PlacesIveBeenMap);
                }
            }
            catch (Exception)
            {
            }
        }

        private void fetchFromCheckins(Dictionary<Place, int> i_PlacesIveBeenMap)
        {
            string city, country, imageURL, message;
            DateTime time;

            foreach (BasicCheckInData checkin in r_User.Checkins)
            {
                try
                {
                    city = checkin.Place.Location.City;
                    country = checkin.Place.Location.Country;
                    imageURL = checkin.PictureURL;
                    message = checkin.Message;
                    time = checkin.CreatedTime ?? DateTime.MinValue;
                    addPlaceToMap(city, country, imageURL, message, time, i_PlacesIveBeenMap);
                }
                catch (Exception)
                {
                }
            }
        }

        private void fetchFromEvents(Dictionary<Place, int> i_PlacesIveBeenMap)
        {
            string city, country, imageURL, message;
            DateTime time;

            foreach (BasicEventData evnt in r_User.Events)
            {
                try
                {
                    city = evnt.Place.Location.City;
                    country = evnt.Place.Location.Country;
                    imageURL = evnt.PictureNormalURL;
                    message = evnt.Description;
                    time = evnt.StartTime ?? DateTime.MinValue;
                    addPlaceToMap(city, country, imageURL, message, time, i_PlacesIveBeenMap);
                }
                catch (Exception)
                {
                }
            }
        }

        private void addPlaceToMap(string i_City, string i_Country, string i_ImageURL, string i_Post, DateTime i_Time, Dictionary<Place, int> i_PlacesIveBeenMap)
        {
            string fullPlaceName = Place.PlaceToString(i_Country, i_City);
            PlaceRelatedInfo placeRelatedInformation = new PlaceRelatedInfo(i_ImageURL, i_Post, i_Time);
            bool isPlaceExist = false;
            string currentPlaceName;

            foreach (Place place in i_PlacesIveBeenMap.Keys)
            {
                currentPlaceName = Place.PlaceToString(place.CountryName, place.CityName);

                if (currentPlaceName.Equals(fullPlaceName))
                {
                    place.AddRelatedInformation(placeRelatedInformation);
                    i_PlacesIveBeenMap[place]++;
                    isPlaceExist = !isPlaceExist;
                }
            }

            if (!isPlaceExist)
            {
                Place newPlace = new Place(i_Country, i_City);

                newPlace.AddRelatedInformation(placeRelatedInformation);
                i_PlacesIveBeenMap.Add(newPlace, 1);
            }
        }
    }
}