using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace TaskManagementSystem.Application.Services.Users
{
	public class UserService(UserManager<ApplicationUser> _userManager,
		IHttpContextAccessor _httpContextAccessor) : IUserService
	{

		public async Task<ApplicationUser> GetLoggedInUser()
		{
			var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
			return user;
		}
		public async Task<ApplicationUser> GetUserById(string userId)
		{
			var user = await _userManager.FindByIdAsync(userId);
			return user;
		}

		public async Task<List<ApplicationUser>> GetEmployees()
		{
			var employees = await _userManager.GetUsersInRoleAsync(Roles.Employee);
			//we need to list because the above result is an IList
			return employees.ToList();
		}


	}
}





//_userManager: This is an instance of UserManager<ApplicationUser>, which
//is part of ASP.NET Identity and provides methods for managing users.
//_httpContextAccessor.HttpContext
//_httpContextAccessor: This is an instance of the IHttpContextAccessor interface, which provides access to the current HttpContext.
//HttpContext: Represents the HTTP request context, including information about the user, request headers, response, and more. This is specific to the current web request.
//2. HttpContext?.User
//User: This property of HttpContext represents the security context of the current user. It contains the claims-based identity of the user who made the request.
//The ?. operator ensures that this only proceeds if HttpContext is not null (i.e., there's an active HTTP request)._httpContextAccessor.HttpContext
//_httpContextAccessor: This is an instance of the IHttpContextAccessor interface, which provides access to the current HttpContext.
//HttpContext: Represents the HTTP request context, including information about the user, request headers, response, and more. This is specific to the current web request.
//2. HttpContext?.User
//User: This property of HttpContext represents the security context of the current user. It contains the claims-based identity of the user who made the request.
//The ?. operator ensures that this only proceeds if HttpContext is not null (i.e., there's an active HTTP request).