Imports System.Drawing
Class j
    Dim Int As Integer = +199979989911
    Dim I As Integer = 0
    Dim z1 = CreateObject("SAPI.spvoice")
    Public mx As Integer = 8
    Public Const tm As Integer = 3
    Dim Draw As Boolean
    Dim Dcolo As Color = Color.Black
    Dim Dra As Integer = 7
    Dim Bmp As Bitmap
    Dim lu As String = ""
    Dim pv As Boolean = False
    Dim wo As Boolean = False
    Dim tl As ToolStripMenuItem
    Sub a1(ByVal sender As System.Object, ByVal e As EventArgs) Handles b.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub
    Sub a2(ByVal sender As Object, ByVal e As EventArgs) Handles b.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
        End If
    End Sub
    Sub a3(ByVal sender As System.Object, ByVal e As EventArgs) Handles f.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub
    Sub a4(ByVal sender As Object, ByVal e As EventArgs) Handles f.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
        End If
    End Sub
    Sub a5(ByVal sender As System.Object, ByVal e As EventArgs) Handles h.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.h)
    End Sub
    Sub a6(ByVal sender As Object, ByVal e As EventArgs) Handles h.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.h)
        End If
    End Sub
    Sub a7(ByVal sender As System.Object, ByVal e As EventArgs) Handles g.Click
        q1(c.Text)
    End Sub
    Sub a8(ByVal sender As Object, ByVal e As EventArgs) Handles g.MouseHover
        If My.Settings.t = "e" Then
            q1(c.Text)
        End If
    End Sub
    Sub a9(ByVal sender As System.Object, ByVal e As EventArgs) Handles r.Click
        If r.Image Is My.Resources.F7 Then
            r.Image = My.Resources.F8
        End If
        If r.Image Is My.Resources.F8 Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
        Else
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Stop()
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True
            On Error Resume Next
            LO.Size = New Size(1, 2)
            r.Image = My.Resources.F8
            su.Visible = False
            k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Text = ProductName & " - " & k.SelectedTab.Text
            c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
            f6.l0.Items.Add(c.Text)
            c.Items.Add(c.Text)
            If CType(k.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack Then
                b.Enabled = True
                BT.Enabled = True
            Else
                b.Enabled = False
                BT.Enabled = False
            End If
            If CType(k.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward Then
                f.Enabled = True
                FT.Enabled = True
            Else
                f.Enabled = False
                FT.Enabled = False
            End If
        End If
    End Sub
    Sub b1(ByVal sender As Object, ByVal e As EventArgs) Handles r.MouseHover
        If My.Settings.t = "e" Then
            If r.Image Is My.Resources.F7 Then
                r.Image = My.Resources.F8
            End If
            If r.Image Is My.Resources.F8 Then
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
            Else
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Stop()
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True
                On Error Resume Next
                LO.Size = New Size(1, 2)
                r.Image = My.Resources.F8
                su.Visible = False
                k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
                Text = ProductName & " - " & k.SelectedTab.Text
                c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
                f6.l0.Items.Add(c.Text)
                c.Items.Add(c.Text)
                If CType(k.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack Then
                    b.Enabled = True
                    BT.Enabled = True
                Else
                    b.Enabled = False
                    BT.Enabled = False
                End If
                If CType(k.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward Then
                    f.Enabled = True
                    FT.Enabled = True
                Else
                    f.Enabled = False
                    FT.Enabled = False
                End If
            End If
        End If
    End Sub
    Sub b3(ByVal sender As System.Object, ByVal e As EventArgs) Handles s.Click
        q2()
    End Sub
    Sub b4(ByVal sender As Object, ByVal e As EventArgs) Handles s.MouseHover
        Try
            If My.Settings.t = "e" Then
                q2()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub b5(ByVal sender As System.Object, ByVal e As EventArgs) Handles BT.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub
    Sub b6(ByVal sender As Object, ByVal e As EventArgs) Handles BT.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
        End If
    End Sub
    Sub b7(ByVal sender As System.Object, ByVal e As EventArgs) Handles FT.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub
    Sub b8(ByVal sender As Object, ByVal e As EventArgs) Handles FT.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
        End If
    End Sub
    Sub b9(ByVal sender As System.Object, ByVal e As EventArgs) Handles ET.Click
        End
    End Sub
    Sub c1(ByVal sender As Object, ByVal e As EventArgs) Handles ET.MouseHover
        If My.Settings.t = "e" Then
            End
        End If
    End Sub
    Sub c2(ByVal sender As System.Object, ByVal e As EventArgs) Handles CW.Click
        Close()
    End Sub
    Sub c3(ByVal sender As System.Object, ByVal e As EventArgs) Handles NW.Click
        Dim f As New j
        f.Show()
    End Sub
    Sub c4(ByVal sender As Object, ByVal e As EventArgs) Handles NW.MouseHover
        If My.Settings.t = "e" Then
            Dim f As New j
            f.Show()
        End If
    End Sub
    Sub c5(ByVal sender As System.Object, ByVal e As EventArgs) Handles U.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Undo", True, vbNull)
    End Sub
    Sub c6(ByVal sender As Object, ByVal e As EventArgs) Handles U.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Undo", True, vbNull)
        End If
    End Sub
    Sub c7(ByVal sender As System.Object, ByVal e As EventArgs) Handles RD.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Redo", True, vbNull)
    End Sub
    Sub c8(ByVal sender As Object, ByVal e As EventArgs) Handles RD.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Redo", True, vbNull)
        End If
    End Sub
    Sub c9(ByVal sender As System.Object, ByVal e As EventArgs) Handles CO.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Copy", True, vbNull)
    End Sub
    Sub d1(ByVal sender As Object, ByVal e As EventArgs) Handles CO.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Copy", True, vbNull)
        End If
    End Sub
    Sub d2(ByVal sender As System.Object, ByVal e As EventArgs) Handles CU.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Cut", True, vbNull)
    End Sub
    Sub d3(ByVal sender As Object, ByVal e As EventArgs) Handles CU.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Cut", True, vbNull)
        End If
    End Sub
    Sub d4(ByVal sender As System.Object, ByVal e As EventArgs) Handles PA.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Paste", True, vbNull)
    End Sub
    Sub d5(ByVal sender As Object, ByVal e As EventArgs) Handles PA.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Paste", True, vbNull)
        End If
    End Sub
    Sub d6(ByVal sender As System.Object, ByVal e As EventArgs) Handles SA.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("SelectAll", True, vbNull)
    End Sub
    Sub d7(ByVal sender As Object, ByVal e As EventArgs) Handles SA.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("SelectAll", True, vbNull)
        End If
    End Sub
    Sub d8(ByVal sender As System.Object, ByVal e As EventArgs) Handles D.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Delete", True, vbNull)
    End Sub
    Sub d9(ByVal sender As Object, ByVal e As EventArgs) Handles D.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Delete", True, vbNull)
        End If
    End Sub
    Sub e1(ByVal sender As System.Object, ByVal e As EventArgs) Handles P.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub
    Sub e2(ByVal sender As Object, ByVal e As EventArgs) Handles P.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
        End If
    End Sub
    Sub e3(ByVal sender As System.Object, ByVal e As EventArgs) Handles PP.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
    End Sub
    Sub e4(ByVal sender As Object, ByVal e As EventArgs) Handles PP.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
        End If
    End Sub
    Sub e5(ByVal sender As System.Object, ByVal e As EventArgs) Handles PS.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub
    Sub e6(ByVal sender As Object, ByVal e As EventArgs) Handles PS.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
        End If
    End Sub
    Sub e7(ByVal sender As System.Object, ByVal e As EventArgs) Handles A.Click
        f2.Show()
    End Sub
    Sub e8(ByVal sender As Object, ByVal e As EventArgs) Handles A.MouseHover
        If My.Settings.t = "e" Then
            f2.Show()
        End If
    End Sub
    Sub e9(ByVal sender As System.Object, ByVal e As EventArgs) Handles pt.Click
        F3.Show()
        F3.RN.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentText
    End Sub
    Sub g1(ByVal sender As Object, ByVal e As EventArgs) Handles pt.MouseHover
        If My.Settings.t = "e" Then
            F3.Show()
            F3.RN.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentText
        End If
    End Sub
    Sub g2(ByVal sender As System.Object, ByVal e As EventArgs) Handles O.Click
        F4.Show()
    End Sub
    Sub g3(ByVal sender As Object, ByVal e As EventArgs) Handles O.MouseHover
        If My.Settings.t = "e" Then
            F4.Show()
        End If
    End Sub
    Sub g5(ByVal sender As System.Object, ByVal e As EventArgs) Handles HT.Click
        zx.PerformClick()
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://firespiderinternet.weebly.com/help.html")
    End Sub
    Sub f5(ByVal sender As Object, ByVal e As EventArgs) Handles HT.MouseHover
        If My.Settings.t = "e" Then
            zx.PerformClick()
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://firespiderinternet.weebly.com/help.html")
        End If
    End Sub
    Sub g6(ByVal sender As System.Object, ByVal e As EventArgs) Handles SH.Click
        f6.Show()
    End Sub
    Sub g7(ByVal sender As Object, ByVal e As EventArgs) Handles SH.MouseHover
        If My.Settings.t = "e" Then
            f6.Show()
        End If
    End Sub
    Sub g8(ByVal sender As System.Object, ByVal e As EventArgs) Handles SB.Click
        F7.Show()
    End Sub
    Sub g9(ByVal sender As Object, ByVal e As EventArgs) Handles SB.MouseHover
        If My.Settings.t = "e" Then
            F7.Show()
        End If
    End Sub
    Sub h1(ByVal sender As System.Object, ByVal e As EventArgs) Handles OP.Click
        Dim ox As New OpenFileDialog()
        ox.Title = "Open"
        ox.CheckFileExists = True
        ox.Filter = "All Files (*.*)|*.*"
        ox.ShowDialog()
        Try
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ox.FileName)
        Catch ex As Exception
        End Try
    End Sub
    Sub h2(ByVal sender As Object, ByVal e As EventArgs) Handles OP.MouseHover
        If My.Settings.t = "e" Then
            Dim ox As New OpenFileDialog()
            ox.Title = "Open"
            ox.CheckFileExists = True
            ox.Filter = "All Files (*.*)|*.*"
            ox.ShowDialog()
            Try
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ox.FileName)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub h3(ByVal sender As System.Object, ByVal e As EventArgs) Handles SP.Click
        Dim SX As New SaveFileDialog()
        Dim mySW As System.IO.StreamWriter
        SX.FileName = (CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle)
        SX.Filter = "HTML [*.html*]|*.html|All Files [*.*]|*.*"
        SX.CheckPathExists = True
        SX.Title = "Save Page"
        SX.ShowDialog(Me)
        Try
            mySW = System.IO.File.AppendText(SX.FileName)
            mySW.Write(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document)
            mySW.Flush()
        Catch ex As Exception
        End Try
    End Sub
    Sub h4(ByVal sender As Object, ByVal e As EventArgs) Handles SP.MouseHover
        If My.Settings.t = "e" Then
            Dim SX As New SaveFileDialog()
            Dim mySW As System.IO.StreamWriter
            SX.FileName = (CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle)
            SX.Filter = "HTML [*.html*]|*.html|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Page"
            SX.ShowDialog(Me)
            Try
                mySW = System.IO.File.AppendText(SX.FileName)
                mySW.Write(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document)
                mySW.Flush()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub nc(ByVal sender As System.Object, ByVal e As EventArgs) Handles N.Click
        Dim B As New WebBrowser
        k.TabPages.Add("New Tab")
        k.SelectTab(I)
        B.Dock = DockStyle.Fill
        k.SelectedTab.Controls.Add(B)
        AddHandler B.Navigating, AddressOf nn
        AddHandler B.Navigated, AddressOf nv
        AddHandler B.DocumentCompleted, AddressOf n0
        AddHandler B.ProgressChanged, AddressOf q14
        I = I + 1
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.h)
        Dim tz As Size = k.ItemSize
        If I <= 20 Then
            tz.Width -= 6
        ElseIf I >= 30 Then
            tz.Width += 8
        End If
        k.ItemSize = tz
    End Sub
    Sub nh(ByVal sender As Object, ByVal e As EventArgs) Handles N.MouseHover
        If My.Settings.t = "e" Then
            Dim B As New WebBrowser
            k.TabPages.Add("New Tab")
            k.SelectTab(I)
            B.Dock = DockStyle.Fill
            k.SelectedTab.Controls.Add(B)
            AddHandler B.Navigating, AddressOf nn
            AddHandler B.Navigated, AddressOf nv
            AddHandler B.DocumentCompleted, AddressOf n0
            AddHandler B.ProgressChanged, AddressOf q14
            I = I + 1
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.h)
            Dim tz As Size = k.ItemSize
            If I <= 20 Then
                tz.Width -= 6
            ElseIf I >= 30 Then
                tz.Width += 8
            End If
            k.ItemSize = tz
        End If
    End Sub
    Sub h5(ByVal sender As System.Object, ByVal e As EventArgs) Handles CT.Click
        If k.TabCount = 1 = False Then
            rca(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            k.TabPages.RemoveAt(k.SelectedIndex)
            I = I - 1
            Dim tz As Size = k.ItemSize
            tz.Width += 6
            k.ItemSize = tz
            k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Text = ProductName & " - " & k.SelectedTab.Text
            c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Else
            End
        End If
    End Sub
    Sub h6(ByVal sender As System.Object, ByVal e As EventArgs) Handles HO.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub
    Sub h7(ByVal sender As Object, ByVal e As EventArgs) Handles HO.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
        End If
    End Sub
    Sub h8(ByVal sender As System.Object, ByVal e As EventArgs) Handles PB.Click
        Dim f As New j
        f.Show()
        f.Close()
        c.Items.Clear()
        f6.l0.Items.Clear()
        My.Settings.b0 = "f"
    End Sub
    Sub h9(ByVal sender As Object, ByVal e As EventArgs) Handles PB.MouseHover
        If My.Settings.t = "e" Then
            Dim f As New j
            f.Show()
            f.Close()
            c.Items.Clear()
            f6.l0.Items.Clear()
            My.Settings.b0 = "f"
        End If
    End Sub
    Sub i1(ByVal sender As System.Object, ByVal e As EventArgs) Handles CR.Click
        c.Items.Clear()
        f6.l0.Items.Clear()
    End Sub
    Sub i2(ByVal sender As Object, ByVal e As EventArgs) Handles CR.MouseHover
        If My.Settings.t = "e" Then
            c.Items.Clear()
            f6.l0.Items.Clear()
        End If
    End Sub
    Sub i3(ByVal sender As System.Object, ByVal e As EventArgs) Handles re.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub
    Sub i4(ByVal sender As Object, ByVal e As EventArgs) Handles re.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
        End If
    End Sub
    Sub i5(ByVal sender As System.Object, ByVal e As EventArgs) Handles st.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Stop()
    End Sub
    Sub i6(ByVal sender As Object, ByVal e As EventArgs) Handles st.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Stop()
        End If
    End Sub
    Sub i7(ByVal sender As System.Object, ByVal e As EventArgs) Handles fs.Click
        If TopMost = False Then
            m.Visible = False
            k.Dock = DockStyle.Fill
            TopMost = True
            WindowState = FormWindowState.Normal
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Maximized
            ShowIcon = False
            y2.Image = My.Resources.O0
            q.AutoSize = True
        Else
            m.Visible = True
            k.Dock = DockStyle.None
            TopMost = False
            FormBorderStyle = FormBorderStyle.Sizable
            WindowState = FormWindowState.Maximized
            ShowIcon = False
            y2.Image = My.Resources.F1
        End If
    End Sub
    Sub i8(ByVal sender As Object, ByVal e As EventArgs) Handles fs.MouseHover
        If My.Settings.t = "e" Then
            If TopMost = False Then
                m.Visible = False
                k.Dock = DockStyle.Fill
                TopMost = True
                WindowState = FormWindowState.Normal
                FormBorderStyle = FormBorderStyle.None
                WindowState = FormWindowState.Maximized
                ShowIcon = False
                y2.Image = My.Resources.O0
                q.AutoSize = True
            Else
                m.Visible = True
                k.Dock = DockStyle.None
                TopMost = False
                FormBorderStyle = FormBorderStyle.Sizable
                WindowState = FormWindowState.Maximized
                ShowIcon = False
                y2.Image = My.Resources.F1
            End If
        End If
    End Sub
    Sub i9(ByVal sender As Object, ByVal e As KeyEventArgs) Handles c.KeyDown
        If c.Text = "" Then
        Else
            If e.KeyCode = Keys.Enter Then
                q1(c.Text)
            End If
        End If
    End Sub
    Sub j1(ByVal sender As Object, ByVal e As KeyEventArgs) Handles x.KeyDown
        If x.Text = "search" Then
            x.Text = ""
        End If
        If x.Text = "" Then
        Else
            If e.KeyCode = Keys.Enter Then
                If x.Text = "search" Then
                Else
                    q2()
                End If
            End If
        End If
    End Sub
    Sub xc(ByVal sender As System.Object, ByVal e As EventArgs) Handles x.Click
        If x.Text = "search" Then
            x.Text = ""
            s.Enabled = False
        ElseIf x.Text = "" Then
            x.Text = "search"
            s.Enabled = False
        End If
    End Sub
    Sub tk(ByVal sender As System.Object, ByVal e As EventArgs) Handles t.Tick
        su.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).StatusText
    End Sub
    Dim it As Integer = 0
    Sub pc(ByVal sender As System.Object, ByVal e As EventArgs) Handles BP.Click
        Try
            Dim fv As New ToolStripMenuItem
            fv.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            fv.Tag = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            fv.Image = My.Resources.F9
            fv.BackgroundImage = My.Resources.F2
            fv.BackgroundImageLayout = ImageLayout.Stretch
            fv.ForeColor = Color.White
            AddHandler fv.Click, AddressOf z2
            AddHandler fv.MouseHover, AddressOf z2
            RB.DropDownItems.Add(fv)
            My.Settings.bm.Add(fv.Tag.ToString)
        Catch ex As Exception
        End Try
    End Sub
    Sub z2(ByVal sender As ToolStripMenuItem, ByVal ByVale As EventArgs)
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(sender.Tag)
    End Sub
    Sub jl(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            mf = Me
            u8(mf)
            If My.Settings.i = Color.Black Then
            Else
                q.BackgroundImage = Nothing
                q.BackColor = My.Settings.i
                fl.BackgroundImage = Nothing
                fl.BackColor = My.Settings.i
                BackgroundImage = Nothing
                BackColor = My.Settings.i
                v.BackgroundImage = Nothing
                v.BackColor = My.Settings.i
                hi.BackgroundImage = Nothing
                hi.BackColor = My.Settings.i
                bo.BackgroundImage = Nothing
                bo.BackColor = My.Settings.i
                ot.BackgroundImage = Nothing
                ot.BackColor = My.Settings.i
                he.BackgroundImage = Nothing
                he.BackColor = My.Settings.i
                c.BackColor = My.Settings.i
                x.BackColor = My.Settings.i
            End If
            My.Settings.b0 = "e"
            KeyPreview = True
            For q As Integer = 0 To My.Settings.bm.Count - 1
                If My.Settings.bm.Item(q) = "" Then
                Else
                    Dim fv As New ToolStripMenuItem
                    fv.Text = My.Settings.bm.Item(q)
                    fv.Tag = My.Settings.bm.Item(q)
                    fv.Image = My.Resources.F9
                    fv.BackgroundImage = My.Resources.F2
                    fv.BackgroundImageLayout = ImageLayout.Stretch
                    fv.ForeColor = Color.White
                    AddHandler fv.Click, AddressOf z2
                    AddHandler fv.MouseHover, AddressOf z2
                    RB.DropDownItems.Add(fv)
                End If
            Next q
            For q As Integer = 0 To My.Settings.s.Count - 1
                If My.Settings.s.Item(q) = "" Then
                ElseIf My.Settings.s.Item(q) = "search" Then
                Else
                    x.Items.Add(My.Settings.s.Item(q))
                End If
            Next q
            Dim du As New ToolStripMenuItem
            du.Text = "Duplicate Tab"
            du.Image = My.Resources.F9
            du.BackColor = Color.White
            du.ForeColor = Color.Black
            du.Padding = New Padding(0)
            AddHandler du.Click, AddressOf q4
            AddHandler du.MouseHover, AddressOf q5
            fl.DropDownItems.Insert(3, du)
            Dim ru As New ToolStripMenuItem
            ru.Text = "Reopen Closed Tab"
            ru.Image = My.Resources.F9
            ru.BackColor = Color.White
            ru.ForeColor = Color.Black
            ru.Padding = New Padding(0)
            AddHandler ru.Click, AddressOf q6
            AddHandler ru.MouseHover, AddressOf q7
            fl.DropDownItems.Insert(4, ru)
            Dim co As New ToolStripMenuItem
            co.Text = "Close Other Tabs"
            co.Image = My.Resources.F9
            co.BackColor = Color.White
            co.ForeColor = Color.Black
            co.Padding = New Padding(0)
            AddHandler co.Click, AddressOf q16
            AddHandler co.MouseHover, AddressOf q17
            fl.DropDownItems.Insert(5, co)
            Dim pm As New ToolStripMenuItem
            pm.Text = "Private Mode"
            pm.Image = My.Resources.F9
            pm.BackColor = Color.White
            pm.ForeColor = Color.Black
            pm.Padding = New Padding(0)
            AddHandler pm.Click, AddressOf q18
            AddHandler pm.MouseHover, AddressOf q19
            ot.DropDownItems.Insert(0, pm)
            Dim hm As New ToolStripMenuItem
            hm.Text = "Use Current Page As Home"
            hm.Image = My.Resources.F9
            hm.BackColor = Color.White
            hm.ForeColor = Color.Black
            hm.Padding = New Padding(0)
            AddHandler hm.Click, AddressOf q11
            AddHandler hm.MouseHover, AddressOf q12
            hi.DropDownItems.Insert(4, hm)
            Dim cp As New ToolStripMenuItem
            cp.Text = "Copy Page Link"
            cp.Image = My.Resources.F9
            cp.BackColor = Color.White
            cp.ForeColor = Color.Black
            cp.Padding = New Padding(0)
            AddHandler cp.Click, AddressOf q20
            AddHandler cp.MouseHover, AddressOf q21
            Me.e.DropDownItems.Insert(2, cp)
            Dim ra As New ToolStripMenuItem
            ra.Text = "Reload All Tabs"
            ra.Image = My.Resources.F9
            ra.BackColor = Color.White
            ra.ForeColor = Color.Black
            ra.Padding = New Padding(0)
            AddHandler ra.Click, AddressOf q22
            AddHandler ra.MouseHover, AddressOf q23
            v.DropDownItems.Insert(2, ra)
            tl = New ToolStripMenuItem
            tl.Text = "Tabs"
            tl.Image = My.Resources.F9
            tl.BackColor = Color.White
            tl.ForeColor = Color.Black
            tl.Padding = New Padding(0)
            AddHandler tl.DropDownOpening, AddressOf q24
            AddHandler tl.MouseHover, AddressOf q26
            hi.DropDownItems.Insert(5, tl)
            Dim ss As New ToolStripMenuItem
            ss.Text = "Save Screenshot"
            ss.Image = My.Resources.F9
            ss.BackColor = Color.White
            ss.ForeColor = Color.Black
            ss.Padding = New Padding(0)
            AddHandler ss.Click, AddressOf q27
            AddHandler ss.MouseHover, AddressOf q28
            fl.DropDownItems.Insert(8, ss)
            Dim cs As New ToolStripMenuItem
            cs.Text = "Clear Saved Session"
            cs.Image = My.Resources.F9
            cs.BackColor = Color.White
            cs.ForeColor = Color.Black
            cs.Padding = New Padding(0)
            AddHandler cs.Click, AddressOf q29
            AddHandler cs.MouseHover, AddressOf q30
            ot.DropDownItems.Insert(1, cs)
            Dim ba As New ToolStripMenuItem
            ba.Text = "Bookmark All Tabs"
            ba.Image = My.Resources.F9
            ba.BackColor = Color.White
            ba.ForeColor = Color.Black
            ba.Padding = New Padding(0)
            AddHandler ba.Click, AddressOf q31
            AddHandler ba.MouseHover, AddressOf q32
            bo.DropDownItems.Insert(1, ba)
            Dim cr As New ToolStripMenuItem
            cr.Text = "Close Tabs To The Right"
            cr.Image = My.Resources.F9
            cr.BackColor = Color.White
            cr.ForeColor = Color.Black
            cr.Padding = New Padding(0)
            AddHandler cr.Click, AddressOf q33
            AddHandler cr.MouseHover, AddressOf q34
            fl.DropDownItems.Insert(6, cr)
            Dim pi As New ToolStripMenuItem
            pi.Text = "Page Info"
            pi.Image = My.Resources.F9
            pi.BackColor = Color.White
            pi.ForeColor = Color.Black
            pi.Padding = New Padding(0)
            AddHandler pi.Click, AddressOf q35
            AddHandler pi.MouseHover, AddressOf q36
            he.DropDownItems.Insert(0, pi)
            Dim dl As New ToolStripMenuItem
            dl.Text = "Open Downloads Folder"
            dl.Image = My.Resources.F9
            dl.BackColor = Color.White
            dl.ForeColor = Color.Black
            dl.Padding = New Padding(0)
            AddHandler dl.Click, AddressOf q37
            AddHandler dl.MouseHover, AddressOf q38
            fl.DropDownItems.Insert(9, dl)
            Dim nw As New ToolStripMenuItem
            nw.Text = "Open Page In New Window"
            nw.Image = My.Resources.F9
            nw.BackColor = Color.White
            nw.ForeColor = Color.Black
            nw.Padding = New Padding(0)
            AddHandler nw.Click, AddressOf q39
            AddHandler nw.MouseHover, AddressOf q40
            fl.DropDownItems.Insert(7, nw)
            Dim ct As New ToolStripMenuItem
            ct.Text = "Copy Page Title"
            ct.Image = My.Resources.F9
            ct.BackColor = Color.White
            ct.ForeColor = Color.Black
            ct.Padding = New Padding(0)
            AddHandler ct.Click, AddressOf q41
            AddHandler ct.MouseHover, AddressOf q42
            Me.e.DropDownItems.Insert(3, ct)
            Dim rd As New ToolStripMenuItem
            rd.Text = "Remove Duplicate Bookmarks"
            rd.Image = My.Resources.F9
            rd.BackColor = Color.White
            rd.ForeColor = Color.Black
            rd.Padding = New Padding(0)
            AddHandler rd.Click, AddressOf q43
            AddHandler rd.MouseHover, AddressOf q44
            bo.DropDownItems.Insert(2, rd)
            Dim oa As New ToolStripMenuItem
            oa.Text = "Open All Bookmarks"
            oa.Image = My.Resources.F9
            oa.BackColor = Color.White
            oa.ForeColor = Color.Black
            oa.Padding = New Padding(0)
            AddHandler oa.Click, AddressOf q45
            AddHandler oa.MouseHover, AddressOf q46
            bo.DropDownItems.Insert(3, oa)
            Dim sa As New ToolStripMenuItem
            sa.Text = "Stop All Tabs"
            sa.Image = My.Resources.F9
            sa.BackColor = Color.White
            sa.ForeColor = Color.Black
            sa.Padding = New Padding(0)
            AddHandler sa.Click, AddressOf q47
            AddHandler sa.MouseHover, AddressOf q48
            v.DropDownItems.Insert(3, sa)
            Dim stl As New ToolStripMenuItem
            stl.Text = "Save All Tab Links"
            stl.Image = My.Resources.F9
            stl.BackColor = Color.White
            stl.ForeColor = Color.Black
            stl.Padding = New Padding(0)
            AddHandler stl.Click, AddressOf q49
            AddHandler stl.MouseHover, AddressOf q50
            fl.DropDownItems.Insert(10, stl)
            Dim ml As New ToolStripMenuItem
            ml.Text = "Move Tab Left"
            ml.Image = My.Resources.F9
            ml.BackColor = Color.White
            ml.ForeColor = Color.Black
            ml.Padding = New Padding(0)
            AddHandler ml.Click, AddressOf q51
            AddHandler ml.MouseHover, AddressOf q52
            hi.DropDownItems.Insert(6, ml)
            Dim mr As New ToolStripMenuItem
            mr.Text = "Move Tab Right"
            mr.Image = My.Resources.F9
            mr.BackColor = Color.White
            mr.ForeColor = Color.Black
            mr.Padding = New Padding(0)
            AddHandler mr.Click, AddressOf q53
            AddHandler mr.MouseHover, AddressOf q54
            hi.DropDownItems.Insert(7, mr)
            Dim ctl As New ToolStripMenuItem
            ctl.Text = "Copy Page Title And Link"
            ctl.Image = My.Resources.F9
            ctl.BackColor = Color.White
            ctl.ForeColor = Color.Black
            ctl.Padding = New Padding(0)
            AddHandler ctl.Click, AddressOf q55
            AddHandler ctl.MouseHover, AddressOf q56
            Me.e.DropDownItems.Insert(4, ctl)
            Dim osl As New ToolStripMenuItem
            osl.Text = "Open Saved Tab Links"
            osl.Image = My.Resources.F9
            osl.BackColor = Color.White
            osl.ForeColor = Color.Black
            osl.Padding = New Padding(0)
            AddHandler osl.Click, AddressOf q57
            AddHandler osl.MouseHover, AddressOf q58
            fl.DropDownItems.Insert(11, osl)
            Dim db As New ToolStripMenuItem
            db.Text = "Open In Default Browser"
            db.Image = My.Resources.F9
            db.BackColor = Color.White
            db.ForeColor = Color.Black
            db.Padding = New Padding(0)
            AddHandler db.Click, AddressOf q59
            AddHandler db.MouseHover, AddressOf q60
            fl.DropDownItems.Insert(8, db)
            Dim ca As New ToolStripMenuItem
            ca.Text = "Clear Address And Search Suggestions"
            ca.Image = My.Resources.F9
            ca.BackColor = Color.White
            ca.ForeColor = Color.Black
            ca.Padding = New Padding(0)
            AddHandler ca.Click, AddressOf q61
            AddHandler ca.MouseHover, AddressOf q62
            ot.DropDownItems.Insert(2, ca)
            Dim eb As New ToolStripMenuItem
            eb.Text = "Export Bookmarks"
            eb.Image = My.Resources.F9
            eb.BackColor = Color.White
            eb.ForeColor = Color.Black
            eb.Padding = New Padding(0)
            AddHandler eb.Click, AddressOf q63
            AddHandler eb.MouseHover, AddressOf q64
            bo.DropDownItems.Insert(4, eb)
            Dim ib As New ToolStripMenuItem
            ib.Text = "Import Bookmarks"
            ib.Image = My.Resources.F9
            ib.BackColor = Color.White
            ib.ForeColor = Color.Black
            ib.Padding = New Padding(0)
            AddHandler ib.Click, AddressOf q65
            AddHandler ib.MouseHover, AddressOf q66
            bo.DropDownItems.Insert(5, ib)
            Dim sbm As New ToolStripMenuItem
            sbm.Text = "Sort Bookmarks"
            sbm.Image = My.Resources.F9
            sbm.BackColor = Color.White
            sbm.ForeColor = Color.Black
            sbm.Padding = New Padding(0)
            AddHandler sbm.Click, AddressOf q67
            AddHandler sbm.MouseHover, AddressOf q68
            bo.DropDownItems.Insert(6, sbm)
            Dim cat As New ToolStripMenuItem
            cat.Text = "Copy All Tab Links"
            cat.Image = My.Resources.F9
            cat.BackColor = Color.White
            cat.ForeColor = Color.Black
            cat.Padding = New Padding(0)
            AddHandler cat.Click, AddressOf q69
            AddHandler cat.MouseHover, AddressOf q70
            Me.e.DropDownItems.Insert(5, cat)
            Dim cdt As New ToolStripMenuItem
            cdt.Text = "Close Duplicate Tabs"
            cdt.Image = My.Resources.F9
            cdt.BackColor = Color.White
            cdt.ForeColor = Color.Black
            cdt.Padding = New Padding(0)
            AddHandler cdt.Click, AddressOf q71
            AddHandler cdt.MouseHover, AddressOf q72
            fl.DropDownItems.Insert(12, cdt)
            Dim cttl As New ToolStripMenuItem
            cttl.Text = "Copy All Tab Titles And Links"
            cttl.Image = My.Resources.F9
            cttl.BackColor = Color.White
            cttl.ForeColor = Color.Black
            cttl.Padding = New Padding(0)
            AddHandler cttl.Click, AddressOf q73
            AddHandler cttl.MouseHover, AddressOf q74
            Me.e.DropDownItems.Insert(6, cttl)
            Dim stb As New ToolStripMenuItem
            stb.Text = "Sort Tabs By Title"
            stb.Image = My.Resources.F9
            stb.BackColor = Color.White
            stb.ForeColor = Color.Black
            stb.Padding = New Padding(0)
            AddHandler stb.Click, AddressOf q75
            AddHandler stb.MouseHover, AddressOf q76
            hi.DropDownItems.Insert(8, stb)
            Dim ssx As New ToolStripMenuItem
            ssx.Text = "Search Selected Text"
            ssx.Image = My.Resources.F9
            ssx.BackColor = Color.White
            ssx.ForeColor = Color.Black
            ssx.Padding = New Padding(0)
            AddHandler ssx.Click, AddressOf q77
            AddHandler ssx.MouseHover, AddressOf q78
            Me.e.DropDownItems.Insert(7, ssx)
            Dim daw As New ToolStripMenuItem
            daw.Text = "Duplicate All Tabs To New Window"
            daw.Image = My.Resources.F9
            daw.BackColor = Color.White
            daw.ForeColor = Color.Black
            daw.Padding = New Padding(0)
            AddHandler daw.Click, AddressOf q79
            AddHandler daw.MouseHover, AddressOf q80
            fl.DropDownItems.Insert(13, daw)
            Dim eh As New ToolStripMenuItem
            eh.Text = "Export History"
            eh.Image = My.Resources.F9
            eh.BackColor = Color.White
            eh.ForeColor = Color.Black
            eh.Padding = New Padding(0)
            AddHandler eh.Click, AddressOf q81
            AddHandler eh.MouseHover, AddressOf q82
            hi.DropDownItems.Insert(9, eh)
            Dim ih As New ToolStripMenuItem
            ih.Text = "Import History"
            ih.Image = My.Resources.F9
            ih.BackColor = Color.White
            ih.ForeColor = Color.Black
            ih.Padding = New Padding(0)
            AddHandler ih.Click, AddressOf q95
            AddHandler ih.MouseHover, AddressOf q96
            hi.DropDownItems.Insert(10, ih)
            Dim oh As New ToolStripMenuItem
            oh.Text = "Open History Items In Tabs"
            oh.Image = My.Resources.F9
            oh.BackColor = Color.White
            oh.ForeColor = Color.Black
            oh.Padding = New Padding(0)
            AddHandler oh.Click, AddressOf q97
            AddHandler oh.MouseHover, AddressOf q98
            hi.DropDownItems.Insert(11, oh)
            Dim sc As New ToolStripMenuItem
            sc.Text = "Startup Restore Session"
            sc.Image = My.Resources.F9
            sc.BackColor = Color.White
            sc.ForeColor = Color.Black
            sc.Padding = New Padding(0)
            AddHandler sc.Click, AddressOf q83
            AddHandler sc.MouseHover, AddressOf q84
            ot.DropDownItems.Insert(3, sc)
            Dim cl As New ToolStripMenuItem
            cl.Text = "Close Tabs Left Of Current"
            cl.Image = My.Resources.F9
            cl.BackColor = Color.White
            cl.ForeColor = Color.Black
            cl.Padding = New Padding(0)
            AddHandler cl.Click, AddressOf q85
            AddHandler cl.MouseHover, AddressOf q86
            fl.DropDownItems.Insert(14, cl)
            Dim spt As New ToolStripMenuItem
            spt.Text = "Save Current Page Text"
            spt.Image = My.Resources.F9
            spt.BackColor = Color.White
            spt.ForeColor = Color.Black
            spt.Padding = New Padding(0)
            AddHandler spt.Click, AddressOf q87
            AddHandler spt.MouseHover, AddressOf q88
            fl.DropDownItems.Insert(15, spt)
            Dim rt As New ToolStripMenuItem
            rt.Text = "Reverse Tab Order"
            rt.Image = My.Resources.F9
            rt.BackColor = Color.White
            rt.ForeColor = Color.Black
            rt.Padding = New Padding(0)
            AddHandler rt.Click, AddressOf q89
            AddHandler rt.MouseHover, AddressOf q90
            hi.DropDownItems.Insert(10, rt)
            Dim cpt As New ToolStripMenuItem
            cpt.Text = "Copy Current Page Text"
            cpt.Image = My.Resources.F9
            cpt.BackColor = Color.White
            cpt.ForeColor = Color.Black
            cpt.Padding = New Padding(0)
            AddHandler cpt.Click, AddressOf q91
            AddHandler cpt.MouseHover, AddressOf q92
            Me.e.DropDownItems.Insert(8, cpt)
            Dim sph As New ToolStripMenuItem
            sph.Text = "Save Current Page HTML"
            sph.Image = My.Resources.F9
            sph.BackColor = Color.White
            sph.ForeColor = Color.Black
            sph.Padding = New Padding(0)
            AddHandler sph.Click, AddressOf q93
            AddHandler sph.MouseHover, AddressOf q94
            fl.DropDownItems.Insert(16, sph)
            Dim cbm As New ToolStripMenuItem
            cbm.Text = "Clear Bookmarks"
            cbm.Image = My.Resources.F9
            cbm.BackColor = Color.White
            cbm.ForeColor = Color.Black
            cbm.Padding = New Padding(0)
            AddHandler cbm.Click, AddressOf q99
            AddHandler cbm.MouseHover, AddressOf q100
            bo.DropDownItems.Insert(7, cbm)
            Dim ohm As New ToolStripMenuItem
            ohm.Text = "Open Homepage In New Tab"
            ohm.Image = My.Resources.F9
            ohm.BackColor = Color.White
            ohm.ForeColor = Color.Black
            ohm.Padding = New Padding(0)
            AddHandler ohm.Click, AddressOf q101
            AddHandler ohm.MouseHover, AddressOf q102
            hi.DropDownItems.Insert(12, ohm)
            Dim chm As New ToolStripMenuItem
            chm.Text = "Copy Homepage Link"
            chm.Image = My.Resources.F9
            chm.BackColor = Color.White
            chm.ForeColor = Color.Black
            chm.Padding = New Padding(0)
            AddHandler chm.Click, AddressOf q103
            AddHandler chm.MouseHover, AddressOf q104
            hi.DropDownItems.Insert(13, chm)
            Dim rhm As New ToolStripMenuItem
            rhm.Text = "Reset Homepage To Default"
            rhm.Image = My.Resources.F9
            rhm.BackColor = Color.White
            rhm.ForeColor = Color.Black
            rhm.Padding = New Padding(0)
            AddHandler rhm.Click, AddressOf q105
            AddHandler rhm.MouseHover, AddressOf q106
            hi.DropDownItems.Insert(14, rhm)
            Dim sws As New ToolStripMenuItem
            sws.Text = "Save Window Snapshot"
            sws.Image = My.Resources.F9
            sws.BackColor = Color.White
            sws.ForeColor = Color.Black
            sws.Padding = New Padding(0)
            AddHandler sws.Click, AddressOf q107
            AddHandler sws.MouseHover, AddressOf q108
            fl.DropDownItems.Insert(17, sws)
            Dim csh As New ToolStripMenuItem
            csh.Text = "Clear Session And History"
            csh.Image = My.Resources.F9
            csh.BackColor = Color.White
            csh.ForeColor = Color.Black
            csh.Padding = New Padding(0)
            AddHandler csh.Click, AddressOf q109
            AddHandler csh.MouseHover, AddressOf q110
            ot.DropDownItems.Insert(4, csh)
            Dim cdm As New ToolStripMenuItem
            cdm.Text = "Copy Current Domain"
            cdm.Image = My.Resources.F9
            cdm.BackColor = Color.White
            cdm.ForeColor = Color.Black
            cdm.Padding = New Padding(0)
            AddHandler cdm.Click, AddressOf q111
            AddHandler cdm.MouseHover, AddressOf q112
            Me.e.DropDownItems.Insert(9, cdm)
            Dim ptf As New ToolStripMenuItem
            ptf.Text = "Pin Current Tab As First"
            ptf.Image = My.Resources.F9
            ptf.BackColor = Color.White
            ptf.ForeColor = Color.Black
            ptf.Padding = New Padding(0)
            AddHandler ptf.Click, AddressOf q113
            AddHandler ptf.MouseHover, AddressOf q114
            hi.DropDownItems.Insert(15, ptf)
            Dim ohd As New ToolStripMenuItem
            ohd.Text = "Open Homepage In Default Browser"
            ohd.Image = My.Resources.F9
            ohd.BackColor = Color.White
            ohd.ForeColor = Color.Black
            ohd.Padding = New Padding(0)
            AddHandler ohd.Click, AddressOf q115
            AddHandler ohd.MouseHover, AddressOf q116
            hi.DropDownItems.Insert(16, ohd)
            Dim css As New ToolStripMenuItem
            css.Text = "Copy Session Summary"
            css.Image = My.Resources.F9
            css.BackColor = Color.White
            css.ForeColor = Color.Black
            css.Padding = New Padding(0)
            AddHandler css.Click, AddressOf q117
            AddHandler css.MouseHover, AddressOf q118
            Me.e.DropDownItems.Insert(10, css)
            Dim rdt As New ToolStripMenuItem
            rdt.Text = "Reload Duplicate Tabs Only"
            rdt.Image = My.Resources.F9
            rdt.BackColor = Color.White
            rdt.ForeColor = Color.Black
            rdt.Padding = New Padding(0)
            AddHandler rdt.Click, AddressOf q119
            AddHandler rdt.MouseHover, AddressOf q120
            hi.DropDownItems.Insert(17, rdt)
            Dim cab As New ToolStripMenuItem
            cab.Text = "Copy All Bookmark Links"
            cab.Image = My.Resources.F9
            cab.BackColor = Color.White
            cab.ForeColor = Color.Black
            cab.Padding = New Padding(0)
            AddHandler cab.Click, AddressOf q121
            AddHandler cab.MouseHover, AddressOf q122
            bo.DropDownItems.Insert(8, cab)
            Dim odh As New ToolStripMenuItem
            odh.Text = "Open Current Domain Homepage"
            odh.Image = My.Resources.F9
            odh.BackColor = Color.White
            odh.ForeColor = Color.Black
            odh.Padding = New Padding(0)
            AddHandler odh.Click, AddressOf q123
            AddHandler odh.MouseHover, AddressOf q124
            hi.DropDownItems.Insert(18, odh)
            Dim sbs As New ToolStripMenuItem
            sbs.Text = "Save Bookmark Snapshot"
            sbs.Image = My.Resources.F9
            sbs.BackColor = Color.White
            sbs.ForeColor = Color.Black
            sbs.Padding = New Padding(0)
            AddHandler sbs.Click, AddressOf q125
            AddHandler sbs.MouseHover, AddressOf q126
            bo.DropDownItems.Insert(9, sbs)
            Dim cah As New ToolStripMenuItem
            cah.Text = "Copy All History Links"
            cah.Image = My.Resources.F9
            cah.BackColor = Color.White
            cah.ForeColor = Color.Black
            cah.Padding = New Padding(0)
            AddHandler cah.Click, AddressOf q127
            AddHandler cah.MouseHover, AddressOf q128
            Me.e.DropDownItems.Insert(11, cah)
            Dim shd As New ToolStripMenuItem
            shd.Text = "Set Homepage To Current Domain"
            shd.Image = My.Resources.F9
            shd.BackColor = Color.White
            shd.ForeColor = Color.Black
            shd.Padding = New Padding(0)
            AddHandler shd.Click, AddressOf q129
            AddHandler shd.MouseHover, AddressOf q130
            hi.DropDownItems.Insert(19, shd)
            Dim olf As New ToolStripMenuItem
            olf.Text = "Open Local File Folder"
            olf.Image = My.Resources.F9
            olf.BackColor = Color.White
            olf.ForeColor = Color.Black
            olf.Padding = New Padding(0)
            AddHandler olf.Click, AddressOf q131
            AddHandler olf.MouseHover, AddressOf q132
            fl.DropDownItems.Insert(18, olf)
            Dim bsh As New ToolStripMenuItem
            bsh.Text = "Bookmark Selected History Item"
            bsh.Image = My.Resources.F9
            bsh.BackColor = Color.White
            bsh.ForeColor = Color.Black
            bsh.Padding = New Padding(0)
            AddHandler bsh.Click, AddressOf q133
            AddHandler bsh.MouseHover, AddressOf q134
            bo.DropDownItems.Insert(10, bsh)
            Dim shs As New ToolStripMenuItem
            shs.Text = "Save History Snapshot"
            shs.Image = My.Resources.F9
            shs.BackColor = Color.White
            shs.ForeColor = Color.Black
            shs.Padding = New Padding(0)
            AddHandler shs.Click, AddressOf q135
            AddHandler shs.MouseHover, AddressOf q136
            hi.DropDownItems.Insert(20, shs)
            Dim cad As New ToolStripMenuItem
            cad.Text = "Clear All Browser Data"
            cad.Image = My.Resources.F9
            cad.BackColor = Color.White
            cad.ForeColor = Color.Black
            cad.Padding = New Padding(0)
            AddHandler cad.Click, AddressOf q137
            AddHandler cad.MouseHover, AddressOf q138
            ot.DropDownItems.Insert(5, cad)
            Dim odt As New ToolStripMenuItem
            odt.Text = "Open Current Domain In New Tab"
            odt.Image = My.Resources.F9
            odt.BackColor = Color.White
            odt.ForeColor = Color.Black
            odt.Padding = New Padding(0)
            AddHandler odt.Click, AddressOf q139
            AddHandler odt.MouseHover, AddressOf q140
            hi.DropDownItems.Insert(21, odt)
            Dim sds As New ToolStripMenuItem
            sds.Text = "Save All Browser Data Snapshot"
            sds.Image = My.Resources.F9
            sds.BackColor = Color.White
            sds.ForeColor = Color.Black
            sds.Padding = New Padding(0)
            AddHandler sds.Click, AddressOf q141
            AddHandler sds.MouseHover, AddressOf q142
            fl.DropDownItems.Insert(19, sds)
            Dim bcd As New ToolStripMenuItem
            bcd.Text = "Bookmark Current Domain"
            bcd.Image = My.Resources.F9
            bcd.BackColor = Color.White
            bcd.ForeColor = Color.Black
            bcd.Padding = New Padding(0)
            AddHandler bcd.Click, AddressOf q143
            AddHandler bcd.MouseHover, AddressOf q144
            bo.DropDownItems.Insert(11, bcd)
            Dim rsd As New ToolStripMenuItem
            rsd.Text = "Reload Tabs From Same Domain"
            rsd.Image = My.Resources.F9
            rsd.BackColor = Color.White
            rsd.ForeColor = Color.Black
            rsd.Padding = New Padding(0)
            AddHandler rsd.Click, AddressOf q145
            AddHandler rsd.MouseHover, AddressOf q146
            hi.DropDownItems.Insert(22, rsd)
            Dim csd As New ToolStripMenuItem
            csd.Text = "Copy Tabs From Same Domain"
            csd.Image = My.Resources.F9
            csd.BackColor = Color.White
            csd.ForeColor = Color.Black
            csd.Padding = New Padding(0)
            AddHandler csd.Click, AddressOf q147
            AddHandler csd.MouseHover, AddressOf q148
            Me.e.DropDownItems.Insert(12, csd)
            Dim cls As New ToolStripMenuItem
            cls.Text = "Close Tabs From Same Domain"
            cls.Image = My.Resources.F9
            cls.BackColor = Color.White
            cls.ForeColor = Color.Black
            cls.Padding = New Padding(0)
            AddHandler cls.Click, AddressOf q149
            AddHandler cls.MouseHover, AddressOf q150
            hi.DropDownItems.Insert(23, cls)
            Dim sdn As New ToolStripMenuItem
            sdn.Text = "Save Current Domain Snapshot"
            sdn.Image = My.Resources.F9
            sdn.BackColor = Color.White
            sdn.ForeColor = Color.Black
            sdn.Padding = New Padding(0)
            AddHandler sdn.Click, AddressOf q151
            AddHandler sdn.MouseHover, AddressOf q152
            fl.DropDownItems.Insert(20, sdn)
            Dim oct As New ToolStripMenuItem
            oct.Text = "Open Current URL In New Tab"
            oct.Image = My.Resources.F9
            oct.BackColor = Color.White
            oct.ForeColor = Color.Black
            oct.Padding = New Padding(0)
            AddHandler oct.Click, AddressOf q153
            AddHandler oct.MouseHover, AddressOf q154
            hi.DropDownItems.Insert(24, oct)
            Dim sss As New ToolStripMenuItem
            sss.Text = "Save Search Suggestions Snapshot"
            sss.Image = My.Resources.F9
            sss.BackColor = Color.White
            sss.ForeColor = Color.Black
            sss.Padding = New Padding(0)
            AddHandler sss.Click, AddressOf q155
            AddHandler sss.MouseHover, AddressOf q156
            fl.DropDownItems.Insert(21, sss)
            Dim cps As New ToolStripMenuItem
            cps.Text = "Copy Search Suggestions"
            cps.Image = My.Resources.F9
            cps.BackColor = Color.White
            cps.ForeColor = Color.Black
            cps.Padding = New Padding(0)
            AddHandler cps.Click, AddressOf q157
            AddHandler cps.MouseHover, AddressOf q158
            Me.e.DropDownItems.Insert(13, cps)
            Dim rse As New ToolStripMenuItem
            rse.Text = "Restore Default Search Engine"
            rse.Image = My.Resources.F9
            rse.BackColor = Color.White
            rse.ForeColor = Color.Black
            rse.Padding = New Padding(0)
            AddHandler rse.Click, AddressOf q159
            AddHandler rse.MouseHover, AddressOf q160
            ot.DropDownItems.Insert(6, rse)
            Dim cml As New ToolStripMenuItem
            cml.Text = "Copy Page As Markdown Link"
            cml.Image = My.Resources.F9
            cml.BackColor = Color.White
            cml.ForeColor = Color.Black
            cml.Padding = New Padding(0)
            AddHandler cml.Click, AddressOf q167
            AddHandler cml.MouseHover, AddressOf q168
            Me.e.DropDownItems.Insert(14, cml)
            Dim sth As New ToolStripMenuItem
            sth.Text = "Save Tab Links As HTML"
            sth.Image = My.Resources.F9
            sth.BackColor = Color.White
            sth.ForeColor = Color.Black
            sth.Padding = New Padding(0)
            AddHandler sth.Click, AddressOf q169
            AddHandler sth.MouseHover, AddressOf q170
            fl.DropDownItems.Insert(22, sth)
            Dim bsd As New ToolStripMenuItem
            bsd.Text = "Bookmark Tabs From Same Domain"
            bsd.Image = My.Resources.F9
            bsd.BackColor = Color.White
            bsd.ForeColor = Color.Black
            bsd.Padding = New Padding(0)
            AddHandler bsd.Click, AddressOf q171
            AddHandler bsd.MouseHover, AddressOf q172
            bo.DropDownItems.Insert(12, bsd)
            Dim odb As New ToolStripMenuItem
            odb.Text = "Open Current Domain In Default Browser"
            odb.Image = My.Resources.F9
            odb.BackColor = Color.White
            odb.ForeColor = Color.Black
            odb.Padding = New Padding(0)
            AddHandler odb.Click, AddressOf q173
            AddHandler odb.MouseHover, AddressOf q174
            hi.DropDownItems.Insert(25, odb)
            Dim cbt As New ToolStripMenuItem
            cbt.Text = "Close Blank Tabs"
            cbt.Image = My.Resources.F9
            cbt.BackColor = Color.White
            cbt.ForeColor = Color.Black
            cbt.Padding = New Padding(0)
            AddHandler cbt.Click, AddressOf q175
            AddHandler cbt.MouseHover, AddressOf q176
            fl.DropDownItems.Insert(23, cbt)
            Dim cal As New ToolStripMenuItem
            cal.Text = "Copy All Links On Current Page"
            cal.Image = My.Resources.F9
            cal.BackColor = Color.White
            cal.ForeColor = Color.Black
            cal.Padding = New Padding(0)
            AddHandler cal.Click, AddressOf q177
            AddHandler cal.MouseHover, AddressOf q178
            Me.e.DropDownItems.Insert(15, cal)
            Dim sal As New ToolStripMenuItem
            sal.Text = "Save All Links On Current Page"
            sal.Image = My.Resources.F9
            sal.BackColor = Color.White
            sal.ForeColor = Color.Black
            sal.Padding = New Padding(0)
            AddHandler sal.Click, AddressOf q179
            AddHandler sal.MouseHover, AddressOf q180
            fl.DropDownItems.Insert(24, sal)
            Dim bal As New ToolStripMenuItem
            bal.Text = "Bookmark All Links On Current Page"
            bal.Image = My.Resources.F9
            bal.BackColor = Color.White
            bal.ForeColor = Color.Black
            bal.Padding = New Padding(0)
            AddHandler bal.Click, AddressOf q181
            AddHandler bal.MouseHover, AddressOf q182
            bo.DropDownItems.Insert(13, bal)
            Dim pst As New ToolStripMenuItem
            pst.Text = "Scroll Page To Top"
            pst.Image = My.Resources.F9
            pst.BackColor = Color.White
            pst.ForeColor = Color.Black
            pst.Padding = New Padding(0)
            AddHandler pst.Click, AddressOf q183
            AddHandler pst.MouseHover, AddressOf q184
            v.DropDownItems.Insert(4, pst)
            Dim psb As New ToolStripMenuItem
            psb.Text = "Scroll Page To Bottom"
            psb.Image = My.Resources.F9
            psb.BackColor = Color.White
            psb.ForeColor = Color.Black
            psb.Padding = New Padding(0)
            AddHandler psb.Click, AddressOf q185
            AddHandler psb.MouseHover, AddressOf q186
            v.DropDownItems.Insert(5, psb)
            Dim cpi As New ToolStripMenuItem
            cpi.Text = "Copy Page Image Links"
            cpi.Image = My.Resources.F9
            cpi.BackColor = Color.White
            cpi.ForeColor = Color.Black
            cpi.Padding = New Padding(0)
            AddHandler cpi.Click, AddressOf q187
            AddHandler cpi.MouseHover, AddressOf q188
            Me.e.DropDownItems.Insert(16, cpi)
            Dim spi As New ToolStripMenuItem
            spi.Text = "Save Page Image Links"
            spi.Image = My.Resources.F9
            spi.BackColor = Color.White
            spi.ForeColor = Color.Black
            spi.Padding = New Padding(0)
            AddHandler spi.Click, AddressOf q189
            AddHandler spi.MouseHover, AddressOf q190
            fl.DropDownItems.Insert(25, spi)
            Dim cph As New ToolStripMenuItem
            cph.Text = "Copy Current Page HTML"
            cph.Image = My.Resources.F9
            cph.BackColor = Color.White
            cph.ForeColor = Color.Black
            cph.Padding = New Padding(0)
            AddHandler cph.Click, AddressOf q191
            AddHandler cph.MouseHover, AddressOf q192
            Me.e.DropDownItems.Insert(17, cph)
            Dim cpm As New ToolStripMenuItem
            cpm.Text = "Copy Page Metadata"
            cpm.Image = My.Resources.F9
            cpm.BackColor = Color.White
            cpm.ForeColor = Color.Black
            cpm.Padding = New Padding(0)
            AddHandler cpm.Click, AddressOf q193
            AddHandler cpm.MouseHover, AddressOf q194
            Me.e.DropDownItems.Insert(18, cpm)
            Dim osd As New ToolStripMenuItem
            osd.Text = "Open Same-Domain Page Links"
            osd.Image = My.Resources.F9
            osd.BackColor = Color.White
            osd.ForeColor = Color.Black
            osd.Padding = New Padding(0)
            AddHandler osd.Click, AddressOf q195
            AddHandler osd.MouseHover, AddressOf q196
            hi.DropDownItems.Insert(26, osd)
            Dim cspl As New ToolStripMenuItem
            cspl.Text = "Copy Same-Domain Page Links"
            cspl.Image = My.Resources.F9
            cspl.BackColor = Color.White
            cspl.ForeColor = Color.Black
            cspl.Padding = New Padding(0)
            AddHandler cspl.Click, AddressOf q197
            AddHandler cspl.MouseHover, AddressOf q198
            Me.e.DropDownItems.Insert(19, cspl)
            Dim sspl As New ToolStripMenuItem
            sspl.Text = "Save Same-Domain Page Links"
            sspl.Image = My.Resources.F9
            sspl.BackColor = Color.White
            sspl.ForeColor = Color.Black
            sspl.Padding = New Padding(0)
            AddHandler sspl.Click, AddressOf q199
            AddHandler sspl.MouseHover, AddressOf q200
            fl.DropDownItems.Insert(26, sspl)
            Dim oit As New ToolStripMenuItem
            oit.Text = "Open Page Image Links In Tabs"
            oit.Image = My.Resources.F9
            oit.BackColor = Color.White
            oit.ForeColor = Color.Black
            oit.Padding = New Padding(0)
            AddHandler oit.Click, AddressOf q201
            AddHandler oit.MouseHover, AddressOf q202
            hi.DropDownItems.Insert(27, oit)
            Dim cts As New ToolStripMenuItem
            cts.Text = "Copy Tab Summary"
            cts.Image = My.Resources.F9
            cts.BackColor = Color.White
            cts.ForeColor = Color.Black
            cts.Padding = New Padding(0)
            AddHandler cts.Click, AddressOf q203
            AddHandler cts.MouseHover, AddressOf q204
            Me.e.DropDownItems.Insert(20, cts)
            Dim spm As New ToolStripMenuItem
            spm.Text = "Save Page Metadata"
            spm.Image = My.Resources.F9
            spm.BackColor = Color.White
            spm.ForeColor = Color.Black
            spm.Padding = New Padding(0)
            AddHandler spm.Click, AddressOf q205
            AddHandler spm.MouseHover, AddressOf q206
            fl.DropDownItems.Insert(27, spm)
            Dim oat As New ToolStripMenuItem
            oat.Text = "Open All Tabs In Default Browser"
            oat.Image = My.Resources.F9
            oat.BackColor = Color.White
            oat.ForeColor = Color.Black
            oat.Padding = New Padding(0)
            AddHandler oat.Click, AddressOf q207
            AddHandler oat.MouseHover, AddressOf q208
            fl.DropDownItems.Insert(28, oat)
            Dim stc As New ToolStripMenuItem
            stc.Text = "Save All Tabs As CSV"
            stc.Image = My.Resources.F9
            stc.BackColor = Color.White
            stc.ForeColor = Color.Black
            stc.Padding = New Padding(0)
            AddHandler stc.Click, AddressOf q209
            AddHandler stc.MouseHover, AddressOf q210
            fl.DropDownItems.Insert(29, stc)
            Dim cbs As New ToolStripMenuItem
            cbs.Text = "Copy Bookmark Summary"
            cbs.Image = My.Resources.F9
            cbs.BackColor = Color.White
            cbs.ForeColor = Color.Black
            cbs.Padding = New Padding(0)
            AddHandler cbs.Click, AddressOf q211
            AddHandler cbs.MouseHover, AddressOf q212
            Me.e.DropDownItems.Insert(21, cbs)
            Dim orb As New ToolStripMenuItem
            orb.Text = "Open Random Bookmark"
            orb.Image = My.Resources.F9
            orb.BackColor = Color.White
            orb.ForeColor = Color.Black
            orb.Padding = New Padding(0)
            AddHandler orb.Click, AddressOf q213
            AddHandler orb.MouseHover, AddressOf q214
            bo.DropDownItems.Insert(14, orb)
            Dim ctp As New ToolStripMenuItem
            ctp.Text = "Copy Page Text Preview"
            ctp.Image = My.Resources.F9
            ctp.BackColor = Color.White
            ctp.ForeColor = Color.Black
            ctp.Padding = New Padding(0)
            AddHandler ctp.Click, AddressOf q215
            AddHandler ctp.MouseHover, AddressOf q216
            Me.e.DropDownItems.Insert(22, ctp)
            Dim stp As New ToolStripMenuItem
            stp.Text = "Save Page Text Preview"
            stp.Image = My.Resources.F9
            stp.BackColor = Color.White
            stp.ForeColor = Color.Black
            stp.Padding = New Padding(0)
            AddHandler stp.Click, AddressOf q217
            AddHandler stp.MouseHover, AddressOf q218
            fl.DropDownItems.Insert(30, stp)
            Dim hrf As New ToolStripMenuItem
            hrf.Text = "Hard Refresh Current Tab"
            hrf.Image = My.Resources.F9
            hrf.BackColor = Color.White
            hrf.ForeColor = Color.Black
            hrf.Padding = New Padding(0)
            AddHandler hrf.Click, AddressOf q219
            AddHandler hrf.MouseHover, AddressOf q220
            v.DropDownItems.Insert(6, hrf)
            Dim ctm As New ToolStripMenuItem
            ctm.Text = "Copy All Tabs As Markdown"
            ctm.Image = My.Resources.F9
            ctm.BackColor = Color.White
            ctm.ForeColor = Color.Black
            ctm.Padding = New Padding(0)
            AddHandler ctm.Click, AddressOf q221
            AddHandler ctm.MouseHover, AddressOf q222
            Me.e.DropDownItems.Insert(23, ctm)
            Dim sbh As New ToolStripMenuItem
            sbh.Text = "Save Bookmarks As HTML"
            sbh.Image = My.Resources.F9
            sbh.BackColor = Color.White
            sbh.ForeColor = Color.Black
            sbh.Padding = New Padding(0)
            AddHandler sbh.Click, AddressOf q223
            AddHandler sbh.MouseHover, AddressOf q224
            fl.DropDownItems.Insert(31, sbh)
            Dim chs As New ToolStripMenuItem
            chs.Text = "Copy History Summary"
            chs.Image = My.Resources.F9
            chs.BackColor = Color.White
            chs.ForeColor = Color.Black
            chs.Padding = New Padding(0)
            AddHandler chs.Click, AddressOf q225
            AddHandler chs.MouseHover, AddressOf q226
            Me.e.DropDownItems.Insert(24, chs)
            Dim std As New ToolStripMenuItem
            std.Text = "Search Current Domain"
            std.Image = My.Resources.F9
            std.BackColor = Color.White
            std.ForeColor = Color.Black
            std.Padding = New Padding(0)
            AddHandler std.Click, AddressOf q227
            AddHandler std.MouseHover, AddressOf q228
            hi.DropDownItems.Insert(28, std)
            Dim vat As New ToolStripMenuItem
            vat.Text = "View Current Page Source In New Tab"
            vat.Image = My.Resources.F9
            vat.BackColor = Color.White
            vat.ForeColor = Color.Black
            vat.Padding = New Padding(0)
            AddHandler vat.Click, AddressOf q229
            AddHandler vat.MouseHover, AddressOf q230
            hi.DropDownItems.Insert(29, vat)
            Dim cdh As New ToolStripMenuItem
            cdh.Text = "Remove Duplicate History Items"
            cdh.Image = My.Resources.F9
            cdh.BackColor = Color.White
            cdh.ForeColor = Color.Black
            cdh.Padding = New Padding(0)
            AddHandler cdh.Click, AddressOf q231
            AddHandler cdh.MouseHover, AddressOf q232
            hi.DropDownItems.Insert(30, cdh)
            Dim stm As New ToolStripMenuItem
            stm.Text = "Save All Tabs As Markdown"
            stm.Image = My.Resources.F9
            stm.BackColor = Color.White
            stm.ForeColor = Color.Black
            stm.Padding = New Padding(0)
            AddHandler stm.Click, AddressOf q233
            AddHandler stm.MouseHover, AddressOf q234
            fl.DropDownItems.Insert(32, stm)
            Dim hth As New ToolStripMenuItem
            hth.Text = "Save History As HTML"
            hth.Image = My.Resources.F9
            hth.BackColor = Color.White
            hth.ForeColor = Color.Black
            hth.Padding = New Padding(0)
            AddHandler hth.Click, AddressOf q235
            AddHandler hth.MouseHover, AddressOf q236
            fl.DropDownItems.Insert(33, hth)
            Dim plh As New ToolStripMenuItem
            plh.Text = "Copy Page Links As HTML"
            plh.Image = My.Resources.F9
            plh.BackColor = Color.White
            plh.ForeColor = Color.Black
            plh.Padding = New Padding(0)
            AddHandler plh.Click, AddressOf q237
            AddHandler plh.MouseHover, AddressOf q238
            Me.e.DropDownItems.Insert(25, plh)
            Dim ocl As New ToolStripMenuItem
            ocl.Text = "Open Clipboard Link In New Tab"
            ocl.Image = My.Resources.F9
            ocl.BackColor = Color.White
            ocl.ForeColor = Color.Black
            ocl.Padding = New Padding(0)
            AddHandler ocl.Click, AddressOf q239
            AddHandler ocl.MouseHover, AddressOf q240
            hi.DropDownItems.Insert(31, ocl)
            Dim sot As New ToolStripMenuItem
            sot.Text = "Search Open Tabs"
            sot.Image = My.Resources.F9
            sot.BackColor = Color.White
            sot.ForeColor = Color.Black
            sot.Padding = New Padding(0)
            AddHandler sot.Click, AddressOf q241
            AddHandler sot.MouseHover, AddressOf q242
            hi.DropDownItems.Insert(32, sot)
            Dim ctd As New ToolStripMenuItem
            ctd.Text = "Copy Open Tab Domains"
            ctd.Image = My.Resources.F9
            ctd.BackColor = Color.White
            ctd.ForeColor = Color.Black
            ctd.Padding = New Padding(0)
            AddHandler ctd.Click, AddressOf q243
            AddHandler ctd.MouseHover, AddressOf q244
            Me.e.DropDownItems.Insert(26, ctd)
            Dim plm As New ToolStripMenuItem
            plm.Text = "Copy Page Links As Markdown"
            plm.Image = My.Resources.F9
            plm.BackColor = Color.White
            plm.ForeColor = Color.Black
            plm.Padding = New Padding(0)
            AddHandler plm.Click, AddressOf q245
            AddHandler plm.MouseHover, AddressOf q246
            Me.e.DropDownItems.Insert(27, plm)
            Dim pim As New ToolStripMenuItem
            pim.Text = "Copy Page Images As Markdown"
            pim.Image = My.Resources.F9
            pim.BackColor = Color.White
            pim.ForeColor = Color.Black
            pim.Padding = New Padding(0)
            AddHandler pim.Click, AddressOf q247
            AddHandler pim.MouseHover, AddressOf q248
            Me.e.DropDownItems.Insert(28, pim)
            Dim sdc As New ToolStripMenuItem
            sdc.Text = "Save Open Tab Domains As CSV"
            sdc.Image = My.Resources.F9
            sdc.BackColor = Color.White
            sdc.ForeColor = Color.Black
            sdc.Padding = New Padding(0)
            AddHandler sdc.Click, AddressOf q249
            AddHandler sdc.MouseHover, AddressOf q250
            fl.DropDownItems.Insert(34, sdc)
            Dim rsn As New ToolStripMenuItem
            rsn.Text = "Reopen Saved Session In New Window"
            rsn.Image = My.Resources.F9
            rsn.BackColor = Color.White
            rsn.ForeColor = Color.Black
            rsn.Padding = New Padding(0)
            AddHandler rsn.Click, AddressOf q251
            AddHandler rsn.MouseHover, AddressOf q252
            fl.DropDownItems.Insert(35, rsn)
            Dim ctt As New ToolStripMenuItem
            ctt.Text = "Close Tabs Matching Text"
            ctt.Image = My.Resources.F9
            ctt.BackColor = Color.White
            ctt.ForeColor = Color.Black
            ctt.Padding = New Padding(0)
            AddHandler ctt.Click, AddressOf q253
            AddHandler ctt.MouseHover, AddressOf q254
            hi.DropDownItems.Insert(33, ctt)
            Dim bcl As New ToolStripMenuItem
            bcl.Text = "Bookmark Clipboard Link"
            bcl.Image = My.Resources.F9
            bcl.BackColor = Color.White
            bcl.ForeColor = Color.Black
            bcl.Padding = New Padding(0)
            AddHandler bcl.Click, AddressOf q255
            AddHandler bcl.MouseHover, AddressOf q256
            bo.DropDownItems.Insert(15, bcl)
            Dim B As New WebBrowser
            k.TabPages.Add("New Page")
            B.Dock = DockStyle.Fill
            k.SelectedTab.Controls.Add(B)
            AddHandler B.Navigating, AddressOf nn
            AddHandler B.Navigated, AddressOf nv
            AddHandler B.DocumentCompleted, AddressOf n0
            AddHandler B.ProgressChanged, AddressOf q14
            I = I + 1
            If My.Settings.rs = "e" And My.Settings.ls.Count > 0 Then
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.ls.Item(0))
                For q As Integer = 1 To My.Settings.ls.Count - 1
                    q3(My.Settings.ls.Item(q))
                Next q
            Else
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.h)
            End If
            Dim tz As Size = k.ItemSize
            tz.Width = 240
            tz.Height += 3
            k.ItemSize = tz
            If My.Settings.si = "" Then
                F4.HSB1.Value = 1
                si.Visible = False
                T1.Visible = False
                c.Size = New Size(CInt(Size.Width * 0.69), c.Size.Width)
                F4.O2.ForeColor = Color.Black
                F4.O1.ForeColor = Color.White
                F4.F1.Text = "Turn Siera On"
            Else
                c.Size = New Size(CInt(Size.Width * 0.659), c.Size.Width)
            End If
            g.Enabled = False
        Catch ex As Exception
        End Try
    End Sub
    Sub ki(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles k.DrawItem
        Dim z5 As TabPage = k.TabPages(e.Index)
        Dim z6 As Rectangle = k.GetTabRect(e.Index)
        Dim z7 As New SolidBrush(Color.Black)
        Dim z8 As New SolidBrush(Color.Black)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        If CBool(e.State And DrawItemState.Selected) Then
            z7.Color = Color.Black
            z8.Color = Color.Black
            z6.Inflate(1, 1)
        End If
        If k.Alignment = TabAlignment.Left Or k.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If k.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(CSng(z6.Left + (z6.Width / 2)), z6.Top + (z6.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            z6 = New Rectangle(-(z6.Height \ 2), -(z6.Width \ 2), z6.Height, z6.Width)
        End If
        Dim v1 As Rectangle = k.GetTabRect(e.Index)
        Dim z9 As New RectangleF(
            v1.Left + tm,
            v1.Y + tm,
            v1.Width - 4 * tm,
            v1.Height - 2 * tm)
        Dim v2 As New StringFormat
        e.Graphics.DrawImage(My.Resources.F2, z6)
        Dim v3 As New Font(Font, FontStyle.Bold)
        v2.Alignment = StringAlignment.Center
        v2.LineAlignment = StringAlignment.Center
        e.Graphics.DrawString(
            k.TabPages(e.Index).Text,
            v3,
            z7,
            z9,
            v2)
        e.Graphics.DrawImage(My.Resources.FX, z9.Right - mx - -1, z9.Top + mx - 5, 8, 8)
        e.Graphics.ResetTransform()
        z7.Dispose()
        z8.Dispose()
    End Sub
    Sub kd(ByVal sender As Object, ByVal e As MouseEventArgs) Handles k.MouseDown
        Try
            For s As Integer = 0 To k.TabPages.Count - 1
                k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
                Text = ProductName & " - " & k.SelectedTab.Text
                c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
                If CType(k.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack Then
                    b.Enabled = True
                    BT.Enabled = True
                Else
                    b.Enabled = False
                    BT.Enabled = False
                End If
                If CType(k.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward Then
                    f.Enabled = True
                    FT.Enabled = True
                Else
                    f.Enabled = False
                    FT.Enabled = False
                End If
                LO.Size = New Size(1, 2)
                Dim v1 As Rectangle = k.GetTabRect(s)
                Dim z9 As New RectangleF(
                    v1.Left + tm,
                    v1.Y + tm,
                    v1.Width - 4 * tm,
                    v1.Height - 4 * tm)
                If e.X >= z9.Right - mx AndAlso
                   e.X <= z9.Right AndAlso
                   e.Y >= z9.Top AndAlso
                   e.Y <= z9.Top + mx _
                Then
                    If k.TabCount = 1 = False Then
                        Debug.WriteLine("Tab" & s)
                        rca(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                        k.TabPages.RemoveAt(k.SelectedIndex)
                        I = I - 1
                        Dim tz As Size = k.ItemSize
                        tz.Width += 6
                        k.ItemSize = tz
                        k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
                        Text = ProductName & " - " & k.SelectedTab.Text
                        c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
                        If CType(k.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack Then
                            b.Enabled = True
                            BT.Enabled = True
                        Else
                            b.Enabled = False
                            BT.Enabled = False
                        End If
                        If CType(k.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward Then
                            f.Enabled = True
                            FT.Enabled = True
                        Else
                            f.Enabled = False
                            FT.Enabled = False
                        End If
                        Exit Sub
                    Else
                        Close()
                        Exit Sub
                    End If
                End If
            Next s
            Dim pt As Point = New Point(e.X, e.Y)
            Dim tp As TabPage = z4(pt)
            If Not tp Is Nothing Then
                DoDragDrop(tp, DragDropEffects.All)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub nv(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs)
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True
        On Error Resume Next
        LO.Size = New Size(1, 2)
        r.Image = My.Resources.F8
        k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        Text = ProductName & " - " & k.SelectedTab.Text
        c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        If My.Settings.b0 = "e" And pv = False Then
            f6.l0.Items.Add(c.Text)
            c.Items.Add(c.Text)
        ElseIf My.Settings.b0 = "f" Then
        End If
        If CType(k.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack Then
            b.Enabled = True
            BT.Enabled = True
        Else
            b.Enabled = False
            BT.Enabled = False
        End If
        If CType(k.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward Then
            f.Enabled = True
            FT.Enabled = True
        Else
            f.Enabled = False
            FT.Enabled = False
        End If
        g.Enabled = False
    End Sub
    Sub nn(ByVal sender As Object, ByVal e As WebBrowserNavigatingEventArgs)
        If wo = True Then
            e.Cancel = True
            su.Visible = True
            su.Text = "Work offline - navigation blocked"
            Exit Sub
        End If
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True
        On Error Resume Next
        Text = ProductName & " Loading..."
        k.SelectedTab.Text = "Please Wait..."
        LO.Size = New Size(Size.Width, 2)
        r.Image = My.Resources.F7
        su.Visible = True
        g.Enabled = False
    End Sub
    Sub pk(ByVal sender As System.Object, ByVal e As EventArgs) Handles PI.Click
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub
    Sub zk(ByVal sender As System.Object, ByVal e As EventArgs) Handles zx.Click
        Try
            Dim B As New WebBrowser
            k.TabPages.Add("New Tab")
            k.SelectTab(I)
            B.Dock = DockStyle.Fill
            k.SelectedTab.Controls.Add(B)
            AddHandler B.Navigating, AddressOf nn
            AddHandler B.Navigated, AddressOf nv
            AddHandler B.DocumentCompleted, AddressOf n0
            AddHandler B.ProgressChanged, AddressOf q14
            I = I + 1
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.h)
            Dim tz As Size = k.ItemSize
            If I <= 20 Then
                tz.Width -= 6
            ElseIf I >= 30 Then
                tz.Width += 8
            End If
            k.ItemSize = tz
        Catch ex As Exception
        End Try
    End Sub
    Sub zh(ByVal sender As Object, ByVal e As EventArgs) Handles zx.MouseHover
        If My.Settings.t = "e" Then
            Try
                Dim B As New WebBrowser
                k.TabPages.Add("New Tab")
                k.SelectTab(I)
                B.Dock = DockStyle.Fill
                k.SelectedTab.Controls.Add(B)
                AddHandler B.Navigating, AddressOf nn
                AddHandler B.Navigated, AddressOf nv
                AddHandler B.DocumentCompleted, AddressOf n0
                AddHandler B.ProgressChanged, AddressOf q14
                I = I + 1
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.h)
                Dim tz As Size = k.ItemSize
                If I <= 20 Then
                    tz.Width -= 6
                ElseIf I >= 30 Then
                    tz.Width += 8
                End If
                k.ItemSize = tz
            Catch ex As Exception
            End Try
        End If
    End Sub
    Function z4(ByVal pt As Point) As TabPage
        Dim tp As TabPage = Nothing
        For i As Integer = 0 To k.TabPages.Count - 1
            If k.GetTabRect(i).Contains(pt) Then
                tp = k.TabPages(i)
                Exit For
            End If
        Next i
        Return tp
    End Function
    Function z3(ByVal page As TabPage) As Integer
        For i As Integer = 0 To k.TabPages.Count - 1
            If k.TabPages(i) Is page Then
                Return i
            End If
        Next i
        Return -1
    End Function
    Sub l2(ByVal sender As Object, ByVal e As DragEventArgs) Handles k.DragOver
        Dim pt As New Point(e.X, e.Y)
        pt = k.PointToClient(pt)
        Dim ht1 As TabPage = z4(pt)
        If Not ht1 Is Nothing Then
            If e.Data.GetDataPresent(GetType(TabPage)) Then
                e.Effect = DragDropEffects.Link
                Dim dt As TabPage = CType(e.Data.GetData(GetType(TabPage)), TabPage)
                Dim idi As Integer = z3(dt)
                Dim dli As Integer = z3(ht1)
                If idi <> dli Then
                    Dim pages As New ArrayList()
                    For i As Integer = 0 To k.TabPages.Count - 1
                        If i <> idi Then
                            pages.Add(k.TabPages(i))
                        End If
                    Next i
                    pages.Insert(dli, dt)
                    k.TabPages.Clear()
                    k.TabPages.AddRange(CType(pages.ToArray(GetType(TabPage)), TabPage()))
                    k.SelectedTab = dt
                End If
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Sub j2(ByVal sender As System.Object, ByVal e As EventArgs) Handles y2.Click
        If TopMost = False Then
            m.Visible = False
            k.Dock = DockStyle.Fill
            TopMost = True
            WindowState = FormWindowState.Normal
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Maximized
            ShowIcon = False
            y2.Image = My.Resources.O0
            q.AutoSize = True
        Else
            m.Visible = True
            k.Dock = DockStyle.None
            TopMost = False
            FormBorderStyle = FormBorderStyle.Sizable
            WindowState = FormWindowState.Maximized
            ShowIcon = False
            y2.Image = My.Resources.F1
        End If
    End Sub
    Sub j3(ByVal sender As Object, ByVal e As EventArgs) Handles y2.MouseHover
        If My.Settings.t = "e" Then
            If TopMost = False Then
                m.Visible = False
                k.Dock = DockStyle.Fill
                TopMost = True
                WindowState = FormWindowState.Normal
                FormBorderStyle = FormBorderStyle.None
                WindowState = FormWindowState.Maximized
                ShowIcon = False
                y2.Image = My.Resources.O0
                q.AutoSize = True
            Else
                m.Visible = True
                k.Dock = DockStyle.None
                TopMost = False
                FormBorderStyle = FormBorderStyle.Sizable
                WindowState = FormWindowState.Maximized
                ShowIcon = False
                y2.Image = My.Resources.F1
            End If
        End If
    End Sub
    Sub j4(ByVal sender As Object, ByVal e As EventArgs) Handles m.MouseHover
        If My.Settings.t = "e" Then
            If m Is DropDown Then
                m.DropDown.Hide()
            Else
                m.DropDown.Show()
            End If
        End If
    End Sub
    Sub j5(ByVal sender As System.Object, ByVal e As EventArgs) Handles si.Click
        If T1.Text = "" Then
            c.Size = New Size(CInt(Size.Width * 0.61), c.Size.Width)
            T1.Text = "Listening..."
            My.Computer.Audio.Play(My.Resources.sr, AudioPlayMode.Background)
            si.Image = My.Resources.O1
            y1.Start()
        Else
            c.Size = New Size(CInt(Size.Width * 0.659), c.Size.Width)
            T1.Text = "Looking"
            My.Computer.Audio.Play(My.Resources.so, AudioPlayMode.Background)
            si.Image = My.Resources.F0
            y1.Stop()
            z1.Speak("Looking")
            ls()
        End If
    End Sub
    Sub j6(ByVal sender As System.Object, ByVal e As EventArgs) Handles y1.Tick
        c.Size = New Size(CInt(Size.Width * 0.659), c.Size.Width)
        T1.Text = ""
        My.Computer.Audio.Play(My.Resources.so, AudioPlayMode.Background)
        si.Image = My.Resources.F0
        y1.Stop()
        z1.Speak("Looking")
        ls()
    End Sub
    Sub j7(ByVal sender As Object, ByVal e As EventArgs) Handles si.MouseHover
        If My.Settings.t = "e" Then
            If T1.Text = "" Then
                c.Size = New Size(CInt(Size.Width * 0.61), c.Size.Width)
                T1.Text = "Listening..."
                My.Computer.Audio.Play(My.Resources.sr, AudioPlayMode.Background)
                si.Image = My.Resources.O1
                y1.Start()
            Else
                c.Size = New Size(CInt(Size.Width * 0.659), c.Size.Width)
                T1.Text = "Looking"
                My.Computer.Audio.Play(My.Resources.so, AudioPlayMode.Background)
                si.Image = My.Resources.F0
                y1.Stop()
                z1.Speak("Looking")
                ls()
            End If
        End If
    End Sub
    Public Sub ls()
        If c.Text = ("http://www.bing.com/maps/?v=2&cp=44.162140~-77.377258&lvl=12&dir=0&sty=b&where1=Belleville, ON&form=LMLTCC#Y3A9NDQuMTYyMTQwfi03Ny4zNzcyNTgmbHZsPTEyJnN0eT1iJnE9QmVsbGV2aWxsZSUyNTJDJTI1MjBPTg==") Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/maps/?v=2&cp=44.232766~-76.487865&lvl=11&dir=0&sty=b&where1=Kingston, ON&form=LMLTCC&adlt=strict#Y3A9NDQuMjMyNzY2fi03Ni40ODc4NjUmbHZsPTExJnN0eT1iJnE9S2luZ3N0b24lMjUyQyUyNTIwT04=")
            T1.Text = ""
            z1.Speak("Here's Kingston Ontario")
        ElseIf c.Text = ("http://www.bing.com/maps/?v=2&cp=44.232766~-76.487865&lvl=11&dir=0&sty=b&where1=Kingston, ON&form=LMLTCC&adlt=strict#Y3A9NDQuMjMyNzY2fi03Ni40ODc4NjUmbHZsPTExJnN0eT1iJnE9S2luZ3N0b24lMjUyQyUyNTIwT04=") Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.bing.com/maps/?v=2&cp=43.654170~-79.382698&lvl=9&dir=0&sty=b&where1=Toronto, ON&form=LMLTCC#Y3A9NDMuNjU0MTcwfi03OS4zODI2OTgmbHZsPTkmc3R5PWImcT1Ub3JvbnRvJTI1MkMlMjUyME9O")
            T1.Text = ""
            z1.Speak("Here's Toronto Ontario")
        ElseIf c.Text = ("http://www.bing.com/maps/?v=2&cp=43.654170~-79.382698&lvl=9&dir=0&sty=b&where1=Toronto, ON&form=LMLTCC#Y3A9NDMuNjU0MTcwfi03OS4zODI2OTgmbHZsPTkmc3R5PWImcT1Ub3JvbnRvJTI1MkMlMjUyME9O") Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://binged.it/RdYfKM")
            T1.Text = ""
            z1.Speak("Here's Belleville Ontario")
        Else
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://binged.it/RdYfKM")
            T1.Text = ""
            z1.Speak("Here's Belleville Ontario")
        End If
    End Sub
    Sub j8(ByVal sender As System.Object, ByVal e As EventArgs) Handles ti.Tick
        If k.SelectedTab.Text = "(1) Facebook" Then
            My.Computer.Audio.Play(My.Resources.sr, AudioPlayMode.Background)
            si.Image = My.Resources.F2
        End If
    End Sub
    Sub j9(ByVal sender As Object, ByVal e As EventArgs) Handles PI.MouseHover
        If My.Settings.t = "e" Then
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
        End If
    End Sub
    Sub k1(ByVal sender As Object, ByVal e As KeyEventArgs) Handles x.KeyUp
        If x.Text = "" Then
            s.Enabled = False
        ElseIf x.Text = "search" Then
            s.Enabled = False
        Else
            s.Enabled = True
        End If
    End Sub
    Sub cm2(sender As Object, e As EventArgs) Handles x.MouseEnter
        If x.Text = "" Then
            s.Enabled = False
        ElseIf x.Text = "search" Then
            s.Enabled = False
        Else
            s.Enabled = True
        End If
    End Sub
    Sub oi2(ByVal sender As Object, ByVal e As KeyEventArgs) Handles x.SelectedIndexChanged
        If x.Text = "" Then
            s.Enabled = False
        ElseIf x.Text = "search" Then
            s.Enabled = False
        Else
            s.Enabled = True
        End If
    End Sub
    Sub k2(ByVal sender As Object, ByVal e As KeyEventArgs) Handles c.KeyUp
        If c.Text = "" Then
            g.Enabled = False
        Else
            g.Enabled = True
        End If
    End Sub
    Sub cm1(sender As Object, e As EventArgs) Handles c.MouseEnter
        If c.Text = "" Then
            g.Enabled = False
        Else
            g.Enabled = True
        End If
    End Sub
    Sub oi1(ByVal sender As Object, ByVal e As KeyEventArgs) Handles c.SelectedIndexChanged
        If c.Text = "" Then
            g.Enabled = False
        Else
            g.Enabled = True
        End If
    End Sub
    Sub po(ByVal sender As Object, ByVal e As EventArgs) Handles BP.MouseHover
        If My.Settings.t = "e" Then
            Try
                Dim fv As New ToolStripMenuItem
                fv.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
                fv.Tag = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
                fv.Image = My.Resources.F9
                fv.BackgroundImage = My.Resources.F2
                fv.BackgroundImageLayout = ImageLayout.Stretch
                fv.ForeColor = Color.White
                AddHandler fv.MouseHover, AddressOf z2
                RB.DropDownItems.Add(fv)
                My.Settings.bm.Add(fv.Tag.ToString)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub k3(sender As System.Object, e As EventArgs) Handles W.Click
        Try
            wo = Not wo
            su.Visible = True
            If wo = True Then
                su.Text = "Work offline on"
            Else
                su.Text = "Work offline off"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub k4(sender As System.Object, e As EventArgs) Handles SL.Click
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Dim u As String = wb.Url.ToString
            Process.Start("mailto:?subject=" & Uri.EscapeDataString(wb.DocumentTitle) & "&body=" & Uri.EscapeDataString(u))
            su.Visible = True
            su.Text = "Send link opened"
        Catch ex As Exception
        End Try
    End Sub
    Sub k5(sender As System.Object, e As EventArgs) Handles zi.Click
        Try
            Dim doc As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.ScrollRectangle.Size
            doc = Size.Add(CType(doc, Drawing.Size), New Size(50, 50))
            Dim wb As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Size
            Dim factor As String = (Math.Round(Math.Max(wb.Width / doc.Width, wb.Height / doc.Width), 2) * 500).ToString & "%"
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style &= ";zoom:" & factor
        Catch ex As Exception
        End Try
    End Sub
    Sub k6(sender As Object, e As EventArgs) Handles zi.MouseHover
        If My.Settings.t = "e" Then
            Try
                Dim doc As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.ScrollRectangle.Size
                doc = Size.Add(CType(doc, Drawing.Size), New Size(50, 50))
                Dim wb As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Size
                Dim factor As String = (Math.Round(Math.Max(wb.Width / doc.Width, wb.Height / doc.Width), 2) * 500).ToString & "%"
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style &= ";zoom:" & factor
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub k7(sender As System.Object, e As EventArgs) Handles zo.Click
        Try
            Dim doc As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.ScrollRectangle.Size
            doc = Size.Add(CType(doc, Drawing.Size), New Size(150, 150))
            Dim wb As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Size
            Dim factor As String = (Math.Round(Math.Min(wb.Width / doc.Width, wb.Height / doc.Width), 2) * 100).ToString & "%"
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style &= ";zoom:" & factor
        Catch ex As Exception
        End Try
    End Sub
    Sub k8(sender As Object, e As EventArgs) Handles zo.MouseHover
        If My.Settings.t = "e" Then
            Try
                Dim doc As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.ScrollRectangle.Size
                doc = Size.Add(CType(doc, Drawing.Size), New Size(150, 150))
                Dim wb As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Size
                Dim factor As String = (Math.Round(Math.Min(wb.Width / doc.Width, wb.Height / doc.Width), 2) * 100).ToString & "%"
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style &= ";zoom:" & factor
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub k9(sender As System.Object, e As EventArgs) Handles es.Click
        Try
            Dim doc As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.ScrollRectangle.Size
            doc = Size.Add(CType(doc, Drawing.Size), New Size(150, 150))
            Dim wb As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Size
            Dim factor As String = (Math.Round(Math.Max(wb.Width / doc.Width, wb.Height / doc.Width), 2) * 200).ToString & "%"
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style &= ";zoom:" & factor
        Catch ex As Exception
        End Try
    End Sub
    Sub l1(sender As Object, e As EventArgs) Handles es.MouseHover
        If My.Settings.t = "e" Then
            Try
                Dim doc As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.ScrollRectangle.Size
                doc = Size.Add(CType(doc, Drawing.Size), New Size(150, 150))
                Dim wb As Size = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Size
                Dim factor As String = (Math.Round(Math.Max(wb.Width / doc.Width, wb.Height / doc.Width), 2) * 150).ToString & "%"
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style &= ";zoom:" & factor
            Catch ex As Exception
            End Try
        End If
    End Sub
    Public Sub u8(ByVal fn1 As Form)
        Try
            If Screen.PrimaryScreen.WorkingArea.Width() = 800 Then
                fn1.Scale(0.55)
                k.Dock = DockStyle.Fill
            ElseIf Screen.PrimaryScreen.WorkingArea.Width() = 1024 Then
                fn1.Scale(0.77)
                k.Dock = DockStyle.Fill
            ElseIf Screen.PrimaryScreen.WorkingArea.Width() = 1360 Then
                fn1.Scale(1.15)
                k.Dock = DockStyle.Fill
            ElseIf Screen.PrimaryScreen.WorkingArea.Width = 1366 Then
                fn1.Scale(1.02)
                k.Dock = DockStyle.Fill
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub u9(sender As System.Object, e As EventArgs) Handles k.MouseDown
        Try
            If MouseButtons = MouseButtons.Middle Then
                If k.TabCount = 1 = False Then
                    rca(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
                    k.TabPages.RemoveAt(k.SelectedIndex)
                    I = I - 1
                    Dim tz As Size = k.ItemSize
                    tz.Width += 6
                    k.ItemSize = tz
                    k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
                    Text = ProductName & " - " & k.SelectedTab.Text
                    c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
                Else
                    End
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub c0(sender As Object, e As EventArgs) Handles c.Click
        Try
        Catch ex As Exception
        End Try
    End Sub
    Sub n0(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        CType(k.SelectedTab.Controls.Item(0), WebBrowser).ScriptErrorsSuppressed = True
        On Error Resume Next
        LO.Size = New Size(1, 2)
        r.Image = My.Resources.F8
        su.Visible = False
        k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        Text = ProductName & " - " & k.SelectedTab.Text
        c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        g.Enabled = False
    End Sub
    Sub y5(sender As Object, e As EventArgs) Handles y3.Click
        y9.Show()
        Bmp = New Bitmap(y9.Width, y9.Height)
        y9.Image = Bmp
    End Sub
    Sub y4(sender As Object, e As EventArgs) Handles y3.MouseHover
        If My.Settings.t = "e" Then
            y9.Show()
            Bmp = New Bitmap(y9.Width, y9.Height)
            y9.Image = Bmp
        End If
    End Sub
    Sub PaintBrush(X As Integer, Y As Integer)
        Using y5 As Graphics = Graphics.FromImage(y9.Image)
            y5.FillRectangle(New SolidBrush(Dcolo), New Rectangle(X, Y, Dra, Dra))
        End Using
        y9.Refresh()
    End Sub
    Sub y6(sender As Object, e As MouseEventArgs) Handles y9.MouseDown
        Draw = True
        PaintBrush(e.X, e.Y)
    End Sub
    Sub y7(sender As Object, e As MouseEventArgs) Handles y9.MouseMove
        If Draw = True Then
            PaintBrush(e.X, e.Y)
        End If
    End Sub
    Sub y8(sender As Object, e As MouseEventArgs) Handles y9.MouseUp
        Draw = False
    End Sub
    Sub q1(ByVal u As String)
        Try
            If u = "" Then
            ElseIf u.Contains(" ") Or u.Contains(".") = False Then
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.se & Uri.EscapeDataString(u))
            ElseIf u.Contains("://") Or u.StartsWith("about:") Or u.StartsWith("file:") Then
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(u)
            Else
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://" & u)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q2()
        Try
            If x.Text = "" Then
            ElseIf x.Text = "search" Then
            Else
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.se & Uri.EscapeDataString(x.Text))
                x.Items.Add(x.Text)
                My.Settings.s.Add(x.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q3(ByVal u As String)
        Try
            Dim B As New WebBrowser
            k.TabPages.Add("New Tab")
            k.SelectTab(I)
            B.Dock = DockStyle.Fill
            k.SelectedTab.Controls.Add(B)
            AddHandler B.Navigating, AddressOf nn
            AddHandler B.Navigated, AddressOf nv
            AddHandler B.DocumentCompleted, AddressOf n0
            AddHandler B.ProgressChanged, AddressOf q14
            I = I + 1
            q1(u)
            Dim tz As Size = k.ItemSize
            If I <= 20 Then
                tz.Width -= 6
            ElseIf I >= 30 Then
                tz.Width += 8
            End If
            k.ItemSize = tz
        Catch ex As Exception
        End Try
    End Sub
    Sub q4(ByVal sender As Object, ByVal e As EventArgs)
        Try
            q3(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        Catch ex As Exception
        End Try
    End Sub
    Sub q5(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q4(sender, e)
        End If
    End Sub
    Sub q6(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.rc.Count > 0 Then
            q3(My.Settings.rc.Item(0))
            My.Settings.rc.RemoveAt(0)
        ElseIf lu = "" Then
        Else
            q3(lu)
        End If
    End Sub
    Sub q7(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q6(sender, e)
        End If
    End Sub
    Sub q8(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.Control And e.Shift And e.KeyCode = Keys.T Then
                q6(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.C Then
                q20(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.R Then
                q22(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.L Then
                q167(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.B Then
                q171(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.U Then
                q177(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.I Then
                q187(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.S Then
                q203(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.E Then
                q209(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.M Then
                q211(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.D Then
                q227(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.K Then
                q221(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.V Then
                q239(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.F Then
                q241(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.Shift And e.KeyCode = Keys.P Then
                q245(sender, e)
                e.SuppressKeyPress = True
            ElseIf e.Control And e.KeyCode = Keys.L Then
                c.Focus()
                c.SelectAll()
                e.SuppressKeyPress = True
            ElseIf e.Control And e.KeyCode = Keys.T Then
                N.PerformClick()
                e.SuppressKeyPress = True
            ElseIf e.Control And e.KeyCode = Keys.W Then
                CT.PerformClick()
                e.SuppressKeyPress = True
            ElseIf e.Control And e.KeyCode = Keys.R Then
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
                e.SuppressKeyPress = True
            ElseIf e.Control And e.KeyCode = Keys.D Then
                BP.PerformClick()
                e.SuppressKeyPress = True
            ElseIf e.Control And e.KeyCode = Keys.H Then
                f6.Show()
                e.SuppressKeyPress = True
            ElseIf e.Control And e.KeyCode = Keys.B Then
                F7.Show()
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.F5 Then
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
                e.SuppressKeyPress = True
            ElseIf e.Alt And e.KeyCode = Keys.Left Then
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
                e.SuppressKeyPress = True
            ElseIf e.Alt And e.KeyCode = Keys.Right Then
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
                e.SuppressKeyPress = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q9(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If pv = False Then
                My.Settings.ls.Clear()
                For q As Integer = 0 To k.TabPages.Count - 1
                    If k.TabPages(q).Controls.Count > 0 Then
                        Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                        If Not wb.Url Is Nothing Then
                            My.Settings.ls.Add(wb.Url.ToString)
                        End If
                    End If
                Next q
                My.Settings.Save()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q10(ByVal sender As System.Object, ByVal e As EventArgs) Handles FI.Click
        Try
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Find", True, vbNull)
        Catch ex As Exception
        End Try
    End Sub
    Sub q11(ByVal sender As Object, ByVal e As EventArgs)
        Try
            My.Settings.h = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
            My.Settings.Save()
            su.Visible = True
            su.Text = "Home page saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q12(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q11(sender, e)
        End If
    End Sub
    Sub q13(ByVal sender As Object, ByVal e As EventArgs) Handles FI.MouseHover
        If My.Settings.t = "e" Then
            q10(sender, e)
        End If
    End Sub
    Sub q14(ByVal sender As Object, ByVal e As WebBrowserProgressChangedEventArgs)
        Try
            If e.MaximumProgress > 0 And e.CurrentProgress > 0 Then
                Dim sz As Integer = CInt((e.CurrentProgress / e.MaximumProgress) * Size.Width)
                If sz < 1 Then sz = 1
                If sz > Size.Width Then sz = Size.Width
                LO.Size = New Size(sz, 2)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q16(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tp As TabPage = k.SelectedTab
            For q As Integer = k.TabPages.Count - 1 To 0 Step -1
                If k.TabPages(q) Is tp Then
                Else
                    If k.TabPages(q).Controls.Count > 0 Then
                        Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                        If Not wb.Url Is Nothing Then rca(wb.Url.ToString)
                    End If
                    k.TabPages.RemoveAt(q)
                    I = I - 1
                    Dim tz As Size = k.ItemSize
                    tz.Width += 6
                    k.ItemSize = tz
                End If
            Next q
            k.SelectedTab = tp
            k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Text = ProductName & " - " & k.SelectedTab.Text
            c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Catch ex As Exception
        End Try
    End Sub
    Sub q17(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q16(sender, e)
        End If
    End Sub
    Sub q18(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If pv = False Then
                pv = True
                My.Settings.b0 = "f"
                f6.l0.Items.Clear()
                c.Items.Clear()
                su.Visible = True
                su.Text = "Private mode on"
                Text = ProductName & " - Private"
            Else
                pv = False
                My.Settings.b0 = "e"
                su.Visible = True
                su.Text = "Private mode off"
                Text = ProductName & " - " & k.SelectedTab.Text
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q19(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q18(sender, e)
        End If
    End Sub
    Sub q20(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Clipboard.SetText(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            su.Visible = True
            su.Text = "Page link copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q21(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q20(sender, e)
        End If
    End Sub
    Sub q22(ByVal sender As Object, ByVal e As EventArgs)
        Try
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    CType(k.TabPages(q).Controls.Item(0), WebBrowser).Refresh()
                End If
            Next q
        Catch ex As Exception
        End Try
    End Sub
    Sub q23(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q22(sender, e)
        End If
    End Sub
    Sub q24(ByVal sender As Object, ByVal e As EventArgs)
        Try
            tl.DropDownItems.Clear()
            For q As Integer = 0 To k.TabPages.Count - 1
                Dim ti As New ToolStripMenuItem
                ti.Text = k.TabPages(q).Text
                If ti.Text = "" Then ti.Text = "New Tab"
                ti.Tag = k.TabPages(q)
                ti.Image = My.Resources.F9
                ti.BackColor = Color.White
                ti.ForeColor = Color.Black
                ti.Padding = New Padding(0)
                AddHandler ti.Click, AddressOf q25
                AddHandler ti.MouseHover, AddressOf q25
                tl.DropDownItems.Add(ti)
            Next q
        Catch ex As Exception
        End Try
    End Sub
    Sub q25(ByVal sender As ToolStripMenuItem, ByVal e As EventArgs)
        Try
            k.SelectedTab = CType(sender.Tag, TabPage)
            k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Text = ProductName & " - " & k.SelectedTab.Text
            c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Catch ex As Exception
        End Try
    End Sub
    Sub q26(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q24(sender, e)
            tl.DropDown.Show()
        End If
    End Sub
    Sub q27(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            SX.Filter = "PNG Image [*.png*]|*.png|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Screenshot"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Dim bm As New Bitmap(wb.Width, wb.Height)
            Dim pt As Point = wb.PointToScreen(New Point(0, 0))
            Using gr As Graphics = Graphics.FromImage(bm)
                gr.CopyFromScreen(pt, New Point(0, 0), wb.Size)
            End Using
            bm.Save(SX.FileName, Imaging.ImageFormat.Png)
            bm.Dispose()
            su.Visible = True
            su.Text = "Screenshot saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q28(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q27(sender, e)
        End If
    End Sub
    Sub q29(ByVal sender As Object, ByVal e As EventArgs)
        Try
            My.Settings.ls.Clear()
            My.Settings.Save()
            su.Visible = True
            su.Text = "Saved session cleared"
        Catch ex As Exception
        End Try
    End Sub
    Sub q30(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q29(sender, e)
        End If
    End Sub
    Sub q31(ByVal sender As Object, ByVal e As EventArgs)
        Try
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        My.Settings.bm.Add(wb.Url.ToString)
                        Dim fv As New ToolStripMenuItem
                        fv.Text = k.TabPages(q).Text
                        If fv.Text = "" Then fv.Text = wb.Url.ToString
                        fv.Tag = wb.Url.ToString
                        fv.Image = My.Resources.F9
                        fv.BackgroundImage = My.Resources.F2
                        fv.BackgroundImageLayout = ImageLayout.Stretch
                        fv.ForeColor = Color.White
                        AddHandler fv.Click, AddressOf z2
                        AddHandler fv.MouseHover, AddressOf z2
                        RB.DropDownItems.Add(fv)
                    End If
                End If
            Next q
            My.Settings.Save()
            su.Visible = True
            su.Text = "All tabs bookmarked"
        Catch ex As Exception
        End Try
    End Sub
    Sub q32(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q31(sender, e)
        End If
    End Sub
    Sub q33(ByVal sender As Object, ByVal e As EventArgs)
        Try
            For q As Integer = k.TabPages.Count - 1 To k.SelectedIndex + 1 Step -1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then rca(wb.Url.ToString)
                End If
                k.TabPages.RemoveAt(q)
                I = I - 1
                Dim tz As Size = k.ItemSize
                tz.Width += 6
                k.ItemSize = tz
            Next q
            k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Text = ProductName & " - " & k.SelectedTab.Text
            c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Catch ex As Exception
        End Try
    End Sub
    Sub q34(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q33(sender, e)
        End If
    End Sub
    Sub q35(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Dim msg As String = "Title: " & wb.DocumentTitle & vbCrLf &
                "Address: " & wb.Url.ToString & vbCrLf &
                "Status: " & wb.StatusText & vbCrLf &
                "Can Go Back: " & wb.CanGoBack.ToString & vbCrLf &
                "Can Go Forward: " & wb.CanGoForward.ToString
            MessageBox.Show(msg, "Page Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        End Try
    End Sub
    Sub q36(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q35(sender, e)
        End If
    End Sub
    Sub q37(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads")
        Catch ex As Exception
        End Try
    End Sub
    Sub q38(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q37(sender, e)
        End If
    End Sub
    Sub q39(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim f As New j
            f.Show()
            f.q1(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        Catch ex As Exception
        End Try
    End Sub
    Sub q40(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q39(sender, e)
        End If
    End Sub
    Sub q41(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Clipboard.SetText(CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle)
            su.Visible = True
            su.Text = "Page title copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q42(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q41(sender, e)
        End If
    End Sub
    Sub q43(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As New ArrayList
            For q As Integer = 0 To My.Settings.bm.Count - 1
                Dim u As String = My.Settings.bm.Item(q)
                If u = "" Then
                ElseIf ar.Contains(u) Then
                Else
                    ar.Add(u)
                End If
            Next q
            My.Settings.bm.Clear()
            RB.DropDownItems.Clear()
            For q As Integer = 0 To ar.Count - 1
                My.Settings.bm.Add(ar.Item(q).ToString)
                Dim fv As New ToolStripMenuItem
                fv.Text = ar.Item(q).ToString
                fv.Tag = ar.Item(q).ToString
                fv.Image = My.Resources.F9
                fv.BackgroundImage = My.Resources.F2
                fv.BackgroundImageLayout = ImageLayout.Stretch
                fv.ForeColor = Color.White
                AddHandler fv.Click, AddressOf z2
                AddHandler fv.MouseHover, AddressOf z2
                RB.DropDownItems.Add(fv)
            Next q
            My.Settings.Save()
            su.Visible = True
            su.Text = "Duplicate bookmarks removed"
        Catch ex As Exception
        End Try
    End Sub
    Sub q44(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q43(sender, e)
        End If
    End Sub
    Sub q45(ByVal sender As Object, ByVal e As EventArgs)
        Try
            For q As Integer = 0 To My.Settings.bm.Count - 1
                If My.Settings.bm.Item(q) = "" Then
                Else
                    q3(My.Settings.bm.Item(q))
                End If
            Next q
        Catch ex As Exception
        End Try
    End Sub
    Sub q46(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q45(sender, e)
        End If
    End Sub
    Sub q47(ByVal sender As Object, ByVal e As EventArgs)
        Try
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    CType(k.TabPages(q).Controls.Item(0), WebBrowser).Stop()
                End If
            Next q
            LO.Size = New Size(1, 2)
            r.Image = My.Resources.F8
            su.Visible = False
        Catch ex As Exception
        End Try
    End Sub
    Sub q48(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q47(sender, e)
        End If
    End Sub
    Sub q49(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Tabs.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save All Tab Links"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        mySW.WriteLine(wb.Url.ToString)
                    End If
                End If
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Tab links saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q50(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q49(sender, e)
        End If
    End Sub
    Sub q51(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If k.SelectedIndex > 0 Then
                Dim ix As Integer = k.SelectedIndex
                Dim tp As TabPage = k.SelectedTab
                k.TabPages.RemoveAt(ix)
                k.TabPages.Insert(ix - 1, tp)
                k.SelectedTab = tp
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q52(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q51(sender, e)
        End If
    End Sub
    Sub q53(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If k.SelectedIndex < k.TabPages.Count - 1 Then
                Dim ix As Integer = k.SelectedIndex
                Dim tp As TabPage = k.SelectedTab
                k.TabPages.RemoveAt(ix)
                k.TabPages.Insert(ix + 1, tp)
                k.SelectedTab = tp
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q54(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q53(sender, e)
        End If
    End Sub
    Sub q55(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Clipboard.SetText(wb.DocumentTitle & vbCrLf & wb.Url.ToString)
            su.Visible = True
            su.Text = "Page title and link copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q56(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q55(sender, e)
        End If
    End Sub
    Sub q57(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ox As New OpenFileDialog()
            ox.Title = "Open Saved Tab Links"
            ox.CheckFileExists = True
            ox.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            ox.ShowDialog()
            If ox.FileName = "" Then Exit Sub
            Dim ar() As String = System.IO.File.ReadAllLines(ox.FileName)
            For q As Integer = 0 To ar.Length - 1
                If ar(q) = "" Then
                Else
                    q3(ar(q))
                End If
            Next q
        Catch ex As Exception
        End Try
    End Sub
    Sub q58(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q57(sender, e)
        End If
    End Sub
    Sub q59(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Process.Start(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        Catch ex As Exception
        End Try
    End Sub
    Sub q60(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q59(sender, e)
        End If
    End Sub
    Sub q61(ByVal sender As Object, ByVal e As EventArgs)
        Try
            c.Items.Clear()
            x.Items.Clear()
            My.Settings.s.Clear()
            su.Visible = True
            su.Text = "Address and search suggestions cleared"
        Catch ex As Exception
        End Try
    End Sub
    Sub q62(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q61(sender, e)
        End If
    End Sub
    Sub q63(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Bookmarks.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Export Bookmarks"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            For q As Integer = 0 To My.Settings.bm.Count - 1
                If My.Settings.bm.Item(q) = "" Then
                Else
                    mySW.WriteLine(My.Settings.bm.Item(q))
                End If
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Bookmarks exported"
        Catch ex As Exception
        End Try
    End Sub
    Sub q64(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q63(sender, e)
        End If
    End Sub
    Sub q65(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ox As New OpenFileDialog()
            ox.Title = "Import Bookmarks"
            ox.CheckFileExists = True
            ox.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            ox.ShowDialog()
            If ox.FileName = "" Then Exit Sub
            Dim ar() As String = System.IO.File.ReadAllLines(ox.FileName)
            For q As Integer = 0 To ar.Length - 1
                If ar(q) = "" Then
                Else
                    My.Settings.bm.Add(ar(q))
                    Dim fv As New ToolStripMenuItem
                    fv.Text = ar(q)
                    fv.Tag = ar(q)
                    fv.Image = My.Resources.F9
                    fv.BackgroundImage = My.Resources.F2
                    fv.BackgroundImageLayout = ImageLayout.Stretch
                    fv.ForeColor = Color.White
                    AddHandler fv.Click, AddressOf z2
                    AddHandler fv.MouseHover, AddressOf z2
                    RB.DropDownItems.Add(fv)
                End If
            Next q
            My.Settings.Save()
            su.Visible = True
            su.Text = "Bookmarks imported"
        Catch ex As Exception
        End Try
    End Sub
    Sub q66(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q65(sender, e)
        End If
    End Sub
    Sub q67(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As New ArrayList
            For q As Integer = 0 To My.Settings.bm.Count - 1
                If My.Settings.bm.Item(q) = "" Then
                Else
                    ar.Add(My.Settings.bm.Item(q))
                End If
            Next q
            ar.Sort()
            My.Settings.bm.Clear()
            RB.DropDownItems.Clear()
            For q As Integer = 0 To ar.Count - 1
                My.Settings.bm.Add(ar.Item(q).ToString)
                Dim fv As New ToolStripMenuItem
                fv.Text = ar.Item(q).ToString
                fv.Tag = ar.Item(q).ToString
                fv.Image = My.Resources.F9
                fv.BackgroundImage = My.Resources.F2
                fv.BackgroundImageLayout = ImageLayout.Stretch
                fv.ForeColor = Color.White
                AddHandler fv.Click, AddressOf z2
                AddHandler fv.MouseHover, AddressOf z2
                RB.DropDownItems.Add(fv)
            Next q
            My.Settings.Save()
            su.Visible = True
            su.Text = "Bookmarks sorted"
        Catch ex As Exception
        End Try
    End Sub
    Sub q68(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q67(sender, e)
        End If
    End Sub
    Sub q69(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = ""
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        tx &= wb.Url.ToString & vbCrLf
                    End If
                End If
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "All tab links copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q70(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q69(sender, e)
        End If
    End Sub
    Sub q71(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As New ArrayList
            For q As Integer = k.TabPages.Count - 1 To 0 Step -1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        If ar.Contains(wb.Url.ToString) Then
                            rca(wb.Url.ToString)
                            k.TabPages.RemoveAt(q)
                            I = I - 1
                            Dim tz As Size = k.ItemSize
                            tz.Width += 6
                            k.ItemSize = tz
                        Else
                            ar.Add(wb.Url.ToString)
                        End If
                    End If
                End If
            Next q
            k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Text = ProductName & " - " & k.SelectedTab.Text
            c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
            su.Visible = True
            su.Text = "Duplicate tabs closed"
        Catch ex As Exception
        End Try
    End Sub
    Sub q72(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q71(sender, e)
        End If
    End Sub
    Sub q73(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = ""
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        tx &= wb.DocumentTitle & " - " & wb.Url.ToString & vbCrLf
                    End If
                End If
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "All tab titles and links copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q74(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q73(sender, e)
        End If
    End Sub
    Sub q75(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As New ArrayList
            For q As Integer = 0 To k.TabPages.Count - 1
                ar.Add(k.TabPages(q))
            Next q
            For q As Integer = 0 To ar.Count - 2
                For w As Integer = q + 1 To ar.Count - 1
                    If String.Compare(CType(ar(q), TabPage).Text, CType(ar(w), TabPage).Text) > 0 Then
                        Dim tp As TabPage = CType(ar(q), TabPage)
                        ar(q) = ar(w)
                        ar(w) = tp
                    End If
                Next w
            Next q
            Dim st As TabPage = k.SelectedTab
            k.TabPages.Clear()
            For q As Integer = 0 To ar.Count - 1
                k.TabPages.Add(CType(ar(q), TabPage))
            Next q
            k.SelectedTab = st
            su.Visible = True
            su.Text = "Tabs sorted"
        Catch ex As Exception
        End Try
    End Sub
    Sub q76(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q75(sender, e)
        End If
    End Sub
    Sub q77(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.InvokeScript("eval", New Object() {"document.selection ? document.selection.createRange().text : window.getSelection().toString();"}).ToString
            If tx = "" Then
            Else
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.se & Uri.EscapeDataString(tx))
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q78(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q77(sender, e)
        End If
    End Sub
    Sub q79(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim f As New j
            f.Show()
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        If q = 0 Then
                            f.q1(wb.Url.ToString)
                        Else
                            f.q3(wb.Url.ToString)
                        End If
                    End If
                End If
            Next q
        Catch ex As Exception
        End Try
    End Sub
    Sub q80(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q79(sender, e)
        End If
    End Sub
    Sub q81(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider History.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Export History"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            For q As Integer = 0 To f6.l0.Items.Count - 1
                mySW.WriteLine(f6.l0.Items.Item(q).ToString)
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "History exported"
        Catch ex As Exception
        End Try
    End Sub
    Sub q82(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q81(sender, e)
        End If
    End Sub
    Sub q83(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If My.Settings.rs = "e" Then
                My.Settings.rs = ""
                su.Visible = True
                su.Text = "Startup will open homepage"
            Else
                My.Settings.rs = "e"
                su.Visible = True
                su.Text = "Startup will restore session"
            End If
            My.Settings.Save()
        Catch ex As Exception
        End Try
    End Sub
    Sub q84(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q83(sender, e)
        End If
    End Sub
    Sub q85(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ix As Integer = k.SelectedIndex
            For q As Integer = ix - 1 To 0 Step -1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then rca(wb.Url.ToString)
                End If
                k.TabPages.RemoveAt(q)
                I = I - 1
                Dim tz As Size = k.ItemSize
                tz.Width += 6
                k.ItemSize = tz
            Next q
            k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Text = ProductName & " - " & k.SelectedTab.Text
            c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Catch ex As Exception
        End Try
    End Sub
    Sub q86(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q85(sender, e)
        End If
    End Sub
    Sub q87(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & ".txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Current Page Text"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim tx As String = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.InnerText
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.Write(tx)
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Page text saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q88(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q87(sender, e)
        End If
    End Sub
    Sub q89(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim st As TabPage = k.SelectedTab
            Dim ar As New ArrayList
            For q As Integer = k.TabPages.Count - 1 To 0 Step -1
                ar.Add(k.TabPages(q))
            Next q
            k.TabPages.Clear()
            For q As Integer = 0 To ar.Count - 1
                k.TabPages.Add(CType(ar(q), TabPage))
            Next q
            k.SelectedTab = st
            su.Visible = True
            su.Text = "Tabs reversed"
        Catch ex As Exception
        End Try
    End Sub
    Sub q90(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q89(sender, e)
        End If
    End Sub
    Sub q91(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Clipboard.SetText(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.InnerText)
            su.Visible = True
            su.Text = "Page text copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q92(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q91(sender, e)
        End If
    End Sub
    Sub q93(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & ".html"
            SX.Filter = "HTML [*.html*]|*.html|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Current Page HTML"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.Write(CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentText)
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Page HTML saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q94(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q93(sender, e)
        End If
    End Sub
    Sub q95(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ox As New OpenFileDialog()
            ox.Title = "Import History"
            ox.CheckFileExists = True
            ox.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            ox.ShowDialog()
            If ox.FileName = "" Then Exit Sub
            Dim ar() As String = System.IO.File.ReadAllLines(ox.FileName)
            For q As Integer = 0 To ar.Length - 1
                If ar(q) = "" Then
                Else
                    f6.l0.Items.Add(ar(q))
                    c.Items.Add(ar(q))
                End If
            Next q
            su.Visible = True
            su.Text = "History imported"
        Catch ex As Exception
        End Try
    End Sub
    Sub q96(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q95(sender, e)
        End If
    End Sub
    Sub q97(ByVal sender As Object, ByVal e As EventArgs)
        Try
            For q As Integer = 0 To f6.l0.Items.Count - 1
                If f6.l0.Items.Item(q).ToString = "" Then
                Else
                    q3(f6.l0.Items.Item(q).ToString)
                End If
            Next q
        Catch ex As Exception
        End Try
    End Sub
    Sub q98(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q97(sender, e)
        End If
    End Sub
    Sub q99(ByVal sender As Object, ByVal e As EventArgs)
        Try
            My.Settings.bm.Clear()
            RB.DropDownItems.Clear()
            My.Settings.Save()
            su.Visible = True
            su.Text = "Bookmarks cleared"
        Catch ex As Exception
        End Try
    End Sub
    Sub q100(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q99(sender, e)
        End If
    End Sub
    Sub q101(ByVal sender As Object, ByVal e As EventArgs)
        Try
            q3(My.Settings.h)
        Catch ex As Exception
        End Try
    End Sub
    Sub q102(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q101(sender, e)
        End If
    End Sub
    Sub q103(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Clipboard.SetText(My.Settings.h)
            su.Visible = True
            su.Text = "Homepage link copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q104(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q103(sender, e)
        End If
    End Sub
    Sub q105(ByVal sender As Object, ByVal e As EventArgs)
        Try
            My.Settings.h = "http://fsin.glitch.me/"
            My.Settings.Save()
            su.Visible = True
            su.Text = "Homepage reset"
        Catch ex As Exception
        End Try
    End Sub
    Sub q106(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q105(sender, e)
        End If
    End Sub
    Sub q107(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Window Snapshot.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Window Snapshot"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("Firespider Window Snapshot")
            mySW.WriteLine("Selected Tab: " & k.SelectedIndex.ToString)
            mySW.WriteLine("Homepage: " & My.Settings.h)
            mySW.WriteLine("Restore Session: " & My.Settings.rs)
            mySW.WriteLine("Private Mode: " & pv.ToString)
            mySW.WriteLine("")
            For q As Integer = 0 To k.TabPages.Count - 1
                mySW.WriteLine("Tab " & q.ToString)
                mySW.WriteLine("Title: " & k.TabPages(q).Text)
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then mySW.WriteLine("URL: " & wb.Url.ToString)
                End If
                mySW.WriteLine("")
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Window snapshot saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q108(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q107(sender, e)
        End If
    End Sub
    Sub q109(ByVal sender As Object, ByVal e As EventArgs)
        Try
            My.Settings.ls.Clear()
            f6.l0.Items.Clear()
            c.Items.Clear()
            My.Settings.Save()
            su.Visible = True
            su.Text = "Session and history cleared"
        Catch ex As Exception
        End Try
    End Sub
    Sub q110(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q109(sender, e)
        End If
    End Sub
    Sub q111(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Clipboard.SetText(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.Host)
            su.Visible = True
            su.Text = "Current domain copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q112(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q111(sender, e)
        End If
    End Sub
    Sub q113(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If k.SelectedIndex > 0 Then
                Dim tp As TabPage = k.SelectedTab
                k.TabPages.Remove(tp)
                k.TabPages.Insert(0, tp)
                k.SelectedTab = tp
                su.Visible = True
                su.Text = "Tab pinned first"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q114(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q113(sender, e)
        End If
    End Sub
    Sub q115(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Process.Start(My.Settings.h)
        Catch ex As Exception
        End Try
    End Sub
    Sub q116(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q115(sender, e)
        End If
    End Sub
    Sub q117(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = "Firespider Session Summary" & vbCrLf
            tx &= "Selected Tab: " & k.SelectedIndex.ToString & vbCrLf
            tx &= "Homepage: " & My.Settings.h & vbCrLf
            tx &= "Restore Session: " & My.Settings.rs & vbCrLf
            tx &= "Private Mode: " & pv.ToString & vbCrLf & vbCrLf
            For q As Integer = 0 To k.TabPages.Count - 1
                tx &= "Tab " & q.ToString & ": " & k.TabPages(q).Text & vbCrLf
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then tx &= wb.Url.ToString & vbCrLf
                End If
                tx &= vbCrLf
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "Session summary copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q118(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q117(sender, e)
        End If
    End Sub
    Sub q119(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As New ArrayList
            Dim ct As New ArrayList
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        Dim u As String = wb.Url.ToString
                        If ar.Contains(u) Then
                            ct(ar.IndexOf(u)) = CInt(ct(ar.IndexOf(u))) + 1
                        Else
                            ar.Add(u)
                            ct.Add(1)
                        End If
                    End If
                End If
            Next q
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        If CInt(ct(ar.IndexOf(wb.Url.ToString))) > 1 Then
                            wb.Refresh()
                        End If
                    End If
                End If
            Next q
            su.Visible = True
            su.Text = "Duplicate tabs reloaded"
        Catch ex As Exception
        End Try
    End Sub
    Sub q120(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q119(sender, e)
        End If
    End Sub
    Sub q121(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = ""
            For q As Integer = 0 To My.Settings.bm.Count - 1
                If My.Settings.bm.Item(q) = "" Then
                Else
                    tx &= My.Settings.bm.Item(q) & vbCrLf
                End If
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "Bookmark links copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q122(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q121(sender, e)
        End If
    End Sub
    Sub q123(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(u.Scheme & "://" & u.Host & "/")
        Catch ex As Exception
        End Try
    End Sub
    Sub q124(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q123(sender, e)
        End If
    End Sub
    Sub q125(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Bookmark Snapshot.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Bookmark Snapshot"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("Firespider Bookmark Snapshot")
            mySW.WriteLine("Bookmark Count: " & My.Settings.bm.Count.ToString)
            mySW.WriteLine("")
            For q As Integer = 0 To My.Settings.bm.Count - 1
                mySW.WriteLine((q + 1).ToString & ". " & My.Settings.bm.Item(q))
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Bookmark snapshot saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q126(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q125(sender, e)
        End If
    End Sub
    Sub q127(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = ""
            For q As Integer = 0 To f6.l0.Items.Count - 1
                tx &= f6.l0.Items.Item(q).ToString & vbCrLf
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "History links copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q128(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q127(sender, e)
        End If
    End Sub
    Sub q129(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            My.Settings.h = u.Scheme & "://" & u.Host & "/"
            My.Settings.Save()
            su.Visible = True
            su.Text = "Homepage set to current domain"
        Catch ex As Exception
        End Try
    End Sub
    Sub q130(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q129(sender, e)
        End If
    End Sub
    Sub q131(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            If u.IsFile Then
                Process.Start(System.IO.Path.GetDirectoryName(u.LocalPath))
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q132(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q131(sender, e)
        End If
    End Sub
    Sub q133(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If f6.l0.SelectedItem Is Nothing Then Exit Sub
            Dim u As String = f6.l0.SelectedItem.ToString
            My.Settings.bm.Add(u)
            Dim fv As New ToolStripMenuItem
            fv.Text = u
            fv.Tag = u
            fv.Image = My.Resources.F9
            fv.BackgroundImage = My.Resources.F2
            fv.BackgroundImageLayout = ImageLayout.Stretch
            fv.ForeColor = Color.White
            AddHandler fv.Click, AddressOf z2
            AddHandler fv.MouseHover, AddressOf z2
            RB.DropDownItems.Add(fv)
            My.Settings.Save()
            su.Visible = True
            su.Text = "History item bookmarked"
        Catch ex As Exception
        End Try
    End Sub
    Sub q134(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q133(sender, e)
        End If
    End Sub
    Sub q135(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider History Snapshot.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save History Snapshot"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("Firespider History Snapshot")
            mySW.WriteLine("History Count: " & f6.l0.Items.Count.ToString)
            mySW.WriteLine("")
            For q As Integer = 0 To f6.l0.Items.Count - 1
                mySW.WriteLine((q + 1).ToString & ". " & f6.l0.Items.Item(q).ToString)
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "History snapshot saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q136(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q135(sender, e)
        End If
    End Sub
    Sub q137(ByVal sender As Object, ByVal e As EventArgs)
        Try
            My.Settings.ls.Clear()
            My.Settings.bm.Clear()
            My.Settings.s.Clear()
            f6.l0.Items.Clear()
            c.Items.Clear()
            x.Items.Clear()
            RB.DropDownItems.Clear()
            My.Settings.Save()
            su.Visible = True
            su.Text = "All browser data cleared"
        Catch ex As Exception
        End Try
    End Sub
    Sub q138(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q137(sender, e)
        End If
    End Sub
    Sub q139(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            q3(u.Scheme & "://" & u.Host & "/")
        Catch ex As Exception
        End Try
    End Sub
    Sub q140(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q139(sender, e)
        End If
    End Sub
    Sub q141(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Browser Data Snapshot.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save All Browser Data Snapshot"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("Firespider Browser Data Snapshot")
            mySW.WriteLine("Homepage: " & My.Settings.h)
            mySW.WriteLine("Restore Session: " & My.Settings.rs)
            mySW.WriteLine("Private Mode: " & pv.ToString)
            mySW.WriteLine("Open Tabs: " & k.TabPages.Count.ToString)
            mySW.WriteLine("Bookmarks: " & My.Settings.bm.Count.ToString)
            mySW.WriteLine("History: " & f6.l0.Items.Count.ToString)
            mySW.WriteLine("")
            mySW.WriteLine("Open Tabs")
            For q As Integer = 0 To k.TabPages.Count - 1
                mySW.WriteLine((q + 1).ToString & ". " & k.TabPages(q).Text)
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then mySW.WriteLine("   " & wb.Url.ToString)
                End If
            Next q
            mySW.WriteLine("")
            mySW.WriteLine("Bookmarks")
            For q As Integer = 0 To My.Settings.bm.Count - 1
                mySW.WriteLine((q + 1).ToString & ". " & My.Settings.bm.Item(q))
            Next q
            mySW.WriteLine("")
            mySW.WriteLine("History")
            For q As Integer = 0 To f6.l0.Items.Count - 1
                mySW.WriteLine((q + 1).ToString & ". " & f6.l0.Items.Item(q).ToString)
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Browser data snapshot saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q142(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q141(sender, e)
        End If
    End Sub
    Sub q143(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            Dim du As String = u.Scheme & "://" & u.Host & "/"
            My.Settings.bm.Add(du)
            Dim fv As New ToolStripMenuItem
            fv.Text = du
            fv.Tag = du
            fv.Image = My.Resources.F9
            fv.BackgroundImage = My.Resources.F2
            fv.BackgroundImageLayout = ImageLayout.Stretch
            fv.ForeColor = Color.White
            AddHandler fv.Click, AddressOf z2
            AddHandler fv.MouseHover, AddressOf z2
            RB.DropDownItems.Add(fv)
            My.Settings.Save()
            su.Visible = True
            su.Text = "Current domain bookmarked"
        Catch ex As Exception
        End Try
    End Sub
    Sub q144(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q143(sender, e)
        End If
    End Sub
    Sub q145(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        If wb.Url.Host = u.Host Then
                            wb.Refresh()
                        End If
                    End If
                End If
            Next q
            su.Visible = True
            su.Text = "Same-domain tabs reloaded"
        Catch ex As Exception
        End Try
    End Sub
    Sub q146(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q145(sender, e)
        End If
    End Sub
    Sub q147(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            Dim tx As String = ""
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        If wb.Url.Host = u.Host Then
                            tx &= wb.DocumentTitle & " - " & wb.Url.ToString & vbCrLf
                        End If
                    End If
                End If
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "Same-domain tabs copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q148(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q147(sender, e)
        End If
    End Sub
    Sub q149(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            Dim st As TabPage = k.SelectedTab
            For q As Integer = k.TabPages.Count - 1 To 0 Step -1
                If k.TabPages(q) Is st Then
                ElseIf k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        If wb.Url.Host = u.Host Then
                            rca(wb.Url.ToString)
                            k.TabPages.RemoveAt(q)
                            I = I - 1
                            Dim tz As Size = k.ItemSize
                            tz.Width += 6
                            k.ItemSize = tz
                        End If
                    End If
                End If
            Next q
            k.SelectedTab = st
            su.Visible = True
            su.Text = "Same-domain tabs closed"
        Catch ex As Exception
        End Try
    End Sub
    Sub q150(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q149(sender, e)
        End If
    End Sub
    Sub q151(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            Dim du As String = u.Scheme & "://" & u.Host & "/"
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Domain Snapshot.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Current Domain Snapshot"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("Firespider Domain Snapshot")
            mySW.WriteLine("Current URL: " & u.ToString)
            mySW.WriteLine("Domain Root: " & du)
            mySW.WriteLine("Homepage: " & My.Settings.h)
            mySW.WriteLine("")
            mySW.WriteLine("Matching Tabs")
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        If wb.Url.Host = u.Host Then
                            mySW.WriteLine((q + 1).ToString & ". " & wb.DocumentTitle)
                            mySW.WriteLine("   " & wb.Url.ToString)
                        End If
                    End If
                End If
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Domain snapshot saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q152(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q151(sender, e)
        End If
    End Sub
    Sub q153(ByVal sender As Object, ByVal e As EventArgs)
        Try
            q3(CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        Catch ex As Exception
        End Try
    End Sub
    Sub q154(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q153(sender, e)
        End If
    End Sub
    Sub q155(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Search Suggestions Snapshot.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Search Suggestions Snapshot"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("Firespider Search Suggestions Snapshot")
            mySW.WriteLine("Search Engine: " & My.Settings.se)
            mySW.WriteLine("")
            mySW.WriteLine("Address Suggestions")
            For q As Integer = 0 To c.Items.Count - 1
                mySW.WriteLine((q + 1).ToString & ". " & c.Items.Item(q).ToString)
            Next q
            mySW.WriteLine("")
            mySW.WriteLine("Search Suggestions")
            For q As Integer = 0 To x.Items.Count - 1
                mySW.WriteLine((q + 1).ToString & ". " & x.Items.Item(q).ToString)
            Next q
            mySW.WriteLine("")
            mySW.WriteLine("Saved Search Suggestions")
            For q As Integer = 0 To My.Settings.s.Count - 1
                mySW.WriteLine((q + 1).ToString & ". " & My.Settings.s.Item(q))
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Search suggestions snapshot saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q156(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q155(sender, e)
        End If
    End Sub
    Sub q157(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = "Search Engine: " & My.Settings.se & vbCrLf & vbCrLf
            tx &= "Address Suggestions" & vbCrLf
            For q As Integer = 0 To c.Items.Count - 1
                tx &= c.Items.Item(q).ToString & vbCrLf
            Next q
            tx &= vbCrLf & "Search Suggestions" & vbCrLf
            For q As Integer = 0 To x.Items.Count - 1
                tx &= x.Items.Item(q).ToString & vbCrLf
            Next q
            tx &= vbCrLf & "Saved Search Suggestions" & vbCrLf
            For q As Integer = 0 To My.Settings.s.Count - 1
                tx &= My.Settings.s.Item(q) & vbCrLf
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "Search suggestions copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q158(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q157(sender, e)
        End If
    End Sub
    Sub q159(ByVal sender As Object, ByVal e As EventArgs)
        Try
            My.Settings.se = "www.bing.com/search?q="
            My.Settings.Save()
            su.Visible = True
            su.Text = "Default search engine restored"
        Catch ex As Exception
        End Try
    End Sub
    Sub q160(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q159(sender, e)
        End If
    End Sub
    Sub rca(ByVal u As String)
        Try
            If u = "" Then
            Else
                lu = u
                If My.Settings.rc.Contains(u) Then
                    My.Settings.rc.Remove(u)
                End If
                My.Settings.rc.Insert(0, u)
                While My.Settings.rc.Count > 25
                    My.Settings.rc.RemoveAt(My.Settings.rc.Count - 1)
                End While
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q161(ByVal sender As Object, ByVal e As EventArgs) Handles RC.DropDownOpening
        Try
            RC.DropDownItems.Clear()
            For q As Integer = 0 To My.Settings.rc.Count - 1
                Dim ti As New ToolStripMenuItem
                ti.Text = My.Settings.rc.Item(q)
                ti.Tag = My.Settings.rc.Item(q)
                ti.Image = My.Resources.F9
                ti.BackColor = Color.White
                ti.ForeColor = Color.Black
                ti.Padding = New Padding(0)
                AddHandler ti.Click, AddressOf q163
                AddHandler ti.MouseHover, AddressOf q163
                RC.DropDownItems.Add(ti)
            Next q
        Catch ex As Exception
        End Try
    End Sub
    Sub q162(ByVal sender As Object, ByVal e As EventArgs) Handles RC.Click
        q161(sender, e)
        If RC.DropDownItems.Count > 0 Then RC.ShowDropDown()
    End Sub
    Sub q163(ByVal sender As ToolStripMenuItem, ByVal ByVale As EventArgs)
        q3(sender.Tag.ToString)
    End Sub
    Sub q164(ByVal sender As Object, ByVal e As EventArgs) Handles RC.MouseHover
        If My.Settings.t = "e" Then
            q162(sender, e)
        End If
    End Sub
    Sub q165(ByVal sender As Object, ByVal e As EventArgs) Handles RP.Click
        Try
            If My.Settings.ls.Count = 0 Then
                su.Visible = True
                su.Text = "No saved session"
            Else
                CType(k.SelectedTab.Controls.Item(0), WebBrowser).Navigate(My.Settings.ls.Item(0))
                For q As Integer = 1 To My.Settings.ls.Count - 1
                    q3(My.Settings.ls.Item(q))
                Next q
                su.Visible = True
                su.Text = "Previous session restored"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q166(ByVal sender As Object, ByVal e As EventArgs) Handles RP.MouseHover
        If My.Settings.t = "e" Then
            q165(sender, e)
        End If
    End Sub
    Function qh(ByVal tx As String) As String
        Try
            tx = tx.Replace("&", "&amp;")
            tx = tx.Replace("<", "&lt;")
            tx = tx.Replace(">", "&gt;")
            tx = tx.Replace("""", "&quot;")
            Return tx
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Sub q167(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Dim tt As String = wb.DocumentTitle
            If tt = "" Then tt = wb.Url.ToString
            tt = tt.Replace("[", "\[")
            tt = tt.Replace("]", "\]")
            Clipboard.SetText("[" & tt & "](" & wb.Url.ToString & ")")
            su.Visible = True
            su.Text = "Markdown link copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q168(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q167(sender, e)
        End If
    End Sub
    Sub q169(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Tabs.html"
            SX.Filter = "HTML File [*.html*]|*.html|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Tab Links As HTML"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("<!doctype html>")
            mySW.WriteLine("<html>")
            mySW.WriteLine("<head><meta charset=""utf-8""><title>Firespider Tabs</title></head>")
            mySW.WriteLine("<body>")
            mySW.WriteLine("<h1>Firespider Tabs</h1>")
            mySW.WriteLine("<ol>")
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        Dim tt As String = k.TabPages(q).Text
                        If tt = "" Then tt = wb.Url.ToString
                        mySW.WriteLine("<li><a href=""" & qh(wb.Url.ToString) & """>" & qh(tt) & "</a></li>")
                    End If
                End If
            Next q
            mySW.WriteLine("</ol>")
            mySW.WriteLine("</body>")
            mySW.WriteLine("</html>")
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Tab links HTML saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q170(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q169(sender, e)
        End If
    End Sub
    Sub q171(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        If wb.Url.Host = u.Host Then
                            My.Settings.bm.Add(wb.Url.ToString)
                            Dim fv As New ToolStripMenuItem
                            fv.Text = k.TabPages(q).Text
                            If fv.Text = "" Then fv.Text = wb.Url.ToString
                            fv.Tag = wb.Url.ToString
                            fv.Image = My.Resources.F9
                            fv.BackgroundImage = My.Resources.F2
                            fv.BackgroundImageLayout = ImageLayout.Stretch
                            fv.ForeColor = Color.White
                            AddHandler fv.Click, AddressOf z2
                            AddHandler fv.MouseHover, AddressOf z2
                            RB.DropDownItems.Add(fv)
                        End If
                    End If
                End If
            Next q
            My.Settings.Save()
            su.Visible = True
            su.Text = "Same-domain tabs bookmarked"
        Catch ex As Exception
        End Try
    End Sub
    Sub q172(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q171(sender, e)
        End If
    End Sub
    Sub q173(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As Uri = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url
            Process.Start(u.Scheme & "://" & u.Host & "/")
            su.Visible = True
            su.Text = "Domain opened in default browser"
        Catch ex As Exception
        End Try
    End Sub
    Sub q174(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q173(sender, e)
        End If
    End Sub
    Sub q175(ByVal sender As Object, ByVal e As EventArgs)
        Try
            For q As Integer = k.TabPages.Count - 1 To 0 Step -1
                If k.TabPages.Count = 1 Then Exit For
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If wb.Url Is Nothing Or k.TabPages(q).Text = "" Or k.TabPages(q).Text = "New Tab" Or k.TabPages(q).Text = "New Page" Then
                        k.TabPages.RemoveAt(q)
                        I = I - 1
                        Dim tz As Size = k.ItemSize
                        tz.Width += 6
                        k.ItemSize = tz
                    End If
                End If
            Next q
            k.SelectedTab.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
            Text = ProductName & " - " & k.SelectedTab.Text
            c.Text = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
            su.Visible = True
            su.Text = "Blank tabs closed"
        Catch ex As Exception
        End Try
    End Sub
    Sub q176(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q175(sender, e)
        End If
    End Sub
    Function ql() As ArrayList
        Dim ar As New ArrayList
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            For Each he As HtmlElement In wb.Document.Links
                Dim u As String = he.GetAttribute("href")
                If u = "" Then
                ElseIf ar.Contains(u) Then
                Else
                    ar.Add(u)
                End If
            Next
        Catch ex As Exception
        End Try
        Return ar
    End Function
    Sub q177(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As ArrayList = ql()
            Dim tx As String = ""
            For q As Integer = 0 To ar.Count - 1
                tx &= ar.Item(q).ToString & vbCrLf
            Next q
            If tx = "" Then
                su.Visible = True
                su.Text = "No page links found"
            Else
                Clipboard.SetText(tx)
                su.Visible = True
                su.Text = "Page links copied"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q178(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q177(sender, e)
        End If
    End Sub
    Sub q179(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As ArrayList = ql()
            If ar.Count = 0 Then
                su.Visible = True
                su.Text = "No page links found"
                Exit Sub
            End If
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Page Links.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save All Links On Current Page"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("Firespider Page Links")
            mySW.WriteLine("Page: " & CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            mySW.WriteLine("Links: " & ar.Count.ToString)
            mySW.WriteLine("")
            For q As Integer = 0 To ar.Count - 1
                mySW.WriteLine(ar.Item(q).ToString)
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Page links saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q180(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q179(sender, e)
        End If
    End Sub
    Sub q181(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As ArrayList = ql()
            For q As Integer = 0 To ar.Count - 1
                Dim u As String = ar.Item(q).ToString
                My.Settings.bm.Add(u)
                Dim fv As New ToolStripMenuItem
                fv.Text = u
                fv.Tag = u
                fv.Image = My.Resources.F9
                fv.BackgroundImage = My.Resources.F2
                fv.BackgroundImageLayout = ImageLayout.Stretch
                fv.ForeColor = Color.White
                AddHandler fv.Click, AddressOf z2
                AddHandler fv.MouseHover, AddressOf z2
                RB.DropDownItems.Add(fv)
            Next q
            My.Settings.Save()
            su.Visible = True
            su.Text = "Page links bookmarked"
        Catch ex As Exception
        End Try
    End Sub
    Sub q182(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q181(sender, e)
        End If
    End Sub
    Sub q183(ByVal sender As Object, ByVal e As EventArgs)
        Try
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Window.ScrollTo(0, 0)
            su.Visible = True
            su.Text = "Scrolled to top"
        Catch ex As Exception
        End Try
    End Sub
    Sub q184(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q183(sender, e)
        End If
    End Sub
    Sub q185(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Dim y As Integer = wb.Document.Body.ScrollRectangle.Height
            wb.Document.Window.ScrollTo(0, y)
            su.Visible = True
            su.Text = "Scrolled to bottom"
        Catch ex As Exception
        End Try
    End Sub
    Sub q186(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q185(sender, e)
        End If
    End Sub
    Function qi() As ArrayList
        Dim ar As New ArrayList
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            For Each he As HtmlElement In wb.Document.Images
                Dim u As String = he.GetAttribute("src")
                If u = "" Then
                ElseIf ar.Contains(u) Then
                Else
                    ar.Add(u)
                End If
            Next
        Catch ex As Exception
        End Try
        Return ar
    End Function
    Sub q187(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As ArrayList = qi()
            Dim tx As String = ""
            For q As Integer = 0 To ar.Count - 1
                tx &= ar.Item(q).ToString & vbCrLf
            Next q
            If tx = "" Then
                su.Visible = True
                su.Text = "No page images found"
            Else
                Clipboard.SetText(tx)
                su.Visible = True
                su.Text = "Page image links copied"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q188(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q187(sender, e)
        End If
    End Sub
    Sub q189(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As ArrayList = qi()
            If ar.Count = 0 Then
                su.Visible = True
                su.Text = "No page images found"
                Exit Sub
            End If
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Page Images.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Page Image Links"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("Firespider Page Image Links")
            mySW.WriteLine("Page: " & CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            mySW.WriteLine("Images: " & ar.Count.ToString)
            mySW.WriteLine("")
            For q As Integer = 0 To ar.Count - 1
                mySW.WriteLine(ar.Item(q).ToString)
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Page image links saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q190(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q189(sender, e)
        End If
    End Sub
    Sub q191(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Clipboard.SetText(CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentText)
            su.Visible = True
            su.Text = "Page HTML copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q192(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q191(sender, e)
        End If
    End Sub
    Sub q193(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Dim links As ArrayList = ql()
            Dim imgs As ArrayList = qi()
            Dim tx As String = ""
            tx &= "Title: " & wb.DocumentTitle & vbCrLf
            tx &= "Address: " & wb.Url.ToString & vbCrLf
            tx &= "Domain: " & wb.Url.Host & vbCrLf
            tx &= "Status: " & wb.StatusText & vbCrLf
            tx &= "Links: " & links.Count.ToString & vbCrLf
            tx &= "Images: " & imgs.Count.ToString & vbCrLf
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "Page metadata copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q194(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q193(sender, e)
        End If
    End Sub
    Sub q195(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Dim u As Uri = wb.Url
            Dim ar As ArrayList = ql()
            Dim opened As Integer = 0
            For q As Integer = 0 To ar.Count - 1
                Dim lu As New Uri(ar.Item(q).ToString)
                If lu.Host = u.Host Then
                    q3(lu.ToString)
                    opened += 1
                End If
            Next q
            su.Visible = True
            su.Text = opened.ToString & " same-domain links opened"
        Catch ex As Exception
        End Try
    End Sub
    Sub q196(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q195(sender, e)
        End If
    End Sub
    Function qs() As ArrayList
        Dim ar As New ArrayList
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Dim u As Uri = wb.Url
            Dim al As ArrayList = ql()
            For q As Integer = 0 To al.Count - 1
                Dim lu As New Uri(al.Item(q).ToString)
                If lu.Host = u.Host Then ar.Add(lu.ToString)
            Next q
        Catch ex As Exception
        End Try
        Return ar
    End Function
    Function qm() As String
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Dim links As ArrayList = ql()
            Dim imgs As ArrayList = qi()
            Dim tx As String = ""
            tx &= "Title: " & wb.DocumentTitle & vbCrLf
            tx &= "Address: " & wb.Url.ToString & vbCrLf
            tx &= "Domain: " & wb.Url.Host & vbCrLf
            tx &= "Status: " & wb.StatusText & vbCrLf
            tx &= "Links: " & links.Count.ToString & vbCrLf
            tx &= "Same-Domain Links: " & qs().Count.ToString & vbCrLf
            tx &= "Images: " & imgs.Count.ToString & vbCrLf
            tx &= "Can Go Back: " & wb.CanGoBack.ToString & vbCrLf
            tx &= "Can Go Forward: " & wb.CanGoForward.ToString & vbCrLf
            Return tx
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Sub q197(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As ArrayList = qs()
            Dim tx As String = ""
            For q As Integer = 0 To ar.Count - 1
                tx &= ar.Item(q).ToString & vbCrLf
            Next q
            If tx = "" Then
                su.Visible = True
                su.Text = "No same-domain links found"
            Else
                Clipboard.SetText(tx)
                su.Visible = True
                su.Text = "Same-domain links copied"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q198(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q197(sender, e)
        End If
    End Sub
    Sub q199(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As ArrayList = qs()
            If ar.Count = 0 Then
                su.Visible = True
                su.Text = "No same-domain links found"
                Exit Sub
            End If
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Same Domain Links.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Same-Domain Page Links"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("Firespider Same-Domain Page Links")
            mySW.WriteLine("Page: " & CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            mySW.WriteLine("Links: " & ar.Count.ToString)
            mySW.WriteLine("")
            For q As Integer = 0 To ar.Count - 1
                mySW.WriteLine(ar.Item(q).ToString)
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Same-domain links saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q200(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q199(sender, e)
        End If
    End Sub
    Sub q201(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As ArrayList = qi()
            For q As Integer = 0 To ar.Count - 1
                q3(ar.Item(q).ToString)
            Next q
            su.Visible = True
            su.Text = ar.Count.ToString & " image links opened"
        Catch ex As Exception
        End Try
    End Sub
    Sub q202(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q201(sender, e)
        End If
    End Sub
    Sub q203(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = ""
            tx &= "Open Tabs: " & k.TabPages.Count.ToString & vbCrLf
            tx &= "Selected Tab: " & k.SelectedIndex.ToString & vbCrLf
            tx &= "" & vbCrLf
            For q As Integer = 0 To k.TabPages.Count - 1
                tx &= (q + 1).ToString & ". " & k.TabPages(q).Text & vbCrLf
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then tx &= "   " & wb.Url.ToString & vbCrLf
                End If
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "Tab summary copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q204(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q203(sender, e)
        End If
    End Sub
    Sub q205(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Page Metadata.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Page Metadata"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.Write(qm())
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Page metadata saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q206(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q205(sender, e)
        End If
    End Sub
    Sub q207(ByVal sender As Object, ByVal e As EventArgs)
        Try
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then Process.Start(wb.Url.ToString)
                End If
            Next q
            su.Visible = True
            su.Text = "All tabs opened in default browser"
        Catch ex As Exception
        End Try
    End Sub
    Sub q208(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q207(sender, e)
        End If
    End Sub
    Function qc(ByVal tx As String) As String
        Try
            tx = tx.Replace("""", """""")
            Return """" & tx & """"
        Catch ex As Exception
            Return """"""
        End Try
    End Function
    Function qp() As String
        Try
            Dim tx As String = CType(k.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.InnerText
            If tx.Length > 1000 Then tx = tx.Substring(0, 1000)
            Return tx
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Sub q209(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Tabs.csv"
            SX.Filter = "CSV File [*.csv*]|*.csv|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save All Tabs As CSV"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("Number,Title,Address,Domain")
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        mySW.WriteLine(qc((q + 1).ToString) & "," & qc(k.TabPages(q).Text) & "," & qc(wb.Url.ToString) & "," & qc(wb.Url.Host))
                    End If
                End If
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Tabs CSV saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q210(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q209(sender, e)
        End If
    End Sub
    Sub q211(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = ""
            tx &= "Bookmarks: " & My.Settings.bm.Count.ToString & vbCrLf
            tx &= "" & vbCrLf
            For q As Integer = 0 To My.Settings.bm.Count - 1
                If My.Settings.bm.Item(q) = "" Then
                Else
                    tx &= (q + 1).ToString & ". " & My.Settings.bm.Item(q) & vbCrLf
                End If
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "Bookmark summary copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q212(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q211(sender, e)
        End If
    End Sub
    Sub q213(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As New ArrayList
            For q As Integer = 0 To My.Settings.bm.Count - 1
                If My.Settings.bm.Item(q) = "" Then
                Else
                    ar.Add(My.Settings.bm.Item(q))
                End If
            Next q
            If ar.Count = 0 Then
                su.Visible = True
                su.Text = "No bookmarks"
            Else
                Dim rn As New Random
                q3(ar.Item(rn.Next(0, ar.Count)).ToString)
                su.Visible = True
                su.Text = "Random bookmark opened"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q214(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q213(sender, e)
        End If
    End Sub
    Sub q215(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = qp()
            If tx = "" Then
                su.Visible = True
                su.Text = "No page text"
            Else
                Clipboard.SetText(tx)
                su.Visible = True
                su.Text = "Page text preview copied"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q216(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q215(sender, e)
        End If
    End Sub
    Sub q217(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = qp()
            If tx = "" Then
                su.Visible = True
                su.Text = "No page text"
                Exit Sub
            End If
            Dim SX As New SaveFileDialog()
            SX.FileName = CType(k.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " Preview.txt"
            SX.Filter = "Text File [*.txt*]|*.txt|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Page Text Preview"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.Write(tx)
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Page text preview saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q218(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q217(sender, e)
        End If
    End Sub
    Sub q219(ByVal sender As Object, ByVal e As EventArgs)
        Try
            CType(k.SelectedTab.Controls.Item(0), WebBrowser).Refresh(WebBrowserRefreshOption.Completely)
            su.Visible = True
            su.Text = "Current tab hard refreshed"
        Catch ex As Exception
        End Try
    End Sub
    Sub q220(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q219(sender, e)
        End If
    End Sub
    Function qmk(ByVal tx As String) As String
        Try
            tx = tx.Replace("[", "\[")
            tx = tx.Replace("]", "\]")
            Return tx
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Sub q221(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = ""
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        Dim tt As String = k.TabPages(q).Text
                        If tt = "" Then tt = wb.Url.ToString
                        tx &= "- [" & qmk(tt) & "](" & wb.Url.ToString & ")" & vbCrLf
                    End If
                End If
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "Tabs copied as Markdown"
        Catch ex As Exception
        End Try
    End Sub
    Sub q222(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q221(sender, e)
        End If
    End Sub
    Sub q223(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Bookmarks.html"
            SX.Filter = "HTML File [*.html*]|*.html|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save Bookmarks As HTML"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("<!doctype html>")
            mySW.WriteLine("<html>")
            mySW.WriteLine("<head><meta charset=""utf-8""><title>Firespider Bookmarks</title></head>")
            mySW.WriteLine("<body>")
            mySW.WriteLine("<h1>Firespider Bookmarks</h1>")
            mySW.WriteLine("<ol>")
            For q As Integer = 0 To My.Settings.bm.Count - 1
                If My.Settings.bm.Item(q) = "" Then
                Else
                    mySW.WriteLine("<li><a href=""" & qh(My.Settings.bm.Item(q)) & """>" & qh(My.Settings.bm.Item(q)) & "</a></li>")
                End If
            Next q
            mySW.WriteLine("</ol>")
            mySW.WriteLine("</body>")
            mySW.WriteLine("</html>")
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Bookmarks HTML saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q224(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q223(sender, e)
        End If
    End Sub
    Sub q225(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = ""
            tx &= "History Items: " & f6.l0.Items.Count.ToString & vbCrLf
            tx &= "" & vbCrLf
            For q As Integer = 0 To f6.l0.Items.Count - 1
                tx &= (q + 1).ToString & ". " & f6.l0.Items.Item(q).ToString & vbCrLf
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "History summary copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q226(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q225(sender, e)
        End If
    End Sub
    Sub q227(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim wb As WebBrowser = CType(k.SelectedTab.Controls.Item(0), WebBrowser)
            Dim tx As String = InputBox("Search " & wb.Url.Host, "Search Current Domain")
            If tx = "" Then Exit Sub
            q3(My.Settings.se & Uri.EscapeDataString("site:" & wb.Url.Host & " " & tx))
            su.Visible = True
            su.Text = "Domain search opened"
        Catch ex As Exception
        End Try
    End Sub
    Sub q228(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q227(sender, e)
        End If
    End Sub
    Sub q229(ByVal sender As Object, ByVal e As EventArgs)
        Try
            q3("view-source:" & CType(k.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            su.Visible = True
            su.Text = "Page source opened"
        Catch ex As Exception
        End Try
    End Sub
    Sub q230(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q229(sender, e)
        End If
    End Sub
    Sub q231(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As New ArrayList
            For q As Integer = 0 To f6.l0.Items.Count - 1
                Dim u As String = f6.l0.Items.Item(q).ToString
                If u = "" Then
                ElseIf ar.Contains(u) Then
                Else
                    ar.Add(u)
                End If
            Next q
            f6.l0.Items.Clear()
            For q As Integer = 0 To ar.Count - 1
                f6.l0.Items.Add(ar.Item(q).ToString)
            Next q
            su.Visible = True
            su.Text = "Duplicate history items removed"
        Catch ex As Exception
        End Try
    End Sub
    Sub q232(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q231(sender, e)
        End If
    End Sub
    Sub q233(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider Tabs.md"
            SX.Filter = "Markdown File [*.md*]|*.md|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save All Tabs As Markdown"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("# Firespider Tabs")
            mySW.WriteLine("")
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        Dim tt As String = k.TabPages(q).Text
                        If tt = "" Then tt = wb.Url.ToString
                        mySW.WriteLine("- [" & qmk(tt) & "](" & wb.Url.ToString & ")")
                    End If
                End If
            Next q
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "Tabs Markdown saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q234(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q233(sender, e)
        End If
    End Sub
    Sub q235(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SX As New SaveFileDialog()
            SX.FileName = "Firespider History.html"
            SX.Filter = "HTML File [*.html*]|*.html|All Files [*.*]|*.*"
            SX.CheckPathExists = True
            SX.Title = "Save History As HTML"
            SX.ShowDialog(Me)
            If SX.FileName = "" Then Exit Sub
            Dim mySW As New System.IO.StreamWriter(SX.FileName, False)
            mySW.WriteLine("<!doctype html>")
            mySW.WriteLine("<html>")
            mySW.WriteLine("<head><meta charset=""utf-8""><title>Firespider History</title></head>")
            mySW.WriteLine("<body>")
            mySW.WriteLine("<h1>Firespider History</h1>")
            mySW.WriteLine("<ol>")
            For q As Integer = 0 To f6.l0.Items.Count - 1
                Dim u As String = f6.l0.Items.Item(q).ToString
                If u = "" Then
                Else
                    mySW.WriteLine("<li><a href=""" & qh(u) & """>" & qh(u) & "</a></li>")
                End If
            Next q
            mySW.WriteLine("</ol>")
            mySW.WriteLine("</body>")
            mySW.WriteLine("</html>")
            mySW.Flush()
            mySW.Close()
            su.Visible = True
            su.Text = "History HTML saved"
        Catch ex As Exception
        End Try
    End Sub
    Sub q236(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q235(sender, e)
        End If
    End Sub
    Sub q237(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As ArrayList = ql()
            Dim tx As String = "<ol>" & vbCrLf
            For q As Integer = 0 To ar.Count - 1
                tx &= "<li><a href=""" & qh(ar.Item(q).ToString) & """>" & qh(ar.Item(q).ToString) & "</a></li>" & vbCrLf
            Next q
            tx &= "</ol>"
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "Page links HTML copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q238(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q237(sender, e)
        End If
    End Sub
    Sub q239(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim u As String = Clipboard.GetText
            If u = "" Then
                su.Visible = True
                su.Text = "Clipboard is empty"
            Else
                q3(u)
                su.Visible = True
                su.Text = "Clipboard link opened"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub q240(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q239(sender, e)
        End If
    End Sub
    Sub q241(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tx As String = InputBox("Find tab title or address", "Search Open Tabs")
            If tx = "" Then Exit Sub
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Text.ToLower.Contains(tx.ToLower) Then
                    k.SelectedTab = k.TabPages(q)
                    su.Visible = True
                    su.Text = "Matching tab selected"
                    Exit Sub
                ElseIf k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        If wb.Url.ToString.ToLower.Contains(tx.ToLower) Then
                            k.SelectedTab = k.TabPages(q)
                            su.Visible = True
                            su.Text = "Matching tab selected"
                            Exit Sub
                        End If
                    End If
                End If
            Next q
            su.Visible = True
            su.Text = "No matching tab"
        Catch ex As Exception
        End Try
    End Sub
    Sub q242(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q241(sender, e)
        End If
    End Sub
    Sub q243(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim ar As New ArrayList
            For q As Integer = 0 To k.TabPages.Count - 1
                If k.TabPages(q).Controls.Count > 0 Then
                    Dim wb As WebBrowser = CType(k.TabPages(q).Controls.Item(0), WebBrowser)
                    If Not wb.Url Is Nothing Then
                        If ar.Contains(wb.Url.Host) Then
                        Else
                            ar.Add(wb.Url.Host)
                        End If
                    End If
                End If
            Next q
            Dim tx As String = ""
            For q As Integer = 0 To ar.Count - 1
                tx &= ar.Item(q).ToString & vbCrLf
            Next q
            Clipboard.SetText(tx)
            su.Visible = True
            su.Text = "Open tab domains copied"
        Catch ex As Exception
        End Try
    End Sub
    Sub q244(ByVal sender As Object, ByVal e As EventArgs)
        If My.Settings.t = "e" Then
            q243(sender, e)
        End If
    End Sub
    Dim nt As Integer = -1119769811
End Class
