﻿Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Media
Imports Microsoft.Xna.Framework.Input

Public Class GameCore
    ' ENTITIES & OBJECTS
    Private _startScreen As StartScreen

    Public Sub New()

    End Sub

    Public Sub Load()
        _startScreen = New StartScreen
    End Sub

    Private Sub UpdateCamera()

    End Sub

    Public Sub Update()
        UpdateCamera()
        _startScreen.Update()
    End Sub

    Public Sub Draw()
        Globals.SpriteBatch.Begin(transformMatrix:=Globals.Camera)

        _startScreen.Draw()

        Globals.SpriteBatch.End()
    End Sub
End Class
