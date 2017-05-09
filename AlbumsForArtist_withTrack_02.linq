<Query Kind="Statements">
  <Connection>
    <ID>e7b757f7-09d8-4e96-922d-09a1c5dd7ecc</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from a in Artists
where a.ArtistId == 1
orderby a.Name
select new
{
Artist = a.Name,
Albums = from b in a.Albums
orderby b.Title
select new
	{
	Title = b.Title,
	Year = b.ReleaseYear,
	label = b.ReleaseLabel
	}
};
results.Dump();