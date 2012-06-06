
//<script type="text/javascript" charset="utf-8" src="../childbrowser.js"></script>


function onLoad() {

          
          document.addEventListener("deviceready", onDeviceReady, true);

     }

     function onDeviceReady(){

          navigator.notification.alert("PhoneGap is working");
  
     }
     
     function onGeoLocation(){
         navigator.geolocation.getCurrentPosition(onSuccess, onError);
     }

     // onSuccess Geolocation
     //
     function onSuccess(position) {
         var element = document.getElementById('geolocation');
         element.innerHTML = 'Latitude: '           + position.coords.latitude              + '<br />' +
                             'Longitude: '          + position.coords.longitude             + '<br />' +
                             'Altitude: '           + position.coords.altitude              + '<br />' +
                             'Accuracy: '           + position.coords.accuracy              + '<br />' +
                             'Altitude Accuracy: '  + position.coords.altitudeAccuracy      + '<br />' +
                             'Heading: '            + position.coords.heading               + '<br />' +
                             'Speed: '              + position.coords.speed                 + '<br />' +
                             'Timestamp: '          + new Date(position.timestamp)          + '<br />';
     }

     // onError Callback receives a PositionError object
     //
     function onError(error) {
         alert('code: '    + error.code    + '\n' +
               'message: ' + error.message + '\n');
     }

     
     function showMyPage(){
         
     }
     
     function onLaunchChildBrowser1()
     {
         
         window.plugins.childBrowser.showWebPage("http://www.google.com", { showLocationBar: true });
     }
     
     