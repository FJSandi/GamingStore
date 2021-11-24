using System.Security.Cryptography;
using System.Text;

namespace BussinessLogic
{
        public static class Encriptador
        {
            public static string Encriptar(string Entrada)
            {
                SHA512CryptoServiceProvider ProveedorCrypto = new SHA512CryptoServiceProvider();

                //Descompone la cadenaDeEntrada en Bytes
                byte[] BytesDeEntrada = Encoding.UTF8.GetBytes(Entrada);

                //Usando los bytes de la cadena de entrada crea el Hash
                byte[] BytesConHash = ProveedorCrypto.ComputeHash(BytesDeEntrada);

                StringBuilder Resultado = new StringBuilder();

                //el for recorre cada byte del Hash y lo agrega a una cadena (stringbuilder)
                for (int i = 0; i < BytesConHash.Length; i++)
                    Resultado.Append(BytesConHash[i].ToString("x2").ToLower());
                // el x2 lo que hace es poner los caracteres hexadecimales con cierto formato.

                return Resultado.ToString();
            }

        }
    }