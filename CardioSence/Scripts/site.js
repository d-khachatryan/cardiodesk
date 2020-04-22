//Grid height
var gridHeight = $(window).height() - 160;
var gridHeightCat = $(window).height() - 115;
$(".k-grid").height(gridHeight);
$(".catalog-grid").height(gridHeightCat);

//For Grid Commands Icons
function showCommandIcons() {
    $(".Update_Icon").find("span").addClass("glyphicon glyphicon-pencil");
    $(".Delete_Icon").find("span").addClass("glyphicon glyphicon-trash");
    $(".Remove_Icon").find("span").addClass("glyphicon glyphicon-remove");
}

//For menu active elements
var hasNotActive = $("ul.sidebar-menu > li.treeview > ul.treeview-menu > li").not(".active");
var hasActive = $("ul.sidebar-menu > li.treeview > ul.treeview-menu > li.active");
hasActive.children("a").prepend("<i class=\"fa fa-dot-circle-o\"></i> ");
hasNotActive.children("a").prepend("<i class=\"fa fa-circle-o\"></i> ");

//For Load
$(".forLoad").click(function () {
    $(".loader").show();
});

//For Right Slide
var next_move = "closed";
$(".right-slidePanel .slidePanel-btn").html("<i class=\"glyphicon glyphicon-search\"></i>");
$(".right-slidePanel .slidePanel-btn, .right-slidePanel #rtSearch")
        .click(function () {
            console.log(next_move);
            var css = {};
            if (next_move == "closed") {
                css = {
                    right: '0'
                };
                $(".right-slidePanel .slidePanel-btn").html("<i class=\"glyphicon glyphicon-chevron-right\"></i>");
                next_move = "shrink";
            } else {
                css = {
                    right: '-225px'
                };
                console.log('hi');
                next_move = "closed";
                $(".right-slidePanel .slidePanel-btn").html("<i class=\"glyphicon glyphicon-search\"></i>");
            }
            $(this).closest(".right-slidePanel").animate(css, 200);
        });

