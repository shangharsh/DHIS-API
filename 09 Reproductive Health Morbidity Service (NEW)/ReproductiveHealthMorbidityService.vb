Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq
Public Class ReproductiveHealthMorbidityService
    Dim dataSetId As String = "M2GN3nbmgh2" 'UID of Dataset
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
        """dataElement"": ""w2LEXzy1YaO""," &
        """categoryOptionCombo"": ""yChOB6JeYN0""," &
        """value"": """ & TextBox1.Text & """," &
        """comment"": ""३०-४९ बर्षका महिलाको संख्या -Screened""" &
    "}," &
    "{" &
        """dataElement"": ""qLC78KRszQp""," &
        """categoryOptionCombo"": ""yChOB6JeYN0""," &
        """value"": """ & TextBox3.Text & """," &
        """comment"": ""३०-४९ बर्षका महिलाको संख्या -Positive""" &
    "}," &
    "{" &
        """dataElement"": ""w2LEXzy1YaO""," &
        """categoryOptionCombo"": ""PnfuqWPvwJR""," &
        """value"": """ & TextBox5.Text & """," &
        """comment"": ""३०-४९ बर्षका महिलाको संख्या -Screened""" &
    "}," &
    "{" &
        """dataElement"": ""qLC78KRszQp""," &
        """categoryOptionCombo"": ""PnfuqWPvwJR""," &
        """value"": """ & TextBox7.Text & """," &
        """comment"": ""३०-४९ बर्षका महिलाको संख्या -Positive""" &
    "}," &
    "{" &
        """dataElement"": ""w2LEXzy1YaO""," &
        """categoryOptionCombo"": ""LGOgLIqjYAq""," &
        """value"": """ & TextBox9.Text & """," &
        """comment"": ""३०-४९ बर्षका महिलाको संख्या -Screened""" &
    "}," &
    "{" &
        """dataElement"": ""qLC78KRszQp""," &
        """categoryOptionCombo"": ""LGOgLIqjYAq""," &
        """value"": """ & TextBox11.Text & """," &
        """comment"": ""३०-४९ बर्षका महिलाको संख्या -Positive""" &
    "}," &
    "{" &
        """dataElement"": ""XTueZo6p2U6""," &
        """categoryOptionCombo"": ""yChOB6JeYN0""," &
        """value"": """ & TextBox2.Text & """," &
        """comment"": ""५० बर्ष भन्दा माथिका महिलाको संख्या -Screened""" &
    "}," &
    "{" &
        """dataElement"": ""v5q6QifR6ek""," &
        """categoryOptionCombo"": ""yChOB6JeYN0""," &
        """value"": """ & TextBox4.Text & """," &
        """comment"": ""५० बर्ष भन्दा माथिका महिलाको संख्या -Positive""" &
    "}," &
    "{" &
        """dataElement"": ""XTueZo6p2U6""," &
        """categoryOptionCombo"": ""PnfuqWPvwJR""," &
        """value"": """ & TextBox6.Text & """," &
        """comment"": ""५० बर्ष भन्दा माथिका महिलाको संख्या -Screened""" &
    "}," &
    "{" &
        """dataElement"": ""v5q6QifR6ek""," &
        """categoryOptionCombo"": ""PnfuqWPvwJR""," &
        """value"": """ & TextBox8.Text & """," &
        """comment"": ""५० बर्ष भन्दा माथिका महिलाको संख्या -Positive""" &
    "}," &
    "{" &
        """dataElement"": ""XTueZo6p2U6""," &
        """categoryOptionCombo"": ""LGOgLIqjYAq""," &
        """value"": """ & TextBox10.Text & """," &
        """comment"": ""५० बर्ष भन्दा माथिका महिलाको संख्या -Screened""" &
    "}," &
    "{" &
        """dataElement"": ""v5q6QifR6ek""," &
        """categoryOptionCombo"": ""LGOgLIqjYAq""," &
        """value"": """ & TextBox12.Text & """," &
        """comment"": ""५० बर्ष भन्दा माथिका महिलाको संख्या -Positive""" &
    "}," &
    "{" &
        """dataElement"": ""AdBRm3v8me0""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox30.Text & """," &
        """comment"": ""Ablative Treatment गराएको (संख्यामा)""" &
    "}," &
    "{" &
        """dataElement"": ""ouztGuLeeev""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox13.Text & """," &
        """comment"": ""Colposcopy (संख्यामा)""" &
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
                        'Dim status As String = responseObject(responseObject).ToString()

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
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
        """dataElement"": ""SiBcMWmvDO3""," &
        """categoryOptionCombo"": ""Fo5nxKCmZOV""," &
        """value"": """ & TextBox14.Text & """," &
        """comment"": ""Screened -< ४० बर्ष""" &
    "}," &
    "{" &
        """dataElement"": ""SiBcMWmvDO3""," &
        """categoryOptionCombo"": ""VeoHzvhwKIG""," &
        """value"": """ & TextBox16.Text & """," &
        """comment"": ""Screened ४०-७० बर्ष""" &
    "}," &
    "{" &
        """dataElement"": ""SiBcMWmvDO3""," &
        """categoryOptionCombo"": ""INhdaAUf4lM""," &
        """value"": """ & TextBox18.Text & """," &
        """comment"": ""Screened > ७० बर्ष""" &
    "}," &
    "{" &
        """dataElement"": ""HmAlzd9hhmx""," &
        """categoryOptionCombo"": ""Fo5nxKCmZOV""," &
        """value"": """ & TextBox15.Text & """," &
        """comment"": ""Suspected -< ४० बर्ष""" &
    "}," &
    "{" &
        """dataElement"": ""HmAlzd9hhmx""," &
        """categoryOptionCombo"": ""VeoHzvhwKIG""," &
        """value"": """ & TextBox17.Text & """," &
        """comment"": ""Suspected ४०-७० बर्ष""" &
    "}," &
    "{" &
        """dataElement"": ""HmAlzd9hhmx""," &
        """categoryOptionCombo"": ""INhdaAUf4lM""," &
        """value"": """ & TextBox19.Text & """," &
        """comment"": ""Suspected > ७० बर्ष""" &
    "}" &
