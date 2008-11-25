/* 
  PureMVC CSharp / Silverlight / Webservice Demo - Login
  By Matt Brailsford <matt.brailsford@puremvc.org>
  Copyright(c) 2007-08 Matt Brailsford, Some rights reserved.
*/
﻿using PureMVC.Interfaces;
using PureMVC.Patterns;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Controller
{
    public class ViewStateChangeCommand : SimpleCommand
    {
        /// <summary>
        /// Fulfill the use-case initiated by the given <c>INotification</c>
        /// </summary>
        /// <param name="notification">The <c>INotification</c> to handle</param>
        /// <remarks>
        /// In the Command Pattern, an application use-case typically begins with some user action, which results in an <c>INotification</c> being broadcast, which is handled by business logic in the <c>execute</c> method of an <c>ICommand</c>
        /// </remarks>
        public override void Execute(INotification notification)
        {
            ApplicationProxy appProxy = Facade.RetrieveProxy(ApplicationProxy.NAME) as ApplicationProxy;
            if(appProxy != null) appProxy.ViewState = notification.Body.ToString();
        }
    }
}
