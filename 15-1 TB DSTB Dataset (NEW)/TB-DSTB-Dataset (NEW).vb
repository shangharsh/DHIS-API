Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq

Public Class TB_DSTB_Dataset__NEW_
    Dim dataSetId As String = "bBX7Ml1HvQ1" 'UID of Dataset
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
    """dataElement"": ""fEqA4AtMjJL""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox1.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""fEqA4AtMjJL""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox2.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""k26RPrXIpoo""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox3.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""k26RPrXIpoo""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox4.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""gN5dGI91IcU""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox5.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""gN5dGI91IcU""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox6.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""Vn2hxlC0kae""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox7.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""Vn2hxlC0kae""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox8.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""VJG7eqFdNFw""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox9.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""VJG7eqFdNFw""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox10.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""GyNhrvFPQaO""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox11.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""GyNhrvFPQaO""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox12.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""wn7uqOYMdca""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox13.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""wn7uqOYMdca""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox14.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""VAT9uMm4nmr""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox15.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""VAT9uMm4nmr""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox16.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""fG4Z9ItolC5""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox17.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""fG4Z9ItolC5""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox18.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""xVkVMUdLQ6I""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox19.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""xVkVMUdLQ6I""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox20.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""PhcKMCuqZhT""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox21.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""PhcKMCuqZhT""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox22.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""hUFnA75Fp9R""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox23.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""hUFnA75Fp9R""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox24.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""RFALSJwSpmd""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox25.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""RFALSJwSpmd""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox26.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""Y1i5hgjTImc""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox27.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""Y1i5hgjTImc""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox28.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""XJQa2rOjh8O""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox29.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""XJQa2rOjh8O""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox30.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""igiGrm5xZlX""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox31.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""igiGrm5xZlX""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox32.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""wfjQWicPkkd""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox33.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""wfjQWicPkkd""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox34.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""GktEjOoQRGM""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox35.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""GktEjOoQRGM""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox36.Text & """," &
    """comment"": ""Male""" &
    "}" &
" ]" &
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
                        'Dim responseObject As Object = JObject.Parse(responseJson)
                        'Dim status As String = responseObject("status").ToString()
                        MsgBox(responseJson)

                    End Using
                End Using
            End Using

        Catch ex As WebException
            ReturnValue = ex.Message
            MsgBox(ReturnValue)

        End Try

        Return ReturnValue
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
    """dataElement"": ""z8yXfZGhKjb""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox37.Text & """," &
    """comment"": ""Self""" &
    "}," &
    "{" &
    """dataElement"": ""NgIbrlasTs7""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox38.Text & """," &
    """comment"": ""Private Sector""" &
    "}," &
    "{" &
    """dataElement"": ""xT5JhL9Vlgw""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox39.Text & """," &
    """comment"": ""Community""" &
    "}," &
    "{" &
    """dataElement"": ""zpFUGFWqf7x""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox40.Text & """," &
    """comment"": ""Contract Investigation""" &
    "}," &
    "{" &
    """dataElement"": ""o6s0CEHA2Hd""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox41.Text & """," &
    """comment"": ""Self""" &
    "}," &
    "{" &
    """dataElement"": ""bRafuLMI4IY""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox42.Text & """," &
    """comment"": ""Private Sector""" &
    "}," &
    "{" &
    """dataElement"": ""kYKaEXgfA2A""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox43.Text & """," &
    """comment"": ""Community""" &
    "}," &
    "{" &
    """dataElement"": ""zwqIUcfRvho""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox44.Text & """," &
    """comment"": ""Contract Investigation""" &
    "}," &
    "{" &
    """dataElement"": ""sYWPQXJRo8x""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox45.Text & """," &
    """comment"": ""Self""" &
    "}," &
    "{" &
    """dataElement"": ""GNcinvUQTCs""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox46.Text & """," &
    """comment"": ""Private Sector""" &
    "}," &
    "{" &
    """dataElement"": ""h35XmoOywiG""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox47.Text & """," &
    """comment"": ""Community""" &
    "}," &
    "{" &
    """dataElement"": ""mClVAcO2cNs""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox48.Text & """," &
    """comment"": ""Contract Investigation""" &
    "}" &
