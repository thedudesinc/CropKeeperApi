using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Persistance.Entities;

public class GardenPlot : IEntity
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string FabricJson { get; set; } = string.Empty;

    public string PlotName { get; set; } = string.Empty;

    public int HardinessZone { get; set; }

    public DateTime LastFrostDate { get; set; }

    public string ZipCode { get; set; } = string.Empty;

    public string? Notes { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}

