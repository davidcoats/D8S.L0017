using System;
using System.Xml;

using R5T.T0131;


namespace D8S.L0017.L000
{
    [ValuesMarker]
    public partial interface IXmlWriterSettings : IValuesMarker
    {
        /// <summary>
        /// An instance containing the default settings, fresh out of the parameterless constructor.
        /// </summary>
        /// <remarks>
        /// This is a worry these settings might change over time with .NET version.
        /// But that worry is ignored for now.
        /// </remarks>
        System.Xml.XmlWriterSettings Default => new System.Xml.XmlWriterSettings();
    }
}
