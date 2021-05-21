Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        Dim ccal As String
        ccal ='pisello';
        ViewData("Message") = "Your pisello"







        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your pisellino."

        Return View()
    End Function
End Class
