
''Imports Wisej.Web
'''Imports System.Globalization
''Imports System.Data
'''Imports System.Windows.Forms
''Imports System.Drawing
''Imports Wisej.Web.Form

''Public Class combosax

''    Dim sparametros As String
''    Dim scConnect As String
''    Dim Alto As Double
''    Dim TEXTO_GUARDADO As String
''    Dim sidt As String
''    Dim sDescripciont As String
''    Dim myDS As DataSet
''    Dim myDSFILTRADO As DataSet
''    Dim AltoOriginalPadre As Integer = False
''    Dim bPASA As Boolean = False
''    Dim CONTADOR As Integer = 1
''    Dim TODOS As Boolean = False
''    Dim LIMITAR_REGISTROS As Boolean = False
''    Dim mostrar_Mensaje As Boolean = True
''    Dim LocationVar As Point
''    Dim f As New Form
''    Dim vAncho As Integer
''    Private Const maxGarbage As Integer = 1000
''    Private defaultTabla As New DataTable
''    Dim Num_Registros As Integer = 0

''    Public Event SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
''    Public Event KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

''    Public Version As String = "10 BETA 1"


''    Private Sub TextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.DoubleClick
''        TextBox1.SelectAll()
''    End Sub
''    Public Sub TextBox1_EnterKeyDown(ByVal objSender As Object, ByVal objArgs As Wisej.Web.KeyEventArgs) Handles TextBox1.KeyDown
''        Try
''            If sparametros Is Nothing Then

''                Exit Sub

''            End If

''            Dim i As Integer = 0
''            Me.BringToFront()
''            list_llenado.DataSource = Nothing
''            list_llenado.Items.Clear()

''            If LIMITAR_REGISTROS = True Then
''                TODOS = False
''                If Trim(TextBox1.Text).Length <= 2 Then
''                    list_llenado.Visible = False
''                    f.Close()
''                    TextBox1.Watermark = "Ingrese Por Lo Menos 3 Caracteres"
''                    Exit Sub
''                End If
''            End If

''            Dim swhere As String
''            If TODOS <> True Then
''                If TextBox1.Text <> Nothing Then
''                    swhere = sDescripciont & "  like '%" & CStr(TextBox1.Text) & "%'"
''                End If
''            End If

''            If LIMITAR_REGISTROS = True Then
''                Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sparametros, scConnect)
''                myDA.SelectCommand.CommandType = CommandType.Text
''                myDS = New DataSet
''                myDA.Fill(myDS, "SQLX")
''                Dim defaultV = myDS.Tables(0).DefaultView
''                defaultV.RowFilter = swhere
''                Dim objDT = defaultV.ToTable()

''                With list_llenado
''                    .DataSource = Nothing
''                    .Items.Clear()
''                    .ValueMember = sidt
''                    .DataSource = objDT
''                    .DisplayMember = sDescripciont

''                End With

''                Dim max As Integer = 0
''                For Each row As DataRow In Me.DataSource.Tables(0).Rows



''                    f.Width = Me.Width
''                    If max < Len(row(sDescripciont).ToString) Then
''                        max = Len(row(sDescripciont).ToString)
''                        If max * 8 > Me.Width Then
''                            list_llenado.Width = max * 8
''                            list_llenado.Dock = DockStyle.None

''                            list_llenado.Top = 0
''                        Else

''                            list_llenado.Dock = DockStyle.Fill

''                        End If

''                    End If



''                Next
''            Else
''                Dim defaultV = DataSource.Tables(0).DefaultView
''                defaultV.RowFilter = swhere
''                Dim objDT = defaultV.ToTable()

''                With list_llenado
''                    .DataSource = Nothing
''                    .Items.Clear()
''                    .ValueMember = sidt
''                    .DisplayMember = sDescripciont
''                    .DataSource = objDT ' objDS.Tables(0)
''                End With
''                'list_llenado
''            End If


''            bPASA = True




''            If list_llenado.Items.Count = 1 Then
''                f.Height = 21 + 26
''                list_llenado.Height = list_llenado.Height + 5



''            ElseIf list_llenado.Items.Count = 2 Then
''                f.Height = 21 + 43
''                list_llenado.Height = list_llenado.Height * 2 + 5

''            ElseIf list_llenado.Items.Count = 3 Then
''                f.Height = 21 + 64
''                list_llenado.Height = list_llenado.Height * 3 + 5

''            ElseIf list_llenado.Items.Count = 4 Then
''                f.Height = 21 + 85
''                list_llenado.Height = list_llenado.Height * 4 + 5

''            Else
''                f.Height = 121
''                list_llenado.Height = list_llenado.Height * list_llenado.Items.Count + 5

''            End If

''            bPASA = False


''            If list_llenado.Items.Count = 0 Then
''                list_llenado.Visible = False
''                'Me.Height = Alto
''                TEXTO_GUARDADO = TextBox1.Text

''                SelectedIndex = -1

''                'RaiseEvent SelectedIndexChanged(Me, Nothing)
''                TextBox1.Text = TEXTO_GUARDADO
''                TEXTO_GUARDADO = Nothing
''                TextBox1.SelectAll()

''                f.Close()

''                Exit Sub
''            End If

''            If list_llenado.Items.Count = 1 Then

''                SelectedIndex = 0

''                list_llenado.Visible = False

''                f.Close()
''            Else


''                f.Controls.Add(list_llenado)
''                'f.ShowPopup(Me, DialogAlignment.Below)

''                'SelectedIndex = -1
''                list_llenado.Visible = True
''                'list_llenado.ClearSelected()


''            End If

''            'If TextBox1.Text = "" Then
''            '    list_llenado.SelectedIndex = -1

''            'End If

''            If TODOS <> True Then
''                TextBox1.Select(TextBox1.Text.Length, 0)
''                'RaiseEvent SelectedIndexChanged(Me, Nothing)
''            End If




''        Catch ex As NullReferenceException
''            MessageBox.Show("Error del combo " & Me.Name.ToString, "CombosaxV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
''        End Try
''    End Sub
''    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As Wisej.Web.KeyPressEventArgs) Handles TextBox1.KeyPress
''        If Asc(e.KeyChar) = Wisej.Web.Keys.Down Then

''            list_llenado.Focus()

''        ElseIf Asc(e.KeyChar) = Wisej.Web.Keys.Escape Then
''            list_llenado.Visible = False


''            f.Close()
''            TextBox1.SelectAll()
''            Exit Sub

