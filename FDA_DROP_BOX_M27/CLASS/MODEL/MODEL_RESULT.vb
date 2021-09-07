Public Class MODEL_RESULT

    Private _MSG_CODE As String
    Public Property MSG_CODE() As String
        Get
            Return _MSG_CODE
        End Get
        Set(ByVal value As String)
            _MSG_CODE = value
        End Set
    End Property

    Private _MSG_RESULT As String
    Public Property MSG_RESULT() As String
        Get
            Return _MSG_RESULT
        End Get
        Set(ByVal value As String)
            _MSG_RESULT = value
        End Set
    End Property


    Private _MSG_DES As String
    Public Property MSG_DES() As String
        Get
            Return _MSG_DES
        End Get
        Set(ByVal value As String)
            _MSG_DES = value
        End Set
    End Property

    Private _DATA_VALUE As String
    Public Property DATA_VALUE() As String
        Get
            Return _DATA_VALUE
        End Get
        Set(ByVal value As String)
            _DATA_VALUE = value
        End Set
    End Property

    Private _TR_ID As String
    Public Property TR_ID() As String
        Get
            Return _TR_ID
        End Get
        Set(ByVal value As String)
            _TR_ID = value
        End Set
    End Property

    Private _PROCESS As String
    Public Property PROCESS() As String
        Get
            Return _PROCESS
        End Get
        Set(ByVal value As String)
            _PROCESS = value
        End Set
    End Property
End Class
