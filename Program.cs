//ORM - Object Related Mapping - Dapper, Entity Framework
using AdoNet;
using AdoNet.Helpers;
using AdoNet.Models;
using Microsoft.Data.SqlClient;
using System.Data;
class Program
{
    //const string _connString = "Server = .\\SQLEXPRESS;Database = AB108;Trusted_Connection=True;TrustServerCertificate=True";
    static void Main()
    {
        #region AdoNET
        //using (SqlConnection connection = new SqlConnection(_connString))
        //{
        //    using (SqlCommand command = new SqlCommand("SELECT * FROM Students", connection))
        //    {
        //        connection.Open();
        //        var reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Console.WriteLine(reader["Name"] + " " + reader[2]);
        //        }
        //    }
        //}
        //if(SqlHelper.Exec("DELETE Students WHERE Id = 22"))
        //{
        //    Console.WriteLine("Student deleted successfully");
        //}
        //foreach (DataRow item in SqlHelper.Read("SELECT * FROM Students WHERE IsDeleted = 0").Rows)
        //{
        //    Console.WriteLine(item["Name"] + " " + item["Surname"]);
        //}
        #endregion
        Sql sql = new Sql();
        sql.Lessons.ToList()
            .ForEach(x => Console.WriteLine(x.Name + " " + x.CreditCount));
        //sql.Lessons.Add(new Lesson
        //{
        //    CreditCount = 4,
        //    Name = "Fizika"
        //});
        //sql.Lessons.Add(new Lesson
        //{
        //    CreditCount = 8,
        //    Name = "Ali Riyaziyyat"
        //});
        //sql.Lessons.Add(new Lesson
        //{
        //    CreditCount = 6,
        //    Name = "Mentiq"
        //});
        //sql.Teachers.Add(new Teacher
        //{
        //    Name = "Vilayat",
        //    Surname = "Aliyev"
        //});
        //sql.Students.Delete(21);
        //foreach (var item in sql.Students.ToList())
        //{
        //    Console.WriteLine(item.Name);
        //}
        //Student std = new Student
        //{
        //    Id = 1,
        //    IsDeleted = false,
        //    No="0008",
        //    Name = "Rafiga",
        //    Surname = "Mirzazada"
        //};
        //sql.Students.Add(std);
    }
    //static void Create(string name, string surname, string code)
    //{
    //    using SqlConnection conn = new SqlConnection(_connString);
    //    using SqlCommand cmd = new SqlCommand($"INSERT INTO Students VALUES (N'{name}',N'{surname}','{code}',0)", conn);
    //    conn.Open();
    //    int result = cmd.ExecuteNonQuery();
    //    conn.Close();
    //    if (result > 0)
    //    {
    //        Console.WriteLine("Student added successfully");
    //    }
    //}
    //static void GetDatas()
    //{
    //    DataTable dt = new DataTable();
    //    using (SqlConnection connection = new SqlConnection(_connString))
    //    {
    //        using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students", connection))
    //        {
    //            connection.Open();
    //            sda.Fill(dt);
    //        }
    //    }
    //    foreach (DataRow item in dt.Rows)
    //    {
    //        Console.WriteLine(item["Name"] + " " + item["Surname"]);
    //    }
    //}
}
