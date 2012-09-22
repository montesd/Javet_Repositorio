Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Web.Mvc
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Inmobiliaria.MVC

<TestClass()> Public Class HomeControllerTest

    <TestMethod()> Public Sub Index()
        ' Disponer
        Dim controller As HomeController = New HomeController()

        ' Actuar
        Dim result As ViewResult = CType(controller.Index(), ViewResult)

        ' Declarar
        Dim viewData As ViewDataDictionary = result.ViewData
        Assert.AreEqual("ASP.NET MVC", viewData("Message"))
    End Sub

    <TestMethod()> Public Sub About()
        ' Disponer
        Dim controller As HomeController = New HomeController()

        ' Actuar
        Dim result As ViewResult = CType(controller.About(), ViewResult)

        ' Declarar
        Assert.IsNotNull(result)
    End Sub
End Class
