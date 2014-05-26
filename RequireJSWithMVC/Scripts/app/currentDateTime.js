define(["jquery", "moment"],
    function ($, moment) {
        // Requires momentjs to be loaded
        var now = new moment().format("MM-DD-YYYY hh:mm:ss a");

        // Requires jquery to be loaded (and this DOM element)
        $("#currentDateTime").val(now);
    }
);