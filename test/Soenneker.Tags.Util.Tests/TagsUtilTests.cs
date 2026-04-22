using Soenneker.Tags.Util.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Tags.Util.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class TagsUtilTests : HostedUnitTest
{
    private readonly ITagsUtil _util;

    public TagsUtilTests(Host host) : base(host)
    {
        _util = Resolve<ITagsUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
