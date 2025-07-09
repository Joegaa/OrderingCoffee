<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Mid_Panel = New System.Windows.Forms.Panel()
        Me.ShowPanel = New System.Windows.Forms.Panel()
        Me.TotalOrderBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FinalOrder = New System.Windows.Forms.Button()
        Me.Button_Panel = New System.Windows.Forms.Panel()
        Me.FrappeB = New System.Windows.Forms.Button()
        Me.HotB = New System.Windows.Forms.Button()
        Me.ColdB = New System.Windows.Forms.Button()
        Me.CheeseButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Top_Panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Mid_Panel.SuspendLayout()
        Me.ShowPanel.SuspendLayout()
        Me.Button_Panel.SuspendLayout()
        Me.Top_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Mid_Panel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1292, 804)
        Me.Panel1.TabIndex = 1
        '
        'Mid_Panel
        '
        Me.Mid_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mid_Panel.BackColor = System.Drawing.Color.Tomato
        Me.Mid_Panel.Controls.Add(Me.ShowPanel)
        Me.Mid_Panel.Controls.Add(Me.Button_Panel)
        Me.Mid_Panel.Location = New System.Drawing.Point(48, 7)
        Me.Mid_Panel.Name = "Mid_Panel"
        Me.Mid_Panel.Size = New System.Drawing.Size(1196, 794)
        Me.Mid_Panel.TabIndex = 2
        '
        'ShowPanel
        '
        Me.ShowPanel.Controls.Add(Me.TotalOrderBox)
        Me.ShowPanel.Controls.Add(Me.Label2)
        Me.ShowPanel.Controls.Add(Me.FinalOrder)
        Me.ShowPanel.Location = New System.Drawing.Point(4, 88)
        Me.ShowPanel.Name = "ShowPanel"
        Me.ShowPanel.Size = New System.Drawing.Size(1185, 697)
        Me.ShowPanel.TabIndex = 1
        '
        'TotalOrderBox
        '
        Me.TotalOrderBox.BackColor = System.Drawing.Color.Orange
        Me.TotalOrderBox.Font = New System.Drawing.Font("Lucida Handwriting", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalOrderBox.ForeColor = System.Drawing.Color.Black
        Me.TotalOrderBox.Location = New System.Drawing.Point(196, 659)
        Me.TotalOrderBox.Name = "TotalOrderBox"
        Me.TotalOrderBox.ReadOnly = True
        Me.TotalOrderBox.Size = New System.Drawing.Size(117, 38)
        Me.TotalOrderBox.TabIndex = 2
        Me.TotalOrderBox.Text = "0.00"
        Me.TotalOrderBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 664)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Order:"
        '
        'FinalOrder
        '
        Me.FinalOrder.BackColor = System.Drawing.Color.Orange
        Me.FinalOrder.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.FinalOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinalOrder.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalOrder.Location = New System.Drawing.Point(1003, 644)
        Me.FinalOrder.Name = "FinalOrder"
        Me.FinalOrder.Size = New System.Drawing.Size(180, 52)
        Me.FinalOrder.TabIndex = 0
        Me.FinalOrder.Text = "Finalize"
        Me.FinalOrder.UseVisualStyleBackColor = False
        '
        'Button_Panel
        '
        Me.Button_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_Panel.Controls.Add(Me.FrappeB)
        Me.Button_Panel.Controls.Add(Me.HotB)
        Me.Button_Panel.Controls.Add(Me.ColdB)
        Me.Button_Panel.Controls.Add(Me.CheeseButton)
        Me.Button_Panel.Controls.Add(Me.Button1)
        Me.Button_Panel.Location = New System.Drawing.Point(4, 6)
        Me.Button_Panel.Name = "Button_Panel"
        Me.Button_Panel.Size = New System.Drawing.Size(1188, 209)
        Me.Button_Panel.TabIndex = 0
        '
        'FrappeB
        '
        Me.FrappeB.AutoSize = True
        Me.FrappeB.BackColor = System.Drawing.Color.Orange
        Me.FrappeB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FrappeB.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FrappeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FrappeB.Font = New System.Drawing.Font("Lucida Handwriting", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrappeB.Location = New System.Drawing.Point(953, 3)
        Me.FrappeB.Name = "FrappeB"
        Me.FrappeB.Size = New System.Drawing.Size(232, 61)
        Me.FrappeB.TabIndex = 5
        Me.FrappeB.Text = "Frappe"
        Me.FrappeB.UseVisualStyleBackColor = False
        '
        'HotB
        '
        Me.HotB.AutoSize = True
        Me.HotB.BackColor = System.Drawing.Color.Orange
        Me.HotB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HotB.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.HotB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HotB.Font = New System.Drawing.Font("Lucida Handwriting", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotB.Location = New System.Drawing.Point(714, 3)
        Me.HotB.Name = "HotB"
        Me.HotB.Size = New System.Drawing.Size(232, 61)
        Me.HotB.TabIndex = 3
        Me.HotB.Text = "Hot Brew"
        Me.HotB.UseVisualStyleBackColor = False
        '
        'ColdB
        '
        Me.ColdB.AutoSize = True
        Me.ColdB.BackColor = System.Drawing.Color.Orange
        Me.ColdB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColdB.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ColdB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColdB.Font = New System.Drawing.Font("Lucida Handwriting", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColdB.Location = New System.Drawing.Point(476, 3)
        Me.ColdB.Name = "ColdB"
        Me.ColdB.Size = New System.Drawing.Size(232, 61)
        Me.ColdB.TabIndex = 2
        Me.ColdB.Text = "Cold Brew"
        Me.ColdB.UseVisualStyleBackColor = False
        '
        'CheeseButton
        '
        Me.CheeseButton.AutoSize = True
        Me.CheeseButton.BackColor = System.Drawing.Color.Orange
        Me.CheeseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheeseButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheeseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheeseButton.Font = New System.Drawing.Font("Lucida Handwriting", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheeseButton.Location = New System.Drawing.Point(238, 3)
        Me.CheeseButton.Name = "CheeseButton"
        Me.CheeseButton.Size = New System.Drawing.Size(232, 61)
        Me.CheeseButton.TabIndex = 1
        Me.CheeseButton.Text = "Cheesecake"
        Me.CheeseButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Handwriting", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 61)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Milk Tea"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Top_Panel
        '
        Me.Top_Panel.BackColor = System.Drawing.Color.Black
        Me.Top_Panel.BackgroundImage = Global.OrderingCoffee.My.Resources.Resources.pexels_francesco_ungaro_998641
        Me.Top_Panel.Controls.Add(Me.Label1)
        Me.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Top_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Top_Panel.Name = "Top_Panel"
        Me.Top_Panel.Size = New System.Drawing.Size(1292, 100)
        Me.Top_Panel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "YOU CHOOSE, WE BREW..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1292, 904)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Top_Panel)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordering Milk Tea"
        Me.Panel1.ResumeLayout(False)
        Me.Mid_Panel.ResumeLayout(False)
        Me.ShowPanel.ResumeLayout(False)
        Me.ShowPanel.PerformLayout()
        Me.Button_Panel.ResumeLayout(False)
        Me.Button_Panel.PerformLayout()
        Me.Top_Panel.ResumeLayout(False)
        Me.Top_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Top_Panel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Mid_Panel As Panel
    Friend WithEvents Button_Panel As Panel
    Friend WithEvents FrappeB As Button
    Friend WithEvents HotB As Button
    Friend WithEvents ColdB As Button
    Friend WithEvents CheeseButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ShowPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FinalOrder As Button
    Friend WithEvents Label2 As Label
    Public WithEvents TotalOrderBox As TextBox
End Class
