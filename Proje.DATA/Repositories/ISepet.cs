﻿using Proje.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DATA.Repositories
{
	public interface ISepet :IBaseRepository<Sepet>
	{
		List<Sepet> GetSepetIncludeMenu(string userId);
	}
}
