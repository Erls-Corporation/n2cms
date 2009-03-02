using System;
using System.Security.Principal;
using System.Web;
using N2.Engine.Aspects;
using N2.Security;

namespace N2.Web
{
	/// <summary>
	/// The interface for aspect controllers dealing with a web request.
	/// </summary>
	public interface IRequestController : IAspectController
	{
		/// <summary>Rewrites a dynamic/computed url to an actual template url.</summary>
		void RewriteRequest(IWebContext webContext);

		/// <summary>Inject the current page into the page handler.</summary>
		/// <param name="handler">The ASP.NET http handler.</param>
		void InjectCurrentPage(IHttpHandler handler);

		/// <summary>Authorize the user against the current content item. Throw an exception if not authorized.</summary>
		/// <param name="user">The user to authorize.</param>
		/// <param name="security">The security enforcer requesting authorization.</param>
		void AuthorizeRequest(IPrincipal user, ISecurityEnforcer security);

		/// <summary>Is notified when an unhandled error occurs.</summary>
		/// <param name="ex">The thrown exception.</param>
		void HandleError(Exception ex);
	}
}