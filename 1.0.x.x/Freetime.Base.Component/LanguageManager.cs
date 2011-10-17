using Freetime.Base.Business.Implementable;
using Freetime.Base.Business;
using Freetime.Base.Data.Collection;

namespace Freetime.Base.Component
{
    public class LanguageManager : ILanguageManager
    {

        #region Instance
        private static ILanguageManager s_instance;

        public static ILanguageManager Current
        {
            get 
            {
                s_instance = s_instance ?? new LanguageManager();
                return s_instance;
            }
        }

        public static void SetLanguageManager(ILanguageManager manager)
        {
            s_instance = manager;
        }
        #endregion

        private LanguageList m_languageList;

        private ILocalizationLogic m_localizationLogic;

        private ILocalizationLogic CurrentLogic
        {
            get
            {
                m_localizationLogic = m_localizationLogic ?? new LocalizationLogic();
                return m_localizationLogic;
            }
        }

        internal LanguageManager()
        {
            m_languageList = CurrentLogic.GetAllLanguage();    
        }

        public LanguageList Languages 
        { 
            get
            {
                return m_languageList;
            }
        }

        public string GetStringResource(string languageCode, string key)
        {
            return string.Empty;
        }
    }
}
