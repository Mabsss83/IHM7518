Module GlobalVariables
    Private ConnStr = "Server = " & Read_XML_Value("server") & "; Database=" & Read_XML_Value("db") & "; Uid=" & Read_XML_Value("user") & "; Pwd=" & Read_XML_Value("pwd") & "; SslMode=none ;"
    Public bdd As New BDD_Network(ConnStr)
End Module
