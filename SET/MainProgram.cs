namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    static class MainProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Sounds sound = new Sounds();
            string directoryName = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            directoryName = Path.GetDirectoryName(directoryName);
            directoryName = Path.GetDirectoryName(directoryName);
            directoryName = directoryName + "\\set_sounds\\sound_options.txt";
            string text = System.IO.File.ReadAllText(directoryName);
            if (text == "true") { sound.PlayMusicIntro(true); }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
