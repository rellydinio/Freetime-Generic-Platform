using System;
using System.ServiceModel;
using Freetime.Base.Data.Entities;
using Freetime.Base.Data.Collection;

namespace Freetime.Base.Data.Contracts
{
    [ServiceContract]
    public interface ILocalizationSession : IDataSession
    {
        [OperationContract]
        Language GetLanguage(string languageCode);
        LanguageList GetAllLanguage();
        [OperationContract]
        void SaveLanguage(Language language);
        [OperationContract]
        void DeleteLanguage(Language language);
        [OperationContract]
        void DeleteLanguage(string languageCode);
    }
}
