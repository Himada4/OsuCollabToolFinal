using System.Drawing;
using System.Windows.Forms;

namespace OsuCollabTool.UI
{
    internal class Draggable // Credit: https://www.youtube.com/watch?v=cpc-2flmaK4 -> Allows border to be dragged
    {
        private Form form;
        private int formBorder;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private int screenTopBorder = 0;
        private int hitBorder = 0;

        public Draggable(Form form, int formBorderXSize)
        {
            this.form = form;
            formBorder = formBorderXSize;
        }

        public void SetMovable(params Control[] controls) // Adds EventHandlers to make the control interactable
        {
            foreach (Control control in controls)
            {
                control.MouseDown += new MouseEventHandler(_MouseDown);
                control.MouseUp += new MouseEventHandler(_MouseUp);
                control.MouseMove += new MouseEventHandler(_MouseMove);
            }
        }

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
                hitBorder = 0;
            }
        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

            #region custom edit for hitting borders

            Point p = form.PointToScreen(e.Location);

            if (form.Location.X + (form.Size.Width / 3) >= screenWidth)
            {
                hitBorder = 1;
            }
            else if (form.Location.X + (form.Size.Width / 3) <= screenTopBorder)
            {
                hitBorder = 2;
            }

            #endregion custom edit for hitting borders

            switch (hitBorder)
            {
                case 0:
                    break;

                case 1: // If hits right
                    form.Location = new Point(screenWidth - form.Size.Width, screenTopBorder);
                    break;

                case 2: // If hits left
                    form.Location = new Point(screenTopBorder, screenTopBorder);
                    break;
            }
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = form.PointToScreen(e.Location);
                form.Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
                if (screenTopBorder >= form.Location.Y)
                {
                    form.Location = new Point(p.X - this.startPoint.X, screenTopBorder);
                }
                else if (screenHeight <= form.Location.Y + formBorder)
                {
                    form.Location = new Point(p.X - this.startPoint.X, screenHeight - formBorder);
                }
            }
        }
    }
}