angular.module('starter.controllers', ['leaflet-directive'])

.controller('AppCtrl', function($scope) {
})

.controller('PlaylistsCtrl', function($scope) {
  $scope.playlists = [
    { title: 'Reggae', id: 1 },
    { title: 'Chill', id: 2 },
    { title: 'Dubstep', id: 3 },
    { title: 'Indie', id: 4 },
    { title: 'Rap', id: 5 },
    { title: 'Cowbell', id: 6 }
  ];
})

.controller('PlaylistCtrl', function($scope, $stateParams) {
})

.controller('CollectController', function($scope) {
    $scope.philippines = {
        lat: 12.1252,
        lng: 122.1679,
        zoom: 8
    };

    $scope.defaults = {
    	tileLayer: 'img/mapTiles/{z}/{x}/{y}.png',
    	maxZoom: 9,
    	minZoom: 6
    };

    $scope.time = {
        haulTime: "23:00",
        haulDate: "6/14/14",
        setTime: "20:00",
        setDate: "6/14/14"
    };

    $scope.markers = {
        mainMarker: {
            lat: 12.1252,
            lng: 122.1679,
            focus: true,
            message: "Move Marker to Fishing Location",
            draggable: true
        }
    };

    var haulString = window.localStorage['hauls'];
    if(haulString) {
        $scope.hauls = angular.fromJson(haulString);
    } else {
        $scope.hauls = [];
    }

    $scope.submitSync = function() {
        console.log("Sync");
        $scope.hauls.forEach(function(haul) {
            if (window.XMLHttpRequest) {
                var xmlhttp = new XMLHttpRequest();
            } else {
                var xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            }

            xmlhttp.open("POST","http://172.16.240.37/IsdaService.svc/SubmitHaulData",true);
            xmlhttp.setRequestHeader("Content-type","application/x-www-form-urlencoded");
            xmlhttp.send(angular.toJson(haul));
            //console.log(xmlhttp);
            alert(xmlhttp.status);
        });
    };

    $scope.resetSync = function() {
        window.localStorage['hauls'] = [];

    };

    // Called when the form is submitted
    $scope.submitHaul = function(haul, markers, time) {
        console.log(haul);
        console.log(markers);

        haul.Longitude = markers.mainMarker.lng;
        haul.Latitude = markers.mainMarker.lat;

        haul.HaulDateTime = time.haulDate + " " + time.haulTime;
        haul.TrapSetTime = time.setDate + " " + time.setTime;
        haul.SampleDateTime = time.haulDate + " " + time.haulTime;

        haul.VesselId = 1;
        haul.Gear = 2;
        haul.FishType = "Big";

        $scope.hauls.push(haul);
        
        window.localStorage['hauls'] = angular.toJson($scope.hauls);

        console.log($scope.hauls);
    };
})