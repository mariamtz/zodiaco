using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SignosZodiacales
{
    //Aries: 21 de marzo al 20 de Abril
    //Tauro:21 de Abril al 21 de Mayo
    //Geminis: 22 de Mayo al 21 de Junio
    //Cancer: 22 de Junio al 22 Julio
    //Leo: 23 de Julio al 23 de Agosto
    //Virgo :24 de Agosto al 23 de Sepiembre
    //Libra:24 de Septiembre al 23 de Octubre
    //Escoorpion:24 de Octubre al 22 de Noviembre
    //Sagitario:23 de Noviembre al 21 de Diciembre
    //Capricornio: 22 de Diciembre al 20 de Enero
    //Acuario: 21 de Enero al 19 de Febrero 
    //Pisis:20 de Febrero al 20 de Marz
    /// <summary>
    /// Descripción breve de Horoscopos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Horoscopos : System.Web.Services.WebService
    {

        [WebMethod]
        public string Signos(int dia, int mes)
        {
            var signo = "";

            if (mes != -1)
            {
                if (mes == 0) // Enero
                {
                    if (dia <= 20)
                    {
                        signo = "Tu signo es  CAPRICORNIO ";
                    }
                    else
                    {
                        if (dia >= 21 && dia <= 31)
                        {
                            signo = "Tu signo es ACUARIO ";
                        }
                        else
                        {
                            signo = "Favor de Ingresar fecha exacta";
                        }
                    }
                }
                else
                {
                    if (mes == 1) // Febrero
                    {
                        if (dia <= 18)
                        {
                            signo = "Tu signo es ACUARIO ";
                        }
                        else
                        {
                            if (dia >= 19 && dia <= 29)
                            {
                                signo = "Tu signo es PISIS  ";
                            }
                            else
                            {
                                signo = "Favor de Ingresar fecha exacta";
                            }
                        }
                    }
                    else
                    {
                        if (mes == 2) // Marzo
                        {
                            if (dia <= 20)
                            {
                                signo = "Tu signo es PISIS ";
                            }
                            else
                            {
                                if (dia >= 21 && dia <= 31)
                                {
                                    signo = "Tu signo es ARIES  ";
                                }
                                else
                                {
                                    signo = "Favor de Ingresar fecha exacta";
                                }
                            }
                        }
                        else
                        {
                            if (mes == 3) // Abril
                            {
                                if (dia <= 20)
                                {
                                    signo = "Tu signo es ARIES  ";
                                }
                                else
                                {
                                    if (dia >= 21 && dia <= 30)
                                    {
                                        signo = "Tu signo es TAURO ";
                                    }
                                    else
                                    {
                                        signo = "Favor de Ingresar fecha exacta";
                                    }
                                }
                            }
                            else
                            {
                                if (mes == 4) // Mayo
                                {
                                    if (dia <= 21)
                                    {
                                        signo = "Tu signo es TAURO ";
                                    }
                                    else
                                    {
                                        if (dia >= 22 && dia <= 31)
                                        {
                                            signo = "Tu signo es  GEMINIS";
                                        }
                                        else
                                        {
                                            signo = "Favor de Ingresar fecha exacta";
                                        }
                                    }
                                }
                                else
                                {
                                    if (mes == 5) // Junio
                                    {
                                        if (dia <= 21)
                                        {
                                            signo = "Tu signo es GEMINIS ";
                                        }
                                        else
                                        {
                                            if (dia >= 22 && dia <= 30)
                                            {
                                                signo = "Tu signo es CANCER ";
                                            }
                                            else
                                            {
                                                signo = "Favor de Ingresar fecha exacta";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (mes == 6) // Julio
                                        {
                                            if (dia <= 22)
                                            {
                                                signo = "Tu signo es CANCER";
                                            }
                                            else
                                            {
                                                if (dia >= 23 && dia <= 31)
                                                {
                                                    signo = "Tu signo es LEO ";
                                                }
                                                else
                                                {
                                                    signo = "Favor de Ingresar fecha exacta";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (mes == 7) // Agosto
                                            {
                                                if (dia <= 23)
                                                {
                                                    signo = "Tu signo es LEO ";
                                                }
                                                else
                                                {
                                                    if (dia >= 24 && dia <= 31)
                                                    {
                                                        signo = "Tu signo es VIRGO ";
                                                    }
                                                    else
                                                    {
                                                        signo = "Favor de Ingresar fecha exacta";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (mes == 8) // Septiembre
                                                {
                                                    if (dia <= 23)
                                                    {
                                                        signo = "Tu signo es VIRGO \n Virgo";
                                                    }
                                                    else
                                                    {
                                                        if (dia >= 24 && dia <= 30)
                                                        {
                                                            signo = "Tu signo es LIBRA ";
                                                        }
                                                        else
                                                        {
                                                            signo = "Favor de Ingresar fecha exacta";
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (mes == 9) // Octubre
                                                    {
                                                        if (dia <= 23)
                                                        {
                                                            signo = "Tu signo es LIBRA ";
                                                        }
                                                        else
                                                        {
                                                            if (dia >= 24 && dia <= 31)
                                                            {
                                                                signo = "Tu signo es ESCORPION ";
                                                            }
                                                            else
                                                            {
                                                                signo = "Favor de Ingresar fecha exacta";
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (mes == 10) // Noviembre
                                                        {
                                                            if (dia <= 22)
                                                            {
                                                                signo = "Tu signo es ESCORPION ";
                                                            }
                                                            else
                                                            {
                                                                if (dia >= 23 && dia <= 30)
                                                                {
                                                                    signo = "Tu signo es SAGITARIO  ";
                                                                }
                                                                else
                                                                {
                                                                    signo = "Favor de Ingresar fecha exacta";
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (mes == 11) // Diciembre
                                                            {
                                                                if (dia <= 21)
                                                                {
                                                                    signo = "Tu signo es SAGITARIO  ";
                                                                }
                                                                else
                                                                {
                                                                    if (dia >= 22 && dia <= 31)
                                                                    {
                                                                        signo = "Tu signo es CAPRICORNIO ";
                                                                    }
                                                                    else
                                                                    {
                                                                        signo = "Favor de Ingresar fecha exacta";
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return signo;
        }






    }

}  
