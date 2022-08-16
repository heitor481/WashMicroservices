
function DisplayClothes() {
    const reqClothes = {
        type: "GET",
        url: '/api/wash/1',
        payload: null,
        callback: function (res) {

            if (res) {

                $("#clothes").empty();

                res.forEach(r => {
                    var newEl = `  
                            <div class="card" data-id="${r.id}" onclick="setElementSelected(this, 'clothes')">
                                <img src="${r.image}">
                                <div class="container">
                                    <h4><b>${r.type}</b></h4>
                                    <p>${r.color}</p>
                                </div>
                            </div>`;

                    $("#clothes").append(newEl);
                });

                $("#clothes").show();
                $("#btnDispalyProviders").show();
            }
        },
        errorMsg: 'Could not retrieve user clothes. Try again on a few minutes.'
    };

    doRequest(reqClothes);
}