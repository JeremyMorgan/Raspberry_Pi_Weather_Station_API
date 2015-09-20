using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WeatherCenter.Models;

namespace WeatherCenter.Helpers
{
    public class ReadingHandler
    {
        private readonly SqlConnection _sqlConnection;
        private readonly string _sqlConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        public ReadingHandler()
        {
            _sqlConnection = new SqlConnection(_sqlConnectionString);
        }

        public List<Reading> GetReadings(int items)
        {
            var ourReturnList = new List<Reading>();

            try
            {
                using (_sqlConnection)
                {
                    _sqlConnection.Open();
                    //
                    // Create new SqlCommand object.
                    //
                    using (
                        SqlCommand command =
                            new SqlCommand(
                                "SELECT TOP " + items + " [TempSensor1] ,[TempSensor2] ,[TempSensor3] ,[TempSensorAvg] ,[Humidity] ,[Pressure] ,[Altitude] ,[SeaLevelPressure] ,[Lux] ,[TimeStamp] FROM [rpi_mini_weather].[dbo].[Reading] ORDER BY ID DESC ", _sqlConnection))
                    {
                        //
                        // Invoke ExecuteReader method.
                        //
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var reading = new Reading();

                            reading.TempSensor1 = reader.GetFloat(0);
                            reading.TempSensor2 = reader.GetFloat(1);
                            reading.TempSensor3 = reader.GetFloat(2);
                            reading.TempSensorAvg = reader.GetFloat(3);
                            reading.Humidity = reader.GetFloat(4);
                            reading.Pressure = reader.GetFloat(5);
                            reading.Altitude = reader.GetFloat(6);
                            reading.SeaLevelPressure = reader.GetFloat(7);
                            reading.Lux = reader.GetFloat(8);
                            reading.TimeStamp = reader.GetDateTime(9);

                            ourReturnList.Add(reading);

                        }
                    }
                }

                _sqlConnection.Close();

            }
            catch (SqlException ex)
            {
                Debug.Write(ex.ToString());
            }

            return ourReturnList;

        }

    }
}