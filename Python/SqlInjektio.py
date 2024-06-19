name = input('Anna käyttäjän nimi jota haetaan: ')
query = f"SELECT * FROM users WHERE name = '{name}'"

print(query)
