namespace GameStore.Client;
using GameStore.Client.Models;

public static class GameClient
  {
   private static  readonly List<Game> games = new()
    {
      new Game()
          {
              Id=1,
              Name= "Street Fighter II",
              Genre= "Fighting",
              Price= 19.99M,
              ReleaseDate = new DateTime(1992, 2, 1)
          },
      new Game()
          {
              Id=2,
              Name= "Final Fantasy",
              Genre= "Roleplaying",
              Price= 59.99M,
              ReleaseDate = new DateTime(2010, 9, 30)
          },
      new Game()
          {
              Id=3,
              Name= "FIFA 3",
              Genre= "sports",
              Price= 69.99M,
              ReleaseDate = new DateTime(2022, 9, 27)
          }
    };

    public static Game[] getGames() {
      return games.ToArray();
    }

    public static void AddGame(Game game) {
        game.Id = games.Max(game => game.Id)+ 1;
        games.Add(game);
    }
    public static Game GetGame(int id) {
        return games.Find(game => game.Id ==id) ?? throw new Exception("Could not find game!");
    }
    public static void UpdateGame(Game game) {
        Game existingGame = GetGame(game.Id);
        existingGame.Name = game.Name;
        existingGame.Price = game.Price;
        existingGame.Genre = game.Genre;
        existingGame.ReleaseDate = game.ReleaseDate;
    }
    public static void DeleteGame(int id) {
      Game game = GetGame(id);
      games.Remove(game);
    }
  }