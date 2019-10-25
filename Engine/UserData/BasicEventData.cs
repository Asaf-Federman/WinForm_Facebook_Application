using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Engine.UserData
{
    public class BasicEventData
    {
        private Event m_Event;
        private List<BasicUserData> m_DeclinedUsers;
        private List<BasicUserData> m_AttendingUsers;

        public BasicEventData(Event i_Event)
        {
            m_Event = i_Event;
            Name = m_Event.Name;
            PictureNormalURL = m_Event.PictureNormalURL;
            Description = m_Event.Description;
            StartTime = m_Event.StartTime;
            Place = m_Event.Place;
        }

        public string Description
        {
            get;
            set;
        }

        public DateTime? StartTime
        {
            get;
            set;
        }

        public string PictureNormalURL
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string PictureURL
        {
            get;
            set;
        }

        public DateTime? CreatedTime
        {
            get;
            set;
        }

        public Page Place
        {
            get;
            set;
        }

        public List<BasicUserData> DeclinedUsers
        {
            get
            {
                if (m_DeclinedUsers == null)
                {
                    m_DeclinedUsers = makeDeclinedUsersList();
                }

                return m_DeclinedUsers;
            }

            set
            {
                m_DeclinedUsers = value;
            }
        }

        public List<BasicUserData> AttendingUsers
        {
            get
            {
                if (m_AttendingUsers == null)
                {
                    m_AttendingUsers = makeAttendingUsersList();
                }

                return m_AttendingUsers;
            }

            set
            {
                m_AttendingUsers = value;
            }
        }

        private List<BasicUserData> makeDeclinedUsersList()
        {
            FacebookObjectCollection<User> declinedUserList = m_Event.DeclinedUsers;
            List<BasicUserData> declinedBasicUserDataList = new List<BasicUserData>();
            BasicUserData basicUserData;

            foreach (User user in declinedUserList)
            {
                basicUserData = new BasicUserData(user);
                declinedBasicUserDataList.Add(basicUserData);
            }

            return declinedBasicUserDataList;
        }

        private List<BasicUserData> makeAttendingUsersList()
        {
            FacebookObjectCollection<User> attendingUserList = m_Event.AttendingUsers;
            List<BasicUserData> attendingBasicUserDataList = new List<BasicUserData>();
            BasicUserData basicUserData;

            foreach (User user in attendingUserList)
            {
                basicUserData = new BasicUserData(user);
                attendingBasicUserDataList.Add(basicUserData);
            }

            return attendingBasicUserDataList;
        }
    }
}
