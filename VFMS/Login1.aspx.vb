Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    'Private Sub Login_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles Button.Authenticate
    '    Dim Username As String = ""
    '    Dim Password As String = ""
    '    Username = Request.Form("User_tb")
    '    Password = Request.Form("password_tb")
    '    Dim authen As New DataAccessModule
    '    Dim user As New User
    '    user = authen.Authenticate(Username, Password)
    '    If user IsNot Nothing Then
    '        Session("UserFullname") = user.full_name
    '        Session("Username") = user.user_name
    '        Response.Redirect("~/Document/SearchDocument.aspx")
    '    Else
    '        login.FailureText = "ไม่สามารถเข้าสู่ระบบได้ กรุณาลองใหม่อีกครั้ง"
    '    End If
    'End Sub

    'Protected Sub login(sender As Object, e As EventArgs)
    '    Dim Username As String = Request.Form("User_tb")
    '    Dim Password As String = Request.Form("password_tb")
    'End Sub

End Class