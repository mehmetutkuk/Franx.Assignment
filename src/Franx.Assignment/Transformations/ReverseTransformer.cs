using System;
using Franx.Assignment.Models;
using System.Collections.Generic;
using Franx.Assignment.Services;

namespace Franx.Assignment.Transformations
{
	public class ReverseTransformer : ITextTransformation
    {
        public string TransformText(string text)
        {
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>(words);
            return string.Join(" ", stack);
        }
        public TransformationType TransformationType => TransformationType.Reverse;
    }
}

