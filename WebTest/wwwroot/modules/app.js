"use strict";
//Modul untuk Keseluruhan Aplikasi
var app = angular.module("Frontend", [
    "ngAnimate",
    "ngCookies",
    "ngRoute",
    "ngStorage",
    "ui.bootstrap",
    "ui.sortable",
    "ui.router",
    "ngTouch",
    "angular.filter",
    "toastr",
    "angular-table",
    "smart-table",
    "xeditable",
    "ui.slimscroll",
    "ngJsTree",
    "checklist-model",
    "dndLists",
    "angular-progress-button-styles",
    "ngSanitize",
    "ui.select",
    "ngFileUpload",
    //'summernote',
    "multipleDatePicker",
    "textAngular",
]);


app.directive('stringToNumber', function () {
    return {
        require: 'ngModel',
        link: function (scope, element, attrs, ngModel) {
            ngModel.$parsers.push(function (value) {
                return '' + value;
            });
            ngModel.$formatters.push(function (value) {
                return parseFloat(value);
            });
        }
    };
});
app.factory("urlService", function ($http) {
    $http.defaults.headers.post["Content-Type"] =
        "application/json;charset=utf-8";
    var param = function (obj) {
        var query = "",
            name,
            value,
            fullSubName,
            subName,
            subValue,
            innerObj,
            i;

        for (name in obj) {
            value = obj[name];

            if (value instanceof Array) {
                for (i = 0; i < value.length; ++i) {
                    subValue = value[i];
                    fullSubName = name + "[" + i + "]";
                    innerObj = {};
                    innerObj[fullSubName] = subValue;
                    query += param(innerObj) + "&";
                }
            } else if (value instanceof Object) {
                for (subName in value) {
                    subValue = value[subName];
                    fullSubName = name + "[" + subName + "]";
                    innerObj = {};
                    innerObj[fullSubName] = subValue;
                    query += param(innerObj) + "&";
                }
            } else if (value !== undefined && value !== null)
                query +=
                    encodeURIComponent(name) + "=" + encodeURIComponent(value) + "&";
        }

        return query.length ? query.substr(0, query.length - 1) : query;
    };

    // Override $http service's default transformRequest
    $http.defaults.transformRequest = [
        function (data) {
            return angular.isObject(data) && String(data) !== "[object File]" ?
                param(data) :
                data;
        },
    ];
    var ahem =
        location.protocol + "//" + location.hostname + ":" + location.port + "/";

    function get() {
        return ahem;
    }
    return {
        get: get,
    };
});
app.service("stateChangeSpinner", [
    "$rootScope",
    "spinner",
    function ($rootScope, spinner) {
        var showSpinner = function (event, toState) {
            toState.spinnerToken = spinner.show();
        };
        var hideSpinner = function (event, toState) {
            spinner.hide(toState.spinnerToken);
        };

        this.activate = function () {
            $rootScope.$on("$stateChangeStart", showSpinner);
            $rootScope.$on("$stateChangeSuccess", hideSpinner);
            $rootScope.$on("$stateChangeError", hideSpinner);
        };
    },
]);
app.directive('ngConfirmClick', [
    function () {
        return {
            link: function (scope, element, attr) {
                var msg = attr.ngConfirmClick || "Are you sure?";
                var clickAction = attr.confirmedClick;
                element.bind('click', function (event) {
                    if (window.confirm(msg)) {
                        scope.$eval(clickAction)
                    }
                });
            }
        };
    }])
