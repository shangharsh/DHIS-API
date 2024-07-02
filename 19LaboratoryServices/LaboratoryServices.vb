Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq

Public Class LaboratoryServices
    Dim dataSetId As String = "jZ0ClbXLtgz" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"

    Private Sub BtnHMPush_Click(sender As Object, e As EventArgs) Handles BtnHMPush.Click


        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
        {" &
        "    ""dataElement"": ""MX5XthyOLIX""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt1.Text & """," &
        "    ""comment"": ""Hematology HB""" &
        "}," &
        "{" &
        "    ""dataElement"": ""ga8cotZYUGN""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt2.Text & """," &
        "    ""comment"": ""RBC-Count""" &
        "}," &
        "{" &
        "    ""dataElement"": ""udHP9cMdus0""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt3.Text & """," &
        "    ""comment"": ""TLC""" &
        "}," &
        "{" &
        "    ""dataElement"": ""HkVFI7zvtco""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt4.Text & """," &
        "    ""comment"": ""Platelets Count""" &
        "}," &
        "{" &
        "    ""dataElement"": ""Ks9ADEZCFQd""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt5.Text & """," &
        "    ""comment"": ""DLC""" &
        "}," &
        "{" &
        "    ""dataElement"": ""hcN0jcWCBLx""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt6.Text & """," &
        "    ""comment"": ""ESR""" &
        "}," &
        "{" &
        "    ""dataElement"": ""o6paypYS2tc""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt8.Text & """," &
        "    ""comment"": ""MCV""" &
        "}," &
        "{" &
        "    ""dataElement"": ""kTMrl2nmqdQ""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt9.Text & """," &
        "    ""comment"": ""MCH""" &
        "}," &
        "{" &
        "    ""dataElement"": ""mucJ3LkNOGi""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt10.Text & """," &
        "    ""comment"": ""MCHC""" &
        "}," &
        "{" &
        "    ""dataElement"": ""jtq2eCYU4TI""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt11.Text & """," &
        "    ""comment"": ""RDW""" &
        "}," &
        "{" &
        "    ""dataElement"": ""sgR3aHSyj0A""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt12.Text & """," &
        "    ""comment"": ""Blood Group""" &
        "}," &
        "{" &
        "    ""dataElement"": ""V2rLFh947Xk""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt13.Text & """," &
        "    ""comment"": ""Coombs Test""" &
        "}," &
        "{" &
        "    ""dataElement"": ""XJcUhKfv6iG""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt14.Text & """," &
        "    ""comment"": ""Retics""" &
        "}," &
        "{" &
        "    ""dataElement"": ""IB7pwInGJ2Z""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt15.Text & """," &
        "    ""comment"": ""PBS/PBF""" &
        "}," &
        "{" &
        "    ""dataElement"": ""TPfANsOsI68""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt16.Text & """," &
        "    ""comment"": ""HbAlc""" &
        "}," &
        "{" &
        "    ""dataElement"": ""JWcZvHhr1Wh""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt17.Text & """," &
        "    ""comment"": ""Special Stain-MPO""" &
        "}," &
        "{" &
        "    ""dataElement"": ""JaZYiW0YaCW""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt18.Text & """," &
        "    ""comment"": ""Special Stain-PAS""" &
        "}," &
        "{" &
        "    ""dataElement"": ""TWkqsR5UgVd""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt19.Text & """," &
        "    ""comment"": ""Sickling Test""" &
        "}," &
        "{" &
        "    ""dataElement"": ""KhBNHEeaRQ6""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt20.Text & """," &
        "    ""comment"": ""Urine for Hemosiderin""" &
        "}," &
        "{" &
        "    ""dataElement"": ""PEtNspPKfGU""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt21.Text & """," &
        "    ""comment"": ""BT""" &
        "}," &
        "{" &
        "    ""dataElement"": ""VxCaWebcSNY""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt22.Text & """," &
        "    ""comment"": ""CT""" &
        "}," &
        "{" &
        "    ""dataElement"": ""hvKJZhQvtlD""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt23.Text & """," &
        "    ""comment"": ""PT-INR""" &
        "}," &
        "{" &
        "    ""dataElement"": ""lQ3GQrEk9mB""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt24.Text & """," &
        "    ""comment"": ""APTT""" &
        "}," &
        "{" &
        "    ""dataElement"": ""I8Z2E4Kmgii""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt25.Text & """," &
        "    ""comment"": ""Bone Marrow Analysis""" &
        "}," &
        "{" &
        "    ""dataElement"": ""QPNEYl5SKm8""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt26.Text & """," &
        "    ""comment"": ""Aldhyde Test""" &
        "}," &
        "{" &
        "    ""dataElement"": ""UX2IdkwZPm6""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt27.Text & """," &
        "    ""comment"": ""MP Total""" &
        "}," &
        "{" &
        "    ""dataElement"": ""nTOEK8miG0K""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt28.Text & """," &
        "    ""comment"": ""Smear MP Pos-PF""" &
        "}," &
        "{" &
        "    ""dataElement"": ""LZPBP5dgWs0""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt29.Text & """," &
        "    ""comment"": ""Smear MP Pos-PV""" &
        "}," &
        "{" &
        "    ""dataElement"": ""myzTAYlWVAc""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt30.Text & """," &
        "    ""comment"": ""Smear MP Pos-P-MIX""" &
        "}," &
        "{" &
        "    ""dataElement"": ""r25JvgKGqwE""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt31.Text & """," &
        "    ""comment"": ""MF-Total""" &
        "}," &
        "{" &
        "    ""dataElement"": ""TVZ5CT66epd""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt32.Text & """," &
        "    ""comment"": ""MF-Pos""" &
        "}," &
        "{" &
        "    ""dataElement"": ""dkU2y8nxG0h""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt33.Text & """," &
        "    ""comment"": ""LD Bodies""" &
        "}," &
        "{" &
        "    ""dataElement"": ""F8v1z9J0lOg""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt34.Text & """," &
        "    ""comment"": ""Hb Electrophoresis""" &
        "}," &
        "{" &
        "    ""dataElement"": ""RdQOc3LQLP7""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt35.Text & """," &
        "    ""comment"": ""LE cell""" &
        "}," &
        "{" &
        "    ""dataElement"": ""MT1F817ybIC""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt36.Text & """," &
        "    ""comment"": ""ALC""" &
        "}," &
        "{" &
        "    ""dataElement"": ""VlnMWXp6Sqr""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt37.Text & """," &
        "    ""comment"": ""AEF""" &
        "}," &
        "{" &
        "    ""dataElement"": ""bwHADypDLFl""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt38.Text & """," &
        "    ""comment"": ""FDP""" &
        "}," &
        "{" &
        "    ""dataElement"": ""roqaipUwNjT""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt39.Text & """," &
        "    ""comment"": ""D-Dimer""" &
        "}," &
        "{" &
        "    ""dataElement"": ""vBnEHWgBcLR""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt40.Text & """," &
        "    ""comment"": ""FAC-VIII""" &
        "}," &
        "{" &
        "    ""dataElement"": ""UK3UTayMDhQ""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt41.Text & """," &
        "    ""comment"": ""FAC-IX""" &
        "}," &
        "{" &
        "    ""dataElement"": ""FLukVmXHeQx""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt42.Text & """," &
        "    ""comment"": ""Cross-Matching""" &
        "}," &
        "{" &
        "    ""dataElement"": ""ksFMz4c0I39""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & Txt43.Text & """," &
        "    ""comment"": ""Others""" &
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

    Private Sub BtnImmPush_Click(sender As Object, e As EventArgs) Handles BtnImmPush.Click

        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
        {" &
        "    ""dataElement"": ""R5coLEZO6gu""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt44.Text & """," &
        "    ""comment"": ""Immunology Pregnancy Test""" &
        "}," &
        "{" &
        "    ""dataElement"": ""Bdh8yF2CdD8""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt45.Text & """," &
        "    ""comment"": ""ASO""" &
        "}," &
        "{" &
        "    ""dataElement"": ""biBCfb3VTLe""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt46.Text & """," &
        "    ""comment"": ""CRP""" &
        "}," &
        "{" &
        "    ""dataElement"": ""NHUktqhJjbE""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt47.Text & """," &
        "    ""comment"": ""RA Factor""" &
        "}," &
        "{" &
        "    ""dataElement"": ""KQGrcNYhocs""," &
        "    ""categoryOptionCombo"": ""A0ezJDD4TfL""," &
        "    ""value"": """ & txt48.Text & """," &
        "    ""comment"": ""TPHA Total""" &
        "}," &
        "{" &
        "    ""dataElement"": ""KQGrcNYhocs""," &
        "    ""categoryOptionCombo"": ""wCvNkhhbSbl""," &
        "    ""value"": """ & txt49.Text & """," &
        "    ""comment"": ""TPHA +ve""" &
        "}," &
        "{" &
        "    ""dataElement"": ""nkd4WEiWYpm""," &
        "    ""categoryOptionCombo"": ""A0ezJDD4TfL""," &
        "    ""value"": """ & txt50.Text & """," &
        "    ""comment"": ""ANA""" &
        "}," &
        "{" &
        "    ""dataElement"": ""nOITz2nNxAs""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt51.Text & """," &
        "    ""comment"": ""Anti-dsDNA""" &
        "}," &
        "{" &
        "    ""dataElement"": ""llvGO9epm7O""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt52.Text & """," &
        "    ""comment"": ""PRPR/VDRL- Total""" &
        "}," &
        "{" &
        "    ""dataElement"": ""mhrHV87Zc9U""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt53.Text & """," &
        "    ""comment"": ""PRPR/VDRL- +Ve""" &
        "}," &
        "{" &
        "    ""dataElement"": ""Chpshc4ebjM""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt54.Text & """," &
        "    ""comment"": ""CEA""" &
        "}," &
        "{" &
        "    ""dataElement"": ""gVibsIFUGKo""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt55.Text & """," &
        "    ""comment"": ""CA-125""" &
        "}," &
        "{" &
        "    ""dataElement"": ""Y75eapME064""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt56.Text & """," &
        "    ""comment"": ""CA-19.9""" &
        "}," &
        "{" &
        "    ""dataElement"": ""wt7S2uqK6K1""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt57.Text & """," &
        "    ""comment"": ""CA-15.3""" &
        "}," &
        "{" &
        "    ""dataElement"": ""vbl1CwVTr6v""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt58.Text & """," &
        "    ""comment"": ""Toxo""" &
        "}," &
        "{" &
        "    ""dataElement"": ""RBHRqI1plDF""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt59.Text & """," &
        "    ""comment"": ""Rubella""" &
        "}," &
        "{" &
        "    ""dataElement"": ""kbaZJco7mAo""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt60.Text & """," &
        "    ""comment"": ""CMV""" &
        "}," &
        "{" &
        "    ""dataElement"": ""YEgSZqDWUNm""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt61.Text & """," &
        "    ""comment"": ""HSV""" &
        "}," &
        "{" &
        "    ""dataElement"": ""SJZ1Uv3fXPn""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt62.Text & """," &
        "    ""comment"": ""Measles""" &
        "}," &
        "{" &
        "    ""dataElement"": ""lv5WiRQ4EeS""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt63.Text & """," &
        "    ""comment"": ""Echinococcus""" &
        "}," &
        "{" &
        "    ""dataElement"": ""ZCoqqsa2dPi""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt64.Text & """," &
        "    ""comment"": ""Amoebiasis""" &
        "}," &
        "{" &
        "    ""dataElement"": ""U8KGjwMF8pn""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt64.Text & """," &
        "    ""comment"": ""PSA""" &
        "}," &
        "{" &
        "    ""dataElement"": ""ZD0rMCtnrmu""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt66.Text & """," &
        "    ""comment"": ""Ferritin""" &
        "}," &
        "{" &
        "    ""dataElement"": ""dRgsrcHnY6k""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt67.Text & """," &
        "    ""comment"": ""Cysticercosis""" &
        "}," &
        "{" &
        "    ""dataElement"": ""lrfHXRRnECT""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt68.Text & """," &
        "    ""comment"": ""Brucella""" &
        "}," &
        "{" &
        "    ""dataElement"": ""uYVS9Y6WGGX""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt69.Text & """," &
        "    ""comment"": ""Thyroglobulin""" &
        "}," &
        "{" &
        "    ""dataElement"": ""nmdxncyFWLp""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt70.Text & """," &
        "    ""comment"": ""Anti TPO""" &
        "}," &
        "{" &
        "    ""dataElement"": ""ys3Z6SrXbl8""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt71.Text & """," &
        "    ""comment"": ""Protein Electrophoresis""" &
        "}," &
        "{" &
        "    ""dataElement"": ""hg6gptvIanY""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt72.Text & """," &
        "    ""comment"": ""Anti-CCP""" &
        "}," &
        "{" &
        "    ""dataElement"": ""Vjdjtgx1vez""," &
        "    ""categoryOptionCombo"": ""A0ezJDD4TfL""," &
        "    ""value"": """ & txt73.Text & """," &
        "    ""comment"": ""RK-39 Total""" &
        "}," &
        "{" &
        "    ""dataElement"": ""Vjdjtgx1vez""," &
        "    ""categoryOptionCombo"": ""wCvNkhhbSbl""," &
        "    ""value"": """ & txt74.Text & """," &
        "    ""comment"": ""RK-39 +Ve""" &
        "}," &
        "{" &
        "    ""dataElement"": ""zebx7lWQoyM""," &
        "    ""categoryOptionCombo"": ""A0ezJDD4TfL""," &
        "    ""value"": """ & txt75.Text & """," &
        "    ""comment"": ""JE Total""" &
        "}," &
        "{" &
        "    ""dataElement"": ""zebx7lWQoyM""," &
        "    ""categoryOptionCombo"": ""wCvNkhhbSbl""," &
        "    ""value"": """ & txt76.Text & """," &
        "    ""comment"": ""JE +Ve""" &
        "}," &
        "{" &
        "    ""dataElement"": ""ci7ny20DDx5""," &
        "    ""categoryOptionCombo"": ""A0ezJDD4TfL""," &
        "    ""value"": """ & txt77.Text & """," &
        "    ""comment"": ""Dengue Total""" &
        "}," &
        "{" &
        "    ""dataElement"": ""rXWBtyTUZQT""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt78.Text & """," &
        "    ""comment"": ""Dengue +Ve""" &
        "}," &
        "{" &
        "    ""dataElement"": ""FxeXI2YccuG""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt79.Text & """," &
        "    ""comment"": ""Rapid MP Test Total""" &
        "}," &
        "{" &
        "    ""dataElement"": ""B5ykil1xCD7""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt80.Text & """," &
        "    ""comment"": ""Rapid MP Test +Ve PV""" &
        "}," &
        "{" &
        "    ""dataElement"": ""uxXLme8h5rp""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt81.Text & """," &
        "    ""comment"": ""Rapid MP Test +Ve PF""" &
        "}," &
        "{" &
        "    ""dataElement"": ""pk65G1mjDRY""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt82.Text & """," &
        "    ""comment"": ""Rapid MP Test +Ve P-Mix""" &
        "}," &
        "{" &
        "    ""dataElement"": ""iR2RIlfklv4""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt83.Text & """," &
        "    ""comment"": ""Mantoux test""" &
        "}," &
        "{" &
        "    ""dataElement"": ""mWOLG4uhHKF""," &
        "    ""categoryOptionCombo"": ""A0ezJDD4TfL""," &
        "    ""value"": """ & txt84.Text & """," &
        "    ""comment"": ""Chikungunya Total""" &
        "}," &
        "{" &
        "    ""dataElement"": ""mWOLG4uhHKF""," &
        "    ""categoryOptionCombo"": ""wCvNkhhbSbl""," &
        "    ""value"": """ & txt85.Text & """," &
        "    ""comment"": ""Chikungunya +Ve PV""" &
        "}," &
        "{" &
        "    ""dataElement"": ""IlNmTeeBikM""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt86.Text & """," &
        "    ""comment"": ""Scrub Typhus""" &
        "}," &
        "{" &
        "    ""dataElement"": ""ruFgBQtcLeT""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt87.Text & """," &
        "    ""comment"": ""H. Pylori""" &
        "}," &
        "{" &
        "    ""dataElement"": ""ST5xRwmGRmQ""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt88.Text & """," &
        "    ""comment"": ""Leptospira""" &
        "}," &
        "{" &
        "    ""dataElement"": ""czXIORFAbvx""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt89.Text & """," &
        "    ""comment"": ""Widal Test""" &
        "}," &
        "{" &
        "    ""dataElement"": ""qdCl7C4jfvE""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt90.Text & """," &
        "    ""comment"": ""Others""" &
        "}" &
   " ]" &
    "}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnBioChPush_Click(sender As Object, e As EventArgs) Handles BtnBioChPush.Click



        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
        {" &
        "    ""dataElement"": ""GYgsh4jyQhD""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt91.Text & """," &
        "    ""comment"": ""Sugar""" &
        "}," &
        "{" &
        "    ""dataElement"": ""zEyNSH7f3bc""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt92.Text & """," &
        "    ""comment"": ""Blood Urea""" &
        "}," &
        "{" &
        "    ""dataElement"": ""EAej1kE1URL""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt93.Text & """," &
        "    ""comment"": ""Creatinine""" &
        "}," &
        "{" &
        "    ""dataElement"": ""gCtmVdbe7SY""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt94.Text & """," &
        "    ""comment"": ""Sodium(Na)""" &
        "}," &
        "{" &
        "    ""dataElement"": ""KkBUEB0zQPc""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt95.Text & """," &
        "    ""comment"": ""Potassium(K)""" &
        "}," &
        "{" &
        "    ""dataElement"": ""R5LM4KpJvod""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt96.Text & """," &
        "    ""comment"": ""Calcium""" &
        "}," &
        "{" &
        "    ""dataElement"": ""FNACMSYVtoH""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt97.Text & """," &
        "    ""comment"": ""Phosphorous""" &
        "}," &
        "{" &
        "    ""dataElement"": ""K1sYUht3jjV""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt98.Text & """," &
        "    ""comment"": ""Magnesium""" &
        "}," &
        "{" &
        "    ""dataElement"": ""aZL9j6tqQ9p""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt99.Text & """," &
        "    ""comment"": ""Uric Acid""" &
        "}," &
        "{" &
        "    ""dataElement"": ""wulw5ifRsNe""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt100.Text & """," &
        "    ""comment"": ""Total Cholesterol""" &
        "}," &
        "{" &
        "    ""dataElement"": ""aSL8XQRSfQp""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt101.Text & """," &
        "    ""comment"": ""Triglycerides""" &
        "}," &
        "{" &
        "    ""dataElement"": ""EDGJSDQRSBc""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt102.Text & """," &
        "    ""comment"": ""HDL""" &
        "}," &
        "{" &
        "    ""dataElement"": ""VXTX6a2cthA""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt103.Text & """," &
        "    ""comment"": ""LDL""" &
        "}," &
        "{" &
        "    ""dataElement"": ""jnhUYbBZse7""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt104.Text & """," &
        "    ""comment"": ""Amylase""" &
        "}," &
        "{" &
        "    ""dataElement"": ""BdUuj8ytHYt""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt105.Text & """," &
        "    ""comment"": ""Micro Albumin""" &
        "}," &
        "{" &
        "    ""dataElement"": ""APPyfaSy6hf""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt106.Text & """," &
        "    ""comment"": ""Bilirubin""" &
        "}," &
        "{" &
        "    ""dataElement"": ""uk6zFeOqUKH""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt107.Text & """," &
        "    ""comment"": ""SGPT""" &
        "}," &
        "{" &
        "    ""dataElement"": ""iKAc48pZwIU""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt108.Text & """," &
        "    ""comment"": ""Alk Phos""" &
        "}," &
        "{" &
        "    ""dataElement"": ""a0yIeDftBG7""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt109.Text & """," &
        "    ""comment"": ""SGOT""" &
        "}," &
        "{" &
        "    ""dataElement"": ""n5icJ65j8Q3""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt110.Text & """," &
        "    ""comment"": ""Total Protein""" &
        "}," &
        "{" &
        "    ""dataElement"": ""FrhqMwAiYdj""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt111.Text & """," &
        "    ""comment"": ""Gamma GT""" &
        "}," &
        "{" &
        "    ""dataElement"": ""C7eoJAFCH0M""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt112.Text & """," &
        "    ""comment"": ""24hr Urine Protein""" &
        "}," &
        "{" &
        "    ""dataElement"": ""zl0PSyO6WQx""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt113.Text & """," &
        "    ""comment"": ""24hr Urine U/A""" &
        "}," &
        "{" &
        "    ""dataElement"": ""Wqf9ZelXBdQ""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt114.Text & """," &
        "    ""comment"": ""Creatinine Clearance""" &
        "}," &
        "{" &
        "    ""dataElement"": ""ExnjpyTiZkk""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt115.Text & """," &
        "    ""comment"": ""Iron""" &
        "}," &
        "{" &
        "    ""dataElement"": ""w1CqsqkUyl8""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt116.Text & """," &
        "    ""comment"": ""TIBC""" &
        "}," &
        "{" &
        "    ""dataElement"": ""i0ymcWrlIw3""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt117.Text & """," &
        "    ""comment"": ""CPK-MB""" &
        "}," &
        "{" &
        "    ""dataElement"": ""Ikff1OUhABP""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt118.Text & """," &
        "    ""comment"": ""CPK-NAC""" &
        "}," &
        "{" &
        "    ""dataElement"": ""u1gdmCfIfGa""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt119.Text & """," &
        "    ""comment"": ""LDH""" &
        "}," &
        "{" &
        "    ""dataElement"": ""oGlhaIup37P""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt120.Text & """," &
        "    ""comment"": ""Iso-Trop-I""" &
        "}," &
        "{" &
        "    ""dataElement"": ""RqSKEolefFR""," &
        "    ""categoryOptionCombo"": ""kdsirVNKdhm""," &
        "    ""value"": """ & txt121.Text & """," &
        "    ""comment"": ""Others""" &
        "}" &
     "]" &
 "}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnBactPush_Click(sender As Object, e As EventArgs) Handles BtnBactPush.Click


        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
        {" &
    """dataElement"": ""coBAbfppycX""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt122.Text & """," &
    """comment"": ""Bacteriology-Gram Stain""" &
"}," &
"{" &
    """dataElement"": ""it4JusH87Wk""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt123.Text & """," &
    """comment"": ""Culture Blood""" &
"}," &
"{" &
    """dataElement"": ""sLACvSMlg2x""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt124.Text & """," &
    """comment"": ""Culture Urine""" &
"}," &
"{" &
    """dataElement"": ""xMXbKs6edeu""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt125.Text & """," &
    """comment"": ""Culture Body Fluid""" &
"}," &
"{" &
    """dataElement"": ""MkoyR8apLNJ""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt126.Text & """," &
    """comment"": ""Culture Swab""" &
"}," &
"{" &
    """dataElement"": ""llI4WtU0scF""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt127.Text & """," &
    """comment"": ""Culture Stool""" &
"}," &
"{" &
    """dataElement"": ""mV5BSo4BMEk""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt128.Text & """," &
    """comment"": ""Culture Water""" &
"}," &
"{" &
    """dataElement"": ""kp79HNscnxJ""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt129.Text & """," &
    """comment"": ""Culture Pus""" &
"}," &
"{" &
    """dataElement"": ""dXK9lQSnxrg""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt130.Text & """," &
    """comment"": ""Culture Sputum""" &
"}," &
"{" &
    """dataElement"": ""gvv8uQaWTcW""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt131.Text & """," &
    """comment"": ""Culture CSF""" &
"}," &
"{" &
    """dataElement"": ""BcUCgFWFJBe""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt132.Text & """," &
    """comment"": ""Culture Others""" &
"}," &
"{" &
    """dataElement"": ""iHLe8HKsB3K""," &
    """categoryOptionCombo"": ""A0ezJDD4TfL""," &
    """value"": """ & txt133.Text & """," &
    """comment"": ""Sputum AFB""" &
"}," &
"{" &
    """dataElement"": ""sgUz4KSpNIA""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt134.Text & """," &
    """comment"": ""Other AFB""" &
"}," &
"{" &
    """dataElement"": ""Lruh22ELAGR""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt135.Text & """," &
    """comment"": ""Leprosy Smear""" &
"}," &
"{" &
    """dataElement"": ""Av4WfkcxAQA""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt136.Text & """," &
    """comment"": ""India Ink Test""" &
"}," &
"{" &
    """dataElement"": ""HOAJkAvmzz4""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt137.Text & """," &
    """comment"": ""Anaerobic Culture""" &
"}," &
"{" &
    """dataElement"": ""Ko8Z7R3PaN2""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt138.Text & """," &
    """comment"": ""Fungus KOH Test""" &
"}," &
"{" &
    """dataElement"": ""KaPqUD0bWdd""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt139.Text & """," &
    """comment"": ""Fungus Culture""" &
"}," &
"{" &
    """dataElement"": ""VTEmZoEWvp1""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt140.Text & """," &
    """comment"": ""Others""" &
"}" &
"]" &
"}"


        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)

    End Sub

    Private Sub BtnVirgoPush_Click(sender As Object, e As EventArgs) Handles BtnVirgoPush.Click

        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
   """dataElement"": ""HJpcsC6D0at""," &
   """categoryOptionCombo"": ""A0ezJDD4TfL""," &
   """value"": """ & txt141.Text & """," &
   """comment"": ""HIV RDT Total""" &
"}," &
"{" &
   """dataElement"": ""HJpcsC6D0at""," &
   """categoryOptionCombo"": ""wCvNkhhbSbl""," &
   """value"": """ & txt142.Text & """," &
   """comment"": ""HIV RDT +Ve""" &
"}," &
"{" &
   """dataElement"": ""X8FtE4lSQYQ""," &
   """categoryOptionCombo"": ""A0ezJDD4TfL""," &
   """value"": """ & txt143.Text & """," &
   """comment"": ""HBSAg RDT Total""" &
"}," &
"{" &
   """dataElement"": ""X8FtE4lSQYQ""," &
   """categoryOptionCombo"": ""wCvNkhhbSbl""," &
   """value"": """ & txt144.Text & """," &
   """comment"": ""HBSAg RDT +Ve""" &
"}," &
"{" &
   """dataElement"": ""AETUEJEkhGk""," &
   """categoryOptionCombo"": ""A0ezJDD4TfL""," &
   """value"": """ & txt145.Text & """," &
   """comment"": ""HCV RDT Total""" &
"}," &
"{" &
   """dataElement"": ""AETUEJEkhGk""," &
   """categoryOptionCombo"": ""wCvNkhhbSbl""," &
   """value"": """ & txt146.Text & """," &
   """comment"": ""HCV RDT +Ve""" &
"}," &
"{" &
   """dataElement"": ""NkGOcGwTbsy""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt147.Text & """," &
   """comment"": ""HIV ELISA/CLIA Total""" &
"}," &
"{" &
   """dataElement"": ""pnHCOiMByVG""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt148.Text & """," &
   """comment"": ""HIV ELISA/CLIA + Ve""" &
"}," &
"{" &
   """dataElement"": ""IgK9Nv2q8ay""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt149.Text & """," &
   """comment"": ""HAV ELISA/CLIA Total""" &
"}," &
"{" &
   """dataElement"": ""gh8PuXfYKGn""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt150.Text & """," &
   """comment"": ""HAV ELISA/CLIA +Ve""" &
"}," &
"{" &
   """dataElement"": ""XyVUts5xSAc""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt151.Text & """," &
   """comment"": ""HBsAg ELISA/CLIA Total""" &
"}," &
"{" &
   """dataElement"": ""NWgPfhRvUBB""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt152.Text & """," &
   """comment"": ""HBsAg ELISA/CLIA +Ve""" &
"}," &
"{" &
   """dataElement"": ""LaF7BzXQSKV""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt153.Text & """," &
   """comment"": ""HCV ELISA/CLIA Total""" &
"}," &
"{" &
   """dataElement"": ""GKiu4RclCUe""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt154.Text & """," &
   """comment"": ""HCV ELISA/CLIA +Ve""" &
"}," &
"{" &
   """dataElement"": ""WmSJOvBs3Ck""," &
   """categoryOptionCombo"": ""A0ezJDD4TfL""," &
   """value"": """ & txt155.Text & """," &
   """comment"": ""HEV ELISA/CLIA Total""" &
"}," &
"{" &
   """dataElement"": ""WmSJOvBs3Ck""," &
   """categoryOptionCombo"": ""wCvNkhhbSbl""," &
   """value"": """ & txt156.Text & """," &
   """comment"": ""HEV ELISA/CLIA +Ve""" &
"}," &
"{" &
   """dataElement"": ""xcxZPAxhCrT""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt157.Text & """," &
   """comment"": ""Anti-HBs""" &
"}," &
"{" &
   """dataElement"": ""dVvGXhFywu7""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt158.Text & """," &
   """comment"": ""HBeAg""" &
"}," &
"{" &
   """dataElement"": ""X5nw2T7NV8r""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt159.Text & """," &
   """comment"": ""Anti-HBe""" &
"}," &
"{" &
   """dataElement"": ""BZIy8aFttCi""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt160.Text & """," &
   """comment"": ""HBcAg""" &
"}," &
"{" &
   """dataElement"": ""T4Q5ABFtjDP""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt161.Text & """," &
   """comment"": ""Anti HBcAg""" &
"}," &
"{" &
   """dataElement"": ""HQr6MM8GsjH""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt162.Text & """," &
   """comment"": ""Western blot""" &
"}," &
"{" &
   """dataElement"": ""ujt1GxVHLHV""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt163.Text & """," &
   """comment"": ""CD4 count""" &
"}," &
"{" &
   """dataElement"": ""DcQtyLaLoCx""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt164.Text & """," &
   """comment"": ""Viral load""" &
"}," &
"{" &
   """dataElement"": ""vmRFuQZTS6N""," &
   """categoryOptionCombo"": ""kdsirVNKdhm""," &
   """value"": """ & txt165.Text & """," &
   """comment"": ""Others""" &
"}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)

    End Sub

    Private Sub BtnParasiPush_Click(sender As Object, e As EventArgs) Handles BtnParasiPush.Click

        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
    """dataElement"": ""b3zYEkHFmat""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt166.Text & """," &
    """comment"": ""Stool R/E""" &
"}," &
"{" &
    """dataElement"": ""z9i5nhshIPk""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt167.Text & """," &
    """comment"": ""Occult blood""" &
"}," &
"{" &
    """dataElement"": ""aydXkBquvXP""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt168.Text & """," &
    """comment"": ""Reducing Sugar""" &
"}," &
"{" &
    """dataElement"": ""PX30ls6pIRm""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt169.Text & """," &
    """comment"": ""Urine R/E""" &
"}," &
"{" &
    """dataElement"": ""KC4gQ1lbXAg""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt170.Text & """," &
    """comment"": ""Bile salts""" &
"}," &
"{" &
    """dataElement"": ""uVcWLuam362""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt171.Text & """," &
    """comment"": ""Bile pigments""" &
"}," &
"{" &
    """dataElement"": ""XEe49IIPcoD""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt172.Text & """," &
    """comment"": ""Urobilinogen""" &
"}," &
"{" &
    """dataElement"": ""pZSos4N7N2Y""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt173.Text & """," &
    """comment"": ""Urobilinogen""" &
"}," &
"{" &
    """dataElement"": ""W1DQovLs4sh""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt174.Text & """," &
    """comment"": ""Acetone""" &
"}," &
"{" &
    """dataElement"": ""rzfTpDSCtgk""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt175.Text & """," &
    """comment"": ""Chyle""" &
"}," &
"{" &
    """dataElement"": ""rhxy310LFSm""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt176.Text & """," &
    """comment"": ""Specific Gravity""" &
"}," &
"{" &
    """dataElement"": ""cGHCgAKZnjR""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt177.Text & """," &
    """comment"": ""Bence Jones Protin""" &
"}," &
"{" &
    """dataElement"": ""SXwweKinsnK""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt178.Text & """," &
    """comment"": ""Semen anlysis""" &
"}," &
"{" &
    """dataElement"": ""uWALxnktvW8""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt179.Text & """," &
    """comment"": ""Others""" &
"}" &
"]" &
"}"



        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)

    End Sub

    Private Sub BtnHormonePush_Click(sender As Object, e As EventArgs) Handles BtnHormonePush.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
    """dataElement"": ""LzXPUrRvir7""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt180.Text & """," &
    """comment"": "" HORMONE/ENDOCRINE-T3""" &
"}," &
"{" &
    """dataElement"": ""WqsPscUDVDk""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt181.Text & """," &
    """comment"": ""T4""" &
"}," &
"{" &
    """dataElement"": ""QsKf27NOrBI""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt182.Text & """," &
    """comment"": ""TSH""" &
"}," &
"{" &
    """dataElement"": ""qHhZNumTNcz""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt183.Text & """," &
    """comment"": ""Cortisol""" &
"}," &
"{" &
    """dataElement"": ""vdMAkrFTc6e""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt184.Text & """," &
    """comment"": ""AFP""" &
"}," &
"{" &
    """dataElement"": ""W7tq5I1K1BO""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt185.Text & """," &
    """comment"": ""LH""" &
"}," &
"{" &
    """dataElement"": ""rUL3GChBDhn""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt186.Text & """," &
    """comment"": ""FSH""" &
"}," &
"{" &
    """dataElement"": ""c0JMi1fDGqe""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt187.Text & """," &
    """comment"": ""Prolactin""" &
"}," &
"{" &
    """dataElement"": ""V8mAXNggfSP""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt188.Text & """," &
    """comment"": ""Oestrogen""" &
"}," &
"{" &
    """dataElement"": ""o6U9cg57pSH""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt189.Text & """," &
    """comment"": ""Progesterone""" &
"}," &
"{" &
    """dataElement"": ""GOMZ5qZQVs7""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt190.Text & """," &
    """comment"": ""Testosterone""" &
"}," &
"{" &
    """dataElement"": ""ad7l9UXQ95i""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt191.Text & """," &
    """comment"": ""Vit. D""" &
"}," &
"{" &
    """dataElement"": ""W58gwBA5MiV""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt192.Text & """," &
    """comment"": ""Vit. B12""" &
"}," &
"{" &
    """dataElement"": ""O2l3vMZAkYD""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt193.Text & """," &
    """comment"": ""Others""" &
"}" &
"]" &
"}"



        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)

    End Sub

    Private Sub BtnDrugPush_Click(sender As Object, e As EventArgs) Handles BtnDrugPush.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
    {" &
    """dataElement"": ""mMckO2ciFc8""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt194.Text & """," &
    """comment"": ""DRUNG ANALYSIS- Carbamazepine""" &
"}," &
"{" &
    """dataElement"": ""dSvjfeY3o91""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt195.Text & """," &
    """comment"": ""Cyclosporine""" &
"}," &
"{" &
    """dataElement"": ""Buc8Fke2SMT""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt196.Text & """," &
    """comment"": ""Valporic acid""" &
"}," &
"{" &
    """dataElement"": ""d6EvPlKfJLX""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt197.Text & """," &
    """comment"": ""Phenytoin""" &
"}," &
"{" &
    """dataElement"": ""gBGJ7ghPg92""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt198.Text & """," &
    """comment"": ""Digoxine""" &
"}," &
"{" &
    """dataElement"": ""rolQymvE0V7""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt199.Text & """," &
    """comment"": ""Tacrolimus""" &
"}," &
"{" &
    """dataElement"": ""aFxFDDT7Oaf""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt200.Text & """," &
    """comment"": ""Others""" &
"}" &
"]" &
"}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)

    End Sub

    Private Sub BtnHistoPush_Click(sender As Object, e As EventArgs) Handles BtnHistoPush.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
   {" &
    """dataElement"": ""CLAPaXEhw5K""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt201.Text & """," &
    """comment"": ""HISTOPATHOLOGY/ CYTOLOGY Biopsy H & E""" &
"}," &
"{" &
    """dataElement"": ""GavlUw7f7UO""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt202.Text & """," &
    """comment"": ""Biopsy H & E Others""" &
"}," &
"{" &
    """dataElement"": ""U2jRar05uYB""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt203.Text & """," &
    """comment"": ""Cytology Pap""" &
"}," &
"{" &
    """dataElement"": ""CqTFn3gaaxt""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt204.Text & """," &
    """comment"": ""Cytology Giemsa""" &
"}," &
"{" &
    """dataElement"": ""NjfwcREF9Ro""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt205.Text & """," &
    """comment"": ""Cytology Others""" &
"}" &
"]" &
"}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnImmHistoPush_Click(sender As Object, e As EventArgs) Handles BtnImmHistoPush.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
   {" &
    """dataElement"": ""G2cxwinrrRA""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt206.Text & """," &
    """comment"": ""IMMUNO-HISTO CHEMISTRY ER""" &
"}," &
"{" &
    """dataElement"": ""QAKH6RCErmb""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt207.Text & """," &
    """comment"": ""PR""" &
"}," &
"{" &
    """dataElement"": ""OAX1MLXQ5JV""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt208.Text & """," &
    """comment"": ""G-FAP""" &
"}," &
"{" &
    """dataElement"": ""eMDAo089gz3""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt209.Text & """," &
    """comment"": ""S-100""" &
"}," &
"{" &
    """dataElement"": ""V89xWqV2EGN""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt210.Text & """," &
    """comment"": ""Vimentin""" &
"}," &
"{" &
    """dataElement"": ""AhRD9oaSjeL""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt211.Text & """," &
    """comment"": ""Cytokeratin""" &
"}," &
"{" &
    """dataElement"": ""kZZRJEecl4i""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt212.Text & """," &
    """comment"": ""Others""" &
"}" &
"]" &
"}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnMoleFlowPush_Click(sender As Object, e As EventArgs) Handles BtnMoleFlowPush.Click
        Dim jsonData As String = "{
    ""dataSet"": """ & dataSetId & """, 
    ""completeDate"": """ & todayDate & """, 
    ""period"": """ & period & """, 
    ""orgUnit"": """ & orgUnitId & """, 
    ""attributeOptionCombo"": """", 
    ""dataValues"": [
   {" &
    """dataElement"": ""OHLcnsYbP4u""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt213.Text & """," &
    """comment"": ""MOLECULAR LAB & FLOWCYTOMETRY Covid-19 PCR""" &
"}," &
"{" &
    """dataElement"": ""T7Q1TLmqZSn""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt214.Text & """," &
    """comment"": ""Influenza""" &
"}," &
"{" &
    """dataElement"": ""keYqBgyPBPJ""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & txt215.Text & """," &
    """comment"": ""Leukemia Panel""" &
"}" &
"]" &
"}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub
End Class