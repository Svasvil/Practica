$(document).ready(function () {
    $("#AbrirModal").click(function () {
        $.ajax({
            url: '/Reservas/ListaHabitacionesParcial',
            type: "GET",
            data: { id: 45 },
            success: function (Respuesta) {
       
                $('#modal .modal-body').html(Respuesta);

                $('#modal').modal('show');
            },
            error: function (xhr, status, error) {
                alert('Error al cargar el modal: ' + error);
            }
        });
    });
});