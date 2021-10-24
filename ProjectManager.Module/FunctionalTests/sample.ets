;#DropDB ProjectManagerEasyTest

#Application ProjectManagerWin
#Application ProjectManagerWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef ProjectManagerWin

*Action About...
 
*Action OK

#EndIf

#IfDef ProjectManagerWeb
*Action Navigation(My Details)
#EndIf
