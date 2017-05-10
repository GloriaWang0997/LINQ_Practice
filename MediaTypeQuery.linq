<Query Kind="Statements">
  <Connection>
    <ID>94eff408-c7ab-4222-b0bb-9a1b14104094</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
			  select new
			  {
			  Name = m.Name,
			  Tracks = from t in m.Tracks
			  select new
				{
				TrackName = t.Name,
				Album = t.Album.Title,
				Aritist = t.Album.Artist.Name,
				ReleaseYear = t.Album.ReleaseYear,
				ReleaseLabel = t.Album.ReleaseLabel,
				Genre = t.Genre.Name
				}
			  };
results.Dump();