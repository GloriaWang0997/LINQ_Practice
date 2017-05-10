<Query Kind="Statements">
  <Connection>
    <ID>94eff408-c7ab-4222-b0bb-9a1b14104094</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new
			  {
			  	Genre = g.Name,
			  	TracksCount = g.Tracks.Count()
			  };
results.Dump("Query Math 1");