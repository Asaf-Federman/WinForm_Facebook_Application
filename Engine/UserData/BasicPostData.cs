using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Engine.UserData
{
    public class BasicPostData : IEnumerable<BasicUserData>
    {
        private Post m_Post;

        public BasicPostData(Post i_Post)
        {
            m_Post = i_Post;
            Place = i_Post.Place;
            PictureURL = i_Post.PictureURL;
            Message = i_Post.Message;
            CreatedTime = i_Post.CreatedTime ?? DateTime.Now;
            Source = i_Post.Source;
        }

        public Page Place
        {
            get;
            set;
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

        public DateTime CreatedTime
        {
            get;
            set;
        }

        public string Source
        {
            get;
            set;
        }

        public IEnumerator<BasicUserData> GetEnumerator()
        {
            foreach (User user in m_Post.LikedBy)
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
