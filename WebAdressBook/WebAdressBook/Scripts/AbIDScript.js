var OnButtonClickHandler = function () {
    var val = document.getElementById("idInput").value;
    sendPostRequest("..//api/AdressBooksWebApi/GetAdressBookItem", JSON.stringify({ abID: val }), AddResponseToPage)
}

var sendPostRequest = function (link, body, callback) {
    var xhr = new XMLHttpRequest();

    xhr.open("POST", link, true);
    xhr.setRequestHeader('Content-Type', 'application/json;charset=UTF-8');
    xhr.setRequestHeader('Accept', 'application/xml');
    xhr.setRequestHeader('X-Requested-With', 'XMLHttpRequest');
    xhr.onreadystatechange =
        function () {
            callback(this.responseText);
        };

    xhr.send(body);
}

var AddResponseToPage = function (text) {
    var item = document.getElementById("responseContainer");
    text = text.replace(/></g, '>\r\t<');
    text = text.replace(/\t<\//g, '<\/');
    
    
    item.innerHTML = '<textarea style="width: 100%; max-width: 100%; height: 400px;">' + text + '</textarea>';
}

var SetButtonEnabled = function (enable) {
    document.getElementById('idSubmit').disabled = !enable;
}


var SetEventHandlers = function () {
    document.getElementById('idInput').addEventListener('change', function () {
        var val = document.getElementById('idInput').value;
        SetButtonEnabled(val >= 0);
    }, false);

    document.getElementById('idSubmit').onclick = function () {
        OnButtonClickHandler();
    }
}

SetEventHandlers();