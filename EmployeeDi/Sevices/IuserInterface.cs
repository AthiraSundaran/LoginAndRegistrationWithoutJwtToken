using System;
using EmployeeDi.Model;

namespace EmployeeDi.Sevices
{
	public interface IuserInterface
	{
		bool Register(User user);
		User LogIn(User user);
	}
}

