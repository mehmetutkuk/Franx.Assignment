using System;
using Franx.Assignment.Models;
using Franx.Assignment.Services;
using Franx.Assignment.Transformations;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace Franx.Assignment.UnitTests.Services
{
    public class TextServiceTests
    {
        private readonly TextService textService;


        private readonly ITextTransformation _noneTextTransformer = new NoneTransformer();
        private readonly ITextTransformation _uniqueizeTextTransformer = new UniqueizeTransformer();
        private readonly ITextTransformation _reverseTextTransformer = new ReverseTransformer();


        public TextServiceTests()
        {
            textService = new TextService(new List<ITextTransformation>
                {
                    _noneTextTransformer,
                    _uniqueizeTextTransformer,
                    _reverseTextTransformer
                });
        }

        [Fact]
        public void Reverse_Test_With_Regular_Example_Return_True()
        {
            var reverseTransformer = new ReverseTransformer();

            var result = reverseTransformer.TransformText("some word other");


            Assert.Equal("other word some", result);

        }



        [Fact]
        public void ReverseString_ShouldReturnReversedString_WhenTransformationIsReverse()
        {
            var inputSentence = "all your base are belong to us";
            var expectedResult = "us to belong are base your all";

            var result = textService.TransformText(TransformationType.Reverse, inputSentence);

            result.Should().NotBeEmpty();
            result.Should().BeOfType<string>();
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void UniqueizeString_ShouldReturnUniqueWordsString_WhenTransformationIsDuplicate()
        {
            var inputSentence = "some word some other";
            var expectedResult = "some word other";

            var result = textService.TransformText(TransformationType.Deduplicate, inputSentence);

            result.Should().NotBeEmpty();
            result.Should().BeOfType<string>();
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void NoneStringTransformation_ShouldReturnSameString_WhenTransformationIsNone()
        {
            var inputSentence = "some word some other";

            var result = textService.TransformText(TransformationType.None, inputSentence);

            result.Should().NotBeEmpty();
            result.Should().BeOfType<string>();
            result.Should().Be(inputSentence);
        }
    }
}
