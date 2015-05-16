using System;

namespace Hyperion.Http.Headers
{
    public abstract class HttpHeader : IEquatable<HttpHeader>
    {
        public readonly string Name;
        public readonly string Value;

        /// <exception cref="ArgumentException">HTTP header name cannot be null</exception>
        protected HttpHeader(string name, string value)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("HTTP header name cannot be null", "name");

            Name = name;
            Value = value ?? string.Empty;
        }

        public bool Equals(HttpHeader other)
        {
            return other != null && string.Equals(ToString(), other.ToString(), StringComparison.InvariantCultureIgnoreCase);
        }

        public override string ToString()
        {
            return Name + ": " + Value;
        }

        public sealed override bool Equals(object obj)
        {
            return Equals(obj as HttpHeader);
        }

        public sealed override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}