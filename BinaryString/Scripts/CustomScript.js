$(document).ready(function () {
    $('#binaryForm').submit(function (e) {
        e.preventDefault();

        // Optional client-side validation for binary input
        var binaryString = $('#BinaryString').val();
        if (!/^[01]+$/.test(binaryString)) {
            $('#result').removeClass('alert-info').addClass('alert-danger').text('Invalid input: Only 0 and 1 are allowed.');
            return;
        }

        $.ajax({
            url: '/Binary/CheckBinaryString',
            type: 'POST',
            data: $(this).serialize(),
            success: function (result) {
                if (result.IsGood !== undefined) {
                    $('#result').removeClass('alert-danger').addClass('alert-success').text('Is Good: ' + result.IsGood);
                } else {
                    $('#result').removeClass('alert-info').addClass('alert-danger').text('Invalid binary string.');
                }
            },
            error: function () {
                $('#result').removeClass('alert-info').addClass('alert-danger').text('An error occurred while processing your request.');
            }
        });
    });
});