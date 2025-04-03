using Npgsql;
using WonderWalkApi.Models;
using System.Threading.Tasks;

namespace WonderWalkApi.Data
{
    public class UsersDataAccess
    {
        private readonly string _connectionString;

        public UsersDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int?> CreateUser(string username, string email, string passwordHash)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var cmd = new NpgsqlCommand("INSERT INTO users (Username, Email, PasswordHash) VALUES (@username, @email, @passwordHash) RETURNING UserId;", connection))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("passwordHash", passwordHash);

                    object? result = await cmd.ExecuteScalarAsync();
                    if (result != null)
                    {
                        return (int)result;
                    }
                    else
                    {
                        return null; // Or throw an exception if appropriate
                    }
                }
            }
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var cmd = new NpgsqlCommand("SELECT UserId, Username, Email, PasswordHash FROM users WHERE Email = @email;", connection))
                {
                    cmd.Parameters.AddWithValue("email", email);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new User
                            {
                                UserId = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Email = reader.GetString(2),
                                PasswordHash = reader.GetString(3)
                            };
                        }
                        return null;
                    }
                }
            }
        }
    }
}