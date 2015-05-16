using System.Collections.Generic;
using System.IO;
using Hyperion.Http.Headers;

namespace Hyperion.Http
{
    public interface IHttpResponse
    {
        /// <summary>
        /// Gets collection of HTTP headers sent with provided response.
        /// </summary>
        IEnumerable<HttpHeader> Headers { get; }

        /// <summary>
        /// HTTP response status code.
        /// </summary>
        HttpResponseStatus StatusCode { get; }

        /// <summary>
        /// Output writeable stream. Contains data sent back to client.
        /// </summary>
        Stream OutputStream { get; }

        /// <summary>
        /// Adds new HTTP response header to be sent. Returns value determining if provided header replaced existing one.
        /// </summary>
        bool AddHeader<THttpHeader>(THttpHeader header) where THttpHeader : HttpHeader, IHttpResponseHeader;
    }

    public class HttpResponse : IHttpResponse
    {
        private readonly ISet<HttpHeader> _headers = new HashSet<HttpHeader>();
        public IEnumerable<HttpHeader> Headers { get { return _headers; } }
        public HttpResponseStatus StatusCode { get; protected set; }
        public Stream OutputStream { get; protected set; }

        public bool AddHeader<THttpHeader>(THttpHeader header) where THttpHeader : HttpHeader, IHttpResponseHeader
        {
            return _headers.Add(header);
        }
    }
}