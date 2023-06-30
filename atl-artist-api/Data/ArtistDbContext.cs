using atl_artist_api.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

//TODO Refactor to use Service Class
namespace atl_artist_api.Data
{
    public class ArtistDbContext : DbContext
    {
        public string ConnectionString { get; set; }
        public ArtistDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public DbSet<ArtistModel> Artists { get; set; }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

    public List<ArtistModel> GetAllArtists()
{
    List<ArtistModel> list = new List<ArtistModel>();

    using (MySqlConnection conn = GetConnection())
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("select * from Artists", conn);

        using (var reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                list.Add(new ArtistModel()
                {
                    id = Convert.ToInt32(reader["Id"]),
                    name = reader["Name"].ToString(),
                    topSong = reader["Top_song"].ToString(),
                    neighborhood = reader["Neighborhood"].ToString(),
                    genre = reader["Genre"].ToString()

                });
            }
        }
    }
    return list;
}
    public ArtistModel GetArtistById(int id)
{
    ArtistModel artist = new ArtistModel();

    using (MySqlConnection conn = GetConnection())
    {
        var sql = $"select * from Artists where id = {id}";
        conn.Open();
        MySqlCommand cmd = new MySqlCommand(sql, conn);

        using (var reader = cmd.ExecuteReader())
        {
            if (reader.Read())
            {
                artist = (new ArtistModel()
                {
                    id = Convert.ToInt32(reader["Id"]),
                    name = reader["Name"].ToString(),
                    topSong = reader["Top_song"].ToString(),
                    neighborhood = reader["Neighborhood"].ToString(),
                    genre = reader["Genre"].ToString()

                });
            }
        }
    }
    return artist;
}


    }
}