using System;
using System.Collections;
using System.Collections.Generic;

namespace Hyperion.Http.Routing
{
    [Serializable]
    public class RouteParsingException : Exception
    {
        public RouteParsingException(string message) : base(message) { }
        protected RouteParsingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    public abstract class Route 
    {
        public static readonly Route Root = new StaticRoute("/");
    }

    public class StaticRoute : Route
    {
        private readonly string _route;

        public StaticRoute(string route)
        {
            _route = route;
        }

        public override string ToString()
        {
            return _route;
        }
    }
}