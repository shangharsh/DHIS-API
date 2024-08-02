Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Newtonsoft.Json.Linq
Public Class AcuteMalnutrition
    Dim dataSetId As String = "SQy6hpI5xjp" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"
    Private Sub BtnIMAMPush_Click(sender As Object, e As EventArgs) Handles BtnIMAMPush.Click
        Dim jsonData As String = "{" &
  """dataSet"": """ & dataSetId & """," &
  """completeDate"": """ & todayDate & """," &
  """period"": """ & period & """," &
  """orgUnit"": """ & orgUnitId & """," &
  """attributeOptionCombo"": """"," &
  """dataValues"": [" &
        "{" &
    """dataElement"": ""G7OeIYTd3yO""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox1.Text & """," &
    """comment"": ""६- ५९ महिना गत महिना बालिका मध्यम """ &
  "}," &
  "{" &
    """dataElement"": ""NkHHyxyg29R""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox2.Text & """," &
    """comment"": ""६- ५९ महिना गत महिना बालिका कडा """ &
  "}," &
  "{" &
    """dataElement"": ""XLOwQdun4LI""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox5.Text & """," &
    """comment"": ""६- ५९ महिना नयाँ भर्ना बालिका मध्यम  """ &
  "}," &
  "{" &
    """dataElement"": ""DULm1tEVUqq""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox6.Text & """," &
    """comment"": ""६- ५९ महिना नयाँ भर्ना बालिका कडा  """ &
  "}," &
  "{" &
    """dataElement"": ""KrwFLTq7Gcu""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox9.Text & """," &
    """comment"": ""६- ५९ महिना पुनः भर्ना बालिका मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""ha3JdafbqGN""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox10.Text & """," &
    """comment"": ""६- ५९ महिना पुनः भर्ना बालिका कडा""" &
  "}," &
  "{" &
    """dataElement"": ""CtUt6YSz7gy""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox13.Text & """," &
    """comment"": ""६- ५९ महिना रेफर भई आएका बालिका मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""XZhwcLsbYey""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox14.Text & """," &
    """comment"": ""६- ५९ महिना रेफर भई आएका बालिका कडा""" &
  "}," &
  "{" &
    """dataElement"": ""OTT8KP1nvEn""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox17.Text & """," &
    """comment"": ""६- ५९ महिना निको भएको बालिका मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""CBHBOvWIiOa""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox18.Text & """," &
    """comment"": ""६- ५९ महिना निको भएको बालिका कडा""" &
  "}," &
  "{" &
    """dataElement"": ""S86ikMH8Vyo""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox21.Text & """," &
    """comment"": ""६- ५९ महिना मृत्यू भएको बालिका मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""ZjynfuDXRxg""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox22.Text & """," &
    """comment"": ""६- ५९ महिना मृत्यू भएको बालिका कडा""" &
  "}," &
  "{" &
    """dataElement"": ""T9L9yOBHRwX""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox25.Text & """," &
    """comment"": ""६- ५९ महिना डिफल्टर भएको बालिका मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""hX9W4ZCopCC""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox26.Text & """," &
    """comment"": ""६- ५९ महिना डिफल्टर भएको बालिका कडा""" &
  "}," &
  "{" &
    """dataElement"": ""xNLqc7QcStQ""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox29.Text & """," &
    """comment"": ""६- ५९ महिना निको नभएको बालिका मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""yvcW8AJMl8Q""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox30.Text & """," &
    """comment"": ""६- ५९ महिना निको नभएको बालिका कडा""" &
  "}," &
  "{" &
    """dataElement"": ""s80zN0baqw7""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox33.Text & """," &
    """comment"": ""६- ५९ महिना अस्पतालमा पठाएको  बालिका मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""nF45Bt9Lp8c""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox34.Text & """," &
    """comment"": ""६- ५९ महिना अस्पतालमा पठाएको  बालिका कडा""" &
  "}," &
  "{" &
    """dataElement"": ""VMqHYxsan97""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox37.Text & """," &
    """comment"": ""६- ५९ महिना स्थानान्तरण भइ अन्यत्र गएका  बालिका मध्यम """ &
  "}," &
  "{" &
    """dataElement"": ""uRfdlPKK4Zl""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox38.Text & """," &
    """comment"": ""६- ५९ महिना स्थानान्तरण भइ अन्यत्र गएका  बालिका कडा """ &
  "}," &
  "{" &
    """dataElement"": ""f6gg8ULj6Yd""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox41.Text & """," &
    """comment"": ""६- ५९ महिना महिनाको अन्त्यम जम्मा बालबालिका   बालिका मध्यम  """ &
  "}," &
  "{" &
    """dataElement"": ""KjmPIqw7P7M""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox42.Text & """," &
    """comment"": ""६- ५९ महिना महिनाको अन्त्यम जम्मा बालबालिका   बालिका कडा  """ &
  "}," &
    "{" &
    """dataElement"": ""G7OeIYTd3yO""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox3.Text & """," &
    """comment"": ""६- ५९ महिना गत महिना बालक मध्यम """ &
  "}," &
  "{" &
    """dataElement"": ""NkHHyxyg29R""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox4.Text & """," &
    """comment"": ""६- ५९ महिना गत महिना बालक कडा """ &
  "}," &
  "{" &
    """dataElement"": ""XLOwQdun4LI""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox7.Text & """," &
    """comment"": ""६- ५९ महिना नयाँ भर्ना बालक मध्यम  """ &
  "}," &
  "{" &
    """dataElement"": ""DULm1tEVUqq""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox8.Text & """," &
    """comment"": ""६- ५९ महिना नयाँ भर्ना बालक कडा  """ &
  "}," &
  "{" &
    """dataElement"": ""KrwFLTq7Gcu""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox11.Text & """," &
    """comment"": ""६- ५९ महिना पुनः भर्ना बालक मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""ha3JdafbqGN""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox12.Text & """," &
    """comment"": ""६- ५९ महिना पुनः भर्ना बालक कडा""" &
  "}," &
  "{" &
    """dataElement"": ""CtUt6YSz7gy""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox15.Text & """," &
    """comment"": ""६- ५९ महिना रेफर भई आएका बालक मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""XZhwcLsbYey""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox16.Text & """," &
    """comment"": ""६- ५९ महिना रेफर भई आएका बालक कडा""" &
  "}," &
  "{" &
    """dataElement"": ""OTT8KP1nvEn""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox19.Text & """," &
    """comment"": ""६- ५९ महिना निको भएको बालक मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""CBHBOvWIiOa""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox20.Text & """," &
    """comment"": ""६- ५९ महिना निको भएको बालक कडा""" &
  "}," &
  "{" &
    """dataElement"": ""S86ikMH8Vyo""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox23.Text & """," &
    """comment"": ""६- ५९ महिना मृत्यू भएको बालक मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""ZjynfuDXRxg""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox24.Text & """," &
    """comment"": ""६- ५९ महिना मृत्यू भएको बालक कडा""" &
  "}," &
  "{" &
    """dataElement"": ""T9L9yOBHRwX""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox27.Text & """," &
    """comment"": ""६- ५९ महिना डिफल्टर भएको बालक मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""hX9W4ZCopCC""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox28.Text & """," &
    """comment"": ""६- ५९ महिना डिफल्टर भएको बालक कडा""" &
  "}," &
  "{" &
    """dataElement"": ""xNLqc7QcStQ""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox31.Text & """," &
    """comment"": ""६- ५९ महिना निको नभएको बालक मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""yvcW8AJMl8Q""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox32.Text & """," &
    """comment"": ""६- ५९ महिना निको नभएको बालक कडा""" &
  "}," &
  "{" &
    """dataElement"": ""s80zN0baqw7""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox35.Text & """," &
    """comment"": ""६- ५९ महिना अस्पतालमा पठाएको  बालक मध्यम""" &
  "}," &
  "{" &
    """dataElement"": ""nF45Bt9Lp8c""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox36.Text & """," &
    """comment"": ""६- ५९ महिना अस्पतालमा पठाएको  बालक कडा""" &
  "}," &
  "{" &
    """dataElement"": ""VMqHYxsan97""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox39.Text & """," &
    """comment"": ""६- ५९ महिना स्थानान्तरण भइ अन्यत्र गएका  बालक मध्यम """ &
  "}," &
  "{" &
    """dataElement"": ""uRfdlPKK4Zl""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox40.Text & """," &
    """comment"": ""६- ५९ महिना स्थानान्तरण भइ अन्यत्र गएका  बालक कडा """ &
  "}," &
  "{" &
    """dataElement"": ""f6gg8ULj6Yd""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox43.Text & """," &
    """comment"": ""६- ५९ महिना महिनाको अन्त्यम जम्मा बालबालिका   बालक मध्यम  """ &
  "}," &
  "{" &
    """dataElement"": ""KjmPIqw7P7M""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox44.Text & """," &
    """comment"": ""६- ५९ महिना महिनाको अन्त्यम जम्मा बालबालिका   बालक कडा  """ &
  "}," &
  "{" &
    """dataElement"": ""sJlRE8pCxD8""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox45.Text & """," &
    """comment"": ""< ६ महिना महिना गत महिना बालिका """ &
  "}," &
  "{" &
    """dataElement"": ""GXJ2iH9UQaq""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox47.Text & """," &
    """comment"": ""< ६ महिना महिना नयाँ भर्ना बालिका""" &
  "}," &
  "{" &
    """dataElement"": ""ycIp2mBbTfu""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox49.Text & """," &
    """comment"": ""< ६ महिना महिना पुनः भर्ना बालिका""" &
  "}," &
  "{" &
    """dataElement"": ""Z62U9greQvZ""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox51.Text & """," &
    """comment"": ""< ६ महिना महिना रेफर भई आएका बालिका""" &
  "}," &
  "{" &
    """dataElement"": ""ydW0M6PkpBt""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox53.Text & """," &
    """comment"": ""< ६ महिना महिना निको भएको बालिका""" &
  "}," &
  "{" &
    """dataElement"": ""kj687W8jXg8""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox55.Text & """," &
    """comment"": ""< ६ महिना महिना मृत्यू भएको बालिका""" &
  "}," &
  "{" &
    """dataElement"": ""vqA3rf2MjaZ""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox57.Text & """," &
    """comment"": ""< ६ महिना महिना डिफल्टर भएको बालिका""" &
  "}," &
  "{" &
    """dataElement"": ""PLaEGEei2kj""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox59.Text & """," &
    """comment"": ""< ६ महिना महिना निको नभएको बालिका""" &
  "}," &
  "{" &
    """dataElement"": ""QAgJq8StYNg""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox61.Text & """," &
    """comment"": ""< ६ महिना महिना अस्पतालमा पठाएको  बालिका""" &
  "}," &
  "{" &
    """dataElement"": ""R8po0GOj34q""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox63.Text & """," &
    """comment"": ""< ६ महिना महिना स्थानान्तरण भइ अन्यत्र गएका  बालिका """ &
  "}," &
  "{" &
    """dataElement"": ""uWDx72HqzPB""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox65.Text & """," &
    """comment"": ""< ६ महिना महिना महिनाको अन्त्यम जम्मा बालबालिका   बालिका   """ &
  "}," &
  "{" &
    """dataElement"": ""sJlRE8pCxD8""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox46.Text & """," &
    """comment"": ""< ६ महिना महिना गत महिना बालक """ &
  "}," &
  "{" &
    """dataElement"": ""GXJ2iH9UQaq""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox48.Text & """," &
    """comment"": ""< ६ महिना महिना नयाँ भर्ना बालक""" &
  "}," &
  "{" &
    """dataElement"": ""ycIp2mBbTfu""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox50.Text & """," &
    """comment"": ""< ६ महिना महिना पुनः भर्ना बालक""" &
  "}," &
  "{" &
    """dataElement"": ""Z62U9greQvZ""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox52.Text & """," &
    """comment"": ""< ६ महिना महिना रेफर भई आएका बालक""" &
  "}," &
  "{" &
    """dataElement"": ""ydW0M6PkpBt""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox54.Text & """," &
    """comment"": ""< ६ महिना महिना निको भएको बालक""" &
  "}," &
  "{" &
    """dataElement"": ""kj687W8jXg8""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox56.Text & """," &
    """comment"": ""< ६ महिना महिना मृत्यू भएको बालक""" &
  "}," &
  "{" &
    """dataElement"": ""vqA3rf2MjaZ""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox58.Text & """," &
    """comment"": ""< ६ महिना महिना डिफल्टर भएको बालक""" &
  "}," &
  "{" &
    """dataElement"": ""PLaEGEei2kj""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox60.Text & """," &
    """comment"": ""< ६ महिना महिना निको नभएको बालक""" &
  "}," &
  "{" &
    """dataElement"": ""QAgJq8StYNg""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox62.Text & """," &
    """comment"": ""< ६ महिना महिना अस्पतालमा पठाएको  बालक""" &
  "}," &
  "{" &
    """dataElement"": ""R8po0GOj34q""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox64.Text & """," &
    """comment"": ""< ६ महिना महिना स्थानान्तरण भइ अन्यत्र गएका  बालक""" &
  "}," &
  "{" &
    """dataElement"": ""uWDx72HqzPB""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox66.Text & """," &
    """comment"": ""< ६ महिना महिना महिनाको अन्त्यम जम्मा बालबालिका   बालक""" &
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

    Private Sub BtnBalVitaPush_Click(sender As Object, e As EventArgs) Handles BtnBalVitaPush.Click

        Dim jsonData As String = "{" &
  """dataSet"": """ & dataSetId & """," &
  """completeDate"": """ & todayDate & """," &
  """period"": """ & period & """," &
  """orgUnit"": """ & orgUnitId & """," &
  """attributeOptionCombo"": """"," &
  """dataValues"": [" &
  "{" &
  """dataElement"": ""Uv1mfVzdQPT""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox67.Text & """," &
  """comment"": ""६-११ पहिलो पटक म.स्वा.स्व.से.""" &
"}," &
"{" &
  """dataElement"": ""KEn411yvRWn""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox70.Text & """," &
  """comment"": ""६-११ पहिलो पटक स्वास्थ्य संस्था""" &
"}," &
"{" &
  """dataElement"": ""Z1a49yZVRgK""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox68.Text & """," &
  """comment"": ""१२-१७ पहिलो पटक म.स्वा.स्व.से""" &
"}," &
"{" &
  """dataElement"": ""rOmpUcDVlzL""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox71.Text & """," &
  """comment"": ""१२-१७ पहिलो पटक स्वास्थ्य संस्था""" &
"}," &
"{" &
  """dataElement"": ""Xl1eVNX0C1D""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox73.Text & """," &
  """comment"": ""१२-१७ दोस्रो  पटक म.स्वा.स्व.से""" &
"}," &
"{" &
  """dataElement"": ""ePg9O2Sf1ud""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox75.Text & """," &
  """comment"": ""१२-१७ दोस्रो  पटक स्वास्थ्य संस्था""" &
"}," &
"{" &
  """dataElement"": ""ZZGa9fiBKmc""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox69.Text & """," &
  """comment"": ""१८-२३ पहिलो पटक म.स्वा.स्व.से.""" &
"}," &
"{" &
  """dataElement"": ""hEf5ZsPNANO""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox72.Text & """," &
  """comment"": ""१८-२३ पहिलो पटक स्वास्थ्य संस्था""" &
"}," &
"{" &
  """dataElement"": ""NEFIlX1povw""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox74.Text & """," &
  """comment"": ""१८-२३ दोस्रो  पटक म.स्वा.स्व.से.""" &
"}," &
"{" &
  """dataElement"": ""eAAPGAp3tUO""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox76.Text & """," &
  """comment"": ""१८-२३ दोस्रो  पटक स्वास्थ्य संस्था""" &
"}," &
"{" &
  """dataElement"": ""ZreLpnzs7C2""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox77.Text & """," &
  """comment"": ""१८-२३ तेश्रो पटक म.स्वा.स्व.से.""" &
"}," &
"{" &
  """dataElement"": ""XhRreR7KN4C""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox78.Text & """," &
  """comment"": ""१८-२३ तेश्रो पटक स्वास्थ्य संस्था""" &
"}" &
  "]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)

    End Sub

    Private Sub BtnIYCFPush_Click(sender As Object, e As EventArgs) Handles BtnIYCFPush.Click

        Dim jsonData As String = "{" &
  """dataSet"": """ & dataSetId & """," &
  """completeDate"": """ & todayDate & """," &
  """period"": """ & period & """," &
  """orgUnit"": """ & orgUnitId & """," &
  """attributeOptionCombo"": """"," &
  """dataValues"": [" &
"{" &
  """dataElement"": ""pD6X0nQEiA5""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox79.Text & """," &
  """comment"": ""शिशुलाई जन्मेको ६ महिनासम्म् स्तनपान मात्रै गराएका""" &
"}," &
"{" &
  """dataElement"": ""OvTOZ34zPpv""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox80.Text & """," &
  """comment"": ""समयमै थप आहार खुवाउन शुरु गरेका """ &
"}" &
  "]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)

    End Sub

    Private Sub BtnFortifiedFlourPush_Click(sender As Object, e As EventArgs) Handles BtnFortifiedFlourPush.Click
        Dim jsonData As String = "{" &
"""dataSet"": """ & dataSetId & """," &
"""completeDate"": """ & todayDate & """," &
"""period"": """ & period & """," &
"""orgUnit"": """ & orgUnitId & """," &
"""attributeOptionCombo"": """"," &
"""dataValues"": [" &
"{" &
  """dataElement"": ""ONw97WB7mIl""," &
  """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
  """value"": """ & TextBox81.Text & """," &
  """comment"": ""बालबालिकाको संख्या बालिका""" &
"}," &
"{" &
  """dataElement"": ""ONw97WB7mIl""," &
  """categoryOptionCombo"": ""PflKpozpO7b""," &
  """value"": """ & TextBox82.Text & """," &
  """comment"": ""बालबालिकाको संख्या बालक""" &
"}," &
"{" &
  """dataElement"": ""X3rUpDKY78R""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox83.Text & """," &
  """comment"": ""गर्भवती महिला """ &
"}," &
"{" &
  """dataElement"": ""Qim9iaDMdWM""," &
  """categoryOptionCombo"": ""kdsirVNKdhm""," &
  """value"": """ & TextBox84.Text & """," &
  """comment"": ""सुत्केरी महिला """ &
"}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnTeenHealthPush_Click(sender As Object, e As EventArgs) Handles BtnTeenHealthPush.Click
        Dim jsonData As String = "{" &
"""dataSet"": """ & dataSetId & """," &
"""completeDate"": """ & todayDate & """," &
"""period"": """ & period & """," &
"""orgUnit"": """ & orgUnitId & """," &
"""attributeOptionCombo"": """"," &
"""dataValues"": [" &
"{" &
  """dataElement"": ""fAIu1HT2QhX""," &
  """categoryOptionCombo"": ""TVDJYZVHOA3""," &
  """value"": """ & TextBox85.Text & """," &
  """comment"": ""१३ हप्ता सम्म बिद्यालय""" &
"}," &
"{" &
  """dataElement"": ""fAIu1HT2QhX""," &
  """categoryOptionCombo"": ""xJpnKY3GCn9""," &
  """value"": """ & TextBox87.Text & """," &
  """comment"": ""१३ हप्ता सम्म स्वास्थ्य संस्था""" &
"}," &
"{" &
  """dataElement"": ""fAIu1HT2QhX""," &
  """categoryOptionCombo"": ""l4HICsPowW2""," &
  """value"": """ & TextBox89.Text & """," &
  """comment"": ""१३ हप्ता सम्म म.स्वा.स्व.से""" &
"}," &
"{" &
  """dataElement"": ""N7FlMjWKxuZ""," &
  """categoryOptionCombo"": ""TVDJYZVHOA3""," &
  """value"": """ & TextBox86.Text & """," &
  """comment"": ""२६  हप्ता सम्म बिद्यालय""" &
"}," &
"{" &
  """dataElement"": ""N7FlMjWKxuZ""," &
  """categoryOptionCombo"": ""xJpnKY3GCn9""," &
  """value"": """ & TextBox88.Text & """," &
  """comment"": ""२६  हप्ता सम्म स्वास्थ्य संस्था""" &
"}," &
"{" &
  """dataElement"": ""N7FlMjWKxuZ""," &
  """categoryOptionCombo"": ""l4HICsPowW2""," &
  """value"": """ & TextBox90.Text & """," &
  """comment"": ""२६  हप्ता सम्म म.स्वा.स्व.से""" &
"}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnEducationProPush_Click(sender As Object, e As EventArgs) Handles BtnEducationProPush.Click
        Dim jsonData As String = "{" &
"""dataSet"": """ & dataSetId & """," &
"""completeDate"": """ & todayDate & """," &
"""period"": """ & period & """," &
"""orgUnit"": """ & orgUnitId & """," &
"""attributeOptionCombo"": """"," &
"""dataValues"": [" &
 "{" &
      """dataElement"": ""MaUAAZa363X""," &
      """categoryOptionCombo"": ""ElMW7Aa8aUw""," &
      """value"": """ & TextBox91.Text & """," &
      """comment"": ""सेसन संख्या बिद्यालय""" &
    "}," &
    "{" &
      """dataElement"": ""MaUAAZa363X""," &
      """categoryOptionCombo"": ""GEe6TOlmr7L""," &
      """value"": """ & TextBox93.Text & """," &
      """comment"": ""सेसन संख्या समुदाय""" &
    "}," &
    "{" &
      """dataElement"": ""MaUAAZa363X""," &
      """categoryOptionCombo"": ""Cul6YFCgu7s""," &
      """value"": """ & TextBox95.Text & """," &
      """comment"": ""सेसन संख्या अन्य""" &
    "}," &
    "{" &
      """dataElement"": ""lPT0nBoIhVg""," &
      """categoryOptionCombo"": ""ElMW7Aa8aUw""," &
      """value"": """ & TextBox92.Text & """," &
      """comment"": ""सहभागी  संख्या बिद्यालय""" &
    "}," &
    "{" &
      """dataElement"": ""lPT0nBoIhVg""," &
      """categoryOptionCombo"": ""GEe6TOlmr7L""," &
      """value"": """ & TextBox94.Text & """," &
      """comment"": ""सहभागी  संख्या समुदाय""" &
    "}," &
    "{" &
      """dataElement"": ""lPT0nBoIhVg""," &
      """categoryOptionCombo"": ""Cul6YFCgu7s""," &
      """value"": """ & TextBox96.Text & """," &
      """comment"": ""सहभागी  संख्या अन्य""" &
    "}" &
"]" &
"}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub
End Class