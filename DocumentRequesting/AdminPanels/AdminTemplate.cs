using DocumentRequestingUtils.CustomControls;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentRequesting.AdminPanels
{
    public partial class AdminTemplate : MaterialForm
    {
        public AdminTemplate()
        {
            InitializeComponent();
            this.FormClosing += Utilities.MyFormClosing;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);

        }

        public new void Show()
        {
            base.Show();
            this.Size = Utilities.size;
            this.Location = Utilities.location;
            this.WindowState = Utilities.windowState;
            Utilities.RefreshData();
        }

        public new void Hide()
        {
            Utilities.PreviousPanel = this;
            Utilities.size = this.Size;
            Utilities.location = this.Location;
            Utilities.windowState = this.WindowState;
            base.Hide();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(Color.FromArgb(128, 175, 129), Color.FromArgb(128, 175, 129), Color.FromArgb(249, 248, 235), Color.Black, MaterialSkin.TextShade.WHITE);
            this.Size = new Size(1280, 720);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color borderColor = Color.Black; // Change to your preferred color
            int borderThickness = 2;

            // Draw the border
            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void showFormsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.pickDocumentPanel.Show();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.adminInfo.Show();
        }

        private void toStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.staffHome.Show();
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.createAccount.Show();
        }

        private void iconPBox_Click(object sender, EventArgs e)
        {
            Utilities.BackHome();
        }
    }
}
