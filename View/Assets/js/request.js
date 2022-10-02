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

                if (res.Error) {
                    reject(res);
                } else
                    if (res.Result) {
                        resolve(res.Result);
                    } else {
                        resolve(res);
                    }
            } else {
                reject();
            }
        }

    });
} 