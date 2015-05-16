using System;
using System.Globalization;
using System.Text;

namespace Hyperion.Http.Headers
{
    public interface IHttpRequestHeader { }

    /// <summary>
    /// Content-Types that are acceptable for the response.
    /// </summary>
    public sealed class AcceptHeader : HttpHeader, IHttpRequestHeader
    {
        public AcceptHeader(string value) : base("Accept", value) { }
        public AcceptHeader(MimeType contentType) : base("Accept", contentType.ToString()) { }
    }

    /// <summary>
    /// Character sets that are acceptable
    /// </summary>
    public sealed class AcceptCharsetHeader : HttpHeader, IHttpRequestHeader
    {
        public AcceptCharsetHeader(string charset) : base("Accept-Charset", charset) { }
    }

    /// <summary>
    /// List of acceptable encodings.
    /// </summary>
    public sealed class AcceptEncodingHeader : HttpHeader, IHttpRequestHeader
    {
        public AcceptEncodingHeader(params string[] encodings) : base("Accept-Encoding", string.Join(", ", encodings)) { }
    }

    /// <summary>
    /// List of acceptable encodings.
    /// </summary>
    public sealed class AcceptLanguageHeader : HttpHeader, IHttpRequestHeader
    {
        public AcceptLanguageHeader(string value) : base("Accept-Language", value) { }
        public AcceptLanguageHeader(CultureInfo culture) : base("Accept-Language", culture.ToString()) { }
    }

    /// <summary>
    /// Acceptable version in time.
    /// </summary>
    public sealed class AcceptDateTimeHeader : HttpHeader, IHttpRequestHeader
    {
        public AcceptDateTimeHeader(string dateFormat) : base("Accept-Datetime", dateFormat) { }
    }

    /// <summary>
    /// Authentication credentials for HTTP authentication
    /// </summary>
    public sealed class AuthorizationHeader : HttpHeader, IHttpRequestHeader
    {
        public AuthorizationHeader(string credentials) : base("Authorization", credentials) { }
    }

    /// <summary>
    /// Authentication credentials for HTTP authentication
    /// </summary>
    public sealed class CacheControlHeader : HttpHeader, IHttpRequestHeader
    {
        public bool IsPrivate { get; set; }
        public int MaxAge { get; set; }
        public int? SMaxAge { get; set; }
        public bool NoCache { get; set; }
        public bool NoStore { get; set; }
        public bool MustRevalidate { get; set; }
        public bool NoTransform { get; set; }
        public bool ProxyRevalidate { get; set; }
        public string ETag { get; set; }
        public DateTime? Expires { get; set; }
        public string Vary { get; set; }

        public CacheControlHeader() : base("Cache-Control", null) { }

        public override string ToString()
        {
            return base.ToString() + GetHeaderValue();
        }

        private string GetHeaderValue()
        {
            var sb = new StringBuilder()
                .Append(IsPrivate ? "private, " : "public, ")
                .Append("max-age=").Append(MaxAge);

            if (SMaxAge.HasValue) sb.Append(", s-maxage").Append(SMaxAge.Value);
            if (NoCache) sb.Append(", no-cache");
            if (NoStore) sb.Append(", no-store");
            if (MustRevalidate) sb.Append(", must-revalidate");
            if (NoTransform) sb.Append(", no-transform");
            if (ProxyRevalidate) sb.Append(", proxy-revalidate");
            if (Expires.HasValue) sb.Append(Expires.Value.ToString("R"));
            if (!string.IsNullOrEmpty(ETag)) sb.Append("ETag: ").Append(ETag);
            if (!string.IsNullOrEmpty(Vary)) sb.Append("vary: ").Append(Vary);

            return sb.ToString();
        }
    }

    /// <summary>
    /// Control options for the current connection and list of hop-by-hop request fields.
    /// </summary>
    public sealed class ConnectionHeader : HttpHeader, IHttpRequestHeader
    {
        public ConnectionHeader(string value) : base("Connection", value) { }
        public ConnectionHeader(bool keepAlive) : base("Connection", keepAlive ? "keep-alive" : "Upgrade") { }
    }

