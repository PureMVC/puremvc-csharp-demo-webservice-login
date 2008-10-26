using PureMVC.Interfaces;
using PureMVC.Patterns;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model;
using PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Model.Dto;

namespace PureMVC.CSharp.Demos.Silverlight.WebService.Login.Silverlight.Controller
{
    public class LoginCommand : SimpleCommand
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
            LoginDto loginDto = notification.Body as LoginDto;
            LoginProxy loginProxy = Facade.RetrieveProxy(LoginProxy.NAME) as LoginProxy;
            if (loginProxy != null) loginProxy.DoLogin(loginDto);
        }
    }
}
