using DocumentRequesting.StaffPanels;
using DocumentRequestingStaff.StaffPanels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRequesting
{
    internal class OpenPanels
    {
        internal static readonly StaffHome staffHome = new StaffHome();
        internal static readonly LoginPanel loginPanel = new LoginPanel();
        internal static readonly StaffNotificationPanel notificationPanel = new StaffNotificationPanel();
        internal static readonly StaffInfo staffInfo = new StaffInfo();
    }
}
