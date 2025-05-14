using Volo.Abp.Application.Services;
using TrackIT.Localization;

namespace TrackIT.Services;

/* Inherit your application services from this class. */
public abstract class TrackITAppService : ApplicationService
{
    protected TrackITAppService()
    {
        LocalizationResource = typeof(TrackITResource);
    }
}