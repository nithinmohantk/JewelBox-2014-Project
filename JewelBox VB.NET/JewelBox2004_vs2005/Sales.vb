﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3705.288
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class Sales
    Inherits DataSet
    
    Private tableSales As SalesDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Sales")) Is Nothing) Then
                Me.Tables.Add(New SalesDataTable(ds.Tables("Sales")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Sales As SalesDataTable
        Get
            Return Me.tableSales
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As Sales = CType(MyBase.Clone,Sales)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Sales")) Is Nothing) Then
            Me.Tables.Add(New SalesDataTable(ds.Tables("Sales")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableSales = CType(Me.Tables("Sales"),SalesDataTable)
        If (Not (Me.tableSales) Is Nothing) Then
            Me.tableSales.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "Sales"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/Sales.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableSales = New SalesDataTable
        Me.Tables.Add(Me.tableSales)
    End Sub
    
    Private Function ShouldSerializeSales() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub SalesRowChangeEventHandler(ByVal sender As Object, ByVal e As SalesRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SalesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnSALESMANID As DataColumn
        
        Private column_DATE As DataColumn
        
        Private columnITEMCODE As DataColumn
        
        Private columnBILLNO As DataColumn
        
        Private columnNETAMOUNT As DataColumn
        
        Friend Sub New()
            MyBase.New("Sales")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property SALESMANIDColumn As DataColumn
            Get
                Return Me.columnSALESMANID
            End Get
        End Property
        
        Friend ReadOnly Property _DATEColumn As DataColumn
            Get
                Return Me.column_DATE
            End Get
        End Property
        
        Friend ReadOnly Property ITEMCODEColumn As DataColumn
            Get
                Return Me.columnITEMCODE
            End Get
        End Property
        
        Friend ReadOnly Property BILLNOColumn As DataColumn
            Get
                Return Me.columnBILLNO
            End Get
        End Property
        
        Friend ReadOnly Property NETAMOUNTColumn As DataColumn
            Get
                Return Me.columnNETAMOUNT
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As SalesRow
            Get
                Return CType(Me.Rows(index),SalesRow)
            End Get
        End Property
        
        Public Event SalesRowChanged As SalesRowChangeEventHandler
        
        Public Event SalesRowChanging As SalesRowChangeEventHandler
        
        Public Event SalesRowDeleted As SalesRowChangeEventHandler
        
        Public Event SalesRowDeleting As SalesRowChangeEventHandler
        
        Public Overloads Sub AddSalesRow(ByVal row As SalesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddSalesRow(ByVal SALESMANID As String, ByVal _DATE As Date, ByVal ITEMCODE As String, ByVal BILLNO As String, ByVal NETAMOUNT As Decimal) As SalesRow
            Dim rowSalesRow As SalesRow = CType(Me.NewRow,SalesRow)
            rowSalesRow.ItemArray = New Object() {SALESMANID, _DATE, ITEMCODE, BILLNO, NETAMOUNT}
            Me.Rows.Add(rowSalesRow)
            Return rowSalesRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As SalesDataTable = CType(MyBase.Clone,SalesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New SalesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnSALESMANID = Me.Columns("SALESMANID")
            Me.column_DATE = Me.Columns("DATE")
            Me.columnITEMCODE = Me.Columns("ITEMCODE")
            Me.columnBILLNO = Me.Columns("BILLNO")
            Me.columnNETAMOUNT = Me.Columns("NETAMOUNT")
        End Sub
        
        Private Sub InitClass()
            Me.columnSALESMANID = New DataColumn("SALESMANID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSALESMANID)
            Me.column_DATE = New DataColumn("DATE", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.column_DATE)
            Me.columnITEMCODE = New DataColumn("ITEMCODE", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnITEMCODE)
            Me.columnBILLNO = New DataColumn("BILLNO", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnBILLNO)
            Me.columnNETAMOUNT = New DataColumn("NETAMOUNT", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNETAMOUNT)
            Me.columnSALESMANID.AllowDBNull = false
            Me.column_DATE.AllowDBNull = false
            Me.columnITEMCODE.AllowDBNull = false
            Me.columnBILLNO.AllowDBNull = false
            Me.columnNETAMOUNT.AllowDBNull = false
        End Sub
        
        Public Function NewSalesRow() As SalesRow
            Return CType(Me.NewRow,SalesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New SalesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(SalesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.SalesRowChangedEvent) Is Nothing) Then
                RaiseEvent SalesRowChanged(Me, New SalesRowChangeEvent(CType(e.Row,SalesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.SalesRowChangingEvent) Is Nothing) Then
                RaiseEvent SalesRowChanging(Me, New SalesRowChangeEvent(CType(e.Row,SalesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.SalesRowDeletedEvent) Is Nothing) Then
                RaiseEvent SalesRowDeleted(Me, New SalesRowChangeEvent(CType(e.Row,SalesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.SalesRowDeletingEvent) Is Nothing) Then
                RaiseEvent SalesRowDeleting(Me, New SalesRowChangeEvent(CType(e.Row,SalesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveSalesRow(ByVal row As SalesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SalesRow
        Inherits DataRow
        
        Private tableSales As SalesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableSales = CType(Me.Table,SalesDataTable)
        End Sub
        
        Public Property SALESMANID As String
            Get
                Return CType(Me(Me.tableSales.SALESMANIDColumn),String)
            End Get
            Set
                Me(Me.tableSales.SALESMANIDColumn) = value
            End Set
        End Property
        
        Public Property _DATE As Date
            Get
                Return CType(Me(Me.tableSales._DATEColumn),Date)
            End Get
            Set
                Me(Me.tableSales._DATEColumn) = value
            End Set
        End Property
        
        Public Property ITEMCODE As String
            Get
                Return CType(Me(Me.tableSales.ITEMCODEColumn),String)
            End Get
            Set
                Me(Me.tableSales.ITEMCODEColumn) = value
            End Set
        End Property
        
        Public Property BILLNO As String
            Get
                Return CType(Me(Me.tableSales.BILLNOColumn),String)
            End Get
            Set
                Me(Me.tableSales.BILLNOColumn) = value
            End Set
        End Property
        
        Public Property NETAMOUNT As Decimal
            Get
                Return CType(Me(Me.tableSales.NETAMOUNTColumn),Decimal)
            End Get
            Set
                Me(Me.tableSales.NETAMOUNTColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SalesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As SalesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As SalesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As SalesRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
