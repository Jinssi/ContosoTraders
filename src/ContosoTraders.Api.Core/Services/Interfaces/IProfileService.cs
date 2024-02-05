using Profile = GravyTraders.Api.Core.Models.Implementations.Dao.Profile;

namespace GravyTraders.Api.Core.Services.Interfaces;

internal interface IProfileService
{
    IEnumerable<Profile> GetAllProfiles();

    Profile GetProfile(string email);
}