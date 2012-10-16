Public Module Cliente

    Sub Main()
        Dim ruta As String = ".\private$\hsaria"
        If Not Messaging.MessageQueue.Exists(ruta) Then
            Messaging.MessageQueue.Create(ruta)
        End If
        Dim cola As New Messaging.MessageQueue(ruta)
        Dim mensaje As New Messaging.Message
        mensaje.Label = "Nueva Pregunta"
        mensaje.Body = New Preguntas With {.idPregunta = "1", .Pregunta = "Esto esta funcionando"}
        cola.Send(mensaje)

        Console.ReadLine()
    End Sub

    Public Class Preguntas

        Private _idPregunta As String
        Public Property idPregunta() As String
            Get
                Return _idPregunta
            End Get
            Set(ByVal value As String)
                _idPregunta = value
            End Set
        End Property


        Private PreguntaValue As String
        Public Property Pregunta() As String
            Get
                Return PreguntaValue
            End Get
            Set(ByVal value As String)
                PreguntaValue = value
            End Set
        End Property

    End Class

End Module
