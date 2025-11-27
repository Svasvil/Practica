$(document).ready(function () {
    $("#AbrirModal").click(function () {
        $.ajax({
            url: 'ObtenerListaHabitacionesParcial',
            type: "GET",
            data: { id: 45 },
            success: function (Respuesta) {
                // 1. Cargamos el contenido en el cuerpo del modal correcto
                $('#exampleModal .modal-body').html(Respuesta);

                // 2. Mostramos el modal usando su ID correcto
                $('#exampleModal').modal('show');
            },
            error: function (xhr, status, error) {
                alert('Error al cargar el modal: ' + error);
            }
        });
    });
});