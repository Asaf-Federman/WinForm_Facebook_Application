using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Engine;
using Engine.UserData;

namespace UI.Forms
{
    public partial class FormFacebookWindow : Form
    {
        private BasicUserData m_LoggedInUser;

        public FormFacebookWindow()
        {
            m_LoggedInUser = LoggedInUser.InstanceOfLoggedInUser.LoggedInUserInstance;
            InitializeComponent();
            Visible = true;
            fetchUserData();
            Text = "My Facebook Window";
        }

        private void fetchUserData()
        {
            profilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            userNameLabel.Text = m_LoggedInUser.FirstName + " " + m_LoggedInUser.LastName;
            try
            {
                coverPictureBox.LoadAsync(m_LoggedInUser.Cover.SourceURL);
            }
            catch (Exception)
            {
            }
        }

        private void fetchPostsButton_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            string posts;

            postsListBox.Items.Clear();
            foreach (BasicPostData post in m_LoggedInUser.Posts)
            {
                posts = post.Source + " " + post.Message + " ";
                postsListBox.Items.Add(posts);
            }
        }

        private void fetchPosts(BasicUserData i_User)
        {
            string posts;

            friendPostsListBox.Items.Clear();
            foreach (BasicPostData post in i_User.Posts)
            {
                posts = post.Source + " " + post.Message + " ";
                friendPostsListBox.Items.Add(posts);
            }

            if (m_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void postStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoggedInUser.PostStatus(textBoxStatus.Text);
            }
            catch (Exception)
            {
            }
        }

        private void fetchFriendsButton_Click(object sender, EventArgs e)
        {
            if (friendsListBox.Items.Count == 0)
            {
                Thread thread = new Thread(new ThreadStart(fetchFriends));

                thread.Start();
            }
        }

        private void fetchFriends()
        {
            fetchFriendsButton.Invoke(new Action(() => fetchFriendsButton.Enabled = false));
            friendsListBox.Invoke(new Action(() => friendsListBox.Items.Clear()));
            friendsListBox.Invoke(new Action(() => friendsListBox.DisplayMember = "Name"));
            foreach (Friend friend in m_LoggedInUser.Friends.FriendsList)
            {
                friendsListBox.Invoke(new Action(() => friendsListBox.Items.Add(friend)));
            }

            fetchFriendsButton.Invoke(new Action(() => fetchFriendsButton.Enabled = true));
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (friendsListBox.SelectedItems.Count == 1)
            {
                Friend selectedFriend = friendsListBox.SelectedItem as Friend;

                if (selectedFriend.FacebookUser.PictureNormalURL != null)
                {
                    friendImageBox.LoadAsync(selectedFriend.FacebookUser.PictureNormalURL);
                    friendnameLabel.Text = "Name: " + selectedFriend.Name;
                    birthdayLabel.Text = "Birthday: " + selectedFriend.FacebookUser.Birthday;
                    aboutLabel.Text = "About: " + selectedFriend.FacebookUser.About;
                    friendPostLabel.Text = string.Format("{0}'s posts are: ", selectedFriend.Name);
                    fetchPosts(selectedFriend.FacebookUser);
                }
                else
                {
                    friendImageBox.Image = friendImageBox.ErrorImage;
                }
            }
        }

        private void fetchPlacesButton_Click(object sender, EventArgs e)
        {
            if (placesListBox.Items.Count == 0)
            {
                Thread thread = new Thread(new ThreadStart(fetchPlaces));

                thread.Start();
            }
        }

        private void fetchPlaces()
        {
            fetchPlacesButton.Invoke(new Action(() => fetchPlacesButton.Enabled = false));
            List<Place> FilteredPlacesIveBeenList = new List<Place>();
            FilteredPlaces placesIveBeenToThisYear = new FilteredPlaces(new PlacesIveBeenToThisYear());
            placesIveBeenToThisYear.Filter(FilteredPlacesIveBeenList);

            placesListBox.Invoke(new Action(() => placesListBox.Items.Clear()));
            placesListBox.Invoke(new Action(() => placesListBox.DisplayMember = "FullPlaceName"));

            foreach (Place place in FilteredPlacesIveBeenList)
            {
                placesListBox.Invoke(new Action(() => placesListBox.Items.Add(place)));
            }

            fetchPlacesButton.Invoke(new Action(() => fetchPlacesButton.Enabled = true));
        }

