using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Xunit;

namespace VotingApp_RESTAPI.Tests
{
    public class VotingApp_RESTAPIdataBaseTest
    {
        [Theory]
        [InlineData("Server=(localdb)\\localdb;Database=VotingAppDatabase;Trusted_Connection=True;")]
        public void CheckDatabaseConnection(string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            Assert.Equal(ConnectionState.Open, conn.State);
            conn.Close();
            Assert.Equal(ConnectionState.Closed, conn.State);
        }
    }
}
