var DocumentViewerViewModel = function (documentId) {
    var self = this;

    self.documentId = ko.observable(documentId);

    self.documentDetails = ko.observable();

    self.isBusy = ko.observable(true);

    self.getList = function () {
        self.isBusy(true);
        $.get('http://localhost:50418/api/document/' + self.documentId())
            .then(function (d) {
                self.documentDetails(new DocumentModel(d));
                self.isBusy(false);
            });
    };

    self.getList();
};