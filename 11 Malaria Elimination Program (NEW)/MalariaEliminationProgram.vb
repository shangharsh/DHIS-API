Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq
Public Class MalariaEliminationProgram
    Dim dataSetId As String = "pt4kLYs9rVj" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
        """dataElement"": ""TOmDTWpqffE""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox1.Text & """," &
        """comment"": ""ACD """ &
    "}," &
    "{" &
        """dataElement"": ""QOKP6s57dcM""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox2.Text & """," &
        """comment"": ""PCD """ &
    "}," &
    "{" &
        """dataElement"": ""aLtVoncLlGS""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox3.Text & """," &
        """comment"": ""परिक्षण -Microscopy बाट मात्र """ &
    "}," &
    "{" &
        """dataElement"": ""lzlKtOSysRz""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox5.Text & """," &
        """comment"": ""परिक्षण -RDT बाट मात्र  """ &
    "}," &
    "{" &
        """dataElement"": ""PoVX1B5xEGw""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox7.Text & """," &
        """comment"": ""परिक्षण - Microscopy र RDT दुबैबाट """ &
    "}," &
    "{" &
        """dataElement"": ""KFOKPk0SKFq""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox4.Text & """," &
        """comment"": ""पोजेटिभ -Microscopy बाट मात्र """ &
    "}," &
    "{" &
        """dataElement"": ""wX2bCn77pAZ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox6.Text & """," &
        """comment"": ""पोजेटिभ -RDT बाट मात्र  """ &
    "}," &
    "{" &
        """dataElement"": ""sb4e9ccVZEZ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox8.Text & """," &
        """comment"": ""पोजेटिभ - Microscopy र RDT दुबैबाट """ &
    "}," &
    "{" &
        """dataElement"": ""AuXpXOeCbfO""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox9.Text & """," &
        """comment"": ""जम्मा संख्या  """ &
    "}," &
    "{" &
        """dataElement"": ""TaylTYoc07F""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox10.Text & """," &
        """comment"": ""उपचार पाएका मध्ये गर्भवती संख्या""" &
    "}," &
    "{" &
        """dataElement"": ""WJYHFC15fA6""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox11.Text & """," &
        """comment"": ""उपचार पाएका मध्ये गर्भवती संख्या""" &
    "}" &
"]" &
    "}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Public Shared Function SubmitData(ByVal apiUrl, ByVal userName, ByVal passWord, ByVal jsonData)
        Dim ReturnValue As String = ""
        Dim request As HttpWebRequest = CType(WebRequest.Create(apiUrl), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(userName & ":" + passWord))
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