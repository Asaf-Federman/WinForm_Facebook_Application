using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Engine.UserData;

namespace Engine
{
    public class LoggedInUser
    {
        private const string k_ID = "1450160541956417";
        private static readonly object s_Lock = new object();
        private static LoggedInUser s_LoggedInInstance = null;
        private readonly string[] r_Permissions =
            {
            "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown"
        };

        private BasicUserData m_LoggedInUser;

        public static LoggedInUser InstanceOfLoggedInUser
        {
            get
            {
                if (s_LoggedInInstance == null)
                {
                    lock (s_Lock)
                    {
                        if (s_LoggedInInstance == null)
                        {
                            createLoggedInInstance();
                        }
                    }
                }

                return s_LoggedInInstance;
            }
        }

        public BasicUserData LoggedInUserInstance
        {
            get
            {
                if (m_LoggedInUser == null)
                {
                    createLoggedInUser();
                }

                return m_LoggedInUser;
            }
        }

        private static void createLoggedInInstance()
        {
            s_LoggedInInstance = new LoggedInUser();
        }

        private void createLoggedInUser()
        {
            LoginResult result = FacebookService.Login(k_ID, r_Permissions);
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = new BasicUserData(result.LoggedInUser);
                if (m_LoggedInUser == null)
                {
                    throw new Exception("Failed to create a new user");
                }
            }
            else
            {
                throw new Exception("Could not create a user");
            }
        }

        public void LogOut()
        {
            if (m_LoggedInUser != null)
            {
                FacebookService.Logout(() => m_LoggedInUser = null);
            }
        }
    }
}
