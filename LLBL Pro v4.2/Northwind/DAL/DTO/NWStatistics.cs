namespace Northwind.DAL.DTO
{
	/// <summary>
	/// Class which is used to transport some statistics data to the client for the main screen.
  /// From https://github.com/SolutionsDesign/LLBLGenProExamples_4.x/
	/// </summary>
	public class NWStatistics
	{
		public int NumberOfCustomers { get; set; }
		public decimal MaxOrderPrice { get; set; }
		public string MaxOrderCustomerCompanyName { get; set; }
		public string MaxOrderCustomerCustomerId { get; set; }
		public decimal AverageOrderPrice { get; set; }
		public string MostOrdersCustomerCustomerId { get; set; }
		public string MostOrdersCustomerCompanyName { get; set; }
		public int MostOrdersForOneCustomer { get; set; }
	}
}
