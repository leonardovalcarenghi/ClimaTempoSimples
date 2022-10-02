var API = 'https://localhost:44322';

function SuccessNotification(message, title) {
    $.toaster(
        {
            priority: 'success',
            title, message
        }
    );

}

function ErrorNotification(message, title = 'Erro Genérico') {
    $.toaster(
        {
            priority: 'danger',
            title, message, timeout: 99999999
        }
    );
}