var myModal;
function openModal(c, m, url) {
    bindModal(c, url);
    myModal = new bootstrap.Modal(m, {
        keyboard: false, backdrop: true
    });
    myModal.show();
}
function bindModal(content, url) {
    $(content).html('');
    $.ajax(
        {
            url: url,
            method: "GET",
            success: function (r) {
                $(content).html(r);
                $(content).find("form").submit(
                    function (e) {
                        $(this).validate();

                        if (!$(this).valid())
                            return;
                        e.preventDefault();
                        submitModal(this, "/duyuru/create");
                    }
                );
            }
        }
    );
}
function submitModal(f, url) {
    $.ajax(
        {
            url: url,
            method: "POST",
            data: new FormData(f),
            contentType: false,
            processData: false,
            success: function (r) {
                if (r.basarili) {
                    myModal.hide();
                }
                else { showModalAlert(); }
            }
        }
    );
}
function showModalAlert() {
    alert("Hata Oluştu");
}