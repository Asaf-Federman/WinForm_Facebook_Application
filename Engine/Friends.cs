using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using Engine.UserData;

namespace Engine
{
    public class Friends
    {
        private readonly BasicUserData r_User;

        public List<Friend> FriendsList
        {
            get;
            set;
        }

        public Friends(List<BasicUserData> i_Friends)
        {
            r_User = LoggedInUser.InstanceOfLoggedInUser.LoggedInUserInstance;
            fetchFriends(i_Friends);
        }

        private void fetchFriends(List<BasicUserData> i_Friends)
        {
            Dictionary<BasicUserData, int> friendsMap = initalizeFriendsMap(i_Friends);

            fetchAlbumLikes(friendsMap);
            fetchPostsLikes(friendsMap);
            fetchCheckinLikes(friendsMap);
            fetchVideoLikes(friendsMap);
            fetchStatusLikes(friendsMap);
            initalizeFriendsList(friendsMap);
        }

        private void initalizeFriendsList(Dictionary<BasicUserData, int> i_FriendsMap)
        {
            FriendsList = new List<Friend>(i_FriendsMap.Count);
            foreach (KeyValuePair<BasicUserData, int> valuePair in i_FriendsMap)
            {
                FriendsList.Add(new Friend(valuePair.Key, valuePair.Value, valuePair.Key.Name));
            }

            // FriendsList.Sort((firstFriend, secondFriend) => firstFriend.AmountOfLikes.CompareTo(secondFriend.AmountOfLikes));
        }

        private void fetchStatusLikes(Dictionary<BasicUserData, int> i_FriendsMap)
        {
            try
            {
                foreach (BasicStatusData status in r_User.Statuses)
                {
                    foreach (BasicUserData user in status)
                    {
                        if (i_FriendsMap.ContainsKey(user))
                        {
                            i_FriendsMap[user]++;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void fetchVideoLikes(Dictionary<BasicUserData, int> i_FriendsMap)
        {
            try
            {
                foreach (BasicVideoData video in r_User.Videos)
                {
                    foreach (BasicUserData user in video)
                    {
                        if (i_FriendsMap.ContainsKey(user))
                        {
                            i_FriendsMap[user]++;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void fetchPostsLikes(Dictionary<BasicUserData, int> i_FriendsMap)
        {
            List<BasicPostData> posts = new List<BasicPostData>();

            try
            {
                posts.AddRange(r_User.Posts);
                posts.AddRange(r_User.PostsTaggedIn);
                foreach (BasicPostData post in posts)
                {
                    foreach (BasicUserData user in post)
                    {
                        if (i_FriendsMap.ContainsKey(user))
                        {
                            i_FriendsMap[user]++;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void fetchCheckinLikes(Dictionary<BasicUserData, int> i_FriendsMap)
        {
            try
            {
                foreach (BasicCheckInData checkin in r_User.Checkins)
                {
                    foreach (BasicUserData user in checkin)
                    {
                        if (i_FriendsMap.ContainsKey(user))
                        {
                            i_FriendsMap[user]++;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void fetchAlbumLikes(Dictionary<BasicUserData, int> i_FriendsMap)
        {
            try
            {
                foreach (BasicAlbumData album in r_User.Albums)
                {
                    foreach (BasicPhotoData photo in album)
                    {
                        foreach (BasicUserData user in photo)
                        {
                            if (i_FriendsMap.ContainsKey(user))
                            {
                                i_FriendsMap[user]++;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private Dictionary<BasicUserData, int> initalizeFriendsMap(List<BasicUserData> i_Friends)
        {
            Dictionary<BasicUserData, int> friendsMap = new Dictionary<BasicUserData, int>(i_Friends.Count);

            foreach (BasicUserData user in i_Friends)
            {
                friendsMap.Add(user, 0);
            }

            return friendsMap;
        }

        public List<Friend> FetchTopLikeFriends(int i_AmountOfFriends)
        {
            List<Friend> mostLikeList = new List<Friend>(i_AmountOfFriends);

            if (i_AmountOfFriends < FriendsList.Count)
            {
                for (int i = FriendsList.Count - i_AmountOfFriends; i < FriendsList.Count; ++i)
                {
                    mostLikeList.Add(FriendsList[i]);
                }
            }
            else
            {
                mostLikeList = FriendsList;
            }

            return mostLikeList;
        }
    }
}
