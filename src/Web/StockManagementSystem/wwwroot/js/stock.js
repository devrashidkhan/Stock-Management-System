function AjaxPostRequest(url, parameters, successCallback) {
    //show loading... image

    $.ajax({
        type: 'POST',
        url: url,
        data: JSON.stringify(parameters),
        contentType: 'application/json;',
        dataType: 'json',
        //beforeSend: function () {
                
        //            $('#loadingModal').modal('show');
                
        //    },
        //    complete: function () {
        //        $('#loadingModal').modal('hide');

        //},
        success: successCallback,
        error: function (err) {
            alert("Failed to Load Data");
            //console.log(err);
        }
    });
};

