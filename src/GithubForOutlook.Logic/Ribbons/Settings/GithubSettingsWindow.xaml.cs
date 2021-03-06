﻿using GithubForOutlook.Logic.Modules.Settings;

namespace GithubForOutlook.Logic.Ribbons.Settings
{
    public partial class GithubSettingsWindow
    {
        public GithubSettingsWindow(SettingsViewModel settings)
        {
            InitializeComponent();

            Settings = settings;
            this.DataContext = Settings;
        }

        public SettingsViewModel Settings { get; set; }

        private void SaveBasicAuth_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var username = User.Text;
            var password = Password.Password;

            Settings.SaveBasicAuthSettings(username, password);

            Close();
        }
    }
}
