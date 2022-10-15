using ManegementApi.Models;
using System.Collections;
using System.Collections.Generic;

namespace ManegementApi.ViewModels
{
	public class HomeIndexViewModel
	{
		public IEnumerable<Staff> Staffs { get; set; }
	}
}
