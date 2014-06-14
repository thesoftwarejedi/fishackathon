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

.controller('LeafletController', function($scope) {
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
})