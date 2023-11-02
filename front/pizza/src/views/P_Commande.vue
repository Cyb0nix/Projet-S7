<template>
  <div class="commande-container">
    <img src="../assets/pizza4.jpg" alt="Image d'accueil" class="home-image">
    <h1>Gestion des Clients</h1>

    <!-- Formulaire pour ajouter un client -->
    <div class="add-client-form">
      <h2>Ajouter un Client</h2>
      <form @submit.prevent="ajouterClient">
        <div class="form-group">
          <label for="nom">Nom:</label>
          <input type="text" id="nom" v-model="nouveauClient.nom" required placeholder="Entrez le nom">
        </div>
        <div class="form-group">
          <label for="prenom">Prénom:</label>
          <input type="text" id="prenom" v-model="nouveauClient.prenom" required placeholder="Entrez le prénom">
        </div>
        <div class="form-group">
          <label for="telephone">Numéro de téléphone:</label>
          <input type="text" id="telephone" v-model="nouveauClient.telephone" required placeholder="Entrez le numéro de téléphone">
        </div>
        <button type="submit">Ajouter</button>
      </form>
    </div>

    <!-- Liste des clients présents -->
    <h2>Clients Présents</h2>
    <div class="form-group">
          <label for="recherche">rechercher:</label>
          <input type="text" id="recherche" required placeholder="rechercher">
        </div>
        <button type="submit">valider</button>
    <ul>
      <li v-for="(client, index) in clients" :key="index">
        {{ client.nom }} {{ client.prenom }} - {{ client.telephone }}
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  name: "GestionClients",
  data() {
    return {
      nouveauClient: {
        nom: "",
        prenom: "",
        telephone: "",
      },
      clients: [],
    };
  },
  methods: {
    ajouterClient() {
      this.clients.push({ ...this.nouveauClient });
      // Réinitialiser le formulaire
      this.nouveauClient.nom = "";
      this.nouveauClient.prenom = "";
      this.nouveauClient.telephone = "";
    },
  },
};
</script>

<style scoped>
/* Style de la page de gestion des clients */
.commande-container {
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
}

/* Style du formulaire */
.add-client-form {
  margin-top: 20px;
  width: 100%;
  max-width: 400px;
}

.form-group {
  margin-bottom: 10px;
}

form input {
  width: 100%;
  padding: 10px;
  border: 1px solid #007BFF;
  border-radius: 4px;
  color: #007BFF;
  font-size: 16px;
}

button {
  background-color: #007BFF;
  color: #fff;
  border: none;
  border-radius: 4px;
  padding: 10px 20px;
  cursor: pointer;
  font-size: 16px;
  margin-top: 10px;
}

button:hover {
  background-color: #0056b3;
}

ul {
  list-style-type: none;
  padding: 0;
  width: 100%;
  max-width: 400px;
}

li {
  margin: 5px 0;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 4px;
  background-color: #f1f1f1;
  text-align: left;
  font-size: 16px;
}
</style>
