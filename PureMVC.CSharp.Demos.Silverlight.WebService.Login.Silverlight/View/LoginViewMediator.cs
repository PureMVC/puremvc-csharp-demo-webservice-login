using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model.Dto;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Utils;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.View.Components;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.View
{
    public class LoginViewMediator : Mediator
    {
        #region Members

        new public const string NAME = "LoginViewMediator";

        private LoginProxy loginProxy;

	    #endregion

        #region Accessors

        public LoginView LoginView
        {
            get { return ViewComponent as LoginView; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginViewMediator"/> class.
        /// </summary>
        /// <param name="viewComponent">The view component.</param>
        public LoginViewMediator(Object viewComponent)
            : base(NAME, viewComponent)
        {
            loginProxy = Facade.RetrieveProxy(LoginProxy.NAME) as LoginProxy;

            LoginView.DoLogin += LoginView_DoLogin;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// List the <c>INotification</c> names this <c>Mediator</c> is interested in being notified of
        /// </summary>
        /// <returns>The list of <c>INotification</c> names</returns>
        public override IList<string> ListNotificationInterests()
        {
            return new List<string>(new string[] {
                Notifications.LOGIN_ERROR
            });
        }

        /// <summary>
        /// Handle <c>INotification</c>s
        /// </summary>
        /// <param name="notification">The <c>INotification</c> instance to handle</param>
        /// <remarks>
        /// Typically this will be handled in a switch statement, with one 'case' entry per <c>INotification</c> the <c>Mediator</c> is interested in.
        /// </remarks>
        public override void HandleNotification(INotification notification)
        {
            switch(notification.Name)
            {
                case Notifications.LOGIN_ERROR:
                    LoginView.ShowMessage(notification.Body.ToString());
                    break;
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Performs the login.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="loginDto">The login dto.</param>
        protected void LoginView_DoLogin(object sender, LoginDto loginDto)
        {
            SendNotification(Notifications.LOGIN, loginDto);
        }

        #endregion
    }
}
