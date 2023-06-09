﻿using Domain.Customers;
using Domain.Products;

namespace Domain.Orders;

public class Order
{
	private readonly HashSet<LineItem> _lineItems = new();
	public OrderId Id { get; private set; }
	public CustomerId CustomerId { get; private set; }

	private Order() { }

	public static Order Create(Customer customer)
	{
		var order = new Order()
		{
			Id = new OrderId(Guid.NewGuid()),
			CustomerId = customer.Id
		};
		return order;
	}
	public void Add(Product product)
	{
		var lineItem = new LineItem(
			new LineItemId(Guid.NewGuid()),
			Id,
			product.Id,
			product.Price);

		_lineItems.Add(lineItem);
	}
}
