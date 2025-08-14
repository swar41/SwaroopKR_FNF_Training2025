const encryptor = "the quick brown fox jumps the lazy dog";
const splitWords = encryptor.split(" ");

function encrypt() {
    const input = document.getElementById("word").value.trim().toLowerCase();
    let res = "";

    for (let c of input) {
        let found = false;
        for (let wi = 0; wi < splitWords.length; wi++) {
            let temp = splitWords[wi];
            for (let i = 0; i < temp.length; i++) {
                if (temp[i] === c) {
                    res += wi + "" + i + " ";
                    found = true;
                    break;
                }
            }
            if (found) break;
        }
    }

    document.getElementById("output").textContent = res.trim();
}

window.addEventListener("load", function () {
    document.getElementById("encryptBtn").addEventListener("click", encrypt);
});
