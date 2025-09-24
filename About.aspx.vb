Public Class About
    Inherits Page
    Public persona As New Persona()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        persona.Nombre = txtNombre.Text
        persona.Apellido = txtApellido.Text
    End Sub
End Class