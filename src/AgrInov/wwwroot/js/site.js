// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const $sidebar = $("#agr-sidebar");
const $sidebarClose = $("#agr-sidebar-close");
const $sidebarShow = $("#agr-sidebar-show");

$sidebarClose.on("click", function () {
    $sidebar.removeClass('show');
});

$sidebarShow.on("click", function () {
    $sidebar.addClass('show');
});
