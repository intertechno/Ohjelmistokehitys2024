class Auto {
    merkki;
    malli;
    huippunopeus;

    nopeus = 0;
    moottoriKäynnissä = false;

    /*
    constructor(merkki) {
      this.merkki = merkki;
    }
    */

    startEngine() {
        this.moottoriKäynnissä = true;
    }

    stopEngine() {
        this.moottoriKäynnissä = false;
    }
    
    accelerate() {
        if (moottoriKäynnissä) {
            this.nopeus += 10;
        }
    }
    
    decelerate() {
        if (moottoriKäynnissä) {
            this.nopeus -= 10;

            if (this.nopeus < 0) {
                this.nopeus = 0;
            }
        }
    }
}


// esimerkki luokan käytöstä
const omaAuto = new Auto();
omaAuto.merkki = "Toyota";
omaAuto.merkki = "Corolla";
omaAuto.huippunopeus = 180;
omaAuto.startEngine();

const naapurinAuto = new Auto();
naapurinAuto.merkki = "Porsche";
naapurinAuto.merkki = "Taycan";
naapurinAuto.huippunopeus = 250;
naapurinAuto.startEngine();
