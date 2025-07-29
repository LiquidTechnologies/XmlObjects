# XML Objects


## What is Liquid XML Objects?

Liquid XML Objects is a [XML Data Binding](https://www.liquid-technologies.com/xml-objects) tool written by [Liquid Technologies](https://www.liquid-technologies.com/) that enables you to load XML Documents into a strongly typed object model within your C# or Visual Basic .Net source code.

Meaning fewer coding errors, reduced development and testing time, and an increase in schema conformance and coding reliability.

Liquid XML Objects Features

- Fully Integrated as a Microsoft Visual Studio extension.
- Generates an easy to use class library for C# and Visual Basic .Net.
- Replace xsd.exe with better XSD 1.0 support and adds support for XSD 1.1.
- Generate simple light weight classes which follow the structure of the XML.
- Supports .Net Core, .Net Standard and .Net Framework
- Supports W3C XML Schema for XSD 1.0 and XSD 1.1 standards.
- Supports SchemaSets containing multiple schemas and namespaces.
- Support for the most complex XML standards.
- Royalty free distribution of compiled code and runtime.

## Whats in this repository?

The repository contain examples showing how to the code generated using Liquid XML Objects.

You can run the examples on there own, but if you want to generate code from your own XML schemas then you will need to [Download Liquid Studio](https://www.liquid-technologies.com/trial-download).

- Examples\
    - Bookstore.xsd - The XML Schema the samples are based on
    - BookstoreSample1.xml - An XML document compliant with Bookstore.xsd
    - QuickStartCs\ - A C# XML Objects project generated from the Bookstore.xsd
    - ConsoleAppCs\ - A C# project that uses the QuickStartCs project to read/write/edit/validate an XML document using the generated library.
