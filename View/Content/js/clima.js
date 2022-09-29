
var LocalPort = document.getElementById('localhost-port');
var Port = LocalPort.value;

// Componentes:
var CardWeatherComponent = document.getElementById('card-weather-component');
var TableWeatherTRComponent = document.getElementById('table-weather-tr-component');

// Tabelas:
var cidadesMaisQuentesTable = document.getElementById('cidades-mais-quentes');
var cidadesMaisFriasTable = document.getElementById('cidades-mais-frias');

// Cidade
var cidadeNome = document.getElementById('cidade-nome');
var CitysSelect = document.getElementById('cidades-select');

// Container:
var climatesContainer = document.getElementById('climates-container');

// Listas:
var Citys = [];


window.addEventListener('DOMContentLoaded', async (e) => {

    await ObterCidades();
    ObterCidadesMaisQuentes();
    ObterCidadesMaisFrias();

});


async function ObterCidades() {

    CitysSelect.innerHTML = '<option selected desabled>Carregando...</option>';

    try {
        const response = await Request('GET', `https://localhost:${Port}/cidades`);
        Citys = Array.isArray(response.Result) ? response.Result : [];
        await RenderizarListaDeCidades();
    }
    catch (e) {

    }

}


function RenderizarListaDeCidades() {
    return new Promise((resolve) => {

        CitysSelect.innerHTML = '';

        const emptyOption = document.createElement('option');
        emptyOption.value = -1;
        emptyOption.setAttribute('selected', 'selected');
        emptyOption.setAttribute('disabled', 'disabled');
        emptyOption.innerHTML = 'Selecionar Cidade...';
        CitysSelect.appendChild(emptyOption);

        Citys.forEach(city => {
            const option = document.createElement('option');
            option.value = city.Id;
            option.innerHTML = city.Nome;
            CitysSelect.appendChild(option);
        });

        resolve();

    });
}


async function ObterCidadesMaisQuentes() {
    return new Promise(async (resolve, reject) => {

    });
}


async function ObterCidadesMaisFrias() {
    return new Promise(async (resolve, reject) => {

    });
}


async function RenderizarCidadesExtremas(list = [], table = HTMLElement) {
    return new Promise(async (resolve, reject) => {

    });
}





async function ObterPrevisao(cidadeId) {
    return new Promise(async (resolve, reject) => {

    });
}


async function RenderizarPrevisao(list = []) {
    return new Promise(async (resolve, reject) => {

    });
}


CitysSelect.onchange = function () {
    const id = CitysSelect.value;
    ObterPrevisao(id);
}



async function Request(method = 'GET', url = '', data = null) {
    return new Promise(async (resolve, reject) => {

        const xhr = new XMLHttpRequest();
        xhr.open(method, url, true);
        xhr.send(method == 'GET' ? null : (data ? JSON.stringify(data) : null));
        xhr.onreadystatechange = (e) => {
            if (xhr.readyState != xhr.DONE) { return }
            const data = xhr.responseText;
            if (xhr.status === 200) {
                const res = JSON.parse(data);
                resolve(res);
            } else {
                reject();
            }
        }

    });
} 