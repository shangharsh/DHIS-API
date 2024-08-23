Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq

Public Class KalaazarControlProgram
    Dim dataSetId As String = "wQ7v2W4qwVo" 'UID of Dataset
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
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""fC9QdubWS7J""," &
        """value"": """ & TextBox1.Text & """," &
        """comment"": ""Within District Female""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""Siv2VqcPxM5""," &
        """value"": """ & TextBox4.Text & """," &
        """comment"": ""Within District Male""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""eKxy6tOAhdL""," &
        """value"": """ & TextBox7.Text & """," &
        """comment"": ""Within District Female""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""D3LmlY7aHsn""," &
        """value"": """ & TextBox10.Text & """," &
        """comment"": ""Within District Male""" &
    "}," &
    "{" &
        """dataElement"": ""lZhLpiaG8vG""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox13.Text & """," &
        """comment"": ""RK-39""" &
    "}," &
    "{" &
        """dataElement"": ""hZC8XCdE234""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox16.Text & """," &
        """comment"": ""BM""" &
    "}," &
    "{" &
        """dataElement"": ""vhXdENrBh8N""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox19.Text & """," &
        """comment"": ""SP""" &
    "}," &
    "{" &
        """dataElement"": ""O0ylCjJMMLH""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox22.Text & """," &
        """comment"": ""Other""" &
    "}," &
    "{" &
        """dataElement"": ""NpzwyMp264n""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox25.Text & """," &
        """comment"": ""L, A/ M*""" &
    "}," &
    "{" &
        """dataElement"": ""IDYA3yJwgqM""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox28.Text & """," &
        """comment"": ""Other""" &
    "}," &
    "{" &
        """dataElement"": ""JjUL1bOsvuq""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox31.Text & """," &
        """comment"": ""Female""" &
    "}," &
    "{" &
        """dataElement"": ""JjUL1bOsvuq""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox34.Text & """," &
        """comment"": ""Female""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""UnV1zhHc16P""," &
        """value"": """ & TextBox2.Text & """," &
        """comment"": ""Outside District Female""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""ZZu57qwPvcV""," &
        """value"": """ & TextBox5.Text & """," &
        """comment"": ""Outside District Male""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""zfYUAw14VXT""," &
        """value"": """ & TextBox8.Text & """," &
        """comment"": ""Outside District Female""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""hQn4pn2bwYJ""," &
        """value"": """ & TextBox11.Text & """," &
        """comment"": ""Outside District Male""" &
    "}," &
    "{" &
        """dataElement"": ""ubO6UUS3TXT""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox14.Text & """," &
        """comment"": ""RK-39""" &
    "}," &
    "{" &
        """dataElement"": ""loYDiUMvWgx""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox17.Text & """," &
        """comment"": ""BM""" &
    "}," &
    "{" &
        """dataElement"": ""CoWza8FhfwR""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox20.Text & """," &
        """comment"": ""SP""" &
    "}," &
    "{" &
        """dataElement"": ""QXeSzTxz72n""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox23.Text & """," &
        """comment"": ""Other""" &
    "}," &
    "{" &
        """dataElement"": ""Zk1ymSyYSzC""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox26.Text & """," &
        """comment"": ""L, A/ M*""" &
    "}," &
    "{" &
        """dataElement"": ""yBHoNHEcCuR""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox29.Text & """," &
        """comment"": ""Other""" &
    "}," &
    "{" &
        """dataElement"": ""JmHrJKlAIwQ""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox32.Text & """," &
        """comment"": ""Female""" &
    "}," &
    "{" &
        """dataElement"": ""JmHrJKlAIwQ""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox35.Text & """," &
        """comment"": ""Female""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""Vw0L5uwJazt""," &
        """value"": """ & TextBox3.Text & """," &
        """comment"": ""Foreigner Female""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""njaE7klgjB1""," &
        """value"": """ & TextBox6.Text & """," &
        """comment"": ""Foreigner Male""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""spKmmDGnMzU""," &
        """value"": """ & TextBox9.Text & """," &
        """comment"": ""Foreigner Female""" &
    "}," &
    "{" &
        """dataElement"": ""pvCDKRjZF3S""," &
        """categoryOptionCombo"": ""Ksjz2Pmidc5""," &
        """value"": """ & TextBox12.Text & """," &
        """comment"": ""Foreigner Male""" &
    "}," &
    "{" &
        """dataElement"": ""HWd7LiqNQS0""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox15.Text & """," &
        """comment"": ""RK-39""" &
    "}," &
    "{" &
        """dataElement"": ""TXcAdO9yJWN""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox18.Text & """," &
        """comment"": ""BM""" &
    "}," &
    "{" &
        """dataElement"": ""JfYezSXRBAi""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox21.Text & """," &
        """comment"": ""SP""" &
    "}," &
    "{" &
        """dataElement"": ""JktdCROE9gl""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox24.Text & """," &
        """comment"": ""Other""" &
    "}," &
    "{" &
        """dataElement"": ""DDiORltwpaH""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox27.Text & """," &
        """comment"": ""L, A/ M*""" &
    "}," &
    "{" &
        """dataElement"": ""uMh7L3QDp9H""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox30.Text & """," &
        """comment"": ""Other""" &
    "}," &
    "{" &
        """dataElement"": ""xek318O34bl""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox33.Text & """," &
        """comment"": ""Female""" &
    "}," &
    "{" &
        """dataElement"": ""xek318O34bl""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox36.Text & """," &
        """comment"": ""Male""" &
    "}" &
"]" &
    "}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, JsonData)
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