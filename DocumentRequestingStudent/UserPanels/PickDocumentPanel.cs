using DocumentRequesting.Data;
using DocumentRequestingUtils.CustomControls;
using DocumentRequestingUtils.Popup;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DocumentRequesting.UserPanels
{
    public partial class PickDocumentPanel : MaterialForm
    {
        private Panel flowBottom = new Panel();
        public PickDocumentPanel()
        {
            InitializeComponent();
            this.FormClosing += Utilities.MyFormClosing;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Color.FromArgb(128, 175, 129), Color.FromArgb(128, 175, 129), Color.FromArgb(212, 231, 197), Color.FromArgb(212, 231, 197), MaterialSkin.TextShade.WHITE);
            RefreshItems();

            flowBottom.Height = 30;
            flowBottom.Width = mainPanel.Width - (mainPanel.Padding.Left + mainPanel.Padding.Right);
            flowBottom.BackColor = mainPanel.BackColor;
            mainPanel.Controls.Add(flowBottom);

            scrollBar.ValueChanged += (s, e) =>
            {
                if (scrollBar.Value == mainPanel.VerticalScroll.Value) return;
                mainPanel.VerticalScroll.Value = scrollBar.Value;
                mainPanel.PerformLayout(); // Recalculate layout for smooth scrolling
            };

            mainPanel.Layout += (s, e) =>
            {
                if (scrollBar.Value != mainPanel.VerticalScroll.Value)
                {
                    scrollBar.Value = mainPanel.VerticalScroll.Value;
                }

                int totalScrollableHeight = mainPanel.VerticalScroll.Maximum - mainPanel.ClientSize.Height;
                scrollBar.Maximum = Math.Max(0, totalScrollableHeight);

                if (scrollBar.Maximum == 0) scrollBar.Visible = false;
                else scrollBar.Visible = true;

                float visibleRatio = (float)mainPanel.ClientSize.Height / (mainPanel.VerticalScroll.Maximum + mainPanel.ClientSize.Height);
                scrollBar.ThumbSize = (int)(visibleRatio * scrollBar.Height);

                if (scrollBar.Controls.Contains(flowBottom) && mainPanel.Controls.Count > 0) flowBottom.TabIndex = mainPanel.Controls.Count - 1;
            };

            mainPanel.BackColorChanged += (s, e) =>
            {
                flowBottom.BackColor = mainPanel.BackColor;
            };

            mainPanel.MouseWheel += (s, e) =>
            {
                if (scrollBar.Value != mainPanel.VerticalScroll.Value)
                {
                    scrollBar.Value = mainPanel.VerticalScroll.Value;
                }
            };

            mainPanel.SizeChanged += (s, e) =>
            {
                flowBottom.Width = mainPanel.Width - (mainPanel.Padding.Left + mainPanel.Padding.Right);

            };

        }

        public new void Show()
        {
            if (User.CurrentUser != null && User.CurrentUser.Role == UserType.Admin) userBtn.Visible = true;
            else userBtn.Visible = false;

            RefreshItems();

            base.Show();
            this.Size = Utilities.size;
            this.Location = Utilities.location;
            this.WindowState = Utilities.windowState;
        }

        public new void Hide()
        {
            userBtn.Visible = false;

            Utilities.PreviousPanel = this;
            Utilities.size = this.Size;
            Utilities.location = this.Location;
            Utilities.windowState = this.WindowState;
            base.Hide();
            
        }

        private void RefreshItems()
        {
            mainPanel.Controls.Clear();
            Utilities.RefreshData();

            foreach (DocumentType documentType in DocumentType.DocumentTypes)
            {
                DocumentTypePanel panel = new DocumentTypePanel(documentType);
                mainPanel.Controls.Add(panel);
                panel.Button.Click += (sender, e) =>
                {
                    this.Hide();
                    OpenPanels.newDocumentForm.Show(documentType);
                };
            }

            if (User.CurrentUser == null || User.CurrentUser.Role != UserType.Admin) return;
            DocumentTypePanel addPanel = new DocumentTypePanel("Add Another Document");
            mainPanel.Controls.Add(addPanel);
            addPanel.Button.Click += (sender, e) =>
            {
                NewDocumentPopup form = new NewDocumentPopup();
                form.ShowDialog();
                RefreshItems();
            };

            mainPanel.Controls.Add(flowBottom);
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (Utilities.PreviousPanel != null)
            {
                this.Hide();
                Utilities.PreviousPanel.Show();
            }
            else if (Utilities.mainPanel != null)
            {
                this.Hide();
                Utilities.mainPanel.Show();
            }

            
        }
    }
}
