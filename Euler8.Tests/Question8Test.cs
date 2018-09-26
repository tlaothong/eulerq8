using System;
using Xunit;
using FluentAssertions;

namespace Euler8.Tests
{
    public class Question8Test
    {
        [Fact]
        public void ConvertNumStringsToIntArray()
        {
            var numbers = "12789";
            var expected = new[] { 1, 2, 7, 8, 9 };

            var sut = new Question8();
            var result = sut.ParseNumbers(numbers);
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Numbers1000IsValid()
        {
            var sut = new Question8();
            var n1000 = sut.Numbers1000;

            n1000.Should().HaveCount(1000).And.StartWith(new[] { 7, 3 })
                .And.EndWith(new[] { 5, 0 });
        }

        [Theory]
        [InlineData(0, 4, 0)]
        [InlineData(0, 10, 1)]
        [InlineData(6, 5, 2)]
        public void GetNumbersIsValid(int start, int count, int exi)
        {
            var sut = new Question8();
            var result = sut.GetNumbers(start, count);

            var expectedAll = new int[][] {
                new [] { 7, 3, 1, 6 },
                new [] { 7, 3, 1, 6, 7, 1, 7, 6, 5, 3 },
                new [] { 7, 6, 5, 3, 1 }
            };
            var expected = expectedAll[exi];
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ProductIsCorrect() {
            var sut = new Question8();
            var result = sut.CalcProduct(new [] { 2, 3, 7 });
            result.Should().Be(42);
        }

        [Fact]
        public void CheckQ8For4() {
            var sut = new Question8();
            var ans = sut.AnswerQuestion8(4);
            var expected = 5832;

            ans.Should().Be(expected);
        }
    }
}
