namespace DAL;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;

public class StudentDataAccess
{
    public static string conString = @"server=localhost; port=3306; user=root; password=vishal9767; database=IACSD";

    public static List<Student> GetAllStudent()
    {
        List<Student> allStudent=new List<Student>();

        MySqlConnection con=new MySqlConnection(conString);

        try{
            con.Open();
            string query="select * from student";
          //  DataSet ds=new DataSet();
            MySqlCommand cmd=new MySqlCommand(query,con);
         //   MySqlDataAdapter da=new MySqlDataAdapter(cmd);
          //  da.Fill(ds);
          MySqlDataReader reader=cmd.ExecuteReader();

          //  DataTable dt=ds.Tables[0];
         //   DataRowCollection rows=dt.Rows;
         //   foreach(DataRow row in rows)
            while(reader.Read())
            {
                Student stud=new Student
                {
                    id=int.Parse(reader["id"].ToString()),
                    name=reader["name"].ToString(),
                    place=reader["place"].ToString()
                };
                allStudent.Add(stud);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
        

        return allStudent;
    }
     public static Student GetUserById(int id)
    {
        Student stud = null;
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = "select * from student where id=" + id;
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                stud = new Student
                {
                    id = int.Parse(reader["id"].ToString()),
                    name = reader["name"].ToString(),
                    place = reader["place"].ToString(),
                    
                };
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return stud;
    }

     public static void SaveNewUser(Student stud)
    {
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = $"insert into student(id, name, place) values('{stud.id}', '{stud.name}', '{stud.place}')";
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }

    public static void DeleteUserById(int id)
    {
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = "delete from student where id =" + id;
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }
}