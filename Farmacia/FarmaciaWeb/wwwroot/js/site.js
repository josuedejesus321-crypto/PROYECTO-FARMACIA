// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function() {
    const sidebar = document.getElementById('sidebarMenu');
    const openButton = document.querySelector('.menu-open-button-fixed');
    const contentWrapper = document.querySelector('.content-wrapper');

    if (sidebar && openButton && contentWrapper) {
        
        // 1. Establecer el estado inicial: Menú CERRADO/MINIMIZADO por defecto.
        // Esto asegura que al cargar la página, el menú esté colapsado a 60px.
        sidebar.classList.add('minimized');
        contentWrapper.classList.add('minimized');
        // Si el botón debe estar "movido" en el estado inicial, añadir 'btnnac' aquí.
        // openButton.classList.add("btnnac"); 

        
        // 2. Definir la lógica de alternancia al hacer clic en el botón.
        openButton.addEventListener('click', function () {
            
            // A. CONTROL DEL MINI-SIDEBAR (Cierra/Abre el menú: 60px <-> 250px)
            sidebar.classList.toggle('minimized');
            
            // B. CONTROL DEL DESPLAZAMIENTO DEL CONTENIDO (El margen del contenido principal)
            // Usamos la clase 'minimized' para controlar el margen del contentWrapper:
            contentWrapper.classList.toggle('minimized'); 
            
            // C. CONTROL DEL BOTÓN (Movimiento/Ocultamiento del botón de abrir)
            openButton.classList.toggle("btnnac"); 
            
            
            /*
            * NOTA: La clase 'sidebar-open' que usaste en tu código original 
            * para el desplazamiento se reemplazó por 'minimized' en el contentWrapper,
            * lo cual es más lógico para esta implementación de mini-sidebar.
            */
        });
    }
});