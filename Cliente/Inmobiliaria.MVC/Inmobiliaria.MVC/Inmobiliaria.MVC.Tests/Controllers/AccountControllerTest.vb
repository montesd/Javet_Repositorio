Imports System
Imports System.Security
Imports System.Security.Principal
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing
Imports System.Web.Security
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Inmobiliaria.MVC

<TestClass()> _
Public Class AccountControllerTest

    <TestMethod()> _
    Public Sub ChangePassword_Get_ReturnsView()
        ' Disponer
        Dim controller As AccountController = GetAccountController()

        ' Actuar
        Dim result As ActionResult = controller.ChangePassword()

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(ViewResult))
        Assert.AreEqual(10, CType(result, ViewResult).ViewData("PasswordLength"))
    End Sub

    <TestMethod()> _
    Public Sub ChangePassword_Post_ReturnsRedirectOnSuccess()
        ' Disponer
        Dim controller As AccountController = GetAccountController()
        Dim model As ChangePasswordModel = New ChangePasswordModel()
        model.OldPassword = "goodOldPassword"
        model.NewPassword = "goodNewPassword"
        model.ConfirmPassword = "goodNewPassword"

        ' Actuar
        Dim result As ActionResult = controller.ChangePassword(model)

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(RedirectToRouteResult))
        Dim redirectResult As RedirectToRouteResult = CType(result, RedirectToRouteResult)
        Assert.AreEqual("ChangePasswordSuccess", redirectResult.RouteValues("action"))
    End Sub

    <TestMethod()> _
    Public Sub ChangePassword_Post_ReturnsViewIfChangePasswordFails()
        ' Disponer
        Dim controller As AccountController = GetAccountController()
        Dim model As ChangePasswordModel = New ChangePasswordModel()
        model.OldPassword = "goodOldPassword"
        model.NewPassword = "badNewPassword"
        model.ConfirmPassword = "badNewPassword"

        ' Actuar
        Dim result As ActionResult = controller.ChangePassword(model)

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(ViewResult))
        Dim viewResult As ViewResult = CType(result, ViewResult)
        Assert.AreEqual(model, viewResult.ViewData.Model)
        Assert.AreEqual("La contraseña actual es incorrecta o la nueva contraseña no es válida.", controller.ModelState("").Errors(0).ErrorMessage)
        Assert.AreEqual(10, viewResult.ViewData("PasswordLength"))
    End Sub

    <TestMethod()> _
    Public Sub ChangePassword_Post_ReturnsViewIfModelStateIsInvalid()
        ' Disponer
        Dim controller As AccountController = GetAccountController()
        Dim model As ChangePasswordModel = New Changepasswordmodel()
        model.OldPassword = "goodOldPassword"
        model.NewPassword = "goodNewPassword"
        model.ConfirmPassword = "goodNewPassword"
        controller.ModelState.AddModelError("", "Mensaje de error ficticio.")

        ' Actuar
        Dim result As ActionResult = controller.ChangePassword(model)

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(ViewResult))
        Dim viewResult As ViewResult = CType(result, ViewResult)
        Assert.AreEqual(model, viewResult.ViewData.Model)
        Assert.AreEqual(10, viewResult.ViewData("PasswordLength"))
    End Sub

    <TestMethod()> _
    Public Sub ChangePasswordSuccess_ReturnsView()
        ' Disponer
        Dim controller As AccountController = GetAccountController()

        ' Actuar
        Dim result As ActionResult = controller.ChangePasswordSuccess()

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(ViewResult))
    End Sub

    <TestMethod()> _
    Public Sub LogOff_LogsOutAndRedirects()
        ' Disponer
        Dim controller As AccountController = GetAccountController()

        ' Actuar
        Dim result As ActionResult = controller.LogOff()

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(RedirectToRouteResult))
        Dim redirectResult As RedirectToRouteResult = CType(result, RedirectToRouteResult)
        Assert.AreEqual("Home", redirectResult.RouteValues("controller"))
        Assert.AreEqual("Index", redirectResult.RouteValues("action"))
        Assert.IsTrue(CType(controller.FormsService, MockFormsAuthenticationService).SignOut_WasCalled)
    End Sub

    <TestMethod()> _
    Public Sub LogOn_Get_ReturnsView()
        ' Disponer
        Dim controller As AccountController = GetAccountController()

        ' Actuar
        Dim result As ActionResult = controller.LogOn()

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(ViewResult))
    End Sub

    <TestMethod()> _
    Public Sub LogOn_Post_ReturnsRedirectOnSuccess_WithoutReturnUrl()
        ' Disponer
        Dim controller As AccountController = GetAccountController()
        Dim model As Logonmodel = New logonmodel()
        model.UserName = "someUser"
        model.Password = "goodPassword"
        model.RememberMe = False

        ' Actuar
        Dim result As ActionResult = controller.LogOn(model, Nothing)

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(RedirectToRouteResult))
        Dim redirectResult As RedirectToRouteResult = CType(result, redirecttorouteresult)
        Assert.AreEqual("Home", redirectResult.RouteValues("controller"))
        Assert.AreEqual("Index", redirectResult.RouteValues("action"))
        Assert.IsTrue(CType(controller.formsservice, MockFormsAuthenticationService).SignIn_WasCalled)
    End Sub

    <TestMethod()> _
    Public Sub LogOn_Post_ReturnsRedirectOnSuccess_WithReturnUrl()
        ' Disponer
        Dim controller As AccountController = GetAccountController()
        Dim model As Logonmodel = New logonmodel()
        model.UserName = "someUser"
        model.Password = "goodPassword"
        model.RememberMe = False

        ' Actuar
        Dim result As ActionResult = controller.LogOn(model, "/someUrl")

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(RedirectResult))
        Dim redirectResult As RedirectResult = CType(result, RedirectResult)
        Assert.AreEqual("/someUrl", redirectResult.Url)
        Assert.IsTrue(CType(controller.FormsService, MockFormsAuthenticationService).SignIn_WasCalled)
    End Sub


    <TestMethod()> _
    Public Sub LogOn_Post_ReturnsViewIfModelStateIsInvalid()
        ' Disponer
        Dim controller As AccountController = GetAccountController()
        Dim model As Logonmodel = New logonmodel()
        model.UserName = "someUser"
        model.Password = "goodPassword"
        model.RememberMe = False
        controller.ModelState.AddModelError("", "Mensaje de error ficticio.")

        ' Actuar
        Dim result As ActionResult = controller.LogOn(model, Nothing)

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(ViewResult))
        Dim viewResult As viewresult = CType(result, viewresult)
        Assert.AreEqual(model, viewResult.ViewData.Model)
    End Sub

    <TestMethod()> _
    Public Sub LogOn_Post_ReturnsViewIfValidateUserFails()
        ' Disponer
        Dim controller As AccountController = GetAccountController()
        Dim model As Logonmodel = New logonmodel()
        model.UserName = "someUser"
        model.Password = "badPassword"
        model.RememberMe = False

        ' Actuar
        Dim result As ActionResult = controller.LogOn(model, Nothing)

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(ViewResult))
        Dim viewResult As viewresult = CType(result, viewresult)
        Assert.AreEqual(model, viewResult.ViewData.Model)
        Assert.AreEqual("El nombre de usuario o la contraseña especificados son incorrectos.", controller.ModelState("").Errors(0).ErrorMessage)
    End Sub

    <TestMethod()> _
    Public Sub Register_Get_ReturnsView()
        ' Disponer
        Dim controller As AccountController = GetAccountController()

        ' Actuar
        Dim result As ActionResult = controller.Register()

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(ViewResult))
        Assert.AreEqual(10, CType(result, ViewResult).ViewData("PasswordLength"))
    End Sub

    <TestMethod()> _
    Public Sub Register_Post_ReturnsRedirectOnSuccess()
        ' Disponer
        Dim controller As AccountController = GetAccountController()
        Dim model As registermodel = New registermodel()
        model.UserName = "someUser"
        model.Email = "goodEmail"
        model.Password = "goodPassword"
        model.ConfirmPassword = "goodPassword"

        ' Actuar
        Dim result As ActionResult = controller.Register(model)

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(RedirectToRouteResult))
        Dim redirectResult As RedirectToRouteResult = CType(result, redirecttorouteresult)
        Assert.AreEqual("Home", redirectResult.RouteValues("controller"))
        Assert.AreEqual("Index", redirectResult.RouteValues("action"))
    End Sub

    <TestMethod()> _
    Public Sub Register_Post_ReturnsViewIfRegistrationFails()
        ' Disponer
        Dim controller As AccountController = GetAccountController()
        Dim model As registermodel = New registermodel()
        model.UserName = "duplicateUser"
        model.Email = "goodEmail"
        model.Password = "goodPassword"
        model.ConfirmPassword = "goodPassword"

        ' Actuar
        Dim result As ActionResult = controller.Register(model)

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(ViewResult))
        Dim viewResult As viewresult = CType(result, viewresult)
        Assert.AreEqual(model, viewResult.ViewData.Model)
        Assert.AreEqual("El nombre de usuario ya existe. Escriba otro nombre de usuario.", controller.ModelState("").Errors(0).ErrorMessage)
        Assert.AreEqual(10, viewResult.ViewData("PasswordLength"))
    End Sub

    <TestMethod()> _
    Public Sub Register_Post_ReturnsViewIfModelStateIsInvalid()
        ' Disponer
        Dim controller As AccountController = GetAccountController()
        Dim model As registermodel = New registermodel()
        model.UserName = "someUser"
        model.Email = "goodEmail"
        model.Password = "goodPassword"
        model.ConfirmPassword = "goodPassword"
        controller.ModelState.AddModelError("", "Mensaje de error ficticio.")

        ' Actuar
        Dim result As ActionResult = controller.Register(model)

        ' Declarar
        Assert.IsInstanceOfType(result, GetType(ViewResult))
        Dim viewResult As viewresult = CType(result, viewresult)
        Assert.AreEqual(model, viewResult.ViewData.Model)
        Assert.AreEqual(10, viewResult.ViewData("PasswordLength"))
    End Sub

    Private Shared Function GetAccountController() As AccountController
        Dim controller As AccountController = New AccountController()
        controller.FormsService = New MockFormsAuthenticationService()
        controller.MembershipService = New MockMembershipService()
        controller.ControllerContext = New ControllerContext()
        controller.ControllerContext.Controller = controller
        controller.ControllerContext.RequestContext = New RequestContext(New MockHttpContext(), New RouteData())

        Return controller
    End Function

    Private Class MockFormsAuthenticationService
        Implements IFormsAuthenticationService

        Public SignIn_WasCalled As Boolean
        Public SignOut_WasCalled As Boolean

        Public Sub SignIn(ByVal userName As String, ByVal createPersistentCookie As Boolean) Implements IFormsAuthenticationService.SignIn
            ' comprobar que los argumentos son los esperados
            Assert.AreEqual("someUser", userName)
            Assert.IsFalse(createPersistentCookie)

            SignIn_WasCalled = True
        End Sub

        Public Sub SignOut() Implements IFormsAuthenticationService.SignOut
            SignOut_WasCalled = True
        End Sub
    End Class

    Private Class MockHttpContext
        Inherits HttpContextBase

        Private ReadOnly _user As IPrincipal = New GenericPrincipal(New GenericIdentity("someUser"), Nothing)

        Public Overrides Property User() As IPrincipal
            Get
                Return _user
            End Get
            Set(ByVal value As System.Security.Principal.IPrincipal)
                MyBase.User = value
            End Set
        End Property
    End Class

    Private Class MockMembershipService
        Implements IMembershipService

        Public ReadOnly Property MinPasswordLength() As Integer Implements IMembershipService.MinPasswordLength
            Get
                Return 10
            End Get
        End Property

        Public Function ChangePassword(ByVal userName As String, ByVal oldPassword As String, ByVal newPassword As String) As Boolean Implements IMembershipService.ChangePassword
            Return userName = "someUser" AndAlso oldPassword = "goodOldPassword" AndAlso newPassword = "goodNewPassword"
        End Function

        Public Function CreateUser(ByVal userName As String, ByVal password As String, ByVal email As String) As System.Web.Security.MembershipCreateStatus Implements IMembershipService.CreateUser
            If userName = "duplicateUser" Then
                Return MembershipCreateStatus.DuplicateUserName
            End If

            ' comprobar que los valores son los esperados
            Assert.AreEqual("goodPassword", password)
            Assert.AreEqual("goodEmail", email)

            Return MembershipCreateStatus.Success
        End Function

        Public Function ValidateUser(ByVal userName As String, ByVal password As String) As Boolean Implements IMembershipService.ValidateUser
            Return userName = "someUser" AndAlso password = "goodPassword"
        End Function
    End Class

End Class


