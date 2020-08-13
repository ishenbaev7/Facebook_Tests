namespace FacebookAutomation
{
    using FacebookAutomation.Pages;

    public static class NavigateTo
    {
        public static void SignIn()
        {
            LoginPage home = new LoginPage();
            home.UsernameInput.SendKeys(Config.Credentials.Valid.Email);
            
        }
    }
}
