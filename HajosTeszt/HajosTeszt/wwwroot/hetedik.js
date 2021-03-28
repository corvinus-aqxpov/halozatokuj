window.onload = () => {
    letöltésBefejeződött();
}
var kérdések;
var kérdésszám;

    fetch('/questions.json')
        .then(response => response.json())
        .then(data => letöltésBefejeződött(data)
        );
    
    function letöltésBefejeződött(d) {
        console.log("Sikeres letöltés")
        console.log(d)
        kérdések = d;
        kérdésMegjelenítés(0);
    }
    function kérdésMegjelenítés(k) {
        let ide_kerdes = document.getElementById("kérdés_szöveg.txt")
        kérdések.innerText = kérdések[k].questionText;
        for (var i = 1; i <= 3; i++) {
            document.getElementById(kérdések);
        }
        document.getElementById("kép1").src = "https://szoft1.comeback.hu/hajo/" + kérdések[k].image;
}


function Előző() {
    if (kérdésszám == 0) {
        kérdésszám = kérdések.lenght - 1;
        letöltésBefejeződött();
    }
    else {
        kérdésszám--;
        letöltésBefejeződött();
    }
}

function Következő() {
    if (kérdésszám == kérdések.length - 1) {
        kérdésszám = 0;
        letöltésBefejeződött();
    }
    else {
        kérdésszám++;
        letöltésBefejeződött();
    }
}