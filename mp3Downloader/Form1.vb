Imports System.Threading
Imports System.Xml

Public Class Form1

    'Dim WithEvents wb As New WebBrowser


    'Dim wb As New WebBrowser
    Dim almacen As New ArrayList

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'web.Navigate("https://www.y2mate.com/es/youtube/KSGa-xkS2v0")
        'web.Navigate("https://www.youtube.com")

        TextBox1.Text = "https://www.youtube.com/watch?v=eKaD_-Tl544" & vbCrLf & "https://www.youtube.com/watch?v=1GS7wxWPaxc"

        'Dim wb As New WebBrowser

        'Me.Controls.Add(wb)
        'wb.BringToFront()
        ''wb.Navigate("www.google.com")
        'wb.ScriptErrorsSuppressed = True
        'wb.Width = 700
        'wb.Height = 500


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        almacen.Add(New WebBrowser)

        Me.Controls.Add(almacen(0))
        almacen(0).BringToFront()
        'wb.Navigate("www.google.com")
        almacen(0).ScriptErrorsSuppressed = True
        almacen(0).Width = 700
        almacen(0).Height = 500


        Dim listaDeVideos = TextBox1.Text.Split(vbCrLf)(0)

        Dim linkActual = listaDeVideos.ToString.Replace("https://www.youtube.com/watch?v=", "https://www.y2mate.com/es/youtube/")

        almacen(0).Navigate(linkActual)

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Try

            'Get all components.

            'Dim a = Form1.

            '1º paso
            almacen(0).Document.GetElementById("process_mp3_a").InvokeMember("click")

            '2º paso

            Dim paginaString = almacen(0).Document.GetElementById("process-result").InnerHtml

            paginaString = "<padre> " & paginaString & " </padre>"
            paginaString = paginaString.Replace("&nbsp;", "")
            Dim doc As New XmlDocument()
            doc.LoadXml(paginaString)

            Dim cadena = doc.DocumentElement.ChildNodes(1).ChildNodes(0).OuterXml
            cadena = cadena.Replace("""", "*")
            cadena = cadena.Replace("<a class=*btn btn-success btn-file* href=*", "")
            cadena = cadena.Replace("* rel=*nofollow* type=*button*><i class=*glyphicon glyphicon-download-alt*></i> Descargar .mp3    </a>", "")


            '3º paso

            My.Computer.Network.DownloadFile(cadena, "C:\Users\Apolo\Desktop\" & almacen(0).Document.GetElementsByTagName("b")(0).OuterText & ".mp3")


        Catch ex As Exception

            MessageBox.Show("Aún no esta listo el enlace")

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim lista = TextBox1.Text.Split(vbCrLf)



        For i As Integer = 0 To lista.Count - 1

            'lista(i)

            almacen.Add(New WebBrowser)

            Me.Controls.Add(almacen(i))
            almacen(i).BringToFront()
            'wb.Navigate("www.google.com")
            almacen(i).ScriptErrorsSuppressed = True
            almacen(i).Width = 700
            almacen(i).Height = 500

            If i = 0 Then
                CType(almacen(i), WebBrowser).Location = (New Point(668, 12))
            End If



            Dim lnkVideo = lista(i)

            Dim linkActual = lnkVideo.ToString.Replace("https://www.youtube.com/watch?v=", "https://www.y2mate.com/es/youtube/")

            almacen(i).Navigate(linkActual)


        Next






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim lista = TextBox1.Text.Split(vbCrLf)



        For i As Integer = 0 To lista.Count - 1



            Try





                '1º paso
                almacen(i).Document.GetElementById("process_mp3_a").InvokeMember("click")

                '2º paso

                Dim paginaString = almacen(i).Document.GetElementById("process-result").InnerHtml

                paginaString = "<padre> " & paginaString & " </padre>"
                paginaString = paginaString.Replace("&nbsp;", "")
                Dim doc As New XmlDocument()
                doc.LoadXml(paginaString)

                Dim cadena = doc.DocumentElement.ChildNodes(1).ChildNodes(0).OuterXml
                cadena = cadena.Replace("""", "*")
                cadena = cadena.Replace("<a class=*btn btn-success btn-file* href=*", "")
                cadena = cadena.Replace("* rel=*nofollow* type=*button*><i class=*glyphicon glyphicon-download-alt*></i> Descargar .mp3    </a>", "")


                '3º paso

                My.Computer.Network.DownloadFile(cadena, "C:\Users\Apolo\Desktop\" & almacen(i).Document.GetElementsByTagName("b")(0).OuterText & ".mp3")


            Catch ex As Exception

                'MessageBox.Show("Aún no esta listo el enlace")

            End Try





        Next



    End Sub



End Class

