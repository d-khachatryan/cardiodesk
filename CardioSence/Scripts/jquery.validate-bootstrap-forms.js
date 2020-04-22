$(".text-box").addClass("k-textbox");
$(".k-textbox").addClass("input-item form-control");

$("input[type=submit]").click(function (e) {
    var validator = $("form");
    if (validator.valid()) {
        $(".loader").show();
        return true;
    }
    else {
        $(".vldmsg span").prepend("<i class=\"fa fa-exclamation-triangle\"</i> ");
        return false;
    }
});

//For Kendo Elements
$.validator.setDefaults({
    ignore: [],
});

(function ($) {
    var defaultOptions = {
        validClass: 'has-success',
        errorClass: 'has-error',
        highlight: function (element, errorClass, validClass) {
            $(element).closest(".form-group")
                .removeClass(validClass)
                .addClass('has-error');
        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).closest(".form-group")
            .removeClass('has-error')
            .addClass(validClass);
        }
    };

    $.validator.setDefaults(defaultOptions);

    $.validator.unobtrusive.options = {
        errorClass: defaultOptions.errorClass,
        validClass: defaultOptions.validClass,
    };
})(jQuery);
