var dropDown = document.getElementById('dropDown');
var myMenu = document.getElementById('myMenu');
var isOpen = false;
dropDown.onclick = function ()
{
    if (isOpen == false) {
        myMenu.style.display = 'block';
        isOpen = true;
    }
    else
    {
        myMenu.style.display = 'none';
        isOpen = false;
    }
}