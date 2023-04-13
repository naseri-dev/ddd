namespace Domain.Products;

public record Sku
{
	private const int DefaultValue = 15;
	public string Value { get; init; }
	private Sku(string value) => Value = value;

	public static Sku? Create(string value)
	{
		if (string.IsNullOrEmpty(value)) 
		{ return null; }
		if (value.Length != DefaultValue) return null;

		return new Sku(value);
	}
}