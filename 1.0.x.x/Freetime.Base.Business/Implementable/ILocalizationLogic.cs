using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Freetime.Base.Data.Entities;
using Freetime.Base.Data.Collection;

namespace Freetime.Base.Business.Implementable
{
    public interface ILocalizationLogic : ILogic
    {
        Language GetLanguage(string languageCode);
        LanguageList GetAllLanguage();
        void SaveLanguage(Language language);
        void DeleteLanguage(Language language);
        void DeleteLanguage(string languageCode);
        Language NewLanguage();
        Language NewLanguage(string languageCode);
    }
}
