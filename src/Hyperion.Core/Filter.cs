using System.Threading.Tasks;

namespace Hyperion.Core
{
    public delegate Task<TOut> Filter<in TIn, TOut, out TReq, TRep>(TIn request, Service<TReq, TRep> service);

    public static class FilterExtensions
    {
        /// <summary>
        /// Combines two filters into one.
        /// </summary>
        public static Filter<TIn, TOut, TReq2, TRep2> Pipe<TIn, TOut, TReq1, TRep1, TReq2, TRep2>(this Filter<TIn, TOut, TReq1, TRep1> self, Filter<TReq1, TRep1, TReq2, TRep2> next)
        {
            return (request, service) => self(request, req => next(req, service));
        }

        /// <summary>
        /// Applies filter behavior to a service, returning service with combined behavior.
        /// </summary>
        public static Service<TReqIn, TRepOut> ApplyTo<TReqIn, TRepOut, TReqOut, TRepIn>(this Filter<TReqIn, TRepOut, TReqOut, TRepIn> filter, Service<TReqOut, TRepIn> service)
        {
            return request => filter(request, service);
        }
    }
}