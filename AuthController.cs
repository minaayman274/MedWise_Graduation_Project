using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using MedWise.Core.DTOs;
using MedWise.Core.Enums;
using MedWise.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedWise.Controllers;

public class AuthController : Controller
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLogin_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IActionResult> _003C_003Et__builder;

		public AuthController _003C_003E4__this;

		public LoginDto dto;

		private TaskAwaiter<ApiResponse<AuthResponseDto>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			AuthController authController = _003C_003E4__this;
			IActionResult result;
			try
			{
				TaskAwaiter<ApiResponse<AuthResponseDto>> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ApiResponse<AuthResponseDto>>);
					num = (_003C_003E1__state = -1);
					goto IL_0092;
				}
				if (((ControllerBase)authController).ModelState.IsValid)
				{
					awaiter = authController._authService.LoginAsync(dto).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ApiResponse<AuthResponseDto>>, _003CLogin_003Ed__3>(ref awaiter, ref this);
						return;
					}
					goto IL_0092;
				}
				result = (IActionResult)(object)((Controller)authController).View((object)dto);
				goto end_IL_000e;
				IL_0092:
				ApiResponse<AuthResponseDto> result2 = awaiter.GetResult();
				ApiResponse<AuthResponseDto> apiResponse = result2;
				if (!apiResponse.Success)
				{
					((ControllerBase)authController).ModelState.AddModelError("", apiResponse.Message);
					result = (IActionResult)(object)((Controller)authController).View((object)dto);
				}
				else
				{
					((ControllerBase)authController).Response.Cookies.Append("jwt_token", apiResponse.Data.Token, new CookieOptions
					{
						HttpOnly = true,
						Secure = true,
						SameSite = (SameSiteMode)2,
						Expires = DateTimeOffset.op_Implicit(apiResponse.Data.ExpiresAt)
					});
					result = (IActionResult)(object)((apiResponse.Data.User.Role == UserRole.Caregiver) ? ((ControllerBase)authController).RedirectToAction("Dashboard", "Caregiver") : ((ControllerBase)authController).RedirectToAction("Dashboard", "Patient"));
				}
				end_IL_000e:;
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
	private struct _003CRegister_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IActionResult> _003C_003Et__builder;

		public AuthController _003C_003E4__this;

		public RegisterDto dto;

		private TaskAwaiter<ApiResponse<AuthResponseDto>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			AuthController authController = _003C_003E4__this;
			IActionResult result;
			try
			{
				TaskAwaiter<ApiResponse<AuthResponseDto>> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ApiResponse<AuthResponseDto>>);
					num = (_003C_003E1__state = -1);
					goto IL_0092;
				}
				if (((ControllerBase)authController).ModelState.IsValid)
				{
					awaiter = authController._authService.RegisterAsync(dto).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ApiResponse<AuthResponseDto>>, _003CRegister_003Ed__5>(ref awaiter, ref this);
						return;
					}
					goto IL_0092;
				}
				result = (IActionResult)(object)((Controller)authController).View((object)dto);
				goto end_IL_000e;
				IL_0092:
				ApiResponse<AuthResponseDto> result2 = awaiter.GetResult();
				ApiResponse<AuthResponseDto> apiResponse = result2;
				if (!apiResponse.Success)
				{
					((ControllerBase)authController).ModelState.AddModelError("", apiResponse.Message);
					result = (IActionResult)(object)((Controller)authController).View((object)dto);
				}
				else
				{
					((ControllerBase)authController).Response.Cookies.Append("jwt_token", apiResponse.Data.Token, new CookieOptions
					{
						HttpOnly = true,
						Secure = true,
						SameSite = (SameSiteMode)2,
						Expires = DateTimeOffset.op_Implicit(apiResponse.Data.ExpiresAt)
					});
					result = (IActionResult)(object)((apiResponse.Data.User.Role == UserRole.Caregiver) ? ((ControllerBase)authController).RedirectToAction("Dashboard", "Caregiver") : ((ControllerBase)authController).RedirectToAction("Dashboard", "Patient"));
				}
				end_IL_000e:;
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

	private readonly IAuthService _authService;

	public AuthController(IAuthService authService)
	{
		_authService = authService;
	}

	[HttpGet]
	public IActionResult Login()
	{
		return (IActionResult)(object)((Controller)this).View();
	}

	[AsyncStateMachine(typeof(_003CLogin_003Ed__3))]
	[HttpPost]
	public async global::System.Threading.Tasks.Task<IActionResult> Login(LoginDto dto)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (!((ControllerBase)this).ModelState.IsValid)
		{
			return (IActionResult)(object)((Controller)this).View((object)dto);
		}
		ApiResponse<AuthResponseDto> apiResponse = await _authService.LoginAsync(dto);
		if (!apiResponse.Success)
		{
			((ControllerBase)this).ModelState.AddModelError("", apiResponse.Message);
			return (IActionResult)(object)((Controller)this).View((object)dto);
		}
		((ControllerBase)this).Response.Cookies.Append("jwt_token", apiResponse.Data.Token, new CookieOptions
		{
			HttpOnly = true,
			Secure = true,
			SameSite = (SameSiteMode)2,
			Expires = DateTimeOffset.op_Implicit(apiResponse.Data.ExpiresAt)
		});
		return (IActionResult)(object)((apiResponse.Data.User.Role == UserRole.Caregiver) ? ((ControllerBase)this).RedirectToAction("Dashboard", "Caregiver") : ((ControllerBase)this).RedirectToAction("Dashboard", "Patient"));
	}

	[HttpGet]
	public IActionResult Register()
	{
		return (IActionResult)(object)((Controller)this).View();
	}

	[AsyncStateMachine(typeof(_003CRegister_003Ed__5))]
	[HttpPost]
	public async global::System.Threading.Tasks.Task<IActionResult> Register(RegisterDto dto)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (!((ControllerBase)this).ModelState.IsValid)
		{
			return (IActionResult)(object)((Controller)this).View((object)dto);
		}
		ApiResponse<AuthResponseDto> apiResponse = await _authService.RegisterAsync(dto);
		if (!apiResponse.Success)
		{
			((ControllerBase)this).ModelState.AddModelError("", apiResponse.Message);
			return (IActionResult)(object)((Controller)this).View((object)dto);
		}
		((ControllerBase)this).Response.Cookies.Append("jwt_token", apiResponse.Data.Token, new CookieOptions
		{
			HttpOnly = true,
			Secure = true,
			SameSite = (SameSiteMode)2,
			Expires = DateTimeOffset.op_Implicit(apiResponse.Data.ExpiresAt)
		});
		return (IActionResult)(object)((apiResponse.Data.User.Role == UserRole.Caregiver) ? ((ControllerBase)this).RedirectToAction("Dashboard", "Caregiver") : ((ControllerBase)this).RedirectToAction("Dashboard", "Patient"));
	}

	public IActionResult Logout()
	{
		((ControllerBase)this).Response.Cookies.Delete("jwt_token");
		return (IActionResult)(object)((ControllerBase)this).RedirectToAction("Index", "Home");
	}
}
