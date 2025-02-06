$(document).ready(function () {
    var i = 0;
    $('#firtshow0').prev('h4').addClass("eq_active_h4");
    $('#navi > div > h4').each(function (i) {
        $(this).next().hide("fast", function () {
            $('#firtshow0').show();
        });
        i = i + 1;
    });
    $('#navi > div > h4').click(function () {
        var index = $("#navi > div > h4").index(this);
        var i = 0;

        $('#navi > div > h4').each(function (i) {
            if (i != index) $(this).next().hide("slow");
            i = i + 1;
        });

        $(this).next().slideToggle('slow');
    });

    $("a.tab").click(function () {
        if ($(this).parents('h4').hasClass("eq_active_h4")) {
            $(this).parents('h4').toggleClass("off");
        }
        else {
            $(".eq_active_h4").removeClass("off");
            $(".eq_active_h4").removeClass("eq_active_h4");
            $(this).parents('h4').addClass("eq_active_h4");
        }


    });
});

$(function () {

    $(".main_area").click(function () {
        closeNavi();
    });

    $("#top_menu").click(function () {
        if ($("#navi").is(':hidden') == true) {
            $("#navi").attr("style", "display:block;");
            $("#help_faq").attr("style", "display:none;");
        } else { $("#navi").attr("style", "display:none;"); }
    });

    $("#user_help_menu").click(function () {
        if ($("#help_faq").is(':hidden') == true) {
            var left = $("#user_help_menu").offset().left - $(".main_area").offset().left;
            $("#help_faq").attr("style", "display:block;left:" + left + "px;min-width:" + $("#help_faq").outerWidth() + "px");
            $("#navi").attr("style", "display:none;");
        } else { $("#help_faq").attr("style", "display:none;"); }
    });
});

function closeNavi() {
    $("#navi").attr("style", "display:none;");
    $("#help_faq").attr("style", "display:none;");
}