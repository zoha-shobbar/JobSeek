namespace JobSeek.Api.Responses

{
    public class SingleResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public T? Result { get; set; }
        public string Message { get; set; }

        public static SingleResponse<T> Success(T result)
        {
            return new SingleResponse<T> { Status = ResponseStatus.Success, Result = result, Message = "" };
        }

        public static SingleResponse<T> Success(T result, string message)
        {
            return new SingleResponse<T> { Status = ResponseStatus.Success, Result = result, Message = message };
        }

        public static SingleResponse<T> Failed(ResponseStatus status)
        {
            return new SingleResponse<T> { Status = status, Result = default };
        }

        public static SingleResponse<T> Failed(ResponseStatus status, string message)
        {
            return new SingleResponse<T> { Status = status, Result = default, Message = message };
        }

        public static implicit operator SingleResponse<T>(ResponseStatus status)
        {
            return SingleResponse<T>.Failed(status);
        }

        public static implicit operator SingleResponse<T>(T result)
        {
            return SingleResponse<T>.Success(result);
        }

        public static implicit operator SingleResponse<T>(Tuple<T, string> data)
        {
            return SingleResponse<T>.Success(data.Item1, data.Item2);
        }
    }
}