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
		public int Balance { get; set; }
		public string Address { get; set; }
		public DateTime DateOfBirth { get; set; }
		public User(int Id, string Name, string SurName, string Email, string AccountNumber, int Balance, string Address, DateTime DateOfBirth)
		{
			this.Id = Id;
			this.Name = Name;
			this.Surname = Surname;
			this.Email = Email;
			this.AccountNumber = AccountNumber;
			this.Balance = Balance;
			this.Address = Address;
			this.DateOfBirth = DateOfBirth;
		}
		public User()
		{

		}
	}

}

