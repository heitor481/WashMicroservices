
function DisplayProviders() {
    const reqProviders = {
        type: "GET",
        url: '/api/wash/providers',
        payload: null,
        callback: function (res) {

            if (res) {
                res.forEach(r => {
                    var newEl = `
                        <li class="splide__slide">   
                        <div class="card providers" data-id="${r.id}" onclick="setElementSelected(this, 'providers')">
                        <div class="container">
                        <h4><b>${r.name}</b></h4> 
                        <p>$ ${r.price}</p> 
                        </div>
                    </div>
                    </li>`;

                    $("#providers .splide__list").append(newEl);
                });

                $("#providers").show();
            }
        },
        errorMsg: 'Could not retrieve providers. Try again on a few minutes.'
    };

    doRequest(reqProviders);
}