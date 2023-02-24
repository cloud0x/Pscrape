﻿Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function GetBetween(ByVal Source As String, ByVal Str1 As String, ByVal Str2 As String, Optional ByVal Index As Integer = 0) As String
        Return Regex.Split(Regex.Split(Source, Str1)(Index + 1), Str2)(0)
    End Function

    Private Sub Scrape()

        Try

            Dim strURL As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=socks5&country=all"

            Dim strOutput As String = ""

            Dim wrResponse As WebResponse
            Dim wrRequest As WebRequest = HttpWebRequest.Create(strURL)

            txtScrape.Text = "Extracting..." & Environment.NewLine

            wrResponse = wrRequest.GetResponse()

            Using sr As New StreamReader(wrResponse.GetResponseStream())
                strOutput = sr.ReadToEnd()
                ' Close and clean up the StreamReader
                sr.Close()
            End Using

            txtScrape.Text = strOutput

            'Formatting Techniques

            ' Remove Doctype ( HTML 5 )
            strOutput = Regex.Replace(strOutput, "<!(.|\s)*?>", "")

            ' Remove HTML Tags
            strOutput = Regex.Replace(strOutput, "</?[a-z][a-z0-9]*[^<>]*>", "")

            ' Remove HTML Comments
            strOutput = Regex.Replace(strOutput, "<!--(.|\s)*?-->", "")

            ' Remove Script Tags
            strOutput = Regex.Replace(strOutput, "<script.*?</script>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            ' Remove Stylesheets
            strOutput = Regex.Replace(strOutput, "<style.*?</style>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            txtFormatted2.Text = strOutput 'write Formatted Output To Separate TB


        Catch ex As Exception

            Console.WriteLine(ex.Message, "Error")

        End Try

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Scrape() 'Scrape Text From URL

    End Sub

    Private Sub txtScrape_TextChanged(sender As Object, e As EventArgs) Handles txtScrape.TextChanged

    End Sub

    Private Sub Scrape2()

        Try

            Dim strURL As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=socks4&country=all"

            Dim strOutput As String = ""

            Dim wrResponse As WebResponse
            Dim wrRequest As WebRequest = HttpWebRequest.Create(strURL)

            txtScrape.Text = "Extracting..." & Environment.NewLine

            wrResponse = wrRequest.GetResponse()

            Using sr As New StreamReader(wrResponse.GetResponseStream())
                strOutput = sr.ReadToEnd()
                ' Close and clean up the StreamReader
                sr.Close()
            End Using

            txtScrape.Text = strOutput

            'Formatting Techniques

            ' Remove Doctype ( HTML 5 )
            strOutput = Regex.Replace(strOutput, "<!(.|\s)*?>", "")

            ' Remove HTML Tags
            strOutput = Regex.Replace(strOutput, "</?[a-z][a-z0-9]*[^<>]*>", "")

            ' Remove HTML Comments
            strOutput = Regex.Replace(strOutput, "<!--(.|\s)*?-->", "")

            ' Remove Script Tags
            strOutput = Regex.Replace(strOutput, "<script.*?</script>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            ' Remove Stylesheets
            strOutput = Regex.Replace(strOutput, "<style.*?</style>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            txtFormatted2.Text = strOutput 'write Formatted Output To Separate TB


        Catch ex As Exception

            Console.WriteLine(ex.Message, "Error")

        End Try

    End Sub
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Scrape2()
    End Sub


    Private Sub Scrape3()

        Try

            Dim strURL As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=HTTP&country=all"

            Dim strOutput As String = ""

            Dim wrResponse As WebResponse
            Dim wrRequest As WebRequest = HttpWebRequest.Create(strURL)

            txtScrape.Text = "Extracting..." & Environment.NewLine

            wrResponse = wrRequest.GetResponse()

            Using sr As New StreamReader(wrResponse.GetResponseStream())
                strOutput = sr.ReadToEnd()
                ' Close and clean up the StreamReader
                sr.Close()
            End Using

            txtScrape.Text = strOutput

            'Formatting Techniques

            ' Remove Doctype ( HTML 5 )
            strOutput = Regex.Replace(strOutput, "<!(.|\s)*?>", "")

            ' Remove HTML Tags
            strOutput = Regex.Replace(strOutput, "</?[a-z][a-z0-9]*[^<>]*>", "")

            ' Remove HTML Comments
            strOutput = Regex.Replace(strOutput, "<!--(.|\s)*?-->", "")

            ' Remove Script Tags
            strOutput = Regex.Replace(strOutput, "<script.*?</script>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            ' Remove Stylesheets
            strOutput = Regex.Replace(strOutput, "<style.*?</style>", "", RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            txtFormatted2.Text = strOutput 'write Formatted Output To Separate TB


        Catch ex As Exception

            Console.WriteLine(ex.Message, "Error")

        End Try

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Scrape3()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Close()
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        My.Computer.FileSystem.WriteAllText("C:\PulledLISTS\lst.txt", txtFormatted2.Text, False)
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click

        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuGroupBox1_Enter(sender As Object, e As EventArgs) Handles BunifuGroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtFormatted2_TextChanged(sender As Object, e As EventArgs) Handles txtFormatted2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtFormatted_TextChanged(sender As Object, e As EventArgs) Handles txtFormatted.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
