using DocumentRequesting.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DocumentRequestingUtils.CustomControls
{
    public partial class DocumentTypePanel : UserControl
    {
        private DocumentType? type = null;

        public DocumentTypePanel(DocumentType type) : this(type.Type)
        {
            this.type = type;
            if (!string.IsNullOrWhiteSpace(type.Abv)) Button.Text = type.Type + " (" + type.Abv + ")";
        }

        public DocumentTypePanel(String text)
        {
            InitializeComponent();
            Button.Text = text;
            this.Size = new Size(300, 300);
            this.BackColor = Color.White;
        }

    }
}
