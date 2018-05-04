var DocumentViewerViewModel = function (documentId, URL) {
    var self = this;

    self.documentId = ko.observable(documentId);

    self.documentDetails = ko.observable();

    self.isBusy = ko.observable(true);

    self.getList = function () {
        self.isBusy(true);
        $.get(URL + '/document/' + self.documentId())
            .then(function (d) {
                self.documentDetails(new DocumentModel(d));
                self.isBusy(false);
            });
    };

    self.getList();
};