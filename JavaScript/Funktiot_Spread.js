function tulosta(a, b, c)
{
    console.log(`A = ${a}`);
    console.log(`B = ${b}`);
    console.log(`C = ${c}`);
}

luvut = [1, 2, 3];
// tulosta(luvut[0], luvut[1], luvut[2]);
tulosta(...luvut);
