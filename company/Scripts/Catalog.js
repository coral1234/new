$(document).ready(function () {
    $("#DynamicHTML").append(buildMyProduct(JSONCatalog));

    GetAllProducts();


});
function buildMyProduct(obj) {
    var html = "";
    $.each(obj, function (element, object) {
        html += "<div><a href='detail.html?id = " + object.id + "'>" + object.title + "</a></div>"
        //html += "<div><img class='Catalog' src='" + object.imgUrl + "' /></div>";
        html += "<div><img src='" + object.imgUrl + "' /></div>";
        html += "<div>" + object.description + "</div>";
        html += "<div>" + object.Model + "</div>";
        html += "<div>" + object.Price + "</div>";
    });
    return html;
}
