using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mypo.Model;
using Mypo.DAO;

namespace Mypo.Controller
{
    public class ControllerLogin
    {

        public bool Login(string valor,string contrasenia)
        {

            try
            {
                DAOLogIn dLogIn = new DAOLogIn();

                return dLogIn.Login(valor, contrasenia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
