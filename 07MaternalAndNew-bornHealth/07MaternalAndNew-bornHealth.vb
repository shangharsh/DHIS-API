Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq

Public Class _07MaternalAndNew_bornHealth

    Dim dataSetId As String = "jZ0ClbXLtgz" 'UID of Dataset
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
    """dataElement"": ""C6ubEqEew8X""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox1.Text & """," &
    """comment"": ""पहिलो (जुनसुकै समयको) -< २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""kSnqP4GPOsQ""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox5.Text & """," &
    """comment"": ""पहिलो (जुनसुकै समयको) ≥ २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""vTDKlAOKGjn""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox2.Text & """," &
    """comment"": ""१२ हप्ता सम्म < २० बर्ष """ &
"}," &
"{" &
    """dataElement"": ""ZcrvEPX6AgY""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox6.Text & """," &
    """comment"": ""१२ हप्ता सम्म ≥ २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""RtidqFs7NRc""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox3.Text & """," &
    """comment"": ""४ पटक (१६ ,२०-२४, ३२ र ३६ हप्ता)  < २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""gNcAqChA90J""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox7.Text & """," &
    """comment"": ""४ पटक (१६ ,२०-२४, ३२ र ३६ हप्ता)  ≥ २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""hGW7Z3Y7xzA""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox4.Text & """," &
    """comment"": ""८ पटक (प्रोटोकल अनुसार)  < २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""pvTVo0fTEW1""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox8.Text & """," &
    """comment"": ""८ पटक (प्रोटोकल अनुसार)  ≥ २० बर्ष""" &
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
    """dataElement"": ""T9SHzXzpwnJ""," &
    """categoryOptionCombo"": ""o6KMyyni9Vl""," &
    """value"": """ & TextBox9.Text & """," &
    """comment"": ""दक्ष प्रसुतिकर्मीबाट (SBA trained ANM)  < २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""T9SHzXzpwnJ""," &
    """categoryOptionCombo"": ""UGR7o8AHNH2""," &
    """value"": """ & TextBox13.Text & """," &
    """comment"": ""दक्ष प्रसुतिकर्मीबाट (SBA trained ANM)  ≥ २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""nRDFRYBCiuz""," &
    """categoryOptionCombo"": ""o6KMyyni9Vl""," &
    """value"": """ & TextBox10.Text & """," &
    """comment"": ""दक्ष स्वास्थ्यकर्मीबाट (SHP)  < २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""nRDFRYBCiuz""," &
    """categoryOptionCombo"": ""UGR7o8AHNH2""," &
    """value"": """ & TextBox14.Text & """," &
    """comment"": ""दक्ष स्वास्थ्यकर्मीबाट (SHP)  ≥ २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""NPzEfDEIBBl""," &
    """categoryOptionCombo"": ""o6KMyyni9Vl""," &
    """value"": """ & TextBox11.Text & """," &
    """comment"": ""अन्य स्वास्थ्यकर्मीबाट  < २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""NPzEfDEIBBl""," &
    """categoryOptionCombo"": ""UGR7o8AHNH2""," &
    """value"": """ & TextBox15.Text & """," &
    """comment"": ""अन्य स्वास्थ्यकर्मीबाट  ≥ २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""pgmxB8n1Vv7""," &
    """categoryOptionCombo"": ""o6KMyyni9Vl""," &
    """value"": """ & TextBox12.Text & """," &
    """comment"": ""घरमा प्रसुति संख्या   < २० बर्ष""" &
"}," &
"{" &
    """dataElement"": ""pgmxB8n1Vv7""," &
    """categoryOptionCombo"": ""UGR7o8AHNH2""," &
    """value"": """ & TextBox16.Text & """," &
    """comment"": ""घरमा प्रसुति संख्या   ≥ २० बर्ष""" &
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
    """dataElement"": ""VdZyJrLrSg5""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox17.Text & """," &
    """comment"": ""सामान्य (Spontaneous)-Cephalic""" &
"}," &
"{" &
    """dataElement"": ""rqny3AJuymt""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox20.Text & """," &
    """comment"": ""सामान्य (Spontaneous)-Shoulder""" &
