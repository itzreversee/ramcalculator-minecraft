namespace mcramcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(serverRamBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                serverRamBox.Text = serverRamBox.Text.Remove(serverRamBox.Text.Length - 1);
            }
        }

        private int serverRam;
        private int serverVersionLevel;

        private int pluginLevel;
        private int playerLevel;

        private bool usesBungee;
        private bool worldSmall;
        private bool worldPregen;

        private void calculate_button(object sender, EventArgs e)
        {
            if (serverRamBox.Text == "" || versionBox.SelectedIndex < -1 || pluginsBox.SelectedIndex < -1 || playersBox.SelectedIndex < -1) { MessageBox.Show("complete the form before calculating.");  return; }
            serverRam = Int32.Parse(serverRamBox.Text);
            checkVersionLevel();
            pluginLevelCheck();
            playerLevelCheck();
            checkOther();

            genOptimized();

        }

        void genOptimized()
        {
            panel1.Hide();
            panel2.Hide();

            optimizedSettingsLabel.Text = "Generating optimized settings for you.";
            Thread.Sleep(2);

            getServerRam();

            this.Size = new Size(816, 250);
            this.MaximumSize = new Size(816, 250);
            this.MinimumSize = new Size(816, 250);

            optimizedSettingsLabel.Text =
                "Version : "+ versionBox.Text+ " | " + serverEngine + " | " + versionEstimatedRam +
                "\nPlugins Count : " + pluginsBox.Text + " | " + pluginsEstimatedRam +
                "\nPlayer Count : " + playersBox.Text + " | " + playerEstimatedRam +

                "\n\nis World Pregenerated : " + iwp +
                "\nis World Small : " + iws +

                "\n\n Recomended Minecraft Server RAM : " +serverEstimatedRam + " MB" + 
                "\n Recomended Proxy RAM : " + bungeeEstimatedRam + " MB" +

                "\n\nRecomended Server OS : " + rso;
        }

        private string serverVersion;
        private string serverEngine;
        private int serverEstimatedRam;
        private int versionEstimatedRam;
        private int bungeeEstimatedRam;

        private int pluginsEstimatedRam;
        private int playerEstimatedRam;

        private int iwpc = 0;
        private string iwp;
        private int iwsc = 0;
        private string iws;
        private string rso;

        void getServerRam()
        {
            // server version ram and engine
            if (serverVersionLevel == 0) { versionEstimatedRam = 1024; serverEngine = "Spigot (Unknown Version!)"; }
            else if ( serverVersionLevel == 1 ) { versionEstimatedRam = 1024; serverEngine = "Spigot or Forks"; }
            else if ( serverVersionLevel == 2 ) { versionEstimatedRam = 1024; serverEngine = "Spigot or Forks"; }
            else if ( serverVersionLevel == 3 ) { versionEstimatedRam = 1536; serverEngine = "Spigot or Forks"; }
            else if ( serverVersionLevel == 4 ) { versionEstimatedRam = 2048; serverEngine = "Paper or Forks"; }
            else if ( serverVersionLevel == 5 ) { versionEstimatedRam = 3072; serverEngine = "Paper or Forks"; }

            //plugins ram
            if (pluginLevel == 0) { pluginsEstimatedRam = 768; }
            if (pluginLevel == 1) { pluginsEstimatedRam = 1024; }
            if (pluginLevel == 2) { pluginsEstimatedRam = 2048; }
            if (pluginLevel == 3) { pluginsEstimatedRam = 3072; }

            //players ram
            if (playerLevel == 0) { playerEstimatedRam = 768; }
            if (playerLevel == 1) { playerEstimatedRam = 1536; }
            if (playerLevel == 2) { playerEstimatedRam = 2048; }
            if (playerLevel == 3) { playerEstimatedRam = 3072; }
            if (playerLevel == 4) { playerEstimatedRam = 4096; }
            if (playerLevel == 5) { playerEstimatedRam = 6144; }

            //other checks
            if (worldPregen == true) { iwp = "yes"; iwpc = -512; } else { iwp = "no"; } // -512MB
            if (worldSmall == true) { iws = "yes"; iwsc = -1024; } else { iws = "no"; iwsc = 1024; } // -1024MB || 1024MB
            if (usesBungee == true) {  bungeeEstimatedRam = 512; }

            //final sum
            serverEstimatedRam = versionEstimatedRam + pluginsEstimatedRam + playerEstimatedRam + iwpc + iwsc;
            if (serverRam <= 16384 ) { rso = "Any Linux Distro ( avoid GNOME or KDE for better performance)"; }
            if (serverRam <= 8192 ) { rso = "Ubuntu XFCE, or without DE || Arch XFCE, or without DE || Void linux XFCE"; }
            if (serverRam <= 6144 ) { rso = "Ubuntu Server || Arch i3 or without DE || Void Linux XFCE or without DE"; }
            if (serverRam <= 4096 ) { rso = "Ubuntu Server || Arch without DE || Void Linux without DE"; }
            if (serverRam <= 4095 ) { rso = "Void Linux without DE"; }
            if (serverRam <= 2048 ) { rso = "Don't even try"; }
        }

        void checkVersionLevel()
        {
            switch (versionBox.SelectedIndex)
            {
                case 0: serverVersionLevel = 1; break; // 1.8 - light
                case 1: serverVersionLevel = 2; break; // 1.9 - somewhat medium
                case 3: serverVersionLevel = 2; break; // 1.10
                case 4: serverVersionLevel = 2; break; // 1.11
                case 5: serverVersionLevel = 2; break; // 1.12
                case 6: serverVersionLevel = 3; break; // 1.13 - medium
                case 7: serverVersionLevel = 3; break; // 1.14
                case 8: serverVersionLevel = 3; break; // 1.15
                case 9: serverVersionLevel = 4; break; // 1.16 - light heavy
                case 10: serverVersionLevel = 4; break; // 1.17
                case 11: serverVersionLevel = 5; break; // 1.18 - heavy 
                case 12: serverVersionLevel = 5; break; // 1.19
                default:
                    // something went wrong lol
                    serverVersionLevel = 0;
                    break;
            }
        }

        void pluginLevelCheck()
        {
            switch (pluginsBox.SelectedIndex)
            {
                case 0: pluginLevel = 1; break; // 768
                case 2: pluginLevel = 2; break; // 1024
                case 3: pluginLevel = 3; break; // 1536
            }
        }

        void playerLevelCheck()
        {
            switch (playersBox.SelectedIndex)
            {
                case 0: playerLevel = 0; break;
                case 1: playerLevel = 1; break;
                case 3: playerLevel = 2; break;
                case 4: playerLevel = 3; break;
                case 5: playerLevel = 4; break;
            }
        }

        void checkOther()
        {
            if (isCracked.Checked == true) { usesBungee = true; }
            if (isWorldPregenerated.Checked == true) { worldPregen = true; }
            if (isWorldSmall.Checked == true) { worldSmall = true; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Disclaimer: This is only a suggestion. \nDo not trust this tool, i will not cover any damage or anything");
            this.Show();
        }
    }
}