///////////////////////////////////////////////////////////////////////////
//           Liquid XML Objects GENERATED CODE - DO NOT MODIFY           //
//            https://www.liquid-technologies.com/xml-objects            //
//=======================================================================//
// Dependencies                                                          //
//     Nuget : LiquidTechnologies.XmlObjects.Runtime                     //
//           : MUST BE VERSION 21.1.0                                    //
//=======================================================================//
// Online Help                                                           //
//     https://www.liquid-technologies.com/xml-objects-quick-start-guide //
//=======================================================================//
// Licensing Information                                                 //
//     https://www.liquid-technologies.com/eula                          //
///////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Numerics;
using LiquidTechnologies.XmlObjects;
using LiquidTechnologies.XmlObjects.Attribution;

// ------------------------------------------------------
// |                      Settings                      |
// ------------------------------------------------------
// GenerateCommonBaseClass                  = False
// GenerateUnprocessedNodeHandlers          = False
// RaiseChangeEvents                        = False
// CollectionNaming                         = Pluralize
// Language                                 = CS
// OutputNamespace                          = QuickStartCs
// WriteDefaultValuesForOptionalAttributes  = False
// WriteDefaultValuesForOptionalElements    = False
// MixedContentHandling                     = TreatAsAny
// GenerationModel                          = Simple
//                                            *WARNING* this simplified model that is very easy to work with
//                                            but may cause the XML to be produced without regard for element
//                                            cardinality or order. Where very high compliance with the XML Schema
//                                            standard is required use GenerationModelType.Conformant
// XSD Schema Files
//    D:\Development21\Liquid\Applications\XmlDataBinder\Documentation\xml-objects\examples\QuickStart\Bookstore.xsd


namespace QuickStartCs
{
    #region Global Settings
    /// <summary>Contains library level properties, and ensures the version of the runtime used matches the version used to generate it.</summary>
    [LxRuntimeRequirements("21.1.0.14151")]
    public partial class LxRuntimeRequirementsWritten
    {
    }

    #endregion

}

namespace QuickStartCs.Bs
{
    #region Enumerations
    /// <summary>An enumeration representing XSD simple type GenreType@http://www.liquid-technologies.com/sample/bookstore</summary>
    /// <XsdPath>schema:Bookstore.xsd/simpleType:GenreType</XsdPath>
    /// <XsdFile>D:\Development21\Liquid\Applications\XmlDataBinder\Documentation\xml-objects\examples\QuickStart\Bookstore.xsd</XsdFile>
    /// <XsdLocation>57:3-64:20</XsdLocation>
    [LxSimpleTypeDefinition("GenreType", "http://www.liquid-technologies.com/sample/bookstore")]
    public enum GenreTypeEnum
    {
        /// <summary>Represents the value 'Horror' in the XML</summary>
        [LxEnumValue("Horror")]
        Horror,
        /// <summary>Represents the value 'Reference' in the XML</summary>
        [LxEnumValue("Reference")]
        Reference,
        /// <summary>Represents the value 'Scifi' in the XML</summary>
        [LxEnumValue("Scifi")]
        Scifi,
        /// <summary>Represents the value 'Fiction' in the XML</summary>
        [LxEnumValue("Fiction")]
        Fiction,
    }
    #endregion

