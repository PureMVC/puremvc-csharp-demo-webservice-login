/* 
  PureMVC CSharp / Silverlight / Webservice Demo - Login
  By Matt Brailsford <matt.brailsford@puremvc.org>
  Copyright(c) 2007-08 Matt Brailsford, Some rights reserved.
*/
﻿﻿using System;
using System.Windows;
using System.Windows.Controls;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model.Dto;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.View.Components
{
    public partial class LoginView : UserControl
    {
        #region Events

        public delegate void DoLoginHandler(Object sender, LoginDto loginDto);
        public event DoLoginHandler DoLogin;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginView"/> class.
        /// </summary>
        public LoginView()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Shows a message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public void ShowMessage(string msg)
        {
            txtMessage.Text = msg;
            txtMessage.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Hides the message.
        /// </summary>
        public void HideMessage()
        {
            txtMessage.Text = "";
            txtMessage.Visibility = Visibility.Collapsed;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            HideMessage();

            LoginDto loginDto = new LoginDto();
            loginDto.Username = txtUsername.Text;
            loginDto.Password = txtPassword.Password;

            DoLogin(this, loginDto);
        }

        #endregion
    }
}
