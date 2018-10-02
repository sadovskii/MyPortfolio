$(document).ready(function () {
    AjaxForNavLink(".sidebar-header", '/Welcome', '#result')
    AjaxForNavLinkByClick(".sidebar-header", '/Welcome', '#result')
    AjaxForNavLinkByClick(".link-blog", '/Blog', '#result')
    AjaxForNavLinkByClick(".link-projects", '/Projects', '#result')
    AjaxForNavLinkByClick(".link-articles", '/Articles', '#result')

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
        $('#main').toggleClass('active');
    });

    $('#myModal').on('shown.bs.modal', function () {
        $('#myInput').trigger('focus')
    })
});