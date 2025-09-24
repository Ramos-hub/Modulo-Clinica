using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public static class Seguridad
    {
        public static string CrearHash(string clavePlano) => BCrypt.Net.BCrypt.HashPassword(clavePlano);

        public static bool EsBcrypt(string s) => !string.IsNullOrEmpty(s) &&
               (s.StartsWith("$2a$") || s.StartsWith("$2b$") || s.StartsWith("$2y$")) &&
               s.Length >= 60;
    }
}
