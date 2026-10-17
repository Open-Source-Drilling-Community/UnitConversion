using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using OSDC.UnitConversion.Service;

namespace OSDC.UnitConversion.ServiceTest;

public sealed class PersistentDatabaseTests
{
    [Test]
    public void Database_path_is_inside_the_configured_directory_and_records_survive_reopening()
    {
        string directory = Path.Combine(TestContext.CurrentContext.WorkDirectory, "storage-tests", Guid.NewGuid().ToString());
        string connectionString = SqlConnectionManager.CreateConnectionString(directory);
        Assert.That(new SqliteConnectionStringBuilder(connectionString).DataSource,
            Is.EqualTo(Path.Combine(directory, SqlConnectionManager.DATABASE_FILENAME)));
        var manager = new SqlConnectionManager(connectionString, NullLogger<SqlConnectionManager>.Instance);
        using (var connection = manager.GetConnection()!)
        using (var command = connection.CreateCommand())
        {
            command.CommandText = "INSERT INTO UnitConversionSetTable (ID, UnitConversionSet) VALUES ('retained-record', '{}')";
            command.ExecuteNonQuery();
        }
        var reopened = new SqlConnectionManager(connectionString, NullLogger<SqlConnectionManager>.Instance);
        using var read = reopened.GetConnection()!;
        using var count = read.CreateCommand(); count.CommandText = "SELECT COUNT(*) FROM UnitConversionSetTable";
        Assert.That(Convert.ToInt64(count.ExecuteScalar()), Is.EqualTo(1));
    }

    [Test]
    public void An_incompatible_existing_database_is_rejected_without_dropping_its_records()
    {
        string directory = Path.Combine(TestContext.CurrentContext.WorkDirectory, "storage-tests", Guid.NewGuid().ToString());
        Directory.CreateDirectory(directory);
        string connectionString = SqlConnectionManager.CreateConnectionString(directory);
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open(); using var command = connection.CreateCommand();
            command.CommandText = "CREATE TABLE RetainedRecords (ID TEXT); INSERT INTO RetainedRecords VALUES ('existing')";
            command.ExecuteNonQuery();
        }
        Assert.Throws<InvalidOperationException>(() => new SqlConnectionManager(connectionString, NullLogger<SqlConnectionManager>.Instance));
        using var check = new SqliteConnection(connectionString); check.Open();
        using var count = check.CreateCommand(); count.CommandText = "SELECT COUNT(*) FROM RetainedRecords";
        Assert.That(Convert.ToInt64(count.ExecuteScalar()), Is.EqualTo(1));
    }
}
