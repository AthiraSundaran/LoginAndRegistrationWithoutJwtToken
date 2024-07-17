using System;
using EmployeeDi.Model;

namespace EmployeeDi.Sevices
{
	public class UserService:IuserInterface
	{

		public List<User> My_list = new List<User>
		{
			new User{ UserId=1,UserName="abc",Email="erd",Password="123"}
		};

       public bool Register(User user)
		{
			My_list.Add(user);
			return true;
			
		}

		public User LogIn(User user)
		{
			try
			{
			var res=My_list.FirstOrDefault(i => i.UserName == user.UserName && i.Password==user.Password);
				if (res == null)
				{
					throw new("user not found");
				}
				return res;

			}
			catch(Exception ex)
			{
				throw new(ex.Message);
			}
			
		}

    }
}

