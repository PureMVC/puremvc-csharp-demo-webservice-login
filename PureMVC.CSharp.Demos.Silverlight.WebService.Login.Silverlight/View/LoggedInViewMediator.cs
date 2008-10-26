using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Utils;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.View.Components;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.View
{
    public class LoggedInViewMediator : Mediator
    {
        #region Members

        new public const string NAME = "LoggedInViewMediator";

        private LoginProxy loginProxy;

        #endregion

        #region Accessors

        /// <summary>
        /// Gets the logged in view.
        /// </summary>
        /// <value>The logged in view.</value>
        public LoggedInView LoggedInView
        {
            get { return ViewComponent as LoggedInView; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggedInViewMediator"/> class.
        /// </summary>
        /// <param name="viewComponent">The view component.</param>
        public LoggedInViewMediator(Object viewComponent)
            : base(NAME, viewComponent)
        {
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
                Notifications.LOGIN_SUCCESS                              
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
                    LoggedInView.LoginDto = loginProxy.LoginDto;
                    break;
            }
        }

        #endregion
    }
}
