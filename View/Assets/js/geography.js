/**
 * Buscar Estados 
 */
async function GetStates() {
    try {
        const response = await Request('GET', `${API}/geography/states`);
        const states = Array.isArray(response) ? response : [];
        return states;
    }
    catch (error) {
        console.error('ERRO AO BUSCAR LISTA DE ESTADOS', error);
        ErrorNotification(error.Message || 'Não foi possível buscar a lista de estados.', 'Erro ao Buscar Lista de Estados');
    }
}

/**
 * Buscar Cidades 
 */
async function GetCities() {
    try {
        const response = await Request('GET', `${API}/geography/cities`);
        const cities = Array.isArray(response) ? response : [];
        return cities;
    }
    catch (error) {
        console.error('ERRO AO BUSCAR LISTA DE CIDADES', error);
        ErrorNotification(error.Message || 'Não foi possível buscar a lista de cidades.', 'Erro ao Buscar Lista de Cidades');
    }
}