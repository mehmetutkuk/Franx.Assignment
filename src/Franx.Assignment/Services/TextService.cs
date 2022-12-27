using System;
using System.Collections.Generic;
using System.Linq;
using Franx.Assignment.Models;

namespace Franx.Assignment.Services
{
    public class TextService : ITextService
    {

        private readonly IEnumerable<ITextTransformation> _textTransformers;

        public TextService(IEnumerable<ITextTransformation> textTransformers)
        {
            _textTransformers = textTransformers;
        }

        public string TransformText(TransformationType type, string text)
        {
            if (_textTransformers.All(transformer => transformer.TransformationType != type))
            {
                throw new Exception("Unsupported Type");
            }

            return _textTransformers.First(textTransformer => textTransformer.TransformationType == type)
                .TransformText(text);

        }
    }
}