﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
	class UserDao
	{
		ShopAppDbContext db = null;
		public UserDao()
		{
			db = new ShopAppDbContext();
		}
		public long Insert(User entity)
		{
			db.Users.Add(entity);
			db.SaveChanges();
			return entity.ID;
		}
		public bool Login(string userName, string passWord)
		{
			var result = db.Users.Count(x => x.Username == userName && x.Password == passWord);
			if (result > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
