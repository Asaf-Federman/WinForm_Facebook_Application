using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Engine.UserData
{
    public class BasicPhotoData : IEnumerable<BasicUserData>
    {
        private Photo m_Photo;

        public BasicPhotoData(Photo i_Photo)
        {
            m_Photo = i_Photo;
            Name = i_Photo.Name;
            PictureNormalURL = m_Photo.PictureNormalURL;
            Message = m_Photo.Message;
            CreatedTime = m_Photo.CreatedTime;
            Place = m_Photo.Place;
        }

         public string Name
        {
            get;
            set;
        }

        public Page Place
        {
            get;
            set;
        }

        public string PictureNormalURL
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

        public IEnumerator<BasicUserData> GetEnumerator()
        {
            foreach (User user in m_Photo.LikedBy)
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
