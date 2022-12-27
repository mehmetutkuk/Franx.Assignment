using Franx.Assignment.Models;

namespace Franx.Assignment.Services
{
    public interface ITextService
    {
        string TransformText(TransformationType transformation, string sentence);
    }
}
