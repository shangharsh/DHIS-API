Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq

Public Class LeprosyEliminationProgram
    Dim dataSetId As String = "rcs5vhrMJrQ" 'UID of Dataset
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
        """dataElement"": ""MLmqYWJGPJC""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox1.Text &"""," &
        """comment"": ""13.1 Female""" &
    "}," &
    "{" &
        """dataElement"": ""MLmqYWJGPJC""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox14.Text &"""," &
        """comment"": ""13.1 Male""" &
    "}," &
    "{" &
        """dataElement"": ""qxsOWzbKUaM""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox27.Text &"""," &
        """comment"": ""13.1 Female""" &
    "}," &
    "{" &
        """dataElement"": ""qxsOWzbKUaM""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox40.Text &"""," &
        """comment"": ""13.1 Male""" &
    "}," &
    "{" &
        """dataElement"": ""k4bqJU6Otyr""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox2.Text &"""," &
        """comment"": ""13.2 Female""" &
    "}," &
    "{" &
        """dataElement"": ""k4bqJU6Otyr""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox15.Text &"""," &
        """comment"": ""13.2 Male""" &
    "}," &
    "{" &
        """dataElement"": ""cg8bW1IGGY6""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox28.Text &"""," &
        """comment"": ""13.2 Female""" &
    "}," &
    "{" &
        """dataElement"": ""cg8bW1IGGY6""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox41.Text &"""," &
        """comment"": ""13.2 Male""" &
    "}," &
    "{" &
        """dataElement"": ""LhPiUHVF3qH""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox3.Text &"""," &
        """comment"": ""13.3 Female""" &
    "}," &
    "{" &
        """dataElement"": ""LhPiUHVF3qH""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox16.Text &"""," &
        """comment"": ""13.3 Male""" &
    "}," &
    "{" &
        """dataElement"": ""Umvs7eqA9bF""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox29.Text &"""," &
        """comment"": ""13.3 Female""" &
    "}," &
    "{" &
        """dataElement"": ""Umvs7eqA9bF""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox42.Text &"""," &
        """comment"": ""13.3 Male""" &
    "}," &
    "{" &
        """dataElement"": ""MDQuDIvcmDG""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox4.Text &"""," &
        """comment"": ""13.4 Female""" &
    "}," &
    "{" &
        """dataElement"": ""MDQuDIvcmDG""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox17.Text &"""," &
        """comment"": ""13.4 Male""" &
    "}," &
    "{" &
        """dataElement"": ""SqqmKBBO5dA""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox30.Text &"""," &
        """comment"": ""13.4 Female""" &
    "}," &
    "{" &
        """dataElement"": ""SqqmKBBO5dA""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox43.Text &"""," &
        """comment"": ""13.4 Male""" &
    "}," &
    "{" &
        """dataElement"": ""gKDp6rM5SKC""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox5.Text &"""," &
        """comment"": ""13.5 Female""" &
    "}," &
    "{" &
        """dataElement"": ""gKDp6rM5SKC""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox18.Text &"""," &
        """comment"": ""13.5 Male""" &
    "}," &
    "{" &
        """dataElement"": ""B0grizM21U0""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox31.Text &"""," &
        """comment"": ""13.5 Female""" &
    "}," &
    "{" &
        """dataElement"": ""B0grizM21U0""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox44.Text &"""," &
        """comment"": ""13.5 Male""" &
    "}," &
    "{" &
        """dataElement"": ""DZJiZ0jboiH""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox6.Text &"""," &
        """comment"": ""13.6 Female""" &
    "}," &
    "{" &
        """dataElement"": ""DZJiZ0jboiH""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox19.Text &"""," &
        """comment"": ""13.6 Male""" &
    "}," &
    "{" &
        """dataElement"": ""UXGX0txvV64""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox32.Text &"""," &
        """comment"": ""13.6 Female""" &
    "}," &
    "{" &
        """dataElement"": ""UXGX0txvV64""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox45.Text &"""," &
        """comment"": ""13.6 Male""" &
    "}," &
    "{" &
        """dataElement"": ""ymGtY0eS5Jc""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox8.Text &"""," &
        """comment"": ""13.8 Female""" &
    "}," &
    "{" &
        """dataElement"": ""ymGtY0eS5Jc""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox21.Text &"""," &
        """comment"": ""13.8 Male""" &
    "}," &
    "{" &
        """dataElement"": ""lr2c4SvhC5w""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox34.Text &"""," &
        """comment"": ""13.8 Female""" &
    "}," &
    "{" &
        """dataElement"": ""lr2c4SvhC5w""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox47.Text &"""," &
        """comment"": ""13.8 Male""" &
    "}," &
    "{" &
        """dataElement"": ""N097AQezHbX""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox9.Text &"""," &
        """comment"": ""13.9 Female""" &
    "}," &
    "{" &
        """dataElement"": ""N097AQezHbX""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox22.Text &"""," &
        """comment"": ""13.9 Male""" &
    "}," &
    "{" &
        """dataElement"": ""qyYAJ76ln2k""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox35.Text &"""," &
        """comment"": ""13.9 Female""" &
    "}," &
    "{" &
        """dataElement"": ""qyYAJ76ln2k""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox48.Text &"""," &
        """comment"": ""13.9 Male""" &
    "}," &
    "{" &
        """dataElement"": ""aCMvVLEtHKm""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox10.Text &"""," &
        """comment"": ""13.10 Female""" &
    "}," &
    "{" &
        """dataElement"": ""aCMvVLEtHKm""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox23.Text &"""," &
        """comment"": ""13.10 Male""" &
    "}," &
    "{" &
        """dataElement"": ""MIabZFoyiNa""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox36.Text &"""," &
        """comment"": ""13.10 Female""" &
    "}," &
    "{" &
        """dataElement"": ""MIabZFoyiNa""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox49.Text &"""," &
        """comment"": ""13.10 Male""" &
    "}," &
    "{" &
        """dataElement"": ""SzRGyOFmdjo""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox11.Text &"""," &
        """comment"": ""13.11 Female""" &
    "}," &
    "{" &
        """dataElement"": ""SzRGyOFmdjo""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox24.Text &"""," &
        """comment"": ""13.11 Male""" &
    "}," &
    "{" &
        """dataElement"": ""WPz17LTYpne""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox37.Text &"""," &
        """comment"": ""13.11 Female""" &
    "}," &
    "{" &
        """dataElement"": ""WPz17LTYpne""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox50.Text &"""," &
        """comment"": ""13.11 Male""" &
    "}," &
    "{" &
        """dataElement"": ""psRprHTmF2h""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox12.Text &"""," &
        """comment"": ""13.12 Female""" &
    "}," &
    "{" &
        """dataElement"": ""psRprHTmF2h""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox25.Text &"""," &
        """comment"": ""13.12 Male""" &
    "}," &
    "{" &
        """dataElement"": ""USNeEAsWwj9""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox38.Text &"""," &
        """comment"": ""13.12 Female""" &
    "}," &
    "{" &
        """dataElement"": ""USNeEAsWwj9""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox51.Text &"""," &
        """comment"": ""13.12 Male""" &
    "}," &
    "{" &
        """dataElement"": ""suBFDHxUSC8""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox54.Text &"""," &
        """comment"": ""13.15 Female""" &
    "}," &
    "{" &
        """dataElement"": ""suBFDHxUSC8""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox69.Text &"""," &
        """comment"": ""13.15 Male""" &
    "}," &
    "{" &
        """dataElement"": ""jOs9JAeA3Gd""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox84.Text &"""," &
        """comment"": ""13.15 Female""" &
    "}," &
    "{" &
        """dataElement"": ""jOs9JAeA3Gd""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox99.Text &"""," &
        """comment"": ""13.15 Male""" &
    "}," &
    "{" &
        """dataElement"": ""cSOdzmM0920""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox55.Text &"""," &
        """comment"": ""13.16 Female""" &
    "}," &
    "{" &
        """dataElement"": ""cSOdzmM0920""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox70.Text &"""," &
        """comment"": ""13.16 Male""" &
    "}," &
    "{" &
        """dataElement"": ""KFfj5Sr37F1""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox85.Text &"""," &
        """comment"": ""13.16 Female""" &
    "}," &
    "{" &
        """dataElement"": ""KFfj5Sr37F1""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox100.Text &"""," &
        """comment"": ""13.16 Male""" &
    "}," &
    "{" &
        """dataElement"": ""S0oeJ56oWxj""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox56.Text &"""," &
        """comment"": ""13.17 Female""" &
    "}," &
    "{" &
        """dataElement"": ""S0oeJ56oWxj""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox71.Text &"""," &
        """comment"": ""13.17 Male""" &
    "}," &
    "{" &
        """dataElement"": ""ihereZIMhXR""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox86.Text &"""," &
        """comment"": ""13.17 Female""" &
    "}," &
    "{" &
        """dataElement"": ""ihereZIMhXR""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox101.Text &"""," &
        """comment"": ""13.17 Male""" &
    "}," &
    "{" &
        """dataElement"": ""smIZPpDohxD""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox57.Text &"""," &
        """comment"": ""13.18 Female""" &
    "}," &
    "{" &
        """dataElement"": ""smIZPpDohxD""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox72.Text &"""," &
        """comment"": ""13.18 Male""" &
    "}," &
    "{" &
        """dataElement"": ""iPeIqZQP2tQ""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox87.Text &"""," &
        """comment"": ""13.18 Female""" &
    "}," &
    "{" &
        """dataElement"": ""iPeIqZQP2tQ""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox102.Text &"""," &
        """comment"": ""13.18 Male""" &
    "}," &
    "{" &
        """dataElement"": ""F0hciGYG6eG""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox58.Text &"""," &
        """comment"": ""13.19 Female""" &
    "}," &
    "{" &
        """dataElement"": ""F0hciGYG6eG""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox73.Text &"""," &
        """comment"": ""13.19 Male""" &
    "}," &
    "{" &
        """dataElement"": ""TzzsMDdJO9X""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox88.Text &"""," &
        """comment"": ""13.19 Female""" &
    "}," &
    "{" &
        """dataElement"": ""TzzsMDdJO9X""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox103.Text &"""," &
        """comment"": ""13.19 Male""" &
    "}," &
    "{" &
        """dataElement"": ""nKZuK28KQbP""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox59.Text &"""," &
        """comment"": ""13.19 Female""" &
    "}," &
    "{" &
        """dataElement"": ""nKZuK28KQbP""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox74.Text &"""," &
        """comment"": ""13.19 Male""" &
    "}," &
    "{" &
        """dataElement"": ""dVXOa44UROn""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox89.Text &"""," &
        """comment"": ""13.19 Female""" &
    "}," &
    "{" &
        """dataElement"": ""dVXOa44UROn""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox104.Text &"""," &
        """comment"": ""13.19 Male""" &
    "}," &
    "{" &
        """dataElement"": ""RROFqu9js1F""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox60.Text &"""," &
        """comment"": ""13.19 Female""" &
    "}," &
    "{" &
        """dataElement"": ""RROFqu9js1F""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox75.Text &"""," &
        """comment"": ""13.19 Male""" &
    "}," &
    "{" &
        """dataElement"": ""WrXDFYXSDfm""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox90.Text &"""," &
        """comment"": ""13.19 Female""" &
    "}," &
    "{" &
        """dataElement"": ""WrXDFYXSDfm""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox105.Text &"""," &
        """comment"": ""13.19 Male""" &
    "}," &
     "{" &
        """dataElement"": ""h4EslU0KJu9""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox61.Text &"""," &
        """comment"": ""13.21 Female""" &
    "}," &
    "{" &
        """dataElement"": ""h4EslU0KJu9""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox76.Text &"""," &
        """comment"": ""13.21 Male""" &
    "}," &
    "{" &
        """dataElement"": ""hKndvUVMnSv""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox91.Text &"""," &
        """comment"": ""13.21 Female""" &
    "}," &
    "{" &
        """dataElement"": ""hKndvUVMnSv""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox106.Text &"""," &
        """comment"": ""13.21 Male""" &
    "}," &
    "{" &
        """dataElement"": ""Ng5TJftVtns""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox62.Text &"""," &
        """comment"": ""13.22 Female""" &
    "}," &
    "{" &
        """dataElement"": ""Ng5TJftVtns""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox77.Text &"""," &
        """comment"": ""13.22 Male""" &
    "}," &
    "{" &
        """dataElement"": ""BFV9tgdwFkw""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox92.Text &"""," &
        """comment"": ""13.22 Female""" &
    "}," &
    "{" &
        """dataElement"": ""BFV9tgdwFkw""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox107.Text &"""," &
        """comment"": ""13.22 Male""" &
    "}," &
    "{" &
        """dataElement"": ""tY0Vtlu8zrN""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox63.Text &"""," &
        """comment"": ""13.23 Female""" &
    "}," &
    "{" &
        """dataElement"": ""tY0Vtlu8zrN""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox78.Text &"""," &
        """comment"": ""13.23 Male""" &
    "}," &
    "{" &
        """dataElement"": ""LjMLRDTXK1Q""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox93.Text &"""," &
        """comment"": ""13.23 Female""" &
    "}," &
    "{" &
        """dataElement"": ""LjMLRDTXK1Q""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox108.Text &"""," &
        """comment"": ""13.23 Male""" &
    "}," &
    "{" &
        """dataElement"": ""yQAJRHA98rk""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox64.Text &"""," &
        """comment"": ""13.24 Female""" &
    "}," &
    "{" &
        """dataElement"": ""yQAJRHA98rk""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox79.Text &"""," &
        """comment"": ""13.24 Male""" &
    "}," &
    "{" &
        """dataElement"": ""omBX28e1CIx""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox94.Text &"""," &
        """comment"": ""13.24 Female""" &
    "}," &
    "{" &
        """dataElement"": ""omBX28e1CIx""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox109.Text &"""," &
        """comment"": ""13.24 Male""" &
    "}," &
    "{" &
        """dataElement"": ""iDnNoRsZkIE""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox65.Text &"""," &
        """comment"": ""13.25 Female""" &
    "}," &
    "{" &
        """dataElement"": ""iDnNoRsZkIE""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox80.Text &"""," &
        """comment"": ""13.25 Male""" &
    "}," &
    "{" &
        """dataElement"": ""lSs37DZDKzm""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """&TextBox95.Text &"""," &
        """comment"": ""13.25 Female""" &
    "}," &
    "{" &
        """dataElement"": ""lSs37DZDKzm""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """&TextBox110.Text &"""," &
        """comment"": ""13.25 Male""" &
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class