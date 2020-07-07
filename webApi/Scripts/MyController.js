/// <reference path="angular.min.js" />

var app = angular.module("myApp", []);

app.controller('myCtrl', function ($scope, $http) {
    $http.get("http://localhost:64418/api/EmployeeApi")
        .then(function (response) {
            alert(response.data);
            $scope.EmployeeData = response.data;
        })

    $scope.save = function () {
        $http({
            method: "POST",
            url: "http://localhost:64418/api/EmployeeApi",
            data: {
                EmpName: $scope.EmpName,
                EmpSalary: $scope.EmpSalary
            }
        }).then(function mySuccess(response) {
            alert('Inserted Successfully');
        }), function myError(response) {
            alert('Not Inserted');
        }
    }

    })