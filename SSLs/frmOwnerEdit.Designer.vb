﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOwnerEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.tbTel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFax = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTax = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(485, 256)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 23)
        Me.btDelete.TabIndex = 331
        Me.btDelete.Text = "Delete"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(603, 256)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 330
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'tbTel
        '
        Me.tbTel.Location = New System.Drawing.Point(66, 106)
        Me.tbTel.MaxLength = 100
        Me.tbTel.Name = "tbTel"
        Me.tbTel.Size = New System.Drawing.Size(612, 20)
        Me.tbTel.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 329
        Me.Label5.Text = "เบอร์โทร :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(66, 60)
        Me.tbAddress.MaxLength = 200
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(612, 40)
        Me.tbAddress.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 328
        Me.Label4.Text = "ที่อยู่ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbDesc
        '
        Me.tbDesc.Location = New System.Drawing.Point(66, 210)
        Me.tbDesc.MaxLength = 200
        Me.tbDesc.Multiline = True
        Me.tbDesc.Name = "tbDesc"
        Me.tbDesc.Size = New System.Drawing.Size(612, 40)
        Me.tbDesc.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 327
        Me.Label3.Text = "หมายเหตุ :"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(66, 34)
        Me.tbName.MaxLength = 100
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(612, 20)
        Me.tbName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 326
        Me.Label2.Text = "ชื่อเจ้าของ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCode
        '
        Me.tbCode.Location = New System.Drawing.Point(66, 8)
        Me.tbCode.MaxLength = 15
        Me.tbCode.Name = "tbCode"
        Me.tbCode.Size = New System.Drawing.Size(101, 20)
        Me.tbCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 325
        Me.Label1.Text = "รหัส  :"
        '
        'tbFax
        '
        Me.tbFax.Location = New System.Drawing.Point(66, 132)
        Me.tbFax.MaxLength = 100
        Me.tbFax.Name = "tbFax"
        Me.tbFax.Size = New System.Drawing.Size(612, 20)
        Me.tbFax.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 333
        Me.Label6.Text = "Fax :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(66, 158)
        Me.tbEmail.MaxLength = 100
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(612, 20)
        Me.tbEmail.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 335
        Me.Label7.Text = "Email :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTax
        '
        Me.tbTax.Location = New System.Drawing.Point(125, 184)
        Me.tbTax.MaxLength = 40
        Me.tbTax.Name = "tbTax"
        Me.tbTax.Size = New System.Drawing.Size(251, 20)
        Me.tbTax.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 337
        Me.Label8.Text = "เลขประจำตัวผู้เสียภาษี :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmOwnerEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 283)
        Me.Controls.Add(Me.tbTax)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbFax)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.tbTel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCode)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOwnerEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "เพิ่ม/แก้ไขรายละเอียดเจ้าของสินค้า"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btDelete As Button
    Friend WithEvents btSave As Button
    Friend WithEvents tbTel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbFax As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbTax As TextBox
    Friend WithEvents Label8 As Label
End Class
