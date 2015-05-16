using System;
using Hyperion.Core;

namespace Hyperion.Http.Routing
{
    using HttpService = Service<IHttpRequest, IHttpResponse>;

    public class Router
    {
        public static HttpService Combine(params HttpService[] routees)
        {
            throw new NotImplementedException();
        }

        public static HttpService Get<TReq, TRep>(string path, Service<TReq, TRep> responder)
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            throw new NotImplementedException();
        }

        public static HttpService Get<TReq, TRep>(RoutePath path, Service<TReq, TRep> responder)
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            throw new NotImplementedException();
        }

        public static HttpService Post<TReq, TRep>(string path, Service<TReq, TRep> responder)
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            throw new NotImplementedException();
        }

        public static HttpService Post<TReq, TRep>(RoutePath path, Service<TReq, TRep> responder)
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            throw new NotImplementedException();
        }

        public static HttpService Put<TReq, TRep>(string path, Service<TReq, TRep> responder)
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            throw new NotImplementedException();
        }

        public static HttpService Put<TReq, TRep>(RoutePath path, Service<TReq, TRep> responder)
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            throw new NotImplementedException();
        }

        public static HttpService Patch<TReq, TRep>(string path, Service<TReq, TRep> responder)
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            throw new NotImplementedException();
        }

        public static HttpService Patch<TReq, TRep>(RoutePath path, Service<TReq, TRep> responder)
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            throw new NotImplementedException();
        }

        public static HttpService Delete<TReq, TRep>(string path, Service<TReq, TRep> responder)
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            throw new NotImplementedException();
        }

        public static HttpService Delete<TReq, TRep>(RoutePath path, Service<TReq, TRep> responder)
            where TReq : IHttpRequest
            where TRep : IHttpResponse
        {
            throw new NotImplementedException();
        }
    }
}