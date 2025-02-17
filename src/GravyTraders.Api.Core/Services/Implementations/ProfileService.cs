﻿using Profile = gravyTraders.Api.Core.Models.Implementations.Dao.Profile;

namespace gravyTraders.Api.Core.Services.Implementations;

internal class ProfileService : gravyTradersServiceBase, IProfileService
{
    private readonly ProfilesDbContext _profileRepository;

    public ProfileService(ProfilesDbContext profileRepository, IMapper mapper, IConfiguration configuration, ILogger<ProfileService> logger) : base(mapper, configuration, logger)
    {
        _profileRepository = profileRepository;
    }

    public IEnumerable<Profile> GetAllProfiles()
    {
        return _profileRepository.Profiles.ToList();
    }

    public Profile GetProfile(string email)
    {
        var profile = _profileRepository.Profiles.SingleOrDefault(profile => profile.Email == email);

        if (profile is null) throw new ProfileNotFoundException(email);

        return profile;
    }
}