﻿
Imports mpFormulaVB

Module Program
    
    Sub Main()
        
	    Console.ForegroundColor = ConsoleColor.Black
        Console.BackgroundColor = ConsoleColor.White
        Console.Clear()
        Console.BufferHeight = 10000      'Int16.MaxValue -1
	    Console.BufferWidth = 400

        
'        MpfMain()
'        MpcMain()
'        MpiMain()
'        MpciMain
        MpfMatMain()
'        MpiMatMain()
        
        Console.WriteLine("Press the key q to exit . . . ")
        Console.SetCursorPosition(0,0)
		Dim info As ConsoleKeyInfo
		Dim ch As String
		ch = ""
		While (ch <> "q")
    		info = Console.ReadKey(True)
    		ch = info.KeyChar.ToString()
		End While
        
    End Sub
End Module
