namespace JobSeek.Api.Responses;

public class ListRespons<T>
{
    public ResponsStatus Status { get; set; }
    public List<T>? Result { get; set; }

    public static ListRespons<T> Success(List<T> result)
    {
        return new ListRespons<T> { Status = ResponsStatus.Success, Result = result };
    }

    public static ListRespons<T> Failed(ResponsStatus status)
    {
        return new ListRespons<T> { Status = status, Result = null };
    }
}
