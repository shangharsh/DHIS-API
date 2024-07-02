Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net
Imports System.Text

Public Class MonthlyProgressReport
    Dim dataSetId As String = "jZ0ClbXLtgz" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"


    Private Sub BtnAgePush_Click(sender As Object, e As EventArgs) Handles BtnAgePush.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
        {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""I1gylzOskBs""," &
            "        ""value"": """ & TextBox1.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या म. 0-9 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""TTNFd2X49S6""," &
            "        ""value"": """ & TextBox2.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या पु. 0-9 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""ciTvZ1HjQTw""," &
            "        ""value"": """ & TextBox3.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या म. 10-14 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""SDgsEKTs0IH""," &
            "        ""value"": """ & TextBox4.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या पु. 10-14 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""RnH2ZpATWSI""," &
            "        ""value"": """ & TextBox5.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या म. 15-19 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""ffNSZ7u5Y5P""," &
            "        ""value"": """ & TextBox6.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या पु. 15-19 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""sfmUgn8yywu""," &
            "        ""value"": """ & TextBox7.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या म. 20-59 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""iUcXHCikw4W""," &
            "        ""value"": """ & TextBox8.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या पु. 20-59 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""COAFy42YNLg""," &
            "        ""value"": """ & TextBox9.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या म. 60-69 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""D7tJYC2XYrC""," &
            "        ""value"": """ & TextBox10.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या पु. 60-69 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""M0yrPwi8vEK""," &
            "        ""value"": """ & TextBox11.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या म. >=70 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""HscG3R78Jzc""," &
            "        ""categoryOptionCombo"": ""DYUdGTQhgf9""," &
            "        ""value"": """ & TextBox12.Text & """," &
            "        ""comment"": ""नयाँ सेवाग्राहीको सँख्या पु. >=70 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""I1gylzOskBs""," &
            "        ""value"": """ & TextBox13.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या म. 0-9 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""TTNFd2X49S6""," &
            "        ""value"": """ & TextBox14.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या पु. 0-9 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""ciTvZ1HjQTw""," &
            "        ""value"": """ & TextBox15.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या म. 10-14 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""SDgsEKTs0IH""," &
            "        ""value"": """ & TextBox16.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या पु. 10-14 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""RnH2ZpATWSI""," &
            "        ""value"": """ & TextBox17.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या म. 15-19 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""ffNSZ7u5Y5P""," &
            "        ""value"": """ & TextBox18.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या पु. 15-19 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""sfmUgn8yywu""," &
            "        ""value"": """ & TextBox19.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या म. 20-59 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""iUcXHCikw4W""," &
            "        ""value"": """ & TextBox20.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या पु. 20-59 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""COAFy42YNLg""," &
            "        ""value"": """ & TextBox21.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या म. 60-69 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""D7tJYC2XYrC""," &
            "        ""value"": """ & TextBox22.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या पु. 60-69 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""M0yrPwi8vEK""," &
            "        ""value"": """ & TextBox23.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या म. >=70 Years""" &
            "    }," &
            "    {" &
            "        ""dataElement"": ""XjuXeaVPUsr""," &
            "        ""categoryOptionCombo"": ""DYUdGTQhgf9""," &
            "        ""value"": """ & TextBox24.Text & """," &
            "        ""comment"": ""जम्मा (नयाँ/ पुराना) सेवाग्राही सँख्या पु. >=70 Years""" &
            "    }," &
            "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""I1gylzOskBs""," &
    """value"": """ & TextBox25.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही म.  0-9 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""TTNFd2X49S6""," &
    """value"": """ & TextBox26.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही पु.  0-9 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""ciTvZ1HjQTw""," &
    """value"": """ & TextBox27.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही म.  10-14 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""SDgsEKTs0IH""," &
    """value"": """ & TextBox28.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही पु.  10-14 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""RnH2ZpATWSI""," &
    """value"": """ & TextBox29.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही म.  15-19 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""ffNSZ7u5Y5P""," &
    """value"": """ & TextBox30.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही पु.  15-19 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""sfmUgn8yywu""," &
    """value"": """ & TextBox31.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही म.  20-59 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""iUcXHCikw4W""," &
    """value"": """ & TextBox32.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही पु.  20-59 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""COAFy42YNLg""," &
    """value"": """ & TextBox33.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही म.  60-69 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""D7tJYC2XYrC""," &
    """value"": """ & TextBox34.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही पु.  60-69 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""M0yrPwi8vEK""," &
    """value"": """ & TextBox35.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही म.  >=70 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ZNYzRQGhxpd""," &
    """categoryOptionCombo"": ""DYUdGTQhgf9""," &
    """value"": """ & TextBox36.Text & """," &
    """comment"": ""प्रेषण भई आएका जम्मा सेवाग्राही पु.  >=70 Years""" &
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
                        Dim responseObject As Object = JObject.Parse(responseJson)
                        Dim status As String = responseObject("status").ToString()
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

    Private Sub BtnWorkPush_Click(sender As Object, e As EventArgs) Handles BtnWorkPush.Click

        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
  {" &
    """dataElement"": ""yUNjmhz0j9s""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox37.Text & """," &
    """comment"": ""गाउँघर क्लिनिक---संचालन/ प्रतिवेदन हुनुपर्ने (संख्या)""" &
    "}," &
    "{" &
    """dataElement"": ""BG55tDKF0np""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox38.Text & """," &
    """comment"": ""गाउँघर क्लिनिक---संचालन/ प्रतिवेदन भएको (संख्या)""" &
    "}," &
    "{" &
    """dataElement"": ""bKTB9K7u6DS""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox39.Text & """," &
    """comment"": ""गाउँघर क्लिनिक---सेवा पाएका जम्मा सेवाग्राहीको संख्या""" &
    "}," &
    "{" &
    """dataElement"": ""sBAeCFmRvOG""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox40.Text & """," &
    """comment"": ""खोप क्लिनिक ---संचालन/ प्रतिवेदन हुनुपर्ने (संख्या)""" &
    "}," &
    "{" &
    """dataElement"": ""w7FmV7f1Rcn""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox41.Text & """," &
    """comment"": ""खोप क्लिनिक ---संचालन/ प्रतिवेदन भएको (संख्या)""" &
    "}," &
    "{" &
    """dataElement"": ""TEdItLSOdos""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox42.Text & """," &
    """comment"": ""खोप क्लिनिक ---सेवा पाएका जम्मा सेवाग्राहीको संख्या""" &
    "}," &
    "{" &
    """dataElement"": ""e0HZBrBDfpg""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox43.Text & """," &
    """comment"": ""खोप सेशन---संचालन/ प्रतिवेदन हुनुपर्ने (संख्या)""" &
    "}," &
    "{" &
    """dataElement"": ""BF7zguwOCqE""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox44.Text & """," &
    """comment"": ""खोप सेशन---संचालन/ प्रतिवेदन भएको (संख्या)""" &
    "}," &
    "{" &
    """dataElement"": ""IY9MMZYW2Td""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox45.Text & """," &
    """comment"": ""सरसफाई सेसन (पटक)---संचालन/ प्रतिवेदन हुनुपर्ने (संख्या)""" &
    "}," &
    "{" &
    """dataElement"": ""K8inoFQdq06""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox46.Text & """," &
    """comment"": ""सरसफाई सेसन (पटक)---संचालन/ प्रतिवेदन भएको (संख्या)""" &
    "}," &
    "{" &
    """dataElement"": ""Jy09iroElNr""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox47.Text & """," &
    """comment"": ""सरसफाई सेसन (पटक)---सेवा पाएका जम्मा सेवाग्राहीको संख्या""" &
    "}," &
    "{" &
    """dataElement"": ""CfKB0tK9q3M""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox48.Text & """," &
    """comment"": ""म. स्वा. स्व. से.---संचालन/ प्रतिवेदन हुनुपर्ने (संख्या)""" &
    "}," &
    "{" &
    """dataElement"": ""Lix74hdpuwt""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox49.Text & """," &
    """comment"": ""म. स्वा. स्व. से.---संचालन/ प्रतिवेदन भएको (संख्या)""" &
    "}," &
    "{" &
    """dataElement"": ""GvdBFMcPVox""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox50.Text & """," &
    """comment"": ""म. स्वा. स्व. से.---सेवा पाएका जम्मा सेवाग्राहीको संख्या""" &
    "}" &
   " ]" &
    "}"


        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)

    End Sub
End Class

