/* 
  PureMVC CSharp / Silverlight / Webservice Demo - Login
  By Matt Brailsford <matt.brailsford@puremvc.org>
  Copyright(c) 2007-08 Matt Brailsford, Some rights reserved.
*/
﻿using System;
using PureMVC.Patterns;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Utils;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model
{
    public class ApplicationProxy : Proxy
    {
        #region Members

        new public const string NAME = "ApplicationProxy";

        public const string LOGIN_STATE = "loginState";
        public const string LOGGED_IN_STATE = "loggedInState";
        public const string LOGIN_ERROR_STATE = "loginErrorState";

        private string viewState;

        #endregion

        #region Accessors

        /// <summary>
        /// Gets or sets the state of the view.
        /// </summary>
        /// <value>The state of the view.</value>
        public string ViewState
        {
            get { return viewState; }
            set
            {
                viewState = value;

                SendNotification(Notifications.VIEW_STATE_CHANGED);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationProxy"/> class.
        /// </summary>
        public ApplicationProxy()
            : base(NAME)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationProxy"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public ApplicationProxy(Object data)
            : base(NAME, data)
        { }

        #endregion       
    }
}
