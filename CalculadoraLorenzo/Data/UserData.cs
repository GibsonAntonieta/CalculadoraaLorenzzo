using CalculadoraLorenzo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLorenzo.Data
{
    public class UserData
    {
        private SQLiteAsyncConnection _conexaoDB;

        public UserData(SQLiteAsyncConnection conexaoDB)
        {
            _conexaoDB = conexaoDB;
        }

        public Task<List<UsuarioModel>> GetUsers()
        {
            var Lista = _conexaoDB
                .Table<UsuarioModel>()
                .ToListAsync();

            return Lista;

        }

        public Task<UsuarioModel> GetItenUser(string email, string password)
        {
            var user = _conexaoDB
                .Table<UsuarioModel>()
                .Where(u => u.Email == email && u.Password == password)
                .FirstOrDefaultAsync();

            return user;

        }

        public Task<UsuarioModel> GetIdUser(Guid id)
        {
            var user = _conexaoDB
                .Table<UsuarioModel>()
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();

            return user;

        }

        public async Task<int> SaveUser(UsuarioModel user)
        {
            var newUser = await GetIdUser(user.Id);
            if (newUser == null)
            {
                return await _conexaoDB.InsertAsync(user);
            }
            else
            {
                return await _conexaoDB.UpdateAsync(user);
            }
        }

        public async Task<int> deletarUsuario(UsuarioModel user)
        {
            return await _conexaoDB.DeleteAsync(user);
        }
    }
}
