namespace TaskManagementSystem.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string ResponseMessage { get; set; } = string.Empty;
    }
}
