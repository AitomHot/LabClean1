using LabClean1.Application.Common.Interfaces;

namespace LabClean1.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
