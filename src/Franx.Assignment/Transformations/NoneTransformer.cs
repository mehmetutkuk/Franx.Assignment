using System;
using Franx.Assignment.Models;
using Franx.Assignment.Services;

namespace Franx.Assignment.Transformations
{
	public class NoneTransformer : ITextTransformation
    {
        public string TransformText(string text) => text;
        public TransformationType TransformationType => TransformationType.None;

    }
}

