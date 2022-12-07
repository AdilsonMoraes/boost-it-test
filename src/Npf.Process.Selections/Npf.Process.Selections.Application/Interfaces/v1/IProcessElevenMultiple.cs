using Npf.Process.Selections.Domain.Request.v1;
using Npf.Process.Selections.Domain.Response.v1;

namespace Npf.Process.Selections.Application.Interfaces.v1
{
    public interface IProcessElevenMultiple
    {
        Task<Response> GetElevenMultiple(Request numbers);

    }
}
