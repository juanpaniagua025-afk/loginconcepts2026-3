[Serializable]
internal class Exeption : Exception
{
	public Exeption()
	{
	}

	public Exeption(string? message) : base(message)
	{
	}

	public Exeption(string? message, Exception? innerException) : base(message, innerException)
	{
	}
}