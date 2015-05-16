using System;
using System.Threading.Tasks;

namespace Hyperion.Core
{
    public interface IServerListener : IDisposable
    {
        bool IsOpen { get; }
        Task Close(TimeSpan timeout);
    }

    /// <summary>
    /// Interface for RPC servers implementing <typeparamref name="TReq"/> requests and returning <typeparamref name="TRep"/> replies.
    /// </summary>
    public interface IServer<out TReq, TRep>
    {
        IServerListener Serve(string address, ServiceFactory<TReq, TRep> factory);
    }

    /// <summary>
    /// RPC-style client with<typeparamref name="TReq"/> type requests and <typeparamref name="TRep"/> type responses.
    /// Each destination is represented by name.
    /// </summary>
    public interface IClient<in TReq, TRep>
    {
        Service<TReq, TRep> Service(string destination);
        ServiceFactory<TReq, TRep> Client(string destination);
    }
}