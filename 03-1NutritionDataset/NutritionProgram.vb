Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class NutritionProgram

    Dim dataSetId As String = "E0Yt8M22QhC" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"

    Private Sub BtnNutriPush_Click(sender As Object, e As EventArgs) Handles BtnNutriPush.Click
        Dim jsonData As String = "{" &
    """dataSet"": """ & dataSetId & """," &
    """completeDate"": """ & todayDate & """," &
    """period"": """ & period & """," &
    """orgUnit"": """ & orgUnitId & """," &
    """attributeOptionCombo"": """"," &
    """dataValues"": [" &
        "{" &
        """dataElement"": ""CaMTpkTWWBZ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox1.Text & """," &
        """comment"": ""सामान्य""" &
        "}," &
        "{" &
        """dataElement"": ""dVs9Txg7Kba""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox2.Text & """," &
        """comment"": ""जोखिम """ &
        "}," &
        "{" &
        """dataElement"": ""OosqBGrHiwW""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox3.Text & """," &
        """comment"": ""अति जोखिम""" &
        "}," &
        "{" &
        """dataElement"": ""BNdVWRrLRKa""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox4.Text & """," &
        """comment"": ""सामान्य """ &
        "}," &
        "{" &
        """dataElement"": ""f60vNZX1J0a""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox5.Text & """," &
        """comment"": ""जोखिम""" &
        "}," &
        "{" &
        """dataElement"": ""EFSOZE2OOFg""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox6.Text & """," &
        """comment"": ""अति जोखिम""" &
        "}," &
        "{" &
        """dataElement"": ""A6kM4WXuZk9""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox7.Text & """," &
        """comment"": ""बृध्दि अनुगमनका लागि दर्ता गरिएका २३ महिना पुरा गरेका जम्मा बालबालिकाको संख्या""" &
        "}," &
        "{" &
        """dataElement"": ""MkQZM247r0b""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox8.Text & """," &
        """comment"": ""बृध्दि अनुगमनका लागि दर्ता गरिएका २३ महिना पुरा गरेका बालबालिकाले तौल लिएको जम्मा पटक""" &
        "}," &
        "{" &
        """dataElement"": ""ejBJjaRprm4""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox9.Text & """," &
        """comment"": ""पहिलो पटक आइरन चक्की """ &
        "}," &
        "{" &
        """dataElement"": ""spKJslN2lrS""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox10.Text & """," &
        """comment"": ""१८० आइरन चक्की""" &
        "}," &
        "{" &
        """dataElement"": ""JFfNeS87bEz""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox11.Text & """," &
        """comment"": ""जुकाको औषधी""" &
        "}," &
        "{" &
        """dataElement"": ""bJNtTf8pEAH""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox12.Text & """," &
        """comment"": ""क्याल्सियम चक्की पाएका महिला""" &
        "}," &
        "{" &
        """dataElement"": ""bAOLmUYdHfP""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox13.Text & """," &
        """comment"": ""४५ आइरन चक्की""" &
        "}," &
        "{" &
        """dataElement"": ""xnojKupd4UW""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox14.Text & """," &
        """comment"": ""भिटामिन ए""" &
        "}," &
        "{" &
        """dataElement"": ""vnlcPlZecpF""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox15.Text & """," &
        """comment"": ""भिटामिन ए ६-११ म.""" &
        "}," &
        "{" &
        """dataElement"": ""bq9k9ObBv5O""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox16.Text & """," &
        """comment"": ""भिटामिन ए १२-५९ म.""" &
        "}," &
        "{" &
        """dataElement"": ""m363PRvwqpZ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox17.Text & """," &
        """comment"": ""जुकाको औषधी""" &
        "}," &
        "{" &
        """dataElement"": ""lUA6rAs6cHJ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox18.Text & """," &
        """comment"": ""छात्रा """ &
        "}," &
        "{" &
        """dataElement"": ""Anq3fiynEpp""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox19.Text & """," &
        """comment"": ""छात्र""" &
        "}," &
        "{" &
        """dataElement"": ""YmHULt1YbW4""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox20.Text & """," &
        """comment"": ""०-११ महिना सामान्य""" &
        "}," &
        "{" &
        """dataElement"": ""X7pKNdTja8U""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox21.Text & """," &
        """comment"": ""०-११ महिना जोखिम """ &
        "}," &
        "{" &
        """dataElement"": ""LJ3B1C9HbzE""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox22.Text & """," &
        """comment"": ""०-११ महिना अति जोखिम""" &
        "}," &
        "{" &
        """dataElement"": ""u5vn6WYT982""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox23.Text & """," &
        """comment"": ""१२-२३ महिना सामान्य""" &
        "}," &
        "{" &
        """dataElement"": ""DeC5yyoMu6v""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox24.Text & """," &
        """comment"": ""१२-२३ महिना जोखिम""" &
        "}," &
        "{" &
        """dataElement"": ""EGnC5n5Q2kP""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox25.Text & """," &
        """comment"": ""१२-२३ महिना अति जोखिम""" &
        "}" &
    "]" &
"}"


        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub
    Public Shared Function SubmitData(ByVal apiUrl As String, ByVal username As String, ByVal password As String, ByVal jsonData As String) As String
        Dim ReturnValue As String = ""
        Dim request As HttpWebRequest = CType(WebRequest.Create(apiUrl), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(username & ":" + password))
        request.Headers(HttpRequestHeader.Authorization) = "Basic " & credentials

        Try

            Using writer As StreamWriter = New StreamWriter(request.GetRequestStream())
                writer.Write(jsonData)
                writer.Flush()
            End Using

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

                Using responseStream As Stream = response.GetResponseStream()

                    Using reader As StreamReader = New StreamReader(responseStream)
                        Dim responseJson As String = reader.ReadToEnd()
                        Dim responseObject As Object = JObject.Parse(responseJson)
                        Dim status As String = responseObject("status").ToString()
                        Dim description As String = responseObject("description").ToString()
                        MsgBox(status & " " & description)

                    End Using
                End Using
            End Using

        Catch ex As WebException
            ReturnValue = ex.Message
            MsgBox(ReturnValue)

        End Try

        Return ReturnValue

    End Function

End Class