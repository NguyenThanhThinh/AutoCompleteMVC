/// <reference path="../bootstrap3-typeahead.js" />
$(function () {
    $("#search").typeahead({
        source: function (query, process) {
            var stuffs = [];
            return $.post("/Home/GetAll", { query: query }, function (response) {
                $.each(response, function (i, stuff) {
                    var item = stuff.Name + "-" + stuff.Price;
                    stuffs.push(item);
                });
                process(stuffs);
            });
        }
    });
});