app.service("backlinkService", [
    "$window",
    function ($window) {
        var self = this;

        var urls = [];
        self.reset = function () {
            urls = [];
        };

        self.setUrls = function (backLinks) {
            self.reset();
            angular.forEach(backLinks, function (backLink) {
                self.addUrl(backLink);
            });
        };

        self.addUrl = function (backLink) {
            urls.push(backLink);
        };

        self.addBackUrl = function (label) {
            var backLabel = label || "Back";
            urls.push({
                label: backLabel,
                action: history.back,
            });
        };

        self.getUrlByLabel = function (label) {
            return urls.filter(function (url) {
                return url.label === label;
            });
        };

        self.getAllUrls = function () {
            return urls;
        };
    },
]);
app.service("messagingService", [
    "$rootScope",
    "$timeout",
    function ($rootScope, $timeout) {
        this.messages = { error: [], info: [] };
        var self = this;

        $rootScope.$on("event:serverError", function (event, errorMessage) {
            self.showMessage("error", errorMessage, "serverError");
        });

        this.showMessage = function (level, message, errorEvent) {
            var messageObject = { value: "", isServerError: false };
            messageObject.value = message;
            if (errorEvent) {
                messageObject.isServerError = true;
            } else if (level == "info") {
                this.createTimeout("info", 4000);
            }

            var index = _.findIndex(this.messages[level], function (msg) {
                return msg.value == messageObject.value;
            });

            if (index >= 0) {
                this.messages[level].splice(index, 1);
            }
            this.messages[level].push(messageObject);
        };

        this.createTimeout = function (level, time) {
            $timeout(
                function () {
                    self.messages[level] = [];
                },
                time,
                true
            );
        };

        this.hideMessages = function (level) {
            self.messages[level].length = 0;
        };

        this.clearAll = function () {
            self.messages["error"] = [];
            self.messages["info"] = [];
        };
    },
]);
app.factory("spinner", [
    "messagingService",
    "$timeout",
    function (messagingService, $timeout) {
        var tokens = [];

        var topLevelDiv = function (element) {
            return $(element).find("div").eq(0);
        };

        var showSpinnerForElement = function (element) {
            if ($(element).find(".dashboard-section-loader").length === 0) {
                topLevelDiv(element)
                    .addClass("spinnable")
                    .append('<div class="dashboard-section-loader"></div>');
            }
            return {
                element: $(element).find(".dashboard-section-loader"),
            };
        };

        var showSpinnerForOverlay = function () {
            var token = Math.random();
            tokens.push(token);

            if ($("#overlay").length === 0) {
                $("body").prepend('<div id="overlay"><div></div></div>');
            }

            var spinnerElement = $("#overlay");
            spinnerElement.stop().show();

            return {
                element: spinnerElement,
                token: token,
            };
        };

        var show = function (element) {
            if (element !== undefined) {
                return showSpinnerForElement(element);
            }

            return showSpinnerForOverlay();
        };

        var hide = function (spinner, parentElement) {
            var spinnerElement = spinner.element;
            if (spinner.token) {
                _.pull(tokens, spinner.token);
                if (tokens.length === 0) {
                    spinnerElement.fadeOut(300);
                }
            } else {
                topLevelDiv(parentElement).removeClass("spinnable");
                spinnerElement && spinnerElement.remove();
            }
        };

        var forPromise = function (promise, element) {
            return $timeout(function () {
                var spinner = show(element);
                promise["finally"](function () {
                    hide(spinner, element);
                });
                return promise;
            });
        };

        var forAjaxPromise = function (promise, element) {
            var spinner = show(element);
            promise.always(function () {
                hide(spinner, element);
            });
            return promise;
        };

        return {
            forPromise: forPromise,
            forAjaxPromise: forAjaxPromise,
            show: show,
            hide: hide,
        };
    },
]);
app.factory("FileUploadService", function ($http, $q) {
    // explained abour controller and service in part 2

    var fac = {};
    fac.UploadFile = function (file, data, url) {
        var formData = new FormData();
        formData.append("file", file);
        debugger;
        //We can send more data to server using append
        for (var key in data) {
            formData.append(key, data[key]);
        }
        var defer = $q.defer();
        $http
            .post(url, formData, {
                withCredentials: true,
                headers: { "Content-Type": undefined },
                transformRequest: angular.identity,
            })
            .success(function (d) {
                defer.resolve(d);
            })
            .error(function () {
                defer.reject("File Upload Failed!");
            });

        return defer.promise;
    };
    return fac;
});
app.directive("ngFileSelect", function () {
    return {
        link: function ($scope, el) {
            el.bind("change", function (e) {
                $scope.file = (e.srcElement || e.target).files[0];
                $scope.getFile();
            });
        },
    };
});
var fileReader = function ($q, $log) {
    var onLoad = function (reader, deferred, scope) {
        return function () {
            scope.$apply(function () {
                deferred.resolve(reader.result);
            });
        };
    };

    var onError = function (reader, deferred, scope) {
        return function () {
            scope.$apply(function () {
                deferred.reject(reader.result);
            });
        };
    };

    var getReader = function (deferred, scope) {
        var reader = new FileReader();
        reader.onload = onLoad(reader, deferred, scope);
        reader.onerror = onError(reader, deferred, scope);
        return reader;
    };

    var readAsDataURL = function (file, scope) {
        var deferred = $q.defer();

        var reader = getReader(deferred, scope);
        reader.readAsDataURL(file);

        return deferred.promise;
    };

    return {
        readAsDataUrl: readAsDataURL,
    };
};
app.directive('contenteditable', ['$sce', function ($sce) {
    return {
        restrict: 'A', // only activate on element attribute
        require: '?ngModel', // get a hold of NgModelController
        link: function (scope, element, attrs, ngModel) {
            if (!ngModel) return; // do nothing if no ng-model

            console.log(attrs);

            if (attrs.type === "date") {
                console.info("aborey");
            }

            // Specify how UI should be updated
            ngModel.$render = function () {
                element.html($sce.getTrustedHtml(ngModel.$viewValue || ''));
            };

            // Listen for change events to enable binding
            element.on('blur keyup change', function () {
                scope.$evalAsync(read);
            });



            // Write data to the model
            function read() {
                var html = element.html();
                // When we clear the content editable the browser leaves a <br> behind
                // If strip-br attribute is provided then we strip this out
                if (attrs.stripBr && html == '<br>') {
                    html = '';
                }
                ngModel.$setViewValue(html);
            }
        }
    };
}])
app.factory("fileReader", ["$q", "$log", fileReader]);
app.factory("printer", [
    "$rootScope",
    "$compile",
    "$http",
    "$timeout",
    "$q",
    "spinner",
    function ($rootScope, $compile, $http, $timeout, $q, spinner) {
        var printHtml = function (html) {
            var deferred = $q.defer();
            var hiddenFrame = $(
                '<iframe style="visibility: hidden"></iframe>'
            ).appendTo("body")[0];
            hiddenFrame.contentWindow.printAndRemove = function () {
                hiddenFrame.contentWindow.print();
                $(hiddenFrame).remove();
                deferred.resolve();
            };
            var htmlContent =
                "<!doctype html>" +
                "<html>" +
                '<body onload="printAndRemove();">' +
                html +
                "</body>" +
                "</html>";
            var doc = hiddenFrame.contentWindow.document.open("text/html", "replace");
            doc.write(htmlContent);
            doc.close();
            return deferred.promise;
        };

        var openNewWindow = function (html) {
            var popupWin = window.open("", "_blank", "width=1366,height=800");
            popupWin.document.open();
            popupWin.document.write(
                '<html><head><link rel="stylesheet" type="text/css" href="..app/main.css" /></head><body onload="window.print()">' +
                html +
                "</body></html>"
            );
            popupWin.document.close();
            popupWin.print();
            setTimeout(window.close, 0);
        };

        var print = function (templateUrl, data) {
            $rootScope.isBeingPrinted = true;
            $http.get(templateUrl).then(function (templateData) {
                var template = templateData.data;
                var printScope = $rootScope.$new();
                angular.extend(printScope, data);
                var element = $compile($("<div>" + template + "</div>"))(printScope);
                var renderAndPrintPromise = $q.defer();
                var waitForRenderAndPrint = function () {
                    if (printScope.$$phase || $http.pendingRequests.length) {
                        $timeout(waitForRenderAndPrint, 1000);
                    } else {
                        // Replace printHtml with openNewWindow for debugging
                        printHtml(element.html()).then(function () {
                            $rootScope.isBeingPrinted = false;
                            renderAndPrintPromise.resolve();
                        });
                        printScope.$destroy();
                    }
                    return renderAndPrintPromise.promise;
                };
                spinner.forPromise(waitForRenderAndPrint());
            });
        };

        var printFromScope = function (templateUrl, scope, afterPrint) {
            $rootScope.isBeingPrinted = true;
            $http.get(templateUrl).then(function (response) {
                var template = response.data;
                var printScope = scope;
                var element = $compile($("<div>" + template + "</div>"))(printScope);
                var renderAndPrintPromise = $q.defer();
                var waitForRenderAndPrint = function () {
                    if (printScope.$$phase || $http.pendingRequests.length) {
                        $timeout(waitForRenderAndPrint);
                    } else {
                        debugger;
                        openNewWindow(element.html()).then(function () {
                            $rootScope.isBeingPrinted = false;
                            if (afterPrint) {
                                afterPrint();
                            }
                            renderAndPrintPromise.resolve();
                        });
                    }
                    return renderAndPrintPromise.promise;
                };
                spinner.forPromise(waitForRenderAndPrint());
            });
        };
        return {
            print: print,
            printFromScope: printFromScope,
        };
    },
]);
app.factory("$localstorage", [
    "$window",
    function ($window) {
        var logged = "0";
        return {
            set: function (key, value) {
                $window.localStorage[key] = value;
            },
            get: function (key) {
                return $window.localStorage[key] || logged;
            },
            setObject: function (key, value) {
                $window.localStorage[key] = JSON.stringify(value);
            },
            getObject: function (key) {
                return JSON.parse($window.localStorage[key] || "{}");
            },
            clear: function () {
                $window.localStorage.clear();
            },
        };
    },
]);


