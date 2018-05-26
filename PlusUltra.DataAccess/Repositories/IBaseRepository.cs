using PlusUltraDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlusUltra.DataAccess.Repositories
{
    public interface IBaseRepository<T>
    {
        IEnumerable<Game> GetGames();
        Game GetGameByID(int gameId);
        void InsertGame(Game game);
        void DeleteGame(int gameId);
        void UpdateGame(Game game);
        void Save();

    }
}
