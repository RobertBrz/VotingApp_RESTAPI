using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using Xunit;

namespace VotingApp_RESTAPI.Tests
{
    //public class VotingApp_RESTAPIdataBaseTest
    //{
    //    IConfiguration _configuration;

    //    [Fact]
    //    public void CheckDatabaseConnection()
    //    {
    //        var builder = new ConfigurationBuilder()
    //            .SetBasePath(Directory.GetCurrentDirectory())
    //            .AddJsonFile("appsettings.json");

    //        _configuration = builder.Build();

    //        SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("LocalConnection"));
    //        conn.Open();
    //        Assert.Equal(ConnectionState.Open, conn.State);
    //        conn.Close();
    //        Assert.Equal(ConnectionState.Closed, conn.State);
    //    }
    //}
}
