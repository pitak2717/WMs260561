'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class SaveDeliveryOrderDetails
    Public Property Id As Integer
    Public Property Description As String
    Public Property CreateDate As Date
    Public Property CreateBy As String
    Public Property UpdateDate As Date
    Public Property UpdateBy As String
    Public Property Enable As Boolean
    Public Property FKSaveDeliveryOrder As Integer
    Public Property CompCode As String
    Public Property ShipTo As String
    Public Property DODoc As String
    Public Property DODate As Date
    Public Property Material As String
    Public Property MaterialText As String
    Public Property Plant As String
    Public Property BaseQty As Decimal
    Public Property BaseUnit As String
    Public Property Status As String
    Public Property Func As String
    Public Property WMsWH As String
    Public Property TakeOrderBy As String
    Public Property TakeOrderDate As Nullable(Of Date)
    Public Property RejectDate As Nullable(Of Date)
    Public Property ItemCate As String

    Public Overridable Property SaveDeliveryOrder As SaveDeliveryOrder

End Class
