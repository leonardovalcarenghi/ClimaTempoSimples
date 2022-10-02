var Total = 3;
var States = [];
var Cities = [];
var HottestCities = [];
var ColderCities = [];

var CitiesSelect = document.getElementById('cities-select');

var HottestCitiesJumbotron = document.getElementById('hottest-cities-jumbotron');
var HottestCitiesLoading = document.getElementById('hottest-cities-loading');
var HottestCitiesError = document.getElementById('hottest-cities-error');
var HottestCitiesTable = document.getElementById('hottest-cities-table');

var ColderCitiesJumbotron = document.getElementById('colder-cities-jumbotron');
var ColderCitiesLoading = document.getElementById('colder-cities-loading');
var ColderCitiesError = document.getElementById('colder-cities-error');
var ColderCitiesTable = document.getElementById('colder-cities-table');

window.addEventListener('DOMContentLoaded', async (e) => {

    States = await GetStates();
    Cities = await GetCities();
    RenderCities();

    GetHottestCities();
    GetColderCities();

});


// Renderizar Cidades //
function RenderCities() {

    CitiesSelect.innerHTML = '';
    $(CitiesSelect).append('<option value="-1" selected disabled>Selecionar Cidade...</option>');

    States.forEach(state => {
        $(CitiesSelect).append(`<optgroup label="${state.Name}">${state.Name}</optgroup>`);
        const cities = Cities.filter(city => city.StateID == state.ID);
        cities.forEach(city => { $(CitiesSelect).append(`<option value="${city.ID}">${city.Name}</option>`); });
    });

    CitiesSelect.removeAttribute('disabled');

}

// Buscar Cidades Mais Quentes //
async function GetHottestCities() {
    try {
        $(HottestCitiesLoading).show();
        $(HottestCitiesError).hide();

        const response = await Request('GET', `${API}/weather/hottest-cities?total=${Total}`);
        HottestCities = Array.isArray(response) ? response : [];
        RenderHottestCities();

    }
    catch (error) {
        console.error('ERRO AO BUSCAR LISTA DE CIDADES MAIS QUENTES DO DIA', error);
        ErrorNotification(error.Message || 'Não foi possível buscar a lista de cidades mais quentes.', 'Erro ao Buscar Lista de Cidades Quentes');
        $(HottestCitiesLoading).hide();
        $(HottestCitiesError).show();
    }
}

// Buscar Cidades Mais Frias //
async function GetColderCities() {
    try {
        $(ColderCitiesLoading).show();
        $(ColderCitiesError).hide();

        const response = await Request('GET', `${API}/weather/colder-cities?total=${Total}`);
        ColderCities = Array.isArray(response) ? response : [];
        RenderColderCities();

    }
    catch (error) {
        console.error('ERRO AO BUSCAR LISTA DE CIDADES MAIS FRIAS DO DIA', error);
        ErrorNotification(error.Message || 'Não foi possível buscar a lista de cidades mais frias.', 'Erro ao Buscar Lista de Cidades Frias');
        $(ColderCitiesLoading).hide();
        $(ColderCitiesError).show();
    }
}


// Renderizar Cidades Mais Quentes //
function RenderHottestCities() {

    const tbody = HottestCitiesTable.querySelector('tbody');
    tbody.innerHTML = '';

    HottestCities.forEach(weather => {

        const tr = document.createElement('tr');

        const td1 = document.createElement('td');
        td1.innerHTML = `<i class="${weather.Icon} mr-2" title="${weather.Description}"></i> ${weather.City}/${weather.StateAbbreviation}`;
        tr.appendChild(td1);

        const td2 = document.createElement('td');
        td2.setAttribute('class', 'td-weather-min');
        td2.innerHTML = `${weather.Min}ºC`;
        tr.appendChild(td2);

        const td3 = document.createElement('td');
        td3.setAttribute('class', 'td-weather-max');
        td3.innerHTML = `${weather.Max}ºC`;
        tr.appendChild(td3);

        tbody.appendChild(tr);

    });

    $(HottestCitiesLoading).hide();
    $(HottestCitiesError).hide();

}

// Renderizar Cidades Mais Frias //
function RenderColderCities() {

    const tbody = ColderCitiesTable.querySelector('tbody');
    tbody.innerHTML = '';

    ColderCities.forEach(weather => {

        const tr = document.createElement('tr');

        const td1 = document.createElement('td');
        td1.innerHTML = `<i class="${weather.Icon} mr-2" title="${weather.Description}"></i> ${weather.City}/${weather.StateAbbreviation}`;
        tr.appendChild(td1);

        const td2 = document.createElement('td');
        td2.setAttribute('class', 'td-weather-min');
        td2.innerHTML = `${weather.Min}ºC`;
        tr.appendChild(td2);

        const td3 = document.createElement('td');
        td3.setAttribute('class', 'td-weather-max');
        td3.innerHTML = `${weather.Max}ºC`;
        tr.appendChild(td3);

        tbody.appendChild(tr);

    });

    $(ColderCitiesLoading).hide();
    $(ColderCitiesError).hide();

}