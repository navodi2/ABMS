using System.Data.SqlClient;
using System.Data;

namespace ABMS.DL
{
   public class DLLogin
   {
       SqlDBHelper sql = new SqlDBHelper();
       public DataSet LoginCredential(BE.BELogin belogin)
       {   
           string connectionString = sql.ConnectionString();
           SqlConnection con = new SqlConnection();
           con.ConnectionString = connectionString;
           con.Open();
           SqlCommand cmd = new SqlCommand("usp_LoginVerification", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@UserId", belogin.UserId);
           cmd.Parameters.AddWithValue("@Password", belogin.Password);
           cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
           cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
           SqlDataAdapter da = new SqlDataAdapter();
           DataSet ds = new DataSet();
           da = new SqlDataAdapter(cmd);
           da.Fill(ds);           
           con.Close();
           return ds;

       }
    }
}
