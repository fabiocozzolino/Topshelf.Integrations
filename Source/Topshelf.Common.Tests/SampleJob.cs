using System.Threading.Tasks;
using Quartz;

namespace Topshelf.Common.Tests
{
    public class SampleJob : IJob
    {
        public static bool HasRun = false;

        protected SampleDependency Dependency;

        public SampleJob()
        {
            Dependency = new SampleDependency();
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Run(() =>
            {
                Dependency.DoWork();
                HasRun = true;
            });
        }
    }

    public class SampleNinjectJob : SampleJob
    {
        public SampleNinjectJob(SampleDependency dependency)
        {
            Dependency = dependency;
        }
    }
}