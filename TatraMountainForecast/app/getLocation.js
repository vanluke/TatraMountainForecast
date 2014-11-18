function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition, error);
    } else {
        alert('Unable to fetch data.');
    }
}

function showPosition(position) {
    var crd = position.coords;
    var obj = { latitude: crd.latitude, longitude: crd.longitude };
    $.ajax({
        url: '/Home/GeoLocation',
        type: 'post',
        async: true,
        success: function(data) {
            
        },
        error: function(one, two, three) {
            
        },
        contentType: 'application/json',
        dataType: 'json',
        data: JSON.stringify(obj)
    });
}
function error(err) {
    console.warn('ERROR(' + err.code + '): ' + err.message);
    alert('Unable to fetch data.');
}

function test() {
    $.get("http://ipinfo.io", function (response) {
        console.log(response.city, response.region, response.country);
    }, "jsonp");
}

window.onload = function() {
    //getLocation();
    //test();
};