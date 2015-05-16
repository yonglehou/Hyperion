using System;
using System.Collections;
using System.Collections.Generic;

namespace Hyperion.Http.Routing
{
    public class RoutePath : IEnumerable<Route>
    {
        internal readonly Route[] Routes;

        /// <exception cref="RouteParsingException">Thrown when provided route could not be parsed.</exception>
        public static RoutePath Parse(string path)
        {
            RoutePath routePath;
            if (TryParse(path, out routePath))
            {
                return routePath;
            }

            throw new RouteParsingException("Couldn't parse provided route: " + path);
        }

        /// <summary>
        /// Tries to parse provided string into <see cref="RoutePath"/>.
        /// </summary>
        /// <exception cref="ArgumentException">Route path is not provided</exception>
        public static bool TryParse(string path, out RoutePath routePath)
        {
            Route[] routes;
            var succeeded = TryParseInternal(path, out routes);

            routePath = succeeded ? new RoutePath(routes) : null;
            return succeeded;
        }

        private static bool TryParseInternal(string path, out Route[] routes)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentException("Route path is not provided", "path");

            throw new NotImplementedException();
        }

        /// <summary>
        /// Concatenates two route paths returning new route path as a result.
        /// </summary>
        public static RoutePath operator /(RoutePath left, RoutePath right)
        {
            if (left == null) throw new ArgumentNullException("left", "RoutePath concat - left route path is null");
            if (right == null) throw new ArgumentNullException("right", "RoutePath concat - right route path is null");

            return left.Concat(right);
        }

        /// <summary>
        /// Concatenates two route paths returning new route path as a result.
        /// </summary>
        public static RoutePath operator /(RoutePath left, string right)
        {
            var parsed = Parse(right);
            return left / parsed;
        }

        /// <summary>
        /// Concatenates two route paths returning new route path as a result.
        /// </summary>
        public static RoutePath operator /(string left, RoutePath right)
        {
            var parsed = Parse(left);
            return parsed / right;
        }

        public RoutePath(params Route[] routes)
        {
            Routes = routes;
        }

        /// <summary>
        /// Concatenates two route paths returning new route path as a result.
        /// </summary>
        public RoutePath Concat(RoutePath other)
        {
            var dest = new Route[Routes.Length + other.Routes.Length];

            Array.Copy(Routes, dest, Routes.Length);
            Array.Copy(other.Routes, 0, dest, Routes.Length, other.Routes.Length);

            return new RoutePath(dest);
        }

        public IEnumerator<Route> GetEnumerator()
        {
            return ((IEnumerable<Route>)Routes).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}