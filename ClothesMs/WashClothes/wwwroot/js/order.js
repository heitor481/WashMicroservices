
function GenerateOrder() {

    const clotheId = $("#clothes .splide__list .card-selected").first().attr("data-id");
    const providerId = $("#providers .splide__list .card-selected").first().attr("data-id");

    const reqOrder = {
        type: "GET",
        url: `/api/wash/${clotheId}/providers/${providerId}`,
        payload: null,
        callback: function (res) {

            if (res) {
                var newEl = `
                    <div id="register">
                      <div id="ticket">
                        <h1>Thank You!</h1>
                        <table>
                          <tbody id="entries">
                            <tr>
                                <td>Provider</td>
                                <td>${res.providerName}</td>
                            </tr>

                            <tr>
                                <td>Driver</td>
                                <td>${res.driverName} ${res.driverSurname}</td>
                            </tr>

                          </tbody>
                          <tfoot>
                            <tr>
                              <th>Total</th>
                              <th>$ ${res.price}</th>
                            </tr>
                          </tfoot>
                        </table>
                      </div>
                    </div>`;

                $("#orderPnl").append(newEl);
            }
        },
        errorMsg: 'Could not generate order. Try again on a few minutes.'
    };

    doRequest(reqOrder);
}
