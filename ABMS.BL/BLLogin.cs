using System.Data;

namespace ABMS.BL
{
    public class BLLogin
    {
        ABMS.DL.DLLogin  objdal = new ABMS.DL.DLLogin();
        BE.BELogin objbeLogin = new BE.BELogin();
        public DataSet UserLogin(BE.BELogin objbeLogin)
        {
            try
            {

                return objdal.LoginCredential(objbeLogin);
            }
            catch
            {
                throw;
            }
        }
    }
}
