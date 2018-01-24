function allowDrop(ev) {
    ev.preventDefault();
}

function drag(ev) {
    ev.dataTransfer.setData("text", ev.target.id);
}

function drop(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    ev.target.appendChild(document.getElementById(data));
}

function addDraggedElement(ev) {

    var ele = ele + ev.dataTransfer.setData("text", ev.target.id+",");
    var hiddenControl = '<%= inpHide.ClientID %>';
    document.getElementById(hiddenControl).value = ele;
}