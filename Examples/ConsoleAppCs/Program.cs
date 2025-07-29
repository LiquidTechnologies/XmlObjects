using LiquidTechnologies.XmlObjects;
using QuickStartCs;
using QuickStartCs.Bs;
using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace ConsoldeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example: Read sample Bookstore XML document into an Object Model
            BookstoreElm bookstore = ReadBookstore();

            // Example: Update the Bookstore objects
            UpdateBookstore(bookstore);

            // Example: Write the updated Bookstore to an XML string
            WriteBookstore(bookstore);

            // Example: Write the updated Bookstore to a JSON string
            string json = WriteBookstoreAsJson(bookstore);

            // Example: Read the updated Bookstore from a JSON string into an Object Model
            ReadBookstoreFromJson(json);

            // Example: Handling Errors using an Error Handler callback
            ErrorHandling();

            // Example: Handling Errors using an XSD Validator callback
            ValidatingReader();

            Console.ReadKey();
        }

        public static BookstoreElm ReadBookstore()
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("** Example: Read sample Bookstore XML document **\n");

            #region Read
            string sampleXml = @"<bs:bookstore xmlns:bs='http://www.liquid-technologies.com/sample/bookstore' >
                                    <bs:book price='23.99' publicationdate='2002-06-01' ISBN='0596002521'>
                                        <bs:title>XML Schema</bs:title>
                                        <bs:author>
                                            <bs:first-name>Eric</bs:first-name>
                                            <bs:last-name>van der Vlist</bs:last-name>
                                        </bs:author>
                                        <bs:genre>Reference</bs:genre>
                                    </bs:book>
                                </bs:bookstore>";

            LxSerializer<BookstoreElm> serializer = new LxSerializer<BookstoreElm>();
            BookstoreElm bookstore;

            using (StringReader reader = new StringReader(sampleXml))
            {
                bookstore = serializer.Deserialize(reader);
            }

            // Display details about the books
            foreach (var book in bookstore.Books)
                Console.WriteLine($"Book[{book.Genre}] : '{book.Title}' ('${book.Price}') by '{book.Author.First_Name} {book.Author.Last_Name}' published on '{book.Publicationdate}'");

            return bookstore;
            #endregion // Read
        }

        public static void UpdateBookstore(BookstoreElm bookstore)
        {
            Console.WriteLine("\n*****************************************");
            Console.WriteLine("** Example: Update the Bookstore objects.\n");

            #region Modify
            BookTypeCt book = new BookTypeCt();
            book.Price = 7.99;
            book.Publicationdate = LxDateTime.CreateDate(2001, 12, 07);
            book.ISBN = "9780130655677";
            book.Title = "Definitive XML Schema";
            book.Author.First_Name = "Priscilla";
            book.Author.Last_Name = "Walmsley";
            book.Genre = GenreTypeEnum.Reference;
            bookstore.Books.Add(book);
            #endregion // Modify
        }

        public static void WriteBookstore(BookstoreElm bookstore)
        {
            Console.WriteLine("\n*****************************************************************");
            Console.WriteLine("** Example: Write the updated Bookstore objects to an XML string:\n");

            #region Write
            LxSerializer<BookstoreElm> serializer = new LxSerializer<BookstoreElm>();

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, bookstore);
                Console.WriteLine(writer.ToString());
            }
            #endregion // Write
        }

        public static string WriteBookstoreAsJson(BookstoreElm bookstore)
        {
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("** Example: Write the Bookstore objects to a JSON string:\n");

            #region Write

            LjSerializer<BookstoreElm> serializer = new LjSerializer<BookstoreElm>();

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, bookstore);
                string json = writer.ToString();
                Console.WriteLine(json);
                return json;
            }

            #endregion // Write
        }

        public static void ReadBookstoreFromJson(string sampleJson)
        {
            Console.WriteLine("\n****************************************************");
            Console.WriteLine("** Example: Read sample Bookstore from a JSON string\n");

            #region Read

            LjSerializer<BookstoreElm> serializer = new LjSerializer<BookstoreElm>();
            BookstoreElm bookstore;

            using (StringReader reader = new StringReader(sampleJson))
            {
                bookstore = serializer.Deserialize(reader);
            }

            // Display details about the books
            foreach (var book in bookstore.Books)
                Console.WriteLine($"Book[{book.Genre}] : '{book.Title}' ('${book.Price}') by '{book.Author.First_Name} {book.Author.Last_Name}' published on '{book.Publicationdate}'");

            #endregion // Read
        }


        public static void ErrorHandling()
        {
            Console.WriteLine("\n************************************************************");
            Console.WriteLine("** Example: Handling Errors using an Error Handler callback:\n");

            #region Error Handling
            // Note : No last-name in author
            string sampleXml = @"<bs:bookstore xmlns:bs='http://www.liquid-technologies.com/sample/bookstore' >
                                    <bs:book price='23.99' publicationdate='2002-06-01' ISBN='0596002521'>
                                        <bs:title>XML Schema</bs:title>
                                        <bs:author>
                                            <bs:first-name>Eric</bs:first-name>
                                        </bs:author>
                                        <bs:genre>Reference</bs:genre>
                                    </bs:book>
                                </bs:bookstore>";

            LxSerializer<BookstoreElm> serializer = new LxSerializer<BookstoreElm>();
            LxReaderSettings settings = new LxReaderSettings();
            settings.ErrorHandler = MyDeserializerErrorHandler;
            BookstoreElm bookstore;

            using (StringReader reader = new StringReader(sampleXml))
            {
                bookstore = serializer.Deserialize(reader, settings);
            }
            #endregion // Error Handling
        }

        #region Error Handler
        private static void MyDeserializerErrorHandler(string msg, LxErrorSeverity severity, LxErrorCode errorCode, TextLocation location, object targetObject)
        {
            Console.WriteLine($"{severity}:{errorCode}:{location} {msg}");

            // throwing an exception will stop de-serialization
            // returning will cause the error to be ignored and serialization will continue
        }
        #endregion // Error Handler

        public static void ValidatingReader()
        {
            Console.WriteLine("\n************************************************************");
            Console.WriteLine("** Example: Handling Errors using an XSD Validator callback:\n");

            #region Validating Reader
            // Note : No last-name in author
            string sampleXml = @"<bs:bookstore xmlns:bs='http://www.liquid-technologies.com/sample/bookstore' >
                                    <bs:book price='23.99' publicationdate='2002-06-01' ISBN='0596002521'>
                                        <bs:title>XML Schema</bs:title>
                                        <bs:author>
                                            <bs:first-name>Eric</bs:first-name>
                                        </bs:author>
                                        <bs:genre>Reference</bs:genre>
                                    </bs:book>
                                </bs:bookstore>";

            using (StringReader reader = new StringReader(sampleXml))
            {
                BookstoreValidator validator = new BookstoreValidator();
                using (XmlReader validatingReader = validator.CreateValidatingReader(reader, ValidatingReaderErrorHandler))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.ReadNode(validatingReader);
                }
            }
            #endregion // Validating Reader
        }

        #region Validating Reader Error Handler
        private static void ValidatingReaderErrorHandler(object sender, ValidationEventArgs e)
        {
            Console.WriteLine($".Net XSD Validator : {e.Severity} : {e.Message}");
        }
        #endregion // Validating Reader Error Handler
    }
}
