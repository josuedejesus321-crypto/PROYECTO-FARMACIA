document.addEventListener('DOMContentLoaded', function () {
    const sidebar = document.getElementById('sidebarMenu');
    const contentWrapper = document.querySelector('.content-wrapper');
    const topBar = document.querySelector('.top-app-bar');

    if (!sidebar || !contentWrapper || !topBar) return;

    sidebar.classList.add('minimized');
    contentWrapper.classList.add('minimized');
    topBar.style.marginLeft = '60px'; // ancho del sidebar minimizado

    let openedByButton = false;

    // --- Evento del botón ---
    const openButton = document.getElementById('sidebarToggle');
    openButton.addEventListener('click', function () {
        openedByButton = !openedByButton;

        sidebar.classList.toggle('minimized', !openedByButton);
        contentWrapper.classList.toggle('minimized', !openedByButton);

        // Mover navbar en vez del botón
        topBar.style.marginLeft = openedByButton ? '250px' : '60px';
    });

    // --- Hover: solo si NO fue abierto por botón ---
    sidebar.addEventListener('mouseenter', function () {
        if (!openedByButton) {
            sidebar.classList.remove('minimized');
            contentWrapper.classList.remove('minimized');
            topBar.style.marginLeft = '250px';
        }
    });

    sidebar.addEventListener('mouseleave', function () {
        if (!openedByButton) {
            sidebar.classList.add('minimized');
            contentWrapper.classList.add('minimized');
            topBar.style.marginLeft = '60px';
        }
    });
});



// esto aqui es el color verde al presionar el boton del navmenu
document.addEventListener('DOMContentLoaded', function () {
    const mainLinks = document.querySelectorAll('.custom-sidebar-style .nav-item-top > .nav-link');

    // Recuperar del localStorage el último link activo
    const activeLink = localStorage.getItem('activeSidebarMainLink');

    if (activeLink) {
        const savedLink = document.querySelector(`.custom-sidebar-style .nav-item-top > a[href="${activeLink}"]`);
        if (savedLink) savedLink.classList.add('active');
    }

    mainLinks.forEach(link => {
        link.addEventListener('click', function () {
            // Quitar clase active de todos
            mainLinks.forEach(l => l.classList.remove('active'));

            // Activar el clickeado
            this.classList.add('active');

            // Guardar en localStorage
            localStorage.setItem('activeSidebarMainLink', this.getAttribute('href'));
        });
    });
});

//esto es la animacion de click de los botones
document.addEventListener('DOMContentLoaded', () => {
  const links = document.querySelectorAll('.custom-sidebar-style .nav-link');

  links.forEach(link => {
    link.addEventListener('click', function (e) {
      // Crear la onda
      const circle = document.createElement('span');
      circle.classList.add('ripple-effect');

      // Determinar tamaño de la onda (el máximo entre ancho y alto del link)
      const diameter = Math.max(this.clientWidth, this.clientHeight);
      const radius = diameter / 2;

      circle.style.width = circle.style.height = `${diameter}px`;

      // Posicionar la onda según donde se hizo clic
      const rect = this.getBoundingClientRect();
      circle.style.left = `${e.clientX - rect.left - radius}px`;
      circle.style.top = `${e.clientY - rect.top - radius}px`;

      // Remover onda previa, si existe
      const existing = this.getElementsByClassName('ripple-effect')[0];
      if (existing) {
        existing.remove();
      }

      // Añadir la onda al enlace
      this.appendChild(circle);

      // La animación dura 600ms (igual que en CSS); después quitamos el elemento
      setTimeout(() => {
        circle.remove();
      }, 600);
    });
  });
});

//Loader
// Cuando la página termine de cargar
window.addEventListener("load", function () {
    const loader = document.getElementById("loader-wrapper");
    if (loader) {
        loader.classList.add("fade-out");
    }
});


//esto es del pdf
document.addEventListener("DOMContentLoaded", function () {
    const pdfButton = document.getElementById("pdfButton");
    if (!pdfButton) return;

    pdfButton.addEventListener("click", async function () {
        try {
            // Clonar solo el body
            const bodyClone = document.body.cloneNode(true);

            // Quitar el botón PDF
            const btnInClone = bodyClone.querySelector("#pdfButton");
            if (btnInClone && btnInClone.parentNode) btnInClone.parentNode.removeChild(btnInClone);

            // Seleccionar solo la primera tabla
            const tabla = bodyClone.querySelector("table");
            if (!tabla) {
                alert("No se encontró ninguna tabla en la página.");
                return;
            }

            // Limpiar body y dejar solo la tabla
            bodyClone.innerHTML = "";
            bodyClone.appendChild(tabla);

            // Construir HTML completo con head y estilos
            const htmlToSend = "<!DOCTYPE html>\n<html>\n<head>\n" +
                document.head.innerHTML +
                "<style>" +
                "table { border-collapse: collapse; width: 100%; } " +
                "th, td { border: 1px solid #000; padding: 5px; text-align: left; }" +
                "</style>\n</head>\n<body>\n" +
                bodyClone.innerHTML +
                "\n</body>\n</html>";

            const formData = new FormData();
            formData.append("html", htmlToSend);
            const filename = (document.title ? document.title.trim() : "Reporte") + ".pdf";
            formData.append("fileName", filename);

            const response = await fetch("/Export/GenerarPdfFromHtml", {
                method: "POST",
                body: formData
            });

            if (!response.ok) {
                const text = await response.text();
                alert("Error al generar el PDF: " + text);
                return;
            }

            const blob = await response.blob();
            const url = URL.createObjectURL(blob);
            const a = document.createElement("a");
            a.href = url;
            a.download = filename;
            document.body.appendChild(a);
            a.click();
            a.remove();
            URL.revokeObjectURL(url);

        } catch (err) {
            console.error("Error al generar PDF:", err);
            alert("Error al generar el PDF: " + (err.message || err));
        }
    });
});
