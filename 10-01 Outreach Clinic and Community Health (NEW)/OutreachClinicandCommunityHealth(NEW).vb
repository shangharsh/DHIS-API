Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq

Public Class OutreachClinicandCommunityHealth_NEW_
    Dim dataSetId As String = "efBGIBcySCl" 'UID of Dataset
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
        """dataElement"": ""G3LhqoHfxhv""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox1.Text & """," &
        """comment"": ""प्राथमिक उपचार गरेका """ &
    "}," &
    "{" &
        """dataElement"": ""Eyf5Gkn3Y9j""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox2.Text & """," &
        """comment"": ""०-११ महिना -सामान्य """ &
    "}," &
    "{" &
        """dataElement"": ""O3FP5FMZiHk""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox3.Text & """," &
        """comment"": ""०-११ महिना -जोखिम """ &
    "}," &
    "{" &
        """dataElement"": ""LDGiXGfVRO1""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox4.Text & """," &
        """comment"": ""०-११ महिना -अति जोखिम  """ &
    "}," &
    "{" &
        """dataElement"": ""F381UkDst7i""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox5.Text & """," &
        """comment"": ""१२-२३ महिना -सामान्य """ &
    "}," &
    "{" &
        """dataElement"": ""N2aPjNVGRxK""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox6.Text & """," &
        """comment"": ""१२-२३ महिना -जोखिम """ &
    "}," &
    "{" &
        """dataElement"": ""QfZokURtxfz""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox7.Text & """," &
        """comment"": ""१२-२३ महिना -अति जोखिम """ &
    "}," &
    "{" &
        """dataElement"": ""AmFg04KWFno""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox8.Text & """," &
        """comment"": ""गर्भ जाँच गरेका महिला """ &
    "}," &
    "{" &
        """dataElement"": ""B6OgKkUhpe5""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox9.Text & """," &
        """comment"": ""सुत्केरी जाँच गरेका महिला """ &
    "}," &
    "{" &
        """dataElement"": ""PKj90nRaglb""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox10.Text & """," &
        """comment"": ""जुकाको औषधी पाएका गर्भवति """ &
    "}," &
    "{" &
        """dataElement"": ""S1YXstoZbGN""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox11.Text & """," &
        """comment"": ""जन्मेको ६ महिनासम्म स्तनपान मात्र गराएको """ &
    "}," &
    "{" &
        """dataElement"": ""hkAUC5M7nIQ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox12.Text & """," &
        """comment"": ""६ महिनापछि स्तनपानका साथै ठोस, अर्धठोस र नरम खाना सुरु गरेका """ &
    "}," &
    "{" &
        """dataElement"": ""uoCe6cHZwnx""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox13.Text & """," &
        """comment"": ""आइरन चक्की वितरण गराएको --नयाँ गर्भवती """ &
    "}," &
    "{" &
        """dataElement"": ""BOdlGFIuzJz""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox14.Text & """," &
        """comment"": ""आइरन चक्की वितरण गराएको --दोहोर्याइ आएका """ &
    "}," &
    "{" &
        """dataElement"": ""FxKnFTm6fwc""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox15.Text & """," &
        """comment"": ""आइरन चक्की वितरण गराएको --सुत्केरी महिला  """ &
    "}," &
    "{" &
        """dataElement"": ""mm7gqOgzo8b""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox16.Text & """," &
        """comment"": ""भिटामिन ए पाएका सुत्केरी महिला""" &
    "}," &
    "{" &
        """dataElement"": ""cRDagjiFlVQ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox17.Text & """," &
        """comment"": ""कण्डम गोटा""" &
    "}," &
    "{" &
        """dataElement"": ""uWUt9X4pLeE""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox18.Text & """," &
        """comment"": ""पिल्स जना""" &
    "}," &
    "{" &
        """dataElement"": ""LkrqEnZWEpb""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox19.Text & """," &
        """comment"": ""पिल्स साईकल""" &
    "}," &
    "{" &
        """dataElement"": ""SSbMoJcQAid""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox20.Text & """," &
        """comment"": ""डिपो  डोज""" &
    "}," &
    "{" &
        """dataElement"": ""QAGDdsrckuH""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox21.Text & """," &
        """comment"": ""सायना प्रेस डोज""" &
    "}," &
    "{" &
        """dataElement"": ""EyqFw1wZqva""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox22.Text & """," &
        """comment"": ""आकस्मिक चक्की डोज """ &
    "}," &
    "{" &
        """dataElement"": ""LRbClvpaMOD""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox23.Text & """," &
        """comment"": ""उपचारमा नियमित नभएका बिरामीको खोज गरेको संख्या (क्षयरोग)""" &
    "}," &
    "{" &
        """dataElement"": ""A481oDgQj8q""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox24.Text & """," &
        """comment"": ""रक्त नमुना संकलन गरेको स्लाइड संख्या""" &
    "}," &
    "{" &
        """dataElement"": ""lp0OcKxZDMW""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox25.Text & """," &
        """comment"": ""आमा समुहको वैठकमा भाग लिएको """ &
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