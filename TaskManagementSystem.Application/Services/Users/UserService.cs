﻿using Microsoft.AspNetCore.Http;
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


