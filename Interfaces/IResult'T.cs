namespace Loxifi.Interfaces
{
	public interface IResult<out T> : IResult
	{
		public new T? Value { get; }
	}
}