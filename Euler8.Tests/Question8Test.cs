using System;
using Xunit;
using FluentAssertions;

namespace Euler8.Tests
{
    public class Question8Test
    {
        [Fact]
        public void ConvertNumStringsToIntArray() {
            var numbers = "12789";
            var expected = new[] {1, 2, 7, 8, 9};

            var sut = new Question8();
            var result = sut.ParseNumbers(numbers);
            result.Should().BeEquivalentTo(expected);
        }
    }
}
