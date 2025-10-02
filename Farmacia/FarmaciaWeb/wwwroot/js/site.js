document.addEventListener('DOMContentLoaded', function () {
  const sidebar = document.getElementById('sidebarMenu');
  const contentWrapper = document.querySelector('.content-wrapper');
  const openButton = document.getElementById('sidebarToggle');

  if (!sidebar || !contentWrapper || !openButton) return;

  // Estado inicial: minimizado
  sidebar.classList.add('minimized');
  contentWrapper.classList.add('minimized');

  openButton.addEventListener('click', function () {
    sidebar.classList.toggle('minimized');
    contentWrapper.classList.toggle('minimized');
    openButton.classList.toggle("btnnac");
  });
});