''        ElseIf Asc(e.KeyChar) = Wisej.Web.Keys.Tab Then
''            list_llenado.Focus()
''            list_llenado.SelectedIndex = 0
''            'If bPASA > 0 And list_filtro.Visible = True Then
''            '    Parent.Height = bPASA
''            'End If
''        End If

''        'If TextBox1 <> "" Then
''        '    TextBox1_EnterKeyDown(Me, Nothing)
''        'End If



''    End Sub

''    'List LLenado Funciones 
''    Private Sub lista_KeyPress(ByVal sender As Object, ByVal e As Wisej.Web.KeyPressEventArgs) Handles list_llenado.KeyPress

''        Try
''            If Asc(e.KeyChar) = Wisej.Web.Keys.Enter Then


''                TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString
''                ToolTip1.SetToolTip(TextBox1, list_llenado.Text)
''                TextBox1.SelectAll()
''                'Me.FindForm.SelectNextControl(sender, True, False, True, True)
''                list_llenado.Visible = False
''                f.Close()

''                RaiseEvent SelectedIndexChanged(Me, e)
''                'SplitContainer1.SplitterDistance = SplitContainer1.Width - 50


''            ElseIf Asc(e.KeyChar) = Wisej.Web.Keys.Tab Then

''                TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString
''                ToolTip1.SetToolTip(TextBox1, list_llenado.Text)
''                TextBox1.SelectAll()

''                f.Close()

''                RaiseEvent SelectedIndexChanged(Me, e)
''                'SplitContainer1.SplitterDistance = SplitContainer1.Width - 50

''                'ElseIf Asc(e.KeyChar) = Wisej.Web.Keys.Up And list_llenado.SelectedIndex = 0 Then
''                '    If CONTADOR >= 2 Then
''                '        TextBox1.Focus()
''                '        CONTADOR = 0
''                '    ElseIf list_llenado.Items.Count = 1 Then
''                '        TextBox1.Focus()
''                '        CONTADOR = 0
''                '    End If
''                '    CONTADOR = CONTADOR + 1

''            ElseIf Asc(e.KeyChar) = Wisej.Web.Keys.Escape Then
''                list_llenado.Visible = False
''                f.Close()

''                TextBox1.SelectAll()

''                'ElseIf Asc(e.KeyChar) = Keys.Up Then
''                '    list_llenado.Visible = False
''                '    f.Close()

''                '    TextBox1.SelectAll()

''            ElseIf Asc(e.KeyChar) = Keys.Down Then

''                list_llenado.Select()

''            ElseIf Asc(e.KeyChar) = Keys.Control And Keys.A Then

''                list_llenado.Select()






''                'MiListView.Select()
''                'MiListView.Items(indice).Focused = True
''                'MiListView.EnsureVisible(indice)
''            End If
''        Catch ex As NullReferenceException

''        End Try

''    End Sub

''    Private Sub list_filtro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_llenado.Click


''        If list_llenado.SelectedIndex <> -1 Then

''            TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString
''            ToolTip1.SetToolTip(TextBox1, TextBox1.Text)
''            TextBox1.SelectAll()
''            list_llenado.Visible = False
''            SplitContainer1.SplitterDistance = SplitContainer1.Width - 50
''            f.Close()
''            RaiseEvent SelectedIndexChanged(Me, e)

''        End If


''    End Sub

''    'Funciones generales

''    Sub llenar_lis_nuevo(ByVal sId As String, ByVal sDescripcion As String, ByVal parametros As String, ByVal cConnect As String)
''        Try
''            sparametros = parametros
''            sidt = sId
''            sDescripciont = sDescripcion
''            bPASA = Me.Height
''            scConnect = cConnect
''            If LIMITAR_REGISTROS = False Then

''                Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(parametros, cConnect)
''                myDA.SelectCommand.CommandType = CommandType.Text
''                myDS = New DataSet
''                myDA.Fill(myDS, "SQLX")
''                defaultTabla = myDS.Tables(0)

''                With list_llenado
''                    .DataSource = Nothing
''                    .Items.Clear()
''                    .ValueMember = myDS.Tables(0).Columns(sId).ColumnName
''                    .DataSource = myDS.Tables(0)
''                    .DisplayMember = myDS.Tables(0).Columns(sDescripcion).ColumnName
''                    sidt = sId
''                    sDescripciont = sDescripcion
''                End With


''            End If

''            If list_llenado.Items.Count = 0 Then
''                If LIMITAR_REGISTROS = True Then
''                    TextBox1.Watermark = "Ingrese Por Lo Menos 3 Caracteres"
''                    Exit Sub
''                Else
''                    'TextBox1.Message = "Sin datos"
''                End If

''            End If
''            Dim max As Integer = 0
''            For Each row As DataRow In Me.DataSource.Tables(0).Rows



''                f.Width = Me.Width
''                If max < Len(row(sDescripcion).ToString) Then
''                    max = Len(row(sDescripcion).ToString)
''                    If max * 8 > Me.Width Then
''                        list_llenado.Width = max * 8
''                        list_llenado.Dock = DockStyle.None

''                        list_llenado.Top = 0
''                    Else

''                        list_llenado.Dock = DockStyle.Fill

''                    End If

''                End If



''            Next