    /// <summary>
    /// An HTTP cookie previously sent by the server with Set-Cookie.
    /// </summary>
    public sealed class CookieHeader : HttpHeader, IHttpRequestHeader
    {
        public CookieHeader(string value) : base("Cookie", value) { }
    }

    /// <summary>
    /// The length of the request body in octets (8-bit bytes).
    /// </summary>
    public sealed class ContentLengthHeader : HttpHeader, IHttpRequestHeader
    {
        public ContentLengthHeader(int length) : base("Content-Length", length.ToString()) { }
    }

    /// <summary>
    /// A Base64-encoded binary MD5 sum of the content of the request body.
    /// </summary>
    public sealed class ContentMd5Header : HttpHeader, IHttpRequestHeader
    {
        public ContentMd5Header(string md5) : base("Content-MD5", md5) { }
        public ContentMd5Header(byte[] md5) : base("Content-MD5", Convert.ToBase64String(md5)) { }
    }

    /// <summary>
    /// The MIME type of the body of the request.
    /// </summary>
    public sealed class ContentTypeHeader : HttpHeader, IHttpRequestHeader
    {
        public ContentTypeHeader(string contentType) : base("Content-Type", contentType) { }
    }

    /// <summary>
    /// The date and time that the message was sent.
    /// </summary>
    public sealed class DateHeader : HttpHeader, IHttpRequestHeader
    {
        public DateHeader(DateTime date) : base("Date", date.ToString("R")) { }
    }

    /// <summary>
    /// Indicates that particular server behaviors are required by the client.
    /// </summary>
    public sealed class ExpectHeader : HttpHeader, IHttpRequestHeader
    {
        public ExpectHeader(string value) : base("Expect", value) { }
        public ExpectHeader(int httpResponseCode) : base("Expect", httpResponseCode.ToString()) { }
    }

    /// <summary>
    /// The email address of the user making the request.
    /// </summary>
    public sealed class FromHeader : HttpHeader, IHttpRequestHeader
    {
        public FromHeader(string email) : base("From", email) { }
    }

    /// <summary>
    /// The domain name of the server (for virtual hosting), and the TCP port number on which the server is listening. 
    /// The port number may be omitted if the port is the standard port for the service requested. 
    /// </summary>
    public sealed class HostHeader : HttpHeader, IHttpRequestHeader
    {
        public HostHeader(string host) : base("Host", host) { }
        public HostHeader(string url, int port) : base("Host", url + ":" + port) { }
    }

    /// <summary>
    /// Only perform the action if the client supplied entity matches the same entity on the server. 
    /// This is mainly for methods like PUT to only update a resource if it has not been modified since the user last updated it.
    /// </summary>
    public sealed class IfMatchHeader : HttpHeader, IHttpRequestHeader
    {
        public IfMatchHeader(string value) : base("If-Match", value) { }
    }

    /// <summary>
    /// Allows a 304 Not Modified to be returned if content is unchanged
    /// </summary>
    public sealed class IfModifiedSinceHeader : HttpHeader, IHttpRequestHeader
    {
        public IfModifiedSinceHeader(DateTime date) : base("If-Modified-Since", date.ToString("R")) { }
    }

    /// <summary>
    /// Allows a 304 Not Modified to be returned if content is unchanged
    /// </summary>
    public sealed class IfNoneMatchHeader : HttpHeader, IHttpRequestHeader
    {
        public IfNoneMatchHeader(string value) : base("If-None-Match", value) { }
    }

    /// <summary>
    /// If the entity is unchanged, send me the part(s) that I am missing; otherwise, send me the entire new entity.
    /// </summary>
    public sealed class IfRangeHeader : HttpHeader, IHttpRequestHeader
    {
        public IfRangeHeader(string value) : base("If-Range", value) { }
    }

    /// <summary>
    /// Only send the response if the entity has not been modified since a specific time.
    /// </summary>
    public sealed class IfUnmodifiedSinceHeader : HttpHeader, IHttpRequestHeader
    {
        public IfUnmodifiedSinceHeader(DateTime date) : base("If-Unmodified-Since", date.ToString("R")) { }
    }

    /// <summary>
    /// Limit the number of times the message can be forwarded through proxies or gateways.
    /// </summary>
    public sealed class MaxForwardsHeader : HttpHeader, IHttpRequestHeader
    {
        public MaxForwardsHeader(int maxForwards) : base("Max-Forwards", maxForwards.ToString()) { }
    }

    /// <summary>
    /// Initiates a request for cross-origin resource sharing (asks server for an 'Access-Control-Allow-Origin' response field) .
    /// </summary>
    public sealed class OriginHeader : HttpHeader, IHttpRequestHeader
    {
        public OriginHeader(string url) : base("Origin", url) { }
        public OriginHeader(Uri url) : base("Origin", url.ToString()) { }
    }

    /// <summary>
    /// Implementation-specific fields that may have various effects anywhere along the request-response chain.
    /// </summary>
    public sealed class PragmaHeader : HttpHeader, IHttpRequestHeader
    {
        public bool NoCache { get; set; }
        public PragmaHeader(bool nocache) : base("Pragma", nocache ? "no-cache" : string.Empty) { }
    }

    /// <summary>
    /// Authorization credentials for connecting to a proxy.
    /// </summary>
    public sealed class ProxyAuthorizationHeader : HttpHeader, IHttpRequestHeader
    {
        public ProxyAuthorizationHeader(string credentials) : base("Proxy-Authorization", credentials) { }
    }

    /// <summary>
    /// Request only part of an entity. Bytes are numbered from 0.
    /// </summary>
    public sealed class RangeHeader : HttpHeader, IHttpRequestHeader
    {
        public RangeHeader(long from, long to) : base("Range", "bytes" + from + "-" + to) { }
    }

    /// <summary>
    /// This is the address of the previous web page from which a link to the currently requested page was followed. 
    /// (The word “referrer” has been misspelled in the RFC as well as in most implementations to the point 
    /// that it has become standard usage and is considered correct terminology)
    /// </summary>
    public sealed class Referer : HttpHeader, IHttpRequestHeader
    {
        public Referer(string refererUrl) : base("Referer", refererUrl) { }
    }

    /// <summary>
    /// The transfer encodings the user agent is willing to accept: the same values as for the response header field 
    /// Transfer-Encoding can be used, plus the "trailers" value (related to the "chunked" transfer method) to notify 
    /// the server it expects to receive additional fields in the trailer after the last, zero-sized, chunk.
    /// </summary>
    public sealed class TransferEncodingsHeader : HttpHeader, IHttpRequestHeader
    {
        public TransferEncodingsHeader(params string[] transferEncodings) : base("TE", string.Join(", ", transferEncodings)) { }
    }

    /// <summary>
    /// The user agent string of the user agent.
    /// </summary>
    public sealed class UserAgentHeader : HttpHeader, IHttpRequestHeader
    {
        public UserAgentHeader(string userAgent) : base("User-Agent", userAgent) { }
    }

    /// <summary>
    /// Ask the server to upgrade to another protocol.
    /// </summary>
    public sealed class UpgradeHeader : HttpHeader, IHttpRequestHeader
    {
        public UpgradeHeader(params string[] upgrades) : base("Upgrade", string.Join(", ", upgrades)) { }
    }

    /// <summary>
    /// Informs the server of proxies through which the request was sent.
    /// </summary>
    public sealed class ViaHeader : HttpHeader, IHttpRequestHeader
    {
        public ViaHeader(params string[] proxies) : base("Upgrade", string.Join(", ", proxies)) { }
    }

    /// <summary>
    /// A general warning about possible problems with the entity body.
    /// </summary>
    public sealed class WarningHeader : HttpHeader, IHttpRequestHeader
    {
        public WarningHeader(string warningMessage) : base("Warning", warningMessage) { }
    }
}