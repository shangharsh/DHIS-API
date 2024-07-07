Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq
Public Class ChildHoodIllnesses
    Dim dataSetId As String = "wFShrjdBjpR" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"

    Private Sub BtnInfantPush_Click(sender As Object, e As EventArgs) Handles BtnInfantPush.Click

        Dim jsonData As String = "{" &
    """dataSet"": ""HMy0VijjNDb""," &
    """completeDate"": ""2024-07-07""," &
    """period"": ""208102""," &
    """orgUnit"": ""aUv4lHwAFh9""," &
    """attributeOptionCombo"": """"," &
    """dataValues"": [" &
        "{" &
            """dataElement"": ""UbOzhGOJdrq""," &
            """categoryOptionCombo"": ""MMj2Dc8TvgL""," &
            """value"": """ & TextBox1.Text & """," &
            """comment"": ""जम्मा बिरामी ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""UbOzhGOJdrq""," &
            """categoryOptionCombo"": ""ZQJ5pcgH1lJ""," &
            """value"": """ & TextBox2.Text & """," &
            """comment"": ""जम्मा बिरामी २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""ISzvhZycG3z""," &
            """categoryOptionCombo"": ""MMj2Dc8TvgL""," &
            """value"": """ & TextBox3.Text & """," &
            """comment"": ""गम्भीर संक्रमण ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""ISzvhZycG3z""," &
            """categoryOptionCombo"": ""ZQJ5pcgH1lJ""," &
            """value"": """ & TextBox4.Text & """," &
            """comment"": ""गम्भीर संक्रमण २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""tAP3rTyoghm""," &
            """categoryOptionCombo"": ""J0QYmZGlEii""," &
            """value"": """ & TextBox5.Text & """," &
            """comment"": ""निमोनिया  ८-२८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""oakKv5hX3tb""," &
            """categoryOptionCombo"": ""J0QYmZGlEii""," &
            """value"": """ & TextBox6.Text & """," &
            """comment"": ""निमोनिया  २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""YXIPqFIPsjg""," &
            """categoryOptionCombo"": ""MMj2Dc8TvgL""," &
            """value"": """ & TextBox7.Text & """," &
            """comment"": ""स्थानिय संक्रमण  ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""YXIPqFIPsjg""," &
            """categoryOptionCombo"": ""ZQJ5pcgH1lJ""," &
            """value"": """ & TextBox8.Text & """," &
            """comment"": ""स्थानिय संक्रमण  २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""IDbh8WJcQsP""," &
            """categoryOptionCombo"": ""MMj2Dc8TvgL""," &
            """value"": """ & TextBox9.Text & """," &
            """comment"": ""कडा कमल पित्त (जण्डिस) ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""IDbh8WJcQsP""," &
            """categoryOptionCombo"": ""ZQJ5pcgH1lJ""," &
            """value"": """ & TextBox10.Text & """," &
            """comment"": ""कडा कमल पित्त (जण्डिस) २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""fmCWNnmldW4""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox11.Text & """," &
            """comment"": ""कम तौल ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""aFgNWKMgYz9""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox12.Text & """," &
            """comment"": ""कम तौल २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""scY0Di7FwBx""," &
            """categoryOptionCombo"": ""J0QYmZGlEii""," &
            """value"": """ & TextBox13.Text & """," &
            """comment"": ""स्तनपान सम्बन्धि समस्या ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""zXSsKcH6bfe""," &
            """categoryOptionCombo"": ""J0QYmZGlEii""," &
            """value"": """ & TextBox14.Text & """," &
            """comment"": ""स्तनपान सम्बन्धि समस्या २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""lfjCh0FyKSc""," &
            """categoryOptionCombo"": ""MMj2Dc8TvgL""," &
            """value"": """ & TextBox15.Text & """," &
            """comment"": ""एम्पिसिलिन ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""lfjCh0FyKSc""," &
            """categoryOptionCombo"": ""ZQJ5pcgH1lJ""," &
            """value"": """ & TextBox16.Text & """," &
            """comment"": ""एम्पिसिलिन २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""zxN7niCGtSh""," &
            """categoryOptionCombo"": ""MMj2Dc8TvgL""," &
            """value"": """ & TextBox17.Text & """," &
            """comment"": ""एमोक्सिसिलिन  ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""zxN7niCGtSh""," &
            """categoryOptionCombo"": ""ZQJ5pcgH1lJ""," &
            """value"": """ & TextBox18.Text & """," &
            """comment"": ""एमोक्सिसिलिन  २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""fK36K8WBX9s""," &
            """categoryOptionCombo"": ""J0QYmZGlEii""," &
            """value"": """ & TextBox19.Text & """," &
            """comment"": ""जेन्टामाइसिन पहिलो डोज """ &
        "}," &
        "{" &
            """dataElement"": ""Q5YnsomfHvO""," &
            """categoryOptionCombo"": ""J0QYmZGlEii""," &
            """value"": """ & TextBox20.Text & """," &
            """comment"": ""जेन्टामाइसिन पुरा डोज """ &
        "}," &
        "{" &
            """dataElement"": ""TwMrwcnwuSO""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox21.Text & """," &
            """comment"": ""अन्य एन्टीबायोटिक """ &
        "}," &
        "{" &
            """dataElement"": ""kqspOhPReRm""," &
            """categoryOptionCombo"": ""MMj2Dc8TvgL""," &
            """value"": """ & TextBox22.Text & """," &
            """comment"": ""रेफ़र ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""kqspOhPReRm""," &
            """categoryOptionCombo"": ""ZQJ5pcgH1lJ""," &
            """value"": """ & TextBox23.Text & """," &
            """comment"": ""रेफ़र २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""WoIzHgdHUjE""," &
            """categoryOptionCombo"": ""J0QYmZGlEii""," &
            """value"": """ & TextBox24.Text & """," &
            """comment"": ""फलोअप """ &
        "}," &
        "{" &
            """dataElement"": ""wxvQ7RxWrP7""," &
            """categoryOptionCombo"": ""J0QYmZGlEii""," &
            """value"": """ & TextBox25.Text & """," &
            """comment"": ""मृत्यु ०-७ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""dKnUYrvpI0f""," &
            """categoryOptionCombo"": ""J0QYmZGlEii""," &
            """value"": """ & TextBox26.Text & """," &
            """comment"": ""मृत्यु ८-२८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""adiGRH9XgjW""," &
            """categoryOptionCombo"": ""ZQJ5pcgH1lJ""," &
            """value"": """ & TextBox27.Text & """," &
            """comment"": ""मृत्यु २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""UbOzhGOJdrq""," &
            """categoryOptionCombo"": ""JJ0l4lSWujm""," &
            """value"": """ & TextBox28.Text & """," &
            """comment"": ""जम्मा बिरामी ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""UbOzhGOJdrq""," &
            """categoryOptionCombo"": ""tZKohdpSDP9""," &
            """value"": """ & TextBox29.Text & """," &
            """comment"": ""जम्मा बिरामी २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""ISzvhZycG3z""," &
            """categoryOptionCombo"": ""JJ0l4lSWujm""," &
            """value"": """ & TextBox30.Text & """," &
            """comment"": ""गम्भीर संक्रमण ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""ISzvhZycG3z""," &
            """categoryOptionCombo"": ""tZKohdpSDP9""," &
            """value"": """ & TextBox31.Text & """," &
            """comment"": ""गम्भीर संक्रमण २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""tAP3rTyoghm""," &
            """categoryOptionCombo"": ""m7ap9PHprpW""," &
            """value"": """ & TextBox32.Text & """," &
            """comment"": ""निमोनिया  ८-२८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""oakKv5hX3tb""," &
            """categoryOptionCombo"": ""m7ap9PHprpW""," &
            """value"": """ & TextBox33.Text & """," &
            """comment"": ""निमोनिया  २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""YXIPqFIPsjg""," &
            """categoryOptionCombo"": ""JJ0l4lSWujm""," &
            """value"": """ & TextBox34.Text & """," &
            """comment"": ""स्थानिय संक्रमण  ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""YXIPqFIPsjg""," &
            """categoryOptionCombo"": ""tZKohdpSDP9""," &
            """value"": """ & TextBox35.Text & """," &
            """comment"": ""स्थानिय संक्रमण  २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""IDbh8WJcQsP""," &
            """categoryOptionCombo"": ""JJ0l4lSWujm""," &
            """value"": """ & TextBox36.Text & """," &
            """comment"": ""कडा कमल पित्त (जण्डिस) ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""IDbh8WJcQsP""," &
            """categoryOptionCombo"": ""tZKohdpSDP9""," &
            """value"": """ & TextBox37.Text & """," &
            """comment"": ""कडा कमल पित्त (जण्डिस) २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""IAfe8CZ6PCM""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox38.Text & """," &
            """comment"": ""कम तौल ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""tYyLoweDDzH""," &
            """categoryOptionCombo"": ""kdsirVNKdhm""," &
            """value"": """ & TextBox39.Text & """," &
            """comment"": ""कम तौल २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""scY0Di7FwBx""," &
            """categoryOptionCombo"": ""m7ap9PHprpW""," &
            """value"": """ & TextBox40.Text & """," &
            """comment"": ""स्तनपान सम्बन्धि समस्या ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""zXSsKcH6bfe""," &
            """categoryOptionCombo"": ""m7ap9PHprpW""," &
            """value"": """ & TextBox41.Text & """," &
            """comment"": ""स्तनपान सम्बन्धि समस्या २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""lfjCh0FyKSc""," &
            """categoryOptionCombo"": ""JJ0l4lSWujm""," &
            """value"": """ & TextBox42.Text & """," &
            """comment"": ""एम्पिसिलिन ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""lfjCh0FyKSc""," &
            """categoryOptionCombo"": ""tZKohdpSDP9""," &
            """value"": """ & TextBox43.Text & """," &
            """comment"": ""एम्पिसिलिन २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""zxN7niCGtSh""," &
            """categoryOptionCombo"": ""JJ0l4lSWujm""," &
            """value"": """ & TextBox44.Text & """," &
            """comment"": ""एमोक्सिसिलिन  ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""zxN7niCGtSh""," &
            """categoryOptionCombo"": ""tZKohdpSDP9""," &
            """value"": """ & TextBox45.Text & """," &
            """comment"": ""एमोक्सिसिलिन  २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""fK36K8WBX9s""," &
            """categoryOptionCombo"": ""m7ap9PHprpW""," &
            """value"": """ & TextBox46.Text & """," &
            """comment"": ""जेन्टामाइसिन पहिलो डोज """ &
        "}," &
        "{" &
            """dataElement"": ""Q5YnsomfHvO""," &
            """categoryOptionCombo"": ""m7ap9PHprpW""," &
            """value"": """ & TextBox47.Text & """," &
            """comment"": ""जेन्टामाइसिन पुरा डोज """ &
        "}," &
        "{" &
            """dataElement"": ""kqspOhPReRm""," &
            """categoryOptionCombo"": ""JJ0l4lSWujm""," &
            """value"": """ & TextBox48.Text & """," &
            """comment"": ""रेफ़र ≤ २८ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""kqspOhPReRm""," &
            """categoryOptionCombo"": ""tZKohdpSDP9""," &
            """value"": """ & TextBox49.Text & """," &
            """comment"": ""रेफ़र २९-५९ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""WoIzHgdHUjE""," &
            """categoryOptionCombo"": ""m7ap9PHprpW""," &
            """value"": """ & TextBox50.Text & """," &
            """comment"": ""फलोअप """ &
        "}," &
        "{" &
            """dataElement"": ""wxvQ7RxWrP7""," &
            """categoryOptionCombo"": ""m7ap9PHprpW""," &
            """value"": """ & TextBox51.Text & """," &
            """comment"": ""मृत्यु ०-७ दिन """ &
        "}," &
        "{" &
            """dataElement"": ""dKnUYrvpI0f""," &
            """categoryOptionCombo"": ""m7ap9PHprpW""," &
            """value"": """ & TextBox52.Text & """," &
            """comment"": ""मृत्यु ८-२८ दिन  """ &
        "}," &
        "{" &
            """dataElement"": ""adiGRH9XgjW""," &
            """categoryOptionCombo"": ""tZKohdpSDP9""," &
            """value"": """ & TextBox53.Text & """," &
            """comment"": ""मृत्यु २९-५९ दिन """ &
        "}" &
        "]" &
        "}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnChildPush_Click(sender As Object, e As EventArgs) Handles BtnChildPush.Click

        Dim jsonData As String = "{" &
    """dataSet"": ""HMy0VijjNDb""," &
    """completeDate"": ""2024-07-07""," &
    """period"": ""208102""," &
    """orgUnit"": ""aUv4lHwAFh9""," &
    """attributeOptionCombo"": """"," &
    """dataValues"": [" &
"{" &
    """dataElement"": ""Qnq95LHLXG0""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox54.Text & """," &
    """comment"": ""जम्मा बिरामी बालक  """ &
    "}," &
    "{" &
    """dataElement"": ""Obq8rdOt6EP""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox55.Text & """," &
    """comment"": ""जम्मा बिरामी बालिका """ &
    "}," &
    "{" &
    """dataElement"": ""GC6lQSFDO5m""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox56.Text & """," &
    """comment"": ""निमोनिया नभएको रूघाखोकी """ &
    "}," &
    "{" &
    """dataElement"": ""GGkot8wSlCj""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox57.Text & """," &
    """comment"": ""निमोनिया""" &
    "}," &
    "{" &
    """dataElement"": ""KcPFNbB3UZg""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox58.Text & """," &
    """comment"": ""कडा निमोनिया/ धेरै कडा रोग """ &
    "}," &
    "{" &
    """dataElement"": ""A2lsvQ94qw5""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox59.Text & """," &
    """comment"": ""जलवियोजन नभएको """ &
    "}," &
    "{" &
    """dataElement"": ""SlIi0mTWXte""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox60.Text & """," &
    """comment"": ""केहि जलवियोजन """ &
    "}," &
    "{" &
    """dataElement"": ""Z7hy1EP2KW5""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox61.Text & """," &
    """comment"": ""कडा जलवियोजन """ &
    "}," &
    "{" &
    """dataElement"": ""KZzKMkn4H7q""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox62.Text & """," &
    """comment"": ""दीर्घ झाडापखाला """ &
    "}," &
    "{" &
    """dataElement"": ""sAdwOfXe6Ld""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox63.Text & """," &
    """comment"": ""ऑऊ/ रगत """ &
    "}," &
    "{" &
    """dataElement"": ""g4gt5htFQEZ""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox64.Text & """," &
    """comment"": ""फाल्सिप्यारम औलो  """ &
    "}," &
    "{" &
    """dataElement"": ""RByUk9PhqrG""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox65.Text & """," &
    """comment"": ""फाल्सिप्यारम नभएको औलो """ &
    "}," &
    "{" &
    """dataElement"": ""IM6lK8Mf0q1""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox66.Text & """," &
    """comment"": ""धेरै कडा ज्वरोजन्य रोग/""" &
    "}," &
    "{" &
    """dataElement"": ""fZEiEvVrr5K""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox67.Text & """," &
    """comment"": ""दादुरा """ &
    "}," &
    "{" &
    """dataElement"": ""o9sqrRiJzrZ""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox68.Text & """," &
    """comment"": ""कानको समस्या """ &
    "}," &
    "{" &
    """dataElement"": ""IXYmLRVEHc2""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox69.Text & """," &
    """comment"": ""ज्वरो """ &
    "}," &
    "{" &
    """dataElement"": ""v42lkXexjFS""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox70.Text & """," &
    """comment"": ""कडा कुपोषण """ &
    "}," &
    "{" &
    """dataElement"": ""YoaOO3Ib7KK""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox71.Text & """," &
    """comment"": ""मध्यम कुपोषण """ &
    "}," &
    "{" &
    """dataElement"": ""jg3YHWsBweg""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox72.Text & """," &
    """comment"": ""रक्त-अल्पता  """ &
    "}," &
    "{" &
    """dataElement"": ""YuNB9v6cf3x""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox73.Text & """," &
    """comment"": ""अन्य  """ &
    "}," &
    "{" &
    """dataElement"": ""C2QpFPSO3cn""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox74.Text & """," &
    """comment"": ""निमोनियाको लागि एमोक्सिसिलिन द्वारा उपचार """ &
    "}," &
    "{" &
    """dataElement"": ""H3GSFHu9DMV""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox75.Text & """," &
    """comment"": ""ओ. आर.एस. र जिंक चक्की """ &
    "}," &
    "{" &
    """dataElement"": ""PbkNwfEqhmR""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox76.Text & """," &
    """comment"": ""आइ. भी. फ्लुइड """ &
    "}," &
    "{" &
    """dataElement"": ""B713onHvu2I""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox77.Text & """," &
    """comment"": ""जुकाको औषधी""" &
    "}," &
    "{" &
    """dataElement"": ""iJzkUTWNH5a""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox78.Text & """," &
    """comment"": ""भिटामिन ए  """ &
    "}," &
    "{" &
    """dataElement"": ""cvo4qh1QkTA""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox79.Text & """," &
    """comment"": ""स्वास प्रस्वास """ &
    "}," &
    "{" &
    """dataElement"": ""CIO7DFOzXSy""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox80.Text & """," &
    """comment"": ""झाडापखाला   """ &
    "}," &
    "{" &
    """dataElement"": ""z8fdZad32Pv""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox81.Text & """," &
    """comment"": ""अन्य  """ &
    "}," &
    "{" &
    """dataElement"": ""ri3xWgIHsw1""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox82.Text & """," &
    """comment"": ""फलो अप """ &
    "}," &
    "{" &
    """dataElement"": ""R6GsecvoH7c""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox83.Text & """," &
    """comment"": ""स्वासप्रस्वास """ &
    "}," &
    "{" &
    """dataElement"": ""jfa1GkNMHfz""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox84.Text & """," &
    """comment"": ""झाडापखाला  """ &
    "}," &
    "{" &
    """dataElement"": ""upTQ8ZYfzRq""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox85.Text & """," &
    """comment"": ""अन्य""" &
    "}," &
    "{" &
    """dataElement"": ""gozGSASvOFN""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox86.Text & """," &
    """comment"": ""२ देखि ११ महिना """ &
    "}," &
    "{" &
    """dataElement"": ""yk0zxyPlEgV""," &
    """categoryOptionCombo"": ""J0QYmZGlEii""," &
    """value"": """ & TextBox87.Text & """," &
    """comment"": ""१२-५९ महिना """ &
    "}," &
    "{" &
    """dataElement"": ""Qnq95LHLXG0""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox88.Text & """," &
    """comment"": ""जम्मा बिरामी बालक  """ &
