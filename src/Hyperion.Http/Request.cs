using System;
using System.Collections.Generic;
using System.IO;
using Hyperion.Http.Headers;

namespace Hyperion.Http
{
    public static class HttpMethod
    {
        public const string Get = "GET";
        public const string Post = "POST";
        public const string Put = "PUT";
        public const string Patch = "PATCH";
        public const string Delete = "DELETE";
        public const string Options = "OPTIONS";
        public const string Head = "HEAD";
        public const string Trace = "TRACE";
        public const string Connect = "CONNECT";
    }

    /// <summary>
    /// Interface representing HTTP request.
    /// </summary>
    public interface IHttpRequest
    {
        /// <summary>
        /// Gets a HTTP method sent by the request.
        /// </summary>
        string Method { get; }

        /// <summary>
        /// Gets a URI address of incoming request.
        /// </summary>
        Uri Uri { get; }

        /// <summary>
        /// Gets a collection of HTTP headers brought by incoming request.
        /// </summary>
        IEnumerable<HttpHeader> Headers { get; }

        /// <summary>
        /// Gets stream with incoming content. It's a readonly stream.
        /// </summary>
        Stream InputStream { get; }
    }

    public class HttpRequest : IHttpRequest
    {
        public string Method { get; protected set; }
        public Uri Uri { get; protected set; }
        public IEnumerable<HttpHeader> Headers { get; protected set; }
        public Stream InputStream { get; protected set; }
    }
}