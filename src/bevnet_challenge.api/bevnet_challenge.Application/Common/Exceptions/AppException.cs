using System.Globalization;
using System.Net;

namespace bevnet_challenge.Application.Common.Exceptions
{
    public class AppException : Exception
    {
        public HttpStatusCode StatusCode { get; }

        public AppException() : base() { }
        public AppException(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest) : base(message) { StatusCode = statusCode; }
        public AppException(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args)) { StatusCode = statusCode; }
    }
}
