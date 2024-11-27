using DocumentRequesting.RequestFormPanels;
using DocumentRequesting.UserPanels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRequesting
{
    internal class OpenPanels
    {
        public static readonly NewDocumentForm newDocumentForm = new NewDocumentForm();
        public static readonly PickDocumentPanel pickDocumentPanel = new PickDocumentPanel();
        public static readonly LoginPanel login = new LoginPanel();
    }
}
