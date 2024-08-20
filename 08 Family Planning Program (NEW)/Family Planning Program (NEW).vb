Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq

Public Class Family_Planning_Program__NEW_
    Dim dataSetId As String = "GHm0rmyDFX3" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim jsonData As String =
        "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
        {" &
            """dataElement"": ""XcWK8DnxZgE""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox39.Text & """," &
            """comment"": ""कण्डम -परिमाण """ &
        "}," &
        "{" &
            """dataElement"": ""evmsb1drajw""," &
            """categoryOptionCombo"": ""o6KMyyni9Vl""," &
            """value"": """ & TextBox17.Text & """," &
            """comment"": ""आकस्मिक गर्भनिरोधक चक्की -< २० बर्ष """ &
        "}," &
        "{" &
            """dataElement"": ""evmsb1drajw""," &
            """categoryOptionCombo"": ""UGR7o8AHNH2""," &
            """value"": """ & TextBox23.Text & """," &
            """comment"": ""आकस्मिक गर्भनिरोधक चक्की ≥ २० बर्ष""" &
        "}," &
        "{" &
            """dataElement"": ""CYxbitME5Es""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox40.Text & """," &
            """comment"": ""आकस्मिक गर्भनिरोधक चक्की ---परिमाण""" &
        "}," &
        "{" &
            """dataElement"": ""oCqILrkoRPB""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox18.Text & """," &
            """comment"": ""पिल्स < २० बर्ष """ &
        "}," &
        "{" &
            """dataElement"": ""zUPRuBqSSgY""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox24.Text & """," &
            """comment"": ""पिल्स ≥ २० बर्ष""" &
        "}," &
        "{" &
            """dataElement"": ""Mg77ZuyM6fe""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox29.Text & """," &
            """comment"": ""पिल्स  हाल आपनाई रहेका""" &
        "}," &
        "{" &
            """dataElement"": ""fPdwKS6tcyn""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox34.Text & """," &
            """comment"": ""पिल्स  सेवामा नियमित नभएका """ &
        "}," &
        "{" &
            """dataElement"": ""xcM0TtsUYQr""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox41.Text & """," &
            """comment"": ""पिल्स  परिमाण""" &
        "}," &
        "{" &
            """dataElement"": ""AnmhKKJgX2G""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox19.Text & """," &
            """comment"": ""डिपो < २० बर्ष """ &
        "}," &
        "{" &
            """dataElement"": ""FCqWVnEwIeX""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox25.Text & """," &
            """comment"": ""डिपो ≥ २० बर्ष""" &
        "}," &
        "{" &
            """dataElement"": ""tobLk0FbS9k""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox30.Text & """," &
            """comment"": ""डिपो  हाल आपनाई रहेका""" &
        "}," &
        "{" &
            """dataElement"": ""gn4hsUJEG7c""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox35.Text & """," &
            """comment"": ""डिपो  सेवामा नियमित नभएका """ &
        "}," &
        "{" &
            """dataElement"": ""KuXdIzVAOZ2""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox42.Text & """," &
            """comment"": ""डिपो  परिमाण""" &
        "}," &
        "{" &
            """dataElement"": ""CbNdtgDWXFY""," &
            """categoryOptionCombo"": ""o6KMyyni9Vl""," &
            """value"": """ & TextBox20.Text & """," &
            """comment"": ""सायना प्रेस < २० बर्ष """ &
        "}," &
        "{" &
            """dataElement"": ""CbNdtgDWXFY""," &
            """categoryOptionCombo"": ""UGR7o8AHNH2""," &
            """value"": """ & TextBox26.Text & """," &
            """comment"": ""सायना प्रेस ≥ २० बर्ष""" &
        "}," &
        "{" &
            """dataElement"": ""cbThwNwFptm""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox31.Text & """," &
            """comment"": ""सायना प्रेस  हाल आपनाई रहेका""" &
        "}," &
        "{" &
            """dataElement"": ""XeiCRRePutJ""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox36.Text & """," &
            """comment"": ""सायना प्रेस  सेवामा नियमित नभएका """ &
        "}," &
        "{" &
            """dataElement"": ""j2DNK5W3ywd""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox43.Text & """," &
            """comment"": ""सायना प्रेस  परिमाण""" &
        "}," &
        "{" &
            """dataElement"": ""SujVjgXHP72""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox21.Text & """," &
            """comment"": ""आई. यु. सी. डी. < २० बर्ष """ &
        "}," &
        "{" &
            """dataElement"": ""DwOKj8SLOtF""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox27.Text & """," &
            """comment"": ""आई. यु. सी. डी. ≥ २० बर्ष""" &
        "}," &
        "{" &
            """dataElement"": ""wJ0d4pvhud7""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox32.Text & """," &
            """comment"": ""आई. यु. सी. डी.  हाल आपनाई रहेका""" &
        "}," &
        "{" &
            """dataElement"": ""eeTiOM51Tbq""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox37.Text & """," &
            """comment"": ""आई. यु. सी. डी.  सेवामा नियमित नभएका """ &
        "}," &
        "{" &
            """dataElement"": ""oj5Bk35Tqb7""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox44.Text & """," &
            """comment"": ""आई. यु. सी. डी.  परिमाण""" &
        "}," &
        "{" &
            """dataElement"": ""CuRbZM8HWyR""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox22.Text & """," &
            """comment"": ""इम्प्लान्ट . < २० बर्ष """ &
        "}," &
        "{" &
            """dataElement"": ""d80NCjU1iPK""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox28.Text & """," &
            """comment"": ""इम्प्लान्ट . ≥ २० बर्ष""" &
        "}," &
        "{" &
            """dataElement"": ""vaRoCnJ7Xwl""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox33.Text & """," &
            """comment"": ""इम्प्लान्ट .  हाल आपनाई रहेका""" &
        "}," &
        "{" &
            """dataElement"": ""UGdWSivv6AA""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox38.Text & """," &
            """comment"": ""इम्प्लान्ट .  सेवामा नियमित नभएका """ &
        "}," &
        "{" &
            """dataElement"": ""lAq7cpHVSFT""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox45.Text & """," &
            """comment"": ""इम्प्लान्ट .  परिमाण""" &
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim jsonData As String =
        "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
    """dataElement"": ""A2Tt6FTOdyw""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox46.Text & """," &
    """comment"": ""सरकारी .  महिला""" &
    "}," &
    "{" &
    """dataElement"": ""A2Tt6FTOdyw""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox48.Text & """," &
    """comment"": ""सरकारी .  पुरूष""" &
    "}," &
    "{" &
    """dataElement"": ""DeP1QtNtDxP""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox50.Text & """," &
    """comment"": ""सरकारी .  महिला""" &
    "}," &
    "{" &
    """dataElement"": ""DeP1QtNtDxP""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox52.Text & """," &
    """comment"": ""सरकारी .  पुरूष""" &
    "}," &
    "{" &
    """dataElement"": ""vX8EiOWYa5P""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox47.Text & """," &
    """comment"": ""सरकारी .  महिला""" &
    "}," &
    "{" &
    """dataElement"": ""vX8EiOWYa5P""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox49.Text & """," &
    """comment"": ""सरकारी .  पुरूष""" &
    "}," &
    "{" &
    """dataElement"": ""xHFh1tfpj3g""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox51.Text & """," &
    """comment"": ""सरकारी .  महिला""" &
    "}," &
    "{" &
    """dataElement"": ""xHFh1tfpj3g""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox53.Text & """," &
    """comment"": ""सरकारी .  पुरूष""" &
    "}," &
    "{" &
    """dataElement"": ""lPDmcklspNe""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox54.Text & """," &
    """comment"": "" महिला""" &
    "}," &
    "{" &
    """dataElement"": ""lPDmcklspNe""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox55.Text & """," &
    """comment"": "" पुरूष""" &
    "}" &
"]" &
"}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim jsonData As String =
            "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
        {" &
        """dataElement"": ""uTtWya0epbQ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox56.Text & """," &
        """comment"": ""आई. यु. सी. डी.""" &
        "}," &
        "{" &
        """dataElement"": ""U2Kn6TMzAO3""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox59.Text & """," &
        """comment"": ""इम्प्लान्ट""" &
        "}," &
        "{" &
        """dataElement"": ""hVwCP5NLK04""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox62.Text & """," &
        """comment"": ""ट्युबेक्टोमी""" &
        "}," &
        "{" &
        """dataElement"": ""TDcjn4fUYe0""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox57.Text & """," &
        """comment"": ""आई. यु. सी. डी.""" &
        "}," &
        "{" &
        """dataElement"": ""rvZXMVSJRWu""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox60.Text & """," &
        """comment"": ""इम्प्लान्ट""" &
        "}," &
        "{" &
        """dataElement"": ""lpcjjSZjCZ7""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox63.Text & """," &
        """comment"": ""ट्युबेक्टोमी""" &
        "}," &
        "{" &
        """dataElement"": ""X9JcO8sSMkk""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox58.Text & """," &
        """comment"": ""डिपो.""" &
        "}," &
        "{" &
        """dataElement"": ""RGC1o37Iaya""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox61.Text & """," &
        """comment"": ""सायना प्रेस""" &
        "}," &
        "{" &
        """dataElement"": ""OBSPXEZ0WZ6""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox64.Text & """," &
        """comment"": ""पिल्स""" &
        "}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub
End Class