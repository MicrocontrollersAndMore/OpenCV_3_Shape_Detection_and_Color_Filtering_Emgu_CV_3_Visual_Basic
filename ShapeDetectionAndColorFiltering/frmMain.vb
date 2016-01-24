'ShapeDetectionAndColorFiltering.sln
'frmMain.vb
'
'using Emgu CV 3.0.0
'
'tableLayoutPanel (TableLayoutPanel)
'btnOpenFile (Button)
'lblChosenFile (Label)
'cbUseWebcam (CheckBox)
'cbShowSteps (CheckBox)
'ibOriginal (ImageBox)
'cbDrawShapesOnOriginalImage (CheckBox)
'cbEnableColorFiltering (CheckBox)
'lblBlueMin (Label)
'lblBlueMax (Label)
'lblGreenMin (Label)
'lblGreenMax (Label)
'lblRedMin (Label)
'lblRedMax (Label)
'tbBlueMin (TrackBar)
'tbBlueMax (TrackBar)
'tbGreenMin (TrackBar)
'tbGreenMax (TrackBar)
'tbRedMin (TrackBar)
'tbRedMax (TrackBar)
'txtInfo (TextBox)
'ofdOpenFile (OpenFileDialog)

Option Explicit On      'require explicit declaration of variables, this is NOT Python !!
Option Strict On        'restrict implicit data type conversions to only widening conversions

