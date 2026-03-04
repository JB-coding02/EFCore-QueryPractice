// Answer the queries to try found in the README.md file. Print out the results in the console for each query.
// Place a Console.Readkey() after each query to pause the console window so you can see the results.
// Use a Console.WriteLine() to print the query question before the result.

using EFCore_QueryPractice.Models;
using Microsoft.EntityFrameworkCore;

ApContext myApContext = new();

// Query 1: Retrieve all invoices along with their associated vendor information. The include performs a "Join" in SQL.
List<Invoice> allInvoices = 
    await myApContext
        .Invoices
        .Include(invoice => invoice.Vendor)
        .ToListAsync();

foreach (var invoice in allInvoices)
{
    Console.WriteLine($"{invoice.InvoiceNumber} {invoice.Vendor.VendorName}");
}