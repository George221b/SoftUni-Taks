function result() {
    let reports = [];
    let currentId = 0;
    let currentSortMethod = 'ID';
    let currentOutputSelector;

    function report(author, description, reproducible, severity) {
        let report = {
            ID: currentId++,
            author: author,
            description: description,
            reproducible: reproducible,
            severity: Number(severity),
            status: 'Open'
        };

        reports.push(report);
        this.sort();
        this.output();
    }

    function setStatus(id, newStatus) {
        for (let i in reports) {
            if (reports[i].ID === id) {
                reports[i].status = newStatus;
                break; //Stop this loop, we found it!
            }
        }

        this.output();
    }

    function remove(id) {
        for (let i in reports) {
            if (reports[i].ID === id) {
                reports.splice(i, 1);
                break; //Stop this loop, we deleted it!
            }
        }

        this.output();
    }

    function sort(method) {
        if (method !== undefined) {
            currentSortMethod = method;
        }

        switch (currentSortMethod) {
            case 'ID':
                reports.sort(function (a, b) {
                    return a.ID - b.ID;
                });
                break;
            case 'author':
                reports.sort(function (a, b) {
                    return a.author > b.author;
                });
                break;
            case 'severity':
                reports.sort(function (a, b) {
                    return a.severity - b.severity;
                });
                break;
        }

        this.output();
    }

    function output(selector) {
        if (selector !== undefined) {
            currentOutputSelector = selector;
        }

        $(currentOutputSelector).html(
            reports.map(r =>`<div id="report_${r.ID}" class="report">
  <div class="body">
    <p>${r.description}</p>
  </div>
  <div class="title">
    <span class="author">Submitted by: ${r.author}</span>
    <span class="status">${r.status} | ${r.severity}</span>
  </div>
</div>
`).join('\n')
        );
    }

    return {
        report,
        setStatus,
        remove,
        sort,
        output
    };
}
