﻿namespace GrinstalGest
{
    using Xamarin.Forms;
    using Views;
    public partial class App : Application
	{
        #region Constructores
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
        #endregion

        #region Metodos
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
