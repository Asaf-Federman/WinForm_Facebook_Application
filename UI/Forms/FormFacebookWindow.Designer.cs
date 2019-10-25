namespace UI.Forms
{
    public partial class FormFacebookWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage placesTab;
            System.Windows.Forms.Label descriptionEventLabel;
            System.Windows.Forms.Label nameLabel;
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.placeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.placeDateTimeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.placesPictureBox = new System.Windows.Forms.PictureBox();
            this.placesListBox = new System.Windows.Forms.ListBox();
            this.fetchPlacesButton = new System.Windows.Forms.Button();
            this.facebookTabs = new System.Windows.Forms.TabControl();
            this.facebookPosts = new System.Windows.Forms.TabPage();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.PostStatusLabel = new System.Windows.Forms.Label();
            this.fetchPostsButton = new System.Windows.Forms.Button();
            this.facebookFriends = new System.Windows.Forms.TabPage();
            this.friendPostLabel = new System.Windows.Forms.Label();
            this.friendPostsListBox = new System.Windows.Forms.ListBox();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.fetchFriendsButton = new System.Windows.Forms.Button();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.friendnameLabel = new System.Windows.Forms.Label();
            this.friendsLabel = new System.Windows.Forms.Label();
            this.friendImageBox = new System.Windows.Forms.PictureBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.picturesTab = new System.Windows.Forms.TabPage();
            this.albumPictureLabel = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.albumsPhotoBox = new System.Windows.Forms.PictureBox();
            this.photosListBox = new System.Windows.Forms.ListBox();
            this.albumsListBox = new System.Windows.Forms.ListBox();
            this.FetchAlbums = new System.Windows.Forms.Button();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionEventTextBox = new System.Windows.Forms.TextBox();
            this.basicEventDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameEventLabel = new System.Windows.Forms.Label();
            this.eventInfoLabel = new System.Windows.Forms.Label();
            this.eventPictureBox = new System.Windows.Forms.PictureBox();
            this.eventsLabel = new System.Windows.Forms.Label();
            this.declineLabel = new System.Windows.Forms.Label();
            this.participateLabel = new System.Windows.Forms.Label();
            this.participateListBox = new System.Windows.Forms.ListBox();
            this.declineListBox = new System.Windows.Forms.ListBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.fetchEventsButton = new System.Windows.Forms.Button();
            this.topLikeTab = new System.Windows.Forms.TabPage();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.topLikesTextBox = new System.Windows.Forms.TextBox();
            this.greetingButton = new System.Windows.Forms.Button();
            this.topLikesPhoto = new System.Windows.Forms.PictureBox();
            this.numberOfLikesLabel = new System.Windows.Forms.Label();
            this.topLikesButton = new System.Windows.Forms.Button();
            this.topLikesListBox = new System.Windows.Forms.ListBox();
            this.topLikesLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            placesTab = new System.Windows.Forms.TabPage();
            descriptionEventLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            placesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placesPictureBox)).BeginInit();
            this.facebookTabs.SuspendLayout();
            this.facebookPosts.SuspendLayout();
            this.facebookFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendImageBox)).BeginInit();
            this.picturesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsPhotoBox)).BeginInit();
            this.eventTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basicEventDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).BeginInit();
            this.topLikeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLikesPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // placesTab
            // 
            placesTab.BackColor = System.Drawing.SystemColors.Control;
            placesTab.Controls.Add(this.descriptionLabel);
            placesTab.Controls.Add(this.placeDescriptionTextBox);
            placesTab.Controls.Add(this.timeLabel);
            placesTab.Controls.Add(this.placeDateTimeListBox);
            placesTab.Controls.Add(this.label1);
            placesTab.Controls.Add(this.placesPictureBox);
            placesTab.Controls.Add(this.placesListBox);
            placesTab.Controls.Add(this.fetchPlacesButton);
            placesTab.Location = new System.Drawing.Point(4, 25);
            placesTab.Name = "placesTab";
            placesTab.Size = new System.Drawing.Size(791, 266);
            placesTab.TabIndex = 3;
            placesTab.Text = "Places";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.descriptionLabel.Location = new System.Drawing.Point(538, 130);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 20);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Description";
            // 
            // placeDescriptionTextBox
            // 
            this.placeDescriptionTextBox.Location = new System.Drawing.Point(403, 153);
            this.placeDescriptionTextBox.Multiline = true;
            this.placeDescriptionTextBox.Name = "placeDescriptionTextBox";
            this.placeDescriptionTextBox.Size = new System.Drawing.Size(379, 92);
            this.placeDescriptionTextBox.TabIndex = 13;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeLabel.Location = new System.Drawing.Point(198, 19);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(203, 20);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "The time I\'ve been there";
            // 
            // placeDateTimeListBox
            // 
            this.placeDateTimeListBox.FormattingEnabled = true;
            this.placeDateTimeListBox.ItemHeight = 16;
            this.placeDateTimeListBox.Location = new System.Drawing.Point(202, 49);
            this.placeDateTimeListBox.Name = "placeDateTimeListBox";
            this.placeDateTimeListBox.Size = new System.Drawing.Size(191, 196);
            this.placeDateTimeListBox.TabIndex = 11;
            this.placeDateTimeListBox.SelectedIndexChanged += new System.EventHandler(this.placeDateTimeListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "The places i\'ve been:";
            // 
            // placesPictureBox
            // 
            this.placesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.placesPictureBox.Location = new System.Drawing.Point(426, 10);
            this.placesPictureBox.Name = "placesPictureBox";
            this.placesPictureBox.Size = new System.Drawing.Size(127, 108);
            this.placesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.placesPictureBox.TabIndex = 8;
            this.placesPictureBox.TabStop = false;
            // 
            // placesListBox
            // 
            this.placesListBox.FormattingEnabled = true;
            this.placesListBox.ItemHeight = 16;
            this.placesListBox.Location = new System.Drawing.Point(18, 49);
            this.placesListBox.Name = "placesListBox";
            this.placesListBox.Size = new System.Drawing.Size(166, 196);
            this.placesListBox.TabIndex = 7;
            this.placesListBox.SelectedIndexChanged += new System.EventHandler(this.placesListBox_SelectedIndexChanged);
            // 
            // fetchPlacesButton
            // 
            this.fetchPlacesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fetchPlacesButton.Location = new System.Drawing.Point(590, 19);
            this.fetchPlacesButton.Name = "fetchPlacesButton";
            this.fetchPlacesButton.Size = new System.Drawing.Size(192, 56);
            this.fetchPlacesButton.TabIndex = 6;
            this.fetchPlacesButton.Text = "Fetch Places";
            this.fetchPlacesButton.UseVisualStyleBackColor = true;
            this.fetchPlacesButton.Click += new System.EventHandler(this.fetchPlacesButton_Click);
            // 
            // descriptionEventLabel
            // 
            descriptionEventLabel.AutoSize = true;
            descriptionEventLabel.Location = new System.Drawing.Point(3, 40);
            descriptionEventLabel.Name = "descriptionEventLabel";
            descriptionEventLabel.Size = new System.Drawing.Size(79, 16);
            descriptionEventLabel.TabIndex = 0;
            descriptionEventLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 14);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 16);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // facebookTabs
            // 
            this.facebookTabs.Controls.Add(this.facebookPosts);
            this.facebookTabs.Controls.Add(this.facebookFriends);
            this.facebookTabs.Controls.Add(placesTab);
            this.facebookTabs.Controls.Add(this.picturesTab);
            this.facebookTabs.Controls.Add(this.eventTab);
            this.facebookTabs.Controls.Add(this.topLikeTab);
            this.facebookTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.facebookTabs.Location = new System.Drawing.Point(-6, 129);
            this.facebookTabs.Name = "facebookTabs";
            this.facebookTabs.SelectedIndex = 0;
            this.facebookTabs.Size = new System.Drawing.Size(799, 295);
            this.facebookTabs.TabIndex = 1;
            // 
            // facebookPosts
            // 
            this.facebookPosts.BackColor = System.Drawing.Color.Transparent;
            this.facebookPosts.Controls.Add(this.postsListBox);
            this.facebookPosts.Controls.Add(this.buttonPostStatus);
            this.facebookPosts.Controls.Add(this.textBoxStatus);
            this.facebookPosts.Controls.Add(this.PostStatusLabel);
            this.facebookPosts.Controls.Add(this.fetchPostsButton);
            this.facebookPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.facebookPosts.Location = new System.Drawing.Point(4, 25);
            this.facebookPosts.Name = "facebookPosts";
            this.facebookPosts.Padding = new System.Windows.Forms.Padding(3);
            this.facebookPosts.Size = new System.Drawing.Size(791, 266);
            this.facebookPosts.TabIndex = 1;
            this.facebookPosts.Text = "Posts";
            // 
            // postsListBox
            // 
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.Location = new System.Drawing.Point(18, 86);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(764, 160);
            this.postsListBox.TabIndex = 51;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostStatus.Location = new System.Drawing.Point(655, 18);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(127, 36);
            this.buttonPostStatus.TabIndex = 50;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(352, 28);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(277, 20);
            this.textBoxStatus.TabIndex = 49;
            // 
            // PostStatusLabel
            // 
            this.PostStatusLabel.AutoSize = true;
            this.PostStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PostStatusLabel.Location = new System.Drawing.Point(256, 29);
            this.PostStatusLabel.Name = "PostStatusLabel";
            this.PostStatusLabel.Size = new System.Drawing.Size(90, 16);
            this.PostStatusLabel.TabIndex = 48;
            this.PostStatusLabel.Text = "Post Status:";
            // 
            // fetchPostsButton
            // 
            this.fetchPostsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fetchPostsButton.Location = new System.Drawing.Point(18, 7);
            this.fetchPostsButton.Name = "fetchPostsButton";
            this.fetchPostsButton.Size = new System.Drawing.Size(180, 60);
            this.fetchPostsButton.TabIndex = 0;
            this.fetchPostsButton.Text = "Fetch Posts";
            this.fetchPostsButton.UseVisualStyleBackColor = true;
            this.fetchPostsButton.Click += new System.EventHandler(this.fetchPostsButton_Click);
            // 
            // facebookFriends
            // 
            this.facebookFriends.BackColor = System.Drawing.SystemColors.Control;
            this.facebookFriends.Controls.Add(this.friendPostLabel);
            this.facebookFriends.Controls.Add(this.friendPostsListBox);
            this.facebookFriends.Controls.Add(this.aboutLabel);
            this.facebookFriends.Controls.Add(this.fetchFriendsButton);
            this.facebookFriends.Controls.Add(this.birthdayLabel);
            this.facebookFriends.Controls.Add(this.friendnameLabel);
            this.facebookFriends.Controls.Add(this.friendsLabel);
            this.facebookFriends.Controls.Add(this.friendImageBox);
            this.facebookFriends.Controls.Add(this.friendsListBox);
            this.facebookFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.facebookFriends.Location = new System.Drawing.Point(4, 25);
            this.facebookFriends.Name = "facebookFriends";
            this.facebookFriends.Padding = new System.Windows.Forms.Padding(3);
            this.facebookFriends.Size = new System.Drawing.Size(791, 266);
            this.facebookFriends.TabIndex = 2;
            this.facebookFriends.Text = "Friends";
            // 
            // friendPostLabel
            // 
            this.friendPostLabel.AutoSize = true;
            this.friendPostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendPostLabel.Location = new System.Drawing.Point(500, 87);
            this.friendPostLabel.Name = "friendPostLabel";
            this.friendPostLabel.Size = new System.Drawing.Size(47, 16);
            this.friendPostLabel.TabIndex = 8;
            this.friendPostLabel.Text = "Posts";
            // 
            // friendPostsListBox
            // 
            this.friendPostsListBox.FormattingEnabled = true;
            this.friendPostsListBox.Location = new System.Drawing.Point(503, 106);
            this.friendPostsListBox.Name = "friendPostsListBox";
            this.friendPostsListBox.Size = new System.Drawing.Size(279, 147);
            this.friendPostsListBox.TabIndex = 7;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.aboutLabel.Location = new System.Drawing.Point(282, 198);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(52, 16);
            this.aboutLabel.TabIndex = 6;
            this.aboutLabel.Text = "About:";
            // 
            // fetchFriendsButton
            // 
            this.fetchFriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fetchFriendsButton.Location = new System.Drawing.Point(590, 16);
            this.fetchFriendsButton.Name = "fetchFriendsButton";
            this.fetchFriendsButton.Size = new System.Drawing.Size(192, 56);
            this.fetchFriendsButton.TabIndex = 5;
            this.fetchFriendsButton.Text = "Fetch Friends";
            this.fetchFriendsButton.UseVisualStyleBackColor = true;
            this.fetchFriendsButton.Click += new System.EventHandler(this.fetchFriendsButton_Click);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.birthdayLabel.Location = new System.Drawing.Point(281, 171);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(69, 16);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "Birthday:";
            // 
            // friendnameLabel
            // 
            this.friendnameLabel.AutoSize = true;
            this.friendnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendnameLabel.Location = new System.Drawing.Point(281, 145);
            this.friendnameLabel.Name = "friendnameLabel";
            this.friendnameLabel.Size = new System.Drawing.Size(53, 16);
            this.friendnameLabel.TabIndex = 3;
            this.friendnameLabel.Text = "Name:";
            // 
            // friendsLabel
            // 
            this.friendsLabel.AutoSize = true;
            this.friendsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsLabel.Location = new System.Drawing.Point(86, 16);
            this.friendsLabel.Name = "friendsLabel";
            this.friendsLabel.Size = new System.Drawing.Size(96, 20);
            this.friendsLabel.TabIndex = 1;
            this.friendsLabel.Text = "My Friends";
            // 
            // friendImageBox
            // 
            this.friendImageBox.Location = new System.Drawing.Point(283, 16);
            this.friendImageBox.Name = "friendImageBox";
            this.friendImageBox.Size = new System.Drawing.Size(164, 116);
            this.friendImageBox.TabIndex = 2;
            this.friendImageBox.TabStop = false;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(18, 54);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(239, 199);
            this.friendsListBox.TabIndex = 0;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // picturesTab
            // 
            this.picturesTab.BackColor = System.Drawing.SystemColors.Control;
            this.picturesTab.Controls.Add(this.albumPictureLabel);
            this.picturesTab.Controls.Add(this.albumLabel);
            this.picturesTab.Controls.Add(this.albumsPhotoBox);
            this.picturesTab.Controls.Add(this.photosListBox);
            this.picturesTab.Controls.Add(this.albumsListBox);
            this.picturesTab.Controls.Add(this.FetchAlbums);
            this.picturesTab.Location = new System.Drawing.Point(4, 25);
            this.picturesTab.Name = "picturesTab";
            this.picturesTab.Size = new System.Drawing.Size(791, 266);
            this.picturesTab.TabIndex = 4;
            this.picturesTab.Text = "Pictures";
            // 
            // albumPictureLabel
            // 
            this.albumPictureLabel.AutoSize = true;
            this.albumPictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.albumPictureLabel.Location = new System.Drawing.Point(231, 16);
            this.albumPictureLabel.Name = "albumPictureLabel";
            this.albumPictureLabel.Size = new System.Drawing.Size(142, 20);
            this.albumPictureLabel.TabIndex = 15;
            this.albumPictureLabel.Text = "Album\'s Pictures";
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.albumLabel.Location = new System.Drawing.Point(47, 16);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(95, 20);
            this.albumLabel.TabIndex = 14;
            this.albumLabel.Text = "My Albums";
            // 
            // albumsPhotoBox
            // 
            this.albumsPhotoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumsPhotoBox.Location = new System.Drawing.Point(623, 104);
            this.albumsPhotoBox.Name = "albumsPhotoBox";
            this.albumsPhotoBox.Size = new System.Drawing.Size(159, 147);
            this.albumsPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumsPhotoBox.TabIndex = 13;
            this.albumsPhotoBox.TabStop = false;
            // 
            // photosListBox
            // 
            this.photosListBox.FormattingEnabled = true;
            this.photosListBox.ItemHeight = 16;
            this.photosListBox.Location = new System.Drawing.Point(218, 55);
            this.photosListBox.Name = "photosListBox";
            this.photosListBox.Size = new System.Drawing.Size(168, 196);
            this.photosListBox.TabIndex = 12;
            this.photosListBox.SelectedIndexChanged += new System.EventHandler(this.photosListBox_SelectedIndexChanged);
            // 
            // albumsListBox
            // 
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.ItemHeight = 16;
            this.albumsListBox.Location = new System.Drawing.Point(22, 55);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(168, 196);
            this.albumsListBox.TabIndex = 11;
            this.albumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // FetchAlbums
            // 
            this.FetchAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FetchAlbums.Location = new System.Drawing.Point(590, 16);
            this.FetchAlbums.Name = "FetchAlbums";
            this.FetchAlbums.Size = new System.Drawing.Size(192, 56);
            this.FetchAlbums.TabIndex = 10;
            this.FetchAlbums.Text = "Fetch Albums";
            this.FetchAlbums.UseVisualStyleBackColor = true;
            this.FetchAlbums.Click += new System.EventHandler(this.fetchAlbums_Click);
            // 
            // eventTab
            // 
            this.eventTab.BackColor = System.Drawing.SystemColors.Control;
            this.eventTab.Controls.Add(this.panel1);
            this.eventTab.Controls.Add(this.eventInfoLabel);
            this.eventTab.Controls.Add(this.eventPictureBox);
            this.eventTab.Controls.Add(this.eventsLabel);
            this.eventTab.Controls.Add(this.declineLabel);
            this.eventTab.Controls.Add(this.participateLabel);
            this.eventTab.Controls.Add(this.participateListBox);
            this.eventTab.Controls.Add(this.declineListBox);
            this.eventTab.Controls.Add(this.eventsListBox);
            this.eventTab.Controls.Add(this.fetchEventsButton);
            this.eventTab.Location = new System.Drawing.Point(4, 25);
            this.eventTab.Name = "eventTab";
            this.eventTab.Size = new System.Drawing.Size(791, 266);
            this.eventTab.TabIndex = 5;
            this.eventTab.Text = "Events";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(descriptionEventLabel);
            this.panel1.Controls.Add(this.descriptionEventTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameEventLabel);
            this.panel1.Location = new System.Drawing.Point(391, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 147);
            this.panel1.TabIndex = 27;
            // 
            // descriptionEventTextBox
            // 
            this.descriptionEventTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.basicEventDataBindingSource, "Description", true));
            this.descriptionEventTextBox.Location = new System.Drawing.Point(6, 59);
            this.descriptionEventTextBox.Multiline = true;
            this.descriptionEventTextBox.Name = "descriptionEventTextBox";
            this.descriptionEventTextBox.Size = new System.Drawing.Size(237, 85);
            this.descriptionEventTextBox.TabIndex = 1;
            // 
            // basicEventDataBindingSource
            // 
            this.basicEventDataBindingSource.DataSource = typeof(Engine.UserData.BasicEventData);
            // 
            // nameEventLabel
            // 
            this.nameEventLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.basicEventDataBindingSource, "Name", true));
            this.nameEventLabel.Location = new System.Drawing.Point(57, 14);
            this.nameEventLabel.Name = "nameEventLabel";
            this.nameEventLabel.Size = new System.Drawing.Size(100, 23);
            this.nameEventLabel.TabIndex = 3;
            // 
            // eventInfoLabel
            // 
            this.eventInfoLabel.AutoSize = true;
            this.eventInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventInfoLabel.Location = new System.Drawing.Point(387, 75);
            this.eventInfoLabel.Name = "eventInfoLabel";
            this.eventInfoLabel.Size = new System.Drawing.Size(152, 20);
            this.eventInfoLabel.TabIndex = 26;
            this.eventInfoLabel.Text = "Event Information";
            // 
            // eventPictureBox
            // 
            this.eventPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eventPictureBox.Location = new System.Drawing.Point(623, 99);
            this.eventPictureBox.Name = "eventPictureBox";
            this.eventPictureBox.Size = new System.Drawing.Size(159, 147);
            this.eventPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eventPictureBox.TabIndex = 25;
            this.eventPictureBox.TabStop = false;
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventsLabel.Location = new System.Drawing.Point(50, 11);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(119, 20);
            this.eventsLabel.TabIndex = 23;
            this.eventsLabel.Text = "List of Events";
            // 
            // declineLabel
            // 
            this.declineLabel.AutoSize = true;
            this.declineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.declineLabel.Location = new System.Drawing.Point(224, 139);
            this.declineLabel.Name = "declineLabel";
            this.declineLabel.Size = new System.Drawing.Size(131, 20);
            this.declineLabel.TabIndex = 20;
            this.declineLabel.Text = "Declined Users";
            // 
            // participateLabel
            // 
            this.participateLabel.AutoSize = true;
            this.participateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.participateLabel.Location = new System.Drawing.Point(224, 13);
            this.participateLabel.Name = "participateLabel";
            this.participateLabel.Size = new System.Drawing.Size(139, 20);
            this.participateLabel.TabIndex = 19;
            this.participateLabel.Text = "Attending Users";
            // 
            // participateListBox
            // 
            this.participateListBox.FormattingEnabled = true;
            this.participateListBox.ItemHeight = 16;
            this.participateListBox.Location = new System.Drawing.Point(213, 36);
            this.participateListBox.Name = "participateListBox";
            this.participateListBox.Size = new System.Drawing.Size(168, 100);
            this.participateListBox.TabIndex = 18;
            // 
            // declineListBox
            // 
            this.declineListBox.FormattingEnabled = true;
            this.declineListBox.ItemHeight = 16;
            this.declineListBox.Location = new System.Drawing.Point(213, 162);
            this.declineListBox.Name = "declineListBox";
            this.declineListBox.Size = new System.Drawing.Size(168, 84);
            this.declineListBox.TabIndex = 16;
            // 
            // eventsListBox
            // 
            this.eventsListBox.DataSource = this.basicEventDataBindingSource;
            this.eventsListBox.DisplayMember = "Name";
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 16;
            this.eventsListBox.Location = new System.Drawing.Point(26, 34);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(168, 212);
            this.eventsListBox.TabIndex = 15;
            this.eventsListBox.SelectedIndexChanged += new System.EventHandler(this.eventsListBox_SelectedIndexChanged);
            // 
            // fetchEventsButton
            // 
            this.fetchEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fetchEventsButton.Location = new System.Drawing.Point(590, 13);
            this.fetchEventsButton.Name = "fetchEventsButton";
            this.fetchEventsButton.Size = new System.Drawing.Size(192, 56);
            this.fetchEventsButton.TabIndex = 14;
            this.fetchEventsButton.Text = "Fetch Events";
            this.fetchEventsButton.UseVisualStyleBackColor = true;
            this.fetchEventsButton.Click += new System.EventHandler(this.fetchEventsButton_Click);
            // 
            // topLikeTab
            // 
            this.topLikeTab.Controls.Add(this.greetingLabel);
            this.topLikeTab.Controls.Add(this.topLikesTextBox);
            this.topLikeTab.Controls.Add(this.greetingButton);
            this.topLikeTab.Controls.Add(this.topLikesPhoto);
            this.topLikeTab.Controls.Add(this.numberOfLikesLabel);
            this.topLikeTab.Controls.Add(this.topLikesButton);
            this.topLikeTab.Controls.Add(this.topLikesListBox);
            this.topLikeTab.Controls.Add(this.topLikesLabel);
            this.topLikeTab.Location = new System.Drawing.Point(4, 25);
            this.topLikeTab.Name = "topLikeTab";
            this.topLikeTab.Size = new System.Drawing.Size(791, 266);
            this.topLikeTab.TabIndex = 6;
            this.topLikeTab.Text = "Top Likes";
            this.topLikeTab.UseVisualStyleBackColor = true;
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.greetingLabel.Location = new System.Drawing.Point(25, 217);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(90, 16);
            this.greetingLabel.TabIndex = 51;
            this.greetingLabel.Text = "Post Status:";
            // 
            // topLikesTextBox
            // 
            this.topLikesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topLikesTextBox.Location = new System.Drawing.Point(121, 215);
            this.topLikesTextBox.Name = "topLikesTextBox";
            this.topLikesTextBox.Size = new System.Drawing.Size(277, 22);
            this.topLikesTextBox.TabIndex = 50;
            // 
            // greetingButton
            // 
            this.greetingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.greetingButton.Location = new System.Drawing.Point(414, 203);
            this.greetingButton.Name = "greetingButton";
            this.greetingButton.Size = new System.Drawing.Size(134, 42);
            this.greetingButton.TabIndex = 15;
            this.greetingButton.Text = "Post a greeting";
            this.greetingButton.UseVisualStyleBackColor = true;
            this.greetingButton.Click += new System.EventHandler(this.greetingButton_Click);
            // 
            // topLikesPhoto
            // 
            this.topLikesPhoto.Location = new System.Drawing.Point(254, 51);
            this.topLikesPhoto.Name = "topLikesPhoto";
            this.topLikesPhoto.Size = new System.Drawing.Size(130, 95);
            this.topLikesPhoto.TabIndex = 14;
            this.topLikesPhoto.TabStop = false;
            // 
            // numberOfLikesLabel
            // 
            this.numberOfLikesLabel.AutoSize = true;
            this.numberOfLikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numberOfLikesLabel.Location = new System.Drawing.Point(251, 167);
            this.numberOfLikesLabel.Name = "numberOfLikesLabel";
            this.numberOfLikesLabel.Size = new System.Drawing.Size(53, 16);
            this.numberOfLikesLabel.TabIndex = 13;
            this.numberOfLikesLabel.Text = "Likes: ";
            // 
            // topLikesButton
            // 
            this.topLikesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.topLikesButton.Location = new System.Drawing.Point(590, 17);
            this.topLikesButton.Name = "topLikesButton";
            this.topLikesButton.Size = new System.Drawing.Size(192, 56);
            this.topLikesButton.TabIndex = 12;
            this.topLikesButton.Text = "Fetch top likes";
            this.topLikesButton.UseVisualStyleBackColor = true;
            this.topLikesButton.Click += new System.EventHandler(this.topLikesButton_Click);
            // 
            // topLikesListBox
            // 
            this.topLikesListBox.FormattingEnabled = true;
            this.topLikesListBox.ItemHeight = 16;
            this.topLikesListBox.Location = new System.Drawing.Point(28, 51);
            this.topLikesListBox.Name = "topLikesListBox";
            this.topLikesListBox.Size = new System.Drawing.Size(185, 132);
            this.topLikesListBox.TabIndex = 11;
            this.topLikesListBox.SelectedIndexChanged += new System.EventHandler(this.topLikesListBox_SelectedIndexChanged);
            // 
            // topLikesLabel
            // 
            this.topLikesLabel.AutoSize = true;
            this.topLikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.topLikesLabel.Location = new System.Drawing.Point(24, 17);
            this.topLikesLabel.Name = "topLikesLabel";
            this.topLikesLabel.Size = new System.Drawing.Size(321, 20);
            this.topLikesLabel.TabIndex = 10;
            this.topLikesLabel.Text = "Top 5 friends who made the most likes:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userNameLabel.Location = new System.Drawing.Point(12, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(51, 20);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "label1";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.Control;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logoutButton.Location = new System.Drawing.Point(662, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(118, 32);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Location = new System.Drawing.Point(148, 41);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(632, 82);
            this.coverPictureBox.TabIndex = 3;
            this.coverPictureBox.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(16, 32);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(108, 91);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // FormFacebookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(781, 412);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.coverPictureBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.facebookTabs);
            this.Controls.Add(this.profilePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFacebookWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FacebookWindow";
            placesTab.ResumeLayout(false);
            placesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placesPictureBox)).EndInit();
            this.facebookTabs.ResumeLayout(false);
            this.facebookPosts.ResumeLayout(false);
            this.facebookPosts.PerformLayout();
            this.facebookFriends.ResumeLayout(false);
            this.facebookFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendImageBox)).EndInit();
            this.picturesTab.ResumeLayout(false);
            this.picturesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsPhotoBox)).EndInit();
            this.eventTab.ResumeLayout(false);
            this.eventTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basicEventDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).EndInit();
            this.topLikeTab.ResumeLayout(false);
            this.topLikeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLikesPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.TabControl facebookTabs;
        private System.Windows.Forms.TabPage facebookPosts;
        private System.Windows.Forms.TabPage facebookFriends;
        private System.Windows.Forms.Button fetchPostsButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Button fetchFriendsButton;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label friendnameLabel;
        private System.Windows.Forms.PictureBox friendImageBox;
        private System.Windows.Forms.Label friendsLabel;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label friendPostLabel;
        private System.Windows.Forms.ListBox friendPostsListBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox placesPictureBox;
        private System.Windows.Forms.ListBox placesListBox;
        private System.Windows.Forms.Button fetchPlacesButton;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label PostStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage picturesTab;
        private System.Windows.Forms.PictureBox albumsPhotoBox;
        private System.Windows.Forms.ListBox photosListBox;
        private System.Windows.Forms.ListBox albumsListBox;
        private System.Windows.Forms.Button FetchAlbums;
        private System.Windows.Forms.TabPage eventTab;
        private System.Windows.Forms.Label declineLabel;
        private System.Windows.Forms.Label participateLabel;
        private System.Windows.Forms.ListBox participateListBox;
        private System.Windows.Forms.ListBox declineListBox;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Button fetchEventsButton;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.TabPage topLikeTab;
        private System.Windows.Forms.Button topLikesButton;
        private System.Windows.Forms.ListBox topLikesListBox;
        private System.Windows.Forms.Label topLikesLabel;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.TextBox topLikesTextBox;
        private System.Windows.Forms.Button greetingButton;
        private System.Windows.Forms.PictureBox topLikesPhoto;
        private System.Windows.Forms.Label numberOfLikesLabel;
        private System.Windows.Forms.Label albumPictureLabel;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.TextBox placeDescriptionTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ListBox placeDateTimeListBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.Label eventInfoLabel;
        private System.Windows.Forms.PictureBox eventPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionEventTextBox;
        private System.Windows.Forms.BindingSource basicEventDataBindingSource;
        private System.Windows.Forms.Label nameEventLabel;
    }
}