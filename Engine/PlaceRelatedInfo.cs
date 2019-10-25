using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class PlaceRelatedInfo
    {
        public string RelatedPictureURL
        {
            get;
            set;
        }

        public string RelatedPost
        {
            get;
            set;
        }

        public DateTime RelatedDateTime
        {
            get;
            set;
        }

        public PlaceRelatedInfo(string i_RelatedPictureURL, string i_RelatedPost, DateTime i_RelatedDateTime)
        {
            RelatedPictureURL = i_RelatedPictureURL;
            RelatedPost = i_RelatedPost;
            RelatedDateTime = i_RelatedDateTime;
        }
    }
}
