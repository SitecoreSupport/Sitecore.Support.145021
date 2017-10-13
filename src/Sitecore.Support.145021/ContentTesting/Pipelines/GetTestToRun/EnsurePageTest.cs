using Sitecore.ContentTesting.Model;
using Sitecore.ContentTesting.Pipelines.GetTestToRun;

namespace Sitecore.Support.ContentTesting.Pipelines.GetTestToRun
{
    public class EnsurePageTest : GetTestToRunProcessor
    {
        public override void Process(GetTestToRunArgs args)
        {
            if ((args.TestDefinition != null) && ((args.TestDefinition.GetTestType() == TestType.Page)))
            {
                var contentItem = args.TestDefinition.ParseContentItem();
                if (contentItem.ItemID != args.HostItem.ID || contentItem.Language != args.HostItem.Language)
                {
                    args.TestDefinition = null;
                }
            }
        }
    }
}
