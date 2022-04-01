using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace CatchException.BlobStoring;

public class DefaultBlobUrlCalculator : IBlobUrlCalculator, ITransientDependency
{
    protected ICurrentTenant CurrentTenant { get; }

    public DefaultBlobUrlCalculator(ICurrentTenant currentTenant)
    {
        CurrentTenant = currentTenant;
    }

    public virtual string Calculate(string fileName)
    {
        return CurrentTenant.Id == null
            ? $"host/{fileName}"
            : $"tenants/{CurrentTenant.Id.Value:D}/{fileName}";
    }
}