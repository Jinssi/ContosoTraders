namespace gravyTraders.Api.Core.Services;

internal abstract class gravyTradersServiceBase
{
    protected readonly IConfiguration Configuration;

    protected readonly ILogger<gravyTradersServiceBase> Logger;

    protected readonly IMapper Mapper;

    protected gravyTradersServiceBase(IMapper mapper, IConfiguration configuration, ILogger<gravyTradersServiceBase> logger)
    {
        Mapper = mapper;
        Configuration = configuration;
        Logger = logger;
    }
}