﻿using TechBuddy.Extension.Validation.Infrastructure.Models.ResponseModels;

namespace E_Commerce.IdentityService.Application.Models
{
    public class ResponseDto<T> : BaseValidationErrorResponseModel
    {
        public T? Data { get; set; }
        public string Message { get; set; }

        public static ResponseDto<T> SuccesWithData(T data)
        {
            return new ResponseDto<T> { Data = data, Errors = null, Message = null };
        }

        public static ResponseDto<T> SuccesWithOutData(string message)
        {
            return new ResponseDto<T> { Data = default, Message = message, Errors = null };
        }

        public static ResponseDto<T> Failed(List<string> errors)
        {
            return new ResponseDto<T> { Data = default, Message = null, Errors = errors };
        }

        public static ResponseDto<T> Failed(string error)
        {
            return new ResponseDto<T> { Data = default, Message = null, Errors = new List<string>() { error } };
        }
    }
}
