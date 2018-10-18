using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public class FilterByLocation : PhotoFilterStyler
    {
        public FilterByLocation(string i_ContextForFilter)
        {
            ContextInputFromUser = i_ContextForFilter;
        }

        protected override bool FilterStyleTest(Photo i_CurrentPhoto)
        {
            bool foundLocationForCurrentPhoto = false;

            if (i_CurrentPhoto.Place != null && i_CurrentPhoto.Place.Name != null && i_CurrentPhoto.Place.Location != null && i_CurrentPhoto.Place.Location.City != null)
            {
                string userPlace = ContextInputFromUser.ToLower();
                string photoPlace = i_CurrentPhoto.Place.Name.ToLower();
                string photoLocation = i_CurrentPhoto.Place.Location.ToString().ToLower();
                string photoLocationCity = i_CurrentPhoto.Place.Location.City.ToLower();

                if (photoPlace.Contains(userPlace) || photoLocation.Contains(userPlace) || photoLocationCity.Contains(userPlace))
                {
                    foundLocationForCurrentPhoto = true;
                }
            }

            return foundLocationForCurrentPhoto;
        }
    }
}
