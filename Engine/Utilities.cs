using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Engine
{
    public class Utilities
    {
        public static DateTime UrlToDateTime(string i_UrlPath)
        {
            DateTime result = DateTime.MinValue;

            if (i_UrlPath!=null && i_UrlPath != "")
            {
                if (!DateTime.TryParseExact(i_UrlPath, "MM/dd/yyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out result))
                {
                    result = DateTime.MinValue;
                }
            }

            return result;
        }

        public static System.Drawing.Image UrlToImage(string i_UrlPath)
        {
            System.Drawing.Image image=null;
            WebClient webClient = new WebClient();
            byte[] dataToDownload;
            MemoryStream memoryStream;
            if (i_UrlPath!=null && i_UrlPath!="")
            {
                dataToDownload = webClient.DownloadData(i_UrlPath);
                memoryStream = new MemoryStream(dataToDownload);
                image = System.Drawing.Image.FromStream(memoryStream);
            }

            return image;
        }

        public static BasicUserData ConvertUserToBasicUserData(User i_User)
        {
            BasicUserData userInfo = new BasicUserData();

            try
            {
                userInfo.FirstName = i_User.FirstName.ToString();
                userInfo.LastName = i_User.LastName.ToString();
                userInfo.ImageUrl = i_User.PictureSmallURL;
                userInfo.Birthday = UrlToDateTime(i_User.Birthday);

                if(i_User.Location == null)
                {
                    userInfo.City = "Not Found";
                }
                else
                {
                    userInfo.City = i_User.Location.Name;
                }

                if(i_User.Friends == null)
                {
                    userInfo.FriendsCount = -1;
                }
                else
                {
                    userInfo.FriendsCount = i_User.Friends.Count;
                }

                if(i_User.InterestedIn == null)
                {
                    userInfo.InterestedIn = "Not Found";
                }
                else
                {
                    userInfo.InterestedIn=i_User.
                }
                userInfo.InterestedIn = i_User.InterestedIn == null ? "X" : string.Join(",", i_User.InterestedIn.Select(x => x.ToString()).ToArray());
                userInfo.UpdateTime = i_User.UpdateTime.HasValue ? i_User.UpdateTime.Value : DateTime.MinValue;
                userInfo.Gender = i_User.Gender.HasValue ? i_User.Gender.ToString() : "X";
                userInfo.RelationshipStatus = i_User.RelationshipStatus.HasValue ? i_User.RelationshipStatus.ToString() : "X";
            }
            catch (FacebookOAuthException)
            {
            }

            return userInfo;
        }
    }
}
