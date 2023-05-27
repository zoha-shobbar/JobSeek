namespace JobSeek.Api.Responses

{
    public class SingleResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public T? Result { get; set; }
        public string Message { get; set; }


        public Tuple<ResponseStatus, string> responseTuble = Tuple.Create(ResponseStatus.Success, "message");

        public static implicit operator SingleResponse<T>((ResponseStatus status, T result) tuple)
        {
            return new SingleResponse<T> { Status = tuple.status, Result = tuple.result, Message = "" };
        }


        public static SingleResponse<T> Success(T result)
        {
            return new SingleResponse<T> { Status = ResponseStatus.Success, Result = result, Message = "" };
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
    }
}