/* 
  PureMVC CSharp / Silverlight / Webservice Demo - Login
  By Matt Brailsford <matt.brailsford@puremvc.org>
  Copyright(c) 2007-08 Matt Brailsford, Some rights reserved.
*/
﻿using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Controller;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Utils;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight
{
    public class ApplicationFacade : Facade
    {
        #region Accessors

        /// <summary>
        /// Facade Singleton Factory method.  This method is thread safe.
        /// </summary>
        new public static IFacade Instance
        {
            get
            {
                if (m_instance == null)
                {
                    lock (m_syncRoot)
                    {
                        if (m_instance == null) m_instance = new ApplicationFacade();
                    }
                }

                return m_instance;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts the specified application.
        /// </summary>
        /// <param name="app">The app.</param>
        public void Startup(Object app)
        {
            NotifyObservers(new Notification(Notifications.APP_STARTUP, app));
        }

        #endregion

        #region Protected & Internal Methods

        /// <summary>
        /// Explicit static constructor to tell C# compiler 
        /// not to mark type as beforefieldinit
        ///</summary>
        static ApplicationFacade()
        { }

        /// <summary>
        /// Initialize the Singleton <c>Facade</c> instance
        /// </summary>
        /// <remarks>
        /// <para>Called automatically by the constructor. Override in your subclass to do any subclass specific initializations. Be sure to call <c>base.initializeFacade()</c>, though</para>
        /// </remarks>
        protected override void InitializeController()
        {
            base.InitializeController();

            RegisterCommand(Notifications.APP_STARTUP, typeof(ApplicationStartupCommand));
            RegisterCommand(Notifications.LOGIN, typeof(LoginCommand));
            RegisterCommand(Notifications.VIEW_STATE_CHANGE, typeof(ViewStateChangeCommand));
        }

        #endregion
    }
}

