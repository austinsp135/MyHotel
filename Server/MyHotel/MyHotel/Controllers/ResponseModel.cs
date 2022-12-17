namespace MyHotel.Controllers
{
    internal class ResponseModel<T>
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; }
        public string Data { get; internal set; }
    }
}