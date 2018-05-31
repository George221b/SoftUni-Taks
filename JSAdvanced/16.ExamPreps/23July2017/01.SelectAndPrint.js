function move(command) {
    function moveRight() {
        let townName = $('#available-towns').find(':selected').text()
        $('#available-towns').find(':selected').remove()
        $('<option>').text(townName).appendTo($('#selected-towns'))
    }
    function moveLeft() {
        let townName = $('#selected-towns').find(':selected').text()
        $('#selected-towns').find(':selected').remove()
        $('<option>').text(townName).appendTo($('#available-towns'))
    }
    function printSelected() {
        let selected = $('#selected-towns').children().toArray().map(o => o.textContent).join('; ')
        $('#output').text(selected)
    }
    switch (command) {
        case 'right': moveRight(); break
        case 'left': moveLeft(); break
        case 'print': printSelected(); break
    }
}