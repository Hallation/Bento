Public Class Form1
    Dim Total As Single
    Dim Weight As Integer
    Dim DeliveryCost As Single
    Dim Discount As Single = 1
    Dim BoxNumber As Integer = 1
    Dim DeliveryFlag As Boolean = False
    Dim MeatFlag As Boolean = False
    Dim DessertFlag As Boolean = False
    Dim SauceFlag As Boolean = False
    Dim VegetaFlag As Boolean = False
    Dim BaseFlag As Boolean = False
    Dim TestFlag As Boolean = False
    Private Sub Menu_Load() 'function to load all the items into the combo boxes
        'meats
        cmbMeat.Items.Add("Tuna Fillet 50g $1.75")
        cmbMeat.Items.Add("Chicken Tenders 75g $1.60")
        cmbMeat.Items.Add("Beef Meatballs 100g $1.55")
        'vegetables
        cmbVegeta.Items.Add("Asparagus 15g $0.20")
        cmbVegeta.Items.Add("Carrot 15g $0.10")
        cmbVegeta.Items.Add("Snow Peas 15g $0.15")
        'basest base
        cmbBase.Items.Add("Rice 175g $0.30")
        cmbBase.Items.Add("Ravioli 175g $0.45")
        cmbBase.Items.Add("Noodles 175g $0.25")
        'sauces
        cmbSauce.Items.Add("Satay Sauce 10g $0.10")
        cmbSauce.Items.Add("Tomato Sauce 10g $0.05")
        cmbSauce.Items.Add("Chilli Sauce 10g $0.05")
        'desserts
        cmbDessert.Items.Add("Kiwi Fruit 60g $0.95")
        cmbDessert.Items.Add("Sesame Cookies 65g $1.10")
        cmbDessert.Items.Add("Peach Yogurt 70g $0.85")
    End Sub

    Private Sub ifnot_addingitems()
        'if there is text in any of the combo boxes, it is added into the listbox and then the corrosponding combo box is disabled
        If Not cmbMeat.Text = "" Then
            lstBento.Items.Add(cmbMeat.SelectedItem + " x " + CStr(numMeat.Value))
            cmbMeat.Items.Remove(cmbMeat.SelectedItem)
            MeatFlag = True
        End If
        If Not cmbVegeta.Text = "" Then
            lstBento.Items.Add(cmbVegeta.SelectedItem + " x " + CStr(numVegetable.Value))
            cmbVegeta.Items.Remove(cmbVegeta.SelectedItem)
            VegetaFlag = True
        End If
        If Not cmbBase.Text = "" Then
            lstBento.Items.Add(cmbBase.SelectedItem + " x " + CStr(numBase.Value))
            cmbBase.Items.Remove(cmbBase.SelectedItem)
            BaseFlag = True
        End If
        If Not cmbSauce.Text = "" Then
            lstBento.Items.Add(cmbSauce.SelectedItem + " x " + CStr(numSauce.Value))
            cmbSauce.Items.Remove(cmbSauce.SelectedItem)
            SauceFlag = True
        End If
        If Not cmbDessert.Text = "" Then
            lstBento.Items.Add(cmbDessert.SelectedItem + " x " + CStr(numDessert.Value))
            cmbDessert.Items.Remove(cmbDessert.SelectedItem)
            DessertFlag = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Weight2 As Single 'local variables for message box flagging
        Dim Total2 As Single
        'if there is not text in the combo boxes, a message box is alerted to select an item first
        If cmbBase.Text + cmbMeat.Text + cmbDessert.Text + cmbSauce.Text + cmbVegeta.Text = "" Then
            MsgBox("Please select an item from one of the drop down boxes")
        Else
            'if the messageblox flag is false then it finds which combo box has text in it,
            'a select case is used to find the weight and total and put into the local variables weight2 and total2
            If DeliveryFlag = False Then
                If Not cmbMeat.Text = "" Then
                    Select Case cmbMeat.Text
                        Case "Tuna Fillet 50g $1.75" : Weight2 += 50 * numMeat.Value
                            Total2 += 1.75 * numMeat.Value
                        Case "Chicken Tenders 75g $1.60" : Weight2 += 75 * numMeat.Value
                            Total2 += 1.6 * numMeat.Value
                        Case "Beef Meatballs 100g $1.55" : Weight2 += 100 * numMeat.Value
                            Total2 += 1.55 * numMeat.Value
                    End Select
                End If
                If Not cmbVegeta.Text = "" Then
                    Select Case cmbVegeta.Text
                        Case "Asparagus 15g $0.20" : Weight2 += 15 * numVegetable.Value
                            Total2 += 0.2 * numVegetable.Value
                        Case "Carrot 15g $0.10" : Weight2 += 15 * numVegetable.Value
                            Total += 0.1 * numVegetable.Value
                        Case "Snow Peas 15g $0.15" : Weight2 += 15 * numVegetable.Value
                            Total2 += 0.15 * numVegetable.Value
                    End Select
                End If
                If Not cmbBase.Text = "" Then
                    Select Case cmbBase.Text
                        Case "Rice 175g $0.30" : Weight2 += 175 * numBase.Value
                            Total2 += 0.3 * numBase.Value
                        Case "Ravioli 175g $0.45" : Weight2 += 175 * numBase.Value
                            Total += 0.45 * numBase.Value
                        Case "Noodles 175g $0.25" : Weight2 += 175 * numBase.Value
                            Total2 += 0.25 * numBase.Value
                    End Select

                End If
                If Not cmbSauce.Text = "" Then
                    Select Case cmbSauce.Text
                        Case "Satay Sauce 10g $0.10" : Weight2 += 10 * numSauce.Value
                            Total2 += 0.1 * numSauce.Value
                        Case "Tomato Sauce 10g $0.05" : Weight2 += 10 * numSauce.Value
                            Total2 += 0.05 * numSauce.Value
                        Case "Chilli Sauce 10g $0.05" : Weight2 += 10 * numSauce.Value
                            Total2 += 0.05 * numSauce.Value
                    End Select

                End If

                If Not cmbDessert.Text = "" Then
                    Select Case cmbDessert.Text
                        Case "Kiwi Fruit 60g $0.95" : Weight2 += 60 * numDessert.Value
                            Total2 += 0.95 * numDessert.Value
                        Case "Sesame Cookies 65g $1.10" : Weight2 += 65 * numDessert.Value
                            Total2 += 1.1 * numDessert.Value
                        Case "Peach Yogurt 70g $0.85" : Weight2 += 70 * numDessert.Value
                            Total2 += 0.85 * numDessert.Value
                    End Select
                End If
                'if the original weight + weight2(local) is = or > than 500 a message box shows up alerting the user the weight will be over 500g and the delivery cost will increase
                'if the user clicks yes to continue, the delivery flag is enabled and the messagebox will not show up until the program is resetted
                'otherwise if weight + weight2 does not equal to 500 or greater the total2 is added into the real total variable, as well for the weight.
                If Weight + Weight2 >= 500 Then
                    Dim Answer As Integer = MsgBox("The weight is going to exceed 500g, the delivery cost will be $1.45. Are you sure you want to conitnue?", MsgBoxStyle.YesNo)
                    If Answer = vbYes Then
                        Total += Total2
                        Weight += Weight2
                        ifnot_addingitems() 'subfunction >refer to private sub ifnot_addingitems()
                        DeliveryFlag = True
                    End If
                Else
                    Total += Total2
                    Weight += Weight2
                    ifnot_addingitems() 'subfunction > refer to private sub ifnot_addingitems()
                End If
            Else 'if the delivery flag has been enabled a case is selected for each of the combo boxes is used to determing weight/total
                If Not cmbMeat.Text = "" Then
                    Select Case cmbMeat.Text
                        Case "Tuna Fillet 50g $1.75" : Weight += 50 * numMeat.Value
                            Total += 1.75 * numMeat.Value
                        Case "Chicken Tenders 75g $1.60" : Weight += 75 * numMeat.Value
                            Total += 1.6 * numMeat.Value
                        Case "Beef Meatballs 100g $1.55" : Weight += 100 * numMeat.Value
                            Total += 1.55 * numMeat.Value
                    End Select

                End If
                If Not cmbVegeta.Text = "" Then
                    Select Case cmbVegeta.Text
                        Case "Asparagus 15g $0.20" : Weight += 15 * numVegetable.Value
                            Total += 0.2 * numVegetable.Value
                        Case "Carrot 15g $0.10" : Weight += 15 * numVegetable.Value
                            Total += 0.1 * numVegetable.Value
                        Case "Snow Peas 15g $0.15" : Weight += 15 * numVegetable.Value
                            Total += 0.15 * numVegetable.Value
                    End Select
                End If
                If Not cmbBase.Text = "" Then
                    Select Case cmbBase.Text
                        Case "Rice 175g $0.30" : Weight += 175 * numBase.Value
                            Total += 0.3 * numBase.Value
                        Case "Ravioli 175g $0.45" : Weight += 175 * numBase.Value
                            Total += 0.45 * numBase.Value
                        Case "Noodles 175g $0.25" : Weight += 175 * numBase.Value
                            Total += 0.25 * numBase.Value
                    End Select

                End If
                If Not cmbSauce.Text = "" Then
                    Select Case cmbSauce.Text
                        Case "Satay Sauce 10g $0.10" : Weight += 10 * numSauce.Value
                            Total += 0.1 * numSauce.Value
                        Case "Tomato Sauce 10g $0.05" : Weight += 10 * numSauce.Value
                            Total += 0.05 * numSauce.Value
                        Case "Chilli Sauce 10g $0.05" : Weight += 10 * numSauce.Value
                            Total += 0.05 * numSauce.Value
                    End Select

                End If

                If Not cmbDessert.Text = "" Then
                    Select Case cmbDessert.Text
                        Case "Kiwi Fruit 60g $0.95" : Weight += 60 * numDessert.Value
                            Total += 0.95 * numDessert.Value
                        Case "Sesame Cookies 65g $1.10" : Weight += 65 * numDessert.Value
                            Total += 1.1 * numDessert.Value
                        Case "Peach Yogurt 70g $0.85" : Weight += 70 * numDessert.Value
                            Total += 0.85 * numDessert.Value
                    End Select
                End If
                ifnot_addingitems() 'sub function > refer private sub ifnot_addingitems()
            End If
            'all the num up down boxes are resetted to 1
            numBase.Value = 1
            numDessert.Value = 1
            numMeat.Value = 1
            numSauce.Value = 1
            numVegetable.Value = 1
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Menu_Load()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'if the list item count is =5 then the add button is disabled and the checkbox is enabled, the receipt button is enabled
        If lstBento.Items.Count() = 5 Then
            chk2Box.Enabled = True
            btnAdd.Enabled = False
            btnReceipt.Enabled = True
        Else
            chk2Box.Enabled = False
            btnAdd.Enabled = True
            btnReceipt.Enabled = False
        End If
        'if there is an item in the listbox the deliverycost is worked out
        'if the weight is >= 500 the deliverycost is $1.45 otherwise it is $0.95
        'if there is nothing in the listbox, deliverycost is $0.00
        If lstBento.Items.Count >= 1 Then
            btnClear.Enabled = True
            If Weight >= 500 Then
                DeliveryCost = 1.45
            ElseIf Weight <= 500 Then
                DeliveryCost = 0.95
            End If
        Else
            btnClear.Enabled = False
            DeliveryCost = 0
        End If

         
      
        'the variables are shown in the labels
        lblDelivery.Text = FormatCurrency(DeliveryCost)
        lblSubtotal.Text = FormatCurrency((Total + DeliveryCost) * Discount)
        lblGST.Text = FormatCurrency(((Total + DeliveryCost) * Discount) * 0.1)
        lblTotal.Text = FormatCurrency(((Total + DeliveryCost) * Discount) * 1.1)
        lblWeight.Text = CStr(Weight) + "g"

        'all these below to make sure they only select 1 of each.
        'when each flag is true, the corrosponding combo box is disabled
        'flags can be returned to false when deleting an item.
        If BaseFlag = True Then
            cmbBase.Enabled = False
        Else
            cmbBase.Enabled = True
        End If
        If MeatFlag = True Then
            cmbMeat.Enabled = False
        Else
            cmbMeat.Enabled = True
        End If
        If DessertFlag = True Then
            cmbDessert.Enabled = False
        Else
            cmbDessert.Enabled = True
        End If
        If VegetaFlag = True Then
            cmbVegeta.Enabled = False
        Else
            cmbVegeta.Enabled = True
        End If
        If SauceFlag = True Then
            cmbSauce.Enabled = False
        Else
            cmbSauce.Enabled = True
        End If

        If lstBento.SelectedIndex <= -1 Then
            btnDelete.Enabled = False
            btnEdit.Enabled = False
        Else
            btnDelete.Enabled = True
            btnEdit.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strArray() As String = Split(lstBento.SelectedItem, " ") 'string array to used to find the weight/total and deduct them from the variable
        Weight -= strArray(strArray.Length - 4).Replace("g", "") * strArray(strArray.Length - 1)
        Total -= strArray(strArray.Length - 3).Replace("$", "") * strArray(strArray.Length - 1)
        Dim multiplier As Integer = lstBento.SelectedItem.IndexOf(" x ") 'find the location of " x "
        Dim selecteditem As String = Microsoft.VisualBasic.Left(lstBento.SelectedItem, multiplier) 'obtain all the string until the location of " x " and move it into selecteditem
        Select Case selecteditem 'the chosen item has a case statement, the flag for each corrosponding item is used to re-enable the combo box
            'meats
            Case "Tuna Fillet 50g $1.75" : cmbMeat.Items.Add("Tuna Fillet 50g $1.75") : MeatFlag = False
            Case "Chicken Tenders 75g $1.60" : cmbMeat.Items.Add("Chicken Tenders 75g $1.60") : MeatFlag = False
            Case "Beef Meatballs 100g $1.55" : cmbMeat.Items.Add("Beef Meatballs 100g $1.55") : MeatFlag = False
                'vegetables  
            Case "Asparagus 15g $0.20" : cmbVegeta.Items.Add("Asparagus 15g $0.20") : VegetaFlag = False
            Case "Carrot 15g $0.10" : cmbVegeta.Items.Add("Carrot 15g $0.10") : VegetaFlag = False
            Case "Snow Peas 15g $0.15" : cmbVegeta.Items.Add("Snow Peas 15g $0.15") : VegetaFlag = False
                'baseses
            Case "Rice 175g $0.30" : cmbBase.Items.Add("Rice 175g $0.30") : BaseFlag = False
            Case "Ravioli 175g $0.45" : cmbBase.Items.Add("Ravioli 175g $0.45") : BaseFlag = False
            Case "Noodles 175g $0.25" : cmbBase.Items.Add("Noodles 175g $0.25") : BaseFlag = False
                'sauces
            Case "Satay Sauce 10g $0.10" : cmbSauce.Items.Add("Satay Sauce 10g $0.10") : SauceFlag = False
            Case "Tomato Sauce 10g $0.05" : cmbSauce.Items.Add("Tomato Sauce 10g $0.05") : SauceFlag = False
            Case "Chilli Sauce 10g $0.05" : cmbSauce.Items.Add("Chilli Sauce 10g $0.05") : SauceFlag = False
                'desserts
            Case "Kiwi Fruit 60g $0.95" : cmbDessert.Items.Add("Kiwi Fruit 60g $0.95") : DessertFlag = False
            Case "Sesame Cookies 65g $1.10" : cmbDessert.Items.Add("Sesame Cookies 65g $1.10") : DessertFlag = False
            Case "Peach Yogurt 70g $0.85" : cmbDessert.Items.Add("Peach Yogurt 70g $0.85") : DessertFlag = False
        End Select
        lstBento.Items.Remove(lstBento.SelectedItem)
    End Sub

    Private Sub chk2Box_Click(sender As Object, e As EventArgs) Handles chk2Box.Click
        'once the checkbox is checked, the discount is 0.8 (20%)
        'otherwise it is 1
        'boxnumber used in receipt
        'if the user clicks on the checkbox and the checkbox is checked, it checks if the dleiveryflag has been turned to true
        'if not the weight is * 2, the weight * 2 is >= 500 then the messagebox comes up confirming the user wants the deliverycost to be $1.45 otherwise the checkbox is unchecked
        'if the flag IS true then the number of boxes is 2, the weight and total are * 2 and discount is .8
        'when clicking on the checkbox to return it to unchecked, the weight/total are /2, boxnumber = 1 and the discount is returned to 1
        If chk2Box.Checked = True Then
            If DeliveryFlag = False Then
                If Weight * 2 >= 500 Then
                    Dim Answer As Integer = MsgBox("The weight is going to exceed 500g, the delivery cost will be $1.45. Are you sure you want to conitnue?", MsgBoxStyle.YesNo)
                    If Answer = vbYes Then
                        Weight *= 2
                        Total *= 2
                        DeliveryFlag = True
                        Discount = 0.8
                        BoxNumber = 2
                    Else
                        chk2Box.Checked = False
                        Discount = 1
                    End If
                Else
                    BoxNumber = 2
                    Weight *= 2
                    Total *= 2
                End If
            Else
                BoxNumber = 2
                Discount = 0.8
                Weight *= 2
                Total *= 2
            End If
        Else
            BoxNumber = 1
            Discount = 1
            Weight /= 2
            Total /= 2
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'entirely the same as the delete button, only difference the Quantity is put into their corrosponding numerical up down boxes
        Dim strArray() As String = Split(lstBento.SelectedItem, " ")
        Weight -= strArray(strArray.Length - 4).Replace("g", "") * strArray(strArray.Length - 1)
        Total -= strArray(strArray.Length - 3).Replace("$", "") * strArray(strArray.Length - 1)
        Dim multiplier As Integer = lstBento.SelectedItem.IndexOf(" x ")
        Dim selecteditem As String = Microsoft.VisualBasic.Left(lstBento.SelectedItem, multiplier)
        Select Case selecteditem
            'meats
            Case "Tuna Fillet 50g $1.75" : cmbMeat.Items.Add("Tuna Fillet 50g $1.75") : MeatFlag = False : numMeat.Value = strArray(strArray.Length - 1)
                cmbMeat.Text = "Tuna Fillet 50g $1.75"
            Case "Chicken Tenders 75g $1.60" : cmbMeat.Items.Add("Chicken Tenders 75g $1.60") : MeatFlag = False : numMeat.Value = strArray(strArray.Length - 1)
                cmbMeat.Text = "Chicken Tenders 75g $1.60"
            Case "Beef Meatballs 100g $1.55" : cmbMeat.Items.Add("Beef Meatballs 100g $1.55") : MeatFlag = False : numMeat.Value = strArray(strArray.Length - 1)
                cmbMeat.Text = "Beef Meatballs 100g $1.55"
                'vegetables  
            Case "Asparagus 15g $0.20" : cmbVegeta.Items.Add("Asparagus 15g $0.20") : VegetaFlag = False : numVegetable.Value = strArray(strArray.Length - 1)
                cmbVegeta.Text = "Asparagus 15g $0.20"
            Case "Carrot 15g $0.10" : cmbVegeta.Items.Add("Carrot 15g $0.10") : VegetaFlag = False : numVegetable.Value = strArray(strArray.Length - 1)
                cmbVegeta.Text = "Carrot 15g $0.10"
            Case "Snow Peas 15g $0.15" : cmbVegeta.Items.Add("Snow Peas 15g $0.15") : VegetaFlag = False : numVegetable.Value = strArray(strArray.Length - 1)
                cmbVegeta.Text = "Snow Peas 15g $0.15"
                'baseses
            Case "Rice 175g $0.30" : cmbBase.Items.Add("Rice 175g $0.30") : BaseFlag = False : numBase.Value = strArray(strArray.Length - 1)
                cmbBase.Text = "Rice 175g $0.30"
            Case "Ravioli 175g $0.45" : cmbBase.Items.Add("Ravioli 175g $0.45") : BaseFlag = False : numBase.Value = strArray(strArray.Length - 1)
                cmbBase.Text = "Ravioli 175g $0.45"
            Case "Noodles 175g $0.25" : cmbBase.Items.Add("Noodles 175g $0.25") : BaseFlag = False : numBase.Value = strArray(strArray.Length - 1)
                cmbBase.Text = "Noodles 175g $0.25"
                'sauces
            Case "Satay Sauce 10g $0.10" : cmbSauce.Items.Add("Satay Sauce 10g $0.10") : SauceFlag = False : numSauce.Value = strArray(strArray.Length - 1)
                cmbSauce.Text = "Satay Sauce 10g $0.10"
            Case "Tomato Sauce 10g $0.05" : cmbSauce.Items.Add("Tomato Sauce 10g $0.05") : SauceFlag = False : numSauce.Value = strArray(strArray.Length - 1)
                cmbSauce.Text = "Satay Sauce 10g $0.10"
            Case "Chilli Sauce 10g $0.05" : cmbSauce.Items.Add("Chilli Sauce 10g $0.05") : SauceFlag = False : numSauce.Value = strArray(strArray.Length - 1)
                cmbSauce.Text = "Chilli Sauce 10g $0.05"
                'desserts
            Case "Kiwi Fruit 60g $0.95" : cmbDessert.Items.Add("Kiwi Fruit 60g $0.95") : DessertFlag = False : numDessert.Value = strArray(strArray.Length - 1)
                cmbDessert.Text = "Kiwi Fruit 60g $0.95"
            Case "Sesame Cookies 65g $1.10" : cmbDessert.Items.Add("Sesame Cookies 65g $1.10") : DessertFlag = False : numDessert.Value = strArray(strArray.Length - 1)
                cmbDessert.Text = "Sesame Cookies 65g $1.10"
            Case "Peach Yogurt 70g $0.85" : cmbDessert.Items.Add("Peach Yogurt 70g $0.85") : DessertFlag = False : numDessert.Value = strArray(strArray.Length - 1)
                cmbDessert.Text = "Peach Yogurt 70g $0.85"
        End Select
        lstBento.Items.Remove(lstBento.SelectedItem)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'confirmation if the user wants to clear the listbox, if yes all the items in the listbox and comboboxes are cleared.
        'the function used in form_load is again used to load the menu to re add all the items back into the combo boxes
        'everything else is resetted.
        Dim Answer As Integer = MsgBox("Are you sure you want to clear the listbox?", MsgBoxStyle.YesNo)
        If Answer = vbYes Then
            lstBento.Items.Clear()
            cmbBase.Items.Clear()
            cmbMeat.Items.Clear()
            cmbDessert.Items.Clear()
            cmbVegeta.Items.Clear()
            cmbSauce.Items.Clear()
            Weight = 0
            Total = 0
            chk2Box.Checked = False
            Menu_Load()
            MeatFlag = False
            BaseFlag = False
            SauceFlag = False
            VegetaFlag = False
            DessertFlag = False
        End If
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        'each line is used to write the desired line to of text to the current users desktop, into a text file named Receipt.
        Using Receipt As New IO.StreamWriter((Environ("USERPROFILE") & "\Desktop\Receipt.txt"))
            Receipt.WriteLine("             BENTO          ")
            Receipt.WriteLine("       ABN  2456 223 091 ")
            Receipt.WriteLine("------------------------------------")
            Receipt.WriteLine(BoxNumber.ToString + "x")
            'all the items in the listbox are added into the textbox
            For Each Str As String In lstBento.Items
                Receipt.WriteLine(Str)
            Next
            Receipt.WriteLine()
            Receipt.WriteLine("DELIVERY                      " + lblDelivery.Text)
            Receipt.WriteLine("GST                           " + lblGST.Text)
            Receipt.WriteLine("TOTAL                         " + lblTotal.Text)
            Receipt.WriteLine("------------------------------------")
            Receipt.WriteLine("       ENJOY YOUR BENTO BOX!  ")
            Receipt.Close()
        End Using
        MsgBox("Receipt is saved on the desktop")
        End 'terminates the program
    End Sub
End Class
