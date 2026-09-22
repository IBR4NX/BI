using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation
{
    public static class Theme
    {
        // =========================
        // Main
        // =========================

        public static Color Background => Color.FromArgb(13, 17, 23);
        public static Color Surface => Color.FromArgb(22, 27, 34);
        public static Color SurfaceLight => Color.FromArgb(30, 36, 44);

        // =========================
        // Text
        // =========================

        public static Color Text => Color.FromArgb(240, 246, 252);
        public static Color TextSecondary => Color.FromArgb(139, 148, 158);
        public static Color TextDisabled => Color.FromArgb(72, 79, 88);

        // =========================
        // Border
        // =========================

        public static Color Border => Color.FromArgb(48, 54, 61);
        public static Color BorderLight => Color.FromArgb(72, 79, 88);

        // =========================
        // Primary
        // =========================

        public static Color Primary => Color.FromArgb(124, 92, 255);
        public static Color PrimaryHover => Color.FromArgb(145, 118, 255);
        public static Color PrimaryPressed => Color.FromArgb(99, 70, 220);

        // =========================
        // Success
        // =========================

        public static Color Success => Color.FromArgb(46, 160, 67);
        public static Color SuccessHover => Color.FromArgb(63, 185, 82);

        // =========================
        // Warning
        // =========================

        public static Color Warning => Color.FromArgb(210, 153, 34);
        public static Color WarningHover => Color.FromArgb(230, 175, 50);

        // =========================
        // Danger
        // =========================

        public static Color Danger => Color.FromArgb(248, 81, 73);
        public static Color DangerHover => Color.FromArgb(255, 100, 92);

        // =========================
        // Info
        // =========================

        public static Color Info => Color.FromArgb(88, 166, 255);
        public static Color InfoHover => Color.FromArgb(110, 180, 255);

        // =========================
        // Controls
        // =========================

        public static Color ControlBackground => Surface;
        public static Color ControlHover => SurfaceLight;
        public static Color ControlPressed => Color.FromArgb(40, 46, 54);

        public static Color ControlBorder => Border;
        public static Color ControlBorderFocus => Primary;

        // =========================
        // Input
        // =========================

        public static Color InputBackground => Color.FromArgb(16, 20, 26);
        public static Color InputBorder => Border;
        public static Color InputFocusBorder => Primary;

        // =========================
        // Selection
        // =========================

        public static Color Selection => Color.FromArgb(56, 45, 110);
        public static Color SelectionText => Text;

        // =========================
        // Disabled
        // =========================

        public static Color DisabledBackground => Color.FromArgb(25, 29, 35);
        public static Color DisabledText => TextDisabled;

        // =========================
        // ScrollBar
        // =========================

        public static Color ScrollBar => Color.FromArgb(48, 54, 61);
        public static Color ScrollBarHover => Color.FromArgb(72, 79, 88);
    }
}
