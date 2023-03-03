namespace Loxifi.Interfaces
{
	public interface IResult
	{
		public Exception Exception { get; }

		public bool IsSuccess { get; }

		public object? Value { get; }
	}
}