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

Partial Public Class PhyCountDTL
    Public Property Id As Integer
    Public Property FKHD As Integer
    Public Property FKProduct As Integer
    Public Property Qty As Decimal
    Public Property QtyCount As Decimal
    Public Property QtyDiff As Decimal
    Public Property QtyCost As Decimal
    Public Property NetPrice As Decimal
    Public Property UnitCode As String
    Public Property CostDiff As Nullable(Of Decimal)
    Public Property Remark As String
    Public Property FKItemStatus As Integer
    Public Property CreateDate As Date
    Public Property CreateBy As String
    Public Property UpdateDate As Date
    Public Property UpdateBy As String
    Public Property Enable As Boolean

    Public Overridable Property ItemStatus As ItemStatus
    Public Overridable Property PhyCountHD As PhyCountHD
    Public Overridable Property Products As Products

End Class