"}," &
"{" &
    """dataElement"": ""c6dLz049UWw""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox22.Text & """," &
    """comment"": ""सामान्य (Spontaneous)-Breech""" &
"}," &
"{" &
    """dataElement"": ""CtX7O3pbtL3""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox18.Text & """," &
    """comment"": ""Cephalic""" &
"}," &
"{" &
    """dataElement"": ""BoPXsSKiPVx""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox19.Text & """," &
    """comment"": ""Cephalic""" &
"}," &
"{" &
    """dataElement"": ""xAulrqfseew""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox21.Text & """," &
    """comment"": ""Shoulder""" &
"}," &
"{" &
    """dataElement"": ""zgNUMf4qP2Z""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox23.Text & """," &
    """comment"": ""Breech""" &
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
    """dataElement"": ""UQTYGjWr7wz""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox24.Text & """," &
    """comment"": ""आमाहरुको संख्या -एकल बच्चा""" &
"}," &
"{" &
    """dataElement"": ""cMo5gmSt1yV""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox27.Text & """," &
    """comment"": ""आमाहरुको संख्या -जुम्ल्याहा""" &
"}," &
"{" &
    """dataElement"": ""pP3HfFu4Bte""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox30.Text & """," &
    """comment"": ""आमाहरुको संख्या ≥ तिम्ल्याहा""" &
"}," &
"{" &
    """dataElement"": ""Yjwho2iruhu""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox25.Text & """," &
    """comment"": ""जम्मा जीवित जन्म महिला एकल बच्चा""" &
"}," &
"{" &
    """dataElement"": ""w0fvdvU1yuF""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox28.Text & """," &
    """comment"": ""जम्मा जीवित जन्म महिला जुम्ल्याहा""" &
"}," &
"{" &
    """dataElement"": ""ZtwhYCiEQ7w""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox31.Text & """," &
    """comment"": ""जम्मा जीवित जन्म महिला ≥ तिम्ल्याहा""" &
"}," &
"{" &
    """dataElement"": ""Yjwho2iruhu""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox26.Text & """," &
    """comment"": ""जम्मा जीवित जन्म पुरूष एकल बच्चा""" &
"}," &
"{" &
    """dataElement"": ""w0fvdvU1yuF""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox29.Text & """," &
    """comment"": ""जम्मा जीवित जन्म पुरूष जुम्ल्याहा""" &
"}," &
"{" &
    """dataElement"": ""ZtwhYCiEQ7w""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox32.Text & """," &
    """comment"": ""जम्मा जीवित जन्म पुरूष ≥ तिम्ल्याहा""" &
"}," &
"{" &
    """dataElement"": ""WKqgC95Vx8S""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox33.Text & """," &
    """comment"": ""अवधि नपुगेको जन्म""" &
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
    """dataElement"": ""k2StfxOzXpx""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox64.Text & """," &
    """comment"": ""Fresh""" &
"}," &
"{" &
    """dataElement"": ""FlyYBxnmKup""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox65.Text & """," &
    """comment"": ""Macerated""" &
"}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
    """dataElement"": ""xuB0JEsPKI9""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox66.Text & """," &
    """comment"": ""जन्मेको १ घण्टा भित्र स्तनपान गराएको शिशु को संख्या""" &
"}," &
"{" &
    """dataElement"": ""XxGpVsZfVPL""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox67.Text & """," &
    """comment"": ""नाभी मलम लगाएको शिशु को संख्या""" &
