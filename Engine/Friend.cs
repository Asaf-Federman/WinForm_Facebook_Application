using FacebookWrapper.ObjectModel;
using Engine.UserData;

namespace Engine
{
    public class Friend
    {
        public string Name
        {
            get;
            set;
        }

        public BasicUserData FacebookUser
        {
            get;
            set;
        }

        public int AmountOfLikes
        {
            get;
            set;
        }

        public Friend(BasicUserData i_Friend, int i_Likes, string i_Name)
        {
            FacebookUser = i_Friend;
            AmountOfLikes = i_Likes;
            Name = i_Name;
        }
    }
}
