<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Legacy1.aspx.cs" Inherits="DefaultHome" %>

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
	       
	           	
                <asp:Label ID="labelShowBox" runat="server" Text="Hi, Harish" CssClass="styleFormHeader"></asp:Label>
        		<br/>
        		
	    </div>

	        <div class="mainFormRight" >
        		<header class="styleFormHeader">    
        			All Available:
        		</header>
 				
	        	<br/>

				<asp:Panel ID="panelAll" runat="server" CssClass="mainFormRightMove" ondrop="drop(event)" ondragover="allowDrop(event)"  >
	
                    
                    <asp:Image ID="drag001" runat="server" src="Assets/Images/a1.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" ondragend=""/>
                    <asp:Image ID="drag002" runat="server" src="Assets/Images/a2.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)"  />
                    <asp:Image ID="drag003" runat="server" src="Assets/Images/a3.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag004" runat="server" src="Assets/Images/a4.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag005" runat="server" src="Assets/Images/a5.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag006" runat="server" src="Assets/Images/a6.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag007" runat="server" src="Assets/Images/a7.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag008" runat="server" src="Assets/Images/a8.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag009" runat="server" src="Assets/Images/a9.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag010" runat="server" src="Assets/Images/a10.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag011" runat="server" src="Assets/Images/a11.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag012" runat="server" src="Assets/Images/a12.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag013" runat="server" src="Assets/Images/a13.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag014" runat="server" src="Assets/Images/a14.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    
                    <asp:Image ID="drag016" runat="server" src="Assets/Images/a16.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag017" runat="server" src="Assets/Images/a17.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag018" runat="server" src="Assets/Images/a18.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag019" runat="server" src="Assets/Images/a19.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag020" runat="server" src="Assets/Images/a20.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag021" runat="server" src="Assets/Images/a21.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag022" runat="server" src="Assets/Images/a22.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag023" runat="server" src="Assets/Images/a23.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                     
                    <asp:Image ID="drag025" runat="server" src="Assets/Images/a25.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag027" runat="server" src="Assets/Images/a27.png" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag028" runat="server" src="Assets/Images/a28.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag029" runat="server" src="Assets/Images/a29.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                    <asp:Image ID="drag030" runat="server" src="Assets/Images/a30.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                   

                    <asp:Image ID="Image5" runat="server" src="Assets/Images/a30.jpg" CssClass="navLinkButton" draggable="true" ondragstart="drag(event)" />
                </asp:Panel>
				<hr/>

                   
                <asp:Button ID="btnAdd" runat="server" Text="Add All" CssClass="navButton" OnClick="btnAdd_Click"  />
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
                
                    
                        <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="navButton" OnClick="btnSave_Click"/>
	                    <br />

                
                
                
                
                <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="navButton" />
	            <br/>
            </div>

            </form>

</body>
</html>