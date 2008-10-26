using System;
using System.ServiceModel;
using System.Windows.Browser;
using PureMVC.Patterns;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Utils;
using LoginDto = PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model.Dto.LoginDto;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model
{
    public class LoginProxy : Proxy
    {
        #region Members

        new public const string NAME = "LoginProxy";

        private LoginDto validLoginDto;

        #endregion

        #region Accessors

        /// <summary>
        /// Gets the login dto.
        /// </summary>
        /// <value>The login dto.</value>
        public LoginDto LoginDto
        {
            get { return validLoginDto; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginProxy"/> class.
        /// </summary>
        public LoginProxy()
            : base(NAME)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginProxy"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public LoginProxy(Object data)
            : base(NAME, data)
        { }

        #endregion

        #region Public Methods

        /// <summary>
        /// Performs the login.
        /// </summary>
        /// <param name="loginDto">The login dto.</param>
        public void DoLogin(LoginDto loginDto)
        {
            // TODO: Need to find a way to share DTOs between layers
            LoginService.LoginDto loginRequestDto = new LoginService.LoginDto();
            loginRequestDto.Username = loginDto.Username;
            loginRequestDto.Password = loginDto.Password;

            LoginServiceSoapClient loginService = new LoginServiceSoapClient();
            loginService.Endpoint.Address = new EndpointAddress("http://puremvc.mattbrailsford.com/logindemo/services/LoginService.asmx");
            loginService.DoLoginCompleted += new EventHandler<DoLoginCompletedEventArgs>(loginService_DoLoginCompleted);
            loginService.DoLoginAsync(loginRequestDto);
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the DoLoginCompleted event of the loginService control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.LoginService.DoLoginCompletedEventArgs"/> instance containing the event data.</param>
        protected void loginService_DoLoginCompleted(object sender, DoLoginCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                SendNotification(Notifications.LOGIN_ERROR, "Invalid Username and/or Password");
            }
            else
            {
                // TODO: Need to find a way to share DTOs between layers
                validLoginDto = new LoginDto();
                validLoginDto.Username = e.Result.Username;
                validLoginDto.Password = e.Result.Password;
                validLoginDto.LoginDate = e.Result.LoginDate;

                SendNotification(Notifications.LOGIN_SUCCESS);
            }
        }

        #endregion
    }
}
