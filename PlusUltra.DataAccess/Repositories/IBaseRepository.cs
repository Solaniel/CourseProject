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
        void InsertStudent(Game game);
        void DeleteStudent(int studentID);
        void UpdateStudent(Student student);
        void Save();

    }
}
