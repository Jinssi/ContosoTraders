using Profile = gravyTraders.Api.Core.Models.Implementations.Dao.Profile;

namespace gravyTraders.Api.Core.Services.Interfaces;

internal interface IProfileService
{
    IEnumerable<Profile> GetAllProfiles();

    Profile GetProfile(string email);
}