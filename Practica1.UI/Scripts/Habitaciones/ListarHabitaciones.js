$(document).ready(function () {
    let table = new DataTable('#myTable');
    $("#AbrirModal").click(function () {
        $.ajax({
            url: 'ObtenerListaHabitacionesParcial',
            type: "GET",
            data: { id: 45 },
            success: function (Respuesta) {
                $('#exampleModal .modal-body').html(Respuesta);
                $('#exampleModal').modal('show');
            },
            error: function (xhr, status, error) {
                alert('Error al cargar el modal: ' + error);
            }
        });
    });

    $("#Guardar").click(function () {
        Swal.fire({
            title: "Drag me!",
            icon: "success",
            draggable: true
        });
    });
});