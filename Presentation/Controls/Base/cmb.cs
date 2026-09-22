using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Controls.Base
{
    public class cmb1 : ComboBox
    {
        public cmb1()
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = Theme.InputBackground;
            ForeColor = Theme.Text;
            DrawMode = DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            e.DrawBackground();

            using Brush brush = new SolidBrush(Theme.InputBackground);
            e.Graphics.FillRectangle(brush, e.Bounds);

            TextRenderer.DrawText(
                e.Graphics,
                Items[e.Index]?.ToString(),
                Font,
                e.Bounds,
                Theme.Text,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );
        }
    }
}