app.factory("urlFactory", function () {
    var savedUrl = "";

    function set(data) {
        savedUrl = data;
    }

    function get() {
        return savedUrl;
    }
    return {
        set: set,
        get: get,
    };
});

app.factory("serviceFactory", function () {
    var savedData = {};

    function set(data) {
        savedData = data;
    }

    function get() {
        return savedData;
    }
    return {
        set: set,
        get: get,
    };
});

app.filter("mydate", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});
app.directive("focusMe", function ($timeout) {
    return {
        scope: { trigger: "@focusMe" },
        link: function (scope, element) {
            scope.$watch("trigger", function (value) {
                if (value === "true") {
                    $timeout(function () {
                        element[0].focus();
                    });
                }
            });
        },
    };
});
app.directive("selectWatcher", function ($timeout) {
    return {
        link: function (scope, element, attr) {
            var last = attr.last;
            if (last === "true") {
                $timeout(function () {
                    $(element).parent().selectpicker("val", "any");
                    $(element).parent().selectpicker("refresh");
                });
            }
        },
    };
});
app.filter("SumOfAmt", function () {
    return function (data, key) {
        if (angular.isUndefined(data) || angular.isUndefined(key)) return 0;
        var sum = 0;
        angular.forEach(data, function (value) {
            sum = sum + parseInt(value[key]);
        });
        return sum;
    };
});
app.filter('myFilter', function () {
    // the filter takes an additional input filterIDs
    return function (inputArray, filterIDs) {
        // filter your original array to return only the objects that
        // have their ID in the filterIDs array
        return inputArray.filter(function (entry) {
            return this.indexOf(entry.id_tim) !== -1;
        }, filterIDs); // filterIDs here is what "this" is referencing in the line above
    };
});
app.filter("jsonDate", [
    "$filter",
    function ($filter) {
        return function (input, format) {
            return input ? $filter("date")(parseInt(input.substr(6)), format) : "";
        };
    },
]);

