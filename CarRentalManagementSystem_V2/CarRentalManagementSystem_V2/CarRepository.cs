using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V2
{
    internal class CarRepository
    {
        private string CarRentalDbConnectionString = "Server=(localdb)\\MSSQLLocalDB); Database=CarRentalManagement; Trusted_Connection=True; TrustServerCertificate=True;";

        public void CreateCar(string carId, string brand, string model, decimal rentalPrice)
        {

            try
            {
                string capitalizeTitle = CapitalizeBrand(brand);
                string insertQuery = @"INSERT INTO Cars (Brand, Model, RentalPrice)
                                  VALUES(@brand, @model, @rentalPrice);";
                using (SqlConnection conn = new SqlConnection(CarRentalDbConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Brand", capitalizeTitle);
                        cmd.Parameters.AddWithValue("@Model", model);
                        cmd.Parameters.AddWithValue("@RentalPrice", rentalPrice);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Car added successfully");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        public void CapitalizeBrand(string value)
        {
            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
                return string.Join(" ", words);
        }

    }


}


    


