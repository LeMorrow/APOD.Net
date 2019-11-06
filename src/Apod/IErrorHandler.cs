﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Apod
{
    public interface IErrorHandler
    {
        ApodError ValidateDate(DateTime dateTime);
        ApodError ValidateDateRange(DateTime startDate, DateTime endDate);
        Task<ApodError> ValidateHttpResponseAsync(HttpResponseMessage httpResponse);
    }
}
