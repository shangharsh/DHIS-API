Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class ImmunizationProgram
    Dim dataSetId As String = "tyPqPw8Y1JA" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"

    Private Sub BtnImmunizationPush_Click(sender As Object, e As EventArgs) Handles BtnImmunizationPush.Click
        Dim jsonData As String = "{" &
  """dataSet"": """ & dataSetId & """," &
  """completeDate"": """ & todayDate & """," &
  """period"": """ & period & """," &
  """orgUnit"": """ & orgUnitId & """," &
  """attributeOptionCombo"": """"," &
  """dataValues"": [" &
  "{" &
    """dataElement"": ""w84aFW1LESM""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox1.Text & """," &
    """comment"": "" बि.सी.जी.(BCG)""" &
  "}," &
  "{" &
    """dataElement"": ""XZZ0Lbe79KT""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox2.Text & """," &
    """comment"": ""रोटा (Rota)-पहिलो""" &
  "}," &
  "{" &
    """dataElement"": ""a6M1cxcfKOC""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox3.Text & """," &
    """comment"": ""रोटा (Rota)-दोस्रो""" &
  "}," &
  "{" &
    """dataElement"": ""j0Bqqi6vw0a""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox4.Text & """," &
    """comment"": ""पोलियो पहिलो""" &
  "}," &
  "{" &
    """dataElement"": ""iIBI3R4j7rR""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox5.Text & """," &
    """comment"": ""पोलियो दोस्रो""" &
  "}," &
  "{" &
    """dataElement"": ""SZXbOZ7nCcT""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox6.Text & """," &
    """comment"": ""पोलियो तेस्रो""" &
  "}," &
  "{" &
    """dataElement"": ""W4MXIx0utSp""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox7.Text & """," &
    """comment"": ""एफ.आई.पि.भी. पहिलो""" &
  "}," &
  "{" &
    """dataElement"": ""HHg41AN9x3a""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox8.Text & """," &
    """comment"": ""एफ.आई.पि.भी. दोस्रो""" &
  "}," &
  "{" &
    """dataElement"": ""F3fBb33oh1c""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox9.Text & """," &
    """comment"": ""पी. सी. भी.  पहिलो""" &
  "}," &
  "{" &
    """dataElement"": ""TkfynUxlyEA""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox10.Text & """," &
    """comment"": ""पी. सी. भी.  दोस्रो""" &
  "}," &
  "{" &
    """dataElement"": ""PZet2gxoVk4""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox11.Text & """," &
    """comment"": ""पी. सी. भी. तेस्रो""" &
  "}," &
  "{" &
    """dataElement"": ""S4NHzUtxuFr""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox12.Text & """," &
    """comment"": ""डी.पी. टी-हेप वि.- हिब. पहिलो""" &
  "}," &
  "{" &
    """dataElement"": ""EWloIcvmV6J""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox13.Text & """," &
    """comment"": "" डी.पी. टी-हेप वि.- हिब. दोस्रो""" &
  "}," &
  "{" &
    """dataElement"": ""BKLqlVqwTX9""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox14.Text & """," &
    """comment"": "" डी.पी. टी-हेप वि.- हिब. तेस्रो""" &
  "}," &
  "{" &
    """dataElement"": ""ZOssey90Zzq""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox15.Text & """," &
    """comment"": ""दादुरा­रुबेला पहिलो """ &
  "}," &
  "{" &
    """dataElement"": ""LLqzacIY1IW""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox16.Text & """," &
    """comment"": ""दादुरा­रुबेला दोस्रो """ &
  "}," &
  "{" &
    """dataElement"": ""ZVZtO6UfQ85""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox17.Text & """," &
    """comment"": ""जे.ई""" &
  "}," &
  "{" &
    """dataElement"": ""lLe3KDDFgjb""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox18.Text & """," &
    """comment"": ""टाईफाईड (TCV)""" &
  "}," &
  "{" &
    """dataElement"": ""PKVJPLDGJip""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox19.Text & """," &
    """comment"": ""२३ म. भित्र पूर्णखोप प्राप्त गरेका बच्चा """ &
  "}," &
  "{" &
    """dataElement"": ""vvjFCmI0DBV""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox20.Text & """," &
    """comment"": ""टि.डी. (गर्भवती महिला) पहिलो""" &
  "}," &
  "{" &
    """dataElement"": ""T6HLuCqpOMn""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox21.Text & """," &
    """comment"": ""टि.डी. (गर्भवती महिला) दोस्रो""" &
  "}," &
  "{" &
    """dataElement"": ""q0XkNvBOqZc""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox22.Text & """," &
    """comment"": ""टि.डी. (गर्भवती महिला) दोस्रो+""" &
  "}," &
  "{" &
    """dataElement"": ""xZReF3UiBCD""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox23.Text & """," &
    """comment"": ""२४ – ५९ म. मा खोप शुरु गरेका बच्चा""" &
  "}," &
  "{" &
    """dataElement"": ""z4wve6VWh78""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox24.Text & """," &
    """comment"": ""AEFI Cases (जनामा) सामान्य""" &
  "}," &
  "{" &
    """dataElement"": ""Yki44AwMmXz""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox25.Text & """," &
    """comment"": ""AEFI Cases (जनामा) गम्भिर""" &
  "}," &
  "{" &
    """dataElement"": ""t9R5Y3uzJTx""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox26.Text & """," &
    """comment"": ""बि.सी.जी.(BCG)""" &
  "}," &
  "{" &
    """dataElement"": ""KamjT3aFCc4""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox27.Text & """," &
    """comment"": ""रोटा (Rota)-पहिलो""" &
  "}," &
   "{" &
        """dataElement"": ""rGLfRwhOjlQ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox28.Text & """," &
        """comment"": ""पोलियो""" &
    "}," &
    "{" &
        """dataElement"": ""hiGYtGNLJtD""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox29.Text & """," &
        """comment"": ""एफ.आई.पि.भी.(FIPV)""" &
    "}," &
    "{" &
        """dataElement"": ""DcEuBApISkR""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox30.Text & """," &
        """comment"": ""पी. सी. भी.""" &
    "}," &
    "{" &
        """dataElement"": ""QtwhOIOxPwA""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox31.Text & """," &
        """comment"": ""डी.पी. टी-हेप वि.- हिब.""" &
    "}," &
    "{" &
        """dataElement"": ""J4hFbjdq6JD""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox32.Text & """," &
        """comment"": ""दादुरा­रुबेला""" &
    "}," &
    "{" &
        """dataElement"": ""Gbg5LIipiRD""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox33.Text & """," &
        """comment"": ""जे.ई""" &
    "}," &
    "{" &
        """dataElement"": ""Ymkoncl0qep""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox34.Text & """," &
        """comment"": ""टाईफाईड (TCV)""" &
    "}," &
    "{" &
        """dataElement"": ""f9FaQ3GKgX0""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox35.Text & """," &
        """comment"": ""टि.डी. (गर्भवती महिला)""" &
    "}," &
    "{" &
        """dataElement"": ""cMxpnkzFYeg""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox36.Text & """," &
        """comment"": ""बि.सी.जी.(BCG)""" &
    "}," &
    "{" &
        """dataElement"": ""envZ4AItikY""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox37.Text & """," &
        """comment"": ""रोटा (Rota)""" &
    "}," &
    "{" &
        """dataElement"": ""jC8CrXFwmUD""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox38.Text & """," &
        """comment"": ""पोलियो""" &
    "}," &
    "{" &
        """dataElement"": ""p3d8kHrTYCX""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox39.Text & """," &
        """comment"": ""एफ.आई.पि.भी.(FIPV)""" &
    "}," &
    "{" &
        """dataElement"": ""fZoKWcz92dn""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox40.Text & """," &
        """comment"": ""पी. सी. भी.""" &
    "}," &
    "{" &
        """dataElement"": ""hqS8h7diCu6""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox41.Text & """," &
        """comment"": ""डी.पी. टी-हेप वि.- हिब.""" &
    "}," &
    "{" &
        """dataElement"": ""TJ9fyMDqUpN""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox42.Text & """," &
        """comment"": ""दादुरा­रुबेला""" &
    "}," &
    "{" &
        """dataElement"": ""rs0OQADW2bj""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox43.Text & """," &
        """comment"": ""जे.ई""" &
    "}," &
    "{" &
        """dataElement"": ""MRlMNDTnxmp""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox44.Text & """," &
        """comment"": ""टाईफाईड (TCV)""" &
    "}," &
    "{" &
        """dataElement"": ""xUD0kVQCGvs""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox45.Text & """," &
        """comment"": ""टि.डी. (गर्भवती महिला)""" &
    "}," &
     "{" &
        """dataElement"": ""UxrWUwkWFTN""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox46.Text & """," &
        """comment"": ""बि.सी.जी.(BCG)""" &
    "}," &
    "{" &
        """dataElement"": ""sCI76IkdZUX""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox47.Text & """," &
        """comment"": ""रोटा (Rota)""" &
    "}," &
    "{" &
        """dataElement"": ""a9rAbH01VaQ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox48.Text & """," &
        """comment"": ""पोलियो""" &
    "}," &
    "{" &
        """dataElement"": ""Xnw28DiqMOa""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox49.Text & """," &
        """comment"": ""एफ.आई.पि.भी.(FIPV)""" &
    "}," &
    "{" &
        """dataElement"": ""fysz9XoNRfT""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox50.Text & """," &
        """comment"": ""पी. सी. भी.""" &
    "}," &
    "{" &
        """dataElement"": ""qeB73HAZP94""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox51.Text & """," &
        """comment"": ""डी.पी. टी-हेप वि.- हिब.""" &
    "}," &
    "{" &
        """dataElement"": ""fdMAev05jId""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox52.Text & """," &
        """comment"": ""दादुरा­रुबेला""" &
    "}," &
    "{" &
        """dataElement"": ""mhF6qCreCd7""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox53.Text & """," &
        """comment"": ""जे.ई""" &
    "}," &
    "{" &
        """dataElement"": ""L6VUmedLlZn""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox54.Text & """," &
        """comment"": ""टाईफाईड (TCV)""" &
    "}," &
    "{" &
        """dataElement"": ""DQjaJxqE0he""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox55.Text & """," &
        """comment"": ""टि.डी. (गर्भवती महिला)""" &
    "}," &
    "{" &
        """dataElement"": ""gxu98NvRyqC""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox56.Text & """," &
        """comment"": ""बि.सी.जी.(BCG)""" &
    "}," &
    "{" &
        """dataElement"": ""zUJ86GbgkFV""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox57.Text & """," &
        """comment"": ""रोटा (Rota)""" &
    "}," &
    "{" &
        """dataElement"": ""SwTOnsmACeX""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox58.Text & """," &
        """comment"": ""पोलियो""" &
    "}," &
    "{" &
        """dataElement"": ""qbc2cQflhWZ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox59.Text & """," &
        """comment"": ""एफ.आई.पि.भी.(FIPV)""" &
    "}," &
    "{" &
        """dataElement"": ""guCDArQSQR9""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox60.Text & """," &
        """comment"": ""पी. सी. भी.""" &
    "}," &
    "{" &
        """dataElement"": ""ldaMw56SZu2""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox61.Text & """," &
        """comment"": ""डी.पी. टी-हेप वि.- हिब.""" &
    "}," &
    "{" &
        """dataElement"": ""sW4PKc7l5fz""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox62.Text & """," &
        """comment"": ""दादुरा­रुबेला""" &
    "}," &
    "{" &
        """dataElement"": ""x7Co1fRAbCV""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox63.Text & """," &
        """comment"": ""जे.ई""" &
    "}," &
    "{" &
        """dataElement"": ""MCr474KVVco""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox64.Text & """," &
        """comment"": ""टाईफाईड (TCV)""" &
    "}," &
    "{" &
        """dataElement"": ""NF7HtjwRAyY""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox65.Text & """," &
        """comment"": ""टि.डी. (गर्भवती महिला)""" &
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
                        Dim status As String = responseObject("status").ToString()
                        Dim description As String = responseObject("description").ToString()
                        MsgBox(status & " " & description)

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