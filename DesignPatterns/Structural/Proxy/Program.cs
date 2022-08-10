
Console.Title = "Proxy";

// without proxy
Console.WriteLine("Constructing document.");
var myDocument = new Proxy.Document("MyDocument.pdf");
Console.WriteLine("Document constructed.");
myDocument.DisplayDocument();

Console.WriteLine();

// with proxy 
Console.WriteLine("Constructing document proxy.");
var myDocumentProxy = new Proxy.DocumentProxy("MyDocument.pdf");
Console.WriteLine("Document proxy constructed.");
myDocumentProxy.DisplayDocument();

Console.WriteLine();

// with chained proxy
Console.WriteLine("Constructing protected document proxy.");
var myProtectedDocumentProxy = new Proxy.ProtectedDocumentProxy("MyDocument.pdf", "Viewer");
Console.WriteLine("Protected document proxy constructed.");
myProtectedDocumentProxy.DisplayDocument();

Console.WriteLine();
try
{
    // with chained proxy, no access
    Console.WriteLine("Constructing protected document proxy.");
    myProtectedDocumentProxy = new Proxy.ProtectedDocumentProxy("MyDocument.pdf", "AnotherRole");
    Console.WriteLine("Protected document proxy constructed.");
    myProtectedDocumentProxy.DisplayDocument();

} catch(UnauthorizedAccessException ex)
{
    Console.WriteLine($"DisplayDocument(): {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.ReadKey();
