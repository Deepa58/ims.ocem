Imports System.Data.SqlClient
Public Class Product
    Dim con As New sqlconnection("Data Source=DPACE\SQLEXPRESS01;Initial Catalog=Inventorydb;Integrated Security=True)
   
     Private Sub btnadd_Click(sender As Object, e As EventArgs") Handles btnadd.Click
    Con.open()
    Dim query As String 
    query="Insert into ProductTbl values("& txtprodid.Text &".'"& txtprodname.Text &"',"& txtquantity.Text &","& txtprice.Text &",'"& txtcatagory.selecteditems.value() &"')"
    Dim cmd As sqlcommand
    cmd=new sqlcommand(query.con)
    cmd.ExecuteNonQuery()
    Msgbox("product added successfully")
    Con.close()
    End Sub
End Class