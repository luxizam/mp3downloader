Imports System.Threading
Imports System.Timers

Public Class Tarea



    Private check As CheckBox
    Private nombre As Label
    Private barraDeProgreso As ProgressBar
    Private estadoDeLaDescarga As PictureBox
    Private hilo As Boolean
    Private linkDescarga As String


    Sub New()
        check = New CheckBox()
        nombre = New Label()
        barraDeProgreso = New ProgressBar()
        estadoDeLaDescarga = New PictureBox()
        hilo = True
    End Sub
    Public Property setAndGetcheck As CheckBox
        Get
            Return check
        End Get
        Set(value As CheckBox)
            check = value
        End Set
    End Property

    Public Property setAndGetNombre As Label
        Get
            Return nombre
        End Get
        Set(value As Label)
            nombre = value
        End Set
    End Property

    Public Property setAndGetBarraDeProgreso As ProgressBar
        Get
            Return barraDeProgreso
        End Get
        Set(value As ProgressBar)
            barraDeProgreso = value
        End Set
    End Property

    Public Property setAndGetEstadoDeLaDescarga As PictureBox
        Get
            Return estadoDeLaDescarga
        End Get
        Set(value As PictureBox)
            estadoDeLaDescarga = value
        End Set
    End Property

    Public Property setAndGetHilo As Boolean
        Get
            Return hilo
        End Get
        Set(value As Boolean)
            hilo = value
        End Set
    End Property


    Public Property setAndGetLinkDescarga As String
        Get
            Return linkDescarga
        End Get
        Set(value As String)
            linkDescarga = value
        End Set
    End Property







End Class
