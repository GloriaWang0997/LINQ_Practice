<Query Kind="Statements">
  <Connection>
    <ID>e7b757f7-09d8-4e96-922d-09a1c5dd7ecc</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Artists
where x.ArtistId == 1
orderby x.Name
select new
{
Artist = x.Name,
Albums = from t in x.Albums
orderby t.Title
select new
	{
	Title = t.Title,
	Tracks = from tr in t.Tracks
	select new{
	TrackName = tr.Name,
	GenreId = tr.GenreId,
	Composer = tr.Composer,
	Milliseconds = tr.Milliseconds
	}
	}
};
results.Dump();