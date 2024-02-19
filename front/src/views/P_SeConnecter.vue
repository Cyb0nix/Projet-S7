<template>
  <div class="signup-page">
    <div class="signup-container">
      <h1>Inscription</h1>
      <form>
        <div class="form-group">
          <label for="username">Nom d'utilisateur</label>
          <input type="text" id="username" placeholder="Entrez votre nom d'utilisateur" required>
        </div>
        <div class="form-group">
          <label for="email">Adresse e-mail</label>
          <input type="email" id="email" placeholder="Entrez votre adresse e-mail" required>
        </div>
        <div class="form-group">
          <label for="password">Mot de passe</label>
          <input type="password" id="password" placeholder="Entrez votre mot de passe" required>
        </div>
        <div class="form-group">
          <label for="confirm-password">Confirmez le mot de passe</label>
          <input type="password" id="confirm-password" placeholder="Confirmez votre mot de passe" required>
        </div>
        <button class="signup-button" type="submit">S'inscrire</button>
      </form>
    </div>
  </div>
</template>
<style scoped>
.signup-page {
  background-image: url("../assets/connexion.jpg");
  background-size: cover;
  background-position: center;
  height: 100vh;
  display: flex;
  margin-left: 15%;
  margin-right: 15%;
  margin-top: 5%;
  align-items: center;
  justify-content: center;
}

.signup-container {
  background-color: rgba(255, 255, 255, 0.9);
  border-radius: 10px;
  padding: 20px;
  text-align: center;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
  max-width: 400px;
  width: 100%;
}

.signup-container h1 {
  font-size: 24px;
  margin-bottom: 20px;
  color: #333;
}

.form-group {
  margin-bottom: 20px;
}

form label {
  display: block;
  font-weight: bold;
  text-align: left;
  margin-bottom: 5px;
  color: #555;
}

form input {
  width: 100%;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 5px;
}

.signup-button {
  background-color: #007BFF;
  color: #fff;
  border: none;
  border-radius: 5px;
  padding: 10px 20px;
  font-size: 16px;
  cursor: pointer;
  transition: background-color 0.3s;
}

.signup-button:hover {
  background-color: #0056b3;
}
</style>

