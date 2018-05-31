function search() {
    let search = $('#searchText').val();
    let count = searchInUl(search);

    $('#result').text(`${count} matches found.`);

    function searchInUl(pattern) {
        let count = 0;
        let ul = $('#towns').children().each(
            (index, element) => {
                $(element).css('font-weight', 'normal');

                if($(element).text().search(pattern) !== -1) {
                    console.log(`govni ${$(element).text()}`);

                    $(element).css('font-weight', 'bold');
                    count++;
                }
            }
        );

        return count;
    }
}