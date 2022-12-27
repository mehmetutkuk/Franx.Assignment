using System;
using Franx.Assignment.Models;
using System.Collections.Generic;
using Franx.Assignment.Services;

namespace Franx.Assignment.Transformations
{
	public class UniqueizeTransformer : ITextTransformation
    {
        public string TransformText(string text)
        {
            var wordSet = new HashSet<string>(text.Split(' ', StringSplitOptions.RemoveEmptyEntries));
            return string.Join(" ", wordSet);
        }
        public TransformationType TransformationType => TransformationType.Deduplicate;
    }
}

