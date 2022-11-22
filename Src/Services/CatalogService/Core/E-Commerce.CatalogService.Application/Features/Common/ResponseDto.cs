namespace E_Commerce.CatalogService.Application.Features.Common
{
    public class ResponseDto<T>
    {
        public T Data { get; set; }


        public string Message { get; set; }

        public static ResponseDto<T> SuccesWithData(T data)
        {
            return new ResponseDto<T> { Data = data };
        }

        public static ResponseDto<T> SuccesWithOutData(string message)
        {
            return new ResponseDto<T> { Message = message };
        }
    }
}
