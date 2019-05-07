Imports System.Data
Imports System.Drawing
Imports Wisej.Web
Imports Wisej.Web.Form

Public Class filtroGrillaSax
    Private I_EXCEPTIONS As Boolean = False
    Private I_TOOLTIP As New ToolTip
    Private I_TABLA_EXPRESIONES As DataTable = Nothing
    Private I_ETIQUETAS_BACKCOLOR As Color = Color.AliceBlue
    'Private I_ETIQUETAS_BORDERCOLOR As BorderColor = Color.LightSteelBlue
    Private I_ETIQUETAS_BORDERSTYLE As BorderStyle = BorderStyle.Solid
    Private I_ETIQUETAS_PADDING As Padding = New Padding(2)
    Private I_ETIQUETAS_MARGIN As Padding = New Padding(1)
    Private I_ETIQUETAS_BORDERWIDTH As Integer = 1
    Private I_FILTRAR_VACIOS As Boolean = False
    '
    Private I_TABLA As DataTable = Nothing
    Private I_DATAGRIDVIEW As Wisej.Web.DataGridView = Nothing
    Private I_BINDING_NAVIGATOR As Wisej.Web.BindingNavigator() = Nothing
    Private I_FRM_PARENT As Form = Nothing
    Private I_COUNT_BINDINGS As Integer = 0
    '
    Private sProcedureName, sWhere_Pub As String

    Private Sub filtroGrillaSax_Load(sender As Object, e As EventArgs) Handles Me.Load
        crearExpresiones()
        cmbExpresion.SelectedIndex = 0
        dtpFecha.Value = Now
        I_TOOLTIP.SetToolTip(cmbBuscar, "Columna a filtrar")
        I_TOOLTIP.SetToolTip(txtFiltros, "Valor para filtrar")
        I_TOOLTIP.SetToolTip(btnBuscar, "Filtrar")
        I_TOOLTIP.SetToolTip(btnLimpiar, "Quitar todos los filtros")

    End Sub

