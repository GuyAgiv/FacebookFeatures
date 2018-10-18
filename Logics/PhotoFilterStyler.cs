using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public abstract class PhotoFilterStyler
    {
        protected string ContextInputFromUser { get; set; }

        protected List<Photo> m_FilteredPhotos = new List<Photo>();

        protected abstract bool FilterStyleTest(Photo i_CurrentPhoto);

        public static PhotoFilterStyler Create(eFilterStyler i_FilterStyler, string i_FilterText)
        {
            PhotoFilterStyler result = null;
            if (i_FilterStyler.Equals(eFilterStyler.ByLocation))
            {
                result = new FilterByLocation(i_FilterText);
            }
            else
            {
                result = new FilterByTaggedFriends(i_FilterText);
            }

            return result;
        }

        public List<Photo> FetchPhotos()
        {
            List<Photo> filteredPhotos = new List<Photo>();

            foreach (Album album in FBAuthenticator.Instance.LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    ////Injection point ( Template Method )
                    if (FilterStyleTest(photo))
                    {
                        filteredPhotos.Add(photo);
                    }
                }
            }

            return filteredPhotos.Count == 0 ? null : filteredPhotos;
        }
    }
}
