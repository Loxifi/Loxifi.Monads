using Loxifi.Interfaces;

namespace Loxifi.Monads
{
	public partial class Result : Result<bool>
	{
		internal Result(bool value) : base(value)
		{
		}

		internal Result(Exception e) : base(e)
		{
		}
	}

	public partial class Result
	{
		public static IResult<T> Failure<T>(Exception ex) => new Result<T>(ex);

		public static IResult Failure(Exception ex) => new Result(ex);

		public static IResult<T> Success<T>(T value) => new Result<T>(value);

		public static IResult Success() => new Result(true);
	}
}