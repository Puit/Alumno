using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PooVueling_Alumno
{
    public class Alumno : IAlumno
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Id { get; set; }
        public bool Guardar()
        {
            bool ok = false;
            try
            {
                if (File.Exists(@"alumno.json"))
                {
                    using (StreamWriter file = File.AppendText(@"alumno.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, this);
                        ok = true;
                    }
                }
                else
                {
                    using (StreamWriter file = File.CreateText(@"alumno.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, this);
                        ok = true;
                    }
                }
            }
            catch (Exception e)
            {
                ok = false;
                throw e;
            }
            return ok;
        }
    }
}
