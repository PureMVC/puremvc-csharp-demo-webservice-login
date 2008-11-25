/* 
  PureMVC CSharp / Silverlight / Webservice Demo - Login
  By Matt Brailsford <matt.brailsford@puremvc.org>
  Copyright(c) 2007-08 Matt Brailsford, Some rights reserved.
*/
﻿﻿using System.Windows.Controls;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model.Dto;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.View.Components
{
    public partial class LoggedInView : UserControl
    {
        #region Accessors

        /// <summary>
        /// Sets the login dto.
        /// </summary>
        /// <value>The login dto.</value>
        public LoginDto LoginDto
        {
            set { txtMessage.Text = string.Format("Logged in as {0} at {1}", value.Username, value.LoginDate); }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggedInView"/> class.
        /// </summary>
        public LoggedInView()
        {
            InitializeComponent();
        }

        #endregion
    }
}