#Region "propiedades"
    Public ReadOnly Property mePanelFiltros() As Panel
        Get
            Return Me.panelFiltros
        End Get
    End Property
    Public ReadOnly Property mePanelEtiquetas() As FlowLayoutPanel
        Get
            Return Me.panelEtiquetas
        End Get
    End Property
    Public ReadOnly Property meLabelColumna() As Label
        Get
            Return Me.lblBuscar
        End Get
    End Property
    'Public ReadOnly Property meLabelValor() As Label
    '    Get
    '        Return Me.lblFiltro
    '    End Get
    'End Property
    Public ReadOnly Property meBotonBuscar() As Button
        Get
            Return Me.btnBuscar
        End Get
    End Property
    Public ReadOnly Property meBotonLimpiar() As Button
        Get
            Return Me.btnLimpiar
        End Get
    End Property
    Public ReadOnly Property meComboColumnas() As ComboBox
        Get
            Return Me.cmbBuscar
        End Get
    End Property
    Public ReadOnly Property meTextBoxFiltro() As TextBox
        Get
            Return Me.txtFiltros
        End Get
    End Property

    Public Property meDatagrid() As Wisej.Web.DataGridView
        Get
            Return I_DATAGRIDVIEW
        End Get
        Set(grid As Wisej.Web.DataGridView)
            quitarFiltros()
            ReDim I_BINDING_NAVIGATOR(-1) : I_COUNT_BINDINGS = 0
            I_DATAGRIDVIEW = grid
            Try
                If I_DATAGRIDVIEW IsNot Nothing Then
                    I_FRM_PARENT = grid.FindForm()
                    Dim binding As BindingSource = TryCast(Me.I_DATAGRIDVIEW.DataSource, BindingSource)
                    If binding IsNot Nothing Then
                        I_TABLA = binding.DataSource.Tables(0)
                    Else

                        If Me.I_DATAGRIDVIEW.DataSource IsNot Nothing Then
                            If Me.I_DATAGRIDVIEW.DataSource.GetType.ToString = "System.Data.DataView" Then
                                I_TABLA = TryCast(Me.I_DATAGRIDVIEW.DataSource, DataView).Table
                            End If
                            If I_TABLA Is Nothing Then
                                I_TABLA = TryCast(Me.I_DATAGRIDVIEW.DataSource.tables(0), DataTable)
                            End If
                        End If

                    End If
                Else
                    I_TABLA = Nothing
                End If

                If I_TABLA IsNot Nothing Then
                    llenarCombo()
                    If I_FRM_PARENT IsNot Nothing Then
                        asignarBindings(I_FRM_PARENT)
                    End If
                End If
            Catch ex As Exception
                lanzarException(ex)
            End Try
        End Set
    End Property


    Public ReadOnly Property meSprocedure() As String
        Get
            If I_TABLA IsNot Nothing Then
                sProcedureName = I_TABLA.TableName
            End If
            Return sProcedureName
        End Get

    End Property
    Public ReadOnly Property me_sWhere() As String
        Get
            Return sWhere_Pub
        End Get

    End Property
    Public Property meLanzarException() As Boolean
        Get
            Return I_EXCEPTIONS
        End Get
        Set(ByVal exceptions As Boolean)
            I_EXCEPTIONS = exceptions
        End Set
    End Property

    Public Property meBorderWidthEtiquetas() As Integer
        Get
            Return I_ETIQUETAS_BORDERWIDTH
        End Get
        Set(ByVal BorderWidth As Integer)
            I_ETIQUETAS_BORDERWIDTH = BorderWidth
        End Set
    End Property
    Public Property meFiltrarVacios() As Boolean
        Get
            Return I_FILTRAR_VACIOS
        End Get
        Set(ByVal filtrarVacios As Boolean)
            I_FILTRAR_VACIOS = filtrarVacios
        End Set
    End Property
    Public Property meMarginEtiquetas() As Wisej.Web.Padding
        Get
            Return I_ETIQUETAS_MARGIN
        End Get
        Set(ByVal padding As Wisej.Web.Padding)
            I_ETIQUETAS_MARGIN = padding
        End Set
    End Property
    Public Property mePaddingEtiquetas() As Wisej.Web.Padding
        Get
            Return I_ETIQUETAS_PADDING
        End Get
        Set(ByVal padding As Wisej.Web.Padding)
            I_ETIQUETAS_PADDING = padding
        End Set
    End Property
    Public Property meBackcolorEtiquetas() As Drawing.Color
        Get
            Return I_ETIQUETAS_BACKCOLOR
        End Get
        Set(ByVal color As Color)
            I_ETIQUETAS_BACKCOLOR = color
        End Set
    End Property

    'Public Property meBorderColorEtiquetas() As Color
    '    Get
    '        Return I_ETIQUETAS_BORDERCOLOR
    '    End Get
    '    Set(ByVal color As Color)
    '        I_ETIQUETAS_BORDERCOLOR = color
    '    End Set
    'End Property

    Public Property meBorderStyleEtiquetas() As BorderStyle
        Get
            Return I_ETIQUETAS_BORDERSTYLE
        End Get
        Set(ByVal color As BorderStyle)
            I_ETIQUETAS_BORDERSTYLE = color
        End Set
    End Property
#End Region

#Region "Eventos"


    Private Sub etiquetaFiltroClick(sender As Object, e As EventArgs)
        Try
            Dim c As Control = sender
            panelEtiquetas.Controls.Remove(c.Parent)
            filtrarGrilla()
        Catch ex As Exception
            lanzarException(ex)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim textoFiltro As String = ""
        If dtpFecha.Visible Then
            If DateTime.TryParse(dtpFecha.Value, New Date()) And Me.cmbBuscar.SelectedIndex <> -1 And cmbExpresion.SelectedIndex <> -1 Then
                crearEtiquetaFiltro(Me.cmbBuscar.Text & " " & cmbExpresion.Text & " [" & dtpFecha.Text & "] ", cmbBuscar.SelectedValue, "#" & dtpFecha.Value.ToLongDateString & "#", panelEtiquetas.Controls.Count + 1, cmbExpresion.Text)
            End If
        ElseIf (Me.cmbBuscar.SelectedIndex <> -1 And (txtFiltros.Text.Trim <> Nothing Or I_FILTRAR_VACIOS = True) And cmbExpresion.SelectedIndex <> -1) Then
            textoFiltro &= txtFiltros.Text.Trim
            crearEtiquetaFiltro(Me.cmbBuscar.Text & " " & cmbExpresion.Text & " [" & textoFiltro & "] ", cmbBuscar.SelectedValue, textoFiltro, panelEtiquetas.Controls.Count + 1, cmbExpresion.Text)
        End If
        txtFiltros.Focus()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        quitarFiltros()
    End Sub
    Private Sub cmbExpresion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExpresion.SelectedIndexChanged
        I_TOOLTIP.SetToolTip(cmbExpresion, cmbExpresion.SelectedValue)
    End Sub

    Private Sub cmbBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscar.SelectedIndexChanged
        habilitarExpresiones()
    End Sub
    'Private Sub txtFiltros_EnterKeyDown(objSender As Object, objArgs As KeyEventArgs) Handles txtFiltros.Enter
    '    Try
    '        btnBuscar.Focus()
    '        btnBuscar_Click(btnBuscar, Nothing)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
