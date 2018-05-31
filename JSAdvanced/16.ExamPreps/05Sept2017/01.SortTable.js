function sort(colIndex, descending) {
    let orig = $('table tbody');
    let sortedRows;
    if (colIndex === 0) {
        if (descending) {
            sortedRows = $('table tbody tr')
                .sort(function (a, b) {
                    return $($(b).children()[0]).text().localeCompare($($(a).children()[0]).text());
                });
        } else {
            sortedRows = $('table tbody tr')
                .sort(function (a, b) {
                    return $($(a).children()[0]).text().localeCompare($($(b).children()[0]).text());
                });
        }
    } else {
        if (descending) {
            sortedRows = $('table tbody tr')
                .sort(function (a, b) {
                    return $($(b).children()[1]).text() - $($(a).children()[1]).text();
                });
        } else {
            sortedRows = $('table tbody tr')
                .sort(function (a, b) {
                    return $($(a).children()[1]).text() - $($(b).children()[1]).text();
                });
        }
    }

    orig.append(sortedRows);
}