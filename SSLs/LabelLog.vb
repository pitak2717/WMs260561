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

Partial Public Class LabelLog
    Public Property Id As Integer
    Public Property FKProductDetail As Integer
    Public Property FKOwner As Integer
    Public Property Barcode As String
    Public Property PrintFlag As Boolean
    Public Property CreateDate As Date
    Public Property CreateBy As String
    Public Property Enable As Boolean
    Public Property FKCompany As Integer

    Public Overridable Property Owners As Owners
    Public Overridable Property ProductDetails As ProductDetails

End Class