        private void placesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetPlacesComponents();
            fetchDates();
        }

        private void resetPlacesComponents()
        {
            placeDescriptionTextBox.Text = null;
            placesPictureBox.Image = null;
        }

        private void fetchDates()
        {
            placeDateTimeListBox.Items.Clear();
            placeDateTimeListBox.DisplayMember = "relatedDateTime";
            if (placesListBox.SelectedItems.Count == 1)
            {
                Place place = placesListBox.SelectedItem as Place;

                foreach (PlaceRelatedInfo relatedInformation in place.PlaceRelatedInformationList)
                {
                    placeDateTimeListBox.Items.Add(relatedInformation);
                }
            }
        }

        private void placeDateTimeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchImage();
            fetchDescription();
        }

        private void fetchDescription()
        {
            try
            {
                if (placeDateTimeListBox.SelectedItems.Count == 1)
                {
                    PlaceRelatedInfo selectedRelatedInformation = placeDateTimeListBox.SelectedItem as PlaceRelatedInfo;

                    placeDescriptionTextBox.Text = selectedRelatedInformation.RelatedPost;
                }
            }
            catch (Exception)
            {
            }
        }

        private void fetchImage()
        {
            try
            {
                if (placeDateTimeListBox.SelectedItems.Count == 1)
                {
                    PlaceRelatedInfo selectedRelatedInformation = placeDateTimeListBox.SelectedItem as PlaceRelatedInfo;

                    placesPictureBox.LoadAsync(selectedRelatedInformation.RelatedPictureURL);
                }
            }
            catch (Exception)
            {
            }
        }

        private void fetchAlbums_Click(object sender, EventArgs e)
        {
            if (albumsListBox.Items.Count == 0)
            {
                fetchAlbums();
            }
        }

        private void fetchAlbums()
        {
            albumsListBox.DisplayMember = "Name";
            try
            {
                foreach (BasicAlbumData album in m_LoggedInUser.Albums)
                {
                    albumsListBox.Items.Add(album);
                }
            }
            catch (Exception)
            {
            }
        }

        private void albumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetAlbumComponents();
            displaySelectedAlbum();
        }

        private void resetAlbumComponents()
        {
            albumsPhotoBox.Image = null;
        }

        private void displaySelectedAlbum()
        {
            photosListBox.Items.Clear();
            photosListBox.DisplayMember = "Name";
            try
            {
                if (albumsListBox.SelectedItems.Count == 1)
                {
                    BasicAlbumData selectedAlbum = albumsListBox.SelectedItem as BasicAlbumData;

                    foreach (BasicPhotoData photo in selectedAlbum)
                    {
                        photosListBox.Items.Add(photo);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void photosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPhotosOfAlbum();
        }

        private void displaySelectedPhotosOfAlbum()
        {
            try
            {
                if (photosListBox.SelectedItems.Count == 1)
                {
                    BasicPhotoData selectedPhoto = photosListBox.SelectedItem as BasicPhotoData;

                    albumsPhotoBox.LoadAsync(selectedPhoto.PictureNormalURL);
                }
            }
            catch (Exception)
            {
            }
        }

        private void fetchEventsButton_Click(object sender, EventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            basicEventDataBindingSource.DataSource = m_LoggedInUser.Events;
        }

        private void eventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedEventAttending();
            displaySelectedEventDeclining();
            displaySelectedEventPhoto();
        }

        private void displaySelectedEventPhoto()
        {
            try
            {
                if (eventsListBox.SelectedItems.Count == 1)
                {
                    BasicEventData selectedEvent = eventsListBox.SelectedItem as BasicEventData;

                    eventPictureBox.LoadAsync(selectedEvent.PictureNormalURL);
                }
            }
            catch (Exception)
            {
            }
        }

        private void displaySelectedEventDeclining()
        {
            declineListBox.Items.Clear();
            declineListBox.DisplayMember = "Name";
            try
            {
                if (eventsListBox.SelectedItems.Count == 1)
                {
                    BasicEventData selectedEvent = eventsListBox.SelectedItem as BasicEventData;

                    foreach (BasicUserData participant in selectedEvent.DeclinedUsers)
                    {
                        declineListBox.Items.Add(participant);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void displaySelectedEventAttending()
        {
            participateListBox.Items.Clear();
            participateListBox.DisplayMember = "Name";
            try
            {
                if (eventsListBox.SelectedItems.Count == 1)
                {
                    BasicEventData selectedEvent = eventsListBox.SelectedItem as BasicEventData;

                    foreach (BasicUserData participant in selectedEvent.AttendingUsers)
                    {
                        participateListBox.Items.Add(participant);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void topLikesButton_Click(object sender, EventArgs e)
        {
            if (topLikesListBox.Items.Count == 0)
            {
                Thread thread = new Thread(new ThreadStart(fetchTopLikes));

                thread.Start();
            }
        }

        private void fetchTopLikes()
        {
            List<Friend> mostLikesList = new List<Friend>();

            topLikesButton.Invoke(new Action(() => topLikesButton.Enabled = false));
            FiltrerBase filterTopLikes = new FilteredTopLikesFriends(5);
            filterTopLikes.Filter(mostLikesList);
            
            topLikesButton.Invoke(new Action(() => topLikesListBox.DisplayMember = "name"));
            foreach (Friend friend in mostLikesList)
            {
                topLikesButton.Invoke(new Action(() => topLikesListBox.Items.Add(friend)));
            }

            topLikesButton.Invoke(new Action(() => topLikesButton.Enabled = true));
        }

        private void topLikesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedTopLikeFriend();
        }

        private void displaySelectedTopLikeFriend()
        {
            try
            {
                if (topLikesListBox.SelectedItems.Count == 1)
                {
                    Friend selectedFriend = topLikesListBox.SelectedItem as Friend;

                    topLikesPhoto.LoadAsync(selectedFriend.FacebookUser.PictureNormalURL);
                    numberOfLikesLabel.Text = "Likes: " + selectedFriend.AmountOfLikes;
                }
            }
            catch (Exception)
            {
            }
        }

        private void greetingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (topLikesListBox.SelectedItems.Count == 1)
                {
                    Friend friend = topLikesListBox.SelectedItem as Friend;

                    if (topLikesTextBox.TextLength > 0)
                    {
                        m_LoggedInUser.PostStatus(topLikesTextBox.Text, null, null, friend.FacebookUser.Id);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
