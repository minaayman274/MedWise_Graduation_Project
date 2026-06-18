using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using MedWise.Core.DTOs;
using MedWise.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;

namespace MedWise.Controllers;

[Authorize(Policy = "CaregiverOnly")]
public class CaregiverController : Controller
{
	[CompilerGenerated]
	private static class _003C_003Eo__4
	{
		public static CallSite<Func<CallSite, object, global::System.Collections.Generic.IEnumerable<UserDto>, object>> _003C_003Ep__0;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAcknowledgeAlert_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IActionResult> _003C_003Et__builder;

		public CaregiverController _003C_003E4__this;

		public int alertId;

		private TaskAwaiter<ApiResponse<bool>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CaregiverController caregiverController = _003C_003E4__this;
			IActionResult result;
			try
			{
				TaskAwaiter<ApiResponse<bool>> awaiter;
				if (num != 0)
				{
					awaiter = caregiverController._alertService.AcknowledgeAlertAsync(alertId, caregiverController.GetUserId()).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ApiResponse<bool>>, _003CAcknowledgeAlert_003Ed__8>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ApiResponse<bool>>);
					num = (_003C_003E1__state = -1);
				}
				awaiter.GetResult();
				result = (IActionResult)(object)((ControllerBase)caregiverController).RedirectToAction("Dashboard");
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDashboard_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IActionResult> _003C_003Et__builder;

		public CaregiverController _003C_003E4__this;

		private TaskAwaiter<ApiResponse<global::System.Collections.Generic.IEnumerable<UserDto>>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CaregiverController caregiverController = _003C_003E4__this;
			IActionResult result2;
			try
			{
				TaskAwaiter<ApiResponse<global::System.Collections.Generic.IEnumerable<UserDto>>> awaiter;
				if (num != 0)
				{
					awaiter = caregiverController._caregiverService.GetLinkedPatientsAsync(caregiverController.GetUserId()).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ApiResponse<global::System.Collections.Generic.IEnumerable<UserDto>>>, _003CDashboard_003Ed__4>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ApiResponse<global::System.Collections.Generic.IEnumerable<UserDto>>>);
					num = (_003C_003E1__state = -1);
				}
				ApiResponse<global::System.Collections.Generic.IEnumerable<UserDto>> result = awaiter.GetResult();
				ApiResponse<global::System.Collections.Generic.IEnumerable<UserDto>> apiResponse = result;
				if (_003C_003Eo__4._003C_003Ep__0 == null)
				{
					_003C_003Eo__4._003C_003Ep__0 = CallSite<Func<CallSite, object, global::System.Collections.Generic.IEnumerable<UserDto>, object>>.Create(Binder.SetMember((CSharpBinderFlags)0, "Patients", typeof(CaregiverController), (global::System.Collections.Generic.IEnumerable<CSharpArgumentInfo>)(object)new CSharpArgumentInfo[2]
					{
						CSharpArgumentInfo.Create((CSharpArgumentInfoFlags)0, (string)null),
						CSharpArgumentInfo.Create((CSharpArgumentInfoFlags)1, (string)null)
					}));
				}
				_003C_003Eo__4._003C_003Ep__0.Target.Invoke((CallSite)(object)_003C_003Eo__4._003C_003Ep__0, ((Controller)caregiverController).ViewBag, apiResponse.Data);
				result2 = (IActionResult)(object)((Controller)caregiverController).View();
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLinkPatient_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IActionResult> _003C_003Et__builder;

		public CaregiverController _003C_003E4__this;

		public string email;

		private TaskAwaiter<ApiResponse<bool>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CaregiverController caregiverController = _003C_003E4__this;
			IActionResult result2;
			try
			{
				TaskAwaiter<ApiResponse<bool>> awaiter;
				if (num != 0)
				{
					awaiter = caregiverController._caregiverService.LinkPatientAsync(caregiverController.GetUserId(), email).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ApiResponse<bool>>, _003CLinkPatient_003Ed__7>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ApiResponse<bool>>);
					num = (_003C_003E1__state = -1);
				}
				ApiResponse<bool> result = awaiter.GetResult();
				ApiResponse<bool> apiResponse = result;
				((IDictionary<string, object>)(object)((Controller)caregiverController).TempData)[apiResponse.Success ? "Success" : "Error"] = apiResponse.Message;
				result2 = (IActionResult)(object)((ControllerBase)caregiverController).RedirectToAction("Dashboard");
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CPatientDetails_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IActionResult> _003C_003Et__builder;

		public CaregiverController _003C_003E4__this;

		public int patientId;

