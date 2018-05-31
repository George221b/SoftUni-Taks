function extractText() {
    let result = [];
    let text = $('ul#items').children().each(
        (index, element) => result.push($(element).text())
    );

    $('#result').text(result.join(', '));
}