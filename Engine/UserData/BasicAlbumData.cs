using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Engine.UserData
{
    public class BasicAlbumData : IEnumerable<BasicPhotoData>
    {
        private Album m_Album;
        private string m_Name;

        public BasicAlbumData(Album i_Album)
        {
            m_Album = i_Album;
        }

        public string Name
        {
            get
            {
                if (m_Name == null)
                {
                    try
                    {
                        m_Name = m_Album.Name;
                    }
                    catch (Exception)
                    {
                    }
                }

                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }

        public IEnumerator<BasicPhotoData> GetEnumerator()
        {
            foreach (Photo photo in m_Album.Photos)
            {
                yield return new BasicPhotoData(photo);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
