using System;

namespace Hyperion.Http
{
    public struct HttpResponseStatus : IEquatable<HttpResponseStatus>, IEquatable<int>
    {
        public readonly int StatusCode;
        public readonly string Description;

        public HttpResponseStatus(int statusCode, string description)
        {
            StatusCode = statusCode;
            Description = description;
        }

        public bool Equals(HttpResponseStatus other)
        {
            return other.StatusCode == StatusCode;
        }

        public bool Equals(int other)
        {
            return other == StatusCode;
        }

        public override string ToString()
        {
            return StatusCode.ToString() + " " + Description;
        }

        public override bool Equals(object obj)
        {
            if (obj is HttpResponseStatus) return Equals((HttpResponseStatus)obj);
            if (obj is int) return Equals((int)obj);
            return false;
        }

        public override int GetHashCode()
        {
            return StatusCode.GetHashCode();
        }

        #region Statuses

        public static HttpResponseStatus Continue = new HttpResponseStatus(100, "Continue");
        public static HttpResponseStatus SwitchingProtocols = new HttpResponseStatus(101, "Switching Protocols");
        public static HttpResponseStatus ConnectionTimedOut = new HttpResponseStatus(110, "Connection Timed Out");
        public static HttpResponseStatus ConnectionRefused = new HttpResponseStatus(111, "Connection Refused");

        public static HttpResponseStatus Ok = new HttpResponseStatus(200, "OK");
        public static HttpResponseStatus Created = new HttpResponseStatus(201, "Created");
        public static HttpResponseStatus Accepted = new HttpResponseStatus(202, "Accepted");
        public static HttpResponseStatus NonAuthoritativeInformation = new HttpResponseStatus(203, "Non-Authoritative Information");
        public static HttpResponseStatus NoContent = new HttpResponseStatus(204, "No content");
        public static HttpResponseStatus ResetContent = new HttpResponseStatus(205, "Reset Content");
        public static HttpResponseStatus PartialContent = new HttpResponseStatus(206, "Partial Content");
        public static HttpResponseStatus MultiStatus = new HttpResponseStatus(207, "Multi-Status");
        public static HttpResponseStatus AlreadyReported = new HttpResponseStatus(208, "Already Reported");
        public static HttpResponseStatus ImUsed = new HttpResponseStatus(226, "IM Used");

        public static HttpResponseStatus MultipleChoices = new HttpResponseStatus(300, "Multiple Choices");
        public static HttpResponseStatus MovedPermanently = new HttpResponseStatus(301, "Moved Permanently");
        public static HttpResponseStatus Found = new HttpResponseStatus(302, "Multiple Choices");
        public static HttpResponseStatus SeeOther = new HttpResponseStatus(303, "See Other");
        public static HttpResponseStatus NotModified = new HttpResponseStatus(304, "Not Modified");
        public static HttpResponseStatus UseProxy = new HttpResponseStatus(305, "Use Proxy");
        public static HttpResponseStatus SwitchProxy = new HttpResponseStatus(306, "Switch Proxy");
        public static HttpResponseStatus TemporaryRedirect = new HttpResponseStatus(307, "Temporary Redirect");
        public static HttpResponseStatus PermanentRedirect = new HttpResponseStatus(308, "Permanent Redirect");

