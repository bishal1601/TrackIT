using Volo.Abp.Domain.Entities.Auditing;

namespace TrackIT.Entities;

public class Unit : FullAuditedEntity<Guid>
{
    public string Name { get; set; }
    public string Symbol { get; set; }
    public bool IsActive { get; set; } = true;
}