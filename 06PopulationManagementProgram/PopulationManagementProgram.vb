Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class PopulationManagementProgram
    Dim dataSetId As String = "CpNy3fSWa0o" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jsonData As String = "{" &
    """dataSet"": ""CpNy3fSWa0o""," &
    """completeDate"": ""2024-07-31""," &
    """period"": ""208102""," &
    """orgUnit"": ""aUv4lHwAFh9""," &
    """attributeOptionCombo"": """"," &
    """dataValues"": [" &
    "{" &
    """dataElement"": ""Mk5HRapKZ2b""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox1.Text & """," &
    """comment"": ""कार्यक्रम लागू भएको बिद्यालय संख्या""" &
    "}," &
    "{" &
    """dataElement"": ""QUDSHZXTMTx""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox2.Text & """," &
    """comment"": ""प्रतिवेदन गर्ने बिद्यालय संख्या""" &
    "}," &
    "{" &
    """dataElement"": ""fuL3AIl9z3T""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox3.Text & """," &
    """comment"": ""परामर्श पाएका जम्मा संख्या छात्रा""" &
    "}," &
    "{" &
    """dataElement"": ""fuL3AIl9z3T""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox4.Text & """," &
    """comment"": ""परामर्श पाएका जम्मा संख्या छात्र""" &
    "}," &
    "{" &
    """dataElement"": ""uS6eezuke6u""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox5.Text & """," &
    """comment"": ""सूपरिवेक्षण गरिएका विद्यालय संख्या """ &
    "}," &
    "{" &
    """dataElement"": ""hQDRyJx9KdZ""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox6.Text & """," &
    """comment"": ""संचालनमा रहेका सूचना केन्द्र संख्या """ &
    "}" &
    "]}"

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
                        Dim status As String = responseObject("description").ToString()
                        MsgBox(status)

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