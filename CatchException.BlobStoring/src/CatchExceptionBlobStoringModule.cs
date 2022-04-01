using Volo.Abp.BlobStoring;
using Volo.Abp.Modularity;

namespace CatchException.BlobStoring;

[DependsOn(typeof(AbpBlobStoringModule))]
public class CatchExceptionBlobStoringModule : AbpModule
{

}