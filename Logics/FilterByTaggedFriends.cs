using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public class FilterByTaggedFriends : PhotoFilterStyler
    {
        protected override bool FilterStyleTest(Photo i_CurrentPhoto)
        {
            bool foundTagFriend = false;

            if (i_CurrentPhoto.Tags != null)
            {
                foreach (PhotoTag phototag in i_CurrentPhoto.Tags)
                {
                    if (phototag.User.Name == ContextInputFromUser)
                    {
                        foundTagFriend = true;
                    }
                }
            }

            return foundTagFriend;
        }

        public FilterByTaggedFriends(string i_ContextForFilter)
        {
            ContextInputFromUser = i_ContextForFilter;
        }
    }
}
