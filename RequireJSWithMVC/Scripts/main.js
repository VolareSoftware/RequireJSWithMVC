// RequireJS config for app
require.config({
    baseUrl: "/Scripts/app",
    paths: {
        jquery: "../lib/jquery-2.1.0",
        jqueryValidate: "../lib/jquery.validate",
        jqueryValidateUnobtrusive: "../lib/jquery.validate.unobtrusive",
        bootstrap: "../lib/bootstrap",
        moment: "../lib/moment"
    },
    shim: {
        jqueryValidate: ["jquery"],
        jqueryValidateUnobtrusive: ["jquery", "jqueryValidate"]
    }
});