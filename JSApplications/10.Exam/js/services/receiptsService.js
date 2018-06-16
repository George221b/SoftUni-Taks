let receipts = (() => {
    function getActiveReceipt(userId) {
        const endpoint = `receipts?query={"_acl.creator":"${userId}","active":"true"}`; //ss
        return remote.get('appdata', endpoint, 'kinvey');
    }

    function createReceipt() {
        let total = 0;
        let productCount = 0;
        let active = true;
        let data = {total, productCount, active};

        return remote.post('appdata', 'receipts', 'kinvey', data);
    }

    function getMyReceipts(userId) {
        const endpoint = `receipts?query={"_acl.creator":"${userId}","active":"false"}`; //ss

        return remote.get('appdata', endpoint, 'kinvey');
    }

    function receiptDetails(receiptId) {
        const endpoint = `receipts/${receiptId}`;

        return remote.get('appdata', endpoint, 'kinvey');
    }

    function commitReceipt(receiptId, total, productCount) {
        const endpoint = `receipts/${receiptId}`;
        let active = false;
        let data = {total, productCount, active};

        return remote.update('appdata', endpoint, 'kinvey', data);
    }

    return {
        getActiveReceipt,
        createReceipt,
        getMyReceipts,
        receiptDetails,
        commitReceipt
    }
})();