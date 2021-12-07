const name = $('#Name')[0]; //.on('change',nameAction);
const results = $('#results')[0];
//console.log(name);
name.addEventListener("change", nameAction);
console.log(name.value);



function nameAction() {
    $.ajax({
        url: "https://localhost:44314/MainCategories/CheckCategoryExistence?category=" + name.value

    }).done(function (returnedData) {
        console.log(returnedData);
        if (returnedData == 'True') {
            results.innerHTML = "<h4 class='errordata'>Error: This category name exists!</h4>";
        } else {
            results.innerHTML = "<h4>This category name is available!</h4>";
            //var button = '<input type="submit" name="Create Category" />';
            //var myForm = document.getElementsByTagName("form")[0].innerHTML;
            //console.log(myForm);
            //myForm += button;
        }
        
        // display this returned data on a div.....
    });
    
    
}