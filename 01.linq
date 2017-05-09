<Query Kind="Statements">
  <Connection>
    <ID>e7b757f7-09d8-4e96-922d-09a1c5dd7ecc</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from a in Artists
orderby a.Name descending
select new
{
ID = a.ArtistId,
Name = a.Name
};
results.Dump();