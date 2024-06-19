process.env.NODE_TLS_REJECT_UNAUTHORIZED = "0";

fetch('https://localhost:7114/WeatherForecast')
  .then(response => response.json())
  .then(json => {
    // console.log(json);
    for (let i = 0; i < json.length; i++) {
      const ennuste = json[i];
      console.log(`Pvm: ${ennuste.date}, lämpötila: ${ennuste.temperatureC}`);
    }
  });
