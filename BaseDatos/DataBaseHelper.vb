Imports System.Data.SqlClient
Imports System.Web.WebSockets

Public Class DataBaseHelper
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("II-46ConnectionString").ConnectionString
    Public Function create(Persona As Persona) As String
        Try
            Dim sql As String = "INSERT INTO PERSONAS (Nombre, Apellido, Edad) VALUES(@Nombre, @Apellido, @Edad)"
            Dim parametros As New List(Of SqlParameter) From {
                New SqlParameter("@Nombre", Persona.Nombre),
                New SqlParameter("@Apellido", Persona.Apellido),
                New SqlParameter("@Edad", Persona.Edad)
                }

            Using connection As New SqlConnection(connectionString)
                Using Command As New SqlCommand(sql, connection)
                    Command.Parameters.AddRange(parametros.ToArray)
                    connection.Open()
                    Command.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception

        End Try
        Return "Persona creada"
    End Function
End Class
