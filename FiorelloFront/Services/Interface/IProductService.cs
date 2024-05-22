using System;
using FiorelloFront.Models;

namespace FiorelloFront.Services.Interface
{
	public interface IProductService
	{
		Task<IEnumerable<Product>> GetAllAsync();
	}
}

