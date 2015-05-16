using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hyperion.Core
{
    public static class Tasks
    {
        /// <summary>
        /// Set a timeout for provided task, within which task must complete.
        /// </summary>
        public static async Task<T> Within<T>(this Task<T> task, TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns task, which is immediatelly completed.
        /// </summary>
        public static Task<T> Done<T>()
        {
            return Task.FromResult(default(T));
        }
    }
}