"]" &
    "}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""uPMXAv639Yo""," &
    """value"": """ & TextBox49.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""T56A8QfMXHb""," &
    """value"": """ & TextBox50.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""j2ZDR093N6j""," &
    """value"": """ & TextBox51.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""vmp37WoeKZv""," &
    """value"": """ & TextBox52.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""tuIu2TU5p9e""," &
    """value"": """ & TextBox53.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""B7YBqKMl7zr""," &
    """value"": """ & TextBox54.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""YNCXGb0JmV9""," &
    """value"": """ & TextBox55.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""QfB5qFpu4O7""," &
    """value"": """ & TextBox56.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""K51gLdainyZ""," &
    """value"": """ & TextBox57.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""O70A1j8ludR""," &
    """value"": """ & TextBox58.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""HdYFfluvlDn""," &
    """value"": """ & TextBox59.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""PYlQXCF5olM""," &
    """value"": """ & TextBox60.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""SmohFfUa5nE""," &
    """value"": """ & TextBox61.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""S2oueQaMp2F""," &
    """value"": """ & TextBox62.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""fQIm42mXlnH""," &
    """value"": """ & TextBox63.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""qXjmxznKsJ6""," &
    """categoryOptionCombo"": ""v4br0jd2BbD""," &
    """value"": """ & TextBox64.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""uPMXAv639Yo""," &
    """value"": """ & TextBox65.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""T56A8QfMXHb""," &
    """value"": """ & TextBox66.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""j2ZDR093N6j""," &
    """value"": """ & TextBox67.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""vmp37WoeKZv""," &
    """value"": """ & TextBox68.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""tuIu2TU5p9e""," &
    """value"": """ & TextBox69.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""B7YBqKMl7zr""," &
    """value"": """ & TextBox70.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""YNCXGb0JmV9""," &
    """value"": """ & TextBox71.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""QfB5qFpu4O7""," &
    """value"": """ & TextBox72.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""K51gLdainyZ""," &
    """value"": """ & TextBox73.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""O70A1j8ludR""," &
    """value"": """ & TextBox74.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""HdYFfluvlDn""," &
    """value"": """ & TextBox75.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""PYlQXCF5olM""," &
    """value"": """ & TextBox76.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""SmohFfUa5nE""," &
    """value"": """ & TextBox77.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""S2oueQaMp2F""," &
    """value"": """ & TextBox78.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""fQIm42mXlnH""," &
    """value"": """ & TextBox79.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""wd0uCW9jjbR""," &
    """categoryOptionCombo"": ""v4br0jd2BbD""," &
    """value"": """ & TextBox80.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""uPMXAv639Yo""," &
    """value"": """ & TextBox81.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""T56A8QfMXHb""," &
    """value"": """ & TextBox82.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""j2ZDR093N6j""," &
    """value"": """ & TextBox83.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""vmp37WoeKZv""," &
    """value"": """ & TextBox84.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""tuIu2TU5p9e""," &
    """value"": """ & TextBox85.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""B7YBqKMl7zr""," &
    """value"": """ & TextBox86.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""YNCXGb0JmV9""," &
    """value"": """ & TextBox87.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""QfB5qFpu4O7""," &
    """value"": """ & TextBox88.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""K51gLdainyZ""," &
    """value"": """ & TextBox89.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""O70A1j8ludR""," &
    """value"": """ & TextBox90.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""HdYFfluvlDn""," &
    """value"": """ & TextBox91.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""PYlQXCF5olM""," &
    """value"": """ & TextBox92.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""SmohFfUa5nE""," &
    """value"": """ & TextBox93.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""S2oueQaMp2F""," &
    """value"": """ & TextBox94.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""fQIm42mXlnH""," &
    """value"": """ & TextBox95.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""t9JrGeZVIxv""," &
    """categoryOptionCombo"": ""v4br0jd2BbD""," &
    """value"": """ & TextBox96.Text & """," &
    """comment"": ""Male""" &
    "}" &
"]" &
    "}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
    """dataElement"": ""xDJcSmvz8vW""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox97.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""xDJcSmvz8vW""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox98.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""eMLIf9jMIKM""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox99.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""eMLIf9jMIKM""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox100.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""F00MenPgrmV""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox101.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""F00MenPgrmV""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox102.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""XlzKo9SDLG0""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox103.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""XlzKo9SDLG0""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox104.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""tMuD7pYofni""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox105.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""tMuD7pYofni""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox106.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""HAUKhvEoJAb""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox107.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""HAUKhvEoJAb""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox108.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""PIYIZSvIzQZ""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox109.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""PIYIZSvIzQZ""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox110.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""ythwm7ixZeZ""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox111.Text & """," &
    """comment"": ""Female""" &
    "}," &
    "{" &
    """dataElement"": ""ythwm7ixZeZ""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox112.Text & """," &
    """comment"": ""Male""" &
    "}" &
"]" &
    "}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
    """dataElement"": ""TtruMgFsLiU""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox113.Text & """," &
    """comment"": ""Xpert MTB/RIF""" &
    "}," &
    "{" &
    """dataElement"": ""PchPhuJF2nz""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox114.Text & """," &
    """comment"": ""Xpert MTB/RIF""" &
    "}," &
    "{" &
    """dataElement"": ""fr7Fda2yTVy""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox115.Text & """," &
    """comment"": ""Xpert MTB/RIF""" &
    "}," &
    "{" &
    """dataElement"": ""kitCuaUqLOf""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox116.Text & """," &
    """comment"": ""Xpert MTB/RIF""" &
    "}" &
"]" &
    "}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
         Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
    """dataElement"": ""U3Zj0k3A9Wc""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox117.Text & """," &
    """comment"": ""Positive""" &
    "}," &
    "{" &
    """dataElement"": ""JoAheHO9Yly""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox118.Text & """," &
    """comment"": ""Negative""" &
    "}," &
    "{" &
    """dataElement"": ""UKebtYlien4""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox119.Text & """," &
    """comment"": ""ART""" &
    "}," &
    "{" &
    """dataElement"": ""JYRiR4z7PWW""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox120.Text & """," &
    """comment"": ""CPT""" &
    "}," &
    "{" &
    """dataElement"": ""U3Zj0k3A9Wc""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox121.Text & """," &
    """comment"": ""Positive""" &
    "}," &
    "{" &
    """dataElement"": ""JoAheHO9Yly""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox122.Text & """," &
    """comment"": ""Negative""" &
    "}," &
    "{" &
    """dataElement"": ""UKebtYlien4""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox123.Text & """," &
    """comment"": ""ART""" &
    "}," &
    "{" &
    """dataElement"": ""JYRiR4z7PWW""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox124.Text & """," &
    """comment"": ""CPT""" &
    "}"&
"]"&
    "}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
    """dataElement"": ""E1zPl3jgehI""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox125.Text & """," &
    """comment"": ""TB Cases Registered""" &
    "}," &
    "{" &
    """dataElement"": ""qkNLP730xVC""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox126.Text & """," &
    """comment"": ""Patient Smoking Tobacco Current""" &
    "}" &
    "]" &
    "}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub
End Class