using System.Threading.Tasks;

namespace Hyperion.Core
{
    public delegate Task<TRep> Service<in TReq, TRep>(TReq request);

    public delegate Service<TReq, TRep> ServiceFactory<in TReq, TRep>();
}