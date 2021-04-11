using System;
using Discord;
using Discord.WebSocket; 
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Weather
{
    public partial class Form1 : Form
    {
        DiscordSocketClient Client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void connect_btn_Click(object sender, EventArgs e)
        {
            Client = new DiscordSocketClient(new DiscordSocketConfig()
            {
                LogLevel = LogSeverity.Verbose
            });

            Client.Log += Client_Log;

            try
            {
                await Client.LoginAsync(TokenType.Bot, token_tb.Text);
                await Client.StartAsync();
            }
            catch
            {
                MessageBox.Show("Error occurred while connecting your bot!, ERROR");
                return;
            }

            await Task.Delay(3000);
        }


        private Task Client_Log(LogMessage arg)
        {
            Invoke((Action)delegate
            {
                console_output_tb.AppendText(arg + "\n");
            });
            return null;
        }
    }
}
