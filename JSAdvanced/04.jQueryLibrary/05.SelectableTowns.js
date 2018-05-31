function attachEvents() {
    $('ul#items').children().on('click', function () {
        let li = $(this);
        if(li.attr('data-selected')) {
            $(this).removeAttr('data-selected');
            $(this).css('background-color', '');
        } else {
            $(this).attr('data-selected', 'true');
            $(this).css('background-color', '#DDD');
        }
    });

    $('#showTownsButton').click(function () {
        let result = [];

        $('#items li[data-selected=true]').each((i, e) => {
            result.push($(e).text());
        });

        $('#selectedTowns').text(`Selected towns: ${result.join(', ')}`);
    })
}