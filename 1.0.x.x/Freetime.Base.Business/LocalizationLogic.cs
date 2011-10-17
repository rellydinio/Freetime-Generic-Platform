using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Freetime.Base.Business.Implementable;
using Freetime.Base.Data;
using Freetime.Base.Data.Contracts;
using Freetime.Base.Data.Entities;
using Freetime.Base.Data.Collection;

namespace Freetime.Base.Business
{
    public class LocalizationLogic : BaseLogic<ILocalizationSession>, ILocalizationLogic
    {

        protected override ILocalizationSession DefaultSession
        {
            get { return new LocalizationSession(); }
        }

        public Language GetLanguage(string languageCode)
        {
            return CurrentSession.GetLanguage(languageCode);
        }


        public LanguageList GetAllLanguage()
        {
            return CurrentSession.GetAllLanguage();
        }

        public void SaveLanguage(Language language)
        {
            CurrentSession.SaveLanguage(language);
        }

        public void DeleteLanguage(Language language)
        {
            CurrentSession.DeleteLanguage(language);
        }

        public void DeleteLanguage(string languageCode)
        {
            CurrentSession.DeleteLanguage(languageCode);
        }

        public Language NewLanguage()
        {
            return new Language();            
        }

        public Language NewLanguage(string languageCode)
        {
            if (Equals(languageCode, null))
                throw new ArgumentNullException("languageCode");

            var language = NewLanguage();
            language.LanguageCode = languageCode;
            return language;
        }


    }
}
