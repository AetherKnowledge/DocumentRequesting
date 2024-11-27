using DocumentRequesting.AdminPanels;
using DocumentRequesting.RequestFormPanels;
using DocumentRequesting.StaffPanels;
using DocumentRequesting.UserPanels;
using DocumentRequestingAdmin.AdminPanels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRequesting
{
    internal class OpenPanels
    {
        public static readonly LoginPanel loginPanel = new LoginPanel();
        public static readonly CreateAccount createAccount = new CreateAccount();
        public static readonly AdminPanel adminPanel = new AdminPanel();
        public static readonly AdminInfo adminInfo = new AdminInfo();
        public static readonly NewDocumentForm newDocumentForm = new NewDocumentForm();
        public static readonly PickDocumentPanel pickDocumentPanel = new PickDocumentPanel();

        public static readonly StaffHome staffHome = new StaffHome();

    }
}