        public static HttpResponseStatus BadRequest = new HttpResponseStatus(400, "Bad Request");
        public static HttpResponseStatus Unauthorized = new HttpResponseStatus(401, "Unauthorized");
        public static HttpResponseStatus PaymentRequired = new HttpResponseStatus(402, "Payment Required");
        public static HttpResponseStatus Forbidden = new HttpResponseStatus(403, "Forbidden");
        public static HttpResponseStatus NotFound = new HttpResponseStatus(404, "Not Found");
        public static HttpResponseStatus MethodNotAllowed = new HttpResponseStatus(405, "Method Not Allowed");
        public static HttpResponseStatus NotAcceptable = new HttpResponseStatus(406, "Not Acceptable");
        public static HttpResponseStatus ProxyAuthenticationRequired = new HttpResponseStatus(407, "Proxy Authentication Required");
        public static HttpResponseStatus RequestTimeout = new HttpResponseStatus(408, "Request Timeout");
        public static HttpResponseStatus Conflict = new HttpResponseStatus(409, "Conflict");
        public static HttpResponseStatus Gone = new HttpResponseStatus(410, "Gone");
        public static HttpResponseStatus LengthRequired = new HttpResponseStatus(411, "Length Required");
        public static HttpResponseStatus PreconditionFailed = new HttpResponseStatus(412, "Precondition Failed");
        public static HttpResponseStatus RequestEntityTooLarge = new HttpResponseStatus(413, "Request Entity Too Large");
        public static HttpResponseStatus RequestUriTooLong = new HttpResponseStatus(414, "Request-URI Too Long");
        public static HttpResponseStatus UnsupportedMediaType = new HttpResponseStatus(415, "Unsupported Media Type");
        public static HttpResponseStatus NotSatisfiable = new HttpResponseStatus(416, "Requested Range Not Satisfiable");
        public static HttpResponseStatus ExpectationFailed = new HttpResponseStatus(417, "Expectation Failed");
        public static HttpResponseStatus Teapot = new HttpResponseStatus(418, "I'm a teapot");
        public static HttpResponseStatus AuthenticationTimeout = new HttpResponseStatus(419, "Authentication Timeout");
        public static HttpResponseStatus MethodFailure = new HttpResponseStatus(420, "Method Failure");
        public static HttpResponseStatus EnhanceYourCalm = new HttpResponseStatus(420, "Enhance Your Calm");
        public static HttpResponseStatus Missdirected = new HttpResponseStatus(421, "Misdirected Request");
        public static HttpResponseStatus UnprocessableEntity = new HttpResponseStatus(422, "Unprocessable Entity");
        public static HttpResponseStatus Locked = new HttpResponseStatus(423, "Locked");
        public static HttpResponseStatus FailedDependency = new HttpResponseStatus(424, " Failed Dependency");
        public static HttpResponseStatus UpgradeRequired = new HttpResponseStatus(426, "Upgrade Required");
        public static HttpResponseStatus PreconditionRequired = new HttpResponseStatus(428, "Precondition Required");
        public static HttpResponseStatus TooManyRequests = new HttpResponseStatus(429, "Too Many Requests");
        public static HttpResponseStatus RequestHeaderFieldsTooLarge = new HttpResponseStatus(431, "Request Header Fields Too Large");
        public static HttpResponseStatus LoginTimeout = new HttpResponseStatus(440, "Login Timeout");
        public static HttpResponseStatus NoResponse = new HttpResponseStatus(444, "No Response");
        public static HttpResponseStatus RetryWith = new HttpResponseStatus(449, "Retry With");
        public static HttpResponseStatus ParentalControlBlock = new HttpResponseStatus(450, "Blocked by Windows Parental Controls");
        public static HttpResponseStatus MicrosoftRedirect = new HttpResponseStatus(451, "Redirect");
        public static HttpResponseStatus UnavailableForLegalReasons = new HttpResponseStatus(451, "Unavailable For Legal Reasons");
        public static HttpResponseStatus RequestHeaderTooLarge = new HttpResponseStatus(494, "Request Header Too Large");
        public static HttpResponseStatus CertError = new HttpResponseStatus(495, "Cert Error");
        public static HttpResponseStatus NoCert = new HttpResponseStatus(496, "No Cert");
        public static HttpResponseStatus Http2Https = new HttpResponseStatus(497, "HTTP to HTTPS");
        public static HttpResponseStatus TokenExpiredOrInvalid = new HttpResponseStatus(498, "Token expired/invalid");
        public static HttpResponseStatus ClientClosedRequest = new HttpResponseStatus(499, " Client Closed Request");
        public static HttpResponseStatus TokenRequired = new HttpResponseStatus(499, "Token required");
        
        public static HttpResponseStatus InternalServerError = new HttpResponseStatus(500, "Internal Server Error");
        public static HttpResponseStatus NotImplemented = new HttpResponseStatus(501, "Not Implemented");
        public static HttpResponseStatus BadGateway = new HttpResponseStatus(502, "Bad Gateway");
        public static HttpResponseStatus ServiceUnavailable = new HttpResponseStatus(503, "Service Unavailable");
        public static HttpResponseStatus GatewayTimeout = new HttpResponseStatus(504, "Gateway Timeout");
        public static HttpResponseStatus HttpVersionNotSupported = new HttpResponseStatus(505, "HTTP Version Not Supported");
        public static HttpResponseStatus VariantNegotiates = new HttpResponseStatus(506, "Variant Also Negotiates");
        public static HttpResponseStatus InsufficientStorage = new HttpResponseStatus(507, "Insufficient Storage");
        public static HttpResponseStatus LoopDetected = new HttpResponseStatus(508, "Loop Detected");
        public static HttpResponseStatus BandwithLimitExceeded = new HttpResponseStatus(509, "Bandwidth Limit Exceeded");
        public static HttpResponseStatus NotExtended = new HttpResponseStatus(510, "Not Extended");
        public static HttpResponseStatus NetworkAuthenticationRequired = new HttpResponseStatus(511, "Network Authentication Required");
        public static HttpResponseStatus NetworkReadTimeout = new HttpResponseStatus(598, "Network read timeout error");
        public static HttpResponseStatus NetworkConnectTimeout = new HttpResponseStatus(599, "Network connect timeout error");

        #endregion
    }
}