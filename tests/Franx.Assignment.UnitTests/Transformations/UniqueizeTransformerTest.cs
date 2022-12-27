using System;
using FluentAssertions;
using Franx.Assignment.Transformations;
using Xunit;

namespace Franx.Assignment.UnitTests.Transformations
{
	public class UniqueizeTransformerTest
	{
        private readonly UniqueizeTransformer transformer;

        public UniqueizeTransformerTest()
        {
            transformer = new UniqueizeTransformer();
        }

        [Fact]
        public void UniqueizeString_ShouldReturnUniqueWords_WhenSentenceIsProvided()
        {
            var inputSentence = "some words others words words words words words others others others";
            var expectedResult = "some words others";

            var result = transformer.TransformText(inputSentence);

            result.Should().NotBeEmpty();
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void UniqueizeString_ShouldReturnReversed_WhenSentenceIs_SingleWord()
        {
            var inputSentence = "some";
            var expectedResult = "some";

            var result = transformer.TransformText(inputSentence);

            result.Should().NotBeEmpty();
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void UniqueizeString_ShouldReturnEmpty_WhenInputIsEmpty()
        {
            var inputSentence = string.Empty;

            var result = transformer.TransformText(inputSentence);

            result.Should().BeEmpty();
            result.Should().Be(inputSentence);
        }
    }
}

