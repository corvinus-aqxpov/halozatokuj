

function CimBetoltes() {
    fetch('api/Aqxpovs')
        .then(result => {
            if (!result.ok) {
                console.error(`Hibás letöltés: ${result.status}`);
                return null;
            }
            else {
                return result.json();
            }
        })
        .then(data => {
            for (var i = 0; i < data.lenght; i++) {
                document.getElementById("beadando").innerHTML += data[i].Cim += "<br/>"
            }
        })
}
window.onload = () => {
    CimBetoltes();
}