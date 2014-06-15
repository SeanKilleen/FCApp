namespace FCApp.Core.Tests
{
    using FluentAssertions;

    using Xunit;

    public class SuppliedHashFunctionTests
    {
        [Fact]
        public void TheyDidntLie_ItReturnsTheExpectedResult()
        {
            SuppliedHashFunction.Hash("leepadg").Should().Be(680131659347);
        }
    }
}
