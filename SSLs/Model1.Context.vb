﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class PTGwmsEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=PTGwmsEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Company() As DbSet(Of Company)
    Public Overridable Property Menu() As DbSet(Of Menu)
    Public Overridable Property MenuAccess() As DbSet(Of MenuAccess)
    Public Overridable Property OwnerAccess() As DbSet(Of OwnerAccess)
    Public Overridable Property Role() As DbSet(Of Role)
    Public Overridable Property WarehouseAccess() As DbSet(Of WarehouseAccess)
    Public Overridable Property ChangeSalesOrder() As DbSet(Of ChangeSalesOrder)
    Public Overridable Property ChangeSalesOrderDetails() As DbSet(Of ChangeSalesOrderDetails)
    Public Overridable Property CheckStockAvailable() As DbSet(Of CheckStockAvailable)
    Public Overridable Property CheckStockAvailableDetails() As DbSet(Of CheckStockAvailableDetails)
    Public Overridable Property GoodsIssueOrder() As DbSet(Of GoodsIssueOrder)
    Public Overridable Property GoodsIssueOrderDetails() As DbSet(Of GoodsIssueOrderDetails)
    Public Overridable Property ReturnDeliveryOrder() As DbSet(Of ReturnDeliveryOrder)
    Public Overridable Property ReturnDeliveryOrderDetails() As DbSet(Of ReturnDeliveryOrderDetails)
    Public Overridable Property SaveDeliveryOrder() As DbSet(Of SaveDeliveryOrder)
    Public Overridable Property SaveDeliveryOrderDetails() As DbSet(Of SaveDeliveryOrderDetails)
    Public Overridable Property SaveSalesOrder() As DbSet(Of SaveSalesOrder)
    Public Overridable Property SaveSalesOrderDetails() As DbSet(Of SaveSalesOrderDetails)
    Public Overridable Property SD004Dtl() As DbSet(Of SD004Dtl)
    Public Overridable Property SD004HD() As DbSet(Of SD004HD)
    Public Overridable Property SD007CancelGIGR() As DbSet(Of SD007CancelGIGR)
    Public Overridable Property WmsNoGenerate() As DbSet(Of WmsNoGenerate)
    Public Overridable Property BoxSize() As DbSet(Of BoxSize)
    Public Overridable Property Drivers() As DbSet(Of Drivers)
    Public Overridable Property Otherfees() As DbSet(Of Otherfees)
    Public Overridable Property TravelFee() As DbSet(Of TravelFee)
    Public Overridable Property Vehicles() As DbSet(Of Vehicles)
    Public Overridable Property VehicleType() As DbSet(Of VehicleType)
    Public Overridable Property AdjustReason() As DbSet(Of AdjustReason)
    Public Overridable Property BatchRunning() As DbSet(Of BatchRunning)
    Public Overridable Property Branch() As DbSet(Of Branch)
    Public Overridable Property CheckStockLocation() As DbSet(Of CheckStockLocation)
    Public Overridable Property CostCenter() As DbSet(Of CostCenter)
    Public Overridable Property CurrentStocks() As DbSet(Of CurrentStocks)
    Public Overridable Property Customers() As DbSet(Of Customers)
    Public Overridable Property CycleCountDTL() As DbSet(Of CycleCountDTL)
    Public Overridable Property CycleCountHD() As DbSet(Of CycleCountHD)
    Public Overridable Property Department() As DbSet(Of Department)
    Public Overridable Property Employee() As DbSet(Of Employee)
    Public Overridable Property IOMaster() As DbSet(Of IOMaster)
    Public Overridable Property IssueSum() As DbSet(Of IssueSum)
    Public Overridable Property ItemStatus() As DbSet(Of ItemStatus)
    Public Overridable Property LabelLog() As DbSet(Of LabelLog)
    Public Overridable Property Locations() As DbSet(Of Locations)
    Public Overridable Property LocationType() As DbSet(Of LocationType)
    Public Overridable Property ManageZone() As DbSet(Of ManageZone)
    Public Overridable Property MaterialTrans() As DbSet(Of MaterialTrans)
    Public Overridable Property MovementType() As DbSet(Of MovementType)
    Public Overridable Property Owners() As DbSet(Of Owners)
    Public Overridable Property PhyCountHD() As DbSet(Of PhyCountHD)
    Public Overridable Property PickingType() As DbSet(Of PickingType)
    Public Overridable Property PickTempOrderDTL() As DbSet(Of PickTempOrderDTL)
    Public Overridable Property PickTempOrderHD() As DbSet(Of PickTempOrderHD)
    Public Overridable Property PickTote() As DbSet(Of PickTote)
    Public Overridable Property ProductBrands() As DbSet(Of ProductBrands)
    Public Overridable Property ProductDetails() As DbSet(Of ProductDetails)
    Public Overridable Property ProductGroups() As DbSet(Of ProductGroups)
    Public Overridable Property Products() As DbSet(Of Products)
    Public Overridable Property ProductType() As DbSet(Of ProductType)
    Public Overridable Property ProductUnit() As DbSet(Of ProductUnit)
    Public Overridable Property RcvDetails() As DbSet(Of RcvDetails)
    Public Overridable Property RcvHeader() As DbSet(Of RcvHeader)
    Public Overridable Property RcvLocation() As DbSet(Of RcvLocation)
    Public Overridable Property RcvTempDetail() As DbSet(Of RcvTempDetail)
    Public Overridable Property RcvTempHeader() As DbSet(Of RcvTempHeader)
    Public Overridable Property RcvTempSetPallet() As DbSet(Of RcvTempSetPallet)
    Public Overridable Property RcvType() As DbSet(Of RcvType)
    Public Overridable Property RTVRunning() As DbSet(Of RTVRunning)
    Public Overridable Property StockCard() As DbSet(Of StockCard)
    Public Overridable Property StockOnhand() As DbSet(Of StockOnhand)
    Public Overridable Property TransferDTL() As DbSet(Of TransferDTL)
    Public Overridable Property TransferHD() As DbSet(Of TransferHD)
    Public Overridable Property Transports() As DbSet(Of Transports)
    Public Overridable Property Vendor() As DbSet(Of Vendor)
    Public Overridable Property Warehouse() As DbSet(Of Warehouse)
    Public Overridable Property Zone() As DbSet(Of Zone)
    Public Overridable Property V_GL100AP() As DbSet(Of V_GL100AP)
    Public Overridable Property V_GL100AR() As DbSet(Of V_GL100AR)
    Public Overridable Property V_PickConfirm() As DbSet(Of V_PickConfirm)
    Public Overridable Property V_PickStatus() As DbSet(Of V_PickStatus)
    Public Overridable Property V_TransferConfirm() As DbSet(Of V_TransferConfirm)
    Public Overridable Property V_LocationEmpty() As DbSet(Of V_LocationEmpty)
    Public Overridable Property V_RPTCycleCount() As DbSet(Of V_RPTCycleCount)
    Public Overridable Property V_RTPPrintInternalBar() As DbSet(Of V_RTPPrintInternalBar)
    Public Overridable Property V_StockBal() As DbSet(Of V_StockBal)
    Public Overridable Property V_StockCard() As DbSet(Of V_StockCard)
    Public Overridable Property V_StockLocation() As DbSet(Of V_StockLocation)
    Public Overridable Property V_SumRcvDetail() As DbSet(Of V_SumRcvDetail)
    Public Overridable Property V_RcvReport() As DbSet(Of V_RcvReport)
    Public Overridable Property V_RcvStatus() As DbSet(Of V_RcvStatus)
    Public Overridable Property V_PhyCount() As DbSet(Of V_PhyCount)
    Public Overridable Property CurrentStocksLog() As DbSet(Of CurrentStocksLog)
    Public Overridable Property V_InterfaceOrder() As DbSet(Of V_InterfaceOrder)
    Public Overridable Property PhyCountDTL() As DbSet(Of PhyCountDTL)
    Public Overridable Property TransferLog() As DbSet(Of TransferLog)
    Public Overridable Property PickOrderDTL() As DbSet(Of PickOrderDTL)
    Public Overridable Property PickOrderHD() As DbSet(Of PickOrderHD)
    Public Overridable Property V_PickLocationSel() As DbSet(Of V_PickLocationSel)
    Public Overridable Property RcvRunning() As DbSet(Of RcvRunning)
    Public Overridable Property V_PickOrderPosted() As DbSet(Of V_PickOrderPosted)
    Public Overridable Property Users() As DbSet(Of Users)
    Public Overridable Property PickLocation() As DbSet(Of PickLocation)

    <DbFunction("PTGwmsEntities", "FN_StockBalHis")>
    Public Overridable Function FN_StockBalHis(tDate As String, wHID As Nullable(Of Integer)) As IQueryable(Of FN_StockBalHis_Result)
        Dim tDateParameter As ObjectParameter = If(tDate IsNot Nothing, New ObjectParameter("TDate", tDate), New ObjectParameter("TDate", GetType(String)))

        Dim wHIDParameter As ObjectParameter = If(wHID.HasValue, New ObjectParameter("WHID", wHID), New ObjectParameter("WHID", GetType(Integer)))

         Return DirectCast(Me, IObjectContextAdapter).ObjectContext.CreateQuery(Of FN_StockBalHis_Result)("[PTGwmsEntities].[FN_StockBalHis](@TDate, @WHID)", tDateParameter, wHIDParameter)
    End Function

End Class