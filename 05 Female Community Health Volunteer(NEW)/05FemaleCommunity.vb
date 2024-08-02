Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class _05FemaleCommunity
    Dim dataSetId As String = "CpNy3fSWa0o" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim jsonData As String = "{" &
    """dataSet"": ""CpNy3fSWa0o""," &
    """completeDate"": ""2024-07-31""," &
    """period"": ""208102""," &
    """orgUnit"": ""aUv4lHwAFh9""," &
    """attributeOptionCombo"": """"," &
    """dataValues"": [" &
    "{" &
    """dataElement"": ""AYPkr75uwtk""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox1.Text & """," &
    """comment"": ""आमा समुहको बैठक बसेको""" &
    "}," &
    "{" &
    """dataElement"": ""nWEjVzYabxb""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox2.Text & """," &
    """comment"": ""गर्भवती महिलालाई भेट गरेको""" &
    "}," &
    "{" &
    """dataElement"": ""VjUyOXbOwK4""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox3.Text & """," &
    """comment"": ""गर्भवती महिलालाई आईरन चक्की वितरण""" &
    "}," &
    "{" &
    """dataElement"": ""WzjbqNgppxu""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox4.Text & """," &
    """comment"": ""मातृ सुरक्षा चक्की खाएको सुनिश्चित""" &
    "}," &
    "{" &
    """dataElement"": ""qMrwlLUqjvZ""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox5.Text & """," &
    """comment"": ""जीवित जन्म भएका शिशु """ &
    "}," &
    "{" &
    """dataElement"": ""KM8WJOfqXie""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox6.Text & """," &
    """comment"": ""मृत जन्म भएका शिशु """ &
    "}," &
    "{" &
    """dataElement"": ""SuVbuGqsBY1""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox7.Text & """," &
    """comment"": ""निसास्सीएको नवजात शिशुको व्यवस्थापन""" &
    "}," &
    "{" &
    """dataElement"": ""bEzUYIQWGAe""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox8.Text & """," &
    """comment"": ""जन्मने बित्तिकै आमाको छातीसंग टासेर राखेको""" &
    "}," &
    "{" &
    """dataElement"": ""HrKXjEzkxgC""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox9.Text & """," &
    """comment"": ""नाभीमा नाभिमलम लगाइएका शिशु""" &
    "}," &
    "{" &
    """dataElement"": ""G4KPD091l1Q""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox10.Text & """," &
    """comment"": ""जन्मेको १ घण्टाभित्र स्तनपान गराएको""" &
    "}," &
    "{" &
    """dataElement"": ""zbyQmvD2eg9""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox11.Text & """," &
    """comment"": ""कम जन्म तौल भएका शिशु (१.५ - < २.५ के.जी.)""" &
    "}," &
    "{" &
    """dataElement"": ""XHJ8keHRytO""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox12.Text & """," &
    """comment"": "" धेरै कम जन्म तौल भएका शिशु (< १.५ के.जी.) """ &
    "}," &
    "{" &
    """dataElement"": ""obTmOIfSlSU""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox13.Text & """," &
    """comment"": "" जन्मेको २४ घण्टा भित्र""" &
    "}," &
    "{" &
    """dataElement"": ""hW9geiK2aVp""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox14.Text & """," &
    """comment"": ""जन्मेको तेस्रो दिन""" &
    "}," &
    "{" &
    """dataElement"": ""Jxbyq0CS8wP""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox15.Text & """," &
    """comment"": ""जन्मेको सातौ दिन""" &
    "}," &
    "{" &
    """dataElement"": ""EwN0uOrOfJv""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox16.Text & """," &
    """comment"": ""भिटामिन ए वितरण गरिएका सुत्केरी महिला""" &
    "}," &
    "{" &
    """dataElement"": ""SkEOOFu6qvF""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox17.Text & """," &
    """comment"": ""कण्डम वितरण गरेको""" &
    "}," &
    "{" &
    """dataElement"": ""OVxTAODPN7V""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox18.Text & """," &
    """comment"": ""पिल्स वितरण गरेको""" &
    "}," &
    "{" &
    """dataElement"": ""pCff3ZBBg7m""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox19.Text & """," &
    """comment"": ""आकस्मिक गर्भनिरोधक चक्की वितरण गरेको डोज""" &
    "}," &
    "{" &
    """dataElement"": ""q2F5TJYQWxY""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox20.Text & """," &
    """comment"": ""आकस्मिक गर्भनिरोधक चक्की वितरण गरेका महिलाको संख्या""" &
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim jsonData As String = "{" &
"""dataSet"": ""CpNy3fSWa0o""," &
"""completeDate"": ""2024-07-31""," &
"""period"": ""208102""," &
"""orgUnit"": ""aUv4lHwAFh9""," &
"""attributeOptionCombo"": """"," &
"""dataValues"": [" &
"{" &
    """dataElement"": ""TRpyDKO2Oha""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox21.Text & """," &
    """comment"": ""गर्भावस्था""" &
    "}," &
    "{" &
    """dataElement"": ""AIsCgxwtpCA""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox22.Text & """," &
    """comment"": ""प्रसुती अवस्था""" &
    "}," &
    "{" &
    """dataElement"": ""rHjBGnfxzP5""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox23.Text & """," &
    """comment"": ""सुत्केरी अवस्था""" &
    "}" &
"]" &
"}"


        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim jsonData As String = "{" &
"""dataSet"": ""CpNy3fSWa0o""," &
"""completeDate"": ""2024-07-31""," &
"""period"": ""208102""," &
"""orgUnit"": ""aUv4lHwAFh9""," &
"""attributeOptionCombo"": """"," &
"""dataValues"": [" &
"{" &
    """dataElement"": ""EsCPjTBWz8T""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox37.Text & """," &
    """comment"": ""हरियो (ह्रष्टपुष्ट)""" &
    "}," &
    "{" &
    """dataElement"": ""C2gBSEWpf3L""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox38.Text & """," &
    """comment"": ""पहेलो (मध्यम शिघ्र कुपोषण)""" &
    "}," &
    "{" &
    """dataElement"": ""hrokHhxMqJA""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox39.Text & """," &
    """comment"": ""रातो: (कडा शिघ्र कुपोषण)""" &
    "}," &
    "{" &
    """dataElement"": ""pTXq7orydD1""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox40.Text & """," &
    """comment"": ""फुकेनास""" &
    "}," &
    "{" &
    """dataElement"": ""Ihx8Sa1A318""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox41.Text & """," &
    """comment"": ""रातो: कडा शिघ्र कुपोषित बच्चा उपचार पछि निको भएको""" &
    "}," &
    "{" &
    """dataElement"": ""j3F7YDajCsv""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox42.Text & """," &
    """comment"": ""रातो: कडा शिघ्र कुपोषित बच्चा उपचार गरिरहँदा पनि तौल वृद्धि नभएको""" &
    "}," &
    "{" &
    """dataElement"": ""EEpOk6EXFMx""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox43.Text & """," &
    """comment"": ""रातो: कडा शिघ्र कुपोषित बच्चा उपचार गर्दा गर्दै स्वास्थ्य संस्था जान छाडेको""" &
    "}" &
"]" &
"}"


        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim jsonData As String = "{" &
"""dataSet"": ""CpNy3fSWa0o""," &
"""completeDate"": ""2024-07-31""," &
"""period"": ""208102""," &
"""orgUnit"": ""aUv4lHwAFh9""," &
"""attributeOptionCombo"": """"," &
"""dataValues"": [" &
 "{" &
    """dataElement"": ""ZHtfBpV3TFw""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox24.Text & """," &
    """comment"": ""२ महिना भन्दा कम (उमेर) ≤ २८ दिन""" &
    "}," &
    "{" &
    """dataElement"": ""eldtJgS46Yn""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox25.Text & """," &
    """comment"": ""२ महिना भन्दा कम (उमेर) २९-५९ दिन""" &
    "}," &
    "{" &
    """dataElement"": ""wpHNwlmEC4I""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox26.Text & """," &
    """comment"": ""स्वासप्रस्वास रोगका जम्मा बिरामी""" &
    "}," &
    "{" &
    """dataElement"": ""VB66omSxCsO""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox27.Text & """," &
    """comment"": ""निमोनिया नभएका बिरामी """ &
    "}," &
    "{" &
    """dataElement"": ""a6xMkNuZsBz""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox28.Text & """," &
    """comment"": ""झाडापखाला भएका बिरामी""" &
    "}," &
    "{" &
    """dataElement"": ""KOtuarB2k4i""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox29.Text & """," &
    """comment"": ""ओ. आर.एस.  र जिंक चक्कीबाट उपचार""" &
    "}," &
    "{" &
    """dataElement"": ""FOSN4tcScrg""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox30.Text & """," &
    """comment"": ""ओ. आर.एस. खर्च (पुरिया)""" &
    "}," &
    "{" &
    """dataElement"": ""VukQeGJiziv""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox31.Text & """," &
    """comment"": ""जिंक चक्की खर्च (चक्की)""" &
    "}," &
    "{" &
    """dataElement"": ""mKVxm9I8am3""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox32.Text & """," &
    """comment"": ""मृत्यु ०-७ दिन""" &
    "}," &
    "{" &
    """dataElement"": ""cAEa1iEK6k6""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox33.Text & """," &
    """comment"": ""मृत्यु ८-२८ दिन""" &
    "}," &
    "{" &
    """dataElement"": ""XS2jGaHKVUo""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox34.Text & """," &
    """comment"": ""मृत्यु २९-५९ दिन""" &
    "}," &
    "{" &
    """dataElement"": ""XRNXPFDNLXV""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox35.Text & """," &
    """comment"": ""मृत्यु २-११ महिना""" &
    "}," &
    "{" &
    """dataElement"": ""zgyDArWkg9p""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox36.Text & """," &
    """comment"": ""मृत्यु १२-५९ महिना""" &
    "}" &
"]" &
"}"


        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub
End Class