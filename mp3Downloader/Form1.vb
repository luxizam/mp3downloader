Imports System.Threading
Imports System.Timers
Imports System.Xml


Public Class Form1

    'Dim WithEvents wb As New WebBrowser

    Dim parar As String = ""
    Dim almacenGeneral As New List(Of Tarea)

    Dim selector As Integer = 0

    Dim web As New WebBrowser()

    'Dim timer As New Timers.Timer()

    Dim contador As Integer = 0



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox1.Text = "https://www.youtube.com/watch?v=eKaD_-Tl544" & vbCrLf & "https://www.youtube.com/watch?v=1GS7wxWPaxc"

        'TextBox1.Text = "https://www.youtube.com/watch?v=eKaD_-Tl544"
        'TextBox1.Text = "https://www.youtube.com/watch?v=fUSwNtLiR_w"


        Me.Controls.Add(web)
        web.BringToFront()
        'wb.Navigate("www.google.com")
        web.ScriptErrorsSuppressed = True
        web.Width = 500
        web.Height = 500
        web.Location = (New Point(20, 300))
        web.Visible = False




    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click

        '#  1 Cargamos los componentes..
        If TextBox1.Text <> "" Then
            '#Carga la página web....
            If Timer1.Enabled = False Then


                Dim lnkVideo = TextBox1.Text

                Dim linkActual = lnkVideo.ToString.Replace("https://www.youtube.com/watch?v=", "https://www.y2mate.com/es/youtube/")

                web.Navigate(linkActual)

                '#Carga los componentes de cada musica a descargar....

                'selector = almacenGeneral.Count

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
                Timer1.Start()


            End If

        End If




    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If almacenGeneral(selector).setAndGetHilo Then

            Try

                If contador = 0 Then
                    '1º paso
                    web.Document.GetElementById("process_mp3_a").InvokeMember("click")

                    contador = contador + 1


                End If




                '2º paso

                If Not IsNothing(web.Document.GetElementById("process-result").InnerHtml) Then

                    'Diagnostics.Debug.WriteLine("hemos entrado!!!! ")

                    Dim paginaString = web.Document.GetElementById("process-result").InnerHtml

                    paginaString = "<padre> " & paginaString & " </padre>"

                    paginaString = paginaString.Replace("&nbsp;", "")



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

                    Console.WriteLine("Exitooooo!")

                    'almacenGeneral(selector).setAndGetBarraDeProgreso.Value = 100
                    almacenGeneral(selector).setAndGetEstadoDeLaDescarga.Image = My.Resources.allok

                    almacenGeneral(selector).setAndGetLinkDescarga = linkCadena



                    almacenGeneral(selector).setAndGetHilo = False


                    Timer1.Stop()

                    selector = selector + 1

                    contador = 0




                End If





            Catch ex As Exception

                'MessageBox.Show("Aún no esta listo el enlace")
                Console.WriteLine("Aún no esta listo el enlace  " & ex.ToString)

            End Try

        End If

    End Sub

    Private Sub btnDescargar_Click(sender As Object, e As EventArgs) Handles btnDescargar.Click


        For i As Integer = 0 To almacenGeneral.Count - 1

            If almacenGeneral(i).setAndGetLinkDescarga <> "" Then



                My.Computer.Network.DownloadFile(almacenGeneral(i).setAndGetLinkDescarga, Environment.CurrentDirectory & "\" & limpiezaDeNombres(almacenGeneral(i).setAndGetNombre.Text) & ".mp3", "", "", True, 5000, True)

            End If

            'Permitir solo caracteres de la a a la z

            Console.WriteLine(almacenGeneral(i).setAndGetLinkDescarga)


        Next





    End Sub

    Public Function limpiezaDeNombres(cadena As String) As String

        Dim cadenaTratada As String = ""

        For i As Integer = 0 To cadena.Length - 1

            If (Asc(cadena(i)) >= 65 AndAlso Asc(cadena(i)) <= 90) OrElse (Asc(cadena(i)) >= 97 AndAlso Asc(cadena(i)) <= 122) Then

                cadenaTratada = cadenaTratada & cadena(i)

            End If

        Next



        Return cadenaTratada



    End Function


End Class

