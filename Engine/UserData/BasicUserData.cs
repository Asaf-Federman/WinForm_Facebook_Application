using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Engine.UserData
{
    public class BasicUserData
    {
        private readonly object r_FetchFriendsLocker = new object();
        private readonly User r_User;
        private List<BasicPostData> m_Posts;
        private Friends m_Friends;
        private List<BasicAlbumData> m_Albums;
        private List<BasicPostData> m_PostsTaggedIn;
        private List<BasicCheckInData> m_Checkins;
        private List<BasicVideoData> m_Videos;
        private List<BasicEventData> m_Events;

        public BasicUserData(User i_User)
        {
            r_User = i_User;
            PictureNormalURL = r_User.PictureNormalURL;
            FirstName = r_User.FirstName;
            LastName = r_User.LastName;
            Name = GetFullName();
            Birthday = r_User.Birthday;
            About = r_User.About == null ? "None" : r_User.About;
            Id = r_User.Id;
            Cover = r_User.Cover;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Id
        {
            get;
            set;
        }

        public string About
        {
            get;
            set;
        }

        public string Birthday
        {
            get;
            set;
        }

        public List<BasicStatusData> Statuses
        {
            get;
            set;
        }

        public string GetFullName()
        {
            try
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<BasicPostData> Posts
        {
            get
            {
                if (m_Posts == null)
                {
                    m_Posts = makePostList();
                }

                return m_Posts;
            }

            set
            {
                m_Posts = value;
            }
        }

        public Friends Friends
        {
            get
            {
                if (m_Friends == null)
                {
                    lock (r_FetchFriendsLocker)
                    {
                        m_Friends = new Friends(makeBasicFriendList());
                    }
                }

                return m_Friends;
            }

            set
            {
                m_Friends = value;
            }
        }

        public List<BasicAlbumData> Albums
        {
            get
            {
                if (m_Albums == null)
                {
                    m_Albums = makeAlbumList();
                }

                return m_Albums;
            }

            set
            {
                m_Albums = value;
            }
        }

        public List<BasicPostData> PostsTaggedIn
        {
            get
            {
                if (m_PostsTaggedIn == null)
                {
                    m_PostsTaggedIn = makePostsTaggedInList();
                }

                return m_PostsTaggedIn;
            }

            set
            {
                m_PostsTaggedIn = value;
            }
        }

        public List<BasicEventData> Events
        {
            get
            {
                if (m_Events == null)
                {
                    m_Events = makeEventList();
                }

                return m_Events;
            }

            set
            {
                m_Events = value;
            }
        }

        public List<BasicCheckInData> Checkins
        {
            get
            {
                if (m_Checkins == null)
                {
                    m_Checkins = makeCheckinList();
                }

                return m_Checkins;
            }

            set
            {
                m_Checkins = value;
            }
        }

        public string PictureNormalURL
        {
            get;
            set;
        }

        public Cover Cover
        {
            get;
            set;
        }

        public void PostStatus(string i_StatusText, string i_PaceID = null, string i_PictureURL = null, string i_TaggedFriendIDs = null, string i_Link = null, string i_PrivacyParameterValue = null)
        {
            r_User.PostStatus(i_StatusText, i_PaceID, i_PictureURL, i_TaggedFriendIDs, i_Link, i_PrivacyParameterValue);
        }

        public List<BasicVideoData> Videos
        {
            get
            {
                if (m_Videos == null)
                {
                    m_Videos = makeVideosList();
                }

                return m_Videos;
            }

            set
            {
                m_Videos = value;
            }
        }

        private List<BasicEventData> makeEventList()
        {
            List<BasicEventData> basicEventDataList = new List<BasicEventData>();
            BasicEventData eventData;

            try
            {
                foreach (Event userEvent in r_User.Events)
                {
                    eventData = new BasicEventData(userEvent);
                    basicEventDataList.Add(eventData);
                }
            }
            catch (Exception)
            {
            }

            return basicEventDataList;
        }

        private List<BasicUserData> makeBasicFriendList()
        {
            List<BasicUserData> basicFriendList = new List<BasicUserData>();
            BasicUserData friend;

            try
            {
                foreach (User user in r_User.Friends)
                {
                    friend = new BasicUserData(user);
                    basicFriendList.Add(friend);
                }
            }
            catch (Exception)
            {
            }

            return basicFriendList;
        }

        private List<BasicStatusData> makeStatusesList()
        {
            List<BasicStatusData> basicStatusDataList = new List<BasicStatusData>();
            BasicStatusData statusData;

            try
            {
                foreach (Status status in r_User.Statuses)
                {
                    statusData = new BasicStatusData(status);
                    basicStatusDataList.Add(statusData);
                }
            }
            catch (Exception)
            {
            }

            return basicStatusDataList;
        }

        private List<BasicVideoData> makeVideosList()
        {
            List<BasicVideoData> basicVideoDataList = new List<BasicVideoData>();
            BasicVideoData videoData;

            try
            {
                foreach (Video video in r_User.Videos)
                {
                    videoData = new BasicVideoData(video);
                    basicVideoDataList.Add(videoData);
                }
            }
            catch (Exception)
            {
            }

            return basicVideoDataList;
        }

        private List<BasicPostData> makePostList()
        {
            List<BasicPostData> basicPostDataList = new List<BasicPostData>();
            BasicPostData postData;

            try
            {
                foreach (Post post in r_User.Posts)
                {
                    postData = new BasicPostData(post);
                    basicPostDataList.Add(postData);
                }
            }
            catch (Exception)
            {
            }

            return basicPostDataList;
        }

        private List<BasicPostData> makePostsTaggedInList()
        {
            List<BasicPostData> basicPostDataList = new List<BasicPostData>();
            BasicPostData postData;

            try
            {
                foreach (Post post in r_User.PostsTaggedIn)
                {
                    postData = new BasicPostData(post);
                    basicPostDataList.Add(postData);
                }
            }
            catch (Exception)
            {
            }

            return basicPostDataList;
        }

        private List<BasicCheckInData> makeCheckinList()
        {
            List<BasicCheckInData> basicCheckinDataList = new List<BasicCheckInData>();
            BasicCheckInData checkinData;

            try
            {
                foreach (Checkin checkin in r_User.Checkins)
                {
                    checkinData = new BasicCheckInData(checkin);
                    basicCheckinDataList.Add(checkinData);
                }
            }
            catch (Exception)
            {
            }

            return basicCheckinDataList;
        }

        private List<BasicAlbumData> makeAlbumList()
        {
            List<BasicAlbumData> basicAlbumDataList = new List<BasicAlbumData>();
            BasicAlbumData albumData;

            try
            {
                foreach (Album album in r_User.Albums)
                {
                    albumData = new BasicAlbumData(album);
                    basicAlbumDataList.Add(albumData);
                }
            }
            catch (Exception)
            {
            }

            return basicAlbumDataList;
        }
    }
}
