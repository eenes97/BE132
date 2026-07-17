// Callback: bir fonksiyonu başka bir fonksiyona parametre olarak gönderilme işlemidir. (Gönderdiğimiz fonksiyon callback fonksiyonu olarak isimlendirilir)

function topla(s1, s2){
    return s1 + s2;
}

const cikar = function(s1, s2){
    return s1 - s2;
}

const bol = (s1, s2) => {

    if(s2 === 0){
        console.error("Sıfıra bölme hatası!");
        return null; 
    }

    return s1 / s2;
}

// const carp = (s1, s2)=> {
//     return s1 * s2;
// }


const carp = (s1, s2) => s1 * s2;


function islemYap(islem, sayi1, sayi2){
    const sonuc = islem(sayi1, sayi2);

    if(sonuc !== null){
        console.log("Sonuç:", sonuc);
    }
}

islemYap(topla, 7, 3); // Sonuç: 10
islemYap(cikar, 7, 3); // Sonuç: 4
islemYap(bol, 7, 3); // Sonuç: 2.33
islemYap(bol, 7, 0); // Sıfıra bölme hatası!
islemYap(carp, 7, 3); // Sonuç: 21

