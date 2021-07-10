using System;
using System.Text;
using VDS.RDF;
using VDS.RDF.Parsing;

Console.WriteLine("Enter RDF URL:");

var graph = new Graph();
UriLoader.Load(graph, new Uri(Console.ReadLine()));

var sb = new StringBuilder();
foreach (var triple in graph.Triples)
    sb.AppendLine(triple.ToString());

Console.WriteLine(sb.ToString());
Console.ReadKey();