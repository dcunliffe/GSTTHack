var ListViewModel = function (url) {
    var self = this;

    self.documentList = ko.observableArray();

    self.isBusy = ko.observable(true);

    self.getList = function () {
        self.isBusy(true);
        $.get(url + '/document')
            .then(function (d) {
                var list = $.map(d, function (value) {
                    return new DocumentModel(value);
                });
                self.documentList(list);
                self.isBusy(false);
            })
            .fail(function (err) {
                if (err && err.statusText)
                    alert(err.statusText); // or whatever
            });
    };

    self.getList();
};