"]" &
    "}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
        """dataElement"": ""lZr0bVedm0C""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox20.Text & """," &
        """comment"": ""Screened""" &
    "}," &
    "{" &
        """dataElement"": ""dO0N8H6SreT""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox22.Text & """," &
        """comment"": ""Referred""" &
    "}," &
    "{" &
        """dataElement"": ""cl5Vv5WH3GZ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox21.Text & """," &
        """comment"": ""Suspected""" &
    "}," &
    "{" &
        """dataElement"": ""iERN2hbZoAE""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox31.Text & """," &
        """comment"": ""शल्यक्रिया गरेको""" &
    "}" &
"]" &
    "}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
{" &
        """dataElement"": ""xhqWR2N1PkK""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox23.Text & """," &
        """comment"": ""Screened """ &
    "}," &
    "{" &
        """dataElement"": ""J0v6kLG2aZs""," &
        """categoryOptionCombo"": ""qFaswBhzzoJ""," &
        """value"": """ & TextBox24.Text & """," &
        """comment"": ""Prolpase पत्ता लागेको Stage 1 & 2""" &
    "}," &
    "{" &
        """dataElement"": ""J0v6kLG2aZs""," &
        """categoryOptionCombo"": ""jnXnfb9ak5x""," &
        """value"": """ & TextBox25.Text & """," &
        """comment"": ""Prolpase पत्ता लागेको Stage 3""" &
    "}," &
    "{" &
        """dataElement"": ""J0v6kLG2aZs""," &
        """categoryOptionCombo"": ""bGHbygvulZY""," &
        """value"": """ & TextBox26.Text & """," &
        """comment"": ""Prolpase पत्ता लागेको Stage 4 """ &
    "}," &
    "{" &
        """dataElement"": ""qWu3Bw1vouH""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox27.Text & """," &
        """comment"": ""Ring pessary लगाईएको """ &
    "}," &
    "{" &
        """dataElement"": ""bX4gzByk17o""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox28.Text & """," &
        """comment"": ""प्रेषण गरेको""" &
    "}," &
    "{" &
        """dataElement"": ""z4abOmsnsux""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox29.Text & """," &
        """comment"": ""शल्यक्रिया गरेको""" &
    "}" &
"]" &
   "}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub
End Class