Imports Emgu.CV                 'usual Emgu Cv imports
Imports Emgu.CV.CvEnum          '
Imports Emgu.CV.Structure       '
Imports Emgu.CV.UI              '
Imports Emgu.CV.Util            '

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class frmMain

    ' member variables ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim SCALAR_RED As New MCvScalar(0.0, 0.0, 255.0)
    Dim SCALAR_GREEN As New MCvScalar(0.0, 200.0, 0.0)
    Dim SCALAR_YELLOW As New MCvScalar(0.0, 255.0, 255.0)
    Dim SCALAR_BLUE As New MCvScalar(255.0, 0.0, 0.0)
    Dim SCALAR_GRAY As New MCvScalar(128.0, 128.0, 128.0)

    Dim MIN_CONTOUR_AREA As Double = 250.0

    Dim capWebcam As Capture                        'Capture object to use with webcam
    Dim blnWebcamCapturingInProcess As Boolean = False
    
    Dim imgOriginal As Mat
    
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Dim drChosenFile As DialogResult

        drChosenFile = ofdOpenFile.ShowDialog()                 'open file dialog
        
        If (drChosenFile <> DialogResult.OK Or ofdOpenFile.FileName = "") Then    'if user chose Cancel or filename is blank . . .
            lblChosenFile.Text = "file not chosen"              'show error message on label
            Return                                              'and exit function
        End If
        
        Try
            imgOriginal = New Mat(ofdOpenFile.FileName, LoadImageType.Color)
        Catch ex As Exception                                                       'if error occurred
            lblChosenFile.Text = "unable to open image, error: " + ex.Message       'show error message on label
            Return                                                                  'and exit function
        End Try

        If (imgOriginal Is Nothing) Then                                  'if image could not be opened
            lblChosenFile.Text = "unable to open image"                 'show error message on label
            Return                                                      'and exit function
        End If
                                                            'if we get here we know the file opened successfully
        lblChosenFile.Text = ofdOpenFile.FileName
        
        ProcessImage()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub cbUseWebcam_CheckedChanged(sender As Object, e As EventArgs) Handles cbUseWebcam.CheckedChanged
        If (cbUseWebcam.Checked = True) Then
            Try
                capWebcam = New Capture(0)                  'associate the capture object to the default webcam
            Catch ex As Exception                           'catch error if unsuccessful
                                                            'show error via message box
                MessageBox.Show("unable to read from webcam, error: " + Environment.NewLine + Environment.NewLine + ex.Message)
                Return
            End Try

            AddHandler Application.Idle, New EventHandler(AddressOf Me.GetFrameFromWebcam)        'add process image function to the application's list of tasks
            blnWebcamCapturingInProcess = True

        ElseIf (cbUseWebcam.Checked = False) Then

            If(blnWebcamCapturingInProcess = True) Then
                RemoveHandler Application.Idle, New EventHandler(AddressOf Me.GetFrameFromWebcam)
                blnWebcamCapturingInProcess = False
                CvInvoke.DestroyAllWindows()
            End If

        Else
            'should never get here
        End If
        
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub cbShowSteps_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowSteps.CheckedChanged

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Sub GetFrameFromWebcam(sender As Object, arg As EventArgs)
        
        imgOriginal = capWebcam.QueryFrame()
        
        If (imgOriginal Is Nothing) Then         'if we did not get a frame
            MessageBox.Show("unable to read frame from webcam")
            Return
        End If
                                 'if we get here we know the frame opened successfully            
        ProcessImage()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub cbDrawShapesOnOriginalImage_CheckedChanged(sender As Object, e As EventArgs) Handles cbDrawShapesOnOriginalImage.CheckedChanged
        
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub cbEnableColorFiltering_CheckedChanged(sender As Object, e As EventArgs) Handles cbEnableColorFiltering.CheckedChanged

        If (cbEnableColorFiltering.Checked = True) Then

            lblBlueMin.Enabled = True
            lblBlueMax.Enabled = True
            lblGreenMin.Enabled = True
            lblGreenMax.Enabled = True
            lblRedMin.Enabled = True
            lblRedMax.Enabled = True

            tbBlueMin.Enabled = True
            tbBlueMax.Enabled = True
            tbGreenMin.Enabled = True
            tbGreenMax.Enabled = True
            tbRedMin.Enabled = True
            tbRedMax.Enabled = True
            
        ElseIf (cbEnableColorFiltering.Checked = False) Then

            tbBlueMin.Enabled = False
            tbBlueMax.Enabled = False
            tbGreenMin.Enabled = False
            tbGreenMax.Enabled = False
            tbRedMin.Enabled = False
            tbRedMax.Enabled = False

            lblBlueMin.Enabled = False
            lblBlueMax.Enabled = False
            lblGreenMin.Enabled = False
            lblGreenMax.Enabled = False
            lblRedMin.Enabled = False
            lblRedMax.Enabled = False

            tbBlueMin.Value = 0
            tbBlueMax.Value = 255
            tbGreenMin.Value = 0
            tbGreenMax.Value = 255
            tbRedMin.Value = 0
            tbRedMax.Value = 255

        End If

        tbBlueMin_Scroll(New Object(), New EventArgs())
        tbBlueMax_Scroll(New Object(), New EventArgs())
        tbGreenMin_Scroll(New Object(), New EventArgs())
        tbGreenMax_Scroll(New Object(), New EventArgs())
        tbRedMin_Scroll(New Object(), New EventArgs())
        tbRedMax_Scroll(New Object(), New EventArgs())

        

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub tbBlueMin_Scroll(sender As Object, e As EventArgs) Handles tbBlueMin.Scroll
        lblBlueMin.Text = "Blue Min = " + tbBlueMin.Value.ToString.PadLeft(3)
        ProcessImage()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub tbBlueMax_Scroll(sender As Object, e As EventArgs) Handles tbBlueMax.Scroll
        lblBlueMax.Text = "Blue Max = " + tbBlueMax.Value.ToString.PadLeft(3)
        ProcessImage()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub tbGreenMin_Scroll(sender As Object, e As EventArgs) Handles tbGreenMin.Scroll
        lblGreenMin.Text = "Green Min = " + tbGreenMin.Value.ToString.PadLeft(3)
        ProcessImage()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub tbGreenMax_Scroll(sender As Object, e As EventArgs) Handles tbGreenMax.Scroll
        lblGreenMax.Text = "Green Max = " + tbGreenMax.Value.ToString.PadLeft(3)
        ProcessImage()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub tbRedMin_Scroll(sender As Object, e As EventArgs) Handles tbRedMin.Scroll
        lblRedMin.Text = "Red Min = " + tbRedMin.Value.ToString.PadLeft(3)
        ProcessImage()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub tbRedMax_Scroll(sender As Object, e As EventArgs) Handles tbRedMax.Scroll
        lblRedMax.Text = "Red Max = " + tbRedMax.Value.ToString.PadLeft(3)
        ProcessImage()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Sub ProcessImage()
        If (imgOriginal Is Nothing) Then
            Return
        End If

        If (imgOriginal.IsEmpty) Then
            Return
        End If

        Dim imgOriginalWithDrawing As New Mat(imgOriginal.Size, DepthType.Cv8U, 3)
        Dim imgOriginalBlurred As New Mat(imgOriginal.Size, DepthType.Cv8U, 3)
        Dim imgGrayscaleColorFiltered As New Mat(imgOriginal.Size, DepthType.Cv8U, 1)
        Dim imgCanny As New Mat(imgOriginal.Size, DepthType.Cv8U, 1)
        Dim imgContours As New Mat(imgOriginal.Size, DepthType.Cv8U, 1)
        Dim imgCircles As New Mat(imgOriginal.Size, DepthType.Cv8U, 3)
        Dim imgLines As New Mat(imgOriginal.Size, DepthType.Cv8U, 3)
        Dim imgShapes As New Mat(imgOriginal.Size, DepthType.Cv8U, 3)
        
        CvInvoke.GaussianBlur(imgOriginal, imgOriginalBlurred, New Size(5, 5), 0)

        If (cbEnableColorFiltering.Checked = False) Then                'if we are not filtering on color
                                                                        'do a simple conversion to grayscale
            CvInvoke.CvtColor(imgOriginalBlurred, imgGrayscaleColorFiltered, ColorConversion.Bgr2Gray)
        ElseIf (cbEnableColorFiltering.Checked = True) Then             'else if we are filtering on color
            Dim minBGRValues As New ScalarArray(New MCvScalar(tbBlueMin.Value, tbGreenMin.Value, tbRedMin.Value))       'get the min values from the track bars
            Dim maxBGRValues As New ScalarArray(New MCvScalar(tbBlueMax.Value, tbGreenMax.Value, tbRedMax.Value))       'get the max values from the track bars
            CvInvoke.InRange(imgOriginalBlurred, minBGRValues, maxBGRValues, imgGrayscaleColorFiltered)                  'and filter on color
        End If
        
        Dim circles As CircleF() = CvInvoke.HoughCircles(imgGrayscaleColorFiltered, HoughType.Gradient, 2.0, imgGrayscaleColorFiltered.Rows / 4)
        
        For Each circle As CircleF In circles
            CvInvoke.Circle(imgCircles, New Point(CInt(circle.Center.X), CInt(circle.Center.Y)), CInt(circle.Radius), SCALAR_RED, 2)
            If (cbDrawShapesOnOriginalImage.Checked = True) Then
                CvInvoke.Circle(imgOriginalWithDrawing, New Point(CInt(circle.Center.X), CInt(circle.Center.Y)), CInt(circle.Radius), SCALAR_RED, 2)
            End If
        Next

        CvInvoke.Canny(imgGrayscaleColorFiltered, imgCanny, 100, 200)

        Dim lines As LineSegment2D() = CvInvoke.HoughLinesP(imgCanny, 1.0, Math.PI / 180.0, 20, 30, 10)

        For Each line As LineSegment2D In lines
            CvInvoke.Line(imgLines, line.P1, line.P2, SCALAR_GREEN, 2)
            If (cbDrawShapesOnOriginalImage.Checked = True) Then
                CvInvoke.Line(imgOriginalWithDrawing, line.P1, line.P2, SCALAR_GREEN, 2)
            End If
        Next

        Dim vectorOfContours As New VectorOfVectorOfPoint()
        Dim listOfContours As New List(Of VectorOfPoint)

        Dim listOfTriangles As New List(Of Triangle2DF)()
        Dim listOfRectangles As New List(Of RotatedRect)()
        Dim listOfPolygons As New List(Of VectorOfPoint)()
        
        Dim imgCopyOfCanny As Mat = imgCanny.Clone()

        CvInvoke.FindContours(imgCopyOfCanny, vectorOfContours, Nothing, RetrType.External, ChainApproxMethod.ChainApproxSimple)
        
        CvInvoke.DrawContours(imgContours, vectorOfContours, -1, New MCvScalar(255.0), 1)

        For i As Integer = 0 To vectorOfContours.Size - 1
            Dim contour As New VectorOfPoint()

            Dim dummyContour As VectorOfPoint = vectorOfContours(i)

            CvInvoke.ApproxPolyDP(vectorOfContours(i), contour, CvInvoke.ArcLength(vectorOfContours(i), True) * 0.05, True)
            
            If (CvInvoke.ContourArea(contour) > MIN_CONTOUR_AREA) Then
                listOfContours.Add(contour)
            End If
        Next

        For Each contour As VectorOfPoint In listOfContours
            If (contour.Size = 3) Then
                listOfTriangles.Add(New Triangle2DF(contour(0), contour(1), contour(2)))
            ElseIf (contour.Size >= 4 And contour.Size <= 7) Then
                Dim points As Point() = contour.ToArray()
                Dim blnIsRectangle As Boolean = True

                If (contour.Size = 4) Then
                    Dim edges As LineSegment2D() = PointCollection.PolyLine(points, True)

                    For i As Integer = 0 To edges.Length - 1
                        Dim dblAngle As Double = Math.Abs(edges((i + 1) Mod edges.Length).GetExteriorAngleDegree(edges(i)))
                        If (dblAngle < 80.0 Or dblAngle > 100.0) Then
                            blnIsRectangle = False
                            Exit For
                        End If
                    Next
                Else
                    blnIsRectangle = False
                End If

                If (blnIsRectangle) Then
                    listOfRectangles.Add(CvInvoke.MinAreaRect(contour))
                Else
                    listOfPolygons.Add(contour)
                End If
                
            End If
            
        Next
                'at this point we're done finding/calculating stuff, now time to draw stuff
        
        For Each triangle As Triangle2DF In listOfTriangles
            DrawTriangle(imgShapes, triangle, SCALAR_YELLOW, 2)
            If (cbDrawShapesOnOriginalImage.Checked = True)
                DrawTriangle(imgOriginalWithDrawing, triangle, SCALAR_YELLOW, 2)
            End If
        Next

        For Each rect As RotatedRect In listOfRectangles
            DrawRotatedRect(imgShapes, rect, SCALAR_BLUE, 2)
            If (cbDrawShapesOnOriginalImage.Checked = True)
                DrawRotatedRect(imgOriginalWithDrawing, rect, SCALAR_BLUE, 2)
            End If
        Next
        
        Dim vectorOfPolygons As New VectorOfVectorOfPoint()

        For i As Integer = 0 To listOfPolygons.Count - 1
            vectorOfPolygons.Push(listOfPolygons(i))
        Next

        CvInvoke.DrawContours(imgShapes, vectorOfPolygons, -1, SCALAR_GRAY, 2)

        If (cbDrawShapesOnOriginalImage.Checked) Then
            ibOriginal.Image = imgOriginalWithDrawing
        Else
            ibOriginal.Image = imgOriginal
        End If
        
        If (cbShowSteps.Checked) Then
            CvInvoke.Imshow("imgOriginal", imgOriginal)
            CvInvoke.Imshow("imgOriginalWithDrawing", imgOriginalWithDrawing)
            CvInvoke.Imshow("imgOriginalBlurred", imgOriginalBlurred)
            CvInvoke.Imshow("imgGrayscaleColorFiltered", imgGrayscaleColorFiltered)
            CvInvoke.Imshow("imgCanny", imgCanny)
            CvInvoke.Imshow("imgContours", imgContours)
            CvInvoke.Imshow("imgCircles", imgCircles)
            CvInvoke.Imshow("imgLines", imgLines)
            CvInvoke.Imshow("imgShapes", imgShapes)
        Else
            CvInvoke.DestroyAllWindows()
        End If
        
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Sub DrawTriangle(image As Mat, triangle As Triangle2DF, color As MCvScalar, intLineThickness As Integer)
        Dim ptfRectPoints(3) As PointF

        ptfRectPoints = triangle.GetVertices()

        Dim pt0 As New Point(CInt(ptfRectPoints(0).X), CInt(ptfRectPoints(0).Y))
        Dim pt1 As New Point(CInt(ptfRectPoints(1).X), CInt(ptfRectPoints(1).Y))
        Dim pt2 As New Point(CInt(ptfRectPoints(2).X), CInt(ptfRectPoints(2).Y))

        CvInvoke.Line(image, pt0, pt1, color, 2)
        CvInvoke.Line(image, pt1, pt2, color, 2)
        CvInvoke.Line(image, pt2, pt0, color, 2)
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Sub DrawRotatedRect(image As Mat, rotatedRect As RotatedRect, color As MCvScalar, intLineThickness As Integer)
        Dim ptfRectPoints(4) As PointF

        ptfRectPoints = rotatedRect.GetVertices()

        Dim pt0 As New Point(CInt(ptfRectPoints(0).X), CInt(ptfRectPoints(0).Y))
        Dim pt1 As New Point(CInt(ptfRectPoints(1).X), CInt(ptfRectPoints(1).Y))
        Dim pt2 As New Point(CInt(ptfRectPoints(2).X), CInt(ptfRectPoints(2).Y))
        Dim pt3 As New Point(CInt(ptfRectPoints(3).X), CInt(ptfRectPoints(3).Y))

        CvInvoke.Line(image, pt0, pt1, color, 2)
        CvInvoke.Line(image, pt1, pt2, color, 2)
        CvInvoke.Line(image, pt2, pt3, color, 2)
        CvInvoke.Line(image, pt3, pt0, color, 2)

    End Sub
    
End Class