"}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
"""dataElement"": ""dZo1PDWPAO1""," &
"""categoryOptionCombo"": ""kdsirVNKdhm""," &
"""value"": """ & TextBox68.Text & """," &
"""comment"": ""यातायात खर्च पाउनुपर्ने""" &
"}," &
"{" &
"""dataElement"": ""ysTJteUVzO1""," &
"""categoryOptionCombo"": ""kdsirVNKdhm""," &
"""value"": """ & TextBox70.Text & """," &
"""comment"": ""यातायात खर्च पाएका""" &
"}," &
"{" &
"""dataElement"": ""MO4VQOLebuG""," &
"""categoryOptionCombo"": ""kdsirVNKdhm""," &
"""value"": """ & TextBox69.Text & """," &
"""comment"": ""गर्भवती उत्प्रेरणा पाउनुपर्ने""" &
"}," &
"{" &
"""dataElement"": ""ua0pnAingEU""," &
"""categoryOptionCombo"": ""kdsirVNKdhm""," &
"""value"": """ & TextBox71.Text & """," &
"""comment"": ""गर्भवती उत्प्रेरणा पाएका""" &
"}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
        """dataElement"": ""f4ueiBTKF1T""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox72.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""b1PTkXsRdX6""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox87.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""WWOFK8vAADY""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox102.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""S4CFTXyEFVc""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox73.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""qkUkDDvmwS0""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox88.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""q8L2FAXjU4I""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox103.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""v3zKVR5wJt3""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox74.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""ohdTLUyqYXk""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox89.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""WEes0A6r9Dh""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox104.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""PELChUNfW2C""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox75.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""H0VEoxGraGW""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox90.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""ItB5JYfclT1""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox105.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""LIo3j809JrK""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox76.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""AudMtjCeYOv""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox91.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""TF2VKOKKdzZ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox106.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""ueBJTsv0PXr""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox77.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""WaovoeTaaaw""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox92.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""BKM6OWQmRku""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox107.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""wsncKYDcmqr""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox78.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""dGAB4Mox8Sl""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox93.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""yPybiey409s""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox108.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""Dior21jcQCe""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox79.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""G7IUvliObQp""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox94.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""Gv1oyaeNKxv""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox109.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""VO1obyQWvjO""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox80.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""LnnazOkLzwa""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox95.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""uMem3pOk3TV""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox110.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""nwQoDUhFR1z""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox81.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""ZJ663GTjG1x""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox96.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""PHry6X0GfZL""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox111.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""PGNd6jcxJX4""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox82.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""W3Stsxj1Lcb""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox97.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""nq5GBHIhiIt""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox112.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""kV3JhKJWMR8""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox83.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""vCrWmEcmnhC""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox98.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""vbi3VCU85Pe""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox113.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""dHet49ySm06""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox84.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""tWRdOmeobnZ""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox99.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""c3BpP1lVGNC""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox114.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""FexcOBCpEz3""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox85.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""FnXt15rpfca""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox100.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""WimUNMADw5X""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox115.Text & """," &
        """comment"": ""Death""" &
    "}," &
    "{" &
        """dataElement"": ""XAzAbTRbJve""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox86.Text & """," &
        """comment"": ""Cases""" &
    "}," &
    "{" &
        """dataElement"": ""qhRyGiA3XAN""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox101.Text & """," &
        """comment"": ""Referred out""" &
    "}," &
    "{" &
        """dataElement"": ""AqCYkbLoysp""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox116.Text & """," &
        """comment"": ""Death""" &
    "}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
        """dataElement"": ""byf1Rf6bEPt""," &
        """categoryOptionCombo"": ""kRwzaFG6GPV""," &
        """value"": """ & TextBox155.Text & """," &
        """comment"": ""गर्भवति अवस्था (APH)""" &
    "}," &
    "{" &
        """dataElement"": ""byf1Rf6bEPt""," &
        """categoryOptionCombo"": ""UxlNYkFakvE""," &
        """value"": """ & TextBox117.Text & """," &
        """comment"": "" प्रसव अवस्था""" &
    "}," &
    "{" &
        """dataElement"": ""byf1Rf6bEPt""," &
        """categoryOptionCombo"": ""DMyKvTLRZPc""," &
        """value"": """ & TextBox119.Text & """," &
        """comment"": "" सुत्केरी अवस्था (PPH)""" &
    "}," &
    "{" &
        """dataElement"": ""PSSyeHAZVcx""," &
        """categoryOptionCombo"": ""kRwzaFG6GPV""," &
        """value"": """ & TextBox156.Text & """," &
        """comment"": ""गर्भवति अवस्था (APH)""" &
    "}," &
    "{" &
        """dataElement"": ""PSSyeHAZVcx""," &
        """categoryOptionCombo"": ""UxlNYkFakvE""," &
        """value"": """ & TextBox118.Text & """," &
        """comment"": "" प्रसव अवस्था""" &
    "}," &
    "{" &
        """dataElement"": ""PSSyeHAZVcx""," &
        """categoryOptionCombo"": ""DMyKvTLRZPc""," &
        """value"": """ & TextBox120.Text & """," &
        """comment"": "" सुत्केरी अवस्था (PPH)""" &
    "}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
        """dataElement"": ""uzX1NG6xDwr""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox121.Text & """," &
        """comment"": ""जम्मा संख्या""" &
    "}," &
    "{" &
        """dataElement"": ""DjglomjSiAu""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox124.Text & """," &
        """comment"": "" निसासिएको""" &
    "}," &
    "{" &
        """dataElement"": ""vIuy5zKUj82""," &
        """categoryOptionCombo"": ""tCy6R2UbkA1""," &
        """value"": """ & TextBox127.Text & """," &
        """comment"": ""Major""" &
    "}," &
    "{" &
        """dataElement"": ""vIuy5zKUj82""," &
        """categoryOptionCombo"": ""XXgFel6hY5K""," &
        """value"": """ & TextBox130.Text & """," &
        """comment"": "" Minor""" &
    "}," &
    "{" &
        """dataElement"": ""vIuy5zKUj82""," &
        """categoryOptionCombo"": ""KiFbliu1f8r""," &
        """value"": """ & TextBox133.Text & """," &
        """comment"": "" Others""" &
    "}," &
    "{" &
        """dataElement"": ""GDJYMsnrkvy""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox136.Text & """," &
        """comment"": "" संक्रमण""" &
    "}," &
    "{" &
        """dataElement"": ""r1x2daA3pwt""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox122.Text & """," &
        """comment"": ""जम्मा संख्या""" &
    "}," &
    "{" &
        """dataElement"": ""stOtnhrYX9J""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox125.Text & """," &
        """comment"": "" निसासिएको""" &
    "}," &
    "{" &
        """dataElement"": ""ssjLchkxrC3""," &
        """categoryOptionCombo"": ""tCy6R2UbkA1""," &
        """value"": """ & TextBox128.Text & """," &
        """comment"": ""Major""" &
    "}," &
    "{" &
        """dataElement"": ""ssjLchkxrC3""," &
        """categoryOptionCombo"": ""XXgFel6hY5K""," &
        """value"": """ & TextBox131.Text & """," &
        """comment"": "" Minor""" &
    "}," &
    "{" &
        """dataElement"": ""ssjLchkxrC3""," &
        """categoryOptionCombo"": ""KiFbliu1f8r""," &
        """value"": """ & TextBox134.Text & """," &
        """comment"": "" Others""" &
    "}," &
    "{" &
        """dataElement"": ""JCo1sEf9nZV""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox137.Text & """," &
        """comment"": "" संक्रमण""" &
    "}," &
    "{" &
        """dataElement"": ""uGteAfUfOBk""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox123.Text & """," &
        """comment"": ""जम्मा संख्या""" &
    "}," &
    "{" &
        """dataElement"": ""DFEHOcOqW5a""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox126.Text & """," &
        """comment"": "" निसासिएको""" &
    "}," &
    "{" &
        """dataElement"": ""zaFinXSR0UY""," &
        """categoryOptionCombo"": ""tCy6R2UbkA1""," &
        """value"": """ & TextBox129.Text & """," &
        """comment"": ""Major""" &
    "}," &
    "{" &
        """dataElement"": ""zaFinXSR0UY""," &
        """categoryOptionCombo"": ""XXgFel6hY5K""," &
        """value"": """ & TextBox132.Text & """," &
        """comment"": "" Minor""" &
    "}," &
    "{" &
        """dataElement"": ""zaFinXSR0UY""," &
        """categoryOptionCombo"": ""KiFbliu1f8r""," &
        """value"": """ & TextBox135.Text & """," &
        """comment"": "" Others""" &
    "}," &
    "{" &
        """dataElement"": ""T83jtwxnALp""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox138.Text & """," &
        """comment"": "" संक्रमण""" &
    "}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
        """dataElement"": ""b8jGBrMfBbP""," &
        """categoryOptionCombo"": ""kXFhKYzLFKT""," &
        """value"": """ & TextBox154.Text & """," &
        """comment"": ""सुत्केरी """ &
    "}," &
    "{" &
        """dataElement"": ""xXGoDPlPopJ""," &
        """categoryOptionCombo"": ""kXFhKYzLFKT""," &
        """value"": """ & TextBox152.Text & """," &
        """comment"": "" नवजात शिशु""" &
    "}," &
    "{" &
        """dataElement"": ""b8jGBrMfBbP""," &
        """categoryOptionCombo"": ""VSSmCVmaTM5""," &
        """value"": """ & TextBox150.Text & """," &
        """comment"": "" सुत्केरी """ &
    "}," &
    "{" &
        """dataElement"": ""xXGoDPlPopJ""," &
        """categoryOptionCombo"": ""VSSmCVmaTM5""," &
        """value"": """ & TextBox148.Text & """," &
        """comment"": "" नवजात शिशु""" &
    "}," &
    "{" &
        """dataElement"": ""ZMdVETMGwzz""," &
        """categoryOptionCombo"": ""kXFhKYzLFKT""," &
        """value"": """ & TextBox153.Text & """," &
        """comment"": ""सुत्केरी """ &
    "}," &
    "{" &
        """dataElement"": ""xGc4o4Oj3W8""," &
        """categoryOptionCombo"": ""kXFhKYzLFKT""," &
        """value"": """ & TextBox149.Text & """," &
        """comment"": "" नवजात शिशु""" &
    "}," &
    "{" &
        """dataElement"": ""ZMdVETMGwzz""," &
        """categoryOptionCombo"": ""VSSmCVmaTM5""," &
        """value"": """ & TextBox146.Text & """," &
        """comment"": "" सुत्केरी """ &
    "}," &
    "{" &
        """dataElement"": ""xGc4o4Oj3W8""," &
        """categoryOptionCombo"": ""VSSmCVmaTM5""," &
        """value"": """ & TextBox144.Text & """," &
        """comment"": "" नवजात शिशु""" &
    "}," &
    "{" &
        """dataElement"": ""Aw24Ejbp63F""," &
        """categoryOptionCombo"": ""kXFhKYzLFKT""," &
        """value"": """ & TextBox151.Text & """," &
        """comment"": ""सुत्केरी """ &
    "}," &
    "{" &
        """dataElement"": ""uKeGRM3UK5z""," &
        """categoryOptionCombo"": ""kXFhKYzLFKT""," &
        """value"": """ & TextBox145.Text & """," &
        """comment"": "" नवजात शिशु""" &
    "}," &
    "{" &
        """dataElement"": ""Aw24Ejbp63F""," &
        """categoryOptionCombo"": ""VSSmCVmaTM5""," &
        """value"": """ & TextBox142.Text & """," &
        """comment"": "" सुत्केरी """ &
    "}," &
    "{" &
        """dataElement"": ""uKeGRM3UK5z""," &
        """categoryOptionCombo"": ""VSSmCVmaTM5""," &
        """value"": """ & TextBox140.Text & """," &
        """comment"": "" नवजात शिशु""" &
    "}," &
    "{" &
        """dataElement"": ""mTfqwld6Ipc""," &
        """categoryOptionCombo"": ""kXFhKYzLFKT""," &
        """value"": """ & TextBox147.Text & """," &
        """comment"": ""सुत्केरी """ &
    "}," &
    "{" &
        """dataElement"": ""oMUgt63LJWU""," &
        """categoryOptionCombo"": ""kXFhKYzLFKT""," &
        """value"": """ & TextBox143.Text & """," &
        """comment"": "" नवजात शिशु""" &
    "}," &
    "{" &
        """dataElement"": ""mTfqwld6Ipc""," &
        """categoryOptionCombo"": ""VSSmCVmaTM5""," &
        """value"": """ & TextBox141.Text & """," &
        """comment"": "" सुत्केरी """ &
    "}," &
    "{" &
        """dataElement"": ""oMUgt63LJWU""," &
        """categoryOptionCombo"": ""VSSmCVmaTM5""," &
        """value"": """ & TextBox139.Text & """," &
        """comment"": "" नवजात शिशु""" &
    "}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
        """dataElement"": ""YZfwWNZzfg0""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox34.Text & """," &
        """comment"": ""गर्भावस्था """ &
    "}," &
    "{" &
        """dataElement"": ""BL5XaUOJ6aw""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox36.Text & """," &
        """comment"": "" प्रसूति अवस्था""" &
    "}," &
    "{" &
        """dataElement"": ""IMFPhLtATaw""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox38.Text & """," &
        """comment"": "" सुत्केरी अवस्था """ &
    "}," &
    "{" &
        """dataElement"": ""Fr9hLa5q3YE""," &
        """categoryOptionCombo"": ""nOyy5SUrox6""," &
        """value"": """ & TextBox40.Text & """," &
        """comment"": ""  ०-७ दिन""" &
    "}," &
    "{" &
        """dataElement"": ""Fr9hLa5q3YE""," &
        """categoryOptionCombo"": ""ZpMmXgciIXo""," &
        """value"": """ & TextBox41.Text & """," &
        """comment"": ""८-२८ दिन """ &
    "}," &
    "{" &
        """dataElement"": ""XllGykStIdr""," &
        """categoryOptionCombo"": ""Pcl6Mfo4Fj7""," &
        """value"": """ & TextBox35.Text & """," &
        """comment"": ""गर्भावस्था """ &
    "}," &
    "{" &
        """dataElement"": ""XllGykStIdr""," &
        """categoryOptionCombo"": ""Kun0DRKCyL6""," &
        """value"": """ & TextBox37.Text & """," &
        """comment"": "" प्रसूति अवस्था""" &
    "}," &
    "{" &
        """dataElement"": ""XllGykStIdr""," &
        """categoryOptionCombo"": ""LRzPA4jWIgo""," &
        """value"": """ & TextBox39.Text & """," &
        """comment"": "" सुत्केरी अवस्था """ &
    "}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
        """dataElement"": ""KsMJg5sdGOS""," &
        """categoryOptionCombo"": ""Fgf21WXIj3N""," &
        """value"": """ & TextBox42.Text & """," &
        """comment"": ""मेडिकल "" " &
    "}," &
    "{" &
        """dataElement"": ""KkSEy2pfgCD""," &
        """categoryOptionCombo"": ""Fgf21WXIj3N""," &
        """value"": """ & TextBox47.Text & """," &
        """comment"": "" सर्जिकल""" &
    "}," &
    "{" &
        """dataElement"": ""KsMJg5sdGOS""," &
        """categoryOptionCombo"": ""MS5MX5dx0nH""," &
        """value"": """ & TextBox52.Text & """," &
        """comment"": "" मेडिकल "" " &
    "}," &
    "{" &
        """dataElement"": ""KkSEy2pfgCD""," &
        """categoryOptionCombo"": ""MS5MX5dx0nH""," &
        """value"": """ & TextBox57.Text & """," &
        """comment"": "" सर्जिकल""" &
    "}," &
    "{" &
        """dataElement"": ""jjcHCV1ZfAt""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox62.Text & """," &
        """comment"": ""PAC सेवा पाएका """ &
    "}," &
    "{" &
        """dataElement"": ""wxIeWrnnZxe""," &
        """categoryOptionCombo"": ""Fgf21WXIj3N""," &
        """value"": """ & TextBox43.Text & """," &
        """comment"": ""मेडिकल "" " &
    "}," &
    "{" &
        """dataElement"": ""ymw1agzYyF3""," &
        """categoryOptionCombo"": ""Fgf21WXIj3N""," &
        """value"": """ & TextBox48.Text & """," &
        """comment"": "" सर्जिकल""" &
    "}," &
    "{" &
        """dataElement"": ""wxIeWrnnZxe""," &
        """categoryOptionCombo"": ""MS5MX5dx0nH""," &
        """value"": """ & TextBox53.Text & """," &
        """comment"": "" मेडिकल "" " &
    "}," &
    "{" &
        """dataElement"": ""ymw1agzYyF3""," &
        """categoryOptionCombo"": ""MS5MX5dx0nH""," &
        """value"": """ & TextBox58.Text & """," &
        """comment"": "" सर्जिकल""" &
    "}," &
    "{" &
        """dataElement"": ""BIjA8u1VMF3""," &
        """categoryOptionCombo"": ""Fgf21WXIj3N""," &
        """value"": """ & TextBox44.Text & """," &
        """comment"": ""मेडिकल "" " &
    "}," &
    "{" &
        """dataElement"": ""spH6ZRldV3F""," &
        """categoryOptionCombo"": ""Fgf21WXIj3N""," &
        """value"": """ & TextBox49.Text & """," &
        """comment"": "" सर्जिकल""" &
    "}," &
    "{" &
        """dataElement"": ""BIjA8u1VMF3""," &
        """categoryOptionCombo"": ""MS5MX5dx0nH""," &
        """value"": """ & TextBox54.Text & """," &
        """comment"": "" मेडिकल "" " &
    "}," &
    "{" &
        """dataElement"": ""spH6ZRldV3F""," &
        """categoryOptionCombo"": ""MS5MX5dx0nH""," &
        """value"": """ & TextBox59.Text & """," &
        """comment"": "" सर्जिकल""" &
    "}," &
    "{" &
        """dataElement"": ""AP5k6dsqGPI""," &
        """categoryOptionCombo"": ""Fgf21WXIj3N""," &
        """value"": """ & TextBox45.Text & """," &
        """comment"": ""मेडिकल "" " &
    "}," &
    "{" &
        """dataElement"": ""WAxqda0KkYt""," &
        """categoryOptionCombo"": ""Fgf21WXIj3N""," &
        """value"": """ & TextBox50.Text & """," &
        """comment"": "" सर्जिकल""" &
    "}," &
    "{" &
        """dataElement"": ""AP5k6dsqGPI""," &
        """categoryOptionCombo"": ""MS5MX5dx0nH""," &
        """value"": """ & TextBox55.Text & """," &
        """comment"": "" मेडिकल "" " &
    "}," &
    "{" &
        """dataElement"": ""WAxqda0KkYt""," &
        """categoryOptionCombo"": ""MS5MX5dx0nH""," &
        """value"": """ & TextBox60.Text & """," &
        """comment"": "" सर्जिकल""" &
    "}," &
    "{" &
        """dataElement"": ""CWlOpEYqaC1""," &
        """categoryOptionCombo"": ""Fgf21WXIj3N""," &
        """value"": """ & TextBox46.Text & """," &
        """comment"": ""मेडिकल "" " &
    "}," &
    "{" &
        """dataElement"": ""FKPsRSUnnob""," &
        """categoryOptionCombo"": ""Fgf21WXIj3N""," &
        """value"": """ & TextBox51.Text & """," &
        """comment"": "" सर्जिकल""" &
    "}," &
    "{" &
        """dataElement"": ""CWlOpEYqaC1""," &
        """categoryOptionCombo"": ""MS5MX5dx0nH""," &
        """value"": """ & TextBox56.Text & """," &
        """comment"": "" मेडिकल "" " &
    "}," &
    "{" &
        """dataElement"": ""FKPsRSUnnob""," &
        """categoryOptionCombo"": ""MS5MX5dx0nH""," &
        """value"": """ & TextBox61.Text & """," &
        """comment"": "" सर्जिकल""" &
    "}," &
    "{" &
        """dataElement"": ""yVSHk4nvDYn""," &
        """categoryOptionCombo"": ""kdsirVNKdhm""," &
        """value"": """ & TextBox63.Text & """," &
        """comment"": "" PAC सेवा पाएका""" &
    "}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub
End Class