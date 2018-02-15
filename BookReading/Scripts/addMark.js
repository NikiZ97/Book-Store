$('.like-btn-1').click(function () {
    var bookId = $(this).data('book');
    var mark = $('.mark');
    var heard = $(this);
    $.post({
        'url': '/Book/AddMark',
        'data': { bookId: bookId,
            mark: 1},
        'success': function () {
            mark.text(1);
            heard.css({'color' : 'red'});
            $('.like-btn-2').css({'color' : 'black'});
            $('.like-btn-3').css({'color' : 'black'});
            $('.like-btn-4').css({'color' : 'black'});
            $('.like-btn-5').css({'color' : 'black'});
        }
    });
});

$('.like-btn-2').click(function () {
    var bookId = $(this).data('book');
    var mark = $('.mark');
    var heard = $(this);
    $.post({
        'url': '/Book/AddMark',
        'data': { bookId: bookId,
            mark: 2},
        'success': function () {
            mark.text(2);
            heard.css({'color' : 'red'});
            $('.like-btn-1').css({'color' : 'black'});
            $('.like-btn-3').css({'color' : 'black'});
            $('.like-btn-4').css({'color' : 'black'});
            $('.like-btn-5').css({'color' : 'black'});
        }
    });
});

$('.like-btn-3').click(function () {
    var bookId = $(this).data('book');
    var mark = $('.mark');
    var heard = $(this);
    $.post({
        'url': '/Book/AddMark',
        'data': { bookId: bookId,
            mark: 3},
        'success': function () {
            mark.text(3);
            heard.css({'color' : 'red'});
            $('.like-btn-2').css({'color' : 'black'});
            $('.like-btn-1').css({'color' : 'black'});
            $('.like-btn-4').css({'color' : 'black'});
            $('.like-btn-5').css({'color' : 'black'});
        }
    });
});

$('.like-btn-4').click(function () {
    var bookId = $(this).data('book');
    var mark = $('.mark');
    var heard = $(this);
    $.post({
        'url': '/Book/AddMark',
        'data': { bookId: bookId,
            mark: 4},
        'success': function () {
            mark.text(4);
            heard.css({'color' : 'red'});
            $('.like-btn-2').css({'color' : 'black'});
            $('.like-btn-3').css({'color' : 'black'});
            $('.like-btn-1').css({'color' : 'black'});
            $('.like-btn-5').css({'color' : 'black'});
        }
    });
});

$('.like-btn-5').click(function () {
    var bookId = $(this).data('book');
    var mark = $('.mark');
    var heard = $(this);
    $.post({
        'url': '/Book/AddMark',
        'data': { bookId: bookId,
            mark: 5},
        'success': function () {
            mark.text(5);
            heard.css({'color' : 'red'});
            $('.like-btn-2').css({'color' : 'black'});
            $('.like-btn-3').css({'color' : 'black'});
            $('.like-btn-4').css({'color' : 'black'});
            $('.like-btn-1').css({'color' : 'black'});
        }
    });
});