		private TaskAwaiter<ApiResponse<CaregiverDashboardDto>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CaregiverController caregiverController = _003C_003E4__this;
			IActionResult result2;
			try
			{
				TaskAwaiter<ApiResponse<CaregiverDashboardDto>> awaiter;
				if (num != 0)
				{
					awaiter = caregiverController._caregiverService.GetDashboardAsync(caregiverController.GetUserId(), patientId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ApiResponse<CaregiverDashboardDto>>, _003CPatientDetails_003Ed__5>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ApiResponse<CaregiverDashboardDto>>);
					num = (_003C_003E1__state = -1);
				}
				ApiResponse<CaregiverDashboardDto> result = awaiter.GetResult();
				ApiResponse<CaregiverDashboardDto> apiResponse = result;
				if (!apiResponse.Success)
				{
					((IDictionary<string, object>)(object)((Controller)caregiverController).TempData)["Error"] = apiResponse.Message;
					result2 = (IActionResult)(object)((ControllerBase)caregiverController).RedirectToAction("Dashboard");
				}
				else
				{
					result2 = (IActionResult)(object)((Controller)caregiverController).View((object)apiResponse.Data);
				}
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly ICaregiverService _caregiverService;

	private readonly IEmergencyAlertService _alertService;

	public CaregiverController(ICaregiverService caregiverService, IEmergencyAlertService alertService)
	{
		_caregiverService = caregiverService;
		_alertService = alertService;
	}

	private int GetUserId()
	{
		return int.Parse(((ControllerBase)this).User.FindFirst("userId").Value);
	}

	[AsyncStateMachine(typeof(_003CDashboard_003Ed__4))]
	public async global::System.Threading.Tasks.Task<IActionResult> Dashboard()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		ApiResponse<global::System.Collections.Generic.IEnumerable<UserDto>> apiResponse = await _caregiverService.GetLinkedPatientsAsync(GetUserId());
		if (_003C_003Eo__4._003C_003Ep__0 == null)
		{
			_003C_003Eo__4._003C_003Ep__0 = CallSite<Func<CallSite, object, global::System.Collections.Generic.IEnumerable<UserDto>, object>>.Create(Binder.SetMember((CSharpBinderFlags)0, "Patients", typeof(CaregiverController), (global::System.Collections.Generic.IEnumerable<CSharpArgumentInfo>)(object)new CSharpArgumentInfo[2]
			{
				CSharpArgumentInfo.Create((CSharpArgumentInfoFlags)0, (string)null),
				CSharpArgumentInfo.Create((CSharpArgumentInfoFlags)1, (string)null)
			}));
		}
		_003C_003Eo__4._003C_003Ep__0.Target.Invoke((CallSite)(object)_003C_003Eo__4._003C_003Ep__0, ((Controller)this).ViewBag, apiResponse.Data);
		return (IActionResult)(object)((Controller)this).View();
	}

	[AsyncStateMachine(typeof(_003CPatientDetails_003Ed__5))]
	public async global::System.Threading.Tasks.Task<IActionResult> PatientDetails(int patientId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		ApiResponse<CaregiverDashboardDto> apiResponse = await _caregiverService.GetDashboardAsync(GetUserId(), patientId);
		if (!apiResponse.Success)
		{
			((IDictionary<string, object>)(object)((Controller)this).TempData)["Error"] = apiResponse.Message;
			return (IActionResult)(object)((ControllerBase)this).RedirectToAction("Dashboard");
		}
		return (IActionResult)(object)((Controller)this).View((object)apiResponse.Data);
	}

	[HttpGet]
	public IActionResult LinkPatient()
	{
		return (IActionResult)(object)((Controller)this).View();
	}

	[AsyncStateMachine(typeof(_003CLinkPatient_003Ed__7))]
	[HttpPost]
	public async global::System.Threading.Tasks.Task<IActionResult> LinkPatient(string email)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		ApiResponse<bool> apiResponse = await _caregiverService.LinkPatientAsync(GetUserId(), email);
		((IDictionary<string, object>)(object)((Controller)this).TempData)[apiResponse.Success ? "Success" : "Error"] = apiResponse.Message;
		return (IActionResult)(object)((ControllerBase)this).RedirectToAction("Dashboard");
	}

	[AsyncStateMachine(typeof(_003CAcknowledgeAlert_003Ed__8))]
	[HttpPost]
	public async global::System.Threading.Tasks.Task<IActionResult> AcknowledgeAlert(int alertId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		await _alertService.AcknowledgeAlertAsync(alertId, GetUserId());
		return (IActionResult)(object)((ControllerBase)this).RedirectToAction("Dashboard");
	}
}
