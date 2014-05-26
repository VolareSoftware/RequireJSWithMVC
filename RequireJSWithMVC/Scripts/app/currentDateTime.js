define(["jquery", "moment"],
    function ($, moment) {
        "use strict";

        var init = function () {
            // Requires MomentJS to be loaded. 
            // “moment” is the argument passed in by RequireJS for the MomentJS module, aliased as “moment” in the require statement.
            var now = new moment().format("M/D/YYYY h:mm:ss A");

            // Requires jQuery to be loaded. 
            // “$” is the argument passed in by RequireJS for the “jquery” module in the require statement.
            $("#currentDateTime").text(now);
        };

        return {
            init: init
        };
    }
);