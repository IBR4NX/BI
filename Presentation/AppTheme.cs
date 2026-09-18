using System.Drawing;
    using System;
using System.Windows.Forms;

namespace Presentation
{
    public static class AppTheme
    {
        public static Color Background = Color.FromArgb(22, 27, 34);
        public static Color Surface = Color.FromArgb(13, 17, 23);
        public static Color Border = Color.FromArgb(48, 54, 61);
        public static Color Text = Color.FromArgb(230, 237, 243);
        public static Color MutedText = Color.FromArgb(139, 148, 158);
        public static Color Primary = Color.FromArgb(124, 58, 237);
        public static void SetupStyle(Control control)
        {
            control.BackColor = AppTheme.Background;
            control.ForeColor = AppTheme.Text;
        }
    }

namespace Presentation.Theme
    {
        public class BasePanel : Panel
        {
            protected override void OnCreateControl()
            {
                base.OnCreateControl();

                BackColor = ProjectTheme.Surface;
                ForeColor = ProjectTheme.Text;
            }
        }
    public static class ProjectTheme
    {
        // Main
        public static Color Background =>
            Color.FromArgb(13, 17, 23);

        // Panels / Controls
        public static Color Surface =>
            Color.FromArgb(22, 27, 34);

        // Borders
        public static Color Border =>
            Color.FromArgb(48, 54, 61);

        // Text
        public static Color Text =>
            Color.FromArgb(230, 237, 243);

        public static Color MutedText =>
            Color.FromArgb(139, 148, 158);

        // Primary
        public static Color Primary =>
            Color.FromArgb(212, 168, 83);

        // States
        public static Color Hover =>
            Color.FromArgb(35, 41, 48);

        public static Color Pressed =>
            Color.FromArgb(48, 54, 61);

        // Semantic
        public static Color Success =>
            Color.FromArgb(46, 160, 67);

        public static Color Warning =>
            Color.FromArgb(210, 153, 34);

        public static Color Danger =>
            Color.FromArgb(248, 81, 73);

        public static Color Info =>
            Color.FromArgb(88, 166, 255);
    }
}
