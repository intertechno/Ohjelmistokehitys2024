/*
function add(a, b) {
    return a + b;
}
*/
addFunc = (a, b) => a + b;

/*
const myObject = {
    value: 10,
    multiply: function (n) {
        setTimeout(function () {
            console.log(this.value * n);
        }.bind(this), 500);
    }
};
*/

const myObject = {
    value: 10,
    multiply: function (n) {
        setTimeout(() => console.log(this.value * n), 5000);
    }
};

// odota näppäinpainallusta poistuaksesi
process.stdin.resume();
process.stdin.setEncoding("utf8");
process.stdin.setRawMode(true);

process.stdin.on("data", (key) => {
    console.log("Poistutaan sovelluksesta.");
    process.exit();
});

process.on("exit", () => {
  process.stdin.setRawMode(false);
  process.stdin.pause();
});

console.log(addFunc(12, 34));
myObject.multiply(7);

console.log("Paina mitä tahansa näppäintä poistuaksesi...");