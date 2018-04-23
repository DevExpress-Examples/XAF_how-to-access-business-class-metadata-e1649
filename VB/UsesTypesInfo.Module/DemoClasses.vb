Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace UsesTypesInfo.Module

    <AttributeUsage(AttributeTargets.Class, Inherited := False)> _
    Public Class MyCustomAttribute
        Inherits Attribute
    End Class

    <MyCustomAttribute, DefaultClassOptions> _
    Public Class DemoContact
        Inherits BaseObject
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property Email() As String
            Get
                Return GetPropertyValue(Of String)("Email")
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Email", value)
            End Set
        End Property
    End Class

    <DefaultClassOptions> _
    Public Class DemoPerson
        Inherits BaseObject
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property Name() As String
            Get
                Return GetPropertyValue(Of String)("Name")
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Name", value)
            End Set
        End Property
    End Class

End Namespace
