using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Engine.UserData
{
    public class BasicCheckInData : IEnumerable<BasicUserData>
    {
        private Checkin m_Checkin;

        public BasicCheckInData(Checkin i_Checkin)
        {
            try
            {
                m_Checkin = i_Checkin;
                Place = m_Checkin.Place;
                PictureURL = m_Checkin.PictureURL;
                Message = m_Checkin.Message;
                CreatedTime = m_Checkin.CreatedTime;
            }
            catch (Exception)
            {
            }
        }

        public string PictureURL
        {
            get;
            set;
        }

        public string Message
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

        public IEnumerator<BasicUserData> GetEnumerator()
        {
            foreach (User user in m_Checkin.LikedBy)
            {
                yield return new BasicUserData(user);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
