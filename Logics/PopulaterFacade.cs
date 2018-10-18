namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public class PopulaterFacade
    {
        ////Transaperent Facade letting the client use the sub systems when/if required
        
        public AppIdOptionsForm AppIDForm { get; set; }

        public FBAuthenticator Authenticator { get; set; }

        ////This is our class proxy who serves the purpose of caching proxy
        public WeatherFetcherCached WeatherFetcher { get; set; }

        public PopulaterFacade()
        {
            Authenticator = FBAuthenticator.Instance;
            WeatherFetcher = new WeatherFetcherCached();
            WeatherFetcher.Authenticator = Authenticator;
            AppIDForm = new AppIdOptionsForm();
        }

        public void PrepareApp()
        {
            AppIDForm = new AppIdOptionsForm();
            AppIDForm.ShowDialog();
            Authenticator.Login(AppIDForm.AppId);
        }

        public void ResetApp()
        {
            WeatherFetcher = new WeatherFetcherCached();
            PrepareApp();
        }
    }
}
