namespace JobSeek.Api.Responses
{
    public class ListResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public List<T>? Result { get; set; }
        public string Message { get; set; }


        public static ListResponse<T> Success(List<T> result)
        {
            return new ListResponse<T> { Status = ResponseStatus.Success, Result = result };
        }

        public static ListResponse<T> Success(List<T> result, string message)
        {
            return new ListResponse<T> { Status = ResponseStatus.Success, Result = result, Message = message };
        }


        public static ListResponse<T> Failed(ResponseStatus status, string message)
        {
            return new ListResponse<T> { Status = status, Result = null, Message = message };
        }

        public static ListResponse<T> Failed(ResponseStatus status)
        {
            return new ListResponse<T> { Status = status, Result = null, Message = "" };
        }

        public static implicit operator ListResponse<T>(List<T> result)
        {
            return ListResponse<T>.Success(result);
        }

        public static implicit operator ListResponse<T>(ResponseStatus status)
        {
            return ListResponse<T>.Failed(status);
        }

        public static implicit operator ListResponse<T>(Tuple<List<T>, string> data)
        {
            return ListResponse<T>.Success(data.Item1, data.Item2);
        }
    }
}