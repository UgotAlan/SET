namespace SET
{
    using Properties;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Media;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Sounds Class including methods for playing intro music, game music, and sounds.
    /// </summary>
    public class Sounds
    { 
        /// <summary>
        /// PlayMusic method that takes boolean if mute option is enabled,
        /// and plays intro music file if it is not.
        /// </summary>
        /// <param name="playing">boolean true/false</param>
        /// <returns>boolean true/false just for unit testing</returns>
        public bool PlayMusic(bool playing)
        {
            SoundPlayer sound = new SoundPlayer(Resources.music);

            if (playing == true)
            {
                sound.PlayLooping();
                return true;
            }
            else
            {
                sound.Stop();
                return false;
            }
        }

        /// <summary>
        /// PlayMusicIntro method that takes boolean if mute option is enabled,
        /// and plays music file if it is not.
        /// </summary>
        /// <param name="playing">boolean true/false</param>
        /// <returns>boolean true/false just for unit testing</returns>        
        public bool PlayMusicIntro(bool playing)
        {
            SoundPlayer sound = new SoundPlayer(Resources.music_intro);

            if (playing == true)
            {
                sound.PlayLooping();
                return true;
            }
            else
            {
                sound.Stop();
                return false;
            }
        }

        /// <summary>
        /// PlayWrong method that takes boolean if mute option is enabled,
        /// and plays audio file if it is not.
        /// </summary>
        /// <param name="playing">boolean true/false</param>
        /// <returns>boolean true/false just for unit testing</returns>   
        public bool PlayWrong(bool playing)
        {
            string directoryName = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            directoryName = Path.GetDirectoryName(directoryName);
            directoryName = Path.GetDirectoryName(directoryName);
            directoryName = directoryName + "\\set_sounds\\wrong\\";
            var rand = new Random();
            var soundFiles = Directory.GetFiles(directoryName, "*wav");
            var playSound = soundFiles[rand.Next(0, soundFiles.Length)];

            var player = new WMPLib.WindowsMediaPlayer();

            if (playing == true)
            {
                player.URL = playSound;
                return true;
            }

            return false;
        }

        /// <summary>
        /// PlayRight method that takes boolean if mute option is enabled,
        /// and plays audio file if it is not.
        /// </summary>
        /// <param name="playing">boolean true/false</param>
        /// <returns>boolean true/false just for unit testing</returns> 
        public bool PlayRight(bool playing)
        {
            string directoryName = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            directoryName = Path.GetDirectoryName(directoryName);
            directoryName = Path.GetDirectoryName(directoryName);
            directoryName = directoryName + "\\set_sounds\\right\\";
            var rand = new Random();
            var soundFiles = Directory.GetFiles(directoryName, "*wav");
            var playSound = soundFiles[rand.Next(0, soundFiles.Length)];

            var player = new WMPLib.WindowsMediaPlayer();

            if (playing == true)
            {
                player.URL = playSound;
                return true;
            }

            return false;
        }
    }
}
