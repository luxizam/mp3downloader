Imports System.Threading
Imports System.Timers
Imports System.Xml

Public Class Form1

    'Dim WithEvents wb As New WebBrowser

    Dim parar As String = ""

    'Dim wb As New WebBrowser
    'Dim almacen As New ArrayList
    'Dim almacenCheckBoxs As New ArrayList
    'Dim almacenBarraProgreso As New ArrayList

    Dim almacenGeneral As New List(Of Tarea)

    Dim selector As Integer = 0

    'Dim almacenDelTiempo As New List(Of System.Timers.Timer)
    'Dim almacenDeNavegadores As New List(Of WebBrowser)

    Dim web As New WebBrowser()

    Dim timer As New Timers.Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox1.Text = "https://www.youtube.com/watch?v=eKaD_-Tl544" & vbCrLf & "https://www.youtube.com/watch?v=1GS7wxWPaxc"

        TextBox1.Text = "https://www.youtube.com/watch?v=eKaD_-Tl544"


        'timer.Interval = 2000
        'AddHandler timer.Elapsed, New ElapsedEventHandler(AddressOf TimerElapsed)

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)

    '    'Dim lista = TextBox1.Text.Split(vbCrLf)



    '    'For i As Integer = 0 To lista.Count - 1

    '    '    'lista(i)

    '    '    almacen.Add(New WebBrowser)

    '    '    Me.Controls.Add(almacen(i))
    '    '    almacen(i).BringToFront()
    '    '    'wb.Navigate("www.google.com")
    '    '    almacen(i).ScriptErrorsSuppressed = True
    '    '    almacen(i).Width = 100
    '    '    almacen(i).Height = 100

    '    '    If i = 0 Then
    '    '        CType(almacen(i), WebBrowser).Location = (New Point(668, 12))
    '    '    End If



    '    '    Dim lnkVideo = lista(i)

    '    '    Dim linkActual = lnkVideo.ToString.Replace("https://www.youtube.com/watch?v=", "https://www.y2mate.com/es/youtube/")

    '    '    almacen(i).Navigate(linkActual)


    '    'Next






    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)

    '    ''1º paso
    '    'almacen(0).Document.GetElementById("process_mp3_a").InvokeMember("click")

    '    ''2º paso

    '    'Dim paginaString = almacen(0).Document.GetElementById("process-result").InnerHtml

    '    'paginaString = "<padre> " & paginaString & " </padre>"
    '    'paginaString = paginaString.Replace("&nbsp;", "")

    '    'If paginaString <> "<padre>  </padre>" Then

    '    '    Dim doc As New XmlDocument()
    '    '    doc.LoadXml(paginaString)


    '    '    Dim empieza = InStr(paginaString, "http://dl89.y2mate.com/?")

    '    '    Dim tmpCadena AS String = ""

    '    '    For i As Integer = empieza - 1 To paginaString.ToString.Length - 1
    '    '        If paginaString(i) = """" Then
    '    '            Exit For
    '    '        Else
    '    '            tmpCadena += paginaString(i)
    '    '        End If

    '    '    Next








    '    '    'Dim cadena = doc.DocumentElement.ChildNodes(1).ChildNodes(0).OuterXml
    '    '    'cadena = cadena.Replace("""", "*")
    '    '    'cadena = cadena.Replace("<a class=*btn btn-success btn-file* href=*", "")
    '    '    'cadena = cadena.Replace("* rel=*nofollow* type=*button*><i class=*glyphicon glyphicon-download-alt*></i> Descargar .mp3    </a>", "")

    '    '    '3º paso

    '    '    'My.Computer.Network.DownloadFile(cadena, "C:\Users\Apolo\Desktop\" & almacen(0).Document.GetElementsByTagName("b")(0).OuterText & ".mp3")
    '    '    'My.Computer.Network.DownloadFile(cadena, "C:\Users\Apolo\Desktop\" & almacen(0).Document.GetElementsByTagName("b")(0).OuterText & ".mp3", "", "", False, 500, True)
    '    '    'My.Computer.Network.DownloadFile(cadena, "hola.mp3", "", "", False, 500, True)




    '    'End If



    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs)


    '    'Timer1.Start()


    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    '    If parar.ToString = "" Then

    '        Try

    '            '1º paso
    '            web.Document.GetElementById("process_mp3_a").InvokeMember("click")

    '            '2º paso

    '            Dim paginaString = web.Document.GetElementById("process-result").InnerHtml

    '            paginaString = "<padre> " & paginaString & " </padre>"
    '            paginaString = paginaString.Replace("&nbsp;", "")

    '            If paginaString <> "<padre>  </padre>" Then

    '                Dim doc As New XmlDocument()
    '                doc.LoadXml(paginaString)


    '                Dim empieza = InStr(paginaString, "http://dl89.y2mate.com/?")

    '                Dim linkCadena As String = ""

    '                For i As Integer = empieza - 1 To paginaString.ToString.Length - 1
    '                    If paginaString(i) = """" Then
    '                        Exit For
    '                    Else
    '                        linkCadena += paginaString(i)
    '                    End If

    '                Next



    '                almacenGeneral(selector).setAndGetNombre.Text = web.Document.GetElementsByTagName("b")(0).OuterText

    '                ''3º paso

    '                'My.Computer.Network.DownloadFile(linkCadena, "C:\Users\Apolo\Desktop\" & almacen(0).Document.GetElementsByTagName("b")(0).OuterText & ".mp3", "", "", False, 500, True)

    '                parar = "stop"



    '            End If



    '        Catch ex As Exception

    '            'MessageBox.Show("Aún no esta listo el enlace")
    '            Console.WriteLine("Aún no esta listo el enlace  " & ex.ToString)

    '        End Try

    '    Else

    '        Timer1.Stop()

    '        'ProgressBar1.Value = 100

    '        Console.WriteLine("Exitooooo!")

    '        'almacenGeneral(selector).setAndGetBarraDeProgreso.Value = 100
    '        almacenGeneral(selector).setAndGetEstadoDeLaDescarga.Image = My.Resources.allok


    '    End If





    'End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        '#  1 Cargamos los componentes..

        '#Carga la página web....

        'almacenDeNavegadores.Add(New WebBrowser)


        Dim lnkVideo = TextBox1.Text

        Dim linkActual = lnkVideo.ToString.Replace("https://www.youtube.com/watch?v=", "https://www.y2mate.com/es/youtube/")



        Me.Controls.Add(web)
        web.BringToFront()
        'wb.Navigate("www.google.com")
        web.ScriptErrorsSuppressed = True
        web.Width = 300
        web.Height = 300
        web.Location = (New Point(20, 400))


        web.Navigate(linkActual)


        '#Carga los componentes de cada musica a descargar....

        selector = almacenGeneral.Count

        almacenGeneral.Add(New Tarea())


        Panel1.Controls.Add(almacenGeneral(selector).setAndGetcheck)
        Panel1.Controls.Add(almacenGeneral(selector).setAndGetNombre)
        Panel1.Controls.Add(almacenGeneral(selector).setAndGetBarraDeProgreso)
        Panel1.Controls.Add(almacenGeneral(selector).setAndGetEstadoDeLaDescarga)
        Panel1.Controls.Add(almacenGeneral(selector).setAndGetEstadoDeLaDescarga)


        almacenGeneral(selector).setAndGetcheck.Checked = True
        almacenGeneral(selector).setAndGetNombre.Text = "Cancion: " & selector
        almacenGeneral(selector).setAndGetEstadoDeLaDescarga.Image = My.Resources.waiting
        almacenGeneral(selector).setAndGetEstadoDeLaDescarga.SizeMode = PictureBoxSizeMode.StretchImage


        If selector = 0 Then
            almacenGeneral(selector).setAndGetNombre.Location = (New Point(20, 20))
            almacenGeneral(selector).setAndGetEstadoDeLaDescarga.Location = (New Point(200, 5))
            almacenGeneral(selector).setAndGetBarraDeProgreso.Location = (New Point(450, 20))
            almacenGeneral(selector).setAndGetcheck.Location = (New Point(650, 20))
        Else

            almacenGeneral(selector).setAndGetNombre.Location = (New Point(20, almacenGeneral(selector - 1).setAndGetNombre.Location.Y + 50))
            almacenGeneral(selector).setAndGetEstadoDeLaDescarga.Location = (New Point(200, almacenGeneral(selector - 1).setAndGetNombre.Location.Y + 30))
            almacenGeneral(selector).setAndGetBarraDeProgreso.Location = (New Point(450, almacenGeneral(selector - 1).setAndGetNombre.Location.Y + 50))
            almacenGeneral(selector).setAndGetcheck.Location = (New Point(650, almacenGeneral(selector - 1).setAndGetNombre.Location.Y + 50))

        End If




        If selector > 25 Then

            '#Aumentamos el tamaño del panel para que tenga scroll y entren todos los componentes..
            Panel1.Height = Panel1.Height + 20

        End If

        '# 2º Iniciamos la busqueda del link

        '#Inicia la busqueda del link a descargar...
        Timer1.Start()



        'Dim timer As New Timers.Timer(2000)
        'AddHandler timer.Elapsed, New ElapsedEventHandler(AddressOf TimerElapsed)





        'timer.Start()



        '#3 Solo quedar descargar los archivos de musica...



    End Sub

    Sub TimerElapsed(ByVal sender As Object, ByVal e As ElapsedEventArgs)




        'If almacenGeneral(selector).setAndGetHilo Then



        Try

                '1º paso
                web.Document.GetElementById("process_mp3_a").InvokeMember("click")

                '2º paso

                Dim paginaString = web.Document.GetElementById("process-result").InnerHtml

                paginaString = "<padre> " & paginaString & " </padre>"
                paginaString = paginaString.Replace("&nbsp;", "")

                If paginaString <> "<padre>  </padre>" Then

                    Dim doc As New XmlDocument()
                    doc.LoadXml(paginaString)


                    Dim empieza = InStr(paginaString, "http://dl89.y2mate.com/?")

                    Dim linkCadena As String = ""

                    For i As Integer = empieza - 1 To paginaString.ToString.Length - 1
                        If paginaString(i) = """" Then
                            Exit For
                        Else
                            linkCadena += paginaString(i)
                        End If

                    Next



                    almacenGeneral(selector).setAndGetNombre.Text = web.Document.GetElementsByTagName("b")(0).OuterText

                    ''3º paso

                    'My.Computer.Network.DownloadFile(linkCadena, "C:\Users\Apolo\Desktop\" & almacen(0).Document.GetElementsByTagName("b")(0).OuterText & ".mp3", "", "", False, 500, True)
                    'Cancelamos el hilo.
                    'almacenGeneral(selector).setAndGetHilo = False


                    'Timer1.Stop()

                    'ProgressBar1.Value = 100

                    Console.WriteLine("Exitooooo!")

                    'almacenGeneral(selector).setAndGetBarraDeProgreso.Value = 100
                    almacenGeneral(selector).setAndGetEstadoDeLaDescarga.Image = My.Resources.allok




                'timer.Stop()




            End If



            Catch ex As Exception

                'MessageBox.Show("Aún no esta listo el enlace")
                Console.WriteLine("Aún no esta listo el enlace  " & ex.ToString)

            End Try






    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If almacenGeneral(selector).setAndGetHilo Then

            Try

                '1º paso
                web.Document.GetElementById("process_mp3_a").InvokeMember("click")

                '2º paso

                Dim paginaString = web.Document.GetElementById("process-result").InnerHtml

                paginaString = "<padre> " & paginaString & " </padre>"
                paginaString = paginaString.Replace("&nbsp;", "")

                If paginaString <> "<padre>  </padre>" Then

                    Dim doc As New XmlDocument()
                    doc.LoadXml(paginaString)


                    Dim empieza = InStr(paginaString, "http://dl89.y2mate.com/?")

                    Dim linkCadena As String = ""

                    For i As Integer = empieza - 1 To paginaString.ToString.Length - 1
                        If paginaString(i) = """" Then
                            Exit For
                        Else
                            linkCadena += paginaString(i)
                        End If

                    Next



                    almacenGeneral(selector).setAndGetNombre.Text = web.Document.GetElementsByTagName("b")(0).OuterText

                    ''3º paso

                    'My.Computer.Network.DownloadFile(linkCadena, "C:\Users\Apolo\Desktop\" & almacen(0).Document.GetElementsByTagName("b")(0).OuterText & ".mp3", "", "", False, 500, True)
                    'Cancelamos el hilo.
                    'almacenGeneral(selector).setAndGetHilo = False


                    'Timer1.Stop()

                    'ProgressBar1.Value = 100

                    Console.WriteLine("Exitooooo!")

                    'almacenGeneral(selector).setAndGetBarraDeProgreso.Value = 100
                    almacenGeneral(selector).setAndGetEstadoDeLaDescarga.Image = My.Resources.allok

                    almacenGeneral(selector).setAndGetHilo = False


                End If



            Catch ex As Exception

                'MessageBox.Show("Aún no esta listo el enlace")
                Console.WriteLine("Aún no esta listo el enlace  " & ex.ToString)

            End Try

        End If

    End Sub


End Class

