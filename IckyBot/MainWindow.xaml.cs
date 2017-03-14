using Discord;
using IckyBot.Model;
using IckyBot.Services;
using System;
using System.Linq;
using System.Windows;

namespace IckyBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DiscordClient _client;

        private UserService _users = new UserService();

        private MessageService _messages = new MessageService();


        /// <summary>
        /// YOU NEED TO ASSIGN THIS FIELD YOUR BOT'S TOKEN VALUE
        /// </summary>
        private string _token;
        
        public MainWindow()
        {
            InitializeComponent();

            _client = new DiscordClient();

            _client.MessageReceived += async (s, e) =>
            {
                //First, we need to see if the current user is known to us
                var user = _users.GetUserByNickname(e.User.Nickname) ?? _users.GetUserByName(e.User.Name);

                if (user == null)
                {
                    //If we're here, we don't know who this is
                    await _users.AddUser(DiscordUserFactory.GenerateUser(e.User));
                }

                await _messages.AddMessage(DiscordMessageFactory.GenerateMessage(e.Message));
            };       
        }        

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            if(_token == null)
            {
                MessageBox.Show("You didn't read the directions and enter your bot token");
                return;
            }

            await _client.Connect(_token, TokenType.Bot);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await _client.Disconnect();

            this.Close();
        }
    }
}