using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen2.CLASES
{
    public class ASIGNACIONES
    {
        public static int asignacionID { get; set; }
        public static int reparacionID { get; set; }
        public static string tecnico { get; set; }
        public static string fechaAsignacion { get; set; }

        public ASIGNACIONES(int AsignacionID, int ReparacionID, string Tecnico, string FechaAsignacion)
        {
            asignacionID = AsignacionID;
            reparacionID = ReparacionID;
            tecnico = Tecnico;
            fechaAsignacion = FechaAsignacion;
        }
    }
}