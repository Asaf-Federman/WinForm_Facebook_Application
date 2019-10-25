using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.UserData;

namespace Engine
{
    public abstract class FiltrerBase
    {
        protected readonly BasicUserData r_User = LoggedInUser.InstanceOfLoggedInUser.LoggedInUserInstance;

        public void Filter(List<Friend> i_FriendsToFilter)
        {
            foreach (Friend friend in r_User.Friends.FriendsList)
            {
                if (ShouldBeAdded(friend))
                {
                    i_FriendsToFilter.Add(friend);
                }
            }
        }

        protected abstract bool ShouldBeAdded(Friend i_Friend);
    }
}
