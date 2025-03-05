using Soenneker.Tags.Util.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Tags.Util.Tests;

[Collection("Collection")]
public class TagsUtilTests : FixturedUnitTest
{
    private readonly ITagsUtil _util;

    public TagsUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<ITagsUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
