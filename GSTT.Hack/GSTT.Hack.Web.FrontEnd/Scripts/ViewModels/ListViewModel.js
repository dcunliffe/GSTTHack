var ListViewModel = function () {
    var self = this;

    self.documentList = ko.observableArray();

    self.getList = function () {
        $.get('http://localhost:50418/api/document')
            .then(function (d) {
                var list = $.map(d, function (value) {
                    return new DocumentModel(value);
                });
                self.documentList(list);
            });
    }

    self.getList();
};