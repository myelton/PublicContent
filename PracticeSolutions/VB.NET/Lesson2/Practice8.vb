﻿Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Carto

Public Class Practice8
    Inherits ESRI.ArcGIS.Desktop.AddIns.Button

    Public Sub New()

    End Sub

    Public Sub Practice8()


        Dim pMxDoc As IMxDocument

        pMxDoc = My.ArcMap.Application.Document

        Dim pMap As IMap

        pMap = pMxDoc.FocusMap

        Dim pLayer As ILayer

        pLayer = pMap.Layer(0)

        pLayer.ShowTips = True


    End Sub

    Protected Overrides Sub OnClick()
        Call Practice8()
    End Sub

    Protected Overrides Sub OnUpdate()

    End Sub
End Class
