using DataAccess.Factory;
using System.Data;

public class UserRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public UserRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public void GetUser(int id)
    {
        var users =new List<object>();

        using IDbConnection connection = _connectionFactory.CreateConnection();

        connection.Open();

        using IDbCommand command =
            connection.CreateCommand();

        command.CommandText =
            "SELECT Id, Name, Email FROM Users WHERE Id = @Id";

        IDbDataParameter parameter =
            command.CreateParameter();

        parameter.ParameterName = "@Id";
        parameter.Value = id;

        command.Parameters.Add(parameter);

        using IDataReader reader =
            command.ExecuteReader();

        while (reader.Read())
        {
            users.Add(new object
            {

            });
        }

        //return users;
    }
}