using System;
using Freetime.Base.Data.Contracts;
using Freetime.Base.Data.Entities;
using Freetime.Base.Data.Collection;

namespace Freetime.Base.Data
{
    public class LocalizationSession : DataSession, ILocalizationSession
    {
        public Language GetLanguage(string languageCode)
        {
            if (Equals(languageCode, null))
                throw new ArgumentNullException("languageCode");

            return CurrentSession.GetT<Language>(l => l.LanguageCode == languageCode);
        }

        public LanguageList GetAllLanguage()
        {
            return CurrentSession.GetList<LanguageList, Language>();
        }

        public void SaveLanguage(Language language)
        {            
            if (Equals(language, null))
                throw new ArgumentNullException("language");

            CurrentSession.Save(language);
        }


        public void DeleteLanguage(Language language)
        {
            if (Equals(language, null))
                throw new ArgumentNullException("language");

            CurrentSession.Delete<Language>(language);
        }

        public void DeleteLanguage(string languageCode)
        {
            if (Equals(languageCode, null))
                throw new ArgumentNullException("languageCode");

            CurrentSession.Delete<Language>(l => l.LanguageCode == languageCode);
        }


    }
}
