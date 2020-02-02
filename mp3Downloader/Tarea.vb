Imports System.Threading

Public Class Tarea



    Private name As String
    Public terminado As Boolean = False
    Private boton As Button

    Sub New(name As String, boton As Button)

        Me.name = name
        Me.boton = boton

    End Sub


    Public Sub Tarea1()


        Thread.Sleep(4000)
        boton.PerformClick()

        'For i As Integer = 0 To 5



        '    'Try

        '    '    'If Not IsNothing(web.Document) Then
        '    '    '    Console.WriteLine("OLEEEEEEE!!!!!!!!")
        '    '    'End If

        '    'Catch ex As Exception

        '    '    Console.WriteLine("buscando boton....")
        '    '    Thread.Sleep(2000)

        '    'End Try




        'Next

        'web.Document.GetElementById("process_mp3_a").InvokeMember("click")

        'Dim bandera = False

        'While (bandera = False)

        '    '1º paso
        '    If Not IsNothing(Me.web.Document) Then

        '        web.Document.GetElementById("process_mp3_a").InvokeMember("click")

        '        bandera = True
        '    End If

        'End While


        'terminado = True


    End Sub












End Class
