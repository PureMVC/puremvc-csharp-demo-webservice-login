using System.Windows.Controls;
using PureMVC.Interfaces;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight
{
    public partial class Login : UserControl
    {
        private ApplicationFacade facade;

        public Login()
        {
            InitializeComponent();

            facade = ApplicationFacade.Instance as ApplicationFacade;
            facade.Startup(this);
        }

        public UserControl LoginView
        {
            get { return vwLogin; }
        }

        public UserControl LoggedInView
        {
            get { return vwLoggedIn; }
        }
    }
}
