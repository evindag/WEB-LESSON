// ID Seçicisi
const baslik = document.getElementById("baslik");
baslik.style.color = "blue"; // Başlık rengini mavi yap

// Sınıf Seçicisi
const metinler = document.getElementsByClassName("metin");
for (let i = 0; i < metinler.length; i++) {
    metinler[i].style.fontWeight = "bold"; // Paragrafları kalın yap
}

// Etiket Seçicisi
const listeOgeleri = document.getElementsByTagName("li");
for (let i = 0; i < listeOgeleri.length; i++) {
    listeOgeleri[i].style.listStyleType = "circle"; // Liste öğelerine daire işareti ekle
}

// Özel ID Seçicisi
const ozelOge = document.getElementById("ozel-oge");
ozelOge.style.backgroundColor = "yellow"; // Özel öğenin arka planını sarı yap

// Düğme Etkinliği
const buton = document.getElementById("buton");
buton.addEventListener("click", function() {
    alert("Düğmeye tıklandı!");
});