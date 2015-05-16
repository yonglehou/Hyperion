using System;

namespace Hyperion.Http.Headers
{
    public interface IHttpResponseHeader { }

    /// <summary>
    /// Specifying which web sites can participate in cross-origin resource sharing
    /// </summary>
    public sealed class AccessControllAllowOriginHeader : HttpHeader, IHttpResponseHeader
    {
        public AccessControllAllowOriginHeader(string value) : base("Access-Control-Allow-Origin", value) { }
        public AccessControllAllowOriginHeader(bool all) : base("Access-Control-Allow-Origin", all ? "*" : String.Empty) { }
    }

    /// <summary>
    /// Specifies which patch document formats this server supports
    /// </summary>
    public sealed class AcceptPatchHeader : HttpHeader, IHttpResponseHeader
    {
        public AcceptPatchHeader(string value) : base("Accept-Patch", value) { }
    }

    /// <summary>
    /// What partial content range types this server supports
    /// </summary>
    public sealed class AcceptRangesHeader : HttpHeader, IHttpResponseHeader
    {
        public AcceptRangesHeader(string value) : base("Accept-Ranges", value) { }
    }

    /// <summary>
    /// The age the object has been in a proxy cache in seconds
    /// </summary>
    public sealed class AgeHeader : HttpHeader, IHttpResponseHeader
    {
        public AgeHeader(int seconds) : base("Age", seconds.ToString()) { }
        public AgeHeader(TimeSpan age) : base("Age", ((int)age.TotalSeconds).ToString()) { }
    }

    /// <summary>
    /// Valid actions for a specified resource. To be used for a 405 Method not allowed.
    /// </summary>
    public sealed class AllowHeader : HttpHeader, IHttpResponseHeader
    {
        public AllowHeader(params string[] methods) : base("Allow", string.Join(", ", methods)) { }
    }
}