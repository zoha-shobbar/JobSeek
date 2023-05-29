namespace JobSeek.Api.Responses
{
    public class ListResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public List<T>? Result { get; set; }
        public string Message { get; set; }


        public ListResponse(ResponseStatus status, List<T>? result = null, string message = "")
        {
            Status = status;
            Result = result;
            Message = message;
        }

        public static ListResponse<T> Success(List<T> result)
        {
            return new ListResponse<T>(ResponseStatus.Success, result);
        }

        public static ListResponse<T> Failed(ResponseStatus status, string message)
        {
            return new ListResponse<T>(status, null, message);
        }

        public static ListResponse<T> Failed(ResponseStatus status)
        {
            return new ListResponse<T>(status);
        }

        public static implicit operator ListResponse<T>(List<T> result)
        {
            return ListResponse<T>.Success(result);
        }

        public static implicit operator ListResponse<T>(ResponseStatus status)
        {
            return ListResponse<T>.Failed(status);
        }
    }
}