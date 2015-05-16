using System;
using Hyperion.Core;
using Hyperion.Http.Headers;

namespace Hyperion.Http.Filters
{
    public static class HttpFilters
    {
        /// <summary>
        /// A Cross-Origin Resource Sharing policy.
        /// </summary>
        /// <param name="origin">Value specified in the Origin HTTP request header. Default: * </param>
        /// <param name="methods"></param>
        /// <param name="headers"></param>
        /// <param name="exposes"></param>
        /// <returns></returns>
        public static Filter<TReq, TRep, TReq, TRep> Cors<TReq, TRep>(string origin = "*", string methods = "GET", string headers = "x-requested-with", string exposes = "")
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            return (httpRequest, service) =>
            {
                throw new NotImplementedException();
            };
        }

        /// <summary>
        /// General purpose exception filter:
        /// 499 Client Closed Request - all cancelations.
        /// 500 Internal Server Error - all uncaught exceptions.
        /// </summary>
        /// <returns></returns>
        public static Filter<TReq, TRep, TReq, TRep> InternalServerErrors<TReq, TRep>()
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            return (request, service) =>
            {
                throw new NotImplementedException();
            };
        }
    }
}