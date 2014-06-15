using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCApp.Core.Tests
{
    using FluentAssertions;

    using Xunit;

    public class HashStringRevealerTests
    {
        [Fact]
        public void GivenInitialFCExample_ProducesSameResult()
        {
            HashStringRevealer.RevealHashString(680131659347).Should().Be("leepadg");
        }
    }
}
