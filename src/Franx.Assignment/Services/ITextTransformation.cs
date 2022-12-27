using Franx.Assignment.Models;

namespace Franx.Assignment.Services
{

    public interface ITextTransformation
    {
        TransformationType TransformationType { get; }
        string TransformText(string sentence);
    }
}