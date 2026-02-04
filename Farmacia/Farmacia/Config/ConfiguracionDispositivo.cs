using System;
using System.IO;

namespace Farmacia.Config
{
    public static class ConfiguracionDispositivo
    {
        /// <summary>
        /// Obtiene la ruta de destino para guardar los códigos de barras según el dispositivo actual
        /// </summary>
        /// <returns>Ruta completa donde se guardarán los códigos de barras</returns>
        public static string ObtenerRutaCodigoBarras()
        {
            // Obtener el nombre del usuario actual
            string usuarioActual = Environment.UserName;
            string nombreEquipo = Environment.MachineName;

            // Configurar rutas según el dispositivo/usuario
            string rutaBase = string.Empty;

            // Detectar dispositivo actual basado en el nombre del usuario o equipo
            switch (usuarioActual.ToUpper())
            {
                case "ADMIN":
                    // Dispositivo actual (PC donde se está ejecutando ahora)
                    rutaBase = @"C:\Users\ADMIN\Desktop\PROYECTO-FARMACIA\Farmacia\Farmacia\Resources";
                    break;
                case "YEISON DE JESUS":
                    // Otro dispositivo
                    rutaBase = @"C:\Users\Yeison De Jesus\Desktop\PROYECTO FARMACIA\Farmacia\Farmacia\Resources";
                    break;
                default:
                    // Fallback: crear carpeta en el directorio del proyecto actual
                    string directorioProyecto = AppDomain.CurrentDomain.BaseDirectory;
                    rutaBase = Path.Combine(directorioProyecto, "Resources");
                    break;
            }

            // Crear el directorio si no existe
            if (!Directory.Exists(rutaBase))
            {
                try
                {
                    Directory.CreateDirectory(rutaBase);
                }
                catch (Exception ex)
                {
                    // Si hay error creando la carpeta, usar directorio temporal
                    rutaBase = Path.GetTempPath();
                    System.Windows.Forms.MessageBox.Show(
                        $"No se pudo crear la carpeta de recursos. Se usará carpeta temporal.\nError: {ex.Message}", 
                        "Advertencia", 
                        System.Windows.Forms.MessageBoxButtons.OK, 
                        System.Windows.Forms.MessageBoxIcon.Warning);
                }
            }

            return rutaBase;
        }

        /// <summary>
        /// Obtiene información del dispositivo actual para debugging
        /// </summary>
        /// <returns>String con información del dispositivo</returns>
        public static string ObtenerInfoDispositivo()
        {
            return $"Usuario: {Environment.UserName}, Equipo: {Environment.MachineName}";
        }

        /// <summary>
        /// Verifica si la ruta de recursos es accesible
        /// </summary>
        /// <returns>True si la ruta es accesible, False en caso contrario</returns>
        public static bool VerificarAccesoRuta()
        {
            try
            {
                string ruta = ObtenerRutaCodigoBarras();
                return Directory.Exists(ruta) || Directory.CreateDirectory(ruta).Exists;
            }
            catch
            {
                return false;
            }
        }
    }
}