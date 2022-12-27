using System;
using FluentAssertions;
using Franx.Assignment.Transformations;
using Xunit;

namespace Franx.Assignment.UnitTests.Transformations
{
	public class ReverseTransformerTest
    {
		
        private readonly ReverseTransformer transformer;

        public ReverseTransformerTest()
        {
            transformer = new ReverseTransformer();
        }

        [Fact]
        public void ReverseString_ShouldReturnReversed_WhenSentenceIsProvided()
        {
            var inputSentence = "all your base are belong to us";
            var expectedResult = "us to belong are base your all";

            var result = transformer.TransformText(inputSentence);

            result.Should().NotBeEmpty();
            result.Should().Be(expectedResult);
        }


        [Fact]
        public void ReverseString_ShouldReturnReversed_WhenSentenceIs_SingleWord()
        {
            var inputSentence = "all";
            var expectedResult = "all";

            var result = transformer.TransformText(inputSentence);

            result.Should().NotBeEmpty();
            result.Should().Be(expectedResult);
        }



        [Fact]
        public void ReverseString_ShouldReturnEmpty_WhenInputIsEmpty()
        {
            var inputSentence = string.Empty;

            var result = transformer.TransformText(inputSentence);

            result.Should().BeEmpty();
            result.Should().Be(inputSentence);
        }
    }
}