"},
{" &
    """dataElement"": ""Obq8rdOt6EP""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox89.Text & """," &
    """comment"": ""जम्मा बिरामी बालिका """ &
"},
{" &
    """dataElement"": ""GC6lQSFDO5m""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox90.Text & """," &
    """comment"": ""निमोनिया नभएको रूघाखोकी """ &
"},
{" &
    """dataElement"": ""GGkot8wSlCj""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox91.Text & """," &
    """comment"": ""निमोनिया""" &
"},
{" &
    """dataElement"": ""KcPFNbB3UZg""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox92.Text & """," &
    """comment"": ""कडा निमोनिया/ धेरै कडा रोग """ &
"},
{" &
    """dataElement"": ""A2lsvQ94qw5""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox93.Text & """," &
    """comment"": ""जलवियोजन नभएको """ &
"},
{" &
    """dataElement"": ""SlIi0mTWXte""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox94.Text & """," &
    """comment"": ""केहि जलवियोजन """ &
"},
{" &
    """dataElement"": ""Z7hy1EP2KW5""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox95.Text & """," &
    """comment"": ""कडा जलवियोजन """ &
"},
{" &
    """dataElement"": ""KZzKMkn4H7q""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox96.Text & """," &
    """comment"": ""दीर्घ झाडापखाला """ &
"},
{" &
    """dataElement"": ""sAdwOfXe6Ld""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox97.Text & """," &
    """comment"": ""ऑऊ/ रगत """ &
"},
{" &
    """dataElement"": ""UOgwWhba558""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox98.Text & """," &
    """comment"": ""फाल्सिप्यारम औलो  """ &
"},
{" &
    """dataElement"": ""X1MTNA29H5Z""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox99.Text & """," &
    """comment"": ""फाल्सिप्यारम नभएको औलो """ &
"},
{" &
    """dataElement"": ""IM6lK8Mf0q1""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox100.Text & """," &
    """comment"": ""धेरै कडा ज्वरोजन्य रोग/""" &
"},
{" &
    """dataElement"": ""fZEiEvVrr5K""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox101.Text & """," &
    """comment"": ""दादुरा """ &
"},
{" &
    """dataElement"": ""o9sqrRiJzrZ""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox102.Text & """," &
    """comment"": ""कानको समस्या """ &
"},
{" &
    """dataElement"": ""IXYmLRVEHc2""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox103.Text & """," &
    """comment"": ""ज्वरो """ &
"},
{" &
    """dataElement"": ""v42lkXexjFS""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox104.Text & """," &
    """comment"": ""कडा कुपोषण """ &
"},
{" &
    """dataElement"": ""YoaOO3Ib7KK""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox105.Text & """," &
    """comment"": ""मध्यम कुपोषण """ &
"},
{" &
    """dataElement"": ""jg3YHWsBweg""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox106.Text & """," &
    """comment"": ""रक्त-अल्पता  """ &
"},
{" &
    """dataElement"": ""YuNB9v6cf3x""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox107.Text & """," &
    """comment"": ""अन्य  """ &
"},
{" &
    """dataElement"": ""C2QpFPSO3cn""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox108.Text & """," &
    """comment"": ""निमोनियाको लागि एमोक्सिसिलिन द्वारा उपचार """ &
"},
{" &
    """dataElement"": ""H3GSFHu9DMV""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox109.Text & """," &
    """comment"": ""ओ. आर.एस. र जिंक चक्की """ &
"},
{" &
    """dataElement"": ""B713onHvu2I""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox110.Text & """," &
    """comment"": ""जुकाको औषधी""" &
"},
{" &
    """dataElement"": ""iJzkUTWNH5a""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox111.Text & """," &
    """comment"": ""भिटामिन ए  """ &
"},
{" &
    """dataElement"": ""cvo4qh1QkTA""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox112.Text & """," &
    """comment"": ""स्वास प्रस्वास """ &
"},
{" &
    """dataElement"": ""CIO7DFOzXSy""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox113.Text & """," &
    """comment"": ""झाडापखाला   """ &
"},
{" &
    """dataElement"": ""z8fdZad32Pv""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox114.Text & """," &
    """comment"": ""अन्य  """ &
"},
{" &
    """dataElement"": ""ri3xWgIHsw1""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox115.Text & """," &
    """comment"": ""फलो अप """ &
"},
{" &
    """dataElement"": ""R6GsecvoH7c""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox116.Text & """," &
    """comment"": ""स्वासप्रस्वास """ &
"},
{" &
    """dataElement"": ""jfa1GkNMHfz""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox117.Text & """," &
    """comment"": ""झाडापखाला  """ &
"},
{" &
    """dataElement"": ""upTQ8ZYfzRq""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox118.Text & """," &
    """comment"": ""अन्य""" &
"},
{" &
    """dataElement"": ""gozGSASvOFN""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox119.Text & """," &
    """comment"": ""२ देखि ११ महिना """ &
"},
{" &
    """dataElement"": ""yk0zxyPlEgV""," &
    """categoryOptionCombo"": ""m7ap9PHprpW""," &
    """value"": """ & TextBox120.Text & """," &
    """comment"": ""१२-५९ महिना """ &
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
                        Dim description As String = responseObject("description").ToString()
                        Dim status As String = responseObject("status").ToString()
                        MsgBox(status + " " + description)

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