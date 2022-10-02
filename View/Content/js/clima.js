﻿
var LocalPort = document.getElementById('localhost-port');
var Port = LocalPort.value;


// Listas:
var Estados = [];
var Cidades = [];
var CidadesMaisQuentes = [];
var CidadesMaisFrias = [];

// Componentes:
var ListaDeCidades = document.getElementById('cidades-select');
var CardWeatherComponent = document.getElementById('card-weather-component');

// Cidade
var tituloPrevisao = document.getElementById('titulo-previsao');
var cidadeNome = document.getElementById('cidade-nome');


// Container:
var PainelDePrevisoes = document.getElementById('climates-container');


// Cidades Mais Quentes:
var Tabela_CidadesMaisQuentes = document.getElementById('cidades-mais-quentes');
var Loading_MaisQuentes = document.getElementById('loading-mais-quentes');
var Error_MaisQuentes = document.getElementById('error-mais-quentes');


// Cidades Mais Frias:
var Tabela_CidadesMaisFrias = document.getElementById('cidades-mais-frias');
var Loading_MaisFrias = document.getElementById('loading-mais-frias');
var Error_MaisFrias = document.getElementById('error-mais-frias');

window.addEventListener('DOMContentLoaded', async (e) => {

    await ObterEstados();
    await ObterCidades();

    ObterCidadesMaisQuentes();
    ObterCidadesMaisFrias();

});


async function ObterEstados() {

    ListaDeCidades.innerHTML = '<option selected desabled>Carregando...</option>';

    try {
        const response = await Request('GET', `https://localhost:${Port}/estados`);
        Estados = Array.isArray(response.Result) ? response.Result : [];
    }
    catch (error) {
        console.error('ERRO AO BUSCAR ESTADOS', error);
    }

}

async function ObterCidades() {

    ListaDeCidades.innerHTML = '<option selected desabled>Carregando...</option>';

    try {
        const response = await Request('GET', `https://localhost:${Port}/cidades`);
        Cidades = Array.isArray(response.Result) ? response.Result : [];
        await RenderizarListaDeCidades();
    }
    catch (error) {
        console.error('ERRO AO BUSCAR CIDADES', error);
    }

}


function RenderizarListaDeCidades() {
    return new Promise((resolve) => {

        ListaDeCidades.innerHTML = '';

        const emptyOption = document.createElement('option');
        emptyOption.value = -1;
        emptyOption.setAttribute('selected', 'selected');
        emptyOption.setAttribute('disabled', 'disabled');
        emptyOption.innerHTML = 'Selecionar Cidade...';
        ListaDeCidades.appendChild(emptyOption);


        Estados.forEach(estado => {
            const optgroup = document.createElement('optgroup');
            optgroup.innerHTML = estado.Nome;
            optgroup.setAttribute('label', estado.Nome);
            ListaDeCidades.appendChild(optgroup);

            const cidades = Cidades.filter(cidade => cidade.EstadoId == estado.Id);
            cidades.forEach(cidade => {
                const option = document.createElement('option');
                option.value = cidade.Id;
                option.innerHTML = cidade.Nome;
                ListaDeCidades.appendChild(option);
            });

        });



        resolve();

    });
}


async function ObterCidadesMaisQuentes() {
    try {
        Loading_MaisQuentes.style.display = 'flex';
        const response = await Request('GET', `https://localhost:${Port}/climas/mais-quentes`);
        CidadesMaisQuentes = Array.isArray(response.Result) ? response.Result : [];
        await RenderizarCidadesExtremas(CidadesMaisQuentes, Tabela_CidadesMaisQuentes);
        Loading_MaisQuentes.style.display = 'none';
    }
    catch (error) {
        console.error('ERRO AO BUSCAR CIDADES MAIS QUENTES', error);
        Loading_MaisQuentes.style.display = 'none';
        Error_MaisQuentes.style.display = 'flex';

    }
}


async function ObterCidadesMaisFrias() {
    try {
        Loading_MaisFrias.style.display = 'flex';
        const response = await Request('GET', `https://localhost:${Port}/climas/mais-frias`);
        CidadesMaisFrias = Array.isArray(response.Result) ? response.Result : [];
        await RenderizarCidadesExtremas(CidadesMaisFrias, Tabela_CidadesMaisFrias);
        Loading_MaisFrias.style.display = 'none';
    }
    catch (error) {
        console.error('ERRO AO BUSCAR CIDADES MAIS FRIAS', error);
        Loading_MaisFrias.style.display = 'none';
        Error_MaisFrias.style.display = 'flex';
    }
}


async function RenderizarCidadesExtremas(list = [], table = HTMLElement) {
    return new Promise(async (resolve) => {

        table.querySelector('tbody').innerHTML = '';

        list.forEach(clima => {

            const tr = document.createElement('tr');

            const td1 = document.createElement('td');
            td1.innerHTML = `${clima.Cidade}/${clima.UF}`;
            tr.appendChild(td1);

            const td2 = document.createElement('td');
            td2.setAttribute('class', 'td-weather-min');
            td2.innerHTML = `${clima.TemperaturaMinima}ºC`;
            tr.appendChild(td2);

            const td3 = document.createElement('td');
            td3.setAttribute('class', 'td-weather-max');
            td3.innerHTML = `${clima.TemperaturaMaxima}ºC`;
            tr.appendChild(td3);

            table.querySelector('tbody').appendChild(tr);

        });

        resolve();

    });
}





async function ObterPrevisao(cidadeId) {

    try {
        const response = await Request('GET', `https://localhost:${Port}/previsao?cidade=${cidadeId}`);
        const list = Array.isArray(response.Result) ? response.Result : [];
        RenderizarPrevisao(list);
    }
    catch (error) {
        console.error('ERRO AO BUSCAR PREVISAO PARA A CIDADE SELECIONADA', error);
    }

}


async function RenderizarPrevisao(list = []) {
    return new Promise(async (resolve, reject) => {

    });
}


ListaDeCidades.onchange = function () {
    const id = ListaDeCidades.value;
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