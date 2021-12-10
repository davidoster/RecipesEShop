function getIngredientsByCategory() {
    var categorySelect = document.getElementById("categorySelect");
    var categoryIngredients = document.getElementById("categoryIngredients");
    var categoryIndex = categorySelect.selectedIndex;
    var categoryValue = categorySelect.value;
    //console.log("Index: " + categoryIndex + " Value: " + categoryValue);
    var targetUrl = window.location.protocol + "//" + window.location.hostname + ":" + + window.location.port + "/api/Categories/" + categoryValue;
    //console.log(targetUrl);
    $.ajax({
        url: targetUrl

    }).done(function (returnedData) {
        //console.log(returnedData);
        categoryIngredients.innerHTML = "";
        if (!returnedData.Ingredients) {
            categoryIngredients.innerHTML = "<p>No Ingredients Found</p>";
        } else {
            if (returnedData.Ingredients.length == 0) {
                categoryIngredients.innerHTML = "<p>No Ingredients Found</p>";
            } else {
                for (item of returnedData.Ingredients) {
                    categoryIngredients.innerHTML += createCheckBox(item.Name, item.Name, item.Description);
                }
            }
        }
    });
}

function createCheckBox(id, name, description) {
    let checkBox = `<input type="checkbox" id="${id}" name="${name}" value="${name}">
    <label for="${id}"> ${description}</label><br>`;
    return (checkBox);
}