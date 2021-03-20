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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RoastingLabel = New System.Windows.Forms.Label()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.Startbttn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Stopbttn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Savebttn = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RoastingPic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoastingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.RoastingLabel)
        Me.Panel1.Controls.Add(Me.RoastingPic)
        Me.Panel1.Controls.Add(Me.Closebtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 25)
        Me.Panel1.TabIndex = 0
        '
        'RoastingLabel
        '
        Me.RoastingLabel.AutoSize = True
        Me.RoastingLabel.Location = New System.Drawing.Point(31, 6)
        Me.RoastingLabel.Name = "RoastingLabel"
        Me.RoastingLabel.Size = New System.Drawing.Size(161, 14)
        Me.RoastingLabel.TabIndex = 2
        Me.RoastingLabel.Text = "Roasting Password List Creator"
        '
        'Closebtn
        '
        Me.Closebtn.BackColor = System.Drawing.Color.Red
        Me.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Closebtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Closebtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Closebtn.Location = New System.Drawing.Point(570, 0)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(25, 25)
        Me.Closebtn.TabIndex = 0
        Me.Closebtn.Text = "X"
        Me.Closebtn.UseVisualStyleBackColor = False
        '
        'Startbttn
        '
        Me.Startbttn.Location = New System.Drawing.Point(12, 112)
        Me.Startbttn.Name = "Startbttn"
        Me.Startbttn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Startbttn.Size = New System.Drawing.Size(213, 25)
        Me.Startbttn.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Startbttn.TabIndex = 1
        Me.Startbttn.Values.Text = "Start"
        '
        'Stopbttn
        '
        Me.Stopbttn.Location = New System.Drawing.Point(12, 190)
        Me.Stopbttn.Name = "Stopbttn"
        Me.Stopbttn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Stopbttn.Size = New System.Drawing.Size(213, 25)
        Me.Stopbttn.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stopbttn.TabIndex = 2
        Me.Stopbttn.Values.Text = "Stop"
        '
        'Savebttn
        '
        Me.Savebttn.Location = New System.Drawing.Point(12, 268)
        Me.Savebttn.Name = "Savebttn"
        Me.Savebttn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Savebttn.Size = New System.Drawing.Size(213, 25)
        Me.Savebttn.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebttn.TabIndex = 3
        Me.Savebttn.Values.Text = "Save to txt"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(82, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "a"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(252, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(329, 232)
        Me.TextBox1.TabIndex = 6
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown1.Location = New System.Drawing.Point(135, 76)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(90, 20)
        Me.NumericUpDown1.TabIndex = 13
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 14)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "# of Passwords Generated:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(412, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 14)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Initial String:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 14)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Size of Random String:"
        '
        'Timer1
        '
        '
        'RoastingPic
        '
        Me.RoastingPic.BackColor = System.Drawing.Color.Black
        Me.RoastingPic.Image = Global.Roasting_Password_List_Creator.My.Resources.Resources.generate
        Me.RoastingPic.Location = New System.Drawing.Point(0, 0)
        Me.RoastingPic.Name = "RoastingPic"
        Me.RoastingPic.Size = New System.Drawing.Size(25, 25)
        Me.RoastingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RoastingPic.TabIndex = 1
        Me.RoastingPic.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(595, 305)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Savebttn)
        Me.Controls.Add(Me.Stopbttn)
        Me.Controls.Add(Me.Startbttn)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoastingPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Closebtn As Button
    Friend WithEvents RoastingLabel As Label
    Friend WithEvents RoastingPic As PictureBox
    Friend WithEvents Startbttn As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Stopbttn As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Savebttn As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
End Class
