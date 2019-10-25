using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Engine.UserData
{
    public class BasicStatusData : IEnumerable<BasicUserData>
    {
        private Status m_Status;

        public BasicStatusData(Status i_Status)
        {
            m_Status = i_Status;
        }

        public IEnumerator<BasicUserData> GetEnumerator()
        {
            foreach (User user in m_Status.LikedBy)
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
