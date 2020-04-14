using System.Threading.Tasks;
using Abp.Application.Services;
using Solution.Authorization.Accounts.Dto;

namespace Solution.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