app.directive("myEnter", function () {
    return function (scope, element, attrs) {
        element.bind("keydown keypress", function (event) {
            if (event.which === 13) {
                scope.$apply(function () {
                    scope.$eval(attrs.myEnter);
                });

                event.preventDefault();
            }
        });
    };
});


app.service("masterServices", function ($http, urlService) {
    //#region Get URL
    var url = urlService.get();
    //#endregion

    //#region Master
    this.CheckNo = function (no, timId) {
        return $http.get(
            url + "Pemain/CheckNo?no=" + no + "&timId=" + timId);
    };
    this.GetPosisi = function () {
        return $http.get(
            url + "Posisi/GetAll");
    };
    this.GetPemain = function () {
        return $http.get(
            url + "Pemain/GetAll");
    };
    this.GetPemainByTim = function (timId) {
        return $http.get(
            url + "Pemain/GetPemainByTimId?timId=" + timId);
    };
    this.GetTim = function () {
        return $http.get(
            url + "Tim/GetAll");
    };

    this.GetJadwal = function () {
        return $http.get(
            url + "JadwalPertandingan/GetAll");
    };
    this.GetHasil = function () {
        return $http.get(
            url + "HasilPertandingan/GetAll");
    };
    this.GetDetail = function () {
        return $http.get(
            url + "Detail/GetAll");
    };
    this.GetSkorhasil = function (hasilPertandinganId) {
        return $http.get(
            url + "Skorhasil/GetAll?hasilPertandinganId=" + hasilPertandinganId);
    };
    //#endregion
});

app.service("transaksiServices", function ($http, urlService) {
    var url = urlService.get();

    this.SimpanPemain = function (data) {
        return $http.post(
            url + "Pemain/Simpan",
            JSON.stringify(data), { header: { "Content-Type": "application/json" } }
        );
    };
    this.HapusPemain = function (data) {
        return $http.post(
            url + "Pemain/Hapus",
            JSON.stringify(data), { header: { "Content-Type": "application/json" } }
        );
    };

    this.SimpanTim = function (data) {
        return $http.post(
            url + "Tim/Simpan",
            JSON.stringify(data), { header: { "Content-Type": "application/json" } }
        );
    };
    this.HapusTim = function (data) {
        return $http.post(
            url + "Tim/Hapus",
            JSON.stringify(data), { header: { "Content-Type": "application/json" } }
        );
    };

    this.SimpanJadwal = function (data) {
        return $http.post(
            url + "JadwalPertandingan/Simpan",
            JSON.stringify(data), { header: { "Content-Type": "application/json" } }
        );
    };
    this.HapusJadwal = function (data) {
        return $http.post(
            url + "JadwalPertandingan/Hapus",
            JSON.stringify(data), { header: { "Content-Type": "application/json" } }
        );
    };

    this.SimpanHasil = function (data) {
        return $http.post(
            url + "HasilPertandingan/Simpan",
            JSON.stringify(data), { header: { "Content-Type": "application/json" } }
        );
    };
    this.HapusHasil = function (data) {
        return $http.post(
            url + "HasilPertandingan/Hapus",
            JSON.stringify(data), { header: { "Content-Type": "application/json" } }
        );
    };

});