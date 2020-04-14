using System.Threading.Tasks;
using Abp.Application.Services;
using Solution.Sessions.Dto;

namespace Solution.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
