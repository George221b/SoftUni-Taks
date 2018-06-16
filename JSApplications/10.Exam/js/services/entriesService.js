let entriesService = (() => {
    function getEntriesByReceiptId(receiptId) {
        const endpoint = `entries?query={"receiptId":"${receiptId}"}`;

        return remote.get('appdata', endpoint, 'kinvey');
    }

    function addEntry(receiptId, price, qty, type) {
        let data = {receiptId, price, qty, type};

        return remote.post('appdata', 'entries', 'kinvey', data);
    }

    function deleteEntry(entryId) {
        const endpoint = `entries/${entryId}`;

        return remote.remove('appdata', endpoint, 'kinvey');
    }

    return {
        getEntriesByReceiptId,
        addEntry,
        deleteEntry
    }
})();