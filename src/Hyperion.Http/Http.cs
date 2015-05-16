using Hyperion.Core;

namespace Hyperion.Http
{
    public static class HttpVersion
    {
        public const string Http11 = "HTTP 1.1";
    }

    public interface IHttpClient : IClient<IHttpRequest, IHttpResponse>
    {

    }

    public interface IHttpServer : IServer<IHttpRequest, IHttpResponse>
    {

    }
}