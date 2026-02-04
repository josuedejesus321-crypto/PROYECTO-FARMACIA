using Microsoft.AspNetCore.Mvc;
using SelectPdf;

namespace FarmaciaWeb.Controllers
{
    public class ExportController : Controller
    {
        // Fallback: convierte una URL (mantener por compatibilidad)
        [HttpGet]
        public IActionResult GenerarPdf(string pageUrl)
        {
            try
            {
                if (string.IsNullOrEmpty(pageUrl))
                    return BadRequest("URL inválida");

                HtmlToPdf converter = new HtmlToPdf();
                converter.Options.PdfPageSize = PdfPageSize.A4;
                converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;

                // ✅ Márgenes de 10 puntos
                converter.Options.MarginTop = 10;
                converter.Options.MarginBottom = 10;
                converter.Options.MarginLeft = 10;
                converter.Options.MarginRight = 10;

                PdfDocument doc = converter.ConvertUrl(pageUrl);
                byte[] pdf = doc.Save();
                doc.Close();

                return File(pdf, "application/pdf", "Reporte.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al generar el PDF: {ex.Message}");
            }
        }

        // Recomendado: recibe el HTML por POST y lo convierte (más fiable)
        [HttpPost]
        [IgnoreAntiforgeryToken] // evita problemas si no quieres manejar tokens en fetch
        [RequestSizeLimit(50_000_000)] // aumentar según necesidades
        public IActionResult GenerarPdfFromHtml([FromForm] string html, [FromForm] string fileName = "Reporte.pdf")
        {
            if (string.IsNullOrWhiteSpace(html))
            {
                return BadRequest("HTML vacío");
            }

            try
            {
                HtmlToPdf converter = new HtmlToPdf();
                converter.Options.PdfPageSize = PdfPageSize.A4;
                converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;

                // ✅ Márgenes de 10 puntos
                converter.Options.MarginTop = 10;
                converter.Options.MarginBottom = 10;
                converter.Options.MarginLeft = 10;
                converter.Options.MarginRight = 10;

                // Usa baseUrl para resolver recursos relativos (css, img)
                string baseUrl = $"{Request.Scheme}://{Request.Host}";
                PdfDocument doc = converter.ConvertHtmlString(html, baseUrl);

                byte[] pdf = doc.Save();
                doc.Close();

                return File(pdf, "application/pdf", fileName);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al generar el PDF: {ex.Message}");
            }
        }
    }
}
