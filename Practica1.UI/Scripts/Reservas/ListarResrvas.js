$(document).ready(function () {
    let table = new DataTable('#myTable');
    $("#AbrirModal").click(function () {
        let reservas = {
            NombreDeLaPersona: $("#Nombres").val()
            , Identificacion: "123456789", Telefono: "555-1234", Correo: "Se02vas@gmail.com", FechaNacimiento: new Date(1990, 5, 15), Direccion: "Calle Falsa 123, Ciudad Ejemplo",
            FechaInicioReserva: new Date(2024, 6, 1), FechaFinReserva: new Date(2024, 6, 10), IdHabitacion: 5
        }
        $.ajax({
            url: '/Reservas/ListaHabitacionesParcial',
            type: "GET",
            data: reservas,
            success: function (Respuesta) {

                $('#modal .modal-body').html(Respuesta);

                $('#modal').modal('show');
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