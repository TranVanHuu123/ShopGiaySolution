var CartController = function () {
    this.initialize = function () {
        loadData();

        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.btn-plus', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) + 1;
            updateCart(id, quantity);
        });

        $('body').on('click', '.btn-minus', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) - 1;
            updateCart(id, quantity);
        });
        $('body').on('click', '.btn-remove', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            updateCart(id, 0);
        });
    }

    function updateCart(id, quantity) {
        const culture = $('#hidCulture').val();
        $.ajax({
            type: "POST",
            url: "/" + culture + '/Cart/UpdateCart',
            data: {
                id: id,
                quantity: quantity
            },
            success: function (res) {
                $('#lbl_number_items_header').text(res.length);
                loadData();
            },
            error: function (err) {
                console.log(err);
            }
        });
    }

    function loadData() {
        const culture = $('#hidCulture').val();
        $.ajax({
            type: "GET",
            url: "/" + culture + '/Cart/GetListItems',
            success: function (res) {
                if (res.length === 0) {
                    $('#tbl_cart').hide();
                }
                var html = '';
                var total = 0;

                $.each(res, function (i, item) {
                    var amount = item.price * item.quantity;
                    html += "<table>"
                        + "<tr class=\"product-cart-main\">"
                        + "<td >"
                        + "<div class=\"product-cart-img\">"
                        + "<img src=\"" + $('#hidBaseAddress').val() + item.image + "\" alt=\"\">"
                        + "</div>"
                        + "</td>"
                        + "<td class=\"product-cart-name\">"
                        + "<h1>" + item.name + " </h1>"
                        + "<span> 18000000 VND</span>"
                        + "</td>"
                        + "<td class=\"product-cart-price\">"
                        + "<span>Giá : </span>"
                        + "<span>" + numberWithCommas(item.price) + " vnd</span>"
                        + "</td>"
                        + "<td class=\"product-cart-note\">"
                        + "<span>Số lượng</span>"                      
                        + "</td>"
                        + "<td class=\"product-cart-input\">"
                      /*  + "<input id=\"txt_quantity_" + item.id + "\" type=\"hidden\" value=\"\" name=\"ID_SANPHAM\">"*/
                        + "<div class=\"input-append\"><input class=\"span1\" style=\"width: 80px; height: 24px; border:1px solid;margin-left:0\" placeholder=\"1\" id=\"txt_quantity_" + item.productId + "\" value=\"" + item.quantity + "\" size=\"16\" type=\"text\">"
                        + " <button style = \"height:20px; width:28px;\" class=\"btn btn-add btn-minus\" data-id=\"" + item.productId + "\" type =\"button\"> <i class=\"fa-solid fa-minus\"></i></button>"
                        + " <button style = \"height:20px; width:28px;\" class=\"btn btn-pluss btn-plus\" type=\"button\" data-id=\"" + item.productId + "\"><i class=\"fa-solid fa-plus\"></i></button>"
                        + " <button style = \"height:20px; width:28px; color: red; \" class=\"btn btn-danger btn-remove\" type=\"button\" data-id=\"" + item.productId + "\"><i class=\"fa-solid fa-xmark\"></i></i></button>"
                            + " </div >"
                        + "</td>"
                        + "</tr>"
                        + "</table>";

                    total += amount;
                });
                    $('#cart_body').html(html);
                    $('#lbl_number_of_item').text(res.length);
                $('#lbl_total').text(numberWithCommas(total));
                
             }
            });
    }
}
