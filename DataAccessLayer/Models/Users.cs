using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string AccountNumber { get; set; }
		public Decimal Balance { get; set; }
		public string Address { get; set; }
		public User()
		{

		}
	}

}