''        Catch ex As NullReferenceException
''            Wisej.Web.MessageBox.Show("Columna Invalida " & Space(1) & sDescripcion & "o " & sId & " Del combo " & Me.Name.ToString, "CombosaxV5", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
''        End Try



''    End Sub

''    Public Sub RemoveItem(ByVal i As Integer)

''        If i <> -1 Then
''            list_llenado.Items.Remove(i)
''        End If
''    End Sub
''    Public Sub Clear(Optional cleanDS As Boolean = True) '() modificado Oscar :v
''        SelectedIndex = -1
''        RaiseEvent SelectedIndexChanged(Me, Nothing)
''        list_llenado.DataSource = Nothing

''        list_llenado.Items.Clear()
''        TextBox1.Text = Nothing
''        Num_Registros = 0
''        SplitContainer1.SplitterDistance = SplitContainer1.Width - 25
''        If cleanDS Then '() agregado Oscar :v
''            If (Me.myDS IsNot Nothing) Then
''                If (Me.myDS.Tables.Count > 0) Then
''                    If (Me.myDS.Tables(0) IsNot Nothing) Then
''                        Me.myDS.Tables(0).Clear()
''                    End If
''                End If
''            End If
''        End If
''    End Sub

''    Public Sub buscar_padres(ByVal Ccontrols As Object)

''        For Each Ccontrol In Ccontrols.Controls
''            Select Case UCase(TypeName(Ccontrol))
''                Case "COMBOSAX"
''                    Ccontrol.Restablecer()
''            End Select

''            If Ccontrol.HasChildren Then
''                buscar_padres(Ccontrol)
''            End If
''        Next


''    End Sub

''    'Boton Activar
''    Private Sub Activacion_Click(sender As Object, e As EventArgs) Handles BtnActivador.Click

''        f.Tag = True
''        TODOS = True
''        TextBox1_EnterKeyDown(1, Nothing)
''        If TextBox1.Text <> "" Then
''            Dim index As Integer = list_llenado.FindString(TextBox1.Text)
''            If index <> -1 Then
''                list_llenado.SetSelected(0, False)
''                list_llenado.SetSelected(index, True)
''            End If
''        End If
''        TODOS = False
''    End Sub

''    'Funciones Padres 
''    Private Sub combosax_Load(sender As Object, e As System.EventArgs) Handles Me.Load
''        f.Tag = False
''        list_llenado.Font = Me.Font
''        f.Controls.Add(list_llenado)

''        TextBox1.Font = Me.Font
''        ''list_llenado.Sorted = True
''        TextBox1.BackColor = Me.BackColor
''        list_llenado.BackColor = Me.BackColor
''        Me.MensajeAgua = TextBox1.Watermark
''        list_llenado.Enabled = Me.Enabled

''        TextBox1.Enabled = Me.Enabled

''        AddHandler f.FormClosed, AddressOf closed

''        'If Alto <> 0 Then
''        '    Me.Height = Alto
''        '    SplitContainer1.Height = Alto
''        'End If
''        'If vAncho <> 0 Then
''        '    f.Width = vAncho
''        'Else
''        '    f.Width = Me.Width
''        'End If


''        f.AutoScroll = True
''        SplitContainer1.SplitterDistance = SplitContainer1.Width - 25


''    End Sub

''    Sub closed()        'If Me.Form.WindowState = FormWindowState.Maximized Then
''        '    If CInt(Me.Location.X) + Me.Width + 3 > MousePosition.X And CInt(Me.Location.X) + Me.Width - 28 < MousePosition.X Then
''        '        f.Tag = True
''        '    Else
''        '        f.Tag = False
''        '    End If
''        'Else
''        '    If CInt(Me.Location.X) + CInt(Me.Form.Location.X) + Me.Width + 3 > MousePosition.X And CInt(Me.Location.X) + CInt(Me.Form.Location.X) + Me.Width - 28 < MousePosition.X Then
''        '        f.Tag = True
''        '    Else
''        '        f.Tag = False
''        '    End If
''        'End If


''    End Sub

''    Private Sub combosax_BackColorChanged(sender As Object, e As System.EventArgs) Handles Me.BackColorChanged
''        TextBox1.BackColor = Me.BackColor
''        list_llenado.BackColor = Me.BackColor
''    End Sub

''    Private Sub combosax_FontChanged(sender As Object, e As System.EventArgs) Handles Me.FontChanged
''        list_llenado.Font = Me.Font
''        TextBox1.Font = Me.Font
''    End Sub

''    Private Sub combosax_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged

''        list_llenado.Enabled = Me.Enabled

''        TextBox1.Enabled = Me.Enabled


''    End Sub

''    'Propiedades del Combosax

''    Public Property SelectedItem() As String
''        Get
''            If TextBox1.Text <> Nothing Then
''                SelectedItem = TextBox1.Text
''            Else
''                SelectedItem = ""
''            End If
''        End Get
''        Set(ByVal value As String)
''            Try
''                If value <> Nothing Then
''                    TextBox1.Text = value
''                    If LIMITAR_REGISTROS = True Then
''                        TextBox1_EnterKeyDown(1, Nothing)
''                    Else
''                        Dim index As Integer = list_llenado.FindString(TextBox1.Text)
''                        ' Determine if a valid index is returned. Select the item if it is valid. 
''                        If index <> -1 Then
''                            list_llenado.SetSelected(0, False)
''                            list_llenado.SetSelected(index, True)

''                        Else
''                            TextBox1.Text = ""

''                            list_llenado.SelectedIndex = -1

''                        End If
''                    End If



''                    ToolTip1.SetToolTip(TextBox1, value)
''                Else
''                    TextBox1.Text = ""
''                End If
''            Catch ex As Exception
''                If mostrar_Mensaje Then
''                    MessageBox.Show("Error Del combo " & Me.Name.ToString & " al querer asignar el valor " & value & " el cual no existe", "CombosaxV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
''                End If
''            End Try
''        End Set
''    End Property

''    Public Property procedure() As System.Data.DataTable
''        Get
''        End Get
''        Set(ByVal value As System.Data.DataTable)
''        End Set
''    End Property

''    Public Property DataSource() As System.Data.DataSet
''        Get
''            DataSource = myDS
''        End Get
''        Set(ByVal value As System.Data.DataSet)
''        End Set
''    End Property

''    Public Property Count() As Integer
''        Get
''            Count = list_llenado.Items.Count
''        End Get
''        Set(ByVal value As Integer)
''        End Set
''    End Property
''    Public Property mostrarMensaje() As Boolean
''        Get
''            mostrarMensaje = mostrar_Mensaje
''        End Get
''        Set(ByVal value As Boolean)
''            mostrar_Mensaje = value
''        End Set
''    End Property
''    Public Property SelectedValue() As String
''        Get

''            If TextBox1.Text <> Nothing Then
''                SelectedValue = list_llenado.SelectedValue
''            Else
''                SelectedValue = Nothing
''                list_llenado.SelectedIndex = -1
''            End If


''        End Get
''        Set(ByVal value As String)

''            Try
''                If value <> Nothing Then


''                    Dim i As Integer = 0
''                    Me.BringToFront()
''                    list_llenado.DataSource = Nothing
''                    list_llenado.Items.Clear()



''                    Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sparametros, scConnect)
''                    myDA.SelectCommand.CommandType = CommandType.Text
''                    myDS = New DataSet
''                    myDA.Fill(myDS, "SQLX")
''                    Dim defaultV = myDS.Tables(0).DefaultView
''                    'defaultV.RowFilter = swhere
''                    Dim objDT = defaultV.ToTable()

''                    With list_llenado
''                        .DataSource = Nothing
''                        .Items.Clear()
''                        .ValueMember = sidt
''                        .DataSource = objDT
''                        .DisplayMember = sDescripciont

''                    End With


''                    list_llenado.Visible = False
''                    'Me.Height = Alto



''                    ToolTip1.SetToolTip(TextBox1, value)

''                    list_llenado.SelectedValue = value

''                    TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString
''                    SplitContainer1.SplitterDistance = SplitContainer1.Width - 50

''                End If


''                RaiseEvent SelectedIndexChanged(Me, Nothing)

''            Catch ex As Exception
''                If mostrar_Mensaje Then
''                    MessageBox.Show("Error Del combo " & Me.Name.ToString & " al querer asignar el valor " & value & " el cual no existe", "CombosaxV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
''                    SplitContainer1.SplitterDistance = SplitContainer1.Width - 25
''                    SelectedIndex = -1
''                End If
''            End Try
''        End Set
''    End Property

''    <System.ComponentModel.Description("Esta función limita la búsqueda  a 3 caracteres para evitar la carga a la base de datos")>
''    Public Property Limitar() As Boolean
''        Get

''            Limitar = LIMITAR_REGISTROS


''        End Get
''        Set(ByVal value As Boolean)

''            LIMITAR_REGISTROS = value

''        End Set
''    End Property

''    Public Property SelectedIndex() As Integer
''        Get
''            Dim I As Integer = -1
''            If TextBox1.Text = Nothing Then

''                SplitContainer1.SplitterDistance = SplitContainer1.Width - 25
''            Else


''                'Dim index As Integer = list_llenado.FindString(TextBox1.Text)
''                'If index <> Nothing Then
''                '    SelectedIndex = index
''                '    I = index
''                '    SplitContainer1.SplitterDistance = SplitContainer1.Width - 50
''                'Else

''                'End If
''                If list_llenado.SelectedIndex <> -1 Then
''                    I = list_llenado.SelectedIndex
''                    SplitContainer1.SplitterDistance = SplitContainer1.Width - 50
''                End If


''            End If
''            SelectedIndex = I

''        End Get


''        Set(ByVal value As Integer)
''            Try



''                If value <> -1 Then

''                    list_llenado.SelectedIndex = value
''                    TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString
''                    ToolTip1.SetToolTip(TextBox1, TextBox1.Text)
''                    SplitContainer1.SplitterDistance = SplitContainer1.Width - 50
''                    value = -1
''                Else
''                    'Me.Height = Alto
''                    TextBox1.Text = Nothing
''                    ToolTip1.SetToolTip(TextBox1, "")
''                    list_llenado.SelectedIndex = -1
''                    SplitContainer1.SplitterDistance = SplitContainer1.Width - 25
''                    '        list_filtro.Visible = False
''                    '        INDEX = -1
''                    If list_llenado.Items.Count > 0 Then

''                        list_llenado.Visible = False
''                        f.Close()
''                        'Me.Height = Alto
''                        'If bPASA > 0 Then
''                        '    Parent.Height = bPASA
''                        'End If
''                    End If
''                End If




''                RaiseEvent SelectedIndexChanged(Me, Nothing)
''            Catch ex As Exception
''                If mostrar_Mensaje Then
''                    MessageBox.Show("Error Del combo " & Me.Name.ToString & " al querer asignar el valor " & value & " el cual no existe", "CombosaxV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
''                    SplitContainer1.SplitterDistance = SplitContainer1.Width - 25
''                End If
''            End Try

''        End Set
''    End Property

''    'Funciones basuras

''    Public Property Negritas As Boolean
''        Get
''        End Get
''        Set(ByVal value As Boolean)

''        End Set
''    End Property

''    Public Property amarillo() As Boolean
''        Get
''        End Get
''        Set(ByVal value As Boolean)

''        End Set
''    End Property

''    Public Property gris() As Boolean
''        Get
''        End Get
''        Set(ByVal value As Boolean)

''        End Set
''    End Property

''    Public Property ColorAtras As System.Drawing.Color
''        Get
''        End Get
''        Set(ByVal value As System.Drawing.Color)
''        End Set
''    End Property

''    Public Property Letra As System.Drawing.Font
''        Get
''        End Get
''        Set(ByVal value As System.Drawing.Font)
''        End Set
''    End Property

''    Public Property TODOSS() As Boolean
''        Get
''            'TODOSS = TODOS
''        End Get
''        Set(ByVal value As Boolean)
''            'TODOS = value
''        End Set
''    End Property


''    Public Property MensajeAgua() As String
''        Get
''            Return TextBox1.Watermark
''        End Get
''        Set(ByVal value As String)
''            TextBox1.Watermark = value
''        End Set
''    End Property

''    Public Property Ancho() As String
''        Get
''            Return f.Width
''        End Get
''        Set(ByVal value As String)
''            vAncho = value
''            f.Width = vAncho
''        End Set
''    End Property
''    Private Sub list_llenado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_llenado.SelectedIndexChanged
''        ToolTip1.SetToolTip(PictureBox1, list_llenado.Text)
''    End Sub
''    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
''        Clear(False) ' mod Oscar
''    End Sub

''    'Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
''    '    Dim I As ToolStripItem = e.ClickedItem
''    '    If I.Text = "Actualizar" Then
''    '        If sparametros Is Nothing Then
''    '            Exit Sub
''    '        End If
''    '        If LIMITAR_REGISTROS = False Then

''    '            Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sparametros, scConnect)
''    '            myDA.SelectCommand.CommandType = CommandType.Text
''    '            myDS = New DataSet
''    '            myDA.Fill(myDS, "SQLX")


''    '            With list_llenado
''    '                .DataSource = Nothing
''    '                .Items.Clear()
''    '                .ValueMember = myDS.Tables(0).Columns(sidt).ColumnName
''    '                .DataSource = myDS.Tables(0)
''    '                .DisplayMember = myDS.Tables(0).Columns(sDescripciont).ColumnName

''    '                sDescripciont = sDescripciont
''    '            End With



''    '            If list_llenado.Items.Count = 0 Then
''    '                If LIMITAR_REGISTROS = True Then
''    '                    TextBox1.Watermark = "Ingrese Por Lo Menos 3 Caracteres"
''    '                Else
''    '                    'TextBox1.Message = "Sin datos"
''    '                End If

''    '            End If

''    '            f.Width = Me.Width



''    '            If list_llenado.Items.Count = 1 Then
''    '                f.Height = 21 + 26
''    '                list_llenado.Height = list_llenado.Height + 5



''    '            ElseIf list_llenado.Items.Count = 2 Then
''    '                f.Height = 21 + 43
''    '                list_llenado.Height = list_llenado.Height * 2 + 5

''    '            ElseIf list_llenado.Items.Count = 3 Then
''    '                f.Height = 21 + 64
''    '                list_llenado.Height = list_llenado.Height * 3 + 5

''    '            ElseIf list_llenado.Items.Count = 4 Then
''    '                f.Height = 21 + 85
''    '                list_llenado.Height = list_llenado.Height * 4 + 5

''    '            Else
''    '                f.Height = 121
''    '                list_llenado.Height = list_llenado.Height * list_llenado.Items.Count + 5
''    '                'Panel1.Width = list_llenado.Width
''    '                'SplitContainer2.Panel2.Width = 20000

''    '                'list_llenado.Dock = DockStyle.None


''    '            End If

''    '        End If
''    '    ElseIf I.Text = "Consulta" Then





''    '        'ElseIf I.Text = "Pegar" Then
''    '        '    Dim iData As IDataObject = Clipboard.GetDataObject()
''    '        '    'Check to see if the data is in a text format
''    '        '    If iData.GetDataPresent(DataFormats.Text) Then
''    '        '        'If it's text, then paste it into the textbox
''    '        '        TextBox1.SelectedText = CType(iData.GetData(DataFormats.Text), String)
''    '        '    Else
''    '        '        'If it's not text, print a warning message
''    '        '        MsgBox("Data in the clipboard is not availble for entry into a textbox")
''    '        '    End If


''    '    End If
''    'End Sub
''    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
''        If SelectedIndex = -1 Then
''            TextBox1.Clear()
''        End If
''    End Sub
''    ''Oscar
''    Public Sub filtrarCombo(where As String, Optional concatenarFiltros As Boolean = True)
''        Dim dv As DataView = Nothing
''        If concatenarFiltros Then
''            dv = myDS.Tables(0).DefaultView
''        Else
''            dv = defaultTabla.DefaultView
''        End If
''        dv.RowFilter = where
''        Dim ndt As DataTable = dv.ToTable()
''        myDS.Tables.RemoveAt(0)
''        myDS.Tables.Add(ndt)
''        With list_llenado
''            .DataSource = Nothing
''            .Items.Clear()
''            .ValueMember = myDS.Tables(0).Columns(sidt).ColumnName
''            .DataSource = myDS.Tables(0)
''            .DisplayMember = myDS.Tables(0).Columns(sDescripciont).ColumnName
''        End With

''    End Sub
''    Public Sub limpiarFiltro()
''        myDS.Tables.RemoveAt(0)
''        myDS.Tables.Add(defaultTabla)
''        With list_llenado
''            .DataSource = Nothing
''            .Items.Clear()
''            .ValueMember = myDS.Tables(0).Columns(sidt).ColumnName
''            .DataSource = myDS.Tables(0)
''            .DisplayMember = myDS.Tables(0).Columns(sDescripciont).ColumnName
''        End With

''    End Sub
''    Private Sub combosax_Click(sender As Object, e As EventArgs) Handles MyBase.Click
''        Me.Focus()
''    End Sub
''    'Private Sub Tprespuesta_Click(sender As Object, e As EventArgs) Handles Tprespuesta.Click
''    '    If "ADMIN" = Application.Session("Cve_Operador") Then
''    '        Tprespuesta.Text = sparametros
''    '        Dim script As String = " document.getElementById('TRG_" & Application.Session("PageContextID") & "').contentWindow.copyToClipboard('HGHDFGDFG' ) "
''    '        InvokeScript(script)
''    '        Tprespuesta.SelectAll()
''    '    End If

''    'End Sub



''End Class



Imports Wisej.Web
Imports System.Globalization
Imports System.Windows.Forms

Public Class combosax

    Dim sparametros As String
    Dim scConnect As String
    Dim Alto As Double
    Dim TEXTO_GUARDADO As String
    Dim sidt As String
    Dim sDescripciont As String
    Dim myDS As DataSet
    Dim AltoOriginalPadre As Integer = False
    Dim bPASA As Boolean = False
    Dim CONTADOR As Integer = 1
    Dim TODOS As Boolean = False
    Dim LIMITAR_REGISTROS As Boolean = False
    'Dim LocationVar As Point3
    Dim f As New Wisej.Web.Form
    Dim vAncho As Integer

    Dim Num_Registros As Integer = 0

    Public Event SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public Event KeyPress(ByVal sender As Object, ByVal e As Wisej.Web.KeyPressEventArgs)

    Public Version As String = "10 BETA 1"


    Private Sub TextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.DoubleClick
        TextBox1.SelectAll()
    End Sub

    Public Sub TextBox1_EnterKeyDown(ByVal objSender As Object, ByVal objArgs As Wisej.Web.KeyEventArgs) Handles TextBox1.KeyDown

        Try
            'objArgs.KeyValue = 'ENTER'


            If sparametros Is Nothing Then

                Exit Sub

            End If

            list_llenado.DataSource = Nothing
            list_llenado.Items.Clear()

            If LIMITAR_REGISTROS = True Then
                TODOS = False
                If Trim(TextBox1.Text).Length <= 2 Then

                    f.Close()
                    TextBox1.Watermark = "Ingrese Por Lo Menos 3 Caracteres"
                    Exit Sub
                End If
            End If

            Dim swhere As String
            If TODOS <> True Then
                If TextBox1.Text <> Nothing Then
                    swhere = sDescripciont & "  like '%" & CStr(TextBox1.Text) & "%'"
                End If
            End If

            If LIMITAR_REGISTROS = True Then
                Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sparametros, scConnect)
                myDA.SelectCommand.CommandType = CommandType.Text
                myDS = New DataSet
                myDA.Fill(myDS, "SQLX")
                Dim defaultV = myDS.Tables(0).DefaultView
                defaultV.RowFilter = swhere
                Dim objDT = defaultV.ToTable()

                With list_llenado
                    .ValueMember = sidt
                    .DataSource = objDT
                    .DisplayMember = sDescripciont

                End With
            Else
                Try
                    Dim defaultV = DataSource.Tables(0).DefaultView
                    defaultV.RowFilter = swhere
                    Dim objDT = defaultV.ToTable()

                    With list_llenado
                        .ValueMember = sidt
                        .DisplayMember = sDescripciont
                        .DataSource = objDT ' objDS.Tables(0)
                    End With
                    'list_llenado
                Catch ex As Exception
                    Wisej.Web.MessageBox.Show("Caracter No Valido", "CombosaxV5", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
                End Try
            End If


            bPASA = True




            If list_llenado.Items.Count = 1 Then
                f.Height = 21 + 26
                list_llenado.Height = list_llenado.Height + 5



            ElseIf list_llenado.Items.Count = 2 Then
                f.Height = 21 + 43
                list_llenado.Height = list_llenado.Height * 2 + 5

            ElseIf list_llenado.Items.Count = 3 Then
                f.Height = 21 + 64
                list_llenado.Height = list_llenado.Height * 3 + 5

            ElseIf list_llenado.Items.Count = 4 Then
                f.Height = 21 + 85
                list_llenado.Height = list_llenado.Height * 4 + 5

            Else
                f.Height = 121
                list_llenado.Height = list_llenado.Height * list_llenado.Items.Count + 5

            End If

            bPASA = False


            If list_llenado.Items.Count = 0 Then


                TEXTO_GUARDADO = TextBox1.Text

                SelectedIndex = -1

                RaiseEvent SelectedIndexChanged(Me, Nothing)
                TextBox1.Text = TEXTO_GUARDADO
                TEXTO_GUARDADO = Nothing
                TextBox1.SelectAll()

                f.Close()

                Exit Sub
            End If

            If list_llenado.Items.Count = 1 Then

                SelectedIndex = 0



                f.Close()
            Else


                f.Show()
                list_llenado.ClearSelected()
                RaiseEvent SelectedIndexChanged(Me, Nothing)

            End If

            If TextBox1.Text = "" Then
                list_llenado.SelectedIndex = -1
            Else
                Dim index As Integer = list_llenado.FindString(TextBox1.Text)
                ' Determine if a valid index is returned. Select the item if it is valid. 
                If index <> -1 Then
                    SplitContainer1.SplitterDistance = SplitContainer1.Width - 50


                    list_llenado.SetSelected(0, False)
                    list_llenado.SetSelected(index, True)
                End If
            End If
            TextBox1.Select(TextBox1.Text.Length, 0)



        Catch ex As NullReferenceException
            Wisej.Web.MessageBox.Show("Error del combo " & Me.Name.ToString, "CombosaxV5", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try
    End Sub



    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As Wisej.Web.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Wisej.Web.Keys.Down Then

            'If Num_Registros >= 3000 Then
            '    If list_llenado.Visible = True Then
            '        list_llenado.SelectedIndex = 0
            '        list_llenado.Focus()
            '    End If
            'Else
            '    If list_llenado.Visible <> True Then
            '        TODOS = True
            '        TextBox1_EnterKeyDown(1, Nothing)
            '        TODOS = False
            '    End If
            'Me.FindForm.SelectNextControl(sender, True, False, True, True)

            list_llenado.Focus()


            'End If
            'Panel1.Focus()

        ElseIf Asc(e.KeyChar) = wisej.web.Keys.Escape Then

            f.Close()
            TextBox1.SelectAll()
            Exit Sub

        ElseIf Asc(e.KeyChar) = wisej.web.Keys.Tab Then
            list_llenado.Focus()
            list_llenado.SelectedIndex = 0
            'If bPASA > 0 And list_filtro.Visible = True Then
            '    Parent.Height = bPASA
            'End If
        End If

        'If TextBox1 <> "" Then
        '    TextBox1_EnterKeyDown(Me, Nothing)
        'End If



    End Sub

    'List LLenado Funciones 

    Private Sub lista_KeyPress(ByVal sender As Object, ByVal e As Wisej.Web.KeyPressEventArgs) Handles list_llenado.KeyPress
        Try
            If Asc(e.KeyChar) = Wisej.Web.Keys.Enter Then


                TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString
                ToolTip1.SetToolTip(TextBox1, list_llenado.Text)
                TextBox1.SelectAll()
                Me.FindForm.SelectNextControl(sender, True, False, True, True)

                f.Close()

                RaiseEvent SelectedIndexChanged(Me, e)
                SplitContainer1.SplitterDistance = SplitContainer1.Width - 50


            ElseIf Asc(e.KeyChar) = wisej.web.Keys.Tab Then

                TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString
                ToolTip1.SetToolTip(TextBox1, list_llenado.Text)
                TextBox1.SelectAll()

                f.Close()

                RaiseEvent SelectedIndexChanged(Me, e)
                SplitContainer1.SplitterDistance = SplitContainer1.Width - 50

                'ElseIf Asc(e.KeyChar) = Keys.Up And list_llenado.SelectedIndex = 0 Then
                '    If CONTADOR >= 2 Then
                '        TextBox1.Focus()
                '        CONTADOR = 0
                '    ElseIf list_llenado.Items.Count = 1 Then
                '        TextBox1.Focus()
                '        CONTADOR = 0
                '    End If
                '    CONTADOR = CONTADOR + 1

            ElseIf Asc(e.KeyChar) = wisej.web.Keys.Escape Then

                f.Close()

                TextBox1.SelectAll()

            ElseIf Asc(e.KeyChar) = wisej.web.Keys.Down Then

                list_llenado.Select()




                'MiListView.Select()
                'MiListView.Items(indice).Focused = True
                'MiListView.EnsureVisible(indice)
            End If
        Catch ex As NullReferenceException

        End Try

    End Sub

    Private Sub list_filtro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_llenado.Click


        If list_llenado.SelectedIndex <> -1 Then

            TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString
            ToolTip1.SetToolTip(TextBox1, TextBox1.Text)
            TextBox1.SelectAll()


            f.Close()
            RaiseEvent SelectedIndexChanged(Me, e)
            If list_llenado.SelectedIndex <> -1 Then
                SplitContainer1.SplitterDistance = SplitContainer1.Width - 50
            Else
                SplitContainer1.SplitterDistance = SplitContainer1.Width - 25
            End If


        End If


    End Sub

    'Funciones generales

    Sub llenar_lis_nuevo(ByVal sId As String, ByVal sDescripcion As String, ByVal parametros As String, ByVal cConnect As String)
        Try
            sparametros = parametros
            sidt = sId
            sDescripciont = sDescripcion
            bPASA = Me.Height
            scConnect = cConnect
            If LIMITAR_REGISTROS = False Then

                Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(parametros, cConnect)
                myDA.SelectCommand.CommandType = CommandType.Text
                myDS = New DataSet
                myDA.Fill(myDS, "SQLX")


                With list_llenado
                    .DataSource = Nothing
                    .Items.Clear()
                    .ValueMember = myDS.Tables(0).Columns(sId).ColumnName
                    .DataSource = myDS.Tables(0)
                    .DisplayMember = myDS.Tables(0).Columns(sDescripcion).ColumnName
                    sidt = sId
                    sDescripciont = sDescripcion
                End With


                'Dim max As Integer = 0
                'For Each row As DataRow In Me.DataSource.Tables(0).Rows

                list_llenado.Dock = Wisej.Web.DockStyle.Fill

                f.Width = Me.Width
                '    If max <Len(row(sDescripcion).ToString) Then
                '        max = Len(row(sDescripcion).ToString)
                '        If max * 8 > Me.Width Then
                '            list_llenado.Width = max * 8
                '            list_llenado.Dock = DockStyle.None

                '            list_llenado.Top = 0
                '        End If
                '    End If



                'Next

            Else


                TextBox1.Watermark = "Ingrese Por Lo Menos 3 Caracteres"
                f.Width = Me.Width
                list_llenado.Dock = Wisej.Web.DockStyle.Fill

            End If















        Catch ex As NullReferenceException
            Wisej.Web.MessageBox.Show("Columna Invalida " & Space(1) & sDescripcion & "o " & sId & " Del combo " & Me.Name.ToString, "CombosaxV5", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try



    End Sub

    Public Sub RemoveItem(ByVal i As Integer)

        If i <> -1 Then
            list_llenado.Items.Remove(i)
        End If
    End Sub

    Public Sub Clear()
        list_llenado.DataSource = Nothing

        list_llenado.Items.Clear()


        SelectedIndex = -1

        TextBox1.Text = Nothing
        Num_Registros = 0
        'SplitContainer1.SplitterDistance = SplitContainer1.Width - 25
    End Sub



    Public Sub buscar_padres(ByVal Ccontrols As Object)

        For Each Ccontrol In Ccontrols.Controls
            Select Case UCase(TypeName(Ccontrol))
                Case "COMBOSAX"
                    Ccontrol.Restablecer()
            End Select

            If Ccontrol.HasChildren Then
                buscar_padres(Ccontrol)
            End If
        Next


    End Sub

    'Boton Activar


    Private Sub Activacion_Click(sender As Object, e As EventArgs) Handles BtnActivador.Click
        If f.Tag = True Then
            f.Tag = False
            Exit Sub
        End If
        f.Tag = True
        TODOS = True
        TextBox1_EnterKeyDown(1, Nothing)
        If TextBox1.Text <> "" Then
            Dim index As Integer = list_llenado.FindString(TextBox1.Text)
            If index <> -1 Then
                list_llenado.SetSelected(0, False)
                list_llenado.SetSelected(index, True)
            End If
        End If
        TODOS = False
    End Sub





    'Funciones Padres 
    Private Sub combosax_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        f.Tag = False
        list_llenado.Font = Me.Font
        f.Controls.Add(list_llenado)

        TextBox1.Font = Me.Font
        ''list_llenado.Sorted = True
        TextBox1.BackColor = Me.BackColor
        list_llenado.BackColor = Me.BackColor
        Me.MensajeAgua = TextBox1.Watermark
        list_llenado.Enabled = Me.Enabled

        TextBox1.Enabled = Me.Enabled

        AddHandler f.FormClosed, AddressOf closed

        'If Alto <> 0 Then
        '    Me.Height = Alto
        '    SplitContainer1.Height = Alto
        'End If
        'If vAncho <> 0 Then
        '    f.Width = vAncho
        'Else
        '    f.Width = Me.Width
        'End If

        If list_llenado.SelectedIndex <> -1 Then
            SplitContainer1.SplitterDistance = SplitContainer1.Width - 50
        Else
            SplitContainer1.SplitterDistance = SplitContainer1.Width - 25
        End If
        f.AutoScroll = True



    End Sub

    Sub closed()
        'If Me.Form.WindowState = FormWindowState.Maximized Then
        '    If MousePosition.X > CInt(Me.Location.X) + Me.Width + 3 And MousePosition.X < CInt(Me.Location.X) + Me.Width - 28 Then
        '        f.Tag = True
        '    Else
        '        f.Tag = False
        '    End If
        'Else
        If CInt(Me.Location.X) + CInt(Me.Location.X) + Me.Width + 23 > MousePosition.X And CInt(Me.Location.X) + CInt(Me.Location.X) + Me.Width - 48 < MousePosition.X Then
            f.Tag = True
        Else
            f.Tag = False
        End If
        'End If
        f.Tag = True


    End Sub

    Private Sub combosax_BackColorChanged(sender As Object, e As System.EventArgs) Handles Me.BackColorChanged
        TextBox1.BackColor = Me.BackColor
        list_llenado.BackColor = Me.BackColor
    End Sub

    Private Sub combosax_FontChanged(sender As Object, e As System.EventArgs) Handles Me.FontChanged
        list_llenado.Font = Me.Font
        TextBox1.Font = Me.Font
    End Sub

    Private Sub combosax_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged

        list_llenado.Enabled = Me.Enabled

        TextBox1.Enabled = Me.Enabled


    End Sub

    'Propiedades del Combosax

    Public Property SelectedItem() As String
        Get
            If TextBox1.Text <> Nothing Then
                SelectedItem = TextBox1.Text
            Else
                SelectedItem = ""
            End If
        End Get
        Set(ByVal value As String)
            If value <> Nothing Then
                TextBox1.Text = value
                SplitContainer1.SplitterDistance = SplitContainer1.Width - 50
                If LIMITAR_REGISTROS = True Then
                    TextBox1_EnterKeyDown(1, Nothing)
                Else
                    Dim index As Integer = list_llenado.FindString(TextBox1.Text)
                    ' Determine if a valid index is returned. Select the item if it is valid. 
                    If index <> -1 Then
                        list_llenado.SetSelected(0, False)
                        list_llenado.SetSelected(index, True)

                    Else
                        TextBox1.Text = ""

                        list_llenado.SelectedIndex = -1

                    End If
                End If



                ToolTip1.SetToolTip(TextBox1, value)
            Else
                TextBox1.Text = ""
                SplitContainer1.SplitterDistance = SplitContainer1.Width - 25
            End If
        End Set
    End Property
    Public Property SelectedIndex() As Integer
        Get
            Dim I As Integer
            If TextBox1.Text = Nothing Then
                I = -1
            Else
                I = list_llenado.SelectedIndex
                'If I = -1 Then
                '    Dim index As Integer = list_llenado.FindString(TextBox1.Text)
                '    ' Determine if a valid index is returned. Select the item if it is valid. 
                '    If index <> -1 Then
                '        list_llenado.SetSelected(0, False)
                '        list_llenado.SetSelected(index, True)
                '        RaiseEvent SelectedIndexChanged(Me, Nothing)
                '        I = index

                '    End If
                'End If

            End If
            SelectedIndex = I

        End Get


        Set(ByVal value As Integer)
            If value <> -1 Then

                list_llenado.SelectedIndex = value
                TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString
                ToolTip1.SetToolTip(TextBox1, TextBox1.Text)
                SplitContainer1.SplitterDistance = SplitContainer1.Width - 50

            Else
                'Me.Height = Alto
                SplitContainer1.SplitterDistance = SplitContainer1.Width - 25
                TextBox1.Text = Nothing
                ToolTip1.SetToolTip(TextBox1, "")
                list_llenado.SelectedIndex = -1
                '        list_filtro.Visible = False
                '        INDEX = -1
                If list_llenado.Items.Count > 0 Then


                    f.Close()
                    'Me.Height = Alto
                    'If bPASA > 0 Then
                    '    Parent.Height = bPASA
                    'End If
                End If
            End If


            RaiseEvent SelectedIndexChanged(Me, Nothing)


        End Set
    End Property
    Public Property SelectedValue() As String
        Get

            If TextBox1.Text <> Nothing Then
                SelectedValue = list_llenado.SelectedValue
            Else
                SelectedValue = Nothing
                list_llenado.SelectedIndex = -1
            End If


        End Get
        Set(ByVal value As String)

            Try





                If value <> Nothing Then

                    If LIMITAR_REGISTROS Then
                        Dim sPARAMETRO As String
                        sPARAMETRO = sparametros & " ,@" & sidt & "='" & value & "'"

                        Dim i As Integer = 0
                        Me.BringToFront()
                        list_llenado.DataSource = Nothing
                        list_llenado.Items.Clear()



                        Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sPARAMETRO, scConnect)
                        myDA.SelectCommand.CommandType = CommandType.Text
                        myDS = New DataSet
                        myDA.Fill(myDS, "SQLX")
                        Dim defaultV = myDS.Tables(0).DefaultView
                        'defaultV.RowFilter = swhere
                        Dim objDT = defaultV.ToTable()

                        With list_llenado
                            .DataSource = Nothing
                            .Items.Clear()
                            .ValueMember = sidt
                            .DataSource = objDT
                            .DisplayMember = sDescripciont

                        End With






                        ToolTip1.SetToolTip(TextBox1, value)

                        list_llenado.SelectedValue = value
                        TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString

                    Else


                        Dim i As Integer = 0
                        Me.BringToFront()
                        list_llenado.DataSource = Nothing
                        list_llenado.Items.Clear()



                        Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sparametros, scConnect)
                        myDA.SelectCommand.CommandType = CommandType.Text
                        myDS = New DataSet
                        myDA.Fill(myDS, "SQLX")
                        Dim defaultV = myDS.Tables(0).DefaultView
                        'defaultV.RowFilter = swhere
                        Dim objDT = defaultV.ToTable()

                        With list_llenado
                            .DataSource = Nothing
                            .Items.Clear()
                            .ValueMember = sidt
                            .DataSource = objDT
                            .DisplayMember = sDescripciont

                        End With





                        ToolTip1.SetToolTip(TextBox1, value)

                        list_llenado.SelectedValue = value
                        TextBox1.Text = list_llenado.SelectedItem.Row.Item(sDescripciont).ToString
                    End If

                End If


                RaiseEvent SelectedIndexChanged(Me, Nothing)

            Catch ex As NullReferenceException
                Wisej.Web.MessageBox.Show("Error Del combo " & Me.Name.ToString & " al querer asignar el valor " & value & " el cual no existe", "CombosaxV5", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            End Try
        End Set
    End Property
    Public Property procedure() As System.Data.DataTable
        Get
        End Get
        Set(ByVal value As System.Data.DataTable)
        End Set
    End Property

    Public Property DataSource() As System.Data.DataSet
        Get
            DataSource = myDS
        End Get
        Set(ByVal value As System.Data.DataSet)
        End Set
    End Property

    Public Property Count() As Integer
        Get
            Count = list_llenado.Items.Count
        End Get
        Set(ByVal value As Integer)
        End Set
    End Property



    <System.ComponentModel.Description("Esta función limita la búsqueda  a 3 caracteres para evitar la carga a la base de datos")>
    Public Property Limitar() As Boolean
        Get

            Limitar = LIMITAR_REGISTROS


        End Get
        Set(ByVal value As Boolean)

            LIMITAR_REGISTROS = value

        End Set
    End Property



    'Funciones basuras

    Public Property Negritas As Boolean
        Get
        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property amarillo() As Boolean
        Get
        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property gris() As Boolean
        Get
        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property ColorAtras As System.Drawing.Color
        Get
        End Get
        Set(ByVal value As System.Drawing.Color)
        End Set
    End Property

    Public Property Letra As System.Drawing.Font
        Get
        End Get
        Set(ByVal value As System.Drawing.Font)
        End Set
    End Property

    Public Property TODOSS() As Boolean
        Get
            'TODOSS = TODOS
        End Get
        Set(ByVal value As Boolean)
            'TODOS = value
        End Set
    End Property


    Public Property MensajeAgua() As String
        Get
            Return TextBox1.Watermark
        End Get
        Set(ByVal value As String)
            TextBox1.Watermark = value
        End Set
    End Property

    Public Property Ancho() As String
        Get
            Return f.Width
        End Get
        Set(ByVal value As String)
            vAncho = value
            f.Width = vAncho
        End Set
    End Property


    'Private Sub list_llenado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_llenado.SelectedIndexChanged
    '    'ToolTip1.SetToolTip(PictureBox1, list_llenado.Text)
    'End Sub





    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        'buscar_padres(Me.ParentForm)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Clear()
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Dim I As ToolStripItem = e.ClickedItem
        If I.Text = "Actualizar" Then

            If LIMITAR_REGISTROS = False Then

                Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sparametros, scConnect)
                myDA.SelectCommand.CommandType = CommandType.Text
                myDS = New DataSet
                myDA.Fill(myDS, "SQLX")


                With list_llenado
                    .DataSource = Nothing
                    .Items.Clear()
                    .ValueMember = myDS.Tables(0).Columns(sidt).ColumnName
                    .DataSource = myDS.Tables(0)
                    .DisplayMember = myDS.Tables(0).Columns(sDescripciont).ColumnName

                    sDescripciont = sDescripciont
                End With


            End If

            If list_llenado.Items.Count = 0 Then
                If LIMITAR_REGISTROS = True Then
                    TextBox1.Watermark = "Ingrese Por Lo Menos 3 Caracteres"
                Else
                    'TextBox1.Message = "Sin datos"
                End If

            End If





        End If
    End Sub



    Private Sub combosax_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'If bPASA = False Then
        '    Alto = sender.Height
        'End If

    End Sub
End Class