    #region Complex Types
    /// <summary>A class representing the root XSD complexType authorNameType@http://www.liquid-technologies.com/sample/bookstore</summary>
    /// <XsdPath>schema:Bookstore.xsd/complexType:authorNameType</XsdPath>
    /// <XsdFile>D:\Development21\Liquid\Applications\XmlDataBinder\Documentation\xml-objects\examples\QuickStart\Bookstore.xsd</XsdFile>
    /// <XsdLocation>44:3-56:21</XsdLocation>
    [LxSimpleComplexTypeDefinition("authorNameType", "http://www.liquid-technologies.com/sample/bookstore")]
    public partial class AuthorNameTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>
        ///   The authors first name.<br/>
        ///   Max 50 characters.
        /// </remarks>
        [LxElementValue(0, "first-name", "http://www.liquid-technologies.com/sample/bookstore", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String First_Name { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue(1, "last-name", "http://www.liquid-technologies.com/sample/bookstore", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String Last_Name { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType bookstoreType@http://www.liquid-technologies.com/sample/bookstore</summary>
    /// <XsdPath>schema:Bookstore.xsd/complexType:bookstoreType</XsdPath>
    /// <XsdFile>D:\Development21\Liquid\Applications\XmlDataBinder\Documentation\xml-objects\examples\QuickStart\Bookstore.xsd</XsdFile>
    /// <XsdLocation>10:3-16:21</XsdLocation>
    [LxSimpleComplexTypeDefinition("bookstoreType", "http://www.liquid-technologies.com/sample/bookstore")]
    public partial class BookstoreTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="QuickStartCs.Bs.BookTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="QuickStartCs.Bs.BookTypeCt" />
        /// </summary>
        [LxElementCt(0, "book", "http://www.liquid-technologies.com/sample/bookstore", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<QuickStartCs.Bs.BookTypeCt> Books { get; } = new List<QuickStartCs.Bs.BookTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType bookType@http://www.liquid-technologies.com/sample/bookstore</summary>
    /// <XsdPath>schema:Bookstore.xsd/complexType:bookType</XsdPath>
    /// <XsdFile>D:\Development21\Liquid\Applications\XmlDataBinder\Documentation\xml-objects\examples\QuickStart\Bookstore.xsd</XsdFile>
    /// <XsdLocation>17:3-43:21</XsdLocation>
    [LxSimpleComplexTypeDefinition("bookType", "http://www.liquid-technologies.com/sample/bookstore")]
    public partial class BookTypeCt
    {
        /// <summary>The value for the attribute price</summary>
        /// <XsdPath>schema:Bookstore.xsd/complexType:bookType/attribute:price</XsdPath>
        /// <XsdFile>D:\Development21\Liquid\Applications\XmlDataBinder\Documentation\xml-objects\examples\QuickStart\Bookstore.xsd</XsdFile>
        /// <XsdLocation>36:5-38:37</XsdLocation>
        [LxAttribute("price", "", LxValueType.Value, XsdType.XsdDecimal, Required = true)]
        public LiquidTechnologies.XmlObjects.BigDecimal Price { get; set; }

        /// <summary>The value for the optional attribute publicationdate</summary>
        /// <XsdPath>schema:Bookstore.xsd/complexType:bookType/attribute:publicationdate</XsdPath>
        /// <XsdFile>D:\Development21\Liquid\Applications\XmlDataBinder\Documentation\xml-objects\examples\QuickStart\Bookstore.xsd</XsdFile>
        /// <XsdLocation>39:5-40:38</XsdLocation>
        [LxAttribute("publicationdate", "", LxValueType.Value, XsdType.XsdDate)]
        public LiquidTechnologies.XmlObjects.LxDateTime? Publicationdate { get; set; }

        /// <summary>The value for the optional attribute ISBN</summary>
        /// <XsdPath>schema:Bookstore.xsd/complexType:bookType/attribute:ISBN</XsdPath>
        /// <XsdFile>D:\Development21\Liquid\Applications\XmlDataBinder\Documentation\xml-objects\examples\QuickStart\Bookstore.xsd</XsdFile>
        /// <XsdLocation>41:5-42:40</XsdLocation>
        [LxAttribute("ISBN", "", LxValueType.Value, XsdType.XsdString)]
        public System.String ISBN { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>
        ///   The title of the book. <br/>
        ///   Max 50 characters.
        /// </remarks>
        [LxElementValue(3, "title", "http://www.liquid-technologies.com/sample/bookstore", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MaxLength = "50")]
        public System.String Title { get; set; } = "";

        /// <summary>
        ///   A class derived from <see cref="QuickStartCs.Bs.AuthorNameTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="QuickStartCs.Bs.AuthorNameTypeCt" />
        /// </summary>
        [LxElementCt(4, "author", "http://www.liquid-technologies.com/sample/bookstore", MinOccurs = 1, MaxOccurs = 1)]
        public QuickStartCs.Bs.AuthorNameTypeCt Author { get; set; } = new QuickStartCs.Bs.AuthorNameTypeCt();

        /// <summary>A nullable <see cref="QuickStartCs.Bs.GenreTypeEnum" />, Optional : null when not set</summary>
        [LxElementValue(5, "genre", "http://www.liquid-technologies.com/sample/bookstore", LxValueType.Enum, XsdType.Enum, MinOccurs = 0, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Preserve)]
        public QuickStartCs.Bs.GenreTypeEnum? Genre { get; set; }

    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element bookstore@http://www.liquid-technologies.com/sample/bookstore</summary>
    /// <XsdPath>schema:Bookstore.xsd/element:bookstore</XsdPath>
    /// <XsdFile>D:\Development21\Liquid\Applications\XmlDataBinder\Documentation\xml-objects\examples\QuickStart\Bookstore.xsd</XsdFile>
    /// <XsdLocation>8:3-9:42</XsdLocation>
    [LxSimpleElementDefinition("bookstore", "http://www.liquid-technologies.com/sample/bookstore", ElementScopeType.GlobalElement)]
    public partial class BookstoreElm : QuickStartCs.Bs.BookstoreTypeCt
    {
    }

    #endregion

}

namespace QuickStartCs.Xsd
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType anyType@http://www.w3.org/2001/XMLSchema</summary>
    /// <XsdPath>schema:.../www.w3.org/2001/XMLSchema/complexType:anyType</XsdPath>
    /// <XsdFile>http://www.w3.org/2001/XMLSchema</XsdFile>
    /// <XsdLocation>Empty</XsdLocation>
    [LxSimpleComplexTypeDefinition("anyType", "http://www.w3.org/2001/XMLSchema")]
    public partial class AnyTypeCt : XElement
    {
        /// <summary>Constructor : create a <see cref="AnyTypeCt" /> element &lt;anyType xmlns='http://www.w3.org/2001/XMLSchema'&gt;</summary>
        public AnyTypeCt()  : base(XName.Get("anyType", "http://www.w3.org/2001/XMLSchema")) { }

    }

    #endregion

}

namespace QuickStartCs
{
    /// <summary>
    /// Provides a validator based on the original XSD schema files. 
    /// </summary>
    public partial class BookstoreValidator : LiquidTechnologies.XmlObjects.XsdValidator
    {
        /// <summary>
        /// Initializes the validator, loads and compiles the XSD schemas.
        /// </summary>
        /// <remarks>
        /// This is an expensive operation so consider caching this object.
        /// </remarks>
        public BookstoreValidator()
            : base(typeof(BookstoreValidator).Assembly, "QuickStartCs.BookstoreResources.SchemaData")
        {
        }
    }
}
