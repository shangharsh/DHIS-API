Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class IndoorServices
    Dim dataSetId As String = "wFShrjdBjpR" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "208102" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "aUv4lHwAFh9" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease

    Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
    Dim userName As String = "baghauda.hosp"
    Dim passWord As String = "Hmis@3344"

    Private Sub BtnNeoPush_Click(sender As Object, e As EventArgs) Handles BtnNeoPush.Click
        Dim jsonData As String = "{" &
  """dataSet"": """ & dataSetId & """," &
  """completeDate"": """ & todayDate & """," &
  """period"": """ & period & """," &
  """orgUnit"": """ & orgUnitId & """," &
  """attributeOptionCombo"": """"," &
  """dataValues"": [" &
  "{" &
    """dataElement"": ""Iyu2jI3uZLe""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox169.Text & """," &
    """comment"": ""Primi 22-27""" &
    "}," &
    "{" &
    """dataElement"": ""XfaiH4LO4HU""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox170.Text & """," &
    """comment"": ""Primi 28-36""" &
    "}," &
    "{" &
    """dataElement"": ""J16O3bLT94B""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox171.Text & """," &
    """comment"": ""Primi 37-41""" &
    "}," &
    "{" &
    """dataElement"": ""Wz9lyL4EFgc""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox172.Text & """," &
    """comment"": ""Primi ≥ 42""" &
    "}," &
    "{" &
    """dataElement"": ""OQ4CxYP11zR""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox173.Text & """," &
    """comment"": ""Multi 22-27""" &
    "}," &
    "{" &
    """dataElement"": ""kK32tZ49ToM""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox174.Text & """," &
    """comment"": ""Multi 28-36""" &
    "}," &
    "{" &
    """dataElement"": ""Wz6fi5h43ln""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox175.Text & """," &
    """comment"": ""Multi 37-41""" &
    "}," &
    "{" &
    """dataElement"": ""f95dTxsNaOr""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox176.Text & """," &
    """comment"": ""Multi ≥ 42""" &
    "}," &
    "{" &
    """dataElement"": ""ErsRqXBszJe""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox177.Text & """," &
    """comment"": ""Grand Multi 22-27""" &
    "}," &
    "{" &
    """dataElement"": ""GU5n3qxVV1G""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox178.Text & """," &
    """comment"": ""Grand Multi 28-36""" &
    "}," &
    "{" &
    """dataElement"": ""FeOTYqWEND5""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox179.Text & """," &
    """comment"": ""Grand Multi 37-41""" &
    "}," &
    "{" &
    """dataElement"": ""fgGIHbLGHr3""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox180.Text & """," &
    """comment"": ""Grand Multi ≥ 42""" &
    "}," &
    "{" &
    """dataElement"": ""LLtybn3Il5y""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox181.Text & """," &
    """comment"": ""<20---- 22-27""" &
    "}," &
    "{" &
    """dataElement"": ""a7MLCIvl3N0""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox182.Text & """," &
    """comment"": ""<20---- 28-36""" &
    "}," &
    "{" &
    """dataElement"": ""i4LqEvJTyyH""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox183.Text & """," &
    """comment"": ""<20----- 37-41""" &
    "}," &
    "{" &
    """dataElement"": ""NmLTLB5IM4x""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox184.Text & """," &
    """comment"": ""<20----- ≥ 42""" &
    "}," &
    "{" &
    """dataElement"": ""Ynoi7oT6Cui""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox185.Text & """," &
    """comment"": ""20-34 ----- 22-27""" &
    "}," &
    "{" &
    """dataElement"": ""jW4Nxz5ZtTc""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox186.Text & """," &
    """comment"": ""20-34 --- 28-36""" &
    "}," &
    "{" &
    """dataElement"": ""T2RIoCzbcrE""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox187.Text & """," &
    """comment"": ""20-34 ---- 37-41""" &
    "}," &
    "{" &
    """dataElement"": ""NNa4syq83FQ""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox188.Text & """," &
    """comment"": ""20-34 ---- ≥ 42""" &
    "}," &
    "{" &
    """dataElement"": ""DmCnfwpVcMT""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox189.Text & """," &
    """comment"": ""≥ 35 ----- 22-27""" &
    "}," &
    "{" &
    """dataElement"": ""yoj2oCbvriM""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox190.Text & """," &
    """comment"": ""≥ 35 ----- 28-36""" &
    "}," &
    "{" &
    """dataElement"": ""bbMBbR3oQa5""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox191.Text & """," &
    """comment"": ""≥ 35 ----- 37-41""" &
    "}," &
    "{" &
    """dataElement"": ""KWtpxg9gMS0""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox192.Text & """," &
    """comment"": ""≥ 35 ----- ≥ 42""" &
    "}" &
  "]" &
  "}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub
    Private Sub BtnMedicoPush_Click(sender As Object, e As EventArgs) Handles BtnMedicoPush.Click

        Dim jsonData As String = "{" &
  """dataSet"": """ & dataSetId & """," &
  """completeDate"": """ & todayDate & """," &
  """period"": """ & period & """," &
  """orgUnit"": """ & orgUnitId & """," &
  """attributeOptionCombo"": """"," &
  """dataValues"": [" &
  "{" &
    """dataElement"": ""cvruy1B1fIf""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox193.Text & """," &
    """comment"": ""Male""" &
    "}," &
    "{" &
    """dataElement"": ""cvruy1B1fIf""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox194.Text & """," &
    """comment"": ""Female""" &
    "}" &
  "]" &
  "}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnSurPush_Click(sender As Object, e As EventArgs) Handles BtnSurPush.Click
        Dim jsonData As String = "{" &
  """dataSet"": """ & dataSetId & """," &
  """completeDate"": """ & todayDate & """," &
  """period"": """ & period & """," &
  """orgUnit"": """ & orgUnitId & """," &
  """attributeOptionCombo"": """"," &
  """dataValues"": [" &
   "{" &
    """dataElement"": ""CLhWwTR9cvm""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox195.Text & """," &
    """comment"": ""Major---Emergency---Female""" &
    "}," &
    "{" &
    """dataElement"": ""CLhWwTR9cvm""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox196.Text & """," &
    """comment"": ""Major---Emergency---Male""" &
    "}," &
    "{" &
    """dataElement"": ""LkfqkCTEMqY""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox197.Text & """," &
    """comment"": ""Major---Emergency---Post Operative Infection""" &
    "}," &
    "{" &
    """dataElement"": ""npj4tlqKsRw""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox198.Text & """," &
    """comment"": ""Major---Inpatient---Female""" &
    "}," &
    "{" &
    """dataElement"": ""npj4tlqKsRw""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox199.Text & """," &
    """comment"": ""Major---Inpatient---Male""" &
    "}," &
    "{" &
    """dataElement"": ""DD8l8cg0zzD""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox200.Text & """," &
    """comment"": ""Major---Inpatient---Post Operative Infection""" &
    "}," &
    "{" &
    """dataElement"": ""cYSIelGCG3M""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox201.Text & """," &
    """comment"": ""Intermediate---Emergency---Female""" &
    "}," &
    "{" &
    """dataElement"": ""cYSIelGCG3M""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox202.Text & """," &
    """comment"": ""Intermediate---Emergency---Male""" &
    "}," &
    "{" &
    """dataElement"": ""myd5N04yqWS""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox203.Text & """," &
    """comment"": ""Intermediate---Emergency---Post Operative Infection""" &
    "}," &
    "{" &
    """dataElement"": ""jiDCdaL2uK8""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox204.Text & """," &
    """comment"": ""Intermediate---Inpatient---Female""" &
    "}," &
    "{" &
    """dataElement"": ""jiDCdaL2uK8""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox205.Text & """," &
    """comment"": ""Intermediate---Inpatient---Male""" &
    "}," &
    "{" &
    """dataElement"": ""OCHPfRV20lM""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox206.Text & """," &
    """comment"": ""Intermediate---Inpatient---Post Operative Infection""" &
    "}," &
    "{" &
    """dataElement"": ""XOIIA9PktoG""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox207.Text & """," &
    """comment"": ""Minor---Outpatients---Female""" &
    "}," &
    "{" &
    """dataElement"": ""XOIIA9PktoG""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox208.Text & """," &
    """comment"": ""Minor---Outpatients---Male""" &
    "}," &
    "{" &
    """dataElement"": ""f9CFvnVSAic""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox209.Text & """," &
    """comment"": ""Minor---Outpatients---Post Operative Infection""" &
    "}," &
    "{" &
    """dataElement"": ""ds89kwFirfa""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox210.Text & """," &
    """comment"": ""Minor---Inpatients---Female""" &
    "}," &
    "{" &
    """dataElement"": ""ds89kwFirfa""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox211.Text & """," &
    """comment"": ""Minor---Inpatients---Male""" &
    "}," &
    "{" &
    """dataElement"": ""yNvksqFvO65""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox212.Text & """," &
    """comment"": ""Minor---Inpatients---Post Operative Infection""" &
    "}," &
    "{" &
    """dataElement"": ""PPLkh56gSDt""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox213.Text & """," &
    """comment"": ""Minor---Emergency---Female""" &
    "}," &
    "{" &
    """dataElement"": ""PPLkh56gSDt""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox214.Text & """," &
    """comment"": ""Minor---Emergency---Male""" &
    "}," &
    "{" &
    """dataElement"": ""gGNm8ee9hl8""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox215.Text & """," &
    """comment"": ""Minor---Emergency---Post Operative Infection""" &
    "}," &
    "{" &
    """dataElement"": ""bRyy4uqVUn6""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox216.Text & """," &
    """comment"": ""Plaster---Female""" &
    "}," &
    "{" &
    """dataElement"": ""bRyy4uqVUn6""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox217.Text & """," &
    """comment"": ""Plaster---Male""" &
    "}" &
  "]" &
  "}"


        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)

    End Sub

    Private Sub BtnDeathPush_Click(sender As Object, e As EventArgs) Handles BtnDeadPush.Click
        Dim jsonData As String = "{" &
"""dataSet"": """ & dataSetId & """," &
"""completeDate"": """ & todayDate & """," &
"""period"": """ & period & """," &
"""orgUnit"": """ & orgUnitId & """," &
"""attributeOptionCombo"": """"," &
"""dataValues"": [" &
 "{" &
   """dataElement"": ""wE8Ua9fF57W""," &
   """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
   """value"": """ & TextBox218.Text & """," &
   """comment"": ""Early Neonatal----Female""" &
   "}," &
   "{" &
   """dataElement"": ""wE8Ua9fF57W""," &
   """categoryOptionCombo"": ""PflKpozpO7b""," &
   """value"": """ & TextBox219.Text & """," &
   """comment"": ""Early Neonatal-----Male""" &
   "}," &
   "{" &
   """dataElement"": ""i9Fd6Sg4Xvz""," &
   """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
   """value"": """ & TextBox220.Text & """," &
   """comment"": ""Late Neonatal----Female""" &
   "}," &
   "{" &
   """dataElement"": ""i9Fd6Sg4Xvz""," &
   """categoryOptionCombo"": ""PflKpozpO7b""," &
   """value"": """ & TextBox221.Text & """," &
   """comment"": ""Late Neonatal-----Male""" &
   "}," &
   "{" &
   """dataElement"": ""OWZvJevMlQd""," &
   """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
   """value"": """ & TextBox222.Text & """," &
   """comment"": ""Maternal(ALL)----Female""" &
   "}," &
   "{" &
   """dataElement"": ""HUtoMj9IIHY""," &
   """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
   """value"": """ & TextBox223.Text & """," &
   """comment"": ""Post-Operative*----Female""" &
   "}," &
   "{" &
   """dataElement"": ""HUtoMj9IIHY""," &
   """categoryOptionCombo"": ""PflKpozpO7b""," &
   """value"": """ & TextBox224.Text & """," &
   """comment"": ""Post-Operative*-----Male""" &
   "}," &
   "{" &
   """dataElement"": ""E71fixytlb4""," &
   """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
   """value"": """ & TextBox225.Text & """," &
   """comment"": ""Emergency----Female""" &
   "}," &
   "{" &
   """dataElement"": ""E71fixytlb4""," &
   """categoryOptionCombo"": ""PflKpozpO7b""," &
   """value"": """ & TextBox226.Text & """," &
   """comment"": ""Emergency-----Male""" &
   "}," &
   "{" &
   """dataElement"": ""zyYi2g0sMwN""," &
   """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
   """value"": """ & TextBox227.Text & """," &
   """comment"": ""Inpatients----Female""" &
   "}," &
   "{" &
   """dataElement"": ""zyYi2g0sMwN""," &
   """categoryOptionCombo"": ""PflKpozpO7b""," &
   """value"": """ & TextBox228.Text & """," &
   """comment"": ""Inpatients-----Male""" &
   "}," &
   "{" &
   """dataElement"": ""w9XVaxfPr9F""," &
   """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
   """value"": """ & TextBox229.Text & """," &
   """comment"": ""Brought Dead----Female""" &
   "}," &
   "{" &
   """dataElement"": ""w9XVaxfPr9F""," &
   """categoryOptionCombo"": ""PflKpozpO7b""," &
   """value"": """ & TextBox230.Text & """," &
   """comment"": ""Brought Dead-----Male""" &
   "}," &
   "{" &
   """dataElement"": ""kkl8yhz37BN""," &
   """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
   """value"": """ & TextBox231.Text & """," &
   """comment"": ""Postmortem Done----Female""" &
   "}," &
   "{" &
   """dataElement"": ""kkl8yhz37BN""," &
   """categoryOptionCombo"": ""PflKpozpO7b""," &
   """value"": """ & TextBox232.Text & """," &
   """comment"": ""Postmortem Done-----Male""" &
   "}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnCostExempPush_Click(sender As Object, e As EventArgs) Handles BtnCostExempPush.Click
        Dim jsonData As String = "{" &
"""dataSet"": """ & dataSetId & """," &
"""completeDate"": """ & todayDate & """," &
"""period"": """ & period & """," &
"""orgUnit"": """ & orgUnitId & """," &
"""attributeOptionCombo"": """"," &
"""dataValues"": [" &
"{" &
    """dataElement"": ""XFaB9VkN3Sh""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox233.Text & """," &
    """comment"": ""Partially----No. of Patients""" &
    "}," &
    "{" &
    """dataElement"": ""eXUI9zdrFSY""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox234.Text & """," &
    """comment"": ""Partially----Total Exempted Cost""" &
    "}," &
    "{" &
    """dataElement"": ""kpcheWPcaMi""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox235.Text & """," &
    """comment"": ""Completely----No. of Patients""" &
    "}," &
    "{" &
    """dataElement"": ""sT2uMMZvrSJ""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox236.Text & """," &
    """comment"": ""Completely----Total Exempted Cost""" &
    "}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnSocialSecurityPush_Click(sender As Object, e As EventArgs) Handles BtnSocialSecurityPush.Click
        Dim jsonData As String = "{" &
"""dataSet"": """ & dataSetId & """," &
"""completeDate"": """ & todayDate & """," &
"""period"": """ & period & """," &
"""orgUnit"": """ & orgUnitId & """," &
"""attributeOptionCombo"": """"," &
"""dataValues"": [" &
 "{" &
    """dataElement"": ""fMgY7buyPgJ""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox237.Text & """," &
    """comment"": ""Outpatients----Ultra Poor/Poor""" &
    "}," &
    "{" &
    """dataElement"": ""TQchxgpT1Mg""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox238.Text & """," &
    """comment"": ""Outpatients----Helpless/ Destitute""" &
    "}," &
    "{" &
    """dataElement"": ""U0aYCzqSIrV""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox239.Text & """," &
    """comment"": ""Outpatients----Disabled""" &
    "}," &
    "{" &
    """dataElement"": ""pGKBCQ2y96V""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox240.Text & """," &
    """comment"": ""Outpatients----Sr. Citizens> 60 Years""" &
    "}," &
    "{" &
    """dataElement"": ""SIODC3GmBPx""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox241.Text & """," &
    """comment"": ""Outpatients----FCHV""" &
    "}," &
    "{" &
    """dataElement"": ""d5xARcg2y1L""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox242.Text & """," &
    """comment"": ""Outpatients----Gender Based Voilence""" &
    "}," &
    "{" &
    """dataElement"": ""xD4PTWeBft4""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox243.Text & """," &
    """comment"": ""Outpatients----Others""" &
    "}," &
    "{" &
    """dataElement"": ""blQafu930Fk""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox244.Text & """," &
    """comment"": ""Inpatients----Ultra Poor/Poor""" &
    "}," &
    "{" &
    """dataElement"": ""K2QvU18Cy9V""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox245.Text & """," &
    """comment"": ""Inpatients----Helpless/ Destitute""" &
    "}," &
    "{" &
    """dataElement"": ""oLHqNDw8P0e""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox246.Text & """," &
    """comment"": ""Inpatients----Disabled""" &
    "}," &
    "{" &
    """dataElement"": ""FpFz27OnLjo""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox247.Text & """," &
    """comment"": ""Inpatients----Sr. Citizens> 60 Years""" &
    "}," &
    "{" &
    """dataElement"": ""brA0o59G66l""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox248.Text & """," &
    """comment"": ""Inpatients----FCHV""" &
    "}," &
    "{" &
    """dataElement"": ""WYnBzcM4iwO""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox249.Text & """," &
    """comment"": ""Inpatients----Gender Based Voilence""" &
    "}," &
    "{" &
    """dataElement"": ""JT6R8JDcdm7""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox250.Text & """," &
    """comment"": ""Inpatients----Others""" &
    "}," &
    "{" &
    """dataElement"": ""sboNx8FiP4d""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox251.Text & """," &
    """comment"": ""Emergency----Ultra Poor/Poor""" &
    "}," &
    "{" &
    """dataElement"": ""B9svAWSTFQt""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox252.Text & """," &
    """comment"": ""Emergency----Helpless/ Destitute""" &
    "}," &
    "{" &
    """dataElement"": ""xkfNycS7hEG""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox253.Text & """," &
    """comment"": ""Emergency----Disabled""" &
    "}," &
    "{" &
    """dataElement"": ""wYwdmBDhBNu""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox254.Text & """," &
    """comment"": ""Emergency----Sr. Citizens> 60 Years""" &
    "}," &
    "{" &
    """dataElement"": ""YLBxlWQ2Ji5""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox255.Text & """," &
    """comment"": ""Emergency----FCHV""" &
    "}," &
    "{" &
    """dataElement"": ""qLLnISVBthc""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox256.Text & """," &
    """comment"": ""Emergency----Gender Based Voilence""" &
    "}," &
    "{" &
    """dataElement"": ""sSIsC8lbPDs""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox257.Text & """," &
    """comment"": ""Emergency----Others""" &
    "}," &
    "{" &
    """dataElement"": ""yeGkme7Wda5""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox258.Text & """," &
    """comment"": ""Referred Out----Ultra Poor/Poor""" &
    "}," &
    "{" &
    """dataElement"": ""zrx6bskmDpn""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox259.Text & """," &
    """comment"": ""Referred Out----Helpless/ Destitute""" &
    "}," &
    "{" &
    """dataElement"": ""NoJQulKOcgB""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox260.Text & """," &
    """comment"": ""Referred Out----Disabled""" &
    "}," &
    "{" &
    """dataElement"": ""riAMS7MJ8Kz""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox261.Text & """," &
    """comment"": ""Referred Out----Sr. Citizens> 60 Years""" &
    "}," &
    "{" &
    """dataElement"": ""pF1Mv020yUl""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox262.Text & """," &
    """comment"": ""Referred Out----FCHV""" &
    "}," &
    "{" &
    """dataElement"": ""GnYEgVNXJ0K""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox263.Text & """," &
    """comment"": ""Referred Out----Gender Based Voilence""" &
    "}," &
    "{" &
    """dataElement"": ""r46z953ZAdI""," &
    """categoryOptionCombo"": ""kdsirVNKdhm""," &
    """value"": """ & TextBox264.Text & """," &
    """comment"": ""Referred Out----Others""" &
    "}" &
"]" &
"}"

        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub

    Private Sub BtnInpatPush_Click(sender As Object, e As EventArgs) Handles BtnInpatPush.Click
        Dim jsonData As String = "{" &
    """dataSet"": """ & dataSetId & """," &
    """completeDate"": """ & todayDate & """," &
    """period"": """ & period & """," &
    """orgUnit"": """ & orgUnitId & """," &
    """attributeOptionCombo"": """"," &
    """dataValues"": [" &
         "{" &
        """dataElement"": ""niC6UlH8lG8""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox1.Text & """," &
        """comment"": ""Female Age Group 0-7 Days""" &
    "}," &
    "{" &
        """dataElement"": ""niC6UlH8lG8""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox2.Text & """," &
        """comment"": ""Male Age Group 0-7 Days""" &
    "}," &
    "{" &
        """dataElement"": ""aw0UrONFp8G""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox3.Text & """," &
        """comment"": ""Female Age Group 8-28 Days""" &
    "}," &
    "{" &
        """dataElement"": ""aw0UrONFp8G""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox4.Text & """," &
        """comment"": ""Male Age Group 8-28 Days""" &
    "}," &
    "{" &
        """dataElement"": ""VT7pxUmkCk4""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox5.Text & """," &
        """comment"": ""Female Age Group 29 Days - <1 Year""" &
    "}," &
    "{" &
        """dataElement"": ""VT7pxUmkCk4""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox6.Text & """," &
        """comment"": ""Male Age Group 29 Days - <1 Year""" &
    "}," &
    "{" &
        """dataElement"": ""hfKKGFpcahT""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox7.Text & """," &
        """comment"": ""Female Age Group 01 - 04 Years""" &
    "}," &
    "{" &
        """dataElement"": ""hfKKGFpcahT""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox8.Text & """," &
        """comment"": ""Male Age Group 01 - 04 Years""" &
    "}," &
    "{" &
        """dataElement"": ""idfm34Azg6Q""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox9.Text & """," &
        """comment"": ""Female Age Group 05 - 14 Years""" &
    "}," &
    "{" &
        """dataElement"": ""idfm34Azg6Q""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox10.Text & """," &
        """comment"": ""Male Age Group 05 - 14 Years""" &
    "}," &
    "{" &
        """dataElement"": ""jeODCTX57ty""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox11.Text & """," &
        """comment"": ""Female Age Group 15 - 19 Years""" &
    "}," &
    "{" &
        """dataElement"": ""jeODCTX57ty""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox12.Text & """," &
        """comment"": ""Male Age Group 15 - 19 Years""" &
    "}," &
    "{" &
        """dataElement"": ""eWZ03zEBkBX""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox13.Text & """," &
        """comment"": ""Female Age Group 20 - 29 Years""" &
    "}," &
    "{" &
        """dataElement"": ""eWZ03zEBkBX""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox14.Text & """," &
        """comment"": ""Male Age Group 20 - 29 Years""" &
    "}," &
    "{" &
        """dataElement"": ""byiU4Z8VZxP""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox15.Text & """," &
        """comment"": ""Female Age Group 30 - 39 Years""" &
    "}," &
    "{" &
        """dataElement"": ""byiU4Z8VZxP""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox16.Text & """," &
        """comment"": ""Male Age Group 30 - 39 Years""" &
    "}," &
    "{" &
        """dataElement"": ""qFKmdcMXi8R""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox17.Text & """," &
        """comment"": ""Female Age Group 40 - 49 Years""" &
    "}," &
    "{" &
        """dataElement"": ""qFKmdcMXi8R""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox18.Text & """," &
        """comment"": ""Male Age Group 40 - 49 Years""" &
    "}," &
    "{" &
        """dataElement"": ""XgqSseUwYwV""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox19.Text & """," &
        """comment"": ""Female Age Group 50 - 59 Years""" &
    "}," &
    "{" &
        """dataElement"": ""XgqSseUwYwV""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox20.Text & """," &
        """comment"": ""Male Age Group 50 - 59 Years""" &
    "}," &
    "{" &
        """dataElement"": ""x6AnbSOW91m""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox21.Text & """," &
        """comment"": ""Female Age Group 60-69 Years""" &
    "}," &
    "{" &
        """dataElement"": ""x6AnbSOW91m""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox22.Text & """," &
        """comment"": ""Male Age Group 60-69 Years""" &
    "}," &
    "{" &
        """dataElement"": ""ExK3mV0mW4C""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox23.Text & """," &
        """comment"": ""Female Age Group ≥ 70 Years""" &
    "}," &
    "{" &
        """dataElement"": ""ExK3mV0mW4C""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox24.Text & """," &
        """comment"": ""Male Age Group ≥ 70 Years""" &
    "}," &
    "{" &
        """dataElement"": ""ZchNDuXAuns""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox25.Text & """," &
        """comment"": ""Female Age Group 0-7 Days""" &
    "}," &
    "{" &
        """dataElement"": ""ZchNDuXAuns""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox26.Text & """," &
        """comment"": ""Male Age Group 0-7 Days""" &
    "}," &
    "{" &
        """dataElement"": ""JZxN7maZNTP""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox27.Text & """," &
        """comment"": ""Female Age Group 8-28 Days""" &
    "}," &
    "{" &
        """dataElement"": ""JZxN7maZNTP""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox28.Text & """," &
        """comment"": ""Male Age Group 8-28 Days""" &
    "}," &
    "{" &
        """dataElement"": ""FBGTznlhG52""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox29.Text & """," &
        """comment"": ""Female Age Group 29 Days - <1 Year""" &
    "}," &
    "{" &
        """dataElement"": ""FBGTznlhG52""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox30.Text & """," &
        """comment"": ""Male Age Group 29 Days - <1 Year""" &
    "}," &
    "{" &
        """dataElement"": ""SY9yhXNOxKV""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox31.Text & """," &
        """comment"": ""Female Age Group 01 - 04 Years""" &
    "}," &
    "{" &
        """dataElement"": ""SY9yhXNOxKV""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox32.Text & """," &
        """comment"": ""Male Age Group 01 - 04 Years""" &
    "}," &
    "{" &
        """dataElement"": ""SrXLG8LgypM""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox33.Text & """," &
        """comment"": ""Female Age Group 05 - 14 Years""" &
    "}," &
    "{" &
        """dataElement"": ""SrXLG8LgypM""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox34.Text & """," &
        """comment"": ""Male Age Group 05 - 14 Years""" &
    "}," &
    "{" &
        """dataElement"": ""QnPXOhBy2L0""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox35.Text & """," &
        """comment"": ""Female Age Group 15 - 19 Years""" &
    "}," &
    "{" &
        """dataElement"": ""QnPXOhBy2L0""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox36.Text & """," &
        """comment"": ""Male Age Group 15 - 19 Years""" &
    "}," &
    "{" &
        """dataElement"": ""fGGxZFck8rJ""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox37.Text & """," &
        """comment"": ""Female Age Group 20 - 29 Years""" &
    "}," &
    "{" &
        """dataElement"": ""fGGxZFck8rJ""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox38.Text & """," &
        """comment"": ""Male Age Group 20 - 29 Years""" &
    "}," &
    "{" &
        """dataElement"": ""BCTQqvSi9Fp""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox39.Text & """," &
        """comment"": ""Female Age Group 30 - 39 Years""" &
    "}," &
    "{" &
        """dataElement"": ""BCTQqvSi9Fp""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox40.Text & """," &
        """comment"": ""Male Age Group 30 - 39 Years""" &
    "}," &
    "{" &
        """dataElement"": ""SYsn3Q7bpEM""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox41.Text & """," &
        """comment"": ""Female Age Group 40 - 49 Years""" &
    "}," &
    "{" &
        """dataElement"": ""SYsn3Q7bpEM""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox42.Text & """," &
        """comment"": ""Male Age Group 40 - 49 Years""" &
    "}," &
    "{" &
        """dataElement"": ""QZzqdCD5pWM""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox43.Text & """," &
        """comment"": ""Female Age Group 50 - 59 Years""" &
    "}," &
    "{" &
        """dataElement"": ""QZzqdCD5pWM""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox44.Text & """," &
        """comment"": ""Male Age Group 50 - 59 Years""" &
    "}," &
    "{" &
        """dataElement"": ""kfKZhz8cxld""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox45.Text & """," &
        """comment"": ""Female Age Group 60-69 Years""" &
    "}," &
    "{" &
        """dataElement"": ""kfKZhz8cxld""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox46.Text & """," &
        """comment"": ""Male Age Group 60-69 Years""" &
    "}," &
    "{" &
        """dataElement"": ""Z4zwE88awmI""," &
        """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
        """value"": """ & TextBox47.Text & """," &
        """comment"": ""Female Age Group ≥ 70 Years""" &
    "}," &
    "{" &
        """dataElement"": ""Z4zwE88awmI""," &
        """categoryOptionCombo"": ""PflKpozpO7b""," &
        """value"": """ & TextBox48.Text & """," &
        """comment"": ""Male Age Group ≥ 70 Years""" &
    "}," &
    "{" &
    """dataElement"": ""mNpQUrhMY2M""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox49.Text & """," &
    """comment"": ""Female Age Group  0-7 Days""" &
    "}," &
    "{" &
    """dataElement"": ""mNpQUrhMY2M""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox50.Text & """," &
    """comment"": ""Male Age Group  0-7 Days""" &
    "}," &
    "{" &
    """dataElement"": ""FSJ68ws5R8q""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox51.Text & """," &
    """comment"": ""Female Age Group  8-28 Days""" &
    "}," &
    "{" &
    """dataElement"": ""FSJ68ws5R8q""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox52.Text & """," &
    """comment"": ""Male Age Group  8-28 Days""" &
    "}," &
    "{" &
    """dataElement"": ""MG81K0P93cC""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox53.Text & """," &
    """comment"": ""Female Age Group  29 Days - <1 Year""" &
    "}," &
    "{" &
    """dataElement"": ""MG81K0P93cC""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox54.Text & """," &
    """comment"": ""Male Age Group  29 Days - <1 Year""" &
    "}," &
    "{" &
    """dataElement"": ""BHMcr2LttVZ""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox55.Text & """," &
    """comment"": ""Female Age Group  01 - 04 Years""" &
    "}," &
    "{" &
    """dataElement"": ""BHMcr2LttVZ""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox56.Text & """," &
    """comment"": ""Male Age Group 01 - 04 Years""" &
    "}," &
    "{" &
    """dataElement"": ""q1rh08vhNLa""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox57.Text & """," &
    """comment"": ""Female Age Group  05 - 14 Years""" &
    "}," &
    "{" &
    """dataElement"": ""q1rh08vhNLa""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox58.Text & """," &
    """comment"": ""Male Age Group  05 - 14 Years""" &
    "}," &
    "{" &
    """dataElement"": ""FVUaOSyrp8X""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox59.Text & """," &
    """comment"": ""Female Age Group  15 - 19 Years""" &
    "}," &
    "{" &
    """dataElement"": ""FVUaOSyrp8X""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox60.Text & """," &
    """comment"": ""Male Age Group  15 - 19 Years""" &
    "}," &
    "{" &
    """dataElement"": ""qC0mnCelPuB""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox61.Text & """," &
    """comment"": ""Female Age Group  20 - 29 Years""" &
    "}," &
    "{" &
    """dataElement"": ""qC0mnCelPuB""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox62.Text & """," &
    """comment"": ""Male Age Group 20 - 29 Years""" &
    "}," &
    "{" &
    """dataElement"": ""xRGqy7Adibr""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox63.Text & """," &
    """comment"": ""Female Age Group  30 - 39 Years""" &
    "}," &
    "{" &
    """dataElement"": ""xRGqy7Adibr""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox64.Text & """," &
    """comment"": ""Male Age Group  30 - 39 Years""" &
    "}," &
    "{" &
    """dataElement"": ""jSCf0lQ0CKP""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox65.Text & """," &
    """comment"": ""Female Age Group  40 - 49 Years""" &
    "}," &
    "{" &
    """dataElement"": ""jSCf0lQ0CKP""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox66.Text & """," &
    """comment"": ""Male Age Group  40 - 49 Years""" &
    "}," &
    "{" &
    """dataElement"": ""O3Z3alM218T""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox67.Text & """," &
    """comment"": ""Female Age Group  50 - 59 Years""" &
    "}," &
    "{" &
    """dataElement"": ""O3Z3alM218T""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox68.Text & """," &
    """comment"": ""Male Age Group  50 - 59 Years""" &
    "}," &
    "{" &
    """dataElement"": ""X8zqZMPNOgz""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox69.Text & """," &
    """comment"": ""Female Age Group  60-69 Years""" &
    "}," &
    "{" &
    """dataElement"": ""X8zqZMPNOgz""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox70.Text & """," &
    """comment"": ""Male Age Group  60-69 Years""" &
    "}," &
    "{" &
    """dataElement"": ""mJtKzHyyCAW""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox71.Text & """," &
    """comment"": ""Female Age Group  ≥ 70 Years""" &
    "}," &
    "{" &
    """dataElement"": ""mJtKzHyyCAW""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox72.Text & """," &
    """comment"": ""Male Age Group  ≥ 70 Years""" &
    "}," &
    "{" &
    """dataElement"": ""PjX59M4FWsV""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox73.Text & """," &
    """comment"": ""Female Age Group  0-7 Days""" &
    "}," &
"{" &
"""dataElement"": ""PjX59M4FWsV""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox74.Text & """," &
"""comment"": ""Male Age Group  0-7 Days""" &
"}," &
"{" &
"""dataElement"": ""tJPTannLCpR""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox75.Text & """," &
"""comment"": ""Female Age Group  8-28 Days""" &
"}," &
"{" &
"""dataElement"": ""tJPTannLCpR""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox76.Text & """," &
"""comment"": ""Male Age Group  8-28 Days""" &
"}," &
"{" &
"""dataElement"": ""nAwr1SuDL5X""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox77.Text & """," &
"""comment"": ""Female Age Group  29 Days - <1 Year""" &
"}," &
"{" &
"""dataElement"": ""nAwr1SuDL5X""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox78.Text & """," &
"""comment"": ""Male Age Group  29 Days - <1 Year""" &
"}," &
"{" &
"""dataElement"": ""uHC49o0YWzj""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox79.Text & """," &
"""comment"": ""Female Age Group  01 - 04 Years""" &
"}," &
"{" &
"""dataElement"": ""uHC49o0YWzj""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox80.Text & """," &
"""comment"": ""Male Age Group 01 - 04 Years""" &
"}," &
"{" &
"""dataElement"": ""aFDqE1qyJwH""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox81.Text & """," &
"""comment"": ""Female Age Group  05 - 14 Years""" &
"}," &
"{" &
"""dataElement"": ""aFDqE1qyJwH""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox82.Text & """," &
"""comment"": ""Male Age Group  05 - 14 Years""" &
"}," &
"{" &
"""dataElement"": ""HnwIe5GtEQd""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox83.Text & """," &
"""comment"": ""Female Age Group  15 - 19 Years""" &
"}," &
"{" &
"""dataElement"": ""HnwIe5GtEQd""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox84.Text & """," &
"""comment"": ""Male Age Group  15 - 19 Years""" &
"}," &
"{" &
"""dataElement"": ""oQDF5rAiZ9s""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox85.Text & """," &
"""comment"": ""Female Age Group  20 - 29 Years""" &
"}," &
"{" &
"""dataElement"": ""oQDF5rAiZ9s""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox86.Text & """," &
"""comment"": ""Male Age Group 20 - 29 Years""" &
"}," &
"{" &
"""dataElement"": ""Nifo5ju2pPP""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox87.Text & """," &
"""comment"": ""Female Age Group  30 - 39 Years""" &
"}," &
"{" &
"""dataElement"": ""Nifo5ju2pPP""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox88.Text & """," &
"""comment"": ""Male Age Group  30 - 39 Years""" &
"}," &
"{" &
"""dataElement"": ""MzCbP9IShpH""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox89.Text & """," &
"""comment"": ""Female Age Group  40 - 49 Years""" &
"}," &
"{" &
"""dataElement"": ""MzCbP9IShpH""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox90.Text & """," &
"""comment"": ""Male Age Group  40 - 49 Years""" &
"}," &
"{" &
"""dataElement"": ""IgUWH05VOXS""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox91.Text & """," &
"""comment"": ""Female Age Group  50 - 59 Years""" &
"}," &
"{" &
"""dataElement"": ""IgUWH05VOXS""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox92.Text & """," &
"""comment"": ""Male Age Group  50 - 59 Years""" &
"}," &
"{" &
"""dataElement"": ""O55ilAmKVCL""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox93.Text & """," &
"""comment"": ""Female Age Group  60-69 Years""" &
"}," &
"{" &
"""dataElement"": ""O55ilAmKVCL""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox94.Text & """," &
"""comment"": ""Male Age Group  60-69 Years""" &
"}," &
"{" &
"""dataElement"": ""lGlrmWuQ6BN""," &
"""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
"""value"": """ & TextBox95.Text & """," &
"""comment"": ""Female Age Group  ≥ 70 Years""" &
"}," &
"{" &
"""dataElement"": ""lGlrmWuQ6BN""," &
"""categoryOptionCombo"": ""PflKpozpO7b""," &
"""value"": """ & TextBox96.Text & """," &
"""comment"": ""Male Age Group  ≥ 70 Years""" &
"}," &
"{" &
    """dataElement"": ""Fqk8Q7IyFGm""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox97.Text & """," &
    """comment"": ""Female Age Group  0-7 Days""" &
    "}," &
    "{" &
    """dataElement"": ""Fqk8Q7IyFGm""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox98.Text & """," &
    """comment"": ""Male Age Group  0-7 Days""" &
    "}," &
    "{" &
    """dataElement"": ""lTMICysCO1L""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox99.Text & """," &
    """comment"": ""Female Age Group  8-28 Days""" &
    "}," &
    "{" &
    """dataElement"": ""lTMICysCO1L""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox100.Text & """," &
    """comment"": ""Male Age Group  8-28 Days""" &
    "}," &
    "{" &
    """dataElement"": ""q1hEowbwEte""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox101.Text & """," &
    """comment"": ""Female Age Group  29 Days - <1 Year""" &
    "}," &
    "{" &
    """dataElement"": ""q1hEowbwEte""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox102.Text & """," &
    """comment"": ""Male Age Group  29 Days - <1 Year""" &
    "}," &
    "{" &
    """dataElement"": ""R9VsHuLaaOV""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox103.Text & """," &
    """comment"": ""Female Age Group  01 - 04 Years""" &
    "}," &
    "{" &
    """dataElement"": ""R9VsHuLaaOV""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox104.Text & """," &
    """comment"": ""Male Age Group 01 - 04 Years""" &
    "}," &
    "{" &
    """dataElement"": ""i80uwDMocMV""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox105.Text & """," &
    """comment"": ""Female Age Group  05 - 14 Years""" &
    "}," &
    "{" &
    """dataElement"": ""i80uwDMocMV""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox106.Text & """," &
    """comment"": ""Male Age Group  05 - 14 Years""" &
    "}," &
    "{" &
    """dataElement"": ""PZP5PrfHPeK""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox107.Text & """," &
    """comment"": ""Female Age Group  15 - 19 Years""" &
    "}," &
    "{" &
    """dataElement"": ""PZP5PrfHPeK""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox108.Text & """," &
    """comment"": ""Male Age Group  15 - 19 Years""" &
    "}," &
    "{" &
    """dataElement"": ""OC96VpJIdoE""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox109.Text & """," &
    """comment"": ""Female Age Group  20 - 29 Years""" &
    "}," &
    "{" &
    """dataElement"": ""OC96VpJIdoE""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox110.Text & """," &
    """comment"": ""Male Age Group 20 - 29 Years""" &
    "}," &
    "{" &
    """dataElement"": ""xOBWxJ7rtOG""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox111.Text & """," &
    """comment"": ""Female Age Group  30 - 39 Years""" &
    "}," &
    "{" &
    """dataElement"": ""xOBWxJ7rtOG""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox112.Text & """," &
    """comment"": ""Male Age Group  30 - 39 Years""" &
    "}," &
    "{" &
    """dataElement"": ""GwmblUqSoMS""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox113.Text & """," &
    """comment"": ""Female Age Group  40 - 49 Years""" &
    "}," &
    "{" &
    """dataElement"": ""GwmblUqSoMS""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox114.Text & """," &
    """comment"": ""Male Age Group  40 - 49 Years""" &
    "}," &
    "{" &
    """dataElement"": ""rvi6BdbtIu1""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox115.Text & """," &
    """comment"": ""Female Age Group  50 - 59 Years""" &
    "}," &
    "{" &
    """dataElement"": ""rvi6BdbtIu1""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox116.Text & """," &
    """comment"": ""Male Age Group  50 - 59 Years""" &
    "}," &
    "{" &
    """dataElement"": ""cWW5H0a30nH""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox117.Text & """," &
    """comment"": ""Female Age Group  60-69 Years""" &
    "}," &
    "{" &
    """dataElement"": ""cWW5H0a30nH""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox118.Text & """," &
    """comment"": ""Male Age Group  60-69 Years""" &
    "}," &
    "{" &
    """dataElement"": ""QMtXxyDBkoy""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox119.Text & """," &
    """comment"": ""Female Age Group  ≥ 70 Years""" &
    "}," &
    "{" &
    """dataElement"": ""QMtXxyDBkoy""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox120.Text & """," &
    """comment"": ""Male Age Group  ≥ 70 Years""" &
    "}," &
    "{" &
    """dataElement"": ""uOpuphGuSnO""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox121.Text & """," &
    """comment"": ""Female Age Group  0-7 Days""" &
    "}," &
    "{" &
    """dataElement"": ""uOpuphGuSnO""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox122.Text & """," &
    """comment"": ""Male Age Group  0-7 Days""" &
    "}," &
    "{" &
    """dataElement"": ""TY2g2JJ60se""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox123.Text & """," &
    """comment"": ""Female Age Group  8-28 Days""" &
    "}," &
    "{" &
    """dataElement"": ""TY2g2JJ60se""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox124.Text & """," &
    """comment"": ""Male Age Group  8-28 Days""" &
    "}," &
    "{" &
    """dataElement"": ""I9luOd2a7XZ""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox125.Text & """," &
    """comment"": ""Female Age Group  29 Days - <1 Year""" &
    "}," &
    "{" &
    """dataElement"": ""I9luOd2a7XZ""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox126.Text & """," &
    """comment"": ""Male Age Group  29 Days - <1 Year""" &
    "}," &
    "{" &
    """dataElement"": ""y9WZpRQwfwP""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox127.Text & """," &
    """comment"": ""Female Age Group  01 - 04 Years""" &
    "}," &
    "{" &
    """dataElement"": ""y9WZpRQwfwP""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox128.Text & """," &
    """comment"": ""Male Age Group 01 - 04 Years""" &
    "}," &
    "{" &
    """dataElement"": ""RZxcXR28SV3""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox129.Text & """," &
    """comment"": ""Female Age Group  05 - 14 Years""" &
    "}," &
    "{" &
    """dataElement"": ""RZxcXR28SV3""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox130.Text & """," &
    """comment"": ""Male Age Group  05 - 14 Years""" &
    "}," &
    "{" &
    """dataElement"": ""J3B6Aqs64TL""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox131.Text & """," &
    """comment"": ""Female Age Group  15 - 19 Years""" &
    "}," &
    "{" &
    """dataElement"": ""J3B6Aqs64TL""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox132.Text & """," &
    """comment"": ""Male Age Group  15 - 19 Years""" &
    "}," &
    "{" &
    """dataElement"": ""EHz6GfxpuXw""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox133.Text & """," &
    """comment"": ""Female Age Group  20 - 29 Years""" &
    "}," &
    "{" &
    """dataElement"": ""EHz6GfxpuXw""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox134.Text & """," &
    """comment"": ""Male Age Group 20 - 29 Years""" &
    "}," &
    "{" &
    """dataElement"": ""r5ovXqoUemk""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox135.Text & """," &
    """comment"": ""Female Age Group  30 - 39 Years""" &
    "}," &
    "{" &
    """dataElement"": ""r5ovXqoUemk""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox136.Text & """," &
    """comment"": ""Male Age Group  30 - 39 Years""" &
    "}," &
    "{" &
    """dataElement"": ""VDDHvT1MISE""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox137.Text & """," &
    """comment"": ""Female Age Group  40 - 49 Years""" &
    "}," &
    "{" &
    """dataElement"": ""VDDHvT1MISE""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox138.Text & """," &
    """comment"": ""Male Age Group  40 - 49 Years""" &
    "}," &
    "{" &
    """dataElement"": ""rjN2W3sO17N""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox139.Text & """," &
    """comment"": ""Female Age Group  50 - 59 Years""" &
    "}," &
    "{" &
    """dataElement"": ""rjN2W3sO17N""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox140.Text & """," &
    """comment"": ""Male Age Group  50 - 59 Years""" &
    "}," &
    "{" &
    """dataElement"": ""rVq4pfFzR1Y""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox141.Text & """," &
    """comment"": ""Female Age Group  60-69 Years""" &
    "}," &
    "{" &
    """dataElement"": ""rVq4pfFzR1Y""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox142.Text & """," &
    """comment"": ""Male Age Group  60-69 Years""" &
    "}," &
    "{" &
    """dataElement"": ""K7ysJSxXsmE""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox143.Text & """," &
    """comment"": ""Female Age Group  ≥ 70 Years""" &
    "}," &
    "{" &
    """dataElement"": ""K7ysJSxXsmE""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox144.Text & """," &
    """comment"": ""Male Age Group  ≥ 70 Years""" &
    "}," &
    "{" &
    """dataElement"": ""WQRxFdjHUwu""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox145.Text & """," &
    """comment"": ""Female Age Group  0-7 Days""" &
    "}," &
    "{" &
    """dataElement"": ""WQRxFdjHUwu""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox146.Text & """," &
    """comment"": ""Male Age Group  0-7 Days""" &
    "}," &
    "{" &
    """dataElement"": ""aebRNbazF1u""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox147.Text & """," &
    """comment"": ""Female Age Group  8-28 Days""" &
    "}," &
    "{" &
    """dataElement"": ""aebRNbazF1u""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox148.Text & """," &
    """comment"": ""Male Age Group  8-28 Days""" &
    "}," &
    "{" &
    """dataElement"": ""u5Ju7K3EFZ3""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox149.Text & """," &
    """comment"": ""Female Age Group  29 Days - <1 Year""" &
    "}," &
    "{" &
    """dataElement"": ""u5Ju7K3EFZ3""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox150.Text & """," &
    """comment"": ""Male Age Group  29 Days - <1 Year""" &
    "}," &
    "{" &
    """dataElement"": ""W1Tfa8N3tEq""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox151.Text & """," &
    """comment"": ""Female Age Group  01 - 04 Years""" &
    "}," &
    "{" &
    """dataElement"": ""W1Tfa8N3tEq""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox152.Text & """," &
    """comment"": ""Male Age Group 01 - 04 Years""" &
    "}," &
    "{" &
    """dataElement"": ""YTzkpp1RDGx""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox153.Text & """," &
    """comment"": ""Female Age Group  05 - 14 Years""" &
    "}," &
    "{" &
    """dataElement"": ""YTzkpp1RDGx""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox154.Text & """," &
    """comment"": ""Male Age Group  05 - 14 Years""" &
    "}," &
    "{" &
    """dataElement"": ""NuvEJyyrRyn""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox155.Text & """," &
    """comment"": ""Female Age Group  15 - 19 Years""" &
    "}," &
    "{" &
    """dataElement"": ""NuvEJyyrRyn""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox156.Text & """," &
    """comment"": ""Male Age Group  15 - 19 Years""" &
    "}," &
    "{" &
    """dataElement"": ""qNch4vXPvMS""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox157.Text & """," &
    """comment"": ""Female Age Group  20 - 29 Years""" &
    "}," &
    "{" &
    """dataElement"": ""qNch4vXPvMS""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox158.Text & """," &
    """comment"": ""Male Age Group 20 - 29 Years""" &
    "}," &
    "{" &
    """dataElement"": ""UAbEC9wm8JC""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox159.Text & """," &
    """comment"": ""Female Age Group  30 - 39 Years""" &
    "}," &
    "{" &
    """dataElement"": ""UAbEC9wm8JC""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox160.Text & """," &
    """comment"": ""Male Age Group  30 - 39 Years""" &
    "}," &
    "{" &
    """dataElement"": ""EDHAawGus2l""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox161.Text & """," &
    """comment"": ""Female Age Group  40 - 49 Years""" &
    "}," &
    "{" &
    """dataElement"": ""EDHAawGus2l""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox162.Text & """," &
    """comment"": ""Male Age Group  40 - 49 Years""" &
    "}," &
    "{" &
    """dataElement"": ""q9HWBr7XI3j""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox163.Text & """," &
    """comment"": ""Female Age Group  50 - 59 Years""" &
    "}," &
    "{" &
    """dataElement"": ""q9HWBr7XI3j""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox164.Text & """," &
    """comment"": ""Male Age Group  50 - 59 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ADTvSS6ZkWi""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox165.Text & """," &
    """comment"": ""Female Age Group  60-69 Years""" &
    "}," &
    "{" &
    """dataElement"": ""ADTvSS6ZkWi""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox166.Text & """," &
    """comment"": ""Male Age Group  60-69 Years""" &
    "}," &
    "{" &
    """dataElement"": ""UBWw7aps69k""," &
    """categoryOptionCombo"": ""ye1QuAMRG5Z""," &
    """value"": """ & TextBox167.Text & """," &
    """comment"": ""Female Age Group  ≥ 70 Years""" &
    "}," &
    "{" &
    """dataElement"": ""UBWw7aps69k""," &
    """categoryOptionCombo"": ""PflKpozpO7b""," &
    """value"": """ & TextBox168.Text & """," &
    """comment"": ""Male Age Group  ≥ 70 Years""" &
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