using Microsoft.Extensions.Localization;
using TrackIT.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TrackIT;

[Dependency(ReplaceServices = true)]
public class TrackITBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TrackITResource> _localizer;

    public TrackITBrandingProvider(IStringLocalizer<TrackITResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}