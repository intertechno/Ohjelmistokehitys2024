fetch('https://jsonplaceholder.typicode.com/users')
      .then(response => response.json())
      .then(json => {
        // console.log(json);
        for (let i = 0; i < json.length; i++) {
            const käyttäjä = json[i];
            console.log(käyttäjä.name);
        }
       });
