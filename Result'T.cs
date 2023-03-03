using Loxifi.Interfaces;

namespace Loxifi.Monads
{
	/// <summary>
	/// Represents a success or failure result of an operation
	/// </summary>
	/// <typeparam name="T">The potential result type</typeparam>
	public class Result<T> : IResult<T?>
	{
		private readonly Exception _exception;

		private readonly T? _value;

		internal Result(T? value)
		{
			this._value = value;
			this.IsSuccess = true;
		}

		internal Result(Exception e)
		{
			this._exception = e;
			this.IsSuccess = false;
		}

		public Exception Exception
		{
			get
			{
				if (this.IsSuccess)
				{
					throw new InvalidOperationException("Can not access the error property of a successful result");
				}

				return this._exception;
			}
		}

		public bool IsSuccess { get; private set; }

		public T? Value
		{
			get
			{
				if (!this.IsSuccess)
				{
					throw this._exception;
				}

				return this._value;
			}
		}

		object? IResult.Value => this.Value;
	}
}