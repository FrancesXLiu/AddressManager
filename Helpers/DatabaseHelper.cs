using System.Collections.Generic;
using System.Data.SQLite;
using AddressManager.Models;

namespace AddressManager.Helpers;

public class DatabaseHelper
{
    private const string ConnectionString = "Data Source=Data/address_manager.db;Version=3;";

    public SQLiteConnection GetConnection()
    {
        return new SQLiteConnection(ConnectionString);
    }

    public void AddOrganization(Organization org)
    {
        using var conn = GetConnection();
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO Organization (Name, Street, Zip, City, Country) VALUES (@name, @street, @zip, @city, @country)";
        cmd.Parameters.AddWithValue("@name", org.Name);
        cmd.Parameters.AddWithValue("@street", org.Street);
        cmd.Parameters.AddWithValue("@zip", org.Zip);
        cmd.Parameters.AddWithValue("@city", org.City);
        cmd.Parameters.AddWithValue("@country", org.Country);

        cmd.ExecuteNonQuery();
    }


    public List<Organization> GetOrganizations()
    {
        var organizations = new List<Organization>();

        using var conn = GetConnection();
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM Organization";

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            organizations.Add(new Organization
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Street = reader.GetString(2),
                Zip = reader.GetString(3),
                City = reader.GetString(4),
                Country = reader.GetString(5)
            });
        }

        return organizations;
    }

    public void UpdateOrganization(Organization org)
    {
        using var conn = GetConnection();
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "UPDATE Organization SET Name = @name, Street = @street, Zip = @zip, City = @city, Country = @country WHERE Id = @id";
        cmd.Parameters.AddWithValue("@name", org.Name);
        cmd.Parameters.AddWithValue("@street", org.Street);
        cmd.Parameters.AddWithValue("@zip", org.Zip);
        cmd.Parameters.AddWithValue("@city", org.City);
        cmd.Parameters.AddWithValue("@country", org.Country);
        cmd.Parameters.AddWithValue("@id", org.Id);
        cmd.ExecuteNonQuery();
    }

    public void DeleteOrganization(int id)
    {
        using var conn = GetConnection();
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM Organization WHERE Id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }

    public void AddEmployee(Employee employee)
    {
        using var conn = GetConnection();
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO Employees (OrganizationId, Title, FirstName, LastName, Phone, Email) VALUES (@organizationId, @title, @firstName, @lastName, @phone, @email)";
        cmd.Parameters.AddWithValue("@organizationId", employee.OrganizationId);
        cmd.Parameters.AddWithValue("@title", employee.Title);
        cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
        cmd.Parameters.AddWithValue("@lastName", employee.LastName);
        cmd.Parameters.AddWithValue("@phone", employee.Phone);
        cmd.Parameters.AddWithValue("@email", employee.Email);

        cmd.ExecuteNonQuery();
    }

    public List<Employee> GetEmployees()
    {
        var employees = new List<Employee>();

        using var conn = GetConnection();
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM Employees";

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            employees.Add(new Employee
            {
                Id = reader.GetInt32(0),
                OrganizationId = reader.GetInt32(1),
                Title = reader.GetString(2),
                FirstName = reader.GetString(3),
                LastName = reader.GetString(4),
                Phone = reader.GetString(5),
                Email = reader.GetString(6)
            });
        }

        return employees;
    }

    public void UpdateEmployee(Employee employee)
    {
        using var conn = GetConnection();
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "UPDATE Employees SET OrganizationId = @organizationId, Title = @title, FirstName = @firstName, LastName = @lastName, Phone = @phone, Email = @email WHERE Id = @id";
        cmd.Parameters.AddWithValue("@organizationId", employee.OrganizationId);
        cmd.Parameters.AddWithValue("@title", employee.Title);
        cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
        cmd.Parameters.AddWithValue("@lastName", employee.LastName);
        cmd.Parameters.AddWithValue("@phone", employee.Phone);
        cmd.Parameters.AddWithValue("@email", employee.Email);
        cmd.Parameters.AddWithValue("@id", employee.Id);

        cmd.ExecuteNonQuery();
    }

    public void DeleteEmployee(int id)
    {
        using var conn = GetConnection();
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM Employees WHERE Id = @id";
        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
    }
}
