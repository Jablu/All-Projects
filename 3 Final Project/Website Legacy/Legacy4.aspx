<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Legacy4.aspx.cs" Inherits="MyFavorites" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dragable Web</title>
    <link href="Assets/CSS/myStyleSheet.css" rel="stylesheet" />
    <script src="Assets/JS/myScript.js"></script>
    

</head>
<body>
    <div class="myHeader">
        <header class="styleHeading">    
        Drag and Drop Demo
        </header>
    </div>
	   
		<form runat="server">
			<br />
            <div class="mainFormRight">
	       
	           	
                <asp:Label ID="labelShowBox" runat="server" Text="Label" CssClass="styleFormHeader"></asp:Label>
        		<br/>
        		
	    </div>

	        
            <div class="mainFormRight">
	       
	           	<header class="styleFormHeader">    
        			My Favorites:
        		</header>
        		<br/>
        		

				
        		<asp:Panel ID="panelFav" runat="server" CssClass="mainFormRightMove" ondrop="drop(event)" ondragover="allowDrop(event)" >

                </asp:Panel>
				<hr/>


                
                <asp:Button ID="btnReset" runat="server" Text="Configure" CssClass="navButton" />
	            <br/>
            </div>
            </form>

</body>
</html>
