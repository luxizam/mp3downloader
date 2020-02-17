Imports System.Threading
Imports System.Timers
Imports System.Xml

Public Class Form1

    'Dim WithEvents wb As New WebBrowser

    Dim parar As String = ""
    Dim almacenGeneral As New List(Of Tarea)

    Dim selector As Integer = 0
    Dim web As New WebBrowser()

    Dim timer As New Timers.Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox1.Text = "https://www.youtube.com/watch?v=eKaD_-Tl544" & vbCrLf & "https://www.youtube.com/watch?v=1GS7wxWPaxc"

        TextBox1.Text = "https://www.youtube.com/watch?v=eKaD_-Tl544"

        web.Visible = False
        'timer.Interval = 2000
        'AddHandler timer.Elapsed, New ElapsedEventHandler(AddressOf TimerElapsed)

    End Sub

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


                    Dim empieza = InStr(paginaString, "http:")

                    Dim linkCadena As String = ""

                    For i As Integer = empieza - 1 To paginaString.ToString.Length - 1
                        If paginaString(i) = """" Then
                            Exit For
                        Else
                            linkCadena += paginaString(i)
                        End If

                    Next



                    almacenGeneral(selector).setAndGetNombre.Text = web.Document.GetElementsByTagName("b")(0).OuterText & ".mp3"

                    ''3º paso

                    'My.Computer.Network.DownloadFile(linkCadena, "C:\Users\Apolo\Desktop\" & almacen(0).Document.GetElementsByTagName("b")(0).OuterText & ".mp3", "", "", False, 500, True)
                    'Cancelamos el hilo.
                    'almacenGeneral(selector).setAndGetHilo = False


                    'Timer1.Stop()

                    'ProgressBar1.Value = 100

                    Console.WriteLine("Exitooooo!")

                    'almacenGeneral(selector).setAndGetBarraDeProgreso.Value = 100
                    almacenGeneral(selector).setAndGetEstadoDeLaDescarga.Image = My.Resources.allok

                    almacenGeneral(selector).setAndGetLinkDescarga = linkCadena



                    almacenGeneral(selector).setAndGetHilo = False


                    Timer1.Stop()


                End If



            Catch ex As Exception

                'MessageBox.Show("Aún no esta listo el enlace")
                Console.WriteLine("Aún no esta listo el enlace  " & ex.ToString)

            End Try

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        For i As Integer = 0 To almacenGeneral.Count - 1



            My.Computer.Network.DownloadFile(almacenGeneral(i).setAndGetLinkDescarga, "C:\Users\Apolo\Desktop\" & almacenGeneral(i).setAndGetNombre.Text, "", "", True, 5000, True)



            Console.WriteLine(almacenGeneral(i).setAndGetLinkDescarga)




        Next





    End Sub
End Class

