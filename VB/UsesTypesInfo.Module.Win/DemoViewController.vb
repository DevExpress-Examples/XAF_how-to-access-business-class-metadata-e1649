Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base

Namespace UsesTypesInfo.Module.Win
    Partial Public Class DemoViewController
        Inherits ViewController
        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
        End Sub

        Private Sub DemoViewController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
            If View.ObjectTypeInfo.FindAttribute(Of MyCustomAttribute)() IsNot Nothing Then
                ' if the business class represented by currently active View has
                ' the custom attribute applied, perform some actions
                '...
                System.Windows.Forms.MessageBox.Show("The custom attribute is applied")
            Else
                System.Windows.Forms.MessageBox.Show("The custom attribute isn't applied")
            End If
        End Sub
    End Class
End Namespace
