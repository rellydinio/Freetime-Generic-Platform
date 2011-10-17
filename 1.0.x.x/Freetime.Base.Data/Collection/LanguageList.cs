using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Freetime.Base.Data.Collection
{
    [Serializable]
    [DataContract]
    [XmlRoot("Language", Namespace = "http://www.freetime-generic.com", IsNullable = true)]
    public class LanguageList : List<Entities.Language>
    {
    }
}
