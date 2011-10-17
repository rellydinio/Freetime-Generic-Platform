using Freetime.Base.Data.Collection;

namespace Freetime.Base.Component
{
    public interface ILanguageManager
    {
        LanguageList Languages { get; }

        string GetStringResource(string languageCode, string key);
    }
}
