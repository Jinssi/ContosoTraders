namespace GravyTraders.Api.Core.Services;

internal abstract class GravyTradersServiceBase
{
    protected readonly IConfiguration Configuration;

    protected readonly ILogger<GravyTradersServiceBase> Logger;

    protected readonly IMapper Mapper;

    protected GravyTradersServiceBase(IMapper mapper, IConfiguration configuration, ILogger<GravyTradersServiceBase> logger)
    {
        Mapper = mapper;
        Configuration = configuration;
        Logger = logger;
    }
}