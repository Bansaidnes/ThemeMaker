using System.Net;
namespace WinFormsApp1
{
    public partial class Form1 : Form

    {
        public string path;
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Filerer = new OpenFileDialog();
            Filerer.ShowDialog();
            path = Filerer.FileName;
            ImgButt.Location = new Point(488, 151);
            PictureShow.Show();
            label1.Show();
            PictureShow.ImageLocation = path;
            Build.Show();
            label2.Show();
            textBox1.Show();   
            AdvStg.Show();
        }
        private void Build_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            string base64String;
            string themename = textBox1.Text.Trim();
            if (themename.Trim() == "")
            {
                themename = "default_name_bozo" + rng.Next(1, 99999999);
            }
            using (Image image = Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    base64String = Convert.ToBase64String(imageBytes);
                }
            }
            form = form.Replace("rplcnm", themename);
            form = form.Replace("rplcbs64", base64String);
            try
            {
                decimal brght;
                brght = BrightCount.Value / 100;
                form = form.Replace("rplcbright", brght.ToString());
                File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\BetterDiscord\themes\" + themename + ".theme.css", form);
                MessageBox.Show("Theme built and moved to themes folder!", "ThemeMaker");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No slashes/special characters in name manne", "ThemeMaker");
            }
        }
        private void AdvStg_CheckedChanged(object sender, EventArgs e)
        {
            Bright.Show();
            BrightCount.Show();
        }
            private void Reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        public string form = @"/**
* @name rplcnm
* @author Bansaidnes ThemeMaker
* @version 1.0
* @description Made using ThemeMaker
* @source https://github.com/puckzxz/NotAnotherAnimeTheme
*/

@import url(https://puckzxz.github.io/NotAnotherAnimeTheme/build/v3/naat.v3.css);

/*
  To make editing this theme easier I recommend using Notepad++
  you can download it for free here https://notepad-plus-plus.org/download/
*/

/* Any images you use MUST end with .jpg or .png or any other image extension */

:root {
  /*
    Theme Background
  */
  --theme-background-image: url(data:image/png;base64,rplcbs64);

  /*
    Main Theme Color
  */
  --main-theme-color: rgb(67, 181, 129);

  /*
    Main Theme Transparency
  */
  --theme-transparency: rgba(0, 0, 0, rplcbright);

  /*
    Home Icon Image
  */
  --home-icon-image: url(https://raw.githubusercontent.com/Bansaidnes/bansaidnes.github.io/main/discord2.png);
  /*
    Change your friends icon image position
  */
  --home-icon-image-position: center center;

  /*
    Change your friends icon image zoom
  */
  --home-icon-image-zoom: 100%;

  /*
    Server Listing Width
    Single Column:  72px
    Double Column:  126px
    Triple Column:  184px
    Quad Column:    242px
  */
  --server-listing-width: 126px;

  /*
    Font Size
  */
  --font-size: 100%;

  /*
    Mention colors
  */
  --mention-color: rgba(250, 166, 26, 0.05);
  --mention-sider: rgba(250, 166, 26, 1);
  --mention-hover-color: rgba(250, 166, 26, 0.08);

  /*
    Server category hover color
  */
  --category-hover-color: rgb(60, 202, 138);

  /*
    Change the unread server animation.
    Replace it with none in order to remove any animations and use the main color instead
  
  --video-screen-button-background-color: rgba(200, 200, 200, 0.2);
  --video-screen-button-foreground-color: white;
  --video-screen-button-background-hovor-color: rgba(200, 200, 200, 0.4);
  --video-screen-button-foreground-hovor-color: white;

  /*
    Role Title Color
  */
  --member-listing-role-color: var(--main-theme-color);

  /*
    Small User Popout
  */
  --small-user-popout-background-image: var(--theme-background-image);
  --small-user-popout-background-transparency: rgba(0, 0, 0, 0.6);
  --small-user-popout-background-image-position: center;

  /*
    Big User Popout
  */
  --big-user-popout-background-image: var(--theme-background-image);
  --big-user-popout-background-transparency: rgba(0, 0, 0, 0.6);
  --big-user-popout-background-image-position: center;

  /*
    Code Markup
  */
  --code-markup-background-color: rgba(0, 0, 0, 0.6);
  --code-markup-border: 1px solid transparent;

  /*
    Message Box Transparency
  */
  --message-box-transparency: rgba(0, 0, 0, 0.6);

  /*
    Embed Background Transparency
  */
  --embed-background-transparency: rgba(0, 0, 0, 0.6);

  /*
    Message Hover Buttons
  */
  --message-hover-buttons-background: rgba(200, 200, 200, 0.1);

  /*
    Context Menu Transparency
  */
  --context-menu-transparency: rgba(15, 15, 15, 0.8);

  /*
    Add Server / Discovery Icon
  */
  --add-discover-icon-transparency: rgba(200, 200, 200, 0.15);
  --add-discover-icon-color: #43b581;

  /*
    Channel Limit Number Color
  */
  --channel-limit-count-color: var(--channels-default);
  --channel-limit-background-left: rgba(200, 200, 200, 0.1);
  --channel-limit-background-right: rgba(200, 200, 200, 0.2);

  /*
    Scrollbar Colors
  */
  --scrollbar-color: rgba(200, 200, 200, 0.2);

  /*
    Unread Message Divider
  */
  --unread-message-divider-color: #f04747;
  --unread-message-divider-font-color: #fff;

  /*
    New Messages Bar Color
  */
  --new-messages-bar-background-color: #7289da;
  --new-messages-bar-font-color: #fff;

  /*
    Emoji Menu
  */
  --emoji-menu-background-color: rgba(0, 0, 0, 0.6);
  --emoji-menu-sider-background-color: rgba(0, 0, 0, 0);
  --emoji-menu-server-header-background-color: rgba(0, 0, 0, 0.8);
  --emoji-menu-bottom-bar-background-color: black;
  --emoji-menu-search-bar-background-color: rgba(200, 200, 200, 0.1);

  /*
    Message Search
  */
  --message-search-menu-background-color: rgba(0, 0, 0, 0.8);
  --message-search-container-background-color: rgba(0, 0, 0, 0.6);
  --message-search-result-background-color: rgba(200, 200, 200, 0.05);

  /*
    Channel colors
  */
  --text-voice-channel-color: rgb(142, 146, 151);
  --text-voice-channel-hover-color: #dcddde;
  --text-voice-channel-selected-text-color: #fff;
  --unread-text-channel-color: #fff;
  --unread-text-channel-bubble-color: var(--main-theme-color);

  /*
    Folders
  */
  --folder-background-color: #2f3136;
  --expanded-folder-background-color: transparent;

  /*
    Reactions
  */
  --reaction-emoji-background-color: rgba(0, 0, 0, 0);
  --reaction-emoji-border-color: 1px solid transparent;
  --reaction-emoji-hover-background-color: rgba(255, 255, 255, 0.1);
  --reaction-emoji-hover-border-color: rgba(255, 255, 255, 0.2);
    }"; 
        private void Bright_Click(object sender, EventArgs e)
        {

        }
    }
}
