using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class FilteredTopLikesFriends : FiltrerBase
    {
        private int StartFromIndex { get; set; }

        public FilteredTopLikesFriends(int i_AmountOfTopLikes)
        {
            r_User.Friends.FriendsList.Sort((firstFriend, secondFriend) => firstFriend.AmountOfLikes.CompareTo(secondFriend.AmountOfLikes));
            StartFromIndex = r_User.Friends.FriendsList.Count - i_AmountOfTopLikes;
        }

        protected override bool ShouldBeAdded(Friend i_Friend)
        {
            bool isShouldBeAdded = false;

            if (i_Friend.AmountOfLikes >= r_User.Friends.FriendsList[StartFromIndex].AmountOfLikes)
            {
                isShouldBeAdded = !isShouldBeAdded;
            }

            return isShouldBeAdded;
        }
    }
}