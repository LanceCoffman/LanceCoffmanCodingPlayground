using System;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server; 

public class StoredProcedures 
{
   [Microsoft.SqlServer.Server.SqlProcedure]
   public static void SalesItems(out SqlInt32 value)
   {
      using(SqlConnection connection = new SqlConnection("context connection=true")) 
      {
         value = 0;
         connection.Open();
         SqlCommand command = new SqlCommand("SELECT ItemName FROM SalesLineItems", connection);
         SqlDataReader reader = command.ExecuteReader();
         
         using (reader)
         {
            while( reader.Read() )
            {
               value += reader.GetSqlInt32(0);
            }
         }         
      }
   }
}