#End Region
#Region "métodos"
    Private Sub quitarFiltros()
        Try
            For i = panelEtiquetas.Controls.Count - 1 To 0 Step -1
                panelEtiquetas.Controls.RemoveAt(i)
            Next
            'quitar los filtros
            Dim defaultV As DataView = I_TABLA.DefaultView
            defaultV.RowFilter = ""
            Me.I_DATAGRIDVIEW.DataSource = defaultV
            '
            For i = 0 To I_BINDING_NAVIGATOR.Length - 1
                I_BINDING_NAVIGATOR(0).BindingSource.Filter() = ""
            Next
        Catch ex As Exception
            lanzarException(ex)
        End Try
    End Sub
    Private Sub crearExpresiones()
        Dim datos As New Dictionary(Of String, String)
        'Agregar par de datos a mostrar en el combo, (tooltip, descripcion)--->
        datos.Add("Contiene", "%")
        datos.Add("Igual", "=")
        datos.Add("Diferente", "<>")
        datos.Add("Mayor que", ">")
        datos.Add("Menor que", "<")
        datos.Add("Mayor o igual que", ">=")
        datos.Add("Menor o igual que", "<=")
        datos.Add("No contiene", "!%")

        '<---- checar metodo "habilitarExpresiones" si se agregan o se quitan datos
        Try
            I_TABLA_EXPRESIONES = New DataTable("COMBO")
            I_TABLA_EXPRESIONES.Columns.Add("valor")
            I_TABLA_EXPRESIONES.Columns.Add("descripcion")
            For Each pair In datos
                Dim Row = I_TABLA_EXPRESIONES.NewRow()
                Row("valor") = pair.Key
                Row("descripcion") = pair.Value
                I_TABLA_EXPRESIONES.Rows.Add(Row)
            Next
            cmbExpresion.ValueMember = "valor"
            cmbExpresion.DisplayMember = "descripcion"
            cmbExpresion.DataSource = I_TABLA_EXPRESIONES
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub habilitarExpresiones()
        If I_TABLA_EXPRESIONES IsNot Nothing Then

            Dim col = I_TABLA.Columns().Item(cmbBuscar.SelectedValue)

            Dim defaultV As DataView = I_TABLA_EXPRESIONES.DefaultView
            If col.DataType.Name.Contains("Int") Or col.DataType.Name.Contains("Decimal") Or col.DataType.Name.Contains("Date") Then
                defaultV.RowFilter = " valor <> 'Contiene' and valor <> 'No contiene'"
            Else
                defaultV.RowFilter = " valor <> 'Mayor que' and valor <> 'Menor que' and valor <> 'Mayor o igual que' and valor <> 'Menor o igual que'"
            End If
            If col.DataType.Name.Contains("Date") Then
                If txtFiltros.Visible Then
                    dtpFecha.Visible = True
                    btnBuscar.Location() = New Point(btnBuscar.Location.X - (txtFiltros.Width - dtpFecha.Width), btnBuscar.Location.Y)
                    btnLimpiar.Location() = New Point(btnLimpiar.Location.X - (txtFiltros.Width - dtpFecha.Width), btnLimpiar.Location.Y)
                    txtFiltros.Visible = False
                End If
            Else
                If dtpFecha.Visible Then
                    txtFiltros.Visible = True
                    btnBuscar.Location() = New Point(btnBuscar.Location.X + (txtFiltros.Width - dtpFecha.Width), btnBuscar.Location.Y)
                    btnLimpiar.Location() = New Point(btnLimpiar.Location.X + (txtFiltros.Width - dtpFecha.Width), btnLimpiar.Location.Y)
                    dtpFecha.Visible = False
                End If
            End If
            cmbExpresion.DataSource = defaultV
        End If
    End Sub
    Private Sub llenarComboConTabla(combo As ComboBox, datos As Dictionary(Of String, String))
        Try
            Dim tabla As DataTable = New DataTable("COMBO")
            tabla.Columns.Add("valor")
            tabla.Columns.Add("descripcion")
            For Each pair In datos
                Dim Row = tabla.NewRow()
                Row("valor") = pair.Key
                Row("descripcion") = pair.Value
                tabla.Rows.Add(Row)
            Next
            combo.ValueMember = "valor"
            combo.DisplayMember = "descripcion"
            combo.DataSource = tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub asignarBindings(Formulario As Control)
        For Each c As Control In Formulario.Controls
            If c.HasChildren Then
                asignarBindings(c)
            Else
                If c.GetType.Name.Contains("BindingNavigator") Then
                    Dim bindingNav = TryCast(c, BindingNavigator)
                    If bindingNav.BindingSource IsNot Nothing Then
                        If bindingNav.BindingSource.DataMember IsNot Nothing Then
                            If TryCast(c, BindingNavigator).BindingSource.DataMember.ToString = I_TABLA.ToString Then
                                ReDim Preserve I_BINDING_NAVIGATOR(I_COUNT_BINDINGS)
                                I_BINDING_NAVIGATOR(I_COUNT_BINDINGS) = TryCast(c, BindingNavigator)
                                I_COUNT_BINDINGS += 1
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub llenarCombo()
        Try
            Dim tabla As DataTable = New DataTable("COMBO")
            tabla.Columns.Add("valor")
            tabla.Columns.Add("descripcion")

            For i = 0 To I_DATAGRIDVIEW.ColumnCount - 1
                If I_DATAGRIDVIEW.Columns(i).Visible = True And (I_DATAGRIDVIEW.Columns(i).CellType.Name = "DataGridViewTextBoxCell" Or I_DATAGRIDVIEW.Columns(i).CellType.Name = "DataGridViewLinkCell") Then
                    If I_DATAGRIDVIEW.Columns(i).DataPropertyName <> Nothing Then
                        If I_TABLA.Columns(I_DATAGRIDVIEW.Columns(i).DataPropertyName) IsNot Nothing Then
                            'If I_TABLA.Columns(I_DATAGRIDVIEW.Columns(i).DataPropertyName).DataType.Name <> "DateTime" Then
                            tabla.Rows.Add(I_DATAGRIDVIEW.Columns(i).DataPropertyName, I_DATAGRIDVIEW.Columns(i).HeaderText)
                            'End If
                        End If
                    End If
                End If
            Next
            Me.cmbBuscar.ValueMember = "valor"
            Me.cmbBuscar.DisplayMember = "descripcion"
            Me.cmbBuscar.DataSource = tabla
        Catch ex As Exception
            lanzarException(ex)
        End Try
    End Sub
    Private Sub filtrarGrilla()
        Dim Where As String = "" : Dim cm1 As String = "" : Dim cm2 As String = "'" : Dim separador As String = " " : Dim expresion As String = ""
        Try
            For i = 0 To panelEtiquetas.Controls.Count - 1
                Dim label As MePanel = panelEtiquetas.Controls(i)
                expresion = label.exp
                Dim col = I_TABLA.Columns().Item(label.field)

                If col.DataType.Name.Contains("Int") Or col.DataType.Name.Contains("Decimal") Then 'si es numerico, se transforma a un double y  se cambia "like" por "="
                    label.value = Double.Parse(rellenar(label.value, 8, True))
                End If

                If expresion = "%" Then
                    cm1 = " Like '%" : cm2 = "%'"
                ElseIf expresion = "!%" Then
                    cm1 = " Not Like '%" : cm2 = "%'"
                Else
                    cm1 = " " & expresion & " '" : cm2 = "'"
                End If

                Where &= separador & label.field & cm1 & label.value & cm2
                separador = " and "
            Next
            Dim defaultV As DataView = I_TABLA.DefaultView
            defaultV.RowFilter = Where
            sWhere_Pub = Where
            Me.I_DATAGRIDVIEW.DataSource = defaultV

            For i = 0 To I_BINDING_NAVIGATOR.Length - 1
                I_BINDING_NAVIGATOR(0).BindingSource.Filter() = Where
            Next
        Catch ex As Exception
            lanzarException(ex)
        End Try

    End Sub
    Private Function rellenar(ByVal texto As String, decimales As Integer, negativo As Boolean)
        Dim numeros As Char()
        If (decimales > 0) Then
            numeros = texto.ToCharArray()
            texto = ""
            For i = 0 To numeros.Length - 1
                If ((numeros(i) >= "0" And numeros(i) <= "9") Or numeros(i) = ".") Then
                    texto += numeros(i)
                ElseIf negativo And numeros(0) = "-" Then
                    texto += numeros(i)
                End If
            Next i
            If texto.Contains(".") Then
                Dim entero_decimal() As String = texto.Split(".")
                If entero_decimal(1).Length >= decimales Then
                    entero_decimal(1) = entero_decimal(1).Substring(0, decimales)
                    texto = entero_decimal(0) & "." & entero_decimal(1)
                Else
                    texto = entero_decimal(0) & "."
                    For i = 1 To decimales - entero_decimal(1).Length
                        entero_decimal(1) += "0"
                    Next
                    texto += entero_decimal(1)
                End If
            Else
                texto = texto & "."
                For i = 1 To decimales
                    texto = texto & "0"
                Next
            End If
        Else
            Dim entero As String() = texto.Split(".")
            numeros = entero(0).ToCharArray()
            texto = ""
            For i = 0 To numeros.Length - 1
                If (numeros(i) >= "0" And numeros(i) <= "9") Then
                    texto += numeros(i)
                ElseIf negativo And numeros(0) = "-" Then
                    texto += numeros(i)
                End If
            Next i
        End If
        If texto.Length > 0 Then
            If texto.Substring(0, 1) = "." Then texto = "0" + texto
        Else texto = "0"
        End If
        Return texto
    End Function

