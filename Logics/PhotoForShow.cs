using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public class PhotoForShow
    {
        public string URL { get; set; }

        public List<string> ListOfFrindsLiked { get; set; }

        public PhotoForShow(string i_URL, List<string> i_ListOfLikingFriends)
        {
            URL = i_URL;
            ListOfFrindsLiked = i_ListOfLikingFriends;
        }

        public PhotoForShow(Photo i_PhotoToConvert)
        {
            URL = i_PhotoToConvert.PictureNormalURL;
            ListOfFrindsLiked = new List<string>();
            foreach (User user in i_PhotoToConvert.LikedBy)
            {
                ListOfFrindsLiked.Add(user.Name);
            }
        }
    }
}
