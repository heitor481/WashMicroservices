
function DisplayClothes() {
    const reqClothes = {
        type: "GET",
        url: '/api/wash/1',
        payload: null,
        callback: function (res) {

            if (res) {
                res.forEach(r => {
                    var newEl = `
                        <li class="splide__slide">    
                            <div class="card" data-id="${r.id}" onclick="setElementSelected(this, 'clothes')">
                                <img src="${r.image}">
                                <div class="container">
                                    <h4><b>${r.type}</b></h4>
                                    <p>${r.color}</p>
                                </div>
                            </div>
                        </li>`;

                    $("#clothes .splide__list").append(newEl);
                });

                $("#clothes").show();
                $("#btnDispalyProviders").show();
            }
        },
        errorMsg: 'Could not retrieve user clothes. Try again on a few minutes.'
    };

    doRequest(reqClothes);
}