$(document).ready(function () {
    $('#resultContainer').hide();
    $('#BinaryString').on('keypress', function (e) {
        var charCode = e.which ? e.which : e.keyCode;
        if (charCode !== 48 && charCode !== 49) {
            e.preventDefault();  // Prevent any character other than 0 or 1
        }
    });

    $('#BinaryString').on('keyup', function (e) {
        if ($('#BinaryString').val().length === 0) {
            $('#resultContainer').hide(); // Hide result container if empty
        }
    });

    $('#binaryForm').submit(function (e) {
        e.preventDefault();
        $('#resultContainer').fadeIn(300).show();
        var binaryString = $('#BinaryString').val();
        // Validate binary input
        if (!/^[01]+$/.test(binaryString)) {
            $('#result').removeClass('alert-success').addClass('alert-danger').text("Binary string can't be empty!");
            return;
        }
        
        $.ajax({
            url: '/Binary/CheckBinaryString',
            type: 'POST',
            data: $(this).serialize(),
            success: function (result) {
                $('#result').hide();
                // Check result validity
                if (result.IsValidString !== undefined) {
                    if (result.IsValidString) {
                        $('#result').removeClass('alert-danger').addClass('alert-success').text('Valid binary string.').fadeIn(300);
                    } else {
                        $('#result').removeClass('alert-success').addClass('alert-danger').text('Invalid binary string.').fadeIn(300);
                    }
                } else {
                    $('#result').removeClass('alert-success').addClass('alert-danger').text('Invalid binary string.').fadeIn(300);
                }
            },
            error: function () {
                // Handle request error
                $('#result').removeClass('alert-success').addClass('alert-danger').text('An error occurred while processing your request.').fadeIn(500);
            }
        });
    });
});