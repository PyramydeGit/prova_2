﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        ViewData("Message") = "Your acampora raffaele 1"


        Return View()
    End Function

    Function About() As ActionResult


        ViewData("Message") = "Your raffaele acampora"







        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your acampora."

        Return View()
    End Function
End Class
