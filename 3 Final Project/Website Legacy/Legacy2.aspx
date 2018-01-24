<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Legacy2.aspx.vb" Inherits="Home" %>

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
	       
	           	
                <asp:Label ID="Label1" runat="server" Text="Label" CssClass="styleFormHeader"></asp:Label>
        		<br/>
        		
	    </div>

	        <div class="mainFormRight" >
        		<header class="styleFormHeader">    
        			All Available:
        		</header>
 				
	        	<br/>

				<div id="divLeft" class="mainFormRightMove" ondrop="drop(event)" ondragover="allowDrop(event)">
        			
        		
	        	<img src="Assets/Images/a1.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag1" />
				<img src="Assets/Images/a2.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag2"/>
				<img src="Assets/Images/a3.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag3" />
				<img src="Assets/Images/a4.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag4"/>
				<img src="Assets/Images/a5.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag5"/>
				<img src="Assets/Images/a6.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag6"/>
				<img src="Assets/Images/a7.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag7"/>
				<img src="Assets/Images/a8.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag8"/>
				<img src="Assets/Images/a9.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag9"/>
				<img src="Assets/Images/a10.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag10"/>
				<img src="Assets/Images/a11.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag11"/>
				<img src="Assets/Images/a12.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag12"/>
				<img src="Assets/Images/a13.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag13"/>
				<img src="Assets/Images/a14.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag14"/>

				<img src="Assets/Images/a16.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag16"/>
				<img src="Assets/Images/a17.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag17"/>
				<img src="Assets/Images/a18.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag18"/>
				<img src="Assets/Images/a19.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag19"/>
				<img src="Assets/Images/a20.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag20"/>
				<img src="Assets/Images/a21.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag21"/>
				<img src="Assets/Images/a22.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag22"/>
				<img src="Assets/Images/a23.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag23"/>

				<img src="Assets/Images/a25.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag25"/>

				<img src="Assets/Images/a27.png" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag27"/>
				<img src="Assets/Images/a28.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag28"/>
				<img src="Assets/Images/a29.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag29"/>
				<img src="Assets/Images/a30.jpg" class="navLinkButton" draggable="true" ondragstart="drag(event)" id="drag30"/>
</div>
				<hr/>
                <asp:Button ID="btnAdd" runat="server" Text="ADD ALL" CssClass="navButton" />
	            <br/>
	    </div>

            <div class="mainFormRight">
	       
	           	<header class="styleFormHeader">    
        			My Favorites:
        		</header>
        		<br/>
        		

				<div id="divRight" class="mainFormRightMove" ondrop="drop(event)" ondragover="allowDrop(event)">
				</div>
        		
				<hr/>

                <asp:Button ID="btnSave" runat="server" Text="SAVE" CssClass="navButton" />
	            <br/>
                <asp:Button ID="btnReset" runat="server" Text="RESET" CssClass="navButton" />
	            <br/>
            </div>

            </form>

</body>
</html>
