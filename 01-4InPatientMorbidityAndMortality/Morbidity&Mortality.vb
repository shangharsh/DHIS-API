Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class Morbidity_Mortality
    Dim dataSetId As String = "G5TIM3GE43V" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "FVbLQv22YYe" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"

    Private Sub BtnMorbidityPush_Click(sender As Object, e As EventArgs) Handles BtnMorbidityPush.Click
        Dim jsonData As String = "{" &
  """dataSet"": """ & dataSetId & """," &
  """completeDate"": """ & todayDate & """," &
  """period"": """ & period & """," &
  """orgUnit"": """ & orgUnitId & """," &
  """attributeOptionCombo"": """ & attributeOptionCombo & """," &
  """dataValues"": [" &
  "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""fKrPh3mNwuA""," &
    """value"": """ & TextBox1.Text & """," &
    """comment"": ""Inpatient Morbidity 0-7 days Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""AqOY5BvwChr""," &
    """value"": """ & TextBox2.Text & """," &
    """comment"": ""Inpatient Morbidity 0-7 days Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""C1nelEDcfkS""," &
    """value"": """ & TextBox3.Text & """," &
    """comment"": ""Inpatient Morbidity 8-28 days Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""YaaywTY9eKq""," &
    """value"": """ & TextBox4.Text & """," &
    """comment"": ""Inpatient Morbidity 8-28 days Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""MQj7sk1V2Wd""," &
    """value"": """ & TextBox5.Text & """," &
    """comment"": ""Inpatient Morbidity 29Days-1Yr Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""QQt2JrzlZbo""," &
    """value"": """ & TextBox6.Text & """," &
    """comment"": ""Inpatient Morbidity 29Days-1Yr Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""mh3DYEYBSpg""," &
    """value"": """ & TextBox7.Text & """," &
    """comment"": ""Inpatient Morbidity 1-4Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""EkuvSkGwGeG""," &
    """value"": """ & TextBox8.Text & """," &
    """comment"": ""Inpatient Morbidity 1-4Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""ImeluxdRw47""," &
    """value"": """ & TextBox9.Text & """," &
    """comment"": ""Inpatient Morbidity 5-14Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""YF8d9qgfLzR""," &
    """value"": """ & TextBox10.Text & """," &
    """comment"": ""Inpatient Morbidity 5-14Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""lo7vNzsUiBe""," &
    """value"": """ & TextBox11.Text & """," &
    """comment"": ""Inpatient Morbidity 15-19Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""dU1fetpED4w""," &
    """value"": """ & TextBox12.Text & """," &
    """comment"": ""Inpatient Morbidity 15-19Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""miqFgXB82SV""," &
    """value"": """ & TextBox13.Text & """," &
    """comment"": ""Inpatient Morbidity 20-29Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""m05Jven6ovZ""," &
    """value"": """ & TextBox14.Text & """," &
    """comment"": ""Inpatient Morbidity 20-29Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""QOM5Xn9HRRF""," &
    """value"": """ & TextBox15.Text & """," &
    """comment"": ""Inpatient Morbidity 30-39Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""lu1kdcpahOB""," &
    """value"": """ & TextBox16.Text & """," &
    """comment"": ""Inpatient Morbidity 30-39Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""KpJMRZlgWu2""," &
    """value"": """ & TextBox17.Text & """," &
    """comment"": ""Inpatient Morbidity 40-49 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""mpbNAZM7jRI""," &
    """value"": """ & TextBox18.Text & """," &
    """comment"": ""Inpatient Morbidity 40-49 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""C9vCxjeox4h""," &
    """value"": """ & TextBox19.Text & """," &
    """comment"": ""Inpatient Morbidity 50-59 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""XwK3g2awV0e""," &
    """value"": """ & TextBox20.Text & """," &
    """comment"": ""Inpatient Morbidity 50-59 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""VDZFWJbjE7D""," &
    """value"": """ & TextBox21.Text & """," &
    """comment"": ""Inpatient Morbidity 60-69 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""dhIPuVKMinp""," &
    """value"": """ & TextBox22.Text & """," &
    """comment"": ""Inpatient Morbidity 60-69 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""N6V9yOzGjyc""," &
    """value"": """ & TextBox23.Text & """," &
    """comment"": ""Inpatient Morbidity 70 Years Above Female""" &
    "}," &
    "{" &
    """dataElement"": ""M6iIxQ7dWte""," &
    """categoryOptionCombo"": ""PrnAj8Z0mrJ""," &
    """value"": """ & TextBox24.Text & """," &
    """comment"": ""Inpatient Morbidity 70 Years Above Male""" &
    "}" &
  "]" &
  "}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnMortalityPush_Click(sender As Object, e As EventArgs) Handles BtnMortalityPush.Click
        Dim jsonData As String = "{" &
  """dataSet"": """ & dataSetId & """," &
  """completeDate"": """ & todayDate & """," &
  """period"": """ & period & """," &
  """orgUnit"": """ & orgUnitId & """," &
  """attributeOptionCombo"": """ & attributeOptionCombo & """," &
  """dataValues"": [" &
   "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""fKrPh3mNwuA""," &
    """value"": """ & TextBox25.Text & """," &
    """comment"": ""Hospital Mortality 0-7 Days Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""AqOY5BvwChr""," &
    """value"": """ & TextBox26.Text & """," &
    """comment"": ""Hospital Mortality 0-7 Days Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""C1nelEDcfkS""," &
    """value"": """ & TextBox27.Text & """," &
    """comment"": ""Hospital Mortality 8-28 Days Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""YaaywTY9eKq""," &
    """value"": """ & TextBox28.Text & """," &
    """comment"": ""Hospital Mortality 8-28 Days Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""MQj7sk1V2Wd""," &
    """value"": """ & TextBox29.Text & """," &
    """comment"": ""Hospital Mortality 29Days-1Yr Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""QQt2JrzlZbo""," &
    """value"": """ & TextBox30.Text & """," &
    """comment"": ""Hospital Mortality 29Days-1Yr Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""mh3DYEYBSpg""," &
    """value"": """ & TextBox31.Text & """," &
    """comment"": ""Hospital Mortality 1-4 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""EkuvSkGwGeG""," &
    """value"": """ & TextBox32.Text & """," &
    """comment"": ""Hospital Mortality 1-4 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""ImeluxdRw47""," &
    """value"": """ & TextBox33.Text & """," &
    """comment"": ""Hospital Mortality 5-14 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""YF8d9qgfLzR""," &
    """value"": """ & TextBox34.Text & """," &
    """comment"": ""Hospital Mortality 5-14 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""lo7vNzsUiBe""," &
    """value"": """ & TextBox35.Text & """," &
    """comment"": ""Hospital Mortality 15-19 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""dU1fetpED4w""," &
    """value"": """ & TextBox36.Text & """," &
    """comment"": ""Hospital Mortality 15-19 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""miqFgXB82SV""," &
    """value"": """ & TextBox37.Text & """," &
    """comment"": ""Hospital Mortality 20-29 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""m05Jven6ovZ""," &
    """value"": """ & TextBox38.Text & """," &
    """comment"": ""Hospital Mortality 20-29 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""QOM5Xn9HRRF""," &
    """value"": """ & TextBox39.Text & """," &
    """comment"": ""Hospital Mortality 30-39 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""lu1kdcpahOB""," &
    """value"": """ & TextBox40.Text & """," &
    """comment"": ""Hospital Mortality 30-39 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""KpJMRZlgWu2""," &
    """value"": """ & TextBox41.Text & """," &
    """comment"": ""Hospital Mortality 40-49 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""mpbNAZM7jRI""," &
    """value"": """ & TextBox42.Text & """," &
    """comment"": ""Hospital Mortality 40-49 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""C9vCxjeox4h""," &
    """value"": """ & TextBox43.Text & """," &
    """comment"": ""Hospital Mortality 50-59 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""XwK3g2awV0e""," &
    """value"": """ & TextBox44.Text & """," &
    """comment"": ""Hospital Mortality 50-59 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""VDZFWJbjE7D""," &
    """value"": """ & TextBox45.Text & """," &
    """comment"": ""Hospital Mortality 60-69 Years Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""dhIPuVKMinp""," &
    """value"": """ & TextBox46.Text & """," &
    """comment"": ""Hospital Mortality 60-69 Years Male""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""N6V9yOzGjyc""," &
    """value"": """ & TextBox47.Text & """," &
    """comment"": ""Hospital Mortality 70 Years Above Female""" &
    "}," &
    "{" &
    """dataElement"": ""p64v9xIGIg0""," &
    """categoryOptionCombo"": ""PrnAj8Z0mrJ""," &
    """value"": """ & TextBox48.Text & """," &
    """comment"": ""Hospital Mortality 70 Years Above Male""" &
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
End Class