using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Engine.UserData
{
    public class BasicVideoData : IEnumerable<BasicUserData>
    {
        private Video m_Video;

        public BasicVideoData(Video i_Video)
        {
            m_Video = i_Video;
        }

        public IEnumerator<BasicUserData> GetEnumerator()
        {
            foreach (User user in m_Video.LikedBy)
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
