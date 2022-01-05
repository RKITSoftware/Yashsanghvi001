using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_Demo
{
    public class database_Movie
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;

        //retrive all data
        public List<Moive> selectAll()
        {
            List<Moive> obj_Movie = new List<Moive>();

            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();
                    MySqlCommand obj_cmd = new MySqlCommand("select * from Movie", obj_conn);

                    using (var reader = obj_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            obj_Movie.Add(new Moive())
                            {
                                MovieID = Convert.ToInt32(reader["MoiveID"]),
                                MoiveName = reader["MoiveName"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection !" + ex.Message);

                }

            }
            return obj_Moive;
        }

        //retrive data by id
        public Moive getMoiveById(int id)
        {
            Tutor Obj_movie = new database_Movie();

            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();
                    MySqlCommand obj_cmd = new MySqlCommand("select * from Movie where Movie = " + id + ";", obj_conn);

                    using (var reader = obj_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Obj_movie.TutorID = Convert.ToInt32(reader["MovieID"]);
                            Obj_movie.TutorName = reader["MovieName"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection !" + ex.Message);

                }
                finally
                {
                    obj_conn.Close();
                }

            }
            return Obj_movie;
        }

        //add data
        public string addMovie(Moive WatchMoive)
        {
            List<Moive> obj_Moive = new List<Moive>();

            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();

                    MySqlCommand obj_cmd = new MySqlCommand("insert into Movie (MovieID,MovieName) values('" + WatchMoive.MoiveID + "','" + WatchMoive.MovieName + "','");


                    int effect = obj_cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    obj_conn.Close();
                }

            }
        }


        //update data
        public string updateTutor(Moive WatchMoive)
        {
            List<Moive> obj_Moive = new List<Movie>();

            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();

                    MySqlCommand obj_cmd = new MySqlCommand("update set MoiveName = '" + WatchMoive.MoiveName , obj_conn);


                    int effect = obj_cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    obj_conn.Close();
                }

            }
        }

        //delete data
        public string deleteMoive(int id)
        {
            using (MySqlConnection obj_conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    obj_conn.Open();

                    MySqlCommand obj_cmd = new MySqlCommand("delete from where id = " + id, obj_conn);

                    int effect = obj_cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    obj_conn.Close();
                }

            }
        }

    }
}

