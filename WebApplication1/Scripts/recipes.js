function getIngredientsByCategory() {
    var categorySelect = document.getElementById("categorySelect");
    var categoryIndex = categorySelect.selectedIndex;
    var categoryValue = categorySelect.value;
    console.log("Index: " + categoryIndex + " Value: " + categoryValue);
    var targetUrl = window.location.protocol + "//" + window.location.hostname + ":" + + window.location.port + "/Categories/Details/" + categoryValue;
    console.log(targetUrl);
    //$.ajax({
    //    url: @Url.Action("/Categories/Details/" + categoryValue)

    //}).done(function (returnedData) {
    //    console.log(returnedData);
    //    if (returnedData == 'True') {
    //        results.innerHTML = "<h4 class='errordata'>Error: This category name exists!</h4>";
    //    } else {
    //        results.innerHTML = "<h4>This category name is available!</h4>";
    //        //var button = '<input type="submit" name="Create Category" />';
    //        //var myForm = document.getElementsByTagName("form")[0].innerHTML;
    //        //console.log(myForm);
    //        //myForm += button;
    //    }

    //    // display this returned data on a div.....
    //});
}