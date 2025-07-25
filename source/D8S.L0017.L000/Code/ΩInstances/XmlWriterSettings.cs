using System;


namespace D8S.L0017.L000
{
    public class XmlWriterSettings : IXmlWriterSettings
    {
        #region Infrastructure

        public static IXmlWriterSettings Instance { get; } = new XmlWriterSettings();


        private XmlWriterSettings()
        {
        }

        #endregion
    }
}
