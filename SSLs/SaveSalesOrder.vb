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

Partial Public Class SaveSalesOrder
    Public Property Id As Integer
    Public Property QtyReq As Integer
    Public Property Description As String
    Public Property CreateDate As Date
    Public Property CreateBy As String
    Public Property UpdateDate As Date
    Public Property UpdateBy As String
    Public Property Enable As Boolean

    Public Overridable Property SaveSalesOrderDetails As ICollection(Of SaveSalesOrderDetails) = New HashSet(Of SaveSalesOrderDetails)

End Class
