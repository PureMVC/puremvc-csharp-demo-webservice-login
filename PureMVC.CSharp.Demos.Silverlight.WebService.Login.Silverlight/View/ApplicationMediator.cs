using System;
using System.Collections.Generic;
using System.Windows;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Utils;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.View
{
    public class ApplicationMediator : Mediator
    {
        #region Members

        new public const string NAME = "ApplicationMediator";

        private ApplicationProxy appProxy;
        private LoginProxy loginProxy;

        #endregion

        #region Accessors

        /// <summary>
        /// Gets the application.
        /// </summary>
        /// <value>The app.</value>
        public Login Application
        {
            get { return ViewComponent as Login; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMediator"/> class.
        /// </summary>
        /// <param name="viewComponent">The view component.</param>
        public ApplicationMediator(Object viewComponent)
            : base(NAME, viewComponent)
        {
            Facade.RegisterMediator(new LoginViewMediator(Application.LoginView));
            Facade.RegisterMediator(new LoggedInViewMediator(Application.LoggedInView));

            appProxy = Facade.RetrieveProxy(ApplicationProxy.NAME) as ApplicationProxy;
            loginProxy = Facade.RetrieveProxy(LoginProxy.NAME) as LoginProxy;
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
                Notifications.LOGIN_SUCCESS,
                Notifications.LOGIN_ERROR,
                Notifications.VIEW_STATE_CHANGED
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
                case Notifications.LOGIN_SUCCESS:
                    SendNotification(Notifications.VIEW_STATE_CHANGE, ApplicationProxy.LOGGED_IN_STATE);
                    break;
                case Notifications.LOGIN_ERROR:
                    SendNotification(Notifications.VIEW_STATE_CHANGE, ApplicationProxy.LOGIN_STATE);
                    break;
                case Notifications.VIEW_STATE_CHANGED:
                    UpdateViewState();
                    break;
            }
        }

        #endregion

        #region Protected & Internal Methods

        /// <summary>
        /// Updates the state of the view.
        /// </summary>
        protected void UpdateViewState()
        {
            switch(appProxy.ViewState)
            {
                case ApplicationProxy.LOGIN_STATE:
                case ApplicationProxy.LOGIN_ERROR_STATE:
                    Application.LoginView.Visibility = Visibility.Visible;
                    Application.LoggedInView.Visibility = Visibility.Collapsed;
                    break;
                case ApplicationProxy.LOGGED_IN_STATE:
                    Application.LoginView.Visibility = Visibility.Collapsed;
                    Application.LoggedInView.Visibility = Visibility.Visible;
                    break;
            }
        }

        #endregion
    }
}
