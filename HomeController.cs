using System.Security.Principal;
using Microsoft.AspNetCore.Mvc;

namespace MedWise.Controllers;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		IIdentity identity = ((ControllerBase)this).User.Identity;
		if (identity != null && identity.IsAuthenticated && ((ControllerBase)this).User.IsInRole("Patient"))
		{
			return (IActionResult)(object)((ControllerBase)this).RedirectToAction("Dashboard", "Patient");
		}
		IIdentity identity2 = ((ControllerBase)this).User.Identity;
		if (identity2 != null && identity2.IsAuthenticated && ((ControllerBase)this).User.IsInRole("Caregiver"))
		{
			return (IActionResult)(object)((ControllerBase)this).RedirectToAction("Dashboard", "Caregiver");
		}
		return (IActionResult)(object)((Controller)this).View();
	}
}
