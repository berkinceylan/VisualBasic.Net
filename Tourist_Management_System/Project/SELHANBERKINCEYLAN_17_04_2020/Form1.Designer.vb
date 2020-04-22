<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CitysInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnkaraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DenizliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.İstanbulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.İzmirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MersinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZonguldakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContectUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithMobilePhoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithSellerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.White
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("SF Pro Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Adana", "Ankara", "Denizli", "İstanbul", "İzmir", "Mersin", "Zonguldak"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(4, 4)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(298, 608)
        Me.CheckedListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("SF Pro Display", 21.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(561, 61)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cities for going around:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 99)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1362, 955)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CitysInfoToolStripMenuItem, Me.ContectUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1672, 38)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CitysInfoToolStripMenuItem
        '
        Me.CitysInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdanaToolStripMenuItem, Me.AnkaraToolStripMenuItem, Me.DenizliToolStripMenuItem, Me.İstanbulToolStripMenuItem, Me.İzmirToolStripMenuItem, Me.MersinToolStripMenuItem, Me.ZonguldakToolStripMenuItem})
        Me.CitysInfoToolStripMenuItem.Name = "CitysInfoToolStripMenuItem"
        Me.CitysInfoToolStripMenuItem.Size = New System.Drawing.Size(123, 34)
        Me.CitysInfoToolStripMenuItem.Text = "City's Info"
        '
        'AdanaToolStripMenuItem
        '
        Me.AdanaToolStripMenuItem.Name = "AdanaToolStripMenuItem"
        Me.AdanaToolStripMenuItem.Size = New System.Drawing.Size(229, 40)
        Me.AdanaToolStripMenuItem.Text = "Adana"
        '
        'AnkaraToolStripMenuItem
        '
        Me.AnkaraToolStripMenuItem.Name = "AnkaraToolStripMenuItem"
        Me.AnkaraToolStripMenuItem.Size = New System.Drawing.Size(229, 40)
        Me.AnkaraToolStripMenuItem.Text = "Ankara"
        '
        'DenizliToolStripMenuItem
        '
        Me.DenizliToolStripMenuItem.Name = "DenizliToolStripMenuItem"
        Me.DenizliToolStripMenuItem.Size = New System.Drawing.Size(229, 40)
        Me.DenizliToolStripMenuItem.Text = "Denizli"
        '
        'İstanbulToolStripMenuItem
        '
        Me.İstanbulToolStripMenuItem.Name = "İstanbulToolStripMenuItem"
        Me.İstanbulToolStripMenuItem.Size = New System.Drawing.Size(229, 40)
        Me.İstanbulToolStripMenuItem.Text = "İstanbul"
        '
        'İzmirToolStripMenuItem
        '
        Me.İzmirToolStripMenuItem.Name = "İzmirToolStripMenuItem"
        Me.İzmirToolStripMenuItem.Size = New System.Drawing.Size(229, 40)
        Me.İzmirToolStripMenuItem.Text = "İzmir"
        '
        'MersinToolStripMenuItem
        '
        Me.MersinToolStripMenuItem.Name = "MersinToolStripMenuItem"
        Me.MersinToolStripMenuItem.Size = New System.Drawing.Size(229, 40)
        Me.MersinToolStripMenuItem.Text = "Mersin"
        '
        'ZonguldakToolStripMenuItem
        '
        Me.ZonguldakToolStripMenuItem.Name = "ZonguldakToolStripMenuItem"
        Me.ZonguldakToolStripMenuItem.Size = New System.Drawing.Size(229, 40)
        Me.ZonguldakToolStripMenuItem.Text = "Zonguldak"
        '
        'ContectUsToolStripMenuItem
        '
        Me.ContectUsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WithMailToolStripMenuItem, Me.WithMobilePhoneToolStripMenuItem, Me.WithSellerToolStripMenuItem})
        Me.ContectUsToolStripMenuItem.Name = "ContectUsToolStripMenuItem"
        Me.ContectUsToolStripMenuItem.Size = New System.Drawing.Size(132, 34)
        Me.ContectUsToolStripMenuItem.Text = "Contect Us"
        '
        'WithMailToolStripMenuItem
        '
        Me.WithMailToolStripMenuItem.Name = "WithMailToolStripMenuItem"
        Me.WithMailToolStripMenuItem.Size = New System.Drawing.Size(305, 40)
        Me.WithMailToolStripMenuItem.Text = "with Mail"
        '
        'WithMobilePhoneToolStripMenuItem
        '
        Me.WithMobilePhoneToolStripMenuItem.Name = "WithMobilePhoneToolStripMenuItem"
        Me.WithMobilePhoneToolStripMenuItem.Size = New System.Drawing.Size(305, 40)
        Me.WithMobilePhoneToolStripMenuItem.Text = "with Mobile Phone"
        '
        'WithSellerToolStripMenuItem
        '
        Me.WithSellerToolStripMenuItem.Name = "WithSellerToolStripMenuItem"
        Me.WithSellerToolStripMenuItem.Size = New System.Drawing.Size(305, 40)
        Me.WithSellerToolStripMenuItem.Text = "with Seller"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(294, 29)
        Me.TextBox1.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkâri", "Hatay", "Iğdır", "Isparta", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Sivas", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat"})
        Me.ComboBox1.Location = New System.Drawing.Point(0, 29)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(294, 32)
        Me.ComboBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 278)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(294, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add City"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(6, 630)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 319)
        Me.Panel1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Location = New System.Drawing.Point(156, 61)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 217)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Add Image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(0, 61)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(294, 217)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'ımageList1
        '
        Me.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ımageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.CheckedListBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1366, 99)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.36204!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.63797!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(306, 955)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1672, 1054)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1638, 965)
        Me.Name = "Form1"
        Me.Text = "Tourist Information System_BERKINCEYLAN_170303006"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CitysInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContectUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnkaraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DenizliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents İstanbulToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents İzmirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MersinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZonguldakToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents WithMailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WithMobilePhoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WithSellerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Protected Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
