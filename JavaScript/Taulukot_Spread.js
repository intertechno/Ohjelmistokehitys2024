const fruits = ["omena", "banaani", "appelsiini"];
const vegetables = ["pinaatti", "porkkana", "peruna"];

yhdistelmä = [...fruits, ...vegetables];
console.log(yhdistelmä);
/*
yhdistelmä = [];
for (let i = 0; i < fruits.length; i++) {
    const hedelmä = fruits[i];
    yhdistelmä.push(hedelmä);
}
for (let i = 0; i < vegetables.length; i++) {
    const vihannes = vegetables[i];
    yhdistelmä.push(vihannes);
}
*/
