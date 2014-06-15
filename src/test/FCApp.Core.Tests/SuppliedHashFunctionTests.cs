using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