#End Region
    'Clase creada para poder agregar campo de la base de datos y valor a filtrar
    Private Class MePanel
        Inherits Panel
        Protected Friend field As String = Nothing
        Protected Friend value As String = Nothing
        Protected Friend exp As String = Nothing

    End Class



    Private Sub crearEtiquetaFiltro(texto As String, campo As String, valor As String, Id As Integer, expresion As String)
        Try
            Dim filtro As MePanel = New MePanel
            Dim boton As New Button
            Dim label As New Label
            '
            I_TOOLTIP.SetToolTip(boton, "Quitar filtro")
            boton.Text = "X"
            boton.Padding = New Padding(0)
            boton.TextAlign = ContentAlignment.MiddleCenter
            boton.ForeColor = Color.White
            boton.Font = New Font("Arial", 8.25!, FontStyle.Bold)
            'boton.FlatStyle = FlatStyle.Standard
            boton.Name = "boton_" & Id
            boton.Size = New System.Drawing.Size(19, 19)
            boton.Location = New Point(0, I_ETIQUETAS_PADDING.Top)
            AddHandler boton.Click, AddressOf etiquetaFiltroClick
            '
            label.MinimumSize = New Size(0, boton.Height + +boton.Margin.Top + I_ETIQUETAS_PADDING.Top)
            label.AutoSize = True
            label.Name = "label_" & Id
            label.Text = texto
            label.TextAlign = ContentAlignment.MiddleCenter
            label.Location = New Point(boton.Right + 2, I_ETIQUETAS_PADDING.Top)
            '
            filtro.MinimumSize = New Size(0, boton.Height + +boton.Margin.Top + boton.Margin.Bottom + I_ETIQUETAS_PADDING.Top + I_ETIQUETAS_PADDING.Bottom)
            filtro.Margin = I_ETIQUETAS_MARGIN
            filtro.Padding = I_ETIQUETAS_PADDING
            filtro.value = valor
            filtro.field = campo
            filtro.exp = expresion
            filtro.AutoSizeMode = AutoSizeMode.GrowAndShrink
            filtro.AutoSize = True
            filtro.Controls.Add(boton)
            filtro.Controls.Add(label)
            filtro.BackColor = I_ETIQUETAS_BACKCOLOR
            filtro.Name = "filtro_" & Id
            'filtro.BorderWidth = I_ETIQUETAS_BORDERWIDTH
            filtro.BorderStyle = BorderStyle.Solid
            '
            panelEtiquetas.Controls.Add(filtro)
            filtrarGrilla()
            Me.txtFiltros.Text = Nothing
        Catch ex As Exception
            lanzarException(ex)
        End Try
    End Sub

    Private Sub txtFiltros_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltros.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar.Focus()
            btnBuscar_Click(btnBuscar, Nothing)
        End If
    End Sub

    Public Sub lanzarException(ex As Exception)
        If I_EXCEPTIONS Then
            Throw ex 'creado por si se desea manejar alguna exception que ocurra
        End If

    End Sub
End Class




