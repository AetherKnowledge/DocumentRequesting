using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentRequestingUtils.Popup
{
    public partial class NewDocumentPopup : Form
    {
        public NewDocumentPopup()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string type = nameBox.Text;
            string abv = abvBox.Text;
            if (!DocumentType.Insert(type, abv)) return;

            PopupForm popupForm = new PopupForm("Successfully Added new Document");
            popupForm.ShowDialog();
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
