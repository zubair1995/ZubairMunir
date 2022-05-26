using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemsLtd.Training.ECommerce.Model
{
	public class Customer
	{
		#region Properties
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerContact { get; set; }
		#endregion
		#region Constractor
		public Customer()
		{
		}
		#endregion
		#region Public Methods
		#endregion